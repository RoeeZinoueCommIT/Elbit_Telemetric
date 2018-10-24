using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace RT_Viewer.Framework
{
    public class MGCModule : IModule
    {

        public class HSTGruConfTableDB
        {
            public string ATOL_ID { get; set; }
            public string UAV_ID { get; set; }
        }

        public class MGCIPConfigurationTableDB
        {
            public string gruId { get; set; }
            public string state { get; set; }
            public string tailNumberAttached { get; set; }
            public string apsRTCH { get; set; }
            public string rtGRUCH { get; set; }
            public string GRURegularCH { get; set; }
            public string GRUFastCH { get; set; }

        }

        public enum ATOL_STATE
        {
            IDLE = 0,
            GRU_SELECT = 1,
            UAV_ATTACHED = 2,
        }
        public enum GRU_NUMBER
        {
            GRU1 = 0,
            GRU2 = 1,
            GRU3 = 2,
            GRU4 = 3,
            GRU5 = 4,
        }

        public struct HSTGruConfTableStruct
        {
            public uint atol_id_1;
            public uint tail_number_1;
            public uint atol_id_2;
            public uint tail_number_2;
            public uint atol_id_3;
            public uint tail_number_3;
            public uint atol_id_4;
            public uint tail_number_4;
            public uint atol_id_5;
            public uint tail_number_5;
        }

        public struct MGCInfoTableEntry
        {
            public uint atol_id;
            public uint uav_tail;
            public uint state;
            public uint is_alive;
            public uint tick_no_respones; 
        }

        public struct MGCInfoTable
        {
            public MGCInfoTableEntry[] infoTableEntry;
            public uint ReceivedCntrMsg;
        }


        public struct MGCSocketConfigurationStruct
        {
            public uint socket;
            public int received_port;
            public int transmit_port;
            public int ip;
            public uint atol_id;
            public uint is_configure;

        }
        public struct MGCIPConfDb
        {
            public MGCSocketConfigurationStruct[] apsRtCmdConfCh;
            public MGCSocketConfigurationStruct[] rtGruCmdConfCh;
            public MGCSocketConfigurationStruct[] gruRtRegularCh;
            public MGCSocketConfigurationStruct[] gruRtFastCh;
        }

        public struct MGCStruct
        {
            public HSTGruConfTableStruct hstGruConfTable;
            public MGCInfoTable infoTable;
            public MGCIPConfDb ipConfDb;
        }

        public const uint MAX_NUM_OF_GRU = 5;
        public MGCStruct mgcStruct;
        public BindingList<HSTGruConfTableDB> BL_HSTGruConfTable;
        public BindingList<MGCIPConfigurationTableDB> BL_MGCGru1ConfTable;
        public BindingList<MGCIPConfigurationTableDB> BL_MGCGru2ConfTable;
        public BindingList<MGCIPConfigurationTableDB> BL_MGCGru3ConfTable;
        public BindingList<MGCIPConfigurationTableDB> BL_MGCGru4ConfTable;
        public BindingList<MGCIPConfigurationTableDB> BL_MGCGru5ConfTable;

        public MGCModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            mgcStruct = new MGCStruct();
            
            for(int i=0;i<MAX_NUM_OF_GRU;i++)
            {
                mgcStruct.infoTable = new MGCInfoTable();
                mgcStruct.infoTable.infoTableEntry = new MGCInfoTableEntry[MAX_NUM_OF_GRU];
                mgcStruct.infoTable.infoTableEntry[i] = new MGCInfoTableEntry();
                mgcStruct.ipConfDb.apsRtCmdConfCh = new MGCSocketConfigurationStruct[MAX_NUM_OF_GRU];
                mgcStruct.ipConfDb.rtGruCmdConfCh = new MGCSocketConfigurationStruct[MAX_NUM_OF_GRU];
                mgcStruct.ipConfDb.gruRtRegularCh = new MGCSocketConfigurationStruct[MAX_NUM_OF_GRU];
                mgcStruct.ipConfDb.gruRtFastCh = new MGCSocketConfigurationStruct[MAX_NUM_OF_GRU];
            }
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int remainLength = (int)size;
            int indexReader = 0;
            int length;
            IntPtr ptr;

            BL_MGCGru1ConfTable = new BindingList<MGCIPConfigurationTableDB>();
            BL_MGCGru2ConfTable = new BindingList<MGCIPConfigurationTableDB>();
            BL_MGCGru3ConfTable = new BindingList<MGCIPConfigurationTableDB>();
            BL_MGCGru4ConfTable = new BindingList<MGCIPConfigurationTableDB>();
            BL_MGCGru5ConfTable = new BindingList<MGCIPConfigurationTableDB>();

            /*Get unicon gruConfMsg*/
            length = Marshal.SizeOf(mgcStruct.hstGruConfTable);
            ptr = Marshal.AllocHGlobal(length);
            Marshal.Copy(msg, indexReader, ptr, length);
            mgcStruct.hstGruConfTable = (HSTGruConfTableStruct)Marshal.PtrToStructure(ptr, mgcStruct.hstGruConfTable.GetType());
            Marshal.FreeHGlobal(ptr);
            indexReader += length;
            remainLength = remainLength - length;

            BL_HSTGruConfTable = new BindingList<HSTGruConfTableDB>();
            BL_HSTGruConfTable.Add(new HSTGruConfTableDB
            {
                ATOL_ID = mgcStruct.hstGruConfTable.atol_id_1.ToString(), 
                UAV_ID = mgcStruct.hstGruConfTable.tail_number_1.ToString(), 
            });
            BL_HSTGruConfTable.Add(new HSTGruConfTableDB
            {
                ATOL_ID = mgcStruct.hstGruConfTable.atol_id_2.ToString(),
                UAV_ID = mgcStruct.hstGruConfTable.tail_number_2.ToString(),
            });
            BL_HSTGruConfTable.Add(new HSTGruConfTableDB
            {
                ATOL_ID = mgcStruct.hstGruConfTable.atol_id_3.ToString(),
                UAV_ID = mgcStruct.hstGruConfTable.tail_number_3.ToString(),
            });
            BL_HSTGruConfTable.Add(new HSTGruConfTableDB
            {
                ATOL_ID = mgcStruct.hstGruConfTable.atol_id_4.ToString(),
                UAV_ID = mgcStruct.hstGruConfTable.tail_number_4.ToString(),
            });
            BL_HSTGruConfTable.Add(new HSTGruConfTableDB
            {
                ATOL_ID = mgcStruct.hstGruConfTable.atol_id_5.ToString(),
                UAV_ID = mgcStruct.hstGruConfTable.tail_number_5.ToString(),
            });

            /*Get MGC info table*/
            for (int i = 0; i < MAX_NUM_OF_GRU; i++)
            {
              
                mgcStruct.infoTable.infoTableEntry[i].atol_id = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.infoTable.infoTableEntry[i].uav_tail = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.infoTable.infoTableEntry[i].state = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.infoTable.infoTableEntry[i].is_alive = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.infoTable.infoTableEntry[i].tick_no_respones = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
            }
            /* Get hst msg cntr*/
            mgcStruct.infoTable.ReceivedCntrMsg = (uint)BitConverter.ToUInt32(msg, indexReader);
            indexReader += 4;

            /*Get MGC IP Conf table*/
            for (int i = 0; i < MAX_NUM_OF_GRU; i++)
            {
                //ApsRtCmdConfCh
                mgcStruct.ipConfDb.apsRtCmdConfCh[i].socket = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.apsRtCmdConfCh[i].received_port = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.apsRtCmdConfCh[i].transmit_port = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.apsRtCmdConfCh[i].ip = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.apsRtCmdConfCh[i].atol_id = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.apsRtCmdConfCh[i].is_configure = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
            }
            for (int i = 0; i < MAX_NUM_OF_GRU; i++)
            {

                //rtGruCmdConfCh
                mgcStruct.ipConfDb.rtGruCmdConfCh[i].socket = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.rtGruCmdConfCh[i].received_port = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.rtGruCmdConfCh[i].transmit_port = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.rtGruCmdConfCh[i].ip = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.rtGruCmdConfCh[i].atol_id = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.rtGruCmdConfCh[i].is_configure = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
            }
            for (int i = 0; i < MAX_NUM_OF_GRU; i++)
            {
                //gruRtRegularCh
                mgcStruct.ipConfDb.gruRtRegularCh[i].socket = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtRegularCh[i].received_port = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtRegularCh[i].transmit_port = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtRegularCh[i].ip = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtRegularCh[i].atol_id = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtRegularCh[i].is_configure = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
            }
            for (int i = 0; i < MAX_NUM_OF_GRU; i++)
            {
                //gruRtFastCh
                mgcStruct.ipConfDb.gruRtFastCh[i].socket = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtFastCh[i].received_port = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtFastCh[i].transmit_port = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtFastCh[i].ip = (int)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtFastCh[i].atol_id = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
                mgcStruct.ipConfDb.gruRtFastCh[i].is_configure = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;
            }
            for (int i = 0; i < MAX_NUM_OF_GRU; i++)
            {
                string apsRTStatus = " (Close)";
                string rtGRUStatus = " (Close)";
                string gruRegularStatus = " (Close)";
                string gruFastStatus = " (Close)";

                if (mgcStruct.ipConfDb.apsRtCmdConfCh[i].socket > 0)
                {
                    apsRTStatus = " (Open)";
                }
                if (mgcStruct.ipConfDb.rtGruCmdConfCh[i].socket > 0)
                {
                    rtGRUStatus = " (Open)";
                }
                if (mgcStruct.ipConfDb.gruRtRegularCh[i].socket > 0)
                {
                    gruRegularStatus = " (Open)";
                }
                if (mgcStruct.ipConfDb.gruRtFastCh[i].socket > 0)
                {
                    gruFastStatus = " (Open)";
                }

                switch (i)
                {
                    case (int)GRU_NUMBER.GRU1:
                        BL_MGCGru1ConfTable.Add(new MGCIPConfigurationTableDB
                        {
                            gruId = mgcStruct.infoTable.infoTableEntry[i] .atol_id.ToString(),
                            state = intToEnum((int)mgcStruct.infoTable.infoTableEntry[i] .state),
                            tailNumberAttached = mgcStruct.infoTable.infoTableEntry[i].uav_tail.ToString(),
                            apsRTCH = getIPStringFromUint(mgcStruct.ipConfDb.apsRtCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.apsRtCmdConfCh[i].received_port.ToString() + apsRTStatus,
                            rtGRUCH = getIPStringFromUint(mgcStruct.ipConfDb.rtGruCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.rtGruCmdConfCh[i].transmit_port.ToString() + rtGRUStatus,
                            GRURegularCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtRegularCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtRegularCh[i].received_port.ToString() + gruRegularStatus,
                            GRUFastCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtFastCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtFastCh[i].received_port.ToString() + gruFastStatus
                        });
                        break;
                        
                    case (int)GRU_NUMBER.GRU2:
                        BL_MGCGru2ConfTable.Add(new MGCIPConfigurationTableDB
                        {
                            gruId = mgcStruct.infoTable.infoTableEntry[i].atol_id.ToString(),
                            state = intToEnum((int)mgcStruct.infoTable.infoTableEntry[i].state),
                            tailNumberAttached = mgcStruct.infoTable.infoTableEntry[i].uav_tail.ToString(),
                            apsRTCH = getIPStringFromUint(mgcStruct.ipConfDb.apsRtCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.apsRtCmdConfCh[i].received_port.ToString() + apsRTStatus,
                            rtGRUCH = getIPStringFromUint(mgcStruct.ipConfDb.rtGruCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.rtGruCmdConfCh[i].transmit_port.ToString() + rtGRUStatus,
                            GRURegularCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtRegularCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtRegularCh[i].received_port.ToString() + gruRegularStatus,
                            GRUFastCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtFastCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtFastCh[i].received_port.ToString() + gruFastStatus
                        });
                        break;
                    case (int)GRU_NUMBER.GRU3:
                        BL_MGCGru3ConfTable.Add(new MGCIPConfigurationTableDB
                        {
                            gruId = mgcStruct.infoTable.infoTableEntry[i].atol_id.ToString(),
                            state = intToEnum((int)mgcStruct.infoTable.infoTableEntry[i].state),
                            tailNumberAttached = mgcStruct.infoTable.infoTableEntry[i].uav_tail.ToString(),
                            apsRTCH = getIPStringFromUint(mgcStruct.ipConfDb.apsRtCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.apsRtCmdConfCh[i].received_port.ToString() + apsRTStatus,
                            rtGRUCH = getIPStringFromUint(mgcStruct.ipConfDb.rtGruCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.rtGruCmdConfCh[i].transmit_port.ToString() + rtGRUStatus,
                            GRURegularCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtRegularCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtRegularCh[i].received_port.ToString() + gruRegularStatus,
                            GRUFastCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtFastCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtFastCh[i].received_port.ToString() + gruFastStatus
                        });
                        break;
                    case (int)GRU_NUMBER.GRU4:
                        BL_MGCGru4ConfTable.Add(new MGCIPConfigurationTableDB
                        {
                            gruId = mgcStruct.infoTable.infoTableEntry[i].atol_id.ToString(),
                            state = intToEnum((int)mgcStruct.infoTable.infoTableEntry[i].state),
                            tailNumberAttached = mgcStruct.infoTable.infoTableEntry[i].uav_tail.ToString(),
                            apsRTCH = getIPStringFromUint(mgcStruct.ipConfDb.apsRtCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.apsRtCmdConfCh[i].received_port.ToString() + apsRTStatus,
                            rtGRUCH = getIPStringFromUint(mgcStruct.ipConfDb.rtGruCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.rtGruCmdConfCh[i].transmit_port.ToString() + rtGRUStatus,
                            GRURegularCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtRegularCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtRegularCh[i].received_port.ToString() + gruRegularStatus,
                            GRUFastCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtFastCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtFastCh[i].received_port.ToString() + gruFastStatus
                        });
                        break;
                    case (int)GRU_NUMBER.GRU5:
                        BL_MGCGru5ConfTable.Add(new MGCIPConfigurationTableDB
                        {
                            gruId = mgcStruct.infoTable.infoTableEntry[i].atol_id.ToString(),
                            state = intToEnum((int)mgcStruct.infoTable.infoTableEntry[i].state),
                            tailNumberAttached = mgcStruct.infoTable.infoTableEntry[i].uav_tail.ToString(),
                            apsRTCH = getIPStringFromUint(mgcStruct.ipConfDb.apsRtCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.apsRtCmdConfCh[i].received_port.ToString() + apsRTStatus,
                            rtGRUCH = getIPStringFromUint(mgcStruct.ipConfDb.rtGruCmdConfCh[i].ip) + ":" + mgcStruct.ipConfDb.rtGruCmdConfCh[i].transmit_port.ToString() + rtGRUStatus,
                            GRURegularCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtRegularCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtRegularCh[i].received_port.ToString() + gruRegularStatus,
                            GRUFastCH = getIPStringFromUint(mgcStruct.ipConfDb.gruRtFastCh[i].ip) + ":" + mgcStruct.ipConfDb.gruRtFastCh[i].received_port.ToString() + gruFastStatus
                        });
                        break;
                }
            }

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }

        public string intToEnum(int num)
        {

            if (ATOL_STATE.IsDefined(typeof(ATOL_STATE), num))
            {
                ATOL_STATE e = (ATOL_STATE)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }

        public string getIPStringFromUint(int ip)
        {
            string result = BitConverter.GetBytes(ip)[0] + "." + BitConverter.GetBytes(ip)[1] + "." + BitConverter.GetBytes(ip)[2] + "." + BitConverter.GetBytes(ip)[3];
            return result;
        }
    }
}
