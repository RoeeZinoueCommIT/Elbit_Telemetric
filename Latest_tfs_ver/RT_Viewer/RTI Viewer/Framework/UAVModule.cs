using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace RT_Viewer.Framework
{
    public class UAVModule : IModule
    {
        public class DNLTable
        {
            public string tail_number { get; set; }
            public string CBAND { get; set; }
            public string CBAND_COUNTER { get; set; }
            public string UHF { get; set; }
            public string UHF_COUNTER { get; set; }
            public string SATCOM { get; set; }
            public string SATCOM_COUNTER { get; set; }
            public string CH_4 { get; set; }
            public string CH_5 { get; set; }
            public string CH_6 { get; set; }
            public string CH_7 { get; set; }
            public string CH_8 { get; set; }
            public string CH_9 { get; set; }
            public string CH_10 { get; set; }
        }

        public struct DNLStructEntry
        {
           public uint tail_number;
           public uint vehicle_type;
           public uint dnl_port1;
           public uint dnl_port2;
           public uint dnl_port3;
           public uint dnl_port4;
           public uint dnl_port5;
           public uint dnl_port6;
           public uint dnl_port7;
           public uint dnl_port8;
           public uint dnl_port9;
           public uint dnl_port10;
           public uint dnl_ip1;
           public uint dnl_ip2;
           public uint dnl_ip3;
           public uint dnl_ip4;
           public uint dnl_ip5;
           public uint dnl_ip6;
           public uint dnl_ip7;
           public uint dnl_ip8;
           public uint dnl_ip9;
           public uint dnl_ip10;
           public uint dnl_receive_socket1;
           public uint dnl_receive_socket2;
           public uint dnl_receive_socket3;
           public uint dnl_receive_socket4;
           public uint dnl_receive_socket5;
           public uint dnl_receive_socket6;
           public uint dnl_receive_socket7;
           public uint dnl_receive_socket8;
           public uint dnl_receive_socket9;
           public uint dnl_receive_socket10;
           public uint dnl_receive_cntr1;
           public uint dnl_receive_cntr2;
           public uint dnl_receive_cntr3;
           public uint dnl_receive_cntr4;
           public uint dnl_receive_cntr5;
           public uint dnl_receive_cntr6;
           public uint dnl_receive_cntr7;
           public uint dnl_receive_cntr8;
           public uint dnl_receive_cntr9;
           public uint dnl_receive_cntr10;

        }
        public struct UAVStruct
        {
            public DNLStructEntry uavDNLStructEntry1;
            public DNLStructEntry uavDNLStructEntry2;
            public DNLStructEntry uavDNLStructEntry3;
            public DNLStructEntry uavDNLStructEntry4;
            public DNLStructEntry uavDNLStructEntry5;
            public DNLStructEntry uavDNLStructEntry6;
            public DNLStructEntry uavDNLStructEntry7;
            public DNLStructEntry uavDNLStructEntry8;
            public DNLStructEntry uavDNLStructEntry9;
            public DNLStructEntry uavDNLStructEntry10;
        }

        public UAVStruct uavStruct;
        public BindingList<DNLTable> BL_DNLTable;

        public UAVModule(SocketHandler.enumDevice_id deviceID)
        {
            uavStruct = new UAVStruct();
            deviceIdConnected = deviceID;
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int length;
            IntPtr ptr;
            length = Marshal.SizeOf(uavStruct);
            ptr = Marshal.AllocHGlobal(length);
            Marshal.Copy(msg, 0, ptr, length);
            UAVStruct tempUAVBlock = (UAVStruct)Marshal.PtrToStructure(ptr, uavStruct.GetType());
            Marshal.FreeHGlobal(ptr);
            BL_DNLTable = new BindingList<DNLTable>();

          while (true)
          {
          
              if (tempUAVBlock.uavDNLStructEntry1.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry1.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry1.dnl_receive_cntr1.ToString(),
                      UHF         = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip2)  + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry1.dnl_receive_cntr2.ToString(),
                      SATCOM      = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry1.dnl_receive_cntr3.ToString(),
                      CH_4        = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip4)  + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port4.ToString(),  
                      CH_5        = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip5)  + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port5.ToString(),  
                      CH_6        = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip6)  + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port6.ToString(),  
                      CH_7        = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip7)  + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port7.ToString(),  
                      CH_8        = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip8)  + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port8.ToString(),  
                      CH_9        = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip9)  + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port9.ToString(),      
                      CH_10       = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry1.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry1.dnl_port10.ToString(),  
          
                  });
              }
              else { break; }

              if (tempUAVBlock.uavDNLStructEntry2.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry2.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry2.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry2.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry2.dnl_receive_cntr3.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry2.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry2.dnl_port10.ToString(),  

                  });
              }
              else { break; }
              if (tempUAVBlock.uavDNLStructEntry3.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry3.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry3.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry3.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry3.dnl_receive_cntr3.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry3.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry3.dnl_port10.ToString(),   

                  });
              }
              else { break; }
              if (tempUAVBlock.uavDNLStructEntry4.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry4.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry4.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry4.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry1.dnl_receive_cntr4.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry4.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry4.dnl_port10.ToString(),  
                  });
              }
              else { break; }
              if (tempUAVBlock.uavDNLStructEntry5.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry5.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry5.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry5.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry5.dnl_receive_cntr3.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry5.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry5.dnl_port10.ToString(),   
                  });
              }
              else { break; }
              if (tempUAVBlock.uavDNLStructEntry6.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry6.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry6.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry6.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry1.dnl_receive_cntr6.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry6.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry6.dnl_port10.ToString(),  
                  });
              }
              else { break; }
              if (tempUAVBlock.uavDNLStructEntry7.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry7.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry7.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry7.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry7.dnl_receive_cntr3.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry7.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry7.dnl_port10.ToString(),   
                  });
              }
              else { break; }
              if (tempUAVBlock.uavDNLStructEntry8.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry8.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry8.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry8.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry8.dnl_receive_cntr3.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry8.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry8.dnl_port10.ToString(),  

                  });
              }
              else { break; }
              if (tempUAVBlock.uavDNLStructEntry9.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry9.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry9.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry9.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry9.dnl_receive_cntr3.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry9.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry9.dnl_port10.ToString(),  

                  });
              }
              else { break; }
              if (tempUAVBlock.uavDNLStructEntry10.tail_number != 0)
              {
                  BL_DNLTable.Add(new DNLTable
                  {
                      tail_number = tempUAVBlock.uavDNLStructEntry10.tail_number.ToString(),
                      CBAND = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip1) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port1.ToString(),
                      CBAND_COUNTER = tempUAVBlock.uavDNLStructEntry10.dnl_receive_cntr1.ToString(),
                      UHF = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip2) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port2.ToString(),
                      UHF_COUNTER = tempUAVBlock.uavDNLStructEntry10.dnl_receive_cntr2.ToString(),
                      SATCOM = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip3) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port3.ToString(),
                      SATCOM_COUNTER = tempUAVBlock.uavDNLStructEntry10.dnl_receive_cntr3.ToString(),
                      CH_4 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip4) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port4.ToString(),
                      CH_5 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip5) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port5.ToString(),
                      CH_6 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip6) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port6.ToString(),
                      CH_7 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip7) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port7.ToString(),
                      CH_8 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip8) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port8.ToString(),
                      CH_9 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip9) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port9.ToString(),
                      CH_10 = getIPStringFromUint(tempUAVBlock.uavDNLStructEntry10.dnl_ip10) + ":" + tempUAVBlock.uavDNLStructEntry10.dnl_port10.ToString(),    

                  });
              }
              else { break; }
               break;
          }

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));

            return true;
        }
         
        public string getIPStringFromUint(uint ip)
        {
            string result = BitConverter.GetBytes(ip)[0] + "." + BitConverter.GetBytes(ip)[1] + "." + BitConverter.GetBytes(ip)[2] + "." + BitConverter.GetBytes(ip)[3];
            return result;
        }
    }
}
