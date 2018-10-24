using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;

namespace RT_Viewer.Framework
{
    public class RTIModule : IModule
    {
        /*Main RTI table*/
        public class UPLTable
        {
            public string tail_number { get; set; }
            public string CBand { get; set; }
            public string UHF { get; set; }
            public string SATCOM1 { get; set; }
            public string SATCOM2 { get; set; }
            public string IRIDIUM { get; set; }
            public string MOBILICOM { get; set; }
            public string CH_7 { get; set; }
            public string CH_8 { get; set; }
            public string CH_9 { get; set; }
            public string CH_10 { get; set; }
        }
        /*HST\UAV RTI table*/
        public class RTEntry
        {
            public string tail_number { get; set; }
            public string gcs_extra { get; set; }
            public string uplinkID1 { get; set; }
            public string uplinkID2 { get; set; }
            public string uplinkID3 { get; set; }
            public string uplinkID4 { get; set; }
            public string uplinkID5 { get; set; }
            public string uplinkID6 { get; set; }
            public string uplinkID7 { get; set; }
            public string uplinkID8 { get; set; }
            public string uplinkID9 { get; set; }
            public string uplinkID10 { get; set; }
        }
        /*LOP table*/
        public class LOPTable
        {
            public string tail_number { get; set; }
            public string console { get; set; }
            public string permission { get; set; }
            public string is_selected { get; set; }
        }



        public struct UPLTableStruct
        {
            public int tail_number;
            public uint no_downlink_timer;
            public uint num_active_comm;
            public uint gcs_extra;
            public uint vehicle_type;
            public ip_configuraton CBand;
            public ip_configuraton UHF;
            public ip_configuraton SATCOM1;
            public ip_configuraton SATCOM2;
            public ip_configuraton IRIDIUM;
            public ip_configuraton MOBILICOM;
            public ip_configuraton CH_7;
            public ip_configuraton CH_8;
            public ip_configuraton CH_9;
            public ip_configuraton CH_10;
        }

        public struct ip_configuraton
        {
            public uint received_udp_socket;
            public uint received_port;
            public int ip;
            public uint port;
            public uint uplink_id;
            public uint new_uplink_id;
            public uint transaction_type;
            public uint site_id;
            public uint gdt_id;
            public uint channel_id;
        }

        public struct LOPTableStruct
        {
            public uint console;
            public uint tail_number;
            public uint permission;
            public uint is_selected;

        }

        public struct HST_RTEntrySturct
        {
           public uint tail;
	       public uint gcs_extra;
	       public uint uplink_id1;
           public uint uplink_id2;
           public uint uplink_id3;
           public uint uplink_id4;
           public uint uplink_id5;
           public uint uplink_id6;
           public uint uplink_id7;
           public uint uplink_id8;
           public uint uplink_id9;
           public uint uplink_id10;
        }

        public struct UAV_RTEntrySturct
        {
            public uint tail;
            public uint gcs_extra;
            public uint gcs_id1;
            public uint gcs_id2;
            public uint gcs_id3;
            public uint gcs_id4;
            public uint gcs_id5;
            public uint gcs_id6;
            public uint gcs_id7;
            public uint gcs_id8;
            public uint gcs_id9;
            public uint gcs_id10;
            public uint num_rx_ka_msg1;
            public uint num_rx_ka_msg2;
            public uint num_rx_ka_msg3;
            public uint num_rx_ka_msg4;
            public uint num_rx_ka_msg5;
            public uint num_rx_ka_msg6;
            public uint num_rx_ka_msg7;
            public uint num_rx_ka_msg8;
            public uint num_rx_ka_msg9;
            public uint num_rx_ka_msg10;
            public uint ch_src_type;
        }



        public struct StateMechineStruct
        {
            public uint timer;
            public uint time_limit;
            public uint time_limit_ch_default;
            public uint time_limit_ch_iridium;
            public uint no_downlink_time_limit;
            public uint table_transaction;
            public uint is_hst_table_rx_transaction_flag;
            public uint is_uav_table_rx_transaction_flag;
            public uint is_uav_table_rx_flag;
        }

