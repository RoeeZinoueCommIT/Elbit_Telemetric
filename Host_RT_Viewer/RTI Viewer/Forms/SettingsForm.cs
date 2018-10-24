using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace RT_Viewer.Forms
{
    public partial class SettingsForm : Form
    {
    
        public SettingsForm()
        {
            InitializeComponent();

            RT_Viewer.Framework.SettingsHandler.Instance().Init();

            FillIpMcstAddress(RT_Viewer.Framework.SettingsHandler.multicastRT1);

            rtATxPort_textBox.Text = RT_Viewer.Framework.SettingsHandler.portRT1TX;
            rtARxPort_textBox.Text = RT_Viewer.Framework.SettingsHandler.portRT1RX;
            rtBTxPort_textBox.Text = RT_Viewer.Framework.SettingsHandler.portRT2TX;
            rtBRxPort_textBox.Text = RT_Viewer.Framework.SettingsHandler.portRT2RX;
            selectedGcsID_textBox.Text = RT_Viewer.Framework.SettingsHandler.selectedGcsID;

            // display logger communication values
            int theRt1Port = RT_Viewer.Framework.LOGModule.RT1_LOGGER_PORT;
            int theRt2Port = RT_Viewer.Framework.LOGModule.RT2_LOGGER_PORT;

            GetLoggerPortsAndUpdateDisplay(ref theRt1Port, ref theRt2Port);

        }

        private void FillIpMcstAddress(string pIpStr)
        {
            IPAddress theIpAdd = IPAddress.Parse(pIpStr);
            byte[] theIpBytes = theIpAdd.GetAddressBytes();

            IpFirstNibleTb.Text = theIpBytes[0].ToString();
            IpSecondNibleTb.Text = theIpBytes[1].ToString();

            IpThirdNibleTb.Text = RT_Viewer.Framework.SettingsHandler.selectedGcsID;

            IpFourthNibleTb.Text = theIpBytes[3].ToString();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
        }

        private bool CheckLegalityOfIntString(string pValueToCheck, string pValName, int pLowLinit, int pHighLinit)
        {
            bool IsValid = false;

            bool isNumeric = Regex.IsMatch(pValueToCheck, @"^\d+$");
             if (!isNumeric)
             {
                 MessageBox.Show(pValName + " value can be only numeric!");
                 IsValid = false;
             }
             else
             {
                 int theVal = Int32.Parse(pValueToCheck);
                 if ((theVal >= pLowLinit) && (theVal <= pHighLinit))
                 {
                     IsValid = true;
                 }
                 else
                 {
                     MessageBox.Show(pValName + " value is out of bounds!");
                 }
             }

             return IsValid;
        }

        private bool CheckLegalityOfIP()
        {
            bool isLegal = CheckLegalityOfIntString(IpFirstNibleTb.Text, "Multicast IP First nible", 224, 239); // multicast range

            if (isLegal == true)
            {
                isLegal = CheckLegalityOfIntString(IpSecondNibleTb.Text, "Multicast IP Second nible", 0, Byte.MaxValue);

                if (isLegal == true)
                {
                    isLegal = CheckLegalityOfIntString(IpFourthNibleTb.Text, "Multicast IP Fourth nible", 0, Byte.MaxValue);

                 }
            }

            return isLegal;
        }

        private void setSettings_button_Click(object sender, EventArgs e)
        {
            bool isLegal = true;

            isLegal = CheckLegalityOfIP();

            if (isLegal == false)
            {
                return;
            }
            
            isLegal = CheckLegalityOfIntString(rtATxPort_textBox.Text, "RT-A TX Port", 1, UInt16.MaxValue);

            if (isLegal == false)
            {
                return;
            }

            isLegal = CheckLegalityOfIntString(rtARxPort_textBox.Text, "RT-A RX Port", 1, UInt16.MaxValue);

            if (isLegal == false)
            {
                return;
            }

            isLegal = CheckLegalityOfIntString(rtBTxPort_textBox.Text, "RT-A TX Port", 1, UInt16.MaxValue);

            if (isLegal == false)
            {
                return;
            }

            isLegal = CheckLegalityOfIntString(rtBRxPort_textBox.Text, "RT-A RX Port", 1, UInt16.MaxValue);

            if (isLegal == false)
            {
                return;
            }


            isLegal = CheckLegalityOfIntString(selectedGcsID_textBox.Text, "Selected GCS ID", 1, Byte.MaxValue);

            if (isLegal == false)
            {
                return;
            }

            if (selectedGcsID_textBox.Text != RT_Viewer.Framework.SettingsHandler.selectedGcsID)
            {
                // Third nibble of IP indicates the station Id
                IpThirdNibleTb.Text = selectedGcsID_textBox.Text;

                RT_Viewer.Framework.SettingsHandler.Instance().GcsIdChanged(selectedGcsID_textBox.Text);

                // Ports are calculated according to GCS ID
                int theRt1Port = RT_Viewer.Framework.LOGModule.RT1_LOGGER_PORT;
                int theRt2Port = RT_Viewer.Framework.LOGModule.RT2_LOGGER_PORT;

                string loggerIniFilePath = GetLoggerPortsAndUpdateDisplay(ref theRt1Port, ref theRt2Port);

                // Save 2 new values in logger module file
                RT_Viewer.Framework.LOGModule.UpdateFileWithPorts(theRt1Port, theRt2Port, loggerIniFilePath);
            }


            /* Valid Parameters*/
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlNode myNode;

                doc.Load(RT_Viewer.Framework.SettingsHandler.xmlFile);
                XmlNode root = doc.DocumentElement;
                myNode = root.SelectSingleNode("MULTICAST_IP");
                myNode.InnerText = IpFirstNibleTb.Text + "." + IpSecondNibleTb.Text + "." + IpThirdNibleTb.Text + "." + IpFourthNibleTb.Text;

                myNode = root.SelectSingleNode("RT1_PROPERTIES");
                myNode = myNode.FirstChild;
                myNode.InnerText = rtATxPort_textBox.Text;
                myNode = myNode.NextSibling;
                myNode.InnerText = rtARxPort_textBox.Text;
                myNode = root.SelectSingleNode("RT2_PROPERTIES");
                myNode = myNode.FirstChild;
                myNode.InnerText = rtBTxPort_textBox.Text;
                myNode = myNode.NextSibling;
                myNode.InnerText = rtBRxPort_textBox.Text;

                myNode = root.SelectSingleNode("SELECTED_GCS_ID");
                myNode.InnerText = selectedGcsID_textBox.Text;


                doc.Save(RT_Viewer.Framework.SettingsHandler.xmlFile);
                MessageBox.Show("Settings has been saved succesfully!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has been accured: " + ex.Message);
            }

            this.Close();
        }

        private string GetLoggerPortsAndUpdateDisplay(ref int theRt1Port, ref int theRt2Port)
        {
            // Ports are calculated according to GCS ID
            string loggerIniFilePath = RT_Viewer.Framework.LOGModule.GetLoggerFilePath();

            RT_Viewer.Framework.SettingsHandler.Instance().GetCalculatedLogPorts(RT_Viewer.Framework.LOGModule.RT1_LOGGER_PORT, RT_Viewer.Framework.LOGModule.RT2_LOGGER_PORT, ref theRt1Port, ref theRt2Port);

            // Get Multicast IP of LOGGER
            string McstIP = RT_Viewer.Framework.LOGModule.ReadIniFile(ref theRt1Port, ref theRt2Port, loggerIniFilePath);

            // display  Logger data
            LoggerMcstIpTb.Text = McstIP;
            LoggerRt1PortTb.Text = theRt1Port.ToString();
            LoggerRt2PortTb.Text = theRt2Port.ToString();

            return loggerIniFilePath;
        }



    }
}
