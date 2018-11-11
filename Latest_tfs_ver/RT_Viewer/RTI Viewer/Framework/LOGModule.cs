using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Threading;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Text.RegularExpressions;

namespace RT_Viewer.Framework
{
    public class LOGModule : IModule
    {
        /*Note: RTCLogger Folder should be at the same path the EXE application running*/
        public const int RT1_LOGGER_PORT = 8890;
        public const int RT2_LOGGER_PORT = 8891;

        public const string RTC_LOGGER_DIRECTORY = "RTCLogger";
        public const string RTC_LOG_FILE_NAME = "RtcLogger.ini";
        public const string RTC_LOGGER_EXE_NAME = "RtcLogger.exe";
        public const string FRAME_WORK_DIR_NAME = "framework";

        static string m_assembly; 
        static string m_assemblyPath; 
        static string m_rtcLoggerPath; 
        static string m_rtcLogIniFileFullName; 

        public static string frameworkPath; // where the result will be saved
        public static List<string> offlineFolderList;
        public static List<string> onlineFolderList;
        public const int MAX_LINE_PER_SCREEN = 1000;
        public static bool isOfflineSearch = false;
        public static SemaphoreSlim stopSearchMutex = new SemaphoreSlim(0);

        /*Search Background Worker*/
        public BackgroundWorker searchBGWorker; //backGroundWorker for search string and updating shell data
        public static bool isSearchEnded = true;
        /*RTCLOGGER Search Section*/
        public static Process RTCLoggerProc = null;
        public static ProcessStartInfo processInfo;
        public delegate void LOGButtonsEvent(object sender, LogEventArgs data);
        public event LOGButtonsEvent LOGStatusEvent;

        public static Dictionary<int, string> navigationResult; // by given an index key return result file path
        public static Dictionary<int, string> navigationResultFileName; // by given an index key return file path of content search
        public static int MaxNavIndex = 0; // max navigation page achives 
        public static int currentNavIndexPaging = 0; // current navigation page 

        public static bool isRTCLoggerWorking;
        public static Thread RTCLoggerThread;
        public SearchState searchState = SearchState.NONE;

        public string foundedLines;
        public Thread findThread; //the thread that working while searching for string in the log
        Dictionary<string, FilterLevelEntry> FilterDict; // the key is the module name example HST,LOG ETC..

        /*RTCLogger Filter Level Section */
        public BindingList<LogFilteredLevelTable> BL_LogFilteredLevelTable;
        public DataTable LOGLevelFilteredDataTable;

        public DataGridViewTextBoxColumn moduleNameFiltered;
        public DataGridViewComboBoxColumn selectedModeFiltered;
        public DataGridViewComboBoxColumn selectedLevelFiltered;
        public List<string> selectedModeFilteredList;
        public List<string> selectedLevelFilteredList;

        public string RTC1SearchLogContent = "RT1_SearchContent.txt";
        public string RTC2SearchLogContent = "RT2_SearchContent.txt";
        /*RT LOG Level Section */
        public BindingList<LogLevelTable> BL_LogLevelTable;
        public DataTable LOGLevelReportedDataTable;
        public RTLogLevel rtLogLevel;
        public RTLogLevelEntry rtLogLevelEntry;

        public DataGridViewTextBoxColumn moduleId;
        public DataGridViewTextBoxColumn moduleName;
        public DataGridViewComboBoxColumn levelToReport;
        public DataGridViewTextBoxColumn reportedLevel;
        public List<string> levelToReportList;

        public enum SearchState 
        {
            NONE,
            WAITING,
            FINISH
        }
        public enum LOGEventState
        {
            NONE,
            RTCLOGGER_STATUS,
            STARTING_SEARCH,
            END_SEARCH,
            READING_NEW_FILE,
            READING_FILE_SEARCH_STATUS,
            FINISH_RELOAD,
            NOTIFICATION,
            NEED_TO_LOAD_MORE_RESULT,
            FINAL_PAGE_SEARCH
        }
        public enum LOGLevelEnum
        {
            DEBUG_LEVEL = 1,
            INFO_LEVEL,
            WARNING_LEVEL,
            ERROR_LEVEL,
            FATAL_LEVEL
        }

        /*ini file content */
        public static class INIContent
        {
            public static bool isInit;
            public static string numOfRecord;
            public static string logfileDir;
            public static string maxLogLength; // in MB
            public static string multicastIP;
            public static string numOfPort;
            public static string rtc1Port;
            public static string rtc2Port;
            public static string FullnameRTCLoggerApp;
        }

        public class RTLogLevel
        {
            public uint numOfLogModules;
            public RTLogLevelEntry[] LevelEntreis;
        }