        public struct CntrMsgStruct
        {
            public uint lop_message_counter;
            public uint main_routing_table_cntr;
            public uint hst_routing_table_cntr;
            public uint uav_routing_table_cntr;
        }

        public struct RTIDblock
        {
            public LOPTableStruct[] lopMessage; //Size of 10         
            public UPLTableStruct[] uplMessage;//Size of 10    
            public HST_RTEntrySturct[] hstRTIMessage;//Size of 10 
            public UAV_RTEntrySturct[] uavRTIMessage;//Size of 10 
            public StateMechineStruct stateMachineMessage; 
            public CntrMsgStruct cntrMessage;                  
        }

        public enum enumRTI_TransactionType
        {
            C_RTI_CHANNEL_TRANS_NONE = 0,     /* No Change in Uplink Channel .    */
            C_RTI_CHANNEL_TRANS_SET,          /* Set Uplink Channel Number .      */
            C_RTI_CHANNEL_TRANS_ADD,          /* Add Uplink Channel Number .      */
            C_RTI_CHANNEL_TRANS_DEL,          /* Delete Uplink Channel Number .   */
            C_RTI_CHANNEL_TRANS_MAX
        };


        public BindingList<UPLTable> BL_RTITable;
        public BindingList<RTEntry>  BL_HSTTable;
        public BindingList<RTEntry>  BL_UAVTable;
        public BindingList<LOPTable> BL_LOPTable;

        public RTIDblock rtiBlock;
        public string stateMechine;
        public const uint NUM_OF_UAV = 10;
        //method

        public RTIModule(SocketHandler.enumDevice_id deviceID)
        {
            rtiBlock = new RTIDblock();
            rtiBlock.lopMessage = new LOPTableStruct[10];
            rtiBlock.uplMessage = new UPLTableStruct[10];
            rtiBlock.hstRTIMessage = new HST_RTEntrySturct[10];
            rtiBlock.uavRTIMessage = new UAV_RTEntrySturct[10];
            deviceIdConnected = deviceID;
        }


        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int remainLength = (int)size;
            int indexReader = 0;
            int length;
            IntPtr ptr;

            string permissionCode, isSelectedCode;

            BL_LOPTable = new BindingList<LOPTable>();
            BL_RTITable = new BindingList<UPLTable>();
            BL_HSTTable = new BindingList<RTEntry>();
            BL_UAVTable = new BindingList<RTEntry>();

