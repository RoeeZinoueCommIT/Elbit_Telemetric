using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace RT_Viewer.Framework
{
    public class GDTModule : IModule
    {
        public const int GDT_TABLE_SIZE = 15;

        public enum enumAPP_gdt_commType
        {
            APP_COMMON_GDT_COMM_TYPE_C_BAND   = 0,
            APP_COMMON_GDT_COMM_TYPE_UHF      ,
            APP_COMMON_GDT_COMM_TYPE_MAX 
        } ;


        public class GDTTable
        {
            public string GdtId { get; set; }
            public string Rx_CBand { get; set; }
            public string Rx_UHF { get; set; }
            public string Tx_CBand { get; set; }
            public string Tx_UHF { get; set; }
            public string GDT_Rx_CBand { get; set; }
            public string GDT_Rx_UHF { get; set; }
        }

        public BindingList<GDTTable> BL_GDTTable;


        public struct C_GDT_ip_config_data
        {
            public uint port;
            public uint ip;
            public uint socket;
        } ;


        public struct C_GDT_Channels
        {
            public C_GDT_ip_config_data[] rx_control_status;
            public C_GDT_ip_config_data[] tx_gdt;
        } ;

        public struct DT_NVM_configFileGdtSet_type
        {
           public uint                         site_id;                                         /* Site Id . */
           public uint                         gdt_id;                                          /* Gdt  Id . */
        }  ;


        public struct Gdt_Struct
        {
            public C_GDT_Channels[] channels;
            public DT_NVM_configFileGdtSet_type[] table; 
            public uint size;
        } ;

        Gdt_Struct gdtStruct;

        public GDTModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;

            gdtStruct = new Gdt_Struct();

            gdtStruct.channels = new C_GDT_Channels[GDT_TABLE_SIZE];
            gdtStruct.table = new DT_NVM_configFileGdtSet_type[GDT_TABLE_SIZE];
            gdtStruct.size = 0;

            for (int Index = 0; Index < GDT_TABLE_SIZE; Index++)
            {
                gdtStruct.channels[Index].rx_control_status = new C_GDT_ip_config_data[(int)(enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_MAX)];
                gdtStruct.channels[Index].tx_gdt = new C_GDT_ip_config_data[(int)(enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_MAX)];

            }
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int remainLength = (int)size;
            int indexReader = 0;

            for (int Index = 0; Index < GDT_TABLE_SIZE; Index++)
            {
                for (int j = 0; j < (int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_MAX; j++)
                {
                    gdtStruct.channels[Index].rx_control_status[j].port = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                    gdtStruct.channels[Index].rx_control_status[j].ip = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                    gdtStruct.channels[Index].rx_control_status[j].socket = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                }
                for (int j = 0; j < (int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_MAX; j++)
                {
                    gdtStruct.channels[Index].tx_gdt[j].port = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                    gdtStruct.channels[Index].tx_gdt[j].ip = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                    gdtStruct.channels[Index].tx_gdt[j].socket = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                }
            }

            for (int Index = 0; Index < GDT_TABLE_SIZE; Index++)
            {
               gdtStruct.table[Index].site_id = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                gdtStruct.table[Index].gdt_id = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
            }
            gdtStruct.size = (uint)BitConverter.ToUInt32(msg, indexReader);
            indexReader += 4;

           
            BL_GDTTable = new BindingList<GDTTable>();

            for (int i = 0; i < gdtStruct.size; i++)
            {
                string gdt_name;

                gdt_name = "";
                if ((gdtStruct.table[i].site_id == 2) && (gdtStruct.table[i].gdt_id == 1))
                {
                    gdt_name = "Eastern 1  ";
                }

                if ((gdtStruct.table[i].site_id == 2) && (gdtStruct.table[i].gdt_id == 2))
                {
                    gdt_name = "Eastern 2  ";
                }

                if ((gdtStruct.table[i].site_id == 2) && (gdtStruct.table[i].gdt_id == 3))
                {
                    gdt_name = "Eastern 3  ";
                }

                if ((gdtStruct.table[i].site_id == 2) && (gdtStruct.table[i].gdt_id == 4))
                {
                    gdt_name = "Eastern 4  ";
                }

                if ((gdtStruct.table[i].site_id == 2) && (gdtStruct.table[i].gdt_id == 5))
                {
                    gdt_name = "Eastern 5  ";
                }

                if ((gdtStruct.table[i].site_id == 3) && (gdtStruct.table[i].gdt_id == 1))
                {
                    gdt_name = "Western 1 ";
                }

                if ((gdtStruct.table[i].site_id == 3) && (gdtStruct.table[i].gdt_id == 2))
                {
                    gdt_name = "Western 2 ";
                }

                if ((gdtStruct.table[i].site_id == 3) && (gdtStruct.table[i].gdt_id == 3))
                {
                    gdt_name = "Western 3 ";
                }

                if ((gdtStruct.table[i].site_id == 3) && (gdtStruct.table[i].gdt_id == 4))
                {
                    gdt_name = "Western 4 ";
                }

                if ((gdtStruct.table[i].site_id == 3) && (gdtStruct.table[i].gdt_id == 5))
                {
                    gdt_name = "Western 5 ";
                }

                if ((gdtStruct.table[i].site_id == 3) && (gdtStruct.table[i].gdt_id == 5))
                {
                    gdt_name = "Western 5 ";
                }

                if ((gdtStruct.table[i].site_id == 4) && (gdtStruct.table[i].gdt_id == 1))
                {
                    gdt_name = "Southern 1";
                }

                if ((gdtStruct.table[i].site_id == 4) && (gdtStruct.table[i].gdt_id == 2))
                {
                    gdt_name = "Southern 2";
                }

                if ((gdtStruct.table[i].site_id == 4) && (gdtStruct.table[i].gdt_id == 3))
                {
                    gdt_name = "Southern 3";
                }

                if ((gdtStruct.table[i].site_id == 4) && (gdtStruct.table[i].gdt_id == 4))
                {
                    gdt_name = "Southern 4";
                }

                if ((gdtStruct.table[i].site_id == 4) && (gdtStruct.table[i].gdt_id == 5))
                {
                    gdt_name = "Southern 5";
                }

                if ((gdtStruct.table[i].site_id == 5) && (gdtStruct.table[i].gdt_id == 1))
                {
                    gdt_name = "mGDT 1    ";
                }

                if ((gdtStruct.table[i].site_id == 6) && (gdtStruct.table[i].gdt_id == 1))
                {
                    gdt_name = "mGDT 2    ";
                }

                if ((gdtStruct.table[i].site_id == 1) && (gdtStruct.table[i].gdt_id == 1))
                {
                    gdt_name = "MOB 1      ";
                }

                if ((gdtStruct.table[i].site_id == 1) && (gdtStruct.table[i].gdt_id == 3))
                {
                    gdt_name = "MOB 3      ";
                }

                BL_GDTTable.Add(new GDTTable
                {
                    GdtId = gdt_name + "   { " + gdtStruct.table[i].site_id.ToString() + " , " + gdtStruct.table[i].gdt_id.ToString() + " } ",
                    Rx_CBand = getIPStringFromUint(gdtStruct.channels[i].rx_control_status[(int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_C_BAND].ip) + ":" + gdtStruct.channels[i].rx_control_status[(int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_C_BAND].port.ToString(),
                    Rx_UHF = getIPStringFromUint(gdtStruct.channels[i].rx_control_status[(int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_UHF].ip) + ":" + gdtStruct.channels[i].rx_control_status[(int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_UHF].port.ToString(),
                    Tx_CBand = getIPStringFromUint(gdtStruct.channels[i].tx_gdt[(int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_C_BAND].ip) + ":" + gdtStruct.channels[i].tx_gdt[(int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_C_BAND].port.ToString(),
                    Tx_UHF = getIPStringFromUint(gdtStruct.channels[i].tx_gdt[(int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_UHF].ip) + ":" + gdtStruct.channels[i].tx_gdt[(int)enumAPP_gdt_commType.APP_COMMON_GDT_COMM_TYPE_UHF].port.ToString(),
                    GDT_Rx_CBand  = "", //TODO: fill data from message
                    GDT_Rx_UHF  = "" //TODO: fill data from message
                });
            }

            // Clear empty rows
            for (uint i = gdtStruct.size; i < GDT_TABLE_SIZE; i++)
            {
                BL_GDTTable.Add(new GDTTable
                {
                    GdtId = "",
                    Rx_CBand = "",
                    Rx_UHF = "",
                    Tx_CBand = "",
                    Tx_UHF = "",
                    GDT_Rx_CBand = "", 
                    GDT_Rx_UHF = "" 
                });
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
