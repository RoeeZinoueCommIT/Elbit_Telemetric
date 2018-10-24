using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using RT_Viewer.Framework;
using RT_Viewer.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.IO;

namespace RT_Viewer
{
    public partial class RTViewerForm : Form
    {

        static System.Windows.Forms.Timer guiTimer = new System.Windows.Forms.Timer();
        public static SocketHandler socketRT1;                   // communicate with RT1
        public static SocketHandler socketRT2;                   //communicate with RT2
        /*Forms*/
        SettingsForm settingsForm;
        AboutForm aboutForm;
        LoggerShellForm LoggerShellFormSideA;
        LoggerShellForm LoggerShellFormSideB;
        GenericTextBoxForm SearchStatusForm;
        TesterForm testForm;

        public static FolderBrowserDialog offlineFolderPath;

        public bool isDispose = false;             // are we going to close the APP?
        public static bool isRTC1Presented = true; // are we want to represent RT1 or RT2?

        System.ComponentModel.ComponentResourceManager resources;

        public RTViewerForm()
        {
            InitializeComponent();
            selectLogFolder_button.Hide();

            logStart_dateTimePicker.Format = DateTimePickerFormat.Custom;
            logStart_dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            /*Start day is always a month before the current date*/
            DateTime lastMonthDate = DateTime.Now;
            lastMonthDate = lastMonthDate.AddMonths(-1);
            logStart_dateTimePicker.Text = lastMonthDate.ToString();

            logEnd_dateTimePicker.Format = DateTimePickerFormat.Custom;
            logEnd_dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            logDateOperator_comboBox_SelectedIndexChanged(this, EventArgs.Empty);
            logDateOperator_comboBox.Text = ">=";

            resources = new System.ComponentModel.ComponentResourceManager(typeof(RTViewerForm));
            /*Reading XML setting File*/
            SettingsHandler.Instance().Init();

            SettingsHandler.Instance().GcsIdChangedEvent += new SettingsHandler.GcsIdChangedEventHandler(settingsHandler_GcsIdChangedEvent);

            /* Creating two sockets */

            socketRT1 = new SocketHandler(SettingsHandler.multicastRT1, SettingsHandler.portRT1RX, SettingsHandler.portRT1TX, SocketHandler.enumDevice_id.RTC_1);
            socketRT2 = new SocketHandler(SettingsHandler.multicastRT2, SettingsHandler.portRT2RX, SettingsHandler.portRT2TX, SocketHandler.enumDevice_id.RTC_2);


            //Add here all the Event module
            //ADD RT1 Events
            socketRT1.rtiModule.ModuleEvent += new IModule.IModuleHandler(RTIEventHandler);
            socketRT1.hstModule.ModuleEvent += new IModule.IModuleHandler(HSTEventHandler);
            socketRT1.appModule.ModuleEvent += new IModule.IModuleHandler(APPEventHandler);
            socketRT1.uavModule.ModuleEvent += new IModule.IModuleHandler(UAVEventHandler);
            socketRT1.logModule.ModuleEvent += new IModule.IModuleHandler(LOGEventHandler);
            socketRT1.logModule.LOGStatusEvent += new LOGModule.LOGButtonsEvent(LOGButtonsEventHandler);
            socketRT1.ntpModule.ModuleEvent += new IModule.IModuleHandler(NTPEventHandler);
            socketRT1.frmModule.ModuleEvent += new IModule.IModuleHandler(FRMEventHandler);
            socketRT1.offModule.ModuleEvent += new IModule.IModuleHandler(OFFEventHandler);
            socketRT1.nvmModule.ModuleEvent += new IModule.IModuleHandler(NVMEventHandler);
            socketRT1.stkModule.ModuleEvent += new IModule.IModuleHandler(STKEventHandler);
            socketRT1.hkyModule.ModuleEvent += new IModule.IModuleHandler(HKYEventHandler);
            socketRT1.pfdModule.ModuleEvent += new IModule.IModuleHandler(PFDEventHandler);
            socketRT1.mgcModule.ModuleEvent += new IModule.IModuleHandler(MGCEventHandler);
            socketRT1.gdtModule.ModuleEvent += new IModule.IModuleHandler(GDTEventHandler);
            socketRT1.irdModule.ModuleEvent += new IModule.IModuleHandler(IRDEventHandler);

            //ADD RT2 Events
            socketRT2.rtiModule.ModuleEvent += new IModule.IModuleHandler(RTIEventHandler);
            socketRT2.hstModule.ModuleEvent += new IModule.IModuleHandler(HSTEventHandler);
            socketRT2.appModule.ModuleEvent += new IModule.IModuleHandler(APPEventHandler);
            socketRT2.uavModule.ModuleEvent += new IModule.IModuleHandler(UAVEventHandler);
            socketRT2.logModule.ModuleEvent += new IModule.IModuleHandler(LOGEventHandler);
            socketRT2.logModule.LOGStatusEvent += new LOGModule.LOGButtonsEvent(LOGButtonsEventHandler);
            socketRT2.ntpModule.ModuleEvent += new IModule.IModuleHandler(NTPEventHandler);
            socketRT2.frmModule.ModuleEvent += new IModule.IModuleHandler(FRMEventHandler);
            socketRT2.offModule.ModuleEvent += new IModule.IModuleHandler(OFFEventHandler);
            socketRT2.nvmModule.ModuleEvent += new IModule.IModuleHandler(NVMEventHandler);
            socketRT2.stkModule.ModuleEvent += new IModule.IModuleHandler(STKEventHandler);
            socketRT2.hkyModule.ModuleEvent += new IModule.IModuleHandler(HKYEventHandler);
            socketRT2.pfdModule.ModuleEvent += new IModule.IModuleHandler(PFDEventHandler);
            socketRT2.mgcModule.ModuleEvent += new IModule.IModuleHandler(MGCEventHandler);
            socketRT2.gdtModule.ModuleEvent += new IModule.IModuleHandler(GDTEventHandler);
            socketRT2.irdModule.ModuleEvent += new IModule.IModuleHandler(IRDEventHandler);

            setRTLogLevel_dataGridView.CellEnter += setRTLogLevel_dataGridView_CellEnter;
            setRTCLoggerFilter_dataGridView.CellEnter += setRTCLoggerFilter_dataGridView_CellEnter;

            viewerVersion_textBox.Text = AboutForm.AssemblyVersion;
            guiTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 1 seconds.
            guiTimer.Interval = 1000;
            guiTimer.Start();

            /*Check if RTCLogger already running*/
            if (LOGModule.isRTCLoggerWorking)
            {
                startRtcLogger_button.Text = "Stop RTCLogger";
                startRtcLogger_button.BackColor = System.Drawing.Color.GreenYellow;
                startRtcLogger_button.Refresh();
            }

            Application.DoEvents();

            this.FormClosed += new FormClosedEventHandler(RTViewerForm_FormClosed);

            // not necesary any more
            this.dataGridViewTextBoxColumn31.Visible = false; 
            this.gcsextraDataGridViewTextBoxColumn.Visible = false;  


        }

        void settingsHandler_GcsIdChangedEvent(object sender, string pGcsID)
        {
            this.gcsIdTextBox.Text = pGcsID;
        }

        void RTViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isDispose = true;
            //Close all the opened tasks
            guiTimer.Stop();
            //if RTCLogger Working, kill him
            if (LOGModule.isRTCLoggerWorking)
            {
                try
                {
                    LOGModule.RTCLoggerProc.Kill();
                    LOGModule.RTCLoggerThread.Abort();
                }
                catch //(Exception ex)
                {
                    //Nothing to do...
                }
            }

            SettingsHandler.Instance().GcsIdChangedEvent -= new SettingsHandler.GcsIdChangedEventHandler(settingsHandler_GcsIdChangedEvent);

            //stop invokes RT1
            socketRT1.rtiModule.ModuleEvent -= new IModule.IModuleHandler(RTIEventHandler);
            socketRT1.hstModule.ModuleEvent -= new IModule.IModuleHandler(HSTEventHandler);
            socketRT1.appModule.ModuleEvent -= new IModule.IModuleHandler(APPEventHandler);
            socketRT1.uavModule.ModuleEvent -= new IModule.IModuleHandler(UAVEventHandler);
            socketRT1.logModule.ModuleEvent -= new IModule.IModuleHandler(LOGEventHandler);
            socketRT1.logModule.LOGStatusEvent -= new LOGModule.LOGButtonsEvent(LOGButtonsEventHandler);
            socketRT1.ntpModule.ModuleEvent -= new IModule.IModuleHandler(NTPEventHandler);
            socketRT1.frmModule.ModuleEvent -= new IModule.IModuleHandler(FRMEventHandler);
            socketRT1.offModule.ModuleEvent -= new IModule.IModuleHandler(OFFEventHandler);
            socketRT1.nvmModule.ModuleEvent -= new IModule.IModuleHandler(NVMEventHandler);
            socketRT1.stkModule.ModuleEvent -= new IModule.IModuleHandler(STKEventHandler);
            socketRT1.hkyModule.ModuleEvent -= new IModule.IModuleHandler(HKYEventHandler);
            socketRT1.mgcModule.ModuleEvent -= new IModule.IModuleHandler(MGCEventHandler);
            socketRT1.gdtModule.ModuleEvent -= new IModule.IModuleHandler(GDTEventHandler);
            socketRT1.irdModule.ModuleEvent -= new IModule.IModuleHandler(IRDEventHandler);

            //stop invokes RT2
            socketRT2.rtiModule.ModuleEvent -= new IModule.IModuleHandler(RTIEventHandler);
            socketRT2.hstModule.ModuleEvent -= new IModule.IModuleHandler(HSTEventHandler);
            socketRT2.appModule.ModuleEvent -= new IModule.IModuleHandler(APPEventHandler);
            socketRT2.uavModule.ModuleEvent -= new IModule.IModuleHandler(UAVEventHandler);
            socketRT2.logModule.ModuleEvent -= new IModule.IModuleHandler(LOGEventHandler);
            socketRT2.logModule.LOGStatusEvent -= new LOGModule.LOGButtonsEvent(LOGButtonsEventHandler);
            socketRT2.ntpModule.ModuleEvent -= new IModule.IModuleHandler(NTPEventHandler);
            socketRT2.frmModule.ModuleEvent -= new IModule.IModuleHandler(FRMEventHandler);
            socketRT2.offModule.ModuleEvent -= new IModule.IModuleHandler(OFFEventHandler);
            socketRT2.nvmModule.ModuleEvent -= new IModule.IModuleHandler(NVMEventHandler);
            socketRT2.stkModule.ModuleEvent -= new IModule.IModuleHandler(STKEventHandler);
            socketRT2.hkyModule.ModuleEvent -= new IModule.IModuleHandler(HKYEventHandler);
            socketRT2.mgcModule.ModuleEvent -= new IModule.IModuleHandler(MGCEventHandler);
            socketRT2.gdtModule.ModuleEvent -= new IModule.IModuleHandler(GDTEventHandler);
            socketRT2.irdModule.ModuleEvent -= new IModule.IModuleHandler(IRDEventHandler);

