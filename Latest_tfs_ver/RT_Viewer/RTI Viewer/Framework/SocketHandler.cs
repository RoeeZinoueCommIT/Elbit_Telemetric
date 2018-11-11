using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;

/***********************************************
 * structure of incoming message:
 * magic number         - 4 byte
 * Source               - 4 byte
 * Destination          - 4 byte
 * Spare                - 4 byte
 * Spare                - 4 byte
 * Type                 - 4 byte
 * Size of the message  - 4 byte
 * Data                 - <Size of the message> byte
 * CheckSum16           - 2 byte
 *********************************************/
namespace RT_Viewer.Framework
{
    public class SocketHandler
    {

        public Socket sockRX;         // socket to receive messages from RTC1 and RTC2 (multicast)
        public UdpClient clientTXRTC; // socket to send messages Viewer to RTC1 or RTC2 (unicast)
        public IPEndPoint ipepRX;     //IPEnd point to RX socket
        public IPEndPoint ipepRTCTX;  //IPEnd point to TX socket
        public IPAddress ipRX;        //multicast IP listening to
        public IPAddress ipRTCTX;     //unicast IP of RTC1\RTC2
        public EndPoint epRX;
        public EndPoint epRTCTX;
        public string portNumberRX;
        public string portNumberTX;
        public int selectedGcs_Id;
        public bool isRTCTXSocketInit = false;


        public Dictionary<uint, IModule> ModuleDictinary; // key is the type of module defining in TypeOfMessage, the value is the module
        public bool isListening;
        public bool isSocketPaused = false;
        public bool isSocketAlive = false;
        public long lastReceivedTimeStamp = 0;
        public Thread listeningThread;
        public const uint MAX_SIZE_OF_MESSAGE = 16384; // 16KB
        public const uint MIN_SIZE_OF_MESSAGE = 36;   //Bytes
        public const uint MAGIC_NUMBER = 0xa1a1a1a1;
        public const uint SIZE_OF_CHECKSUM = 4;
        public const uint HEADER_SIZE = 36;
        public enumDevice_id device_id;
        public byte[] MergedMessage;

        public RTIModule rtiModule;
        public HSTModule hstModule;
        public APPModule appModule;
        public LOGModule logModule;
        public UAVModule uavModule;
        public NTPModule ntpModule;
        public FRMModule frmModule;
        public OffllineParamsModule offModule;
        public NVMModule nvmModule;
        public STKModule stkModule;
        public HKYModule hkyModule;
        public PFDMoudle pfdModule;
        public MGCModule mgcModule;
        public GDTModule gdtModule;
        public IRDModule irdModule;
        public ICDModule icdModule;
        public TLMModule tlmModule;

        /*Note: this enum should be duplicate as in enumVTU_TxTableType in VTU_frame.h  */
        public enum TypeOfRxMessage
        {
            HST_TABLE_TYPE = 0,
            RTI_TABLE_TYPE,
            APP_TABLE_TYPE,
            UAV_TABLE_TYPE,
            LOG_TABLE_TYPE,
            NTP_TABLE_TYPE,
            FRM_TABLE_TYPE,
            OFF_TABLE_TYPE,
            NVM_TABLE_TYPE,
            STK_TABLE_TYPE,
            HKY_TABLE_TYPE,
            PFD_TABLE_TYPE,
            MGC_TABLE_TYPE,
            GDT_TABLE_TYPE,
            IRD_TABLE_TYPE,
            TLM_TABLE_TYPE,
            MAX_TYPE
        }

        /*Note: this enum should be duplicate as in enumVTU_RxTableType in VTU_frame.h  */
        public enum TypeOfTxMessage
        {
            CHANGE_LOG_LEVELS_TYPE = 0,
            READ_NVRAM_TYPE,
            WRITE_NVRAM_TYPE,
            KNOB_PRESET_HK_TYPE,
            KNOB_READ_HK_TYPE,
            WRONG_MAGIC_NUMBER_TYPE, // for test purpose only
            WRONG_CHECKSUM_TYPE,     // for test purpose only
            WRONG_OPCODE_TYPE,       // for test purpose only
            MAX_TYPE
        }

