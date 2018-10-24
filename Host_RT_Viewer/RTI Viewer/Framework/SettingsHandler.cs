using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace RT_Viewer.Framework
{
    public class SettingsHandler
    {
        // Singelton
        private static SettingsHandler mInstance = new SettingsHandler();

        private static bool wasInitialyzed = false;
        public static string multicastRT1;
        public static string portRT1TX;
        public static string portRT1RX;
        public static string multicastRT2;
        public static string portRT2TX;
        public static string portRT2RX;
        public static string xmlFile;
        public static FileStream fs;
        public static string selectedGcsID = "0";


        public static SettingsHandler Instance()
        {
            if (wasInitialyzed == false)
            {
                readSettingsXMLFile(false);
            }
            return mInstance;
        }

        private SettingsHandler()
        {
            if (wasInitialyzed == false)
            {
                readSettingsXMLFile(false);
            }
        }

        public void Init()
        {
            readSettingsXMLFile(true);
        }

        public static bool readSettingsXMLFile(bool pEnableWrite)
        {
            wasInitialyzed = true;

            string assembly = System.Reflection.Assembly.GetEntryAssembly().Location;
            string assemblyPath = System.IO.Path.GetDirectoryName(assembly);
            xmlFile = assemblyPath + @"\settings.xml";
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            try
            {
                FileAccess fileAccess = FileAccess.Read;

                if (pEnableWrite == true)
                {
                    var attr = File.GetAttributes(xmlFile);

                    // unset read-only
                    attr = attr & ~FileAttributes.ReadOnly;
                    File.SetAttributes(xmlFile, attr);

                    fileAccess = FileAccess.ReadWrite;
                }

                fs = new FileStream(xmlFile, FileMode.Open, fileAccess);
                xmldoc.Load(fs);

                xmlnode = xmldoc.GetElementsByTagName("MULTICAST_IP");
                multicastRT2 = multicastRT1 = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();

                xmlnode = xmldoc.GetElementsByTagName("RT1_PROPERTIES");
                portRT1TX = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                portRT1RX = xmlnode[0].ChildNodes.Item(1).InnerText.Trim();

                xmlnode = xmldoc.GetElementsByTagName("RT2_PROPERTIES");
                portRT2TX = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                portRT2RX = xmlnode[0].ChildNodes.Item(1).InnerText.Trim();

                xmlnode = xmldoc.GetElementsByTagName("SELECTED_GCS_ID");
                selectedGcsID = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();

                fs.Close();
            }
            catch(Exception e)
            {
                
                if (e is FileNotFoundException)
                {
                    MessageBox.Show("File settings.xml was not found Exiting ...", "File Not Found ERROR");
                    exitApplication();
                }
                else
                {
                    fs.Close();
                    MessageBox.Show("General error acccured while trying read settings.xml file, please check validity fields in settings.xml file!", "Parameters ERROR");
                    exitApplication();
                }
            }
            return true;
        }

        public void GcsIdChanged(string pGcsID)
        {
            selectedGcsID = pGcsID;

            // raise event
            if (GcsIdChangedEvent != null)
            {
                GcsIdChangedEvent(this, selectedGcsID);
            }
        }

        public delegate void GcsIdChangedEventHandler(object sender, string gcsID);

        public event GcsIdChangedEventHandler GcsIdChangedEvent;


        public void GetCalculatedLogPorts(int pLogBasePortRT1, int pLogBasePortRT2, ref int pLogPortRT1, ref int pLogPortRT2)
        {
            pLogPortRT1 = pLogBasePortRT1 + ((Int32.Parse(selectedGcsID) - 1) * 2);
            pLogPortRT2 = pLogBasePortRT2 + ((Int32.Parse(selectedGcsID) - 1) * 2);
        }


         public static void exitApplication()
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
    }
}