        public struct RTLogLevelEntry
        {
            public uint id_module;
            public char module_name1;
            public char module_name2;
            public char module_name3;
            public char module_name4;
            public uint level;
        }

        /* struct of RT LOG Levels */
        public class LogLevelTable
        {
            public string id_module                                  { get; set; }
            public string Module                                     { get; set; }
            public DataGridViewComboBoxColumn SelectedLevelToReport  { get; set; }
            public string ReportedLevel                              { get; set; }
        }

        /* struct of Filter LOG */
        public class LogFilteredLevelTable
        {
            public string ModuleName { get; set; }
            public DataGridViewComboBoxColumn SelectFromOrOnly { get; set; }
            public DataGridViewComboBoxColumn SelectedLevelToReport { get; set; }
        }


        /* struct sending to RT */
        public struct SelectedModuleLogLevel
        {
            public uint numOfModules;
            public ReportedModuleLogLevelEntry[] reportedLogLevels;
        }
        public struct ReportedModuleLogLevelEntry
        {
            public uint module_id;
            public uint selected_level;
        }
       /* for search options*/

        public class FilterLevelEntry
        {
            public string FilterMode_;
            public string selectedLevel_;

            public FilterLevelEntry(string FilterMode, string selectedLevel)
            {
                FilterMode_ = FilterMode;
                selectedLevel_ = selectedLevel;
            }
        }


        public LOGModule(SocketHandler.enumDevice_id deviceID)
        {
            /* Parser INI file*/
            InitModule();
            
            /*Check if RTCLogger is already running*/
            isRTCLoggerAlreadyRunning();

            //find ini file
            if (Directory.Exists(m_rtcLoggerPath) == false)
            {// This path is a directory
                MessageBox.Show("No directory exist with this folder: " + m_rtcLoggerPath + " Exiting ...");
                exitApplication();
            }
            if (File.Exists(m_rtcLogIniFileFullName) == false)
            {// This path is a file
                MessageBox.Show("No ini file exist on this location : " + m_rtcLogIniFileFullName + " Exiting ...");
                exitApplication();
                
            }
            if (File.Exists(m_rtcLoggerPath + "\\" + RTC_LOGGER_EXE_NAME) == false)
            {// This path is a file
                MessageBox.Show("No RTCLogger.exe file exist on this folder : " + m_rtcLoggerPath + " Exiting ...");
                exitApplication();
            }

            rtLogLevel = new RTLogLevel();
            rtLogLevelEntry = new RTLogLevelEntry();

            deviceIdConnected = deviceID;

            /* INIT Repoertd Level Table */
            initReportLevelColumns();

            /*Search BackGroundWorker Events*/
            searchBGWorker = new BackgroundWorker();
            searchBGWorker.WorkerReportsProgress = true;
            searchBGWorker.WorkerSupportsCancellation = true;
            searchBGWorker.DoWork += new DoWorkEventHandler(searchBGWorker_DoWork);
            searchBGWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(searchBGWorker_RunWorkerCompleted);
            searchBGWorker.ProgressChanged += new ProgressChangedEventHandler(searchBGWorker_ProgressChanged);

            navigationResult = new Dictionary<int, string>();
            navigationResultFileName = new Dictionary<int, string>();
        }


        public bool startRTCLogger()
        {
            if (isRTCLoggerWorking == false)
            {
                ExecuteRTCLogger();
                return true;
            }
            else
            {
                MessageBox.Show("RTCLogger already running...");
                return false;
            }   
        }