        public enum enumDevice_id
        {
            RTC_1 = 1,
            RTC_2,
            VIEWER,
            MAX_DEVICES
        }
        public struct MessageHeader
        {
            public uint magic_number;
            public uint source;
            public uint destination;
            public uint spare1;
            public uint spare2;
            public uint current_packet;
            public uint total_packet;
            public uint type;
            public uint size;
        }

        public SocketHandler(string multicastIP, string portRx, string portTx, enumDevice_id deviceID)
        {
            portNumberRX = portRx;
            portNumberTX = portTx;
            device_id = deviceID;

            ipRX = IPAddress.Parse(multicastIP);
            ipepRX = new IPEndPoint(IPAddress.Any, Int32.Parse(portNumberRX));
            epRX = (EndPoint)ipepRX;
            clientTXRTC = new UdpClient();

            isListening = false;
            ModuleDictinary = new Dictionary<uint, IModule>(); // get Module by id

            /*Add all the new module here*/

            hstModule = new HSTModule(deviceID);
            AddModule(hstModule, SocketHandler.TypeOfRxMessage.HST_TABLE_TYPE);

            rtiModule = new RTIModule(deviceID);
            AddModule(rtiModule, SocketHandler.TypeOfRxMessage.RTI_TABLE_TYPE);

            appModule = new APPModule(deviceID);
            AddModule(appModule, SocketHandler.TypeOfRxMessage.APP_TABLE_TYPE);

            uavModule = new UAVModule(deviceID);
            AddModule(uavModule, SocketHandler.TypeOfRxMessage.UAV_TABLE_TYPE);

            logModule = new LOGModule(deviceID);
            AddModule(logModule, SocketHandler.TypeOfRxMessage.LOG_TABLE_TYPE);

            ntpModule = new NTPModule(deviceID);
            AddModule(ntpModule, SocketHandler.TypeOfRxMessage.NTP_TABLE_TYPE);

            frmModule = new FRMModule(deviceID);
            AddModule(frmModule, SocketHandler.TypeOfRxMessage.FRM_TABLE_TYPE);

            offModule = new OffllineParamsModule(deviceID);
            AddModule(offModule, SocketHandler.TypeOfRxMessage.OFF_TABLE_TYPE);

            nvmModule = new NVMModule(deviceID);
            AddModule(nvmModule, SocketHandler.TypeOfRxMessage.NVM_TABLE_TYPE);

            stkModule = new STKModule(deviceID);
            AddModule(stkModule, SocketHandler.TypeOfRxMessage.STK_TABLE_TYPE);

            hkyModule = new HKYModule(deviceID);
            AddModule(hkyModule, SocketHandler.TypeOfRxMessage.HKY_TABLE_TYPE);

            pfdModule = new PFDMoudle(device_id);
            AddModule(pfdModule, SocketHandler.TypeOfRxMessage.PFD_TABLE_TYPE);

            mgcModule = new MGCModule(device_id);
            AddModule(mgcModule, SocketHandler.TypeOfRxMessage.MGC_TABLE_TYPE);

            gdtModule = new GDTModule(device_id);
            AddModule(gdtModule, SocketHandler.TypeOfRxMessage.GDT_TABLE_TYPE);

            irdModule = new IRDModule(device_id);
            AddModule(irdModule, SocketHandler.TypeOfRxMessage.IRD_TABLE_TYPE);

            tlmModule = new TLMModule(device_id);
            AddModule(irdModule, SocketHandler.TypeOfRxMessage.TLM_TABLE_TYPE);

        }