            /*Get unicon LOP Table*/
            for (int i = 0; i < NUM_OF_UAV; i++)
            {
                length = Marshal.SizeOf(rtiBlock.lopMessage[i]);
                ptr = Marshal.AllocHGlobal(length);
                Marshal.Copy(msg, indexReader, ptr, length);
                rtiBlock.lopMessage[i] = (LOPTableStruct)Marshal.PtrToStructure(ptr, rtiBlock.lopMessage[i].GetType());
                Marshal.FreeHGlobal(ptr);
                indexReader += length;
                remainLength = remainLength - length;
                if (rtiBlock.lopMessage[i].tail_number == 0)
                {
                    continue;
                }

                permissionCode = "N\\A";
                if (rtiBlock.lopMessage[i].permission == 0)
                {
                    permissionCode = "NONE";
                }
                else if (rtiBlock.lopMessage[i].permission == 1)
                {
                    permissionCode = "Read Only";
                }
                else if (rtiBlock.lopMessage[i].permission == 2)
                {
                    permissionCode = "FULL";
                }

                isSelectedCode = "N\\A";
                if (rtiBlock.lopMessage[i].is_selected == 0)
                {
                    isSelectedCode = "Not Selected";
                }
                else if (rtiBlock.lopMessage[i].is_selected == 1)
                {
                    isSelectedCode = "Selected";
                }

                BL_LOPTable.Add(new LOPTable
                {

                    tail_number = rtiBlock.lopMessage[i].tail_number.ToString(),
                    console = rtiBlock.lopMessage[i].console.ToString(),
                    permission = permissionCode,
                    is_selected = isSelectedCode
                });
            }
            /*Get Main RTI Table*/
            for (int i = 0; i < NUM_OF_UAV; i++)
            {
                length = Marshal.SizeOf(rtiBlock.uplMessage[i]);
                ptr = Marshal.AllocHGlobal(length);
                Marshal.Copy(msg, indexReader, ptr, length);
                rtiBlock.uplMessage[i] = (UPLTableStruct)Marshal.PtrToStructure(ptr, rtiBlock.uplMessage[i].GetType());
                Marshal.FreeHGlobal(ptr);
                indexReader += length;
                remainLength = remainLength - length;
                if (rtiBlock.uplMessage[i].tail_number == 0)
                {
                    continue;
                }

                BL_RTITable.Add(new UPLTable
                {
                    tail_number = rtiBlock.uplMessage[i].tail_number.ToString(),
                    CBand = rtiBlock.uplMessage[i].CBand.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].CBand.ip) + ":" + rtiBlock.uplMessage[i].CBand.port.ToString(),
                    UHF = rtiBlock.uplMessage[i].UHF.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].UHF.ip) + ":" + rtiBlock.uplMessage[i].UHF.port.ToString(),
                    IRIDIUM = rtiBlock.uplMessage[i].IRIDIUM.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].IRIDIUM.ip) + ":" + rtiBlock.uplMessage[i].IRIDIUM.port.ToString(),
                    MOBILICOM = rtiBlock.uplMessage[i].MOBILICOM.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].MOBILICOM.ip) + ":" + rtiBlock.uplMessage[i].MOBILICOM.port.ToString(),
                    SATCOM1 = rtiBlock.uplMessage[i].SATCOM1.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].SATCOM1.ip) + ":" + rtiBlock.uplMessage[i].SATCOM1.port.ToString(),
                    SATCOM2 = rtiBlock.uplMessage[i].SATCOM2.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].SATCOM2.ip) + ":" + rtiBlock.uplMessage[i].SATCOM2.port.ToString(),
                    CH_7 = rtiBlock.uplMessage[i].CH_7.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].CH_7.ip) + ":" + rtiBlock.uplMessage[i].CH_7.port.ToString(),
                    CH_8 = rtiBlock.uplMessage[i].CH_8.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].CH_8.ip) + ":" + rtiBlock.uplMessage[i].CH_8.port.ToString(),
                    CH_9 = rtiBlock.uplMessage[i].CH_9.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].CH_9.ip) + ":" + rtiBlock.uplMessage[i].CH_9.port.ToString(),
                    CH_10 = rtiBlock.uplMessage[i].CH_10.received_port.ToString() + ":" + getIPStringFromInt(rtiBlock.uplMessage[i].CH_10.ip) + ":" + rtiBlock.uplMessage[i].CH_10.port.ToString(),
                });
            }
            /*Get HST RTI Table*/
            for (int i = 0; i < NUM_OF_UAV; i++)
            {
                length = Marshal.SizeOf(rtiBlock.hstRTIMessage[i]);
                ptr = Marshal.AllocHGlobal(length);
                Marshal.Copy(msg, indexReader, ptr, length);
                rtiBlock.hstRTIMessage[i] = (HST_RTEntrySturct)Marshal.PtrToStructure(ptr, rtiBlock.hstRTIMessage[i].GetType());
                Marshal.FreeHGlobal(ptr);
                indexReader += length;
                remainLength = remainLength - length;
                if (rtiBlock.hstRTIMessage[i].tail == 0)
                {
                    continue;
                }

                BL_HSTTable.Add(new RTEntry
                {
                    tail_number = rtiBlock.hstRTIMessage[i].tail.ToString(),
                    gcs_extra = rtiBlock.hstRTIMessage[i].gcs_extra.ToString(),
                    uplinkID1 = rtiBlock.hstRTIMessage[i].uplink_id1.ToString(),
                    uplinkID2 = rtiBlock.hstRTIMessage[i].uplink_id2.ToString(),
                    uplinkID3 = rtiBlock.hstRTIMessage[i].uplink_id3.ToString(),
                    uplinkID4 = rtiBlock.hstRTIMessage[i].uplink_id4.ToString(),
                    uplinkID5 = rtiBlock.hstRTIMessage[i].uplink_id5.ToString(),
                    uplinkID6 = rtiBlock.hstRTIMessage[i].uplink_id6.ToString(),
                    uplinkID7 = rtiBlock.hstRTIMessage[i].uplink_id7.ToString(),
                    uplinkID8 = rtiBlock.hstRTIMessage[i].uplink_id8.ToString(),
                    uplinkID9 = rtiBlock.hstRTIMessage[i].uplink_id9.ToString(),
                    uplinkID10 = rtiBlock.hstRTIMessage[i].uplink_id10.ToString(),

                });
            }

            /*Get UAV RTI Table*/
            for (int i = 0; i < NUM_OF_UAV; i++)
            {
                length = Marshal.SizeOf(rtiBlock.uavRTIMessage[i]);
                ptr = Marshal.AllocHGlobal(length);
                Marshal.Copy(msg, indexReader, ptr, length);
                rtiBlock.uavRTIMessage[i] = (UAV_RTEntrySturct)Marshal.PtrToStructure(ptr, rtiBlock.uavRTIMessage[i].GetType());
                Marshal.FreeHGlobal(ptr);
                indexReader += length;
                remainLength = remainLength - length;
                if (rtiBlock.uavRTIMessage[i].tail == 0)
                {
                    continue;
                }

                BL_UAVTable.Add(new RTEntry
                {
                    tail_number = rtiBlock.uavRTIMessage[i].tail.ToString(),
                    gcs_extra = rtiBlock.uavRTIMessage[i].gcs_extra.ToString(),
                    uplinkID1 = rtiBlock.uavRTIMessage[i].gcs_id1.ToString(),
                    uplinkID2 = rtiBlock.uavRTIMessage[i].gcs_id2.ToString(),
                    uplinkID3 = rtiBlock.uavRTIMessage[i].gcs_id3.ToString(),
                    uplinkID4 = rtiBlock.uavRTIMessage[i].gcs_id4.ToString(),
                    uplinkID5 = rtiBlock.uavRTIMessage[i].gcs_id5.ToString(),
                    uplinkID6 = rtiBlock.uavRTIMessage[i].gcs_id6.ToString(),
                    uplinkID7 = rtiBlock.uavRTIMessage[i].gcs_id7.ToString(),
                    uplinkID8 = rtiBlock.uavRTIMessage[i].gcs_id8.ToString(),
                    uplinkID9 = rtiBlock.uavRTIMessage[i].gcs_id9.ToString(),
                    uplinkID10 = rtiBlock.uavRTIMessage[i].gcs_id10.ToString(),

                });
            }

            //Read StateMachine
            length = Marshal.SizeOf(rtiBlock.stateMachineMessage);
            ptr = Marshal.AllocHGlobal(length);
            Marshal.Copy(msg, indexReader, ptr, length);
            rtiBlock.stateMachineMessage = (StateMechineStruct)Marshal.PtrToStructure(ptr, rtiBlock.stateMachineMessage.GetType());
            Marshal.FreeHGlobal(ptr);
            indexReader += length;
            remainLength = remainLength - length;
            stateMechine = intToEnum((int)rtiBlock.stateMachineMessage.table_transaction);

            //Read CntrMessages
            length = Marshal.SizeOf(rtiBlock.cntrMessage);
            ptr = Marshal.AllocHGlobal(length);
            Marshal.Copy(msg, indexReader, ptr, length);
            rtiBlock.cntrMessage = (CntrMsgStruct)Marshal.PtrToStructure(ptr, rtiBlock.cntrMessage.GetType());
            Marshal.FreeHGlobal(ptr);
            indexReader += length;
            remainLength = remainLength - length;


            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }

        public string getIPStringFromInt(int ip)
        {
            string result = BitConverter.GetBytes(ip)[0] + "." + BitConverter.GetBytes(ip)[1] + "." + BitConverter.GetBytes(ip)[2] + "." + BitConverter.GetBytes(ip)[3];
            return result;
        }

        public string intToEnum(int num)
        {

            if (enumRTI_TransactionType.IsDefined(typeof(enumRTI_TransactionType), num))
            {
                enumRTI_TransactionType e = (enumRTI_TransactionType)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }
  
    }
}
