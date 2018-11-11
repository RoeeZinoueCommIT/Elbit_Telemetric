using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace RT_Viewer.Framework
{
    public class FRMModule : IModule
    {
        /* Note: For new FRM Module */
        enum Fault_type_enum
        {
            BIT_NO_FAULT = 0,
            CPU_A_TO_B=3,
            FLASH=5,
            MONITOR=8,
            TIME_PROBLEM_MAIN_TASK=126,
            WATCHDOG=127,
            TIME_PROBLEM_LOG_TASK = 128,
            TIME_PROBLEM_VTU_TASK = 129,
            TIME_PROBLEM_PFD_TASK = 130,
            VMSC_CONFIG_FILE=1012,
            VMSC_NVM_READ=1013,
            VMSC_NVM_WRITE=1014,
            VMSC_SRAM_READ =1015,
            VMSC_SRAM_WRITE=1016,
            VMSC_MON_CPU_A=1017,
            VMSC_MON_CPU_B=1018,
            VMSC_CPU_RESET=1022,
            VMSC_DISCRETE_CMD=1023,
            VMSC_ANALOGS_CALIB = 1025,
            VMSC_REC_WRITE_FAIL=1058,
            VMSC_REC_ERASE_FAIL=1059,
            INIT_SOCKET=3000,
            RTC_HST_KEEP_ALIVE_ERROR,
            RIGHT_STICK_CABLE,
            RIGHT_STICK_RHS_CABLE,
            RIGHT_STICK_LHG_CABLE,
            RIGHT_STICK_A_D,
            RIGHT_STICK_CRC_ERROR,
            RIGHT_STICK_DISCONNECTED,
            LEFT_STICK_CABLE,
            LEFT_STICK_RHS_CABLE,
            LEFT_STICK_LHG_CABLE,
            LEFT_STICK_A_D,
            LEFT_STICK_CRC_ERROR,
            LEFT_STICK_DISCONNECTED,
            NO_DTM_FOR_CALCULATION,
            NO_COMM_PFD,
            PFD_CBIT_ERROR,
            GRU_INIT_ERROR,
            DTM_DATA_ERROR,
            JEPPESEN_UPLOAD_FAIL,
            FCV_OUT_OF_MEMORY,
            RTC_HST_SOCKET_ERROR
        }

        public class FRMTable
        {
            public string MFL_ID_number { get; set; }
            public string Fault_currently_exists { get; set; }
            public string Total_No_of_appearances { get; set; }
            public string First_appearance_VMSC_cycle_No { get; set; }
            public string First_appearance_time_in_msec { get; set; }
            public string First_disappearance_VMSC_cycle_No { get; set; }
            public string First_disappearance_time_in_msec { get; set; }
            public string spare { get; set; }
        }

        public class PFLTable
        {
            public string PFL_ID_number { get; set; }
            public string PFL_LABEL { get; set; }

        }

        public struct FRMRecordStruct
        {
            public UInt16 MFL_ID_number;
            public char Fault_currently_exists;
            public uint Total_No_of_appearances;
            public uint First_appearance_VMSC_cycle_No;
            public uint First_appearance_time_in_msec;
            public uint First_disappearance_VMSC_cycle_No;
            public uint First_disappearance_time_in_msec;
            public char spare;

        }
        public struct PFLRecordStruct
        {
            public uint MFL_ID_number;
            public string PFL_LABEL;
        }
        public struct FRMStruct
        {
           public uint maxFRMFaults;
           public uint currentFRMFaultExistReported;
           public FRMRecordStruct[] FRMRecordEntry;
           public uint maxPFLFaults;
           public uint currentPFLFaultExistReported;
           public ushort[] PFLFaultArray;
        }


        //Members
        public FRMStruct frmDB;

        public BindingList<FRMTable> BL_FRMTable;
        public BindingList<PFLTable> BL_PFLTable;

        public FRMModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            frmDB = new FRMStruct();
            
        }


        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int remainLength = (int)size;
            int indexReader = 0;

            frmDB.maxFRMFaults = (uint)BitConverter.ToInt32(msg, 0);
            indexReader += 4;
            frmDB.currentFRMFaultExistReported = (uint)BitConverter.ToInt32(msg, 4);
            indexReader += 4;
            frmDB.FRMRecordEntry = new FRMRecordStruct[frmDB.maxFRMFaults];
            BL_FRMTable = new BindingList<FRMTable>();
            for (int i = 0; i < frmDB.maxFRMFaults; i++)
            {
                frmDB.FRMRecordEntry[i].MFL_ID_number = (UInt16)BitConverter.ToUInt16(msg, indexReader); // 2
                frmDB.FRMRecordEntry[i].Fault_currently_exists = (char)msg[indexReader+2]; //1
                frmDB.FRMRecordEntry[i].Total_No_of_appearances = (uint)BitConverter.ToUInt32(msg, indexReader + 3); //4
                frmDB.FRMRecordEntry[i].First_appearance_VMSC_cycle_No = (uint)BitConverter.ToUInt32(msg, indexReader + 7); //4
                frmDB.FRMRecordEntry[i].First_appearance_time_in_msec = (uint)BitConverter.ToUInt32(msg, indexReader + 11); //4
                frmDB.FRMRecordEntry[i].First_disappearance_VMSC_cycle_No = (uint)BitConverter.ToUInt32(msg, indexReader + 15); //4
                frmDB.FRMRecordEntry[i].First_disappearance_time_in_msec = (uint)BitConverter.ToUInt32(msg, indexReader + 19); //4
                frmDB.FRMRecordEntry[i].spare = (char)msg[indexReader + 21]; //1
                indexReader += 24;
                string isActive = "YES";
                if (frmDB.FRMRecordEntry[i].Fault_currently_exists == 1)
                {
                    isActive = "YES";
                }
                else
                {
                    isActive = "NO";
                }

                if (frmDB.FRMRecordEntry[i].Fault_currently_exists == 1)
                {
                    BL_FRMTable.Add(new FRMTable
                    {
                        MFL_ID_number = intToEnum(frmDB.FRMRecordEntry[i].MFL_ID_number),
                        Fault_currently_exists = isActive,
                        Total_No_of_appearances = frmDB.FRMRecordEntry[i].Total_No_of_appearances.ToString(),
                        First_appearance_VMSC_cycle_No = frmDB.FRMRecordEntry[i].First_appearance_VMSC_cycle_No.ToString(),
                        First_appearance_time_in_msec = frmDB.FRMRecordEntry[i].First_appearance_time_in_msec.ToString(),
                        First_disappearance_VMSC_cycle_No = frmDB.FRMRecordEntry[i].First_disappearance_VMSC_cycle_No.ToString(),
                        First_disappearance_time_in_msec = frmDB.FRMRecordEntry[i].First_disappearance_time_in_msec.ToString(),
                        spare = Convert.ToByte(frmDB.FRMRecordEntry[i].spare).ToString()
                    });
                }
            }

            /* Recevied PFL Faults*/
            BL_PFLTable = new BindingList<PFLTable>();
            frmDB.maxPFLFaults = (uint)BitConverter.ToInt32(msg, indexReader);
            indexReader += 4;
            frmDB.currentPFLFaultExistReported = (uint)BitConverter.ToInt32(msg, indexReader);
            indexReader += 4;
            frmDB.PFLFaultArray = new ushort[frmDB.maxPFLFaults];

            for (int i = 0; i < frmDB.maxPFLFaults; i++)
            {
                frmDB.PFLFaultArray[i] = (UInt16)BitConverter.ToUInt16(msg, indexReader); // 2
                indexReader += 2;
                if (frmDB.PFLFaultArray[i] != 0)
                {
                    BL_PFLTable.Add(new PFLTable
                    {
                        PFL_ID_number = frmDB.PFLFaultArray[i].ToString(),
                        PFL_LABEL = "TBD PFL Label"
                    });
                }
            }
            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }

        public string intToEnum(int num)
        {
            
            if (Fault_type_enum.IsDefined(typeof(Fault_type_enum), num))
            {
                Fault_type_enum e = (Fault_type_enum)num;
                return e.ToString() + " (" + num.ToString() +")";
            }
            else
            {
                return num.ToString();
            }
            
        }
    }
}