        public void stopRTCLogeer()
        {
            //Stop RTCLogger
            if (RTCLoggerProc != null)
            {
                if (RTCLoggerProc.HasExited == false)
                {
                    RTCLoggerProc.Kill();
                }
                RTCLoggerProc = null;
                isRTCLoggerWorking = false;
                LOGStatusEvent.Invoke(this, new LogEventArgs()); // update form
            }

        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int remainLength = (int)size;
            int indexReader = 0;
            int length;
            IntPtr ptr;

            rtLogLevel.numOfLogModules = (uint)BitConverter.ToInt32(msg, 0);
            indexReader += Marshal.SizeOf(rtLogLevel.numOfLogModules);
            remainLength -= Marshal.SizeOf(rtLogLevel.numOfLogModules);

            BL_LogLevelTable = new BindingList<LogLevelTable>();
            BL_LogFilteredLevelTable = new BindingList<LogFilteredLevelTable>();

            for (int i = 0; i < rtLogLevel.numOfLogModules; i++)
            {
                length = Marshal.SizeOf(rtLogLevelEntry);
                ptr = Marshal.AllocHGlobal(length);
                Marshal.Copy(msg, indexReader, ptr, length);
                rtLogLevelEntry = (RTLogLevelEntry)Marshal.PtrToStructure(ptr, rtLogLevelEntry.GetType());
                Marshal.FreeHGlobal(ptr);
                indexReader += length;
                remainLength = remainLength - length;


                DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
                var list1 = new List<string>() { "DEBUG", "INFO", "WARNING", "ERROR", "FATAL" };
                cb.DataSource = list1;
                cb.HeaderText = "LEVEL";
                cb.DataPropertyName = "LEVEL";
                cb.ReadOnly = false;


                DataGridViewComboBoxColumn cb1 = new DataGridViewComboBoxColumn();
                var list3 = new List<string>() { "DEBUG", "INFO", "WARNING", "ERROR", "FATAL" };
                cb1.DataSource = list3;
                cb1.HeaderText = "LEVEL";
                cb1.DataPropertyName = "LEVEL";
                cb1.ReadOnly = false;

                DataGridViewComboBoxColumn cbFromOrOnly = new DataGridViewComboBoxColumn();
                var list2 = new List<string>() { "FROM", "ONLY"};
                cbFromOrOnly.DataSource = list2;
                cbFromOrOnly.HeaderText = "From_Only";
                cbFromOrOnly.DataPropertyName = "From_Only";
                cbFromOrOnly.ReadOnly = false;

                try
                {
                    BL_LogLevelTable.Add(new LogLevelTable
                    {
                        id_module = rtLogLevelEntry.id_module.ToString(),
                        Module = rtLogLevelEntry.module_name1.ToString() + rtLogLevelEntry.module_name2.ToString() + rtLogLevelEntry.module_name3.ToString() + rtLogLevelEntry.module_name4.ToString(),
                        SelectedLevelToReport = cb,
                        ReportedLevel = convertLogLevel(rtLogLevelEntry.level),
                    });

                    BL_LogFilteredLevelTable.Add(new LogFilteredLevelTable
                    {
                        ModuleName = rtLogLevelEntry.module_name1.ToString() + rtLogLevelEntry.module_name2.ToString() + rtLogLevelEntry.module_name3.ToString() + rtLogLevelEntry.module_name4.ToString(),
                        SelectFromOrOnly = cb1,
                        SelectedLevelToReport = cbFromOrOnly
                    });
                    
                    initReportLevelColumns();

                    foreach (LogLevelTable logLevelEntry in BL_LogLevelTable)
                    {
                        LOGLevelReportedDataTable.Rows.Add(new object[] { logLevelEntry.id_module.ToString(), logLevelEntry.Module, "ERROR", logLevelEntry.ReportedLevel });
                    }

                    foreach (LogFilteredLevelTable logLeveFilteredlEntry in BL_LogFilteredLevelTable)
                    {
                        LOGLevelFilteredDataTable.Rows.Add(new object[] { logLeveFilteredlEntry.ModuleName.ToString(), "FROM", "DEBUG" });
                    }

                   
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));

            return true;
        }


        private void ExecuteRTCLogger()
        {
            try
            {
                if (Directory.Exists(m_rtcLoggerPath) == false)
                {// This path is a directory

                    throw new ApplicationException("No directory exist with this folder: " + m_rtcLoggerPath);
                }

                if (File.Exists(m_rtcLoggerPath + "\\" + RTC_LOGGER_EXE_NAME) == false)
                {// This path is a file

                    throw new ApplicationException("No file exist with this name : " + RTC_LOGGER_EXE_NAME);
                }

                processInfo = new ProcessStartInfo(INIContent.FullnameRTCLoggerApp);
                processInfo.WorkingDirectory = m_rtcLoggerPath;
                processInfo.FileName = RTC_LOGGER_EXE_NAME;
                processInfo.Arguments = RTC_LOG_FILE_NAME;
                processInfo.CreateNoWindow = false;

                RTCLoggerThread = new Thread(new ThreadStart(() =>
                    {
                        isRTCLoggerWorking = true;
                        if (LOGStatusEvent != null)
                        {

                            LOGStatusEvent.Invoke(this, new LogEventArgs("",LOGEventState.RTCLOGGER_STATUS)); // update form
                        }

                        if (RTCLoggerProc == null)
                        {
                            RTCLoggerProc = Process.Start(processInfo);
                        }
                        
                        RTCLoggerProc.WaitForExit();
                        // RTCLogger was exited
                        isRTCLoggerWorking = false;
                        RTCLoggerProc = null;
                        if (LOGStatusEvent != null)
                        {
                            LOGStatusEvent.Invoke(this, new LogEventArgs("", LOGEventState.RTCLOGGER_STATUS)); // update form
                        }

                        RTCLoggerThread.Abort();
                    }
                ));

                RTCLoggerThread.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ", directory: " + string.Format(m_rtcLoggerPath) + ", filename: " + RTC_LOGGER_EXE_NAME);
            }
        }