            setRTLogLevel_dataGridView.CellEnter -= setRTLogLevel_dataGridView_CellEnter;
            setRTCLoggerFilter_dataGridView.CellEnter -= setRTCLoggerFilter_dataGridView_CellEnter;

        }
        /*######################
         #    RTI Event        #
         ######################*/
        public void RTIEventHandler(Object sender, IModuleEventArgs e)
        {

            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(RTIEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }
           
           // Do the work...
            
          if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
          {
              if (socketRT1.rtiModule.BL_RTITable != null)
              {
                  uplTable_dataGridView.DataSource = socketRT1.rtiModule.BL_RTITable;
                  string dnlCntr;
                  for (int i = 0; i < socketRT1.rtiModule.BL_RTITable.Count; i++)
                  {
                      dnlCntr = "     " + (socketRT1.rtiModule.rtiBlock.uplMessage[i].no_downlink_timer / 20).ToString() + " Sec";
                      for (int j = 0; j < uplTable_dataGridView.ColumnCount; j++)
                      {

                          if (socketRT1.rtiModule.rtiBlock.uplMessage[i].no_downlink_timer >= socketRT1.rtiModule.rtiBlock.stateMachineMessage.no_downlink_time_limit)
                          {
                              uplTable_dataGridView[j, i].Style.ForeColor = Color.Gray;
                              uplTable_dataGridView[j, i].ToolTipText = dnlCntr + " (No Downlink)";
                          }
                          else
                          {
                              uplTable_dataGridView[j, i].ToolTipText = dnlCntr;
                          }                 
                      }
                  }

                  uplTable_dataGridView.Refresh();
              }
              if (socketRT1.rtiModule.BL_LOPTable != null)
              {
                  lopTable_dataGridView.DataSource = socketRT1.rtiModule.BL_LOPTable;
                  lopTable_dataGridView.Refresh();
              }
              if (socketRT1.rtiModule.BL_HSTTable != null)
              {
                  hstTable_dataGridView.DataSource = socketRT1.rtiModule.BL_HSTTable;

                  string gdtDetails;
                  uint[] uplink = new uint[10];
                  uint[] site_id = new uint[10];
                  uint[] gdt_id = new uint[10];
                  int j;

                  for (int i = 0; i < socketRT1.rtiModule.BL_HSTTable.Count; i++)
                  {
                      uplink[0] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id1;
                      uplink[1] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id2;
                      uplink[2] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id3;
                      uplink[3] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id4;
                      uplink[4] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id5;
                      uplink[5] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id6;
                      uplink[6] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id7;
                      uplink[7] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id8;
                      uplink[8] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id9;
                      uplink[9] = socketRT1.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id10;

                      // For C-Band & UHF Channels .
                      for (j = 0; j < 2; j++)
                      {
                          if (uplink[j] != 0)
                          {
                              site_id[j] = (uplink[j] / 6);
                              gdt_id[j] = (uplink[j] % 6);

                              gdtDetails = "      GDT = " + "{" + site_id[j].ToString() + ", " + gdt_id[j].ToString() + "}";
                              hstTable_dataGridView[j + 2, i].ToolTipText = gdtDetails;
                          }
                      }

                      // For Other Channels .
                      for (j = 2; j < hstTable_dataGridView.ColumnCount - 2; j++)
                      {
                          if (uplink[j] != 0)
                          {
                              gdtDetails = "      Tail = " + uplink[j].ToString();
                              hstTable_dataGridView[j + 2, i].ToolTipText = gdtDetails;
                          }
                      }
                  }
                  hstTable_dataGridView.Refresh();
              }

              if (socketRT1.rtiModule.BL_UAVTable != null)
              {
                  uavRtiTable_dataGridView.DataSource = socketRT1.rtiModule.BL_UAVTable;

                  string gdtDetails;
                  uint[] uplink  = new uint[10];
                  uint[] site_id = new uint[10];
                  uint[] gdt_id  = new uint[10];
                  int j;

                  for (int i = 0; i < socketRT1.rtiModule.BL_HSTTable.Count; i++)
                  {
                      uplink[0] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id1; //TODO: 
                      uplink[1] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id2;
                      uplink[2] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id3;
                      uplink[3] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id4;
                      uplink[4] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id5;
                      uplink[5] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id6;
                      uplink[6] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id7;
                      uplink[7] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id8;
                      uplink[8] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id9;
                      uplink[9] = socketRT1.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id10;

                      // For C-Band & UHF Channels .
                      for (j = 0; j < 2; j++)
                      {
                          if (uplink[j] != 0)
                          {
                              site_id[j] = (uplink[j] / 6);
                              gdt_id[j] = (uplink[j] % 6);

                              gdtDetails = "      GDT = " + "{" + site_id[j].ToString() + ", " + gdt_id[j].ToString() + "}";
                              uavRtiTable_dataGridView[j + 2, i].ToolTipText = gdtDetails;
                          }
                      }

                      // For Other Channels .
                      for (j = 2; j < uavRtiTable_dataGridView.ColumnCount - 2; j++)
                      {
                          if (uplink[j] != 0)
                          {
                              gdtDetails = "      Tail = " + uplink[j].ToString();
                              uavRtiTable_dataGridView[j + 2, i].ToolTipText = gdtDetails;
                          }
                      }
                  }
                  uavRtiTable_dataGridView.Refresh();
              }

              hstCounter_textBox.Text = socketRT1.rtiModule.rtiBlock.cntrMessage.hst_routing_table_cntr.ToString();
              lopCounter_textBox.Text = socketRT1.rtiModule.rtiBlock.cntrMessage.lop_message_counter.ToString();
              uavCounter_textBox.Text = socketRT1.rtiModule.rtiBlock.cntrMessage.uav_routing_table_cntr.ToString();
              mainRTCounter_textBox.Text = socketRT1.rtiModule.rtiBlock.cntrMessage.main_routing_table_cntr.ToString();
              transactionMode_textBox.Text = socketRT1.rtiModule.stateMechine;
          }

          else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
          {

              if (socketRT2.rtiModule.BL_RTITable != null)
              {
                  uplTable_dataGridView.DataSource = socketRT2.rtiModule.BL_RTITable;
                  string dnlCntr;
                  for (int i = 0; i < socketRT2.rtiModule.BL_RTITable.Count; i++)
                  {
                      dnlCntr = "     " + (socketRT2.rtiModule.rtiBlock.uplMessage[i].no_downlink_timer / 20).ToString() + " Sec";
                      for (int j = 0; j < uplTable_dataGridView.ColumnCount; j++)
                      {

                          if (socketRT2.rtiModule.rtiBlock.uplMessage[i].no_downlink_timer >= socketRT2.rtiModule.rtiBlock.stateMachineMessage.no_downlink_time_limit)
                          {
                              uplTable_dataGridView[j, i].Style.ForeColor = Color.Gray;
                              uplTable_dataGridView[j, i].ToolTipText = dnlCntr + " (No Downlink)";
                          }
                          else
                          {
                              uplTable_dataGridView[j, i].ToolTipText = dnlCntr;
                          }
                      }
                  }
                  uplTable_dataGridView.Refresh();
              }
              if (socketRT2.rtiModule.BL_LOPTable != null)
              {
                  lopTable_dataGridView.DataSource = socketRT2.rtiModule.BL_LOPTable;
                  lopTable_dataGridView.Refresh();
              }
              if (socketRT2.rtiModule.BL_HSTTable != null)
              {
                  hstTable_dataGridView.DataSource = socketRT2.rtiModule.BL_HSTTable;
                  
                  string gdtDetails;
                  uint[] uplink  = new uint[10];
                  uint[] site_id = new uint[2];
                  uint[] gdt_id  = new uint[2];
                  int j;

                  for (int i = 0; i < socketRT2.rtiModule.BL_HSTTable.Count; i++)
                  {
                      uplink[0] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id1;
                      uplink[1] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id2;
                      uplink[2] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id3;
                      uplink[3] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id4;
                      uplink[4] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id5;
                      uplink[5] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id6;
                      uplink[6] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id7;
                      uplink[7] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id8;
                      uplink[8] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id9;
                      uplink[9] = socketRT2.rtiModule.rtiBlock.hstRTIMessage[i].uplink_id10;

                      // For C-Band & UHF Channels .
                      for (j = 0; j < 2; j++)
                      {
                          if (uplink[j] != 0)
                          {
                              site_id[j] = (uplink[j] / 6);
                              gdt_id[j] = (uplink[j] % 6);

                              gdtDetails = "      GDT = " + "{" + site_id[j].ToString() + ", " + gdt_id[j].ToString() + "}";
                              hstTable_dataGridView[j + 2, i].ToolTipText = gdtDetails;
                          }
                      }

                      // For Other Channels .
                      for (j = 2; j < hstTable_dataGridView.ColumnCount - 2; j++)
                      {
                          if (uplink[j] != 0)
                          {
                              gdtDetails = "      Tail = " + uplink[j].ToString();
                              hstTable_dataGridView[j + 2, i].ToolTipText = gdtDetails;
                          }
                      }
                  }
                  hstTable_dataGridView.Refresh();
              }

              if (socketRT2.rtiModule.BL_UAVTable != null)
              {
                  uavRtiTable_dataGridView.DataSource = socketRT2.rtiModule.BL_UAVTable;

                  string gdtDetails;
                  uint[] uplink = new uint[10];
                  uint[] site_id = new uint[10];
                  uint[] gdt_id = new uint[10];
                  int j;

                  for (int i = 0; i < socketRT2.rtiModule.BL_UAVTable.Count; i++)
                  {
                      uplink[0] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id1;
                      uplink[1] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id2;
                      uplink[2] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id3;
                      uplink[3] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id4;
                      uplink[4] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id5;
                      uplink[5] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id6;
                      uplink[6] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id7;
                      uplink[7] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id8;
                      uplink[8] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id9;
                      uplink[9] = socketRT2.rtiModule.rtiBlock.uavRTIMessage[i].gcs_id10;

                      // For C-Band & UHF Channels .
                      for (j = 0; j < 2; j++)
                      {
                          if (uplink[j] != 0)
                          {
                              site_id[j] = (uplink[j] / 6);
                              gdt_id[j] = (uplink[j] % 6);

                              gdtDetails = "      GDT = " + "{" + site_id[j].ToString() + ", " + gdt_id[j].ToString() + "}";
                              uavRtiTable_dataGridView[j + 2, i].ToolTipText = gdtDetails;
                          }
                      }

                      // For Other Channels .
                      for (j = 2; j < uavRtiTable_dataGridView.ColumnCount - 2; j++)
                      {
                          if (uplink[j] != 0)
                          {
                              gdtDetails = "      Tail = " + uplink[j].ToString();
                              uavRtiTable_dataGridView[j + 2, i].ToolTipText = gdtDetails;
                          }
                      }
                  }
                  uavRtiTable_dataGridView.Refresh();
              }

              hstCounter_textBox.Text = socketRT2.rtiModule.rtiBlock.cntrMessage.hst_routing_table_cntr.ToString();
              lopCounter_textBox.Text = socketRT2.rtiModule.rtiBlock.cntrMessage.lop_message_counter.ToString();
              uavCounter_textBox.Text = socketRT2.rtiModule.rtiBlock.cntrMessage.uav_routing_table_cntr.ToString();
              mainRTCounter_textBox.Text = socketRT2.rtiModule.rtiBlock.cntrMessage.main_routing_table_cntr.ToString();
              transactionMode_textBox.Text = socketRT2.rtiModule.stateMechine;
                 
          }

        }
        /*######################
        #    HST Event         #
        ######################*/
        public void HSTEventHandler(Object sender, IModuleEventArgs e)
        {

            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(HSTEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                uint keepAliveState = socketRT1.hstModule.hstStruct.keepAliveState;
                uint keepAliveSentCounter = socketRT1.hstModule.hstStruct.keepAliveSentCounter;
                uint keepAliveRecievedCounter = socketRT1.hstModule.hstStruct.keepAliveRecievedCounter;


                keepAliveRXCntr_textBox.Text = keepAliveRecievedCounter.ToString();
                keepAliveTXCntr_textBox.Text = keepAliveSentCounter.ToString();

                if (socketRT1.hstModule.isKARecivedOK == true)
                {
                    kaRX_pictureBox.Image = Properties.Resources.greedLed;
                }
                else
                {
                    kaRX_pictureBox.Image = Properties.Resources.redLed;
                }
                if (socketRT1.hstModule.isKASentOK == true)
                {
                    kaTX_pictureBox.Image = Properties.Resources.greedLed;
                }
                else
                {
                    kaTX_pictureBox.Image = Properties.Resources.redLed;
                }
            }

            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                uint keepAliveState = socketRT2.hstModule.hstStruct.keepAliveState;
                uint keepAliveSentCounter = socketRT2.hstModule.hstStruct.keepAliveSentCounter;
                uint keepAliveRecievedCounter = socketRT2.hstModule.hstStruct.keepAliveRecievedCounter;


                keepAliveRXCntr_textBox.Text = keepAliveRecievedCounter.ToString();
                keepAliveTXCntr_textBox.Text = keepAliveSentCounter.ToString();

                if (socketRT2.hstModule.isKARecivedOK == true)
                {
                    kaRX_pictureBox.Image = Properties.Resources.greedLed;
                }
                else
                {
                    kaRX_pictureBox.Image = Properties.Resources.redLed;
                }
                if (socketRT2.hstModule.isKASentOK == true)
                {
                    kaTX_pictureBox.Image = Properties.Resources.greedLed;
                }
                else
                {
                    kaTX_pictureBox.Image = Properties.Resources.redLed;
                }
            }


        }
        /*######################
        #    APP Event         #
        ######################*/
        public void APPEventHandler(Object sender, IModuleEventArgs e)
        {

            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(APPEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                rtStatus_textBox.Text = socketRT1.appModule.isRTCActive;  //isActive
                rtVersion_textBox.Text = socketRT1.appModule.RTCVersion;   //version
                buildDate_textBox.Text = socketRT1.appModule.RTCBuildDate; //Build Date
                hbsVersion_textBox.Text = socketRT1.appModule.HBSVersionMajor.ToString() + "." + socketRT1.appModule.HBSVersionMinor.ToString(); // HBS Version
                ipRT1_textBox.Text = socketRT1.appModule.rt1Ip.ToString();// +" ; " + socketRT1.appModule.rt1Ip[1].ToString();
                ipRT2_textBox.Text = socketRT1.appModule.rt2Ip.ToString();// +" ; " + socketRT1.appModule.rt2Ip[1].ToString();
                rtDefualtGatway_textBox.Text = socketRT1.appModule.rtDefaultGatway.ToString();// + " ; " + socketRT1.appModule.rtDefaultGatway[1].ToString();
                viewerVersion_textBox.Text = AboutForm.AssemblyVersion;
                cpuUsage_textBox.Text = socketRT1.appModule.cpuUsage.ToString();
                mainStackUsage_textBox.Text = socketRT1.appModule.main_stack_usage.ToString();
                logStackUsage_textBox.Text = socketRT1.appModule.log_stack_usage.ToString();
                vtuStackUsage_textBox.Text = socketRT1.appModule.vtu_stack_usage.ToString();
                pfdStackUsage_textBox.Text = socketRT1.appModule.pfd_stack_usage.ToString();
                
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                rtStatus_textBox.Text = socketRT2.appModule.isRTCActive;  //isActive
                rtVersion_textBox.Text = socketRT2.appModule.RTCVersion;   //version
                buildDate_textBox.Text = socketRT2.appModule.RTCBuildDate; //Build Date
                hbsVersion_textBox.Text = socketRT2.appModule.HBSVersionMajor.ToString() + "." + socketRT2.appModule.HBSVersionMinor.ToString(); // HBS Version
                ipRT1_textBox.Text = socketRT2.appModule.rt1Ip.ToString();// +" ; " + socketRT2.appModule.rt1Ip[1].ToString();
                ipRT2_textBox.Text = socketRT2.appModule.rt2Ip.ToString();// +" ; " + socketRT2.appModule.rt2Ip[1].ToString();
                rtDefualtGatway_textBox.Text = socketRT2.appModule.rtDefaultGatway.ToString(); //+ " ; " + socketRT2.appModule.rtDefaultGatway[1].ToString();
                viewerVersion_textBox.Text = AboutForm.AssemblyVersion;
                cpuUsage_textBox.Text = socketRT2.appModule.cpuUsage.ToString();
                mainStackUsage_textBox.Text = socketRT2.appModule.main_stack_usage.ToString();
                logStackUsage_textBox.Text = socketRT2.appModule.log_stack_usage.ToString();
                vtuStackUsage_textBox.Text = socketRT2.appModule.vtu_stack_usage.ToString();
                pfdStackUsage_textBox.Text = socketRT2.appModule.pfd_stack_usage.ToString();
            }

            if (socketRT1.appModule.isRTAPPArrived == true && socketRT2.appModule.isRTAPPArrived == true)
            {
                bool isVersionSync = true;

                /* Without prefix RTC1\RTC2*/
                if (socketRT1.appModule.RTCVersion.Substring(5) != socketRT2.appModule.RTCVersion.Substring(5))
                {
                    isVersionSync = false;
                }
                if (socketRT1.appModule.RTCBuildDate != socketRT2.appModule.RTCBuildDate)
                {
                    isVersionSync = false;
                }
                if ((socketRT1.appModule.HBSVersionMajor != socketRT2.appModule.HBSVersionMajor) || (socketRT1.appModule.HBSVersionMinor != socketRT2.appModule.HBSVersionMinor))
                {
                    isVersionSync = false;
                }
                if (isVersionSync == true)
                {
                    versionSync_pictureBox.Image = Properties.Resources.greedLed;
                }
                else
                {
                    versionSync_pictureBox.Image = Properties.Resources.redLed;
                }
            }

            EnableKnobButtons();

        }
        /*######################
        #    UAV Event         #
        ######################*/
        public void UAVEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(UAVEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                if (socketRT1.uavModule.BL_DNLTable != null)
                {
                    uavTable_dataGridView.DataSource = socketRT1.uavModule.BL_DNLTable;
                    uavTable_dataGridView.Refresh();
                }
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                if (socketRT2.uavModule.BL_DNLTable != null)
                {
                    uavTable_dataGridView.DataSource = socketRT2.uavModule.BL_DNLTable;
                    uavTable_dataGridView.Refresh();
                }
            }
        }
        /*######################
        #    LOG Event         #
        ######################*/
        public void LOGEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(LOGEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                setRTLogLevel_dataGridView.AutoGenerateColumns = false;
                setRTCLoggerFilter_dataGridView.AutoGenerateColumns = false;

                if (setRTLogLevel_dataGridView.Rows.Count == 0)
                { // first message, fill the dataGridView

                    setRTLogLevel_dataGridView.DataSource = socketRT1.logModule.LOGLevelReportedDataTable;
                    setRTLogLevel_dataGridView.Columns.AddRange(socketRT1.logModule.moduleId, socketRT1.logModule.moduleName, socketRT1.logModule.levelToReport, socketRT1.logModule.reportedLevel);

                    setRTCLoggerFilter_dataGridView.DataSource = socketRT1.logModule.LOGLevelFilteredDataTable;
                    setRTCLoggerFilter_dataGridView.Columns.AddRange(socketRT1.logModule.moduleNameFiltered, socketRT1.logModule.selectedModeFiltered, socketRT1.logModule.selectedLevelFiltered);

                    undoRTCLogLevel_Button_Click(this, EventArgs.Empty);

                    setLogLevelForAllModules_comboBox.DataSource = new List<string>(socketRT1.logModule.levelToReportList); // Clone the list

                    /*Enable Change Log level*/
                    setRTLogLevel_button.Enabled = true;
                    undoRTCLogLevel_Button.Enabled = true;
                    setRTLogLevelForAllModules_button.Enabled = true;
                    setLogLevelForAllModules_comboBox.Enabled = true;
                    /*Set default filter level to From and Debug */
                    SetFilter_Click(null, EventArgs.Empty);
                    setLogFilter_button.Enabled = true;
                    /*Set filter to default value*/
                    SetFilter_Click(this, EventArgs.Empty);
                }
                else
                {// update if some value changed
                    int rowIndex = 0;
                    foreach (LOGModule.LogLevelTable LogLevel_entry in socketRT1.logModule.BL_LogLevelTable)
                    {
                        if (setRTLogLevel_dataGridView[3, rowIndex].Value.ToString() != LogLevel_entry.ReportedLevel)
                        {
                            setRTLogLevel_dataGridView[3, rowIndex].Value = LogLevel_entry.ReportedLevel;
                        }
                        rowIndex++;
                    }
                }

            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                setRTLogLevel_dataGridView.AutoGenerateColumns = false;
                setRTCLoggerFilter_dataGridView.AutoGenerateColumns = false;

                if (setRTLogLevel_dataGridView.Rows.Count == 0)
                { // first message, fill the dataGridView

                    setRTLogLevel_dataGridView.DataSource = socketRT2.logModule.LOGLevelReportedDataTable;
                    setRTLogLevel_dataGridView.Columns.AddRange(socketRT2.logModule.moduleId, socketRT2.logModule.moduleName, socketRT2.logModule.levelToReport, socketRT2.logModule.reportedLevel);

                    setRTCLoggerFilter_dataGridView.DataSource = socketRT2.logModule.LOGLevelFilteredDataTable;
                    setRTCLoggerFilter_dataGridView.Columns.AddRange(socketRT2.logModule.moduleNameFiltered, socketRT2.logModule.selectedModeFiltered, socketRT2.logModule.selectedLevelFiltered);


                    undoRTCLogLevel_Button_Click(this, EventArgs.Empty);

                    setLogLevelForAllModules_comboBox.DataSource = new List<string>(socketRT2.logModule.levelToReportList); // Clone the list

                    /*Enable Change Log level*/
                    setRTLogLevel_button.Enabled = true;
                    undoRTCLogLevel_Button.Enabled = true;
                    setRTLogLevelForAllModules_button.Enabled = true;
                    setLogLevelForAllModules_comboBox.Enabled = true;
                    /*Set default filter level to From and Debug */
                    SetFilter_Click(null, EventArgs.Empty);
                    setLogFilter_button.Enabled = true;
                    /*Set filter to default value*/
                    SetFilter_Click(this, EventArgs.Empty);
                }
                else
                {// update if some value changed
                    int rowIndex = 0;
                    foreach (LOGModule.LogLevelTable LogLevel_entry in socketRT2.logModule.BL_LogLevelTable)
                    {
                        if (setRTLogLevel_dataGridView[3, rowIndex].Value.ToString() != LogLevel_entry.ReportedLevel)
                        {
                            setRTLogLevel_dataGridView[3, rowIndex].Value = LogLevel_entry.ReportedLevel;
                        }
                        rowIndex++;
                    }
                }
            }
        }
        /*######################
        #    LOG Buttton Event #
        ######################*/
        public void LOGButtonsEventHandler(Object sender, RT_Viewer.Framework.LOGModule.LogEventArgs e)
        { // update LOG tab according the members of the LOGModule
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                RT_Viewer.Framework.LOGModule.LOGButtonsEvent cb = new RT_Viewer.Framework.LOGModule.LOGButtonsEvent(LOGButtonsEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            switch (e.state)
            {
                case RT_Viewer.Framework.LOGModule.LOGEventState.NONE:

                    break;
                case RT_Viewer.Framework.LOGModule.LOGEventState.RTCLOGGER_STATUS:
                    if (LOGModule.isRTCLoggerWorking)
                    {
                        startRtcLogger_button.Text = "Stop RTCLogger";
                        startRtcLogger_button.BackColor = System.Drawing.Color.GreenYellow;
                        startRtcLogger_button.Refresh();

                    }
                    else
                    {
                        startRtcLogger_button.Text = "Start RTCLogger";
                        startRtcLogger_button.BackColor = System.Drawing.Color.Transparent;
                        startRtcLogger_button.Refresh();
                    }
                    break;

                case RT_Viewer.Framework.LOGModule.LOGEventState.STARTING_SEARCH:
                        loadingLogFilter_pictureBox.Image = Properties.Resources.loading1;
                        filterByStringInLog_button.Enabled = false;
                    break;
                    case RT_Viewer.Framework.LOGModule.LOGEventState.END_SEARCH:

                        addLogSearchStatusContent("Search Ended!", Color.ForestGreen);
                        loadingLogFilter_pictureBox.Image = null;
                        filterByStringInLog_button.Enabled = true;
                        stopFilterByStringInLog_button.Enabled = false;
 
                    break;
                    case RT_Viewer.Framework.LOGModule.LOGEventState.READING_FILE_SEARCH_STATUS:
                        //Add content to the textBox
                        logContent_textBox.AppendText(e.fileLogName);

                        if (LOGModule.currentNavIndexPaging > 0)
                        {
                            showPrevLogResult_button.Enabled = true;
                            showPrevLogResult_button.BackColor = Color.SkyBlue;
                        }
                        if (LOGModule.currentNavIndexPaging <= LOGModule.MaxNavIndex)
                        {
                            showNextLogResult_button.Enabled = true;
                            showNextLogResult_button.BackColor = Color.SkyBlue;
                        }
                        else
                        {
                            showNextLogResult_button.Enabled = false;
                            showNextLogResult_button.BackColor = Color.Transparent;
                        }

                    break;
                    case RT_Viewer.Framework.LOGModule.LOGEventState.READING_NEW_FILE:
                    addLogSearchStatusContent("Searching in: " + e.fileLogName, Color.Navy);
                    break;
                case RT_Viewer.Framework.LOGModule.LOGEventState.NOTIFICATION:

                    addLogSearchStatusContent("Notification: " + e.fileLogName, Color.Red);
                    break;

                case RT_Viewer.Framework.LOGModule.LOGEventState.NEED_TO_LOAD_MORE_RESULT:
                    showNextLogResult_button.Enabled = true;
                    showNextLogResult_button.BackColor = Color.SkyBlue;
                    logPageNumber_label.Text = "Page Number: " + (LOGModule.currentNavIndexPaging + 1);
                    break;
                case RT_Viewer.Framework.LOGModule.LOGEventState.FINAL_PAGE_SEARCH:

                    //Add content to the textBox
                    logContent_textBox.AppendText(e.fileLogName);
                    showNextLogResult_button.Enabled = false;
                    showNextLogResult_button.BackColor = Color.Transparent;
                    logPageNumber_label.Text = "Page Number: " + (LOGModule.currentNavIndexPaging + 1) + " (Last Page)";

                    if (LOGModule.currentNavIndexPaging > 0)
                    {
                        showPrevLogResult_button.Enabled = true;
                        showPrevLogResult_button.BackColor = Color.SkyBlue;
                    }
                    if (LOGModule.currentNavIndexPaging < LOGModule.MaxNavIndex)
                    {
                        showNextLogResult_button.Enabled = true;
                        showNextLogResult_button.BackColor = Color.SkyBlue;
                    }
                    else
                    {
                        showNextLogResult_button.Enabled = false;
                        showNextLogResult_button.BackColor = Color.Transparent;
                    }

                    break;

            }
            

        }
        /*######################
        #    NTP Event         #
        ######################*/
        public void NTPEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(NTPEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {

                if (socketRT1.ntpModule.ntpStruct.isNTPServerConnected == 0)
                {
                    ntpServerConnection_textBox.Text = "Disconnected";
                    ntpServerConnection_pictureBox.Image = Properties.Resources.redLed;
                    
                }
                else
                {
                    ntpServerConnection_textBox.Text = "Connected";
                    ntpServerConnection_pictureBox.Image = Properties.Resources.greedLed;
                }
      
                timeStamp_textBox.Text = socketRT1.ntpModule.ntpStruct.timestamp.ToString();
                utc_textBox.Text = socketRT1.ntpModule.utcTime;
                ntpServerIP_textBox.Text = NTPModule.getIPStringFromInt(socketRT1.ntpModule.ntpStruct.server_addr) + ":" + socketRT1.ntpModule.ntpStruct.server_port.ToString();
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {

                if (socketRT2.ntpModule.ntpStruct.isNTPServerConnected == 0)
                {
                    ntpServerConnection_textBox.Text = "Disconnected";
                    ntpServerConnection_pictureBox.Image = Properties.Resources.redLed;
                }
                else
                {
                    ntpServerConnection_textBox.Text = "Connected";
                    ntpServerConnection_pictureBox.Image = Properties.Resources.greedLed;
                }
                 timeStamp_textBox.Text = socketRT2.ntpModule.ntpStruct.timestamp.ToString();
                 utc_textBox.Text = socketRT2.ntpModule.utcTime;
                 ntpServerIP_textBox.Text = NTPModule.getIPStringFromInt(socketRT2.ntpModule.ntpStruct.server_addr) + ":" + socketRT2.ntpModule.ntpStruct.server_port.ToString();
            }
        }
        /*######################
        #    FRM Event         #
        ######################*/
        public void FRMEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(FRMEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                frmFaultCntr_textBox.Text = socketRT1.frmModule.frmDB.currentFRMFaultExistReported.ToString();
                frmFaultMaxRecords_textBox.Text = socketRT1.frmModule.frmDB.maxFRMFaults.ToString();
                pflFaultsReported_textBox.Text = socketRT1.frmModule.frmDB.currentPFLFaultExistReported.ToString();
                totalPFLRecords_textBox.Text = socketRT1.frmModule.frmDB.maxPFLFaults.ToString();

                
                frm_dataGridView.DataSource = socketRT1.frmModule.BL_FRMTable;
                pflFault_dataGridView.DataSource = socketRT1.frmModule.BL_PFLTable;

            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                frmFaultCntr_textBox.Text = socketRT2.frmModule.frmDB.currentFRMFaultExistReported.ToString();
                frmFaultMaxRecords_textBox.Text = socketRT2.frmModule.frmDB.maxFRMFaults.ToString();
                pflFaultsReported_textBox.Text = socketRT2.frmModule.frmDB.currentPFLFaultExistReported.ToString();
                totalPFLRecords_textBox.Text = socketRT2.frmModule.frmDB.maxPFLFaults.ToString();

                frm_dataGridView.DataSource = socketRT2.frmModule.BL_FRMTable;
                pflFault_dataGridView.DataSource = socketRT2.frmModule.BL_PFLTable;
            }

        }
        /*######################
        #    OFF Event         #
        ######################*/
        public void OFFEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(OFFEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            offlineParam_dataGridView.AutoGenerateColumns = false;

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                offlineParam_dataGridView.DataSource = socketRT1.offModule.OfflineDataTable;
                offlineParam_dataGridView.Columns.AddRange(socketRT1.offModule.valueColumn, socketRT1.offModule.descriptionColumn);
                if (socketRT1.offModule.offlineStruct.running_mode == 0)
                {
                    rtMode_textBox.Text = "Application";
                }
                else
                {
                    rtMode_textBox.Text = "Debug";
                }

                /*Update MGC configuration*/
                for (int i = 0; i < MGCModule.MAX_NUM_OF_GRU; i++)
                {
                    switch (i)
                    {
                        case (int)MGCModule.GRU_NUMBER.GRU1:
                            if (socketRT1.offModule.offlineStruct.atol_id1 == 1)
                            {
                                gru1Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru1Configure_label.Text = "Not Configured";
                            }
                            break;
                        case (int)MGCModule.GRU_NUMBER.GRU2:
                            if (socketRT1.offModule.offlineStruct.atol_id2 == 1)
                            {
                                gru2Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru2Configure_label.Text = "Not Configured";
                            }
                            break;
                        case (int)MGCModule.GRU_NUMBER.GRU3:
                            if (socketRT1.offModule.offlineStruct.atol_id3 == 1)
                            {
                                gru3Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru3Configure_label.Text = "Not Configured";
                            }
                            break;
                        case (int)MGCModule.GRU_NUMBER.GRU4:
                            if (socketRT1.offModule.offlineStruct.atol_id4 == 1)
                            {
                                gru4Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru4Configure_label.Text = "Not Configured";
                            }
                            break;
                        case (int)MGCModule.GRU_NUMBER.GRU5:
                            if (socketRT1.offModule.offlineStruct.atol_id5 == 1)
                            {
                                gru5Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru5Configure_label.Text = "Not Configured";
                            }
                            break;
                    }
                }
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                offlineParam_dataGridView.DataSource = socketRT2.offModule.OfflineDataTable;
                offlineParam_dataGridView.Columns.AddRange(socketRT2.offModule.valueColumn, socketRT2.offModule.descriptionColumn);
                if (socketRT2.offModule.offlineStruct.running_mode == 0)
                {
                    rtMode_textBox.Text = "Application";
                }
                else
                {
                    rtMode_textBox.Text = "Debug";
                }
                /*Update MGC configuration*/
                for (int i = 0; i < MGCModule.MAX_NUM_OF_GRU; i++)
                {
                    switch (i)
                    {
                        case (int)MGCModule.GRU_NUMBER.GRU1:
                            if (socketRT2.offModule.offlineStruct.atol_id1 == 1)
                            {
                                gru1Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru1Configure_label.Text = "Not Configured";
                            }
                            break;
                        case (int)MGCModule.GRU_NUMBER.GRU2:
                            if (socketRT2.offModule.offlineStruct.atol_id2 == 1)
                            {
                                gru2Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru2Configure_label.Text = "Not Configured";
                            }
                            break;
                        case (int)MGCModule.GRU_NUMBER.GRU3:
                            if (socketRT2.offModule.offlineStruct.atol_id3 == 1)
                            {
                                gru3Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru3Configure_label.Text = "Not Configured";
                            }
                            break;
                        case (int)MGCModule.GRU_NUMBER.GRU4:
                            if (socketRT2.offModule.offlineStruct.atol_id4 == 1)
                            {
                                gru4Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru4Configure_label.Text = "Not Configured";
                            }
                            break;
                        case (int)MGCModule.GRU_NUMBER.GRU5:
                            if (socketRT2.offModule.offlineStruct.atol_id5 == 1)
                            {
                                gru5Configure_label.Text = "Configured";
                            }
                            else
                            {
                                gru5Configure_label.Text = "Not Configured";
                            }
                            break;
                    }
                }
            }



            /*Check for sync in Configuration file for RT1 and RT2*/
            if (socketRT1.offModule.isRTConfigurationArrived == true && socketRT2.offModule.isRTConfigurationArrived == true)
            {
               /* Check for equation*/
                bool isEqualsConfiguration = true;
                if (socketRT1.offModule.OfflineDataTable.Rows.Count != socketRT2.offModule.OfflineDataTable.Rows.Count || socketRT1.offModule.OfflineDataTable.Columns.Count != socketRT2.offModule.OfflineDataTable.Columns.Count)
                {
                    isEqualsConfiguration = false;
                }

                if (isEqualsConfiguration == true)
                {
                    for (int rowIndex = 0; rowIndex < socketRT1.offModule.OfflineDataTable.Rows.Count; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < socketRT1.offModule.OfflineDataTable.Columns.Count; colIndex++)
                        {

                            if (!Equals(socketRT1.offModule.OfflineDataTable.Rows[rowIndex][colIndex], socketRT2.offModule.OfflineDataTable.Rows[rowIndex][colIndex]))
                            {
                                if ((socketRT1.offModule.OfflineDataTable.Rows[rowIndex].ItemArray[0] == "Number of RT") && 
                                    (socketRT2.offModule.OfflineDataTable.Rows[rowIndex].ItemArray[0] == "Number of RT"))
                                {
                                    // should be in a diffrent RT number for each configuration
                                    continue;
                                }
                                else
                                { 
                                    this.Config_Diff_Tb.Text = 
                                    " different value : " + socketRT1.offModule.OfflineDataTable.Rows[rowIndex][colIndex].ToString();

                                    isEqualsConfiguration = false;

                                    break;
                                }

                            }
                        }
                    }
                }

                if (isEqualsConfiguration == true)
                {
                    configurationSync_pictureBox.Image = Properties.Resources.greedLed;
                }
                else
                {
                    configurationSync_pictureBox.Image = Properties.Resources.redLed;
                }
            }
        }
        /*######################
        #    NVM Event         #
        ######################*/
        public void NVMEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(NVMEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                idGcsReadData_textBox.Text = socketRT1.nvmModule.nvramData.gcs_id.ToString();

                if (idGcsReadData_textBox.Text == idGcsWriteData_textBox.Text)
                {
                    loadingNVRAMWrite_pictureBox.Image = null;
                    socketRT1.nvmModule.isWritingRequested = false;
                    socketRT1.nvmModule.timeElapsedSinceRequest = 0;
                }
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                idGcsReadData_textBox.Text = socketRT2.nvmModule.nvramData.gcs_id.ToString();
                if (idGcsReadData_textBox.Text == idGcsWriteData_textBox.Text)
                {
                    loadingNVRAMWrite_pictureBox.Image = null;
                    socketRT2.nvmModule.isWritingRequested = false;
                    socketRT2.nvmModule.timeElapsedSinceRequest = 0;
                }
            }
        }
        /*######################
        #    STK Event         #
        ######################*/
        public void STKEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(STKEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }
            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {

                //update datasource
                stick_dataGridView.DataSource = socketRT1.stkModule.BL_STKTaxiTable;
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                //update datasource
                stick_dataGridView.DataSource = socketRT2.stkModule.BL_STKTaxiTable;
            }
        }
        /*######################
        #    HKY Event         #
        ######################*/
        public void HKYEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(HKYEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            /* Leds*/
            ledHKYConsole1_flowLayoutPanel.VerticalScroll.Enabled = true;
            ledHKYConsole1_flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            ledHKYConsole1_flowLayoutPanel.AutoScroll = true;

            ledHKYConsole2_flowLayoutPanel.VerticalScroll.Enabled = true;
            ledHKYConsole2_flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            ledHKYConsole2_flowLayoutPanel.AutoScroll = true;

            /* Hard Keys*/
            keysHKYConsole1_flowLayoutPanel.VerticalScroll.Enabled = true;
            keysHKYConsole1_flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            keysHKYConsole1_flowLayoutPanel.AutoScroll = true;

            keysHKYConsole2_flowLayoutPanel.VerticalScroll.Enabled = true;
            keysHKYConsole2_flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            keysHKYConsole2_flowLayoutPanel.AutoScroll = true;

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                /*Console 1*/
            
                SetTailNumOfLeds(this.hkyConsole1Tail_textBox, "1", socketRT1.rtiModule.BL_LOPTable);

                /* Draw Leds*/
                for (int i = 0; i < socketRT1.hkyModule.hkyStruct.num_of_led; i++)
                {
                    PictureBox currentPic = new PictureBox();
                    currentPic.Name = "ledPic" + i.ToString();
                    currentPic.SizeMode = PictureBoxSizeMode.Normal;
                    currentPic.Margin = new System.Windows.Forms.Padding(80, 5, 0, 0);

                    if (socketRT1.hkyModule.hkyStruct.HKYConsole[0].led[i].mode == 2)
                    { // Blink Mode
                        currentPic.Image = Properties.Resources.flickLed;
                    }
                    else if (socketRT1.hkyModule.hkyStruct.HKYConsole[0].led[i].state == 1)
                    {
                        currentPic.Image = Properties.Resources.onLed;
                    }
                    else
                    {
                        currentPic.Image = Properties.Resources.offLed;
                    }

                    Label newLabel = new Label();
                    newLabel.Size = new Size(190, 100);

                    newLabel.Name = "Console1Led" + i.ToString() + "_label";
                    newLabel.Text = socketRT1.hkyModule.ledIntToEnum(i).ToString();
                    newLabel.TextAlign = ContentAlignment.TopCenter;

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Name = "Console1flp" + i.ToString();

                    flp.FlowDirection = FlowDirection.LeftToRight;

                    flp.Size = new Size(200, 100);
                    flp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
                    flp.BorderStyle = BorderStyle.FixedSingle;

                    flp.Controls.Add(currentPic);
                    flp.Controls.Add(newLabel);


                    //get prev item
                    Control[] cntrl = ledHKYConsole1_flowLayoutPanel.Controls.Find(flp.Name, true);
                    if (cntrl.Length > 0)
                    {
                        FlowLayoutPanel clusterCpyflp = (FlowLayoutPanel)cntrl[0]; // the image and label element
                        cntrl = clusterCpyflp.Controls.Find(currentPic.Name, true); // the image element
                        PictureBox prevPic = (PictureBox)cntrl[0];

                        if (prevPic.Image != currentPic.Image)
                        {//update View with current Picture
                            prevPic.Image = currentPic.Image;
                            prevPic.Name = currentPic.Name;
                        }
                    }

                    else
                    { // first time
                        ledHKYConsole1_flowLayoutPanel.Controls.Add(flp);
                    }
                }

                /* Draw Keys  - Console 1*/
                for (int i = 0; i < socketRT1.hkyModule.hkyStruct.num_of_key; i++)
                {
                    PictureBox currentPic = new PictureBox();
                    currentPic.Name = "keyPic" + i.ToString();
                    currentPic.SizeMode = PictureBoxSizeMode.Normal;
                    currentPic.Size = new System.Drawing.Size(60, 52);
                    currentPic.Margin = new System.Windows.Forms.Padding(60, 0, 0, 0);

                    if (socketRT1.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].state == 1)
                    { //pressed
                        currentPic.Image = Properties.Resources.pressed_button;
                    }
                    else
                    { // Not pressed
                        currentPic.Image = Properties.Resources.unpressed_button;
                    }

                    Label keysNameLabel = new Label();
                    keysNameLabel.Size = new Size(190, 12);
                    keysNameLabel.Name = "Console1Keys" + i.ToString() + "_label";
                    keysNameLabel.Text = socketRT1.hkyModule.keysIntToEnum(i).ToString();
                    keysNameLabel.TextAlign = ContentAlignment.TopCenter;
                    keysNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    keysNameLabel.Font = new Font(keysNameLabel.Font, FontStyle.Bold);

                    Label type = new Label();
                    type.Size = new Size(190, 20);
                    type.Name = "Console1KeysType" + i.ToString() + "_label";
                    type.Text = "Type: " + socketRT1.hkyModule.functionIntToEnum((int)socketRT1.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].type);
                    type.TextAlign = ContentAlignment.TopCenter;
                    type.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);

                    Label currDisc = new Label();
                    currDisc.Size = new Size(190, 20);
                    currDisc.Name = "Console1KeysDesc1" + i.ToString() + "_label";
                    if (socketRT1.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].type == 0)
                    {
                        currDisc.Text = "dis_1: " + socketRT1.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].discr[0].state.ToString();
                    }
                    else
                    {
                        currDisc.Text = "dis_1: " + socketRT1.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].discr[0].state.ToString() + "    |    dis_2: " + socketRT1.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].discr[1].state.ToString();
                    }
                    
                    currDisc.TextAlign = ContentAlignment.TopCenter;
                    currDisc.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Name = "Console1flp" + i.ToString();

                    flp.FlowDirection = FlowDirection.LeftToRight;

                    flp.Size = new Size(200, 110);
                    flp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
                    flp.BorderStyle = BorderStyle.FixedSingle;

                    flp.Controls.Add(keysNameLabel);
                    flp.Controls.Add(currentPic);
                    flp.Controls.Add(type);
                    flp.Controls.Add(currDisc);
                    
                    //get prev item
                    Control[] cntrl = keysHKYConsole1_flowLayoutPanel.Controls.Find(flp.Name, true);
                    if (cntrl.Length > 0)
                    {
                        FlowLayoutPanel clusterCpyflp = (FlowLayoutPanel)cntrl[0]; // the image and label element
                        cntrl = clusterCpyflp.Controls.Find(currentPic.Name, true); // the image element
                        PictureBox prevPic = (PictureBox)cntrl[0];

                        if (prevPic.Image != currentPic.Image)
                        {//update View with current Picture
                            prevPic.Image = currentPic.Image;
                            prevPic.Name = currentPic.Name;
                        }

                        cntrl = clusterCpyflp.Controls.Find(currDisc.Name, true); // the Disc element
                        Label prevDisc = (Label)cntrl[0];
                        if (prevDisc.Text != currDisc.Text)
                        {
                            prevDisc.Text = currDisc.Text;
                        }
  
                    }

                    else
                    { // first time
                        keysHKYConsole1_flowLayoutPanel.Controls.Add(flp);
                    }
                }

                /*Console 2*/

                SetTailNumOfLeds(this.hkyConsole2Tail_textBox, "2", socketRT1.rtiModule.BL_LOPTable);

                for (int i = 0; i < socketRT1.hkyModule.hkyStruct.num_of_led; i++)
                {
                    PictureBox currentPic = new PictureBox();
                    currentPic.Name = "ledPic" + i.ToString();
                    currentPic.SizeMode = PictureBoxSizeMode.Normal;
                    currentPic.Margin = new System.Windows.Forms.Padding(80, 5, 0, 0);

                    if (socketRT1.hkyModule.hkyStruct.HKYConsole[1].led[i].mode == 2)
                    { // Blink Mode
                        currentPic.Image = Properties.Resources.flickLed;
                    }
                    else if (socketRT1.hkyModule.hkyStruct.HKYConsole[1].led[i].state == 1)
                    {
                        currentPic.Image = Properties.Resources.onLed;
                    }
                    else
                    {
                        currentPic.Image = Properties.Resources.offLed;
                    }

                    Label labelName = new Label();
                    labelName.Size = new Size(190, 100);

                    labelName.Name = "Console2Led" + i.ToString() + "_label";
                    labelName.Text = socketRT1.hkyModule.ledIntToEnum(i).ToString();
                    labelName.TextAlign = ContentAlignment.TopCenter;

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Name = "Console2flp" + i.ToString();

                    flp.FlowDirection = FlowDirection.LeftToRight;

                    flp.Size = new Size(200, 100);
                    flp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
                    flp.BorderStyle = BorderStyle.FixedSingle;

                    flp.Controls.Add(currentPic);
                    flp.Controls.Add(labelName);


                    //get prev item
                    Control[] cntrl = ledHKYConsole2_flowLayoutPanel.Controls.Find(flp.Name, true);
                    if (cntrl.Length > 0)
                    {
                        FlowLayoutPanel clusterCpyflp = (FlowLayoutPanel)cntrl[0]; // the image and label element
                        cntrl = clusterCpyflp.Controls.Find(currentPic.Name, true); // the image element
                        PictureBox prevPic = (PictureBox)cntrl[0];

                        if (prevPic.Image != currentPic.Image)
                        {//update View with current Picture
                            prevPic.Image = currentPic.Image;
                            prevPic.Name = currentPic.Name;
                        }
                    }

                    else
                    { // first time
                        ledHKYConsole2_flowLayoutPanel.Controls.Add(flp);
                    }
                }
                
                /* Draw Keys - Console 2*/
                for (int i = 0; i < socketRT1.hkyModule.hkyStruct.num_of_key; i++)
                {
                    PictureBox currentPic = new PictureBox();
                    currentPic.Name = "keyPic" + i.ToString();
                    currentPic.Size = new System.Drawing.Size(60, 52);
                    currentPic.Margin = new System.Windows.Forms.Padding(60, 0, 0, 0);


                    if (socketRT1.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].state == 1)
                    { //pressed
                        currentPic.Image = Properties.Resources.pressed_button;
                    }
                    else
                    { // Not pressed
                        currentPic.Image = Properties.Resources.unpressed_button;
                    }

                    Label keysNameLabel = new Label();
                    keysNameLabel.Size = new Size(190, 12);
                    keysNameLabel.Name = "Console1Keys" + i.ToString() + "_label";
                    keysNameLabel.Text = socketRT1.hkyModule.keysIntToEnum(i).ToString();
                    keysNameLabel.TextAlign = ContentAlignment.TopCenter;
                    keysNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    keysNameLabel.Font = new Font(keysNameLabel.Font, FontStyle.Bold);

                    Label type = new Label();
                    type.Size = new Size(190, 20);
                    type.Name = "Console1KeysType" + i.ToString() + "_label";
                    type.Text = "Type: " + socketRT1.hkyModule.functionIntToEnum((int)socketRT1.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].type);
                    type.TextAlign = ContentAlignment.TopCenter;
                    type.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);

                    Label currDisc = new Label();
                    currDisc.Size = new Size(190, 20);
                    currDisc.Name = "Console1KeysDesc1" + i.ToString() + "_label";
                    if (socketRT1.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].type == 0)
                    {
                        currDisc.Text = "dis_1: " + socketRT1.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].discr[0].state.ToString();
                    }
                    else
                    {
                        currDisc.Text = "dis_1: " + socketRT1.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].discr[0].state.ToString() + "    |    dis_2: " + socketRT1.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].discr[1].state.ToString();
                    }

                    currDisc.TextAlign = ContentAlignment.TopCenter;
                    currDisc.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Name = "Console1flp" + i.ToString();

                    flp.FlowDirection = FlowDirection.LeftToRight;
                    flp.Size = new Size(200, 110);
                    flp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
                    flp.BorderStyle = BorderStyle.FixedSingle;

                    flp.Controls.Add(keysNameLabel);
                    flp.Controls.Add(currentPic);
                    flp.Controls.Add(type);
                    flp.Controls.Add(currDisc);

                    //get prev item
                    Control[] cntrl = keysHKYConsole2_flowLayoutPanel.Controls.Find(flp.Name, true);
                    if (cntrl.Length > 0)
                    {
                        FlowLayoutPanel clusterCpyflp = (FlowLayoutPanel)cntrl[0]; // the image and label element
                        cntrl = clusterCpyflp.Controls.Find(currentPic.Name, true); // the image element
                        PictureBox prevPic = (PictureBox)cntrl[0];

                        if (prevPic.Image != currentPic.Image)
                        {//update View with current Picture
                            prevPic.Image = currentPic.Image;
                            prevPic.Name = currentPic.Name;
                        }

                        cntrl = clusterCpyflp.Controls.Find(currDisc.Name, true); // the Disc element
                        Label prevDisc = (Label)cntrl[0];
                        if (prevDisc.Text != currDisc.Text)
                        {
                            prevDisc.Text = currDisc.Text;
                        }

                    }

                    else
                    { // first time
                        keysHKYConsole2_flowLayoutPanel.Controls.Add(flp);
                    }
                }

                DisplayHNDataOfConsole(socketRT1.hkyModule.hkyStruct.HKYConsole[0], 1);

                DisplayHNDataOfConsole(socketRT1.hkyModule.hkyStruct.HKYConsole[1], 2);


            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                /*Console 1*/

                SetTailNumOfLeds(this.hkyConsole1Tail_textBox, "1", socketRT2.rtiModule.BL_LOPTable);

                for (int i = 0; i < socketRT2.hkyModule.hkyStruct.num_of_led; i++)
                {
                    PictureBox currentPic = new PictureBox();
                    currentPic.Name = "ledPic" + i.ToString();
                    currentPic.SizeMode = PictureBoxSizeMode.Normal;
                    currentPic.Margin = new System.Windows.Forms.Padding(80, 5, 0, 0);

                    if (socketRT2.hkyModule.hkyStruct.HKYConsole[0].led[i].mode == 2)
                    { // Blink Mode
                        currentPic.Image = Properties.Resources.flickLed;
                    }
                    else if (socketRT2.hkyModule.hkyStruct.HKYConsole[0].led[i].state == 1)
                    {
                        currentPic.Image = Properties.Resources.onLed;
                    }
                    else
                    {
                        currentPic.Image = Properties.Resources.offLed;
                    }

                    Label newLabel = new Label();
                    newLabel.Size = new Size(190, 100);

                    newLabel.Name = "Console1Led" + i.ToString() + "_label";
                    newLabel.Text = socketRT2.hkyModule.ledIntToEnum(i).ToString();
                    newLabel.TextAlign = ContentAlignment.TopCenter;

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Name = "Console1flp" + i.ToString();

                    flp.FlowDirection = FlowDirection.LeftToRight;

                    flp.Size = new Size(200, 100);
                    flp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
                    flp.BorderStyle = BorderStyle.FixedSingle;

                    flp.Controls.Add(currentPic);
                    flp.Controls.Add(newLabel);


                    //get prev item
                    Control[] cntrl = ledHKYConsole1_flowLayoutPanel.Controls.Find(flp.Name, true);
                    if (cntrl.Length > 0)
                    {
                        FlowLayoutPanel clusterCpyflp = (FlowLayoutPanel)cntrl[0]; // the image and label element
                        cntrl = clusterCpyflp.Controls.Find(currentPic.Name, true); // the image element
                        PictureBox prevPic = (PictureBox)cntrl[0];

                        if (prevPic.Image != currentPic.Image)
                        {//update View with current Picture
                            prevPic.Image = currentPic.Image;
                            prevPic.Name = currentPic.Name;
                        }
                    }

                    else
                    { // first time
                        ledHKYConsole1_flowLayoutPanel.Controls.Add(flp);
                    }

                }

                /* Draw Keys - RT2 Console 1*/
                for (int i = 0; i < socketRT2.hkyModule.hkyStruct.num_of_key; i++)
                {
                    PictureBox currentPic = new PictureBox();
                    currentPic.Name = "keyPic" + i.ToString();
                    currentPic.Size = new System.Drawing.Size(60, 52);
                    currentPic.Margin = new System.Windows.Forms.Padding(60, 0, 0, 0);

                    if (socketRT2.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].state == 1)
                    { //pressed
                        currentPic.Image = Properties.Resources.pressed_button;
                    }
                    else
                    { // Not pressed
                        currentPic.Image = Properties.Resources.unpressed_button;
                    }

                    Label keysNameLabel = new Label();
                    keysNameLabel.Size = new Size(190, 12);
                    keysNameLabel.Name = "Console1Keys" + i.ToString() + "_label";
                    keysNameLabel.Text = socketRT2.hkyModule.keysIntToEnum(i).ToString();
                    keysNameLabel.TextAlign = ContentAlignment.TopCenter;
                    keysNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    keysNameLabel.Font = new Font(keysNameLabel.Font, FontStyle.Bold);

                    Label type = new Label();
                    type.Size = new Size(190, 20);
                    type.Name = "Console1KeysType" + i.ToString() + "_label";
                    type.Text = "Type: " + socketRT2.hkyModule.functionIntToEnum((int)socketRT2.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].type);
                    type.TextAlign = ContentAlignment.TopCenter;
                    type.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);

                    Label currDisc = new Label();
                    currDisc.Size = new Size(190, 20);
                    currDisc.Name = "Console1KeysDesc1" + i.ToString() + "_label";
                    if (socketRT2.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].type == 0)
                    {
                        currDisc.Text = "dis_1: " + socketRT2.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].discr[0].state.ToString();
                    }
                    else
                    {
                        currDisc.Text = "dis_1: " + socketRT2.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].discr[0].state.ToString() + "    |    dis_2: " + socketRT2.hkyModule.hkyStruct.HKYConsole[0].trans[0].hhky[i].discr[1].state.ToString();
                    }

                    currDisc.TextAlign = ContentAlignment.TopCenter;
                    currDisc.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Name = "Console1flp" + i.ToString();

                    flp.FlowDirection = FlowDirection.LeftToRight;

                    flp.Size = new Size(200, 110);
                    flp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
                    flp.BorderStyle = BorderStyle.FixedSingle;

                    flp.Controls.Add(keysNameLabel);
                    flp.Controls.Add(currentPic);
                    flp.Controls.Add(type);
                    flp.Controls.Add(currDisc);

                    //get prev item
                    Control[] cntrl = keysHKYConsole1_flowLayoutPanel.Controls.Find(flp.Name, true);
                    if (cntrl.Length > 0)
                    {
                        FlowLayoutPanel clusterCpyflp = (FlowLayoutPanel)cntrl[0]; // the image and label element
                        cntrl = clusterCpyflp.Controls.Find(currentPic.Name, true); // the image element
                        PictureBox prevPic = (PictureBox)cntrl[0];

                        if (prevPic.Image != currentPic.Image)
                        {//update View with current Picture
                            prevPic.Image = currentPic.Image;
                            prevPic.Name = currentPic.Name;
                        }

                        cntrl = clusterCpyflp.Controls.Find(currDisc.Name, true); // the Disc element
                        Label prevDisc = (Label)cntrl[0];
                        if (prevDisc.Text != currDisc.Text)
                        {
                            prevDisc.Text = currDisc.Text;
                        }

                    }

                    else
                    { // first time
                        keysHKYConsole1_flowLayoutPanel.Controls.Add(flp);
                    }
                }


                /*Console 2*/
                SetTailNumOfLeds(this.hkyConsole2Tail_textBox, "2", socketRT2.rtiModule.BL_LOPTable);

                for (int i = 0; i < socketRT2.hkyModule.hkyStruct.num_of_led; i++)
                {
                    PictureBox currentPic = new PictureBox();
                    currentPic.Name = "ledPic" + i.ToString();
                    currentPic.SizeMode = PictureBoxSizeMode.Normal;
                    currentPic.Margin = new System.Windows.Forms.Padding(80, 5, 0, 0);

                    if (socketRT2.hkyModule.hkyStruct.HKYConsole[1].led[i].mode == 2)
                    { // Blink Mode
                        currentPic.Image = Properties.Resources.flickLed;
                    }
                    else if (socketRT2.hkyModule.hkyStruct.HKYConsole[1].led[i].state == 1)
                    {
                        currentPic.Image = Properties.Resources.onLed;
                    }
                    else
                    {
                        currentPic.Image = Properties.Resources.offLed;
                    }

                    Label newLabel = new Label();
                    newLabel.Size = new Size(190, 100);

                    newLabel.Name = "Console2Led" + i.ToString() + "_label";
                    newLabel.Text = socketRT2.hkyModule.ledIntToEnum(i).ToString();
                    newLabel.TextAlign = ContentAlignment.TopCenter;

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Name = "Console2flp" + i.ToString();

                    flp.FlowDirection = FlowDirection.LeftToRight;

                    flp.Size = new Size(200, 100);
                    flp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
                    flp.BorderStyle = BorderStyle.FixedSingle;

                    flp.Controls.Add(currentPic);
                    flp.Controls.Add(newLabel);


                    //get prev item
                    Control[] cntrl = ledHKYConsole2_flowLayoutPanel.Controls.Find(flp.Name, true);
                    if (cntrl.Length > 0)
                    {
                        FlowLayoutPanel clusterCpyflp = (FlowLayoutPanel)cntrl[0]; // the image and label element
                        cntrl = clusterCpyflp.Controls.Find(currentPic.Name, true); // the image element
                        PictureBox prevPic = (PictureBox)cntrl[0];

                        if (prevPic.Image != currentPic.Image)
                        {//update View with current Picture
                            prevPic.Image = currentPic.Image;
                            prevPic.Name = currentPic.Name;
                        }
                    }

                    else
                    { // first time
                        ledHKYConsole2_flowLayoutPanel.Controls.Add(flp);
                    }
                }

                /* Draw Keys - RT2 Console 2*/
                for (int i = 0; i < socketRT2.hkyModule.hkyStruct.num_of_key; i++)
                {
                    PictureBox currentPic = new PictureBox();
                    currentPic.Name = "keyPic" + i.ToString();
                    currentPic.Size = new System.Drawing.Size(60, 52);
                    currentPic.Margin = new System.Windows.Forms.Padding(60, 0, 0, 0);

                    if (socketRT2.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].state == 1)
                    { //pressed
                        currentPic.Image = Properties.Resources.pressed_button;
                    }
                    else
                    { // Not pressed
                        currentPic.Image = Properties.Resources.unpressed_button;
                    }

                    Label keysNameLabel = new Label();
                    keysNameLabel.Size = new Size(190, 12);
                    keysNameLabel.Name = "Console1Keys" + i.ToString() + "_label";
                    keysNameLabel.Text = socketRT2.hkyModule.keysIntToEnum(i).ToString();
                    keysNameLabel.TextAlign = ContentAlignment.TopCenter;
                    keysNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    keysNameLabel.Font = new Font(keysNameLabel.Font, FontStyle.Bold);

                    Label type = new Label();
                    type.Size = new Size(190, 20);
                    type.Name = "Console1KeysType" + i.ToString() + "_label";
                    type.Text = "Type: " + socketRT2.hkyModule.functionIntToEnum((int)socketRT2.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].type);
                    type.TextAlign = ContentAlignment.TopCenter;
                    type.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);

                    Label currDisc = new Label();
                    currDisc.Size = new Size(190, 20);
                    currDisc.Name = "Console1KeysDesc1" + i.ToString() + "_label";
                    if (socketRT2.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].type == 0)
                    {
                        currDisc.Text = "dis_1: " + socketRT2.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].discr[0].state.ToString();
                    }
                    else
                    {
                        currDisc.Text = "dis_1: " + socketRT2.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].discr[0].state.ToString() + "    |    dis_2: " + socketRT2.hkyModule.hkyStruct.HKYConsole[1].trans[0].hhky[i].discr[1].state.ToString();
                    }

                    currDisc.TextAlign = ContentAlignment.TopCenter;
                    currDisc.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    flp.Name = "Console1flp" + i.ToString();

                    flp.FlowDirection = FlowDirection.LeftToRight;

                    flp.Size = new Size(200, 110);
                    flp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
                    flp.BorderStyle = BorderStyle.FixedSingle;

                    flp.Controls.Add(keysNameLabel);
                    flp.Controls.Add(currentPic);
                    flp.Controls.Add(type);
                    flp.Controls.Add(currDisc);

                    //get prev item
                    Control[] cntrl = keysHKYConsole2_flowLayoutPanel.Controls.Find(flp.Name, true);
                    if (cntrl.Length > 0)
                    {
                        FlowLayoutPanel clusterCpyflp = (FlowLayoutPanel)cntrl[0]; // the image and label element
                        cntrl = clusterCpyflp.Controls.Find(currentPic.Name, true); // the image element
                        PictureBox prevPic = (PictureBox)cntrl[0];

                        if (prevPic.Image != currentPic.Image)
                        {//update View with current Picture
                            prevPic.Image = currentPic.Image;
                            prevPic.Name = currentPic.Name;
                        }

                        cntrl = clusterCpyflp.Controls.Find(currDisc.Name, true); // the Disc element
                        Label prevDisc = (Label)cntrl[0];
                        if (prevDisc.Text != currDisc.Text)
                        {
                            prevDisc.Text = currDisc.Text;
                        }

                    }

                    else
                    { // first time
                        keysHKYConsole2_flowLayoutPanel.Controls.Add(flp);
                    }
                }

                DisplayHNDataOfConsole(socketRT2.hkyModule.hkyStruct.HKYConsole[0], 1);

                DisplayHNDataOfConsole(socketRT2.hkyModule.hkyStruct.HKYConsole[1], 2);

            }

        }

        private void DisplayHNDataOfConsole(RT_Viewer.Framework.HKYModule.HKYEntry pEntry, int pConsole)
        {
            if (pConsole == 1)
            {
                HN1Read1_textBox.Text = pEntry.HeadingData.position_buf1.ToString();
                HN1Read2_textBox.Text = pEntry.HeadingData.position_buf2.ToString();
                HN1Read3_textBox.Text = pEntry.HeadingData.position_buf3.ToString();
                HN1Read4_textBox.Text = pEntry.HeadingData.position_buf4.ToString();

                HN1Calculated_textBox.Text = pEntry.HeadingData.calculated_crc.ToString();

                HN1_raw_position_textBox.Text = Convert.ToString(pEntry.HeadingData.raw_position, 2);

                if (pEntry.HeadingData.isInitOK != 0)
                {
                    HN1InitStatus_textBox.Text = "OK";
                }
                else
                {
                    HN1InitStatus_textBox.Text = "FAIL";
                }

                HN1VendorID1_textBox.Text = Convert.ToChar(pEntry.HeadingData.vendor_id1).ToString() + "(" + pEntry.HeadingData.vendor_id1.ToString() + ")";

                HN1VendorID2_textBox.Text = Convert.ToChar(pEntry.HeadingData.vendor_id2).ToString() + "(" + pEntry.HeadingData.vendor_id2.ToString() + ")";

                HN1VendorID3_textBox.Text = Convert.ToChar(pEntry.HeadingData.vendor_id3).ToString() + "(" + pEntry.HeadingData.vendor_id3.ToString() + ")";

                HN1Position_textBox.Text = pEntry.HeadingData.scaled_position.ToString();

            }
            else // 2
            {
                HN2Read1_textBox.Text = pEntry.HeadingData.position_buf1.ToString();
                HN2Read2_textBox.Text = pEntry.HeadingData.position_buf2.ToString();
                HN2Read3_textBox.Text = pEntry.HeadingData.position_buf3.ToString();
                HN2Read4_textBox.Text = pEntry.HeadingData.position_buf4.ToString();

                HN2Calculated_textBox.Text = pEntry.HeadingData.calculated_crc.ToString();

                HN2_raw_position_textBox.Text = Convert.ToString(pEntry.HeadingData.raw_position, 2);

                if (pEntry.HeadingData.isInitOK != 0)
                {
                    HN2InitStatus_textBox.Text = "OK";
                }
                else
                {
                    HN2InitStatus_textBox.Text = "FAIL";
                }

                HN2VendorID1_textBox.Text = Convert.ToChar(pEntry.HeadingData.vendor_id1).ToString() + "(" + pEntry.HeadingData.vendor_id1.ToString() + ")";

                HN2VendorID2_textBox.Text = Convert.ToChar(pEntry.HeadingData.vendor_id2).ToString() + "(" + pEntry.HeadingData.vendor_id2.ToString() + ")";

                HN2VendorID3_textBox.Text = Convert.ToChar(pEntry.HeadingData.vendor_id3).ToString() + "(" + pEntry.HeadingData.vendor_id3.ToString() + ")";

                HN2Position_textBox.Text = pEntry.HeadingData.scaled_position.ToString();


            }

        }



        /*######################
         #    PFD Event         #
         ######################*/
        public void PFDEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(PFDEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                short pitch = (short)socketRT1.pfdModule.pfdData.pitch;
                short roll  = (short)socketRT1.pfdModule.pfdData.roll;
                
                rollData_textBox.Text  = roll.ToString();
                pitchData_textBox.Text = pitch.ToString();
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
               
                short pitch = (short)socketRT2.pfdModule.pfdData.pitch;
                short roll  = (short)socketRT2.pfdModule.pfdData.roll;
                
                rollData_textBox.Text  = roll.ToString();
                pitchData_textBox.Text = pitch.ToString();
            }
        }


        /*######################
        #    IRD Event         #
        ######################*/
        public void IRDEventHandler(Object sender, IModuleEventArgs e)
        {
            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(IRDEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }
            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {

                //update datasource
                iridium_dataGridView.DataSource = socketRT1.irdModule.BL_IRDModemTable;
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                //update datasource
                iridium_dataGridView.DataSource = socketRT2.irdModule.BL_IRDModemTable;
            }
        }

        /*######################
         #    MGC Event        #
         ######################*/
        public void MGCEventHandler(Object sender, IModuleEventArgs e)
        {

            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(MGCEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            // Do the work...
            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                if (socketRT1.mgcModule.BL_MGCGru1ConfTable != null)
                {
                    gru1Info_dataGridView.DataSource = socketRT1.mgcModule.BL_MGCGru1ConfTable;
                    gru1Info_dataGridView.Refresh();
                }
                if (socketRT1.mgcModule.BL_MGCGru2ConfTable != null)
                {
                    gru2Info_dataGridView.DataSource = socketRT1.mgcModule.BL_MGCGru2ConfTable;
                    gru2Info_dataGridView.Refresh();
                }
                if (socketRT1.mgcModule.BL_MGCGru3ConfTable != null)
                {
                    gru3Info_dataGridView.DataSource = socketRT1.mgcModule.BL_MGCGru3ConfTable;
                    gru3Info_dataGridView.Refresh();
                }
                if (socketRT1.mgcModule.BL_MGCGru4ConfTable != null)
                {
                    gru4Info_dataGridView.DataSource = socketRT1.mgcModule.BL_MGCGru4ConfTable;
                    gru4Info_dataGridView.Refresh();
                }
                if (socketRT1.mgcModule.BL_MGCGru5ConfTable != null)
                {
                    gru5Info_dataGridView.DataSource = socketRT1.mgcModule.BL_MGCGru5ConfTable;
                    gru5Info_dataGridView.Refresh();
                }

                hstGruConfTable_dataGridView.DataSource = socketRT1.mgcModule.BL_HSTGruConfTable;
                hstGruConfTable_dataGridView.Refresh();

                HstGruConfTableCntr_textBox.Text = socketRT1.mgcModule.mgcStruct.infoTable.ReceivedCntrMsg.ToString();
                for (int i = 0; i < MGCModule.MAX_NUM_OF_GRU; i++)
                {
                    if (socketRT1.mgcModule.mgcStruct.infoTable.infoTableEntry[i].is_alive == 1)
                    {
                        switch (i)
                        {

                            case (int)MGCModule.GRU_NUMBER.GRU1:
                                gru1Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU2:
                                gru2Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU3:
                                gru3Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU4:
                                gru4Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU5:
                                gru5Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                        }
                    }
                    else
                    {
                        switch (i)
                        {

                            case (int)MGCModule.GRU_NUMBER.GRU1:
                                gru1Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU2:
                                gru2Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU3:
                                gru3Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU4:
                                gru4Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU5:
                                gru5Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                        }
                    }
                }
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                if (socketRT2.mgcModule.BL_MGCGru1ConfTable != null)
                {
                    gru1Info_dataGridView.DataSource = socketRT2.mgcModule.BL_MGCGru1ConfTable;
                    gru1Info_dataGridView.Refresh();
                }
                if (socketRT2.mgcModule.BL_MGCGru2ConfTable != null)
                {
                    gru2Info_dataGridView.DataSource = socketRT2.mgcModule.BL_MGCGru2ConfTable;
                    gru2Info_dataGridView.Refresh();
                }
                if (socketRT2.mgcModule.BL_MGCGru3ConfTable != null)
                {
                    gru3Info_dataGridView.DataSource = socketRT2.mgcModule.BL_MGCGru3ConfTable;
                    gru3Info_dataGridView.Refresh();
                }
                if (socketRT2.mgcModule.BL_MGCGru4ConfTable != null)
                {
                    gru4Info_dataGridView.DataSource = socketRT2.mgcModule.BL_MGCGru4ConfTable;
                    gru4Info_dataGridView.Refresh();
                }
                if (socketRT2.mgcModule.BL_MGCGru5ConfTable != null)
                {
                    gru5Info_dataGridView.DataSource = socketRT2.mgcModule.BL_MGCGru5ConfTable;
                    gru5Info_dataGridView.Refresh();
                }

                hstGruConfTable_dataGridView.DataSource = socketRT2.mgcModule.BL_HSTGruConfTable;
                hstGruConfTable_dataGridView.Refresh();

                HstGruConfTableCntr_textBox.Text = socketRT2.mgcModule.mgcStruct.infoTable.ReceivedCntrMsg.ToString();

                for (int i = 0; i < MGCModule.MAX_NUM_OF_GRU; i++)
                {
                    if (socketRT2.mgcModule.mgcStruct.infoTable.infoTableEntry[i].is_alive == 1)
                    {
                        switch (i)
                        {

                            case (int)MGCModule.GRU_NUMBER.GRU1:
                                gru1Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU2:
                                gru2Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU3:
                                gru3Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU4:
                                gru4Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU5:
                                gru5Conection_pictureBox.Image = Properties.Resources.greedLed;
                                break;
                        }
                    }
                    else
                    {
                        switch (i)
                        {

                            case (int)MGCModule.GRU_NUMBER.GRU1:
                                gru1Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU2:
                                gru2Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU3:
                                gru3Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU4:
                                gru4Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                            case (int)MGCModule.GRU_NUMBER.GRU5:
                                gru5Conection_pictureBox.Image = Properties.Resources.redLed;
                                break;
                        }
                    }
                }
            }

        }

        private void startListening_click(object sender, EventArgs e)
        {
            //Start Listening
            if (socketRT1.startListening() && socketRT2.startListening())
            {
                startRecieve_button.Enabled = false;
                stopRecieve_button.Enabled = true;
                pause_button.Enabled = true;
                cleanScreen_button.Enabled = true;
                EnableKnobButtons();

            }
            Thread.Sleep(200);
        }

        private void continuePause_Click(object sender, EventArgs e)
        {
            if (socketRT1.isSocketPaused == false)
            {

                pause_button.Enabled = true;
                startRecieve_button.Enabled = false;
                socketRT1.isListening = false;
                socketRT2.isListening = false;
                pause_button.Text = "Continue";
                socketRT1.isSocketPaused = true;
                socketRT2.isSocketPaused = true;
            }
            else
            {
                pause_button.Enabled = true;
                startRecieve_button.Enabled = false;
                socketRT1.isListening = true;
                socketRT2.isListening = true;
                pause_button.Text = "Pause";
                socketRT1.isSocketPaused = false;
                socketRT2.isSocketPaused = false;
            }



        }

        private void stopListening_Click(object sender, EventArgs e)
        { // stop listening

            socketRT1.stopListening();
            socketRT2.stopListening();
            socketRT1.listeningThread.Abort();
            socketRT2.listeningThread.Abort();

            startRecieve_button.Enabled = true;
            stopRecieve_button.Enabled = false;
            pause_button.Enabled = false;
            setRTLogLevel_button.Enabled = false;
            undoRTCLogLevel_Button.Enabled = false;
            setRTLogLevelForAllModules_button.Enabled = false;
            setLogLevelForAllModules_comboBox.Enabled = false;

        }

        private void cleanData_click(object sender, EventArgs e)
        {//Clean view

            /* Clear DataGridView */
            uplTable_dataGridView.Rows.Clear();
            lopTable_dataGridView.Rows.Clear();
            uavTable_dataGridView.Rows.Clear();
            hstTable_dataGridView.Rows.Clear();
            uavRtiTable_dataGridView.Rows.Clear();

            setRTLogLevel_dataGridView.DataSource = null; // importent null DataSource before clean Rows and columns!
            setRTLogLevel_dataGridView.Columns.Clear();
            setRTLogLevel_dataGridView.Rows.Clear();

            setRTCLoggerFilter_dataGridView.DataSource = null; // importent null DataSource before clean Rows and columns!
            setRTCLoggerFilter_dataGridView.Columns.Clear();
            setRTCLoggerFilter_dataGridView.Rows.Clear();

            frm_dataGridView.Rows.Clear();
            stick_dataGridView.Rows.Clear();
            iridium_dataGridView.Rows.Clear();

            hkyConsole1Tail_textBox.Text = "N/A";
            hkyConsole2Tail_textBox.Text = "N/A";

            ledHKYConsole1_flowLayoutPanel.Controls.Clear();
            ledHKYConsole2_flowLayoutPanel.Controls.Clear();

            hstGruConfTable_dataGridView.Rows.Clear();
            gru1Info_dataGridView.Rows.Clear();
            gru2Info_dataGridView.Rows.Clear();
            gru3Info_dataGridView.Rows.Clear();
            gru4Info_dataGridView.Rows.Clear();
            gru5Info_dataGridView.Rows.Clear();

            /* Clean offline parameters*/
            offlineParam_dataGridView.DataSource = null; // importent null DataSource before clean Rows and columns!
            offlineParam_dataGridView.Columns.Clear();
            offlineParam_dataGridView.Rows.Clear();
            socketRT1.offModule.setFirstTime(true);
            socketRT2.offModule.setFirstTime(true);
            
            /*Clean LOG*/
            clearLogContent_button_Click(sender, e);

            /* Clear images*/
            kaRX_pictureBox.Image = Properties.Resources.redLed;
            kaTX_pictureBox.Image = Properties.Resources.redLed;

            gru1Conection_pictureBox.Image = Properties.Resources.redLed;
            gru2Conection_pictureBox.Image = Properties.Resources.redLed;
            gru3Conection_pictureBox.Image = Properties.Resources.redLed;
            gru4Conection_pictureBox.Image = Properties.Resources.redLed;
            gru5Conection_pictureBox.Image = Properties.Resources.redLed;

            socketRT1.appModule.isRTAPPArrived = false;
            socketRT2.appModule.isRTAPPArrived = false;

            /* Clear TextBox */
            hstCounter_textBox.Clear();
            lopCounter_textBox.Clear();
            uavCounter_textBox.Clear();
            mainRTCounter_textBox.Clear();
            transactionMode_textBox.Clear();
            keepAliveRXCntr_textBox.Clear();
            keepAliveTXCntr_textBox.Clear();
            rtComStatus_textBox.Clear();
            rtStatus_textBox.Clear();
            rtVersion_textBox.Clear();
            buildDate_textBox.Clear();
            frmFaultCntr_textBox.Clear();
            frmFaultMaxRecords_textBox.Clear();
            timeStamp_textBox.Clear();
            utc_textBox.Clear();
            timestampConvert_textBox.Clear();
            utcConvert_textBox.Clear();
            idGcsReadData_textBox.Clear();
            hkyConsole1Tail_textBox.Clear();
            hkyConsole2Tail_textBox.Clear();
            hbsVersion_textBox.Clear();
            ipRT1_textBox.Clear(); 
            ipRT2_textBox.Clear();
            rtDefualtGatway_textBox.Clear();
            rtMode_textBox.Clear();
            ntpServerIP_textBox.Clear();
            //user should reload log file
            filterByStringInLog_button.Enabled = false;
            stopFilterByStringInLog_button.Enabled = false;
            logContent_textBox.Text = "";
            HstGruConfTableCntr_textBox.Text = "";
            setLogFilter_button.Enabled = false;

            /* Clear Labels */
            gru1Configure_label.Text = "Not Configured";
            gru2Configure_label.Text = "Not Configured";
            gru3Configure_label.Text = "Not Configured";
            gru4Configure_label.Text = "Not Configured";
            gru5Configure_label.Text = "Not Configured";
        }


        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            bool isSocketRT1Connected = socketRT1.isSocketConnected();
            bool isSocketRT2Connected = socketRT2.isSocketConnected();

            if (isSocketRT1Connected == false)
            {
                socketRT1.isRTCTXSocketInit = false; // connection lost, try reconnect TX Socket when recived message from RT
            }

            if (isSocketRT2Connected == false)
            {
                socketRT2.isRTCTXSocketInit = false; // connection lost, try reconnect TX Socket when recived message from RT
            }

            /* Check if Writing request doesnt return yet */
            if (socketRT1.nvmModule.isWritingRequested)
            {
                socketRT1.nvmModule.timeElapsedSinceRequest++;
                if (socketRT1.nvmModule.timeElapsedSinceRequest > 10)
                {//Write NVRAM Failed
                    loadingNVRAMWrite_pictureBox.Image = Properties.Resources.Error;

                }
            }

            if (socketRT2.nvmModule.isWritingRequested)
            {
                socketRT2.nvmModule.timeElapsedSinceRequest++;
                if (socketRT2.nvmModule.timeElapsedSinceRequest > 10)
                {//Write NVRAM Failed
                    loadingNVRAMWrite_pictureBox.Image = Properties.Resources.Error;
                }
            }


            if (isRTC1Presented)
            {
                if (isSocketRT1Connected == true)
                {
                    rtComStatus_pictureBox.Image = Properties.Resources.greedLed;
                    rtComStatus_textBox.Text = socketRT1.ipRX.ToString() + ":" + socketRT1.portNumberRX;
                    setRTLogLevel_button.Enabled = true;
                    undoRTCLogLevel_Button.Enabled = true;
                    setRTLogLevelForAllModules_button.Enabled = true;
                    setLogLevelForAllModules_comboBox.Enabled = true;
                    filterByStringInLog_button.Enabled = true;
                }
                else
                {
                    rtComStatus_pictureBox.Image = Properties.Resources.redLed;
                    rtComStatus_textBox.Text = "N/A";
                    setRTLogLevel_button.Enabled = false;
                    undoRTCLogLevel_Button.Enabled = false;
                    setRTLogLevelForAllModules_button.Enabled = false;
                    if (isOnlineSearch_radioButton.Checked == true)
                    {
                        filterByStringInLog_button.Enabled = false;
                    }
                    

                }
            }
            else
            {
                if (isSocketRT2Connected == true)
                {
                    rtComStatus_pictureBox.Image = Properties.Resources.greedLed;
                    rtComStatus_textBox.Text = socketRT2.ipRX.ToString() + ":" + socketRT2.portNumberRX;
                    setRTLogLevel_button.Enabled = true;
                    undoRTCLogLevel_Button.Enabled = true;
                    setRTLogLevelForAllModules_button.Enabled = true;
                    setLogLevelForAllModules_comboBox.Enabled = true;
                    reloadLogFile_button.Enabled = true;
                }
                else
                {
                    rtComStatus_pictureBox.Image = Properties.Resources.redLed;
                    rtComStatus_textBox.Text = "N/A";
                    setRTLogLevel_button.Enabled = false;
                    undoRTCLogLevel_Button.Enabled = false;
                    setRTLogLevelForAllModules_button.Enabled = false;
                    setLogLevelForAllModules_comboBox.Enabled = false;
                }
            }

        }


        private void RTViewerForm_Load(object sender, EventArgs e)
        {
            this.gcsIdTextBox.Text = SettingsHandler.selectedGcsID;
        }



        private void uplTable_groupBox_Enter(object sender, EventArgs e)
        {

        }


        private void RTCLogger_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void logContent_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void startStopRTCLogger_Click(object sender, EventArgs e)
        {

            if (LOGModule.isRTCLoggerWorking)
            {//Stop RTCLogger
                socketRT1.logModule.stopRTCLogeer();

            }
            else
            {//Start RTCLogger
                socketRT1.logModule.startRTCLogger();
            }

        }


        private void dnlTable_groupBox_Enter(object sender, EventArgs e)
        {

        }


        private void ntpGroupBox_Enter(object sender, EventArgs e)
        {

        }


        private void hstMsgCnter_groupBox_Enter(object sender, EventArgs e)
        {

        }


        private void taxi_label_Click(object sender, EventArgs e)
        {

        }


        private void nvramReadData_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void keepAliveRX_label_Click(object sender, EventArgs e)
        {

        }

        private void idGCSReadData_TextChanged(object sender, EventArgs e)
        {

        }

        private void idGCSWriteData_TextChanged(object sender, EventArgs e)
        {

        }


        private void uplTable_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rtiCounter_texBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rti_tabPage_Click(object sender, EventArgs e)
        {

        }

        private void rtiMainStatus_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uavTable_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rtComStatus_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logContent_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*Show About form only with one instance*/
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutForm == null || aboutForm.Text == "")
            {
                aboutForm = new AboutForm();
                aboutForm.Dock = DockStyle.Fill;
                aboutForm.Show();
            }
            else if (CheckFormAlreadyOpened(aboutForm.Text))
            {
                aboutForm.WindowState = FormWindowState.Normal;
                aboutForm.Dock = DockStyle.Fill;
                aboutForm.Show();
                aboutForm.Focus();
            }       
        }


        private void filterByStringInLog_button_Click(object sender, EventArgs e)
        {
            string searchString = searchStringInLog_textBox.Text;
            bool isCaseSensitiveSearch = caseSensitiveFilterSearch_checkbox.Checked;

            DateTime startDate = logStart_dateTimePicker.Value.Date.Add(logStart_dateTimePicker.Value.TimeOfDay);
            DateTime endDate = logEnd_dateTimePicker.Value.Date.Add(logEnd_dateTimePicker.Value.TimeOfDay);
            if (logDateOperator_comboBox.Text != "<=" && logDateOperator_comboBox.Text != ">=" && logDateOperator_comboBox.Text != "-")
            {
                MessageBox.Show("ERROR: Unknown date operator (only '<=','>=' or '-' allowed!");
                return;
            }
            if (isRTC1Presented)
            {
                socketRT1.logModule.searchAndFilterByString(searchString, isCaseSensitiveSearch, startDate, endDate, logDateOperator_comboBox.Text);
            }
            else
            {
                socketRT2.logModule.searchAndFilterByString(searchString, isCaseSensitiveSearch, startDate, endDate, logDateOperator_comboBox.Text);
            }
            stopFilterByStringInLog_button.Enabled = true;
            openFilteredFile_Button.Enabled = true;
        }



        private void rt1Selceted_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            isRTC1Presented = true;
            if (rt1Selected_radioButton.Checked)
            {
                cleanData_click(null, EventArgs.Empty); //clear all data
                rt2Selected_radioButton.Checked = false;
                reloadOfflineFolder();
            }

            EnableKnobButtons();
        }

        private void rt2Selceted_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            isRTC1Presented = false;
            if (rt2Selected_radioButton.Checked)
            {
                cleanData_click(null, EventArgs.Empty); //clear all data
                rt1Selected_radioButton.Checked = false;
                reloadOfflineFolder();
            }

            EnableKnobButtons();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SetFilter_Click(object sender, EventArgs e)
        {
            if (isRTC1Presented)
            {
                socketRT1.logModule.setLogFilterLevels(setRTCLoggerFilter_dataGridView);
            }
            else
            {
                socketRT2.logModule.setLogFilterLevels(setRTCLoggerFilter_dataGridView);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kaRX_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void searchStringInLog_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getRTLogLevel_layoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vtuGetRTLogLevel_label_Click(object sender, EventArgs e)
        {

        }

        private void uavGetRTLogLevel_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setRTLogLevel_button_Click(object sender, EventArgs e)
        {
            if (isRTC1Presented)
            {
                byte[] msg = socketRT1.logModule.getSelectedRTLogLevelByteArray(setRTLogLevel_dataGridView);

                socketRT1.sendMsgToRT(msg, (int)SocketHandler.TypeOfTxMessage.CHANGE_LOG_LEVELS_TYPE, SocketHandler.enumDevice_id.RTC_1);
            }
            else
            {
                byte[] msg = socketRT2.logModule.getSelectedRTLogLevelByteArray(setRTLogLevel_dataGridView);
                socketRT2.sendMsgToRT(msg, (int)SocketHandler.TypeOfTxMessage.CHANGE_LOG_LEVELS_TYPE, SocketHandler.enumDevice_id.RTC_2);
            }
        }

        private void setRTLogLevel_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void undoRTCLogLevel_Button_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            int colIndex = 0;

            foreach (DataGridViewRow dgvRow in setRTLogLevel_dataGridView.Rows)
            {
                foreach (DataGridViewColumn dgvCol in setRTLogLevel_dataGridView.Columns)
                {
                    if (colIndex == 2)
                    {
                        setRTLogLevel_dataGridView.Rows[rowIndex].Cells[colIndex].Value = setRTLogLevel_dataGridView.Rows[rowIndex].Cells[3].Value;
                    }
                    colIndex++;
                }
                colIndex = 0;
                rowIndex++;
            }
        }

        private void setRTLogLevelForAllModules_button_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            int colIndex = 0;
            string selectedValue = setLogLevelForAllModules_comboBox.SelectedValue.ToString();
            //in case some of the coulumns has changed
            foreach (DataGridViewRow dgvRow in setRTLogLevel_dataGridView.Rows)
            {
                foreach (DataGridViewColumn dgvCol in setRTLogLevel_dataGridView.Columns)
                {

                    switch (colIndex)
                    {
                        case 2:
                            string prevValue = dgvRow.Cells[colIndex].FormattedValue.ToString();

                            if (prevValue != selectedValue)
                            {
                                setRTLogLevel_dataGridView.Rows[rowIndex].Cells[colIndex].Value = selectedValue;
                            }
                            break;
                        default:
                            break;
                    }

                    colIndex++;


                }
                colIndex = 0;
                rowIndex++;
            }

            setRTLogLevel_button_Click(null, EventArgs.Empty); // send the message
        }

        /* This Event cause edit mode in one click*/
        private void setRTLogLevel_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }

        /* This Event cause edit mode in one click*/
        private void setRTCLoggerFilter_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                var tmp = (ComboBox)datagridview.EditingControl;

                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }

        private void stopFilterByStringInLog_button_Click(object sender, EventArgs e)
        {//Stop searching...

            logContent_textBox.Clear();
            showNextLogResult_button.Enabled = false;
            showNextLogResult_button.BackColor = Color.Transparent;
            showPrevLogResult_button.Enabled = false;
            showPrevLogResult_button.BackColor = Color.Transparent;

            socketRT1.logModule.abortSearchFilter();
            socketRT2.logModule.abortSearchFilter();
   
            addLogSearchStatusContent("Cleaning search!", Color.SkyBlue);
            loadingLogFilter_pictureBox.Image = null;
            filterByStringInLog_button.Enabled = true;
            stopFilterByStringInLog_button.Enabled = false;
            logPageNumber_label.Text = "Page Number: N\\A";
        }

        private void reloadLogFile_button_Click(object sender, EventArgs e)
        {//Reload file
            bool isSuccess;
            bool isCaseSensitiveSearch = caseSensitiveFilterSearch_checkbox.Checked;
            DateTime startDate = logStart_dateTimePicker.Value.Date.Add(logStart_dateTimePicker.Value.TimeOfDay);
            DateTime endDate = logEnd_dateTimePicker.Value.Date.Add(logEnd_dateTimePicker.Value.TimeOfDay);
            if (logDateOperator_comboBox.Text != "<=" && logDateOperator_comboBox.Text != ">=" && logDateOperator_comboBox.Text != "-")
            {
                MessageBox.Show("ERROR: Unknown date operator (only <=,>= or - allowed!");
                return;
            }

            if (isRTC1Presented)
            {
                isSuccess = socketRT1.logModule.reloadLogFile(startDate, endDate, logDateOperator_comboBox.Text);
            }
            else
            {
                isSuccess = socketRT1.logModule.reloadLogFile(startDate, endDate, logDateOperator_comboBox.Text);
            }
            //enables search options
            if (isSuccess)
            {
                addLogSearchStatusContent("Reloaded folder \"" + LOGModule.INIContent.logfileDir + "\" successfully!", Color.Green);
            }
        }




        private void openFilteredFile_Button_Click(object sender, EventArgs e)
        {
            if (isRTC1Presented)
            {
                socketRT1.logModule.openSearchedLogFile();
            }
            else
            {
                socketRT2.logModule.openSearchedLogFile();
            }
        }

        private void caseSensitiveFilterSearch_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtComStatus_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void convertTimeStamp_button_Click(object sender, EventArgs e)
        {
            UInt64 timeStampInput;
            bool isNumeric = Regex.IsMatch(timestampConvert_textBox.Text.Trim(), @"^\d+$");
            if (isNumeric)
            {
                timeStampInput = Convert.ToUInt64(timestampConvert_textBox.Text);
                utcConvert_textBox.Text = NTPModule.convertTimeStampToUtc(timeStampInput);
            }
            else
            {
                utcConvert_textBox.Text = "Invalid Input";
            }

        }

        private void idGCSRead_button_Click(object sender, EventArgs e)
        {
            byte[] emptyByteArray = new byte[0];
            if (isRTC1Presented)
            {
                socketRT1.sendMsgToRT(emptyByteArray, (uint)SocketHandler.TypeOfTxMessage.READ_NVRAM_TYPE, SocketHandler.enumDevice_id.RTC_1);
            }
            else
            {
                socketRT2.sendMsgToRT(emptyByteArray, (uint)SocketHandler.TypeOfTxMessage.READ_NVRAM_TYPE, SocketHandler.enumDevice_id.RTC_2);
            }
        }

        private void idGcsWriteData_button_Click(object sender, EventArgs e)
        {
            string idToWrite = idGcsWriteData_textBox.Text;
            byte[] gcs_id = new byte[4];
            bool isNumeric = Regex.IsMatch(idToWrite, @"^\d+$");
            try
            {
                if (isNumeric == false || Convert.ToUInt64(idToWrite) > UInt32.MaxValue || Convert.ToUInt64(idToWrite) < 0)
                {
                    MessageBox.Show("Please enter only numeric and valid value to gcs_id field", "Invalid input");
                }
                else
                {
                    gcs_id = BitConverter.GetBytes(Convert.ToUInt32(idToWrite));

                    DialogResult operatorsResult = System.Windows.Forms.DialogResult.No;

                    if (gcs_id.ToString() != SettingsHandler.selectedGcsID)
                    {
                        operatorsResult = MessageBox.Show("Are you sure ? Changing GCS ID will change IP of unicast sending to RT and will prevent multicast RX", "Comm Change", MessageBoxButtons.YesNo);
                    }

                    if (operatorsResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (isRTC1Presented)
                        {
                            if (socketRT1.isSocketConnected())
                            {
                                loadingNVRAMWrite_pictureBox.Image = Properties.Resources.loading1;
                                socketRT1.sendMsgToRT(gcs_id, (uint)SocketHandler.TypeOfTxMessage.WRITE_NVRAM_TYPE, SocketHandler.enumDevice_id.RTC_1);
                                socketRT1.nvmModule.isWritingRequested = true;
                                socketRT1.nvmModule.timeElapsedSinceRequest = 0;
                            }
                            else
                            {
                                MessageBox.Show("Error: Cannot Communicate with RT1", "Communication Error");
                            }

                        }
                        else
                        {
                            if (socketRT2.isSocketConnected())
                            {
                                loadingNVRAMWrite_pictureBox.Image = Properties.Resources.loading1;
                                socketRT2.sendMsgToRT(gcs_id, (uint)SocketHandler.TypeOfTxMessage.WRITE_NVRAM_TYPE, SocketHandler.enumDevice_id.RTC_2);
                                socketRT2.nvmModule.isWritingRequested = true;
                                socketRT2.nvmModule.timeElapsedSinceRequest = 0;
                            }
                            else
                            {
                                MessageBox.Show("Error: Cannot Communicate with RT2", "Communication Error");
                            }
                        }
                    }
                    else // System.Windows.Forms.DialogResult.No
                    {
                        idGcsWriteData_textBox.Text = "";
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Runtime Error: " + exception.ToString(), "Error");
            }
        }


        private void SelectedLogFilePath_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyTimestamp_button_Click(object sender, EventArgs e)
        {
            bool isNumeric = Regex.IsMatch(timeStamp_textBox.Text, @"^\d+$");
            if (isNumeric)
            {
                timestampConvert_textBox.Text = timeStamp_textBox.Text;
            }
            else
            {
                MessageBox.Show("TimeStamp value is invalid","Can not copy timestamp");
            }
        }
        /*Show Settings form only with one instance*/
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.Text == "")
            {
                settingsForm = new SettingsForm();
                settingsForm.Dock = DockStyle.Fill;
                settingsForm.Show();
            }
            else if (CheckFormAlreadyOpened(settingsForm.Text))
            {
                settingsForm.WindowState = FormWindowState.Normal;
                settingsForm.Dock = DockStyle.Fill;
                settingsForm.Show();
                settingsForm.Focus();
            }       
        }
        /* return true if the Form is already opened*/
        private bool CheckFormAlreadyOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }



        private void logDateOperator_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (logDateOperator_comboBox.Text == "-")
            {
                logEnd_dateTimePicker.Show();
                logDateOperand1_label.Text = "Start Date";
                logDateOperand2_label.Text = "End Date";
                logDateOperand1_label.Show();
                logDateOperand2_label.Show();
            }
            else if (logDateOperator_comboBox.Text == "<=")
            {
                logDateOperand1_label.Text = "End Date";
                logEnd_dateTimePicker.Hide();
                logDateOperand2_label.Hide();
            }
            else if (logDateOperator_comboBox.Text == ">=")
            {
                logDateOperand1_label.Text = "Start Date";
                logEnd_dateTimePicker.Hide();
                logDateOperand2_label.Hide();
            }
            else
            {
                //Unknown operand
            }
        }

        private void selectLogFolder_button_Click(object sender, EventArgs e)
        {

            using (offlineFolderPath = new FolderBrowserDialog())
            {

                if (offlineFolderPath.ShowDialog() == DialogResult.OK)
                {
                    reloadOfflineFolder();
                }
            }
        }

        private void isOfflineSearch_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (isOnlineSearch_radioButton.Checked)
            {
                selectLogFolder_button.Hide();
                LOGModule.isOfflineSearch = false;
                reloadLogFile_button.Enabled = true;
                clearLogContent_button_Click(sender, e);
            }
        }

        private void isOnlineSearch_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (isOfflineSearch_radioButton.Checked)
            {
                selectLogFolder_button.Show();
                LOGModule.isOfflineSearch = true;
                reloadLogFile_button.Enabled = false;
                clearLogContent_button_Click(sender,e);
            }
        }

        private void clearLogContent_button_Click(object sender, EventArgs e)
        {
            
            addLogSearchStatusContent("Perfoming Clean", Color.Peru);
            /*Make a new search*/
            stopFilterByStringInLog_button_Click(this, EventArgs.Empty);
        }

        private void showNextLogResult_button_Click(object sender, EventArgs e)
        {
            /*Let the LOG load more search result*/
            if (LOGModule.currentNavIndexPaging <= LOGModule.MaxNavIndex || (LOGModule.stopSearchMutex.CurrentCount == 0 && LOGModule.isSearchEnded == false))
            {
                logContent_textBox.Clear();
                if (LOGModule.isSearchEnded == false)
                {/*In a search*/
                    LOGModule.stopSearchMutex.Release();
                }
                else
                {/*Not in search*/
                    LOGModule.currentNavIndexPaging++;
                    /*Show content*/
                    string content = LOGModule.navigationResult[LOGModule.currentNavIndexPaging];
                    logContent_textBox.AppendText(content);
                    if (LOGModule.currentNavIndexPaging > 0)
                    {
                        showPrevLogResult_button.Enabled = true;
                        showPrevLogResult_button.BackColor = Color.SkyBlue;
                    }
                    if (LOGModule.currentNavIndexPaging < LOGModule.MaxNavIndex)
                    {
                        showNextLogResult_button.Enabled = true;
                        showNextLogResult_button.BackColor = Color.SkyBlue;
                    }
                    else
                    {
                        showNextLogResult_button.Enabled = false;
                        showNextLogResult_button.BackColor = Color.Transparent;
                    }
                    logPageNumber_label.Text = "Page Number: " + (LOGModule.currentNavIndexPaging + 1);
                }
                
            }


        }

        private void LogShellSideA_button_Click(object sender, EventArgs e)
        {

            if (LoggerShellFormSideA == null || LoggerShellFormSideA.Text == "")
            {
                LoggerShellFormSideA = new LoggerShellForm(SocketHandler.enumDevice_id.RTC_1);
                LoggerShellFormSideA.Dock = DockStyle.Fill;
                LoggerShellFormSideA.Show();

            }
            else if (CheckFormAlreadyOpened(LoggerShellFormSideA.Text))
            {
                LoggerShellFormSideA.WindowState = FormWindowState.Normal;
                LoggerShellFormSideA.Dock = DockStyle.Fill;
                LoggerShellFormSideA.Show();
                LoggerShellFormSideA.Focus();
            }

        }

        private void LogShellSideB_button_Click(object sender, EventArgs e)
        {
            if (LoggerShellFormSideB == null || LoggerShellFormSideB.Text == "")
            {
                LoggerShellFormSideB = new LoggerShellForm(SocketHandler.enumDevice_id.RTC_2);
                LoggerShellFormSideB.Dock = DockStyle.Fill;
                LoggerShellFormSideB.Show();
            }
            else if (CheckFormAlreadyOpened(LoggerShellFormSideB.Text))
            {
                LoggerShellFormSideB.WindowState = FormWindowState.Normal;
                LoggerShellFormSideB.Dock = DockStyle.Fill;
                LoggerShellFormSideB.Show();
                LoggerShellFormSideB.Focus();
            }
        }

        private void showPrevLogResult_button_Click(object sender, EventArgs e)
        {
            //showPrevLogResult_button
            if (LOGModule.currentNavIndexPaging > 0)
            {
                //Show content
                string content = LOGModule.navigationResult[LOGModule.currentNavIndexPaging - 1];
                logContent_textBox.Clear();
                logContent_textBox.AppendText(content);
                LOGModule.currentNavIndexPaging--;
                logPageNumber_label.Text = "Page Number: " + (LOGModule.currentNavIndexPaging + 1);
                if (LOGModule.currentNavIndexPaging == 0)
                {
                    showPrevLogResult_button.Enabled = false;
                    showPrevLogResult_button.BackColor = Color.Transparent;
                }
                if (LOGModule.currentNavIndexPaging < LOGModule.MaxNavIndex)
                {
                    showNextLogResult_button.Enabled = true;
                    showNextLogResult_button.BackColor = Color.SkyBlue;
                }
                else
                {
                    showNextLogResult_button.Enabled = false;
                    showNextLogResult_button.BackColor = Color.Transparent;
                }

            }

        }

        private void searchStatus_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchStatus_richTextBox_MouseDoubleClick(object sender, EventArgs e)
        {
            if (SearchStatusForm == null || SearchStatusForm.Text == "")
            {
                SearchStatusForm = new GenericTextBoxForm("Search Status", searchStatus_richTextBox.Text,500,800);
                SearchStatusForm.Dock = DockStyle.Fill;
                SearchStatusForm.Show();
            }
            else if (CheckFormAlreadyOpened(SearchStatusForm.Text))
            {
                SearchStatusForm.WindowState = FormWindowState.Normal;
                SearchStatusForm.Dock = DockStyle.Fill;
                SearchStatusForm.Show();
                SearchStatusForm.Focus();
            }
        }

        private void logContent_textBox_MouseDoubleClick(object sender, EventArgs e)
        {
            /*
            if (SearchLogContentForm == null || SearchLogContentForm.Text == "")
            {
                SearchLogContentForm = new GenericTextBoxForm("Search Content", logContent_textBox.Text, 500, 800);
                SearchLogContentForm.Dock = DockStyle.Fill;
                SearchLogContentForm.Show();
            }
            else if (CheckFromAlreadyOpened(SearchLogContentForm.Text))
            {
                SearchLogContentForm.WindowState = FormWindowState.Normal;
                SearchLogContentForm.Dock = DockStyle.Fill;
                SearchLogContentForm.Show();
                SearchLogContentForm.Focus();
            }
            */
        }
        private void addLogSearchStatusContent(string data, Color color)
        {
            string ttime =  DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            searchStatus_richTextBox.SuspendLayout();
            searchStatus_richTextBox.SelectionColor = color;
            searchStatus_richTextBox.AppendText(ttime + " : " + data + "\n");
            searchStatus_richTextBox.ScrollToCaret();
            searchStatus_richTextBox.ResumeLayout();
        }



        private void reloadOfflineFolder()
        {
            string[] splitedPath;
            string fileName;
            string[] fileNameSplited;
            try
            {
                if (offlineFolderPath == null)
                {
                    return;
                }
                /*Get just the parent files directory (Not subdirectory included)*/
                string[] files = Directory.GetFiles(offlineFolderPath.SelectedPath, "*.txt", SearchOption.TopDirectoryOnly);

                LOGModule.offlineFolderList = new List<string>();
                foreach (string file in files)
                {
                    splitedPath = file.Split('\\');
                    if (splitedPath.Length > 0)
                    {
                        fileName = splitedPath[splitedPath.Length - 1];
                        fileNameSplited = fileName.Split('_');
                        if (fileNameSplited.Length > 2)
                        {
                            if ((fileNameSplited[2] == LOGModule.INIContent.rtc1Port && isRTC1Presented == true) || (fileNameSplited[2] == LOGModule.INIContent.rtc2Port && isRTC1Presented == false))
                            {
                                LOGModule.offlineFolderList.Add(file);
                            }
                        }
                    }

                   
                }
                addLogSearchStatusContent("Selected folder path: " + offlineFolderPath.SelectedPath, Color.Green);

                filterByStringInLog_button.Enabled = true;
            }
            catch (Exception ex)
            {
                        MessageBox.Show("Error accure: " + ex.Message.ToString());
            }
        }

        private void SetTailNumOfLeds(TextBox pTextBox, string pConsole, BindingList<RT_Viewer.Framework.RTIModule.LOPTable> pLopTable)
        {
            if (pLopTable == null)
            {
                //Do nothing
                return;
            }
            foreach (RT_Viewer.Framework.RTIModule.LOPTable item in pLopTable)
            {
                if ((item.is_selected == "Selected") && (item.console == pConsole))
                {
                    pTextBox.Text = item.tail_number;

                    return;
                }
            }

            // no UAV is selected
            pTextBox.Text = "N/A";
        }

        private void PresetKnob1Btn_Click(object sender, EventArgs e)
        {
            byte[] msg = BuildKnobRequest(1, 0); // Console 1, No data

            SendKnobMessageToRT(msg, (uint)SocketHandler.TypeOfTxMessage.KNOB_PRESET_HK_TYPE);
        }

        private void PresetKnob2Btn_Click(object sender, EventArgs e)
        {
            byte[] msg = BuildKnobRequest(2, 0); // Console 2, No data

            SendKnobMessageToRT(msg, (uint)SocketHandler.TypeOfTxMessage.KNOB_PRESET_HK_TYPE);
        }

        private byte[] BuildKnobRequest(uint pConsoleId, uint pRequest)
        {
            byte[] Msg = new byte[8];

            byte[] ConsoleIdBytes = BitConverter.GetBytes(pConsoleId);
            byte[] RequestBytes = BitConverter.GetBytes(pRequest);

            ConsoleIdBytes.CopyTo(Msg, 0);

            RequestBytes.CopyTo(Msg, 4);

            return Msg;
        }

        private void SendKnobMessageToRT(byte[] pMsg, uint pOpcode)
        {
            if (isRTC1Presented)
            {
                socketRT1.sendMsgToRT(pMsg, pOpcode, SocketHandler.enumDevice_id.RTC_1);
            }
            else
            {
                socketRT2.sendMsgToRT(pMsg, pOpcode, SocketHandler.enumDevice_id.RTC_2);
            }
        }

        bool m_Rt1StartKnob = false;
        bool m_Rt2StartKnob = false;

        private void StartStopKnob1Btn_Click(object sender, EventArgs e)
        {
            StartStopKnobForConsole(1);
        }

        private void StartStopKnob2Btn_Click(object sender, EventArgs e)
        {
            StartStopKnobForConsole(2);
        }

        private void StartStopKnobForConsole(byte pConsole)
        {
            // Only Active RT can control the knob

            if (((isRTC1Presented == true) && (socketRT1.appModule.isRTCActive == "Active")) ||
                 ((isRTC1Presented == false) && (socketRT2.appModule.isRTCActive == "Active")))
            {

                uint Request;

                if (pConsole == 1)
                {
                    Request = SetKnobButton(ref m_Rt1StartKnob, pConsole);
                }
                else
                {
                    Request = SetKnobButton(ref m_Rt2StartKnob, pConsole);
                }

                byte[] msg = BuildKnobRequest(pConsole, Request);

                SendKnobMessageToRT(msg, (int)SocketHandler.TypeOfTxMessage.KNOB_READ_HK_TYPE);
            }

        }


        private uint SetKnobButton(ref bool pKnob, int pConsole)
        {
            byte returnVal = 0;

            if (pKnob == false)
            {
                // Start request
                returnVal = 1;

                pKnob = true;

                if (pConsole == 1)
                {
                    StartStopKnob1Btn.Text = "Press to Stop Reading";
                }
                else
                {
                    StartStopKnob2Btn.Text = "Press to Stop Reading";
                }
            }
            else
            {
                // Stop Request
                returnVal = 0;

                pKnob = false;

                if (pConsole == 1)
                {
                    StartStopKnob1Btn.Text = "Press to Start Reading";
                }
                else
                {
                    StartStopKnob2Btn.Text = "Press to Start Reading";
                }
            }

            return returnVal;
        }

        private void EnableKnobButtons()
        {

            if ((isRTC1Presented == true) && (socketRT1.appModule.isRTCActive == "Active"))
            {
                this.StartStopKnob1Btn.Enabled = true;
                this.PresetKnob1Btn.Enabled = true;
                this.StartStopKnob2Btn.Enabled = true;
                this.PresetKnob2Btn.Enabled = true;
            }
            else
            {
                if ((isRTC1Presented == false) && (socketRT2.appModule.isRTCActive == "Active"))
                {
                    this.StartStopKnob1Btn.Enabled = true;
                    this.PresetKnob1Btn.Enabled = true;
                    this.StartStopKnob2Btn.Enabled = true;
                    this.PresetKnob2Btn.Enabled = true;
                }
                else
                {
                    this.StartStopKnob1Btn.Enabled = false;
                    this.PresetKnob1Btn.Enabled = false;
                    this.StartStopKnob2Btn.Enabled = false;
                    this.PresetKnob2Btn.Enabled = false;

                    //TODO: Clear display
                    //HKY_KnobConsole1Gb HKY_KnobConsole2Gb
                }
            }
        }
			
		private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           	if (testForm == null || testForm.Text == "")
           	{
              	testForm = new TesterForm();
               	testForm.Dock = DockStyle.Fill;
               	testForm.Show();
           	}
           	else if (CheckFormAlreadyOpened(testForm.Text))
           	{
               	testForm.WindowState = FormWindowState.Normal;
               	testForm.Dock = DockStyle.Fill;
               	testForm.Show();
               	testForm.Focus();
           	}    
		}

        /*######################
        #    GDT Event        #
        ######################*/
        public void GDTEventHandler(Object sender, IModuleEventArgs e)
        {

            /* this line is for thread safe*/
            if (InvokeRequired && !isDispose)
            {
                IModule.IModuleHandler cb = new IModule.IModuleHandler(GDTEventHandler);
                BeginInvoke(cb, new object[] { sender, e });
                return;
            }

            // Do the work...
            if (isRTC1Presented == true && e.device_id == SocketHandler.enumDevice_id.RTC_1)
            {
                // display data
                gdtTable_dataGridView.DataSource = socketRT1.gdtModule.BL_GDTTable;

                gdtTable_dataGridView.Refresh();
            }
            else if (isRTC1Presented == false && e.device_id == SocketHandler.enumDevice_id.RTC_2)
            {
                // display data
                gdtTable_dataGridView.DataSource = socketRT2.gdtModule.BL_GDTTable;

                gdtTable_dataGridView.Refresh();
            }
        }

        /*######################
        #    TLM Event        #
        ######################*/

        private void tlm_btn_SaveConfigurations_Click(object sender, EventArgs e)
        {
            socketRT1.tlmModule.SetTlmOptions
            (
                tlm_rdb_ReadSourceFile.Checked == true ?    TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_READ_SOURCE_FILE :
                tlm_rdb_ReadSourceCurrent.Checked == true ? TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_READ_SOURCE_CURRENT :
                tlm_rdb_ReadSourceFlash.Checked == true ?   TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_READ_SOURCE_FLASH :
                                                            TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_NOT_SELECTED,
                tlm_tbx_LoadFilePath.Text,

                tlm_rdb_SaveFileYes.Checked == true ?       TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_SAVE_FILE_NO :
                                                            TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_SAVE_FILE_YES,
                tlm_tbx_SaveFilePath.Text,

                tlm_rdb_SortByGroups.Checked == true ?      TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_SORT_GROUPS :
                tlm_rdb_SortHighLow.Checked == true ?       TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_SORT_HIGH_LOW :
                                                            TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_SORT_LOW_HIGH,

                tlm_rdb_DataTypeChars.Checked == true ?     TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_DATA_TYPE_CHARS :
                                                            TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_DATA_TYPE_ORG,

                tlm_rdb_VisualModeTable.Checked == true ?   TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_VISUAL_TABLE :
                                                            TLMModule.TLMModuleOptions.enumTLM_opt.TLM_OPT_VISUAL_FIGURE
            );

        }

        private void tlm_btn_SelectDataMember_Click(object sender, EventArgs e)
        {


        }

        private void tlm_btn_ForceUpdate_Click(object sender, EventArgs e)
        {
            
            string line = string.Empty;
            

            if (tlm_tbx_ForceUpdatePath.Text != string.Empty)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(tlm_tbx_ForceUpdatePath.Text);
                while ((line = file.ReadLine()) != null)
                {
                    byte[] msg = Encoding.Default.GetBytes(line);
                    if (msg.Length == 0) continue;
                    socketRT1.tlmModule.update(msg, (uint)msg.Length, 0, 0);
                    
                }

                tlmTable_dataGridView.DataSource = socketRT1.tlmModule.BL_TLMDataTable;
                tlmTable_dataGridView.Refresh();

            }
            
            
        }



        private void tlm_btn_FigureDataMember_Click(object sender, EventArgs e)
        {
            DataTable dataTalbe = socketRT1.tlmModule.SelectDataMember(tlm_tbx_FindName.Text, tlm_tbx_FindGroup.SelectedText);

            /* Update TLM DB chart lists */
            socketRT1.tlmModule.UpdateChartLists();

            // Bind the chart to the list. 
            tlm_chart_view.Series[0].Points.DataBindXY(socketRT1.tlmModule.tlm_x_chart, socketRT1.tlmModule.tlm_y_chart);
        }
    }
}
