using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT_Viewer.Framework;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

namespace RT_Viewer.Forms
{
    public partial class LoggerShellForm : Form
    {
        public const int CHUNK_SIZE = 2048;
        public const long MAX_TEXTBOX_SHELL_SIZE = 1000000;
        public int sleepTime = 200; // in ms
        public bool isListening = true;
        public BackgroundWorker shellBGWorker; //backGroundWorker for reading and updating shell data
        public Socket shellSocket;
        public IPAddress multicastip = IPAddress.Parse("225.5.11.229");
        public SocketHandler.enumDevice_id rtNumber;
        byte[] incomingData;
        IPEndPoint ipepRT;
        EndPoint epRT;

        public static int LoggerPortNumberRT1 = UInt16.Parse(LOGModule.INIContent.rtc1Port);
        public static int LoggerPortNumberRT2 = UInt16.Parse(LOGModule.INIContent.rtc2Port);

        public LoggerShellForm(SocketHandler.enumDevice_id rt_number)
        {
            InitializeComponent();
            rtNumber = rt_number;

            if (LOGModule.INIContent.isInit == true)
            {
                LoggerPortNumberRT1 = Int32.Parse(LOGModule.INIContent.rtc1Port);
                LoggerPortNumberRT2 = Int32.Parse(LOGModule.INIContent.rtc2Port);
                multicastip = IPAddress.Parse(LOGModule.INIContent.multicastIP);
            }

            if (rtNumber == SocketHandler.enumDevice_id.RTC_1)
            {
                ipepRT = new IPEndPoint(IPAddress.Any, LoggerPortNumberRT1);
            }
            else // RTC_2
            {
                ipepRT = new IPEndPoint(IPAddress.Any, LoggerPortNumberRT2);
            }

            epRT = (EndPoint)ipepRT;

            /*BackGroundWorker Events*/
            shellBGWorker = new BackgroundWorker();
            shellBGWorker.WorkerReportsProgress = true;
            shellBGWorker.WorkerSupportsCancellation = true;
            shellBGWorker.DoWork += new DoWorkEventHandler(shellBGWorker_DoWork);
            shellBGWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(shellBGWorker_RunWorkerCompleted);
            shellBGWorker.ProgressChanged += new ProgressChangedEventHandler(shellBGWorker_ProgressChanged);

            this.speedShell_comboBox.SelectedIndexChanged += new System.EventHandler(speedShell_SelectedIndexChanged);

            pauseContinueShell_button.Text = "Pause Shell";
            pauseContinueShell_button.BackColor = System.Drawing.Color.GreenYellow;
            pauseContinueShell_button.Refresh();


            if (rt_number == SocketHandler.enumDevice_id.RTC_1)
            {
                RTLogShell_label.Text = "RTC Side A Log Shell";
            }
            else
            {
                RTLogShell_label.Text = "RTC Side B Log Shell";
            }


            this.FormClosed += new FormClosedEventHandler(LoggerShellForm_FormClosed);
        }


        void LoggerShellForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pauseContinueShell_button_Click(object sender, EventArgs e)
        {
            isListening = !isListening;
            if (isListening)
            {
                pauseContinueShell_button.Text = "Pause Shell";
                pauseContinueShell_button.BackColor = System.Drawing.Color.GreenYellow;
                pauseContinueShell_button.Refresh();
            }
            else
            {
                pauseContinueShell_button.Text = "Continue Shell";
                pauseContinueShell_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                pauseContinueShell_button.Refresh();
            }
        }


        private void LoggerShellForm_Load(object sender, EventArgs e)
        {
            if (shellBGWorker.IsBusy != true)
            {
                // Start the asynchronous operation.
                shellBGWorker.RunWorkerAsync();
            }

        }


        // This event handler is where the time-consuming work is done.
        private void shellBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string dataReads;
            incomingData = new byte[CHUNK_SIZE];
            try
            {
                createSocket();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Winsock error: " + ex.ToString());
            }


            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }
            else
            {                   
                    while (true)
                    {
                        int sizeOfIncomingMessage;
                        while (true)
                        {
                            if (isListening)
                            {
                                Array.Clear(incomingData, 0, incomingData.Length);
                                try
                                {

                                    sizeOfIncomingMessage = shellSocket.ReceiveFrom(incomingData, ref epRT);
                                    dataReads = System.Text.Encoding.UTF8.GetString(incomingData);
                                    shellBGWorker.ReportProgress(0, dataReads);

                                }
                                catch (Exception ex)
                                {//Will be catch while killing the thread
                                     //MessageBox.Show("Information: " + ex.Message.ToString());
                                }
                                Thread.Sleep(sleepTime);
                            }
                        }
                    }
            }
        }

        private void shellBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            try
            {
                if (logShellContent_textBox.Text.Length > MAX_TEXTBOX_SHELL_SIZE)
                {
                    logShellContent_textBox.Clear();
                }

                logShellContent_textBox.AppendText(e.UserState.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        // This event handler deals with the results of the background operation.
        private void shellBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Nothing to do...
        }

             
        private void speedShell_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isNumeric = Regex.IsMatch(speedShell_comboBox.Text, @"^\d+$");

            if (isNumeric)
            {
                sleepTime = Int32.Parse(speedShell_comboBox.Text);
            }
            else
            {
                MessageBox.Show("Only numeric value is allowed");
            }
        }
        

        public bool createSocket()
        {
            try
            {
                shellSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                shellSocket.ReceiveBufferSize = 32768; // 32KB
                shellSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                shellSocket.Bind(ipepRT);
                shellSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(multicastip, IPAddress.Any));
            }
            catch (Exception e)
            {
                MessageBox.Show("Winsock error: " + e.ToString());
                return false;
            }
            return true;

        }

        private void clearShell_button_Click(object sender, EventArgs e)
        {
            logShellContent_textBox.Clear();
        }

        private void logShellContent_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logShellContent_textBox_MouseClick(object sender, EventArgs e)
        {
            pauseContinueShell_button_Click(sender, e);
        }
        

    }
}
