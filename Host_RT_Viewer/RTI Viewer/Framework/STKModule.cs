using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace RT_Viewer.Framework
{
    public class STKModule : IModule
    {

        public class STKTaxiTable
        {
            public string tail_number      { get; set; }
            public string on_ground        { get; set; }
            public string taxi_enabled     { get; set; }
            public string taxi_report      { get; set; }
            public string taxi_command_sent{ get; set; }
            public string ka_cntr          { get; set; }
        }

        public struct UAVInfoEntry
        {
            public uint on_ground;
            public uint taxi_enabled;
            public uint taxi_report;
            public uint taxi_command_sent;
            public uint ka_cntr;
            public uint is_release_key_enabled;
        }
        
        public struct STKSturct
        {
           public uint maxTailNumber;
           public uint[] tail_number;
           public UAVInfoEntry[] uavEntry;
        }

        public STKSturct stkStruct;
        public BindingList<STKTaxiTable> BL_STKTaxiTable;

        public STKModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            stkStruct = new STKSturct();
            BL_STKTaxiTable = new BindingList<STKTaxiTable>();
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            string isOnGround;
            string isTaxi_enabled;

            int length;
            int indexReader = 0;
            IntPtr ptr;

          
            stkStruct.maxTailNumber = (uint)BitConverter.ToInt32(msg, indexReader);
            indexReader += 4;
            stkStruct.tail_number = new uint[stkStruct.maxTailNumber];
            for(int i=0;i<stkStruct.maxTailNumber; i++)
            {
                stkStruct.tail_number[i] =  (uint)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
            }

            stkStruct.uavEntry = new UAVInfoEntry[stkStruct.maxTailNumber];
            BL_STKTaxiTable=new BindingList<STKTaxiTable>();

            for (int i = 0; i < stkStruct.maxTailNumber; i++)
            {
                
                length = Marshal.SizeOf(stkStruct.uavEntry[i]);
                ptr = Marshal.AllocHGlobal(length);
                Marshal.Copy(msg, indexReader, ptr, length);
                stkStruct.uavEntry[i] = (UAVInfoEntry)Marshal.PtrToStructure(ptr, stkStruct.uavEntry[i].GetType());
                Marshal.FreeHGlobal(ptr);
                indexReader += length;

                if (stkStruct.tail_number[i] != 0)
                {
                    if (stkStruct.uavEntry[i].on_ground == 0)
                    {
                        isOnGround = "NO";
                    }
                    else
                    {
                        isOnGround = "YES";
                    }

                    if (stkStruct.uavEntry[i].taxi_enabled == 0)
                    {
                        isTaxi_enabled = "Disable";
                    }
                    else
                    {
                        isTaxi_enabled = "Enable";
                    }


                    BL_STKTaxiTable.Add(new STKTaxiTable
                    {
                        ka_cntr = stkStruct.uavEntry[i].ka_cntr.ToString(),
                        on_ground = isOnGround,
                        tail_number = stkStruct.tail_number[i].ToString(),
                        taxi_command_sent = stkStruct.uavEntry[i].taxi_command_sent.ToString(),
                        taxi_enabled = isTaxi_enabled,
                        taxi_report = stkStruct.uavEntry[i].taxi_report.ToString(),
                    });
                }
            }

           

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }


    }
}