        public static string GetLoggerFilePath()
        {

            m_assembly = System.Reflection.Assembly.GetEntryAssembly().Location;
            m_assemblyPath = System.IO.Path.GetDirectoryName(m_assembly);
            m_rtcLoggerPath = Path.Combine(m_assemblyPath, RTC_LOGGER_DIRECTORY);
            m_rtcLogIniFileFullName = m_rtcLoggerPath + "\\" + RTC_LOG_FILE_NAME;

            return m_rtcLogIniFileFullName;
        }

        public void InitModule()
        {
            string rtcLogIniFileFullName = GetLoggerFilePath();

            int Rt1Port = RT1_LOGGER_PORT;
            int Rt2Port = RT2_LOGGER_PORT;

            ReadIniFile(ref Rt1Port, ref Rt2Port, rtcLogIniFileFullName);

            // write new values to file
            UpdateFileWithPorts(Rt1Port, Rt2Port, rtcLogIniFileFullName);

            LOGModule.INIContent.isInit = true;

            INIContent.FullnameRTCLoggerApp = m_rtcLoggerPath + RTC_LOGGER_EXE_NAME;

            // if the Log directory is not exist yet, create it
            if (Directory.Exists(LOGModule.INIContent.logfileDir) == false)
            {
                Directory.CreateDirectory(LOGModule.INIContent.logfileDir);
            }

            // if the Framework directory is not exist yet, create it
            frameworkPath = Path.GetFullPath(Path.Combine(LOGModule.INIContent.logfileDir, @"..\" + FRAME_WORK_DIR_NAME));

            if (Directory.Exists(frameworkPath) == false)
            {
                Directory.CreateDirectory(frameworkPath);
            }
            
        }

        public static string ReadIniFile(ref int Rt1Port, ref int Rt2Port, string pRtcLogIniFileFullName)
        {
            // Ports are calculated according to GCS ID
            SettingsHandler.Instance().GetCalculatedLogPorts(RT1_LOGGER_PORT, RT2_LOGGER_PORT, ref Rt1Port, ref Rt2Port);

            StreamReader reader = File.OpenText(pRtcLogIniFileFullName);
            string line;
            int lineNumber = 0;
            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split(' ');

                switch (lineNumber)
                {
                    case 1:
                        LOGModule.INIContent.numOfRecord = items[0];
                        break;
                    case 2:
                        LOGModule.INIContent.logfileDir = items[0];
                        break;
                    case 3:
                        LOGModule.INIContent.maxLogLength = items[0];
                        break;
                    case 6:
                        LOGModule.INIContent.multicastIP = items[0];
                        break;
                    case 8:
                        LOGModule.INIContent.numOfPort = items[0];
                        break;
                    case 9:
                        LOGModule.INIContent.rtc1Port = Rt1Port.ToString();
                        break;
                    case 10:
                        LOGModule.INIContent.rtc2Port = Rt2Port.ToString(); Rt1Port.ToString();
                        break;
                    default:
                        break;
                }
                lineNumber++;
            }
            reader.Close();

            return LOGModule.INIContent.multicastIP;
        }

        public static void UpdateFileWithPorts(int Rt1Port, int Rt2Port, string pRtcLogIniFileFullName)
        {
            try
            {
                StringBuilder newFile = new StringBuilder();

                int LineCount = 0;
                bool FoundPorts = false;

                string[] file = File.ReadAllLines(pRtcLogIniFileFullName);

                foreach (string line in file)
                {
                    if (line.Contains("[PORT]"))
                    {
                        FoundPorts = true;
                    }

                    if (FoundPorts == true)
                    {
                        LineCount++;
                    }

                    if (LineCount == 3)
                    {
                        newFile.Append(Rt1Port.ToString() + "\r\n");
                    }
                    else if (LineCount == 4)
                    {
                        newFile.Append(Rt2Port.ToString() + "\r\n");
                    }
                    else
                    {
                        newFile.Append(line + "\r\n");
                    }

                }

                System.IO.FileInfo fileInfo = new System.IO.FileInfo(pRtcLogIniFileFullName);
                fileInfo.IsReadOnly = false;

                File.WriteAllText(pRtcLogIniFileFullName, newFile.ToString());
            }
            catch
            {
            }
        }

        /* The search Method*/
        public bool searchAndFilterByString(string searchString,bool isCaseSensetive,DateTime startDate,DateTime endDate,string operand)
        {
            List<Object> EventParamsList = new List<Object>();

            LOGStatusEvent.Invoke(this, new LogEventArgs("", LOGEventState.STARTING_SEARCH)); // update form
            EventParamsList.Add(searchString);
            EventParamsList.Add(isCaseSensetive);
            EventParamsList.Add(startDate);
            EventParamsList.Add(endDate);
            EventParamsList.Add(operand);
            if (searchBGWorker.IsBusy)
            {//busy
                LOGStatusEvent.Invoke(this, new LogEventArgs("Eror: Can not running a multiple search, Please stop previous search first!", LOGEventState.NOTIFICATION)); // update form
            }
            else
            {
                searchBGWorker.RunWorkerAsync(EventParamsList);
            }
            return true;
        }

        public void abortSearchFilter()
        {
            LOGModule.MaxNavIndex = 0;
            LOGModule.currentNavIndexPaging = 0;
            LOGModule.isSearchEnded = true;
            if (LOGModule.stopSearchMutex.CurrentCount == 0)
            {
                LOGModule.stopSearchMutex.Release();
                LOGModule.stopSearchMutex = new SemaphoreSlim(0);

            }
            searchBGWorker.CancelAsync();
            searchBGWorker.Dispose();
        }

        public string convertLogLevel(uint logLevel)
        {
            if ((int)logLevel == 1)
            {
                return "DEBUG";
            }
            else if ((int)logLevel == 2)
            {
                return "INFO";
            }
            else if ((int)logLevel == 3)
            {
                return "WARNING";
            }
            else if ((int)logLevel == 4)
            {
                return "ERROR";
            }
            else if ((int)logLevel == 5)
            {
                return "FATAL";
            }

            return "N\\A";
        }

        public uint convertLogLevel(string logLevel)
        {
            if (logLevel == "DEBUG")
            {
                return 1;
            }
            else if (logLevel == "INFO")
            {
                return 2;
            }
            else if (logLevel == "WARNING")
            {
                return 3;
            }
            else if (logLevel == "ERROR")
            {
                return 4;
            }
            else if (logLevel == "FATAL")
            {
                return 5;
            }
            else
            {
                return 0; // Not Exist
            }
        }


        public byte[] getSelectedRTLogLevelByteArray(DataGridView selectedLogLevels)
        {
            byte[] msgToSend;

            SelectedModuleLogLevel rtLogLevelTable = new SelectedModuleLogLevel();
            rtLogLevelTable.numOfModules = (uint) selectedLogLevels.RowCount;

            msgToSend = BitConverter.GetBytes(rtLogLevelTable.numOfModules);

            int rowIndex = 0;
            rtLogLevelTable.reportedLogLevels = new ReportedModuleLogLevelEntry[rtLogLevelTable.numOfModules];

            foreach (DataGridViewRow dgvRow in selectedLogLevels.Rows)
            {
                uint moduleID = (uint)Convert.ToInt32(dgvRow.Cells[0].Value);
                uint selected = convertLogLevel((string)dgvRow.Cells[2].Value);

                byte[] moduleIDByteArray = BitConverter.GetBytes(moduleID);
                byte[] selectedByteArray = BitConverter.GetBytes(selected);

                msgToSend = Combine(msgToSend, moduleIDByteArray, selectedByteArray);

                rtLogLevelTable.reportedLogLevels[rowIndex] = (new ReportedModuleLogLevelEntry() 
              {
                  module_id = moduleID,
                  selected_level = selected,
              });
              rowIndex++;
            }

            return msgToSend;
        }

        public void initReportLevelColumns()
        {
            /* INIT Repoertd Level Table */
            LOGLevelReportedDataTable = new DataTable();
            LOGLevelReportedDataTable.Columns.Add("Module id", typeof(String));
            LOGLevelReportedDataTable.Columns.Add("Module", typeof(String));
            LOGLevelReportedDataTable.Columns.Add("Selected Level", typeof(String));
            LOGLevelReportedDataTable.Columns.Add("Reported Level", typeof(String));

            moduleId = new DataGridViewTextBoxColumn();
            moduleId.HeaderText = "ID";
            moduleId.DataPropertyName = "Module id";
            moduleId.ReadOnly = true;
            moduleId.FillWeight = 20;
            moduleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;


            moduleName = new DataGridViewTextBoxColumn();
            moduleName.HeaderText = "Module";
            moduleName.DataPropertyName = "Module";
            moduleName.ReadOnly = true;
            moduleName.FillWeight = 100;
            moduleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            levelToReport = new DataGridViewComboBoxColumn();
            levelToReportList = new List<string>() { "DEBUG", "INFO", "WARNING", "ERROR", "FATAL" };
            levelToReport.DataSource = levelToReportList;
            levelToReport.HeaderText = "Selected Level";
            levelToReport.DataPropertyName = "Selected Level";
            levelToReport.FillWeight = 100;
            levelToReport.ReadOnly = false;
            levelToReport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;


            reportedLevel = new DataGridViewTextBoxColumn();
            reportedLevel.HeaderText = "Reported Level";
            reportedLevel.DataPropertyName = "Reported Level";
            reportedLevel.ReadOnly = true;
            reportedLevel.FillWeight = 100;
            reportedLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            /* INIT Repoertd Level Filter Table */

            LOGLevelFilteredDataTable = new DataTable();
            LOGLevelFilteredDataTable.Columns.Add("Module", typeof(String));
            LOGLevelFilteredDataTable.Columns.Add("From_Only", typeof(String));
            LOGLevelFilteredDataTable.Columns.Add("Level", typeof(String));

            moduleNameFiltered = new DataGridViewTextBoxColumn();
            moduleNameFiltered.HeaderText = "Module";
            moduleNameFiltered.DataPropertyName = "Module";
            moduleNameFiltered.ReadOnly = true;
            moduleNameFiltered.FillWeight = 100;
            moduleNameFiltered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            selectedModeFiltered = new DataGridViewComboBoxColumn();
            selectedModeFilteredList = new List<string>() { "ONLY","FROM" };
            selectedModeFiltered.DataSource = selectedModeFilteredList;
            selectedModeFiltered.HeaderText = "From\\Only";
            selectedModeFiltered.DataPropertyName = "From_Only";
            selectedModeFiltered.FillWeight = 100;
            selectedModeFiltered.ReadOnly = false;
            selectedModeFiltered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            selectedLevelFiltered = new DataGridViewComboBoxColumn();
            selectedLevelFilteredList = new List<string>() { "DEBUG", "INFO", "WARNING", "ERROR", "FATAL" };
            selectedLevelFiltered.DataSource = selectedLevelFilteredList;
            selectedLevelFiltered.HeaderText = "Level";
            selectedLevelFiltered.DataPropertyName = "Level";
            selectedLevelFiltered.FillWeight = 100;
            selectedLevelFiltered.ReadOnly = false;
            selectedLevelFiltered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        byte[] Combine(byte[] a1, byte[] a2, byte[] a3)
        {
            byte[] ret = new byte[a1.Length + a2.Length + a3.Length];
            Array.Copy(a1, 0, ret, 0, a1.Length);
            Array.Copy(a2, 0, ret, a1.Length, a2.Length);
            Array.Copy(a3, 0, ret, a1.Length + a2.Length, a3.Length);
            return ret;
        }

        public bool reloadLogFile(DateTime startDate, DateTime endDate, string operand)
        {
            /*Check for new files detected on online files*/
            try
            {

                string[] logFiles = Directory.GetFiles(LOGModule.INIContent.logfileDir, "*.txt", SearchOption.TopDirectoryOnly);
                onlineFolderList = new List<string>();
                string[] fileNameSplited;
                DateTime LastWriteTime;
                foreach (string logFile in logFiles)
                {
                    
                    fileNameSplited = logFile.Split('_');
                    if (fileNameSplited.Length > 2 && fileNameSplited[2] != null)
                    {
                        /*check if this file is relevant to this RTC*/
                        if ((deviceIdConnected == SocketHandler.enumDevice_id.RTC_1 && fileNameSplited[2] == INIContent.rtc1Port) ||
                            (deviceIdConnected == SocketHandler.enumDevice_id.RTC_2 && fileNameSplited[2] == INIContent.rtc2Port))
                        {
                            /* Check if Time is relvant*/
                            LastWriteTime = File.GetLastWriteTime(logFile);
                            if(operand == "<=")
                            {
                                if (LastWriteTime.Ticks <= startDate.Ticks)
                                {
                                    onlineFolderList.Add(logFile);
                                }
                            }
                            else if (operand == ">=")
                            {
                                if (LastWriteTime.Ticks >= startDate.Ticks)
                                {
                                    onlineFolderList.Add(logFile);
                                }
                            }
                            else if (operand == "-")
                            {
                                if (LastWriteTime.Ticks >= startDate.Ticks && LastWriteTime.Ticks <= endDate.Ticks)
                                {
                                    onlineFolderList.Add(logFile);
                                }
                            }
                        }
                    }
                }

                LOGStatusEvent.Invoke(this, new LogEventArgs("",LOGEventState.FINISH_RELOAD));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accure: " + ex.Message.ToString());
            }
            return true;
        }

        public void openSearchedLogFile()
        {

            if (navigationResultFileName.ContainsKey(currentNavIndexPaging))
            {
                string destinationSearchedLogFile = navigationResultFileName[currentNavIndexPaging];

                if (File.Exists(destinationSearchedLogFile))
                {
                    System.Diagnostics.Process.Start(destinationSearchedLogFile);
                }
                else
                {
                    MessageBox.Show("No such file exist with this name: " + destinationSearchedLogFile);
                }
            }
            else
            {
                LOGStatusEvent.Invoke(this, new LogEventArgs("There is no filter file in the system!", LOGEventState.NOTIFICATION));
            }

        }
        public void exitApplication()
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        public void setLogFilterLevels(DataGridView dgv)
        {

            FilterDict = new Dictionary<string, FilterLevelEntry>();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                FilterDict.Add(dgv[0, i].Value.ToString().Replace("\0",string.Empty), new FilterLevelEntry(dgv[1, i].Value.ToString(), dgv[2, i].Value.ToString()));
            }

        }


        public static void isRTCLoggerAlreadyRunning()
        {
            IntPtr hWnd = IntPtr.Zero;
            Process[] RTLoggerProcess = Process.GetProcessesByName("RTCLogger");

            foreach (Process process in RTLoggerProcess)
            {
                RTCLoggerProc = process;
                isRTCLoggerWorking = true;
                return;
            }
        }

        // This event handler is where the time-consuming work is done.
        private void searchBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Object> paramList = (List<Object>)e.Argument;
            string searchString = (string)paramList[0];
            bool isCaseSensetive = (bool)paramList[1];
            DateTime startDate = (DateTime)paramList[2];
            DateTime endDate = (DateTime)paramList[3];
            string operand = (string)paramList[4];
            List<string> selectedFolder;
            StreamReader sr;
            isSearchEnded = false;
            StringBuilder contentResult = new StringBuilder();
            BackgroundWorker worker = sender as BackgroundWorker;
            string line;
            int lineCntr = 0;
            string tmpLine, moduleNameLOGReceived, levelLOGReceived, foundedLines;
            try
            {
                /*Clear last framework*/
                deleteFrameworkFolder();
                navigationResult.Clear();
                navigationResultFileName.Clear();

                if ((offlineFolderList == null || offlineFolderList.Count == 0) && isOfflineSearch == true)
                {
                    LOGStatusEvent.Invoke(this, new LogEventArgs("No folder or valid files was found for offline search!", LOGEventState.NOTIFICATION)); // update form
                    return;
                }

                if (isOfflineSearch == true)
                {
                    selectedFolder = offlineFolderList;
                }
                else
                {
                    selectedFolder = onlineFolderList;
                }

                /* loop over all files*/
                if (selectedFolder.Count <= 0)
                {
                    /*No folder*/
                    isSearchEnded = true;
                    LOGStatusEvent.Invoke(this, new LogEventArgs("", LOGEventState.FINAL_PAGE_SEARCH)); // update form
                    return;
                }
                string lastFileName = selectedFolder[selectedFolder.Count - 1];

                foreach (string filename in selectedFolder)
                {
                    DateTime currFileLastWriteTime = File.GetLastWriteTime(filename);
                    /*Take only the file that suitable to the requirement time*/
                    switch (operand)
                    {
                        case ">=":
                            if (currFileLastWriteTime < startDate)
                            {
                                continue;
                            }
                            break;
                        case "<=":
                            if (currFileLastWriteTime > endDate)
                            {
                                continue;
                            }
                            break;
                        case "-":
                            if (currFileLastWriteTime > startDate || currFileLastWriteTime > endDate)
                            {
                                continue;
                            }
                            break;
                        default:
                            MessageBox.Show("Error: Unknown Operator for search date option");
                            return;
                    }

                    /*Starting Search*/
                    LOGStatusEvent.Invoke(this, new LogEventArgs(filename, LOGEventState.READING_NEW_FILE)); // update form

                    /* Reading while another process writing (RTCLogger) */
                    using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (sr = new StreamReader(fs, Encoding.Default))
                        {
                            
                            /* While there is any data to read, read it...*/
                            while (!sr.EndOfStream)
                            {
                                /* If we reached to the MAX Line allowed on the screen, stop and display the result*/
                                if (lineCntr >= MAX_LINE_PER_SCREEN )
                                {
                                    LOGStatusEvent.Invoke(this, new LogEventArgs("", LOGEventState.NEED_TO_LOAD_MORE_RESULT)); // update form
                                    foundedLines = contentResult.ToString();
                                    contentResult.Clear();
                                    Thread.Sleep(50);
                                    LOGStatusEvent.Invoke(this, new LogEventArgs(foundedLines, LOGEventState.READING_FILE_SEARCH_STATUS)); // update form

                                    /* save current result for navigation later*/
                                    string currPagingFileName = "PagingResult" + MaxNavIndex + ".txt";
                                    string currFileName = frameworkPath + "\\" + currPagingFileName;
                                    navigationResult.Add(MaxNavIndex, foundedLines);
                                    navigationResultFileName.Add(MaxNavIndex, currFileName);
                                    try
                                    {
                                        File.WriteAllText(currFileName, foundedLines);
                                    }
                                    catch (Exception ex1)
                                    {
                                        MessageBox.Show("Some Error accure while trying writing to the file: " + currPagingFileName);
                                    }

                                    //wait until will load more result
                                    stopSearchMutex.Wait();

                                    MaxNavIndex++;
                                    currentNavIndexPaging++;
                                    lineCntr = 0;
                                }

                                /* Check for cancel*/
                                if (worker.CancellationPending == true)
                                {
                                    e.Cancel = true;
                                    LOGStatusEvent.Invoke(this, new LogEventArgs("", LOGEventState.END_SEARCH)); // update form
                                    currentNavIndexPaging = 0;
                                    MaxNavIndex = 0;
                                    return;
                                }
                                line = sr.ReadLine();
                                
                                string[] split = line.Split(',');
                                if (split.Length < 7)
                                {//unvalid line
                                    continue;
                                }

                                if (isCaseSensetive)
                                {
                                    tmpLine = line;
                                }
                                else
                                {
                                    tmpLine = line.ToLower();
                                    searchString = searchString.ToLower();
                                }

                                // split[1] = Level, split[3] = module name
                                moduleNameLOGReceived = split[3].Replace(" ", String.Empty);
                                levelLOGReceived = split[1].Replace(" ", String.Empty);

                                /*if FilterDict is null, dont filter...*/
                                if (FilterDict == null)
                                {
                                    if (tmpLine.Contains(searchString))
                                    {
                                        contentResult.Append(line + Environment.NewLine);
                                        lineCntr++;
                                    }
                                    continue;
                                }

                                if (FilterDict.ContainsKey(moduleNameLOGReceived) == false)
                                {
                                    continue;
                                }
                                FilterLevelEntry fle = FilterDict[moduleNameLOGReceived];
                                if (fle.FilterMode_ == "FROM")
                                {//check if this line Level bigger than filterLevel
                                
                                    int indexSelected = selectedLevelFilteredList.IndexOf(fle.selectedLevel_);
                                    int indexFound = selectedLevelFilteredList.IndexOf(levelLOGReceived);
                                
                                    if (indexFound >= indexSelected && indexSelected != -1 && indexFound != -1)
                                    {
                                        if (tmpLine.Contains(searchString))
                                        {
                                            contentResult.Append(line + Environment.NewLine);
                                            lineCntr++;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    /* Only level*/
                                    if (FilterDict[moduleNameLOGReceived].selectedLevel_ == levelLOGReceived)
                                    { // the Level is ok, search string in this line
                                
                                        if (tmpLine.Contains(searchString))
                                        {
                                            contentResult.Append(line + Environment.NewLine);
                                            lineCntr++;
                                        }
                                
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            } // While there is any data to read

                            /*The remaining ending lines*/
                            if (lastFileName == filename)
                            {
                                foundedLines = contentResult.ToString();
                                /* save current result for navigation later*/
                                string LastcurrPagingFileName = "PagingResult" + MaxNavIndex + ".txt";
                                string LastcurrFileName = frameworkPath + "\\" + LastcurrPagingFileName;
                                navigationResult.Add(MaxNavIndex, foundedLines);
                                navigationResultFileName.Add(MaxNavIndex, LastcurrFileName);
                                try
                                {
                                    File.WriteAllText(LastcurrFileName, foundedLines);
                                }
                                catch (Exception ex1)
                                {
                                    MessageBox.Show("Some Error accure while trying writing to the file: " + LastcurrPagingFileName);
                                }
                                isSearchEnded = true;
                                LOGStatusEvent.Invoke(this, new LogEventArgs(foundedLines, LOGEventState.FINAL_PAGE_SEARCH)); // update form
                            }

                        } // Read File
                    }//Try Reading file
              }//foreach file

            }
            catch (Exception ex)
            {//Will be catch while killing the thread
                //MessageBox.Show("Information: " + ex.Message.ToString());
            }                
        }


        private void searchBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {


                //logShellContent_textBox.AppendText(e.UserState.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        // This event handler deals with the results of the background operation.
        private void searchBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LOGStatusEvent.Invoke(this, new LogEventArgs("", LOGEventState.END_SEARCH)); // update form

        }

        /*Log eventArgs Handler*/
        public class LogEventArgs : EventArgs
        {
            public string fileLogName { get; internal set; }
            public string content { get; internal set; }
            public LOGEventState state;
           

            public LogEventArgs(string Name, LOGEventState State)
            {
                this.fileLogName = Name;
                this.state = State;
            }

            public LogEventArgs()
            {
                this.fileLogName = "";
                this.state = LOGEventState.NONE;
            }
        }

        /* Clear content of framework folder*/
        public void deleteFrameworkFolder()
        {
            try
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(frameworkPath);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Data.ToString());
            }
        }


    }
}