        public void AddModule(IModule moduleClass, TypeOfRxMessage type)
        {
            ModuleDictinary.Add((uint)type, moduleClass);

        }
        public bool createSocket()
        {
            try
            {
                sockRX = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                sockRX.ReceiveBufferSize = 32768; // 32KB
                sockRX.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                sockRX.Bind(ipepRX);
                sockRX.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ipRX, IPAddress.Any));
            }
            catch (Exception e)
            {
                MessageBox.Show("Winsock error: " + e.ToString());
                return false;
            }
            return true;

        }

        /*---------------------------------------------------------------------
         *
         * typedef struct
         *   {
	     *       _uint magic_number; (0-3)
	     *       _uint source;       (4-7)
	     *       _uint destination;  (8-11)
	     *       _uint spare1;       (12-15)
	     *       _uint spare2;       (16-19)
         *       _uint current_packet(20-23)
         *       _uint total_packet  (24-27)
	     *       _uint type;         (28-31)
	     *       _uint size;         (32-35)
         *   }DT_VTU_message_header;
         *   
         * typedef struct
         * {
	     *     DT_VTU_message_header header;
         *     _char				  data[C_COMMON_VIEWER_BUF_SIZE];
	     *     _uint				  checksum32;
         * }DT_VTU_message;
         * --------------------------------------------------------------------
         */
        public void ManageData(byte[] byteArray, int size, EndPoint epReceived)
        {

            uint magicNumber, source, destination,current_packet,total_packet, type, sizeOfMessage;
            uint checksumReceived, checksumCalculated;
            byte[] dataArray; // only data including checksum
            byte[] incoming_data; // All the incoming message

            if (size < MIN_SIZE_OF_MESSAGE)
            { // the message is in the incorrect format, message is too small
                return;
            }

            magicNumber = (uint)BitConverter.ToUInt32(byteArray, 0);
            source = (uint)BitConverter.ToUInt32(byteArray, 4);
            destination = (uint)BitConverter.ToUInt32(byteArray, 8);
            current_packet = (uint)BitConverter.ToUInt32(byteArray, 20);
            total_packet = (uint)BitConverter.ToUInt32(byteArray, 24);
            type = (uint)BitConverter.ToUInt32(byteArray, 28);
            sizeOfMessage = (uint)BitConverter.ToUInt32(byteArray, 32); // without checksum
            incoming_data = new byte[size];
            Array.Copy(byteArray, incoming_data, size);
         
            /*Merge*/
            if (current_packet == 1)
            {
                MergedMessage = new byte[0];
            }
            if (current_packet < total_packet)
            {//add this data to the merged message and continue untill reaching to total packet (no checksum here)
                dataArray = new byte[sizeOfMessage];
                Array.Copy(incoming_data, HEADER_SIZE, dataArray, 0, dataArray.Length); // copy only data without headers or checksum
                MergedMessage = Combine(MergedMessage, dataArray);
                return;
            }
            else if (current_packet == total_packet)
            {
                dataArray = new byte[sizeOfMessage + SIZE_OF_CHECKSUM];
                Array.Copy(incoming_data, HEADER_SIZE, dataArray, 0, dataArray.Length); // copy data + checksum
                MergedMessage = Combine(MergedMessage, dataArray);
            }
            else
            {
                return; // unreachable status
            }

            /*Now in MergedMessage will be the full message including checksum*/
            
            checksumReceived = (uint)BitConverter.ToUInt32(MergedMessage, MergedMessage.Length - 4); // exclude 4 byte of the Checksum
            checksumCalculated = calculateCheckSum32(MergedMessage, (uint)MergedMessage.Length - 4);  //exclude 4 byte of the Checksum


            if (!checkMegicNumber(magicNumber))
            {// the magic number is incorrect
                return;
            }
            if (checksumReceived != checksumCalculated)
            { // Wrong Checksum 
                return;
            }
            if (destination != (int)enumDevice_id.VIEWER)
            { // destination is not for the viewer
                return;
            }

            if (source == (uint)this.device_id)
            { //this message is from this socket
                if (!isRTCTXSocketInit)
                {
                    epRTCTX = epReceived;
                    isRTCTXSocketInit = true;
                }
            }
            else
            { //this message is not for this socket
                return;
            }


            /* Forward to the relevant module with only the data */
            if (ModuleDictinary.ContainsKey(type))
            {
                dataArray = new byte[MergedMessage.Length - 2];
                Array.Copy(MergedMessage, 0, dataArray, 0, MergedMessage.Length - 2); // copy only data without headers or checksum
                ModuleDictinary[type].update(dataArray, (uint)dataArray.Length, type, source); // pass the message without checksum
                lastReceivedTimeStamp = (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) / 1000;

            }
            else
            {//throw the message - unknown type
                return;
            }


        }

        public void sendMsgToRT(byte[] dataArray, uint type, enumDevice_id dest)
        {
            byte[] msgToSend; // the full message 
            byte[] msgHeaderBuffer; // header message
            byte[] msgHeaderAndData; // header+ data message
            MessageHeader msg = new MessageHeader();

            if (type == (uint)TypeOfTxMessage.WRONG_MAGIC_NUMBER_TYPE)
            {
                msg.magic_number = (uint)0xabcde; // make wrong magic number
            }
            else
            {
                msg.magic_number = (uint)MAGIC_NUMBER;
            }
            msg.source = (uint)enumDevice_id.VIEWER;
            msg.destination = (uint)dest; // RT1 or RT2
            msg.spare1 = 0;
            msg.spare2 = 0;
            msg.current_packet = 1;
            msg.total_packet = 1;
            msg.type = type;
            msg.size = (uint)dataArray.Length;
            msgHeaderBuffer = getBytesFromMessageHeaderStruct(msg);
            msgHeaderAndData = Combine(msgHeaderBuffer, dataArray);

            uint checksum = calculateCheckSum32(msgHeaderAndData, (uint)msgHeaderAndData.Length);
            if (type == (uint)TypeOfTxMessage.WRONG_CHECKSUM_TYPE)
            {
                checksum += 1; // make a wrong checksum
            }
            msgToSend = Combine(msgHeaderAndData, BitConverter.GetBytes(checksum));

            if (type > (uint)TypeOfTxMessage.MAX_TYPE || type < 0)
            {// unkown type
                return;
            }

            if (isRTCTXSocketInit == true)
            {

                ipepRTCTX = new IPEndPoint(((IPEndPoint)epRTCTX).Address, (int)Convert.ToInt32(portNumberTX));
                int result = clientTXRTC.Send(msgToSend, msgToSend.Length, ipepRTCTX);
            }
            else
            {
                MessageBox.Show("Cannot send message to RT, Please check the connection to RT", "Communication Error");
            }
        }

        public bool startListening()
        {

            if (createSocket())
            {
                listeningThread = new Thread(listening);
                listeningThread.IsBackground = true;
                listeningThread.Start();
                isListening = true;
                return true;
            }
            return false;
        }

        public void stopListening()
        {
            isListening = false;
            sockRX.Shutdown(SocketShutdown.Both);
            sockRX.Close();
            isSocketAlive = false;
        }

        public void listening()
        {


            byte[] incomingData = new byte[MAX_SIZE_OF_MESSAGE];
            int sizeOfIncomingMessage;
            while (true)
            {
                if (isListening)
                {
                    Array.Clear(incomingData, 0, incomingData.Length);
                    try
                    {
                       
                        sizeOfIncomingMessage = sockRX.ReceiveFrom(incomingData, ref epRX);

                        ManageData(incomingData, sizeOfIncomingMessage, epRX);
        
                    }
                    catch (Exception e)
                    {//Will be catch while killing the thread
                        if (e.Message.Contains("WSACancelBlockingCall") == false)
                        {
                           // MessageBox.Show("Information: " + e.Message.ToString());
                        }           

                    }
                    Thread.Sleep(20);
                }

            }

        }

        public bool checkMegicNumber(uint megicNumber_)
        {
            if (megicNumber_ == MAGIC_NUMBER)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public uint calculateCheckSum32(byte[] dataArray, uint size)
        {
            uint result = 0;
            for (int i = 0; i < size; i++)
            {
                result += dataArray[i];
            }

            return result;
        }

        public bool isSocketConnected()
        {
            if (sockRX != null && isListening)
            {
                long currentTime = (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) / 1000; // current time in second

                if (currentTime - lastReceivedTimeStamp > 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        byte[] getBytesFromMessageHeaderStruct(MessageHeader str)
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, false);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }


        byte[] Combine(byte[] a1, byte[] a2, byte[] a3)
        {
            byte[] ret = new byte[a1.Length + a2.Length + a3.Length];
            Array.Copy(a1, 0, ret, 0, a1.Length);
            Array.Copy(a2, 0, ret, a1.Length, a2.Length);
            Array.Copy(a3, 0, ret, a1.Length + a2.Length, a3.Length);
            return ret;
        }

        byte[] Combine(byte[] a1, byte[] a2)
        {
            byte[] ret = new byte[a1.Length + a2.Length];
            Array.Copy(a1, 0, ret, 0, a1.Length);
            Array.Copy(a2, 0, ret, a1.Length, a2.Length);
            return ret;
        }


        internal void ClearDisplay()
        {
            icdModule.Clear();
        }
    }
}
