using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RT_Viewer.Framework
{
    public class HKYModule : IModule
    {
        enum enumHKY_LedType
        {
            ABORT = 0,
            ENGINE_CUT,
            LANDING,
            HOLD,
            BRAKES,
            LASER_ENABLE,
            PARACHUTE_RELEASE,
            HEADING_KNOB,
            MASTER_ALERT,
            MAX
        };

        enum enumHKY_KeysType
        {
            ABORT = 0,
            ENGINE_CUT,
            LANDING,
            HOLD,
            HEADING_KNOB,
            BRAKES_ON,
            BRAKES_OFF,
            LASER_ENABLE_ON,
            LASER_ENABLE_OFF,
            PARACHUTE_ENABLE,
            PARACHUTE_RELEASE,
            MASTER_ALERT,
            MAX
        };

        enum enumHKY_FunctionType
        {
           SINGLE = 0, /* Single HK . */
           SECURE,     /* Secure HK . */
           DOUBLE,     /* Double HK . */
           MAX
        };


        public struct LedTypeStruct
        {
            public uint mode;
            public uint state;
            public uint blink_cntr;
            public int icd;
        }
        public struct MsgTypeStruct
        {
            public uint state;
            public uint is_cont;
            public uint cntr;
        }
        public struct DiscrTypeStruct
        {
            public uint state;
            public int icd;
        }

        public struct KeyAttribTypeStruct
        {
            public int type;
            public DiscrTypeStruct[] discr;
            public int state;
            public MsgTypeStruct msg;
            public int hk_id;
        }

        public struct HKYTypeStruct
        {
            public KeyAttribTypeStruct[] hhky; // size 11
        }

        public struct HKYEntry
        {
            public HKYTypeStruct[] trans;
            public LedTypeStruct[] led;
            public uint console_num;
            public HKYHeadingKnobStruct HeadingData;
        }

        public struct HKYStruct
        {
            public uint num_of_console;
            public uint num_of_trans;
            public uint num_of_led;
            public uint num_of_key;
            public uint num_of_discr;
            public HKYEntry[] HKYConsole;
        }

        public struct HKYHeadingKnobStruct
        {
            public byte vendor_id1; 
            public byte vendor_id2; 
            public byte vendor_id3; 
            public byte vendor_id4; 
            public uint is_vendor;
            public byte position_buf1;
            public byte position_buf2;
            public byte position_buf3;
            public byte position_buf4;
            public uint calculated_crc; // received CRC
            public uint raw_position;
            public int  scaled_position;
            public uint cmd_state1;
            public uint cmd_state2;
            public uint isInitOK;
        }

        public HKYStruct hkyStruct;
        //public int[] currHeadingPosition;
        public HKYModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            hkyStruct = new HKYStruct();
            //currHeadingPosition = new int[2];
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int remainLength = (int)size;
            int indexReader = 0;
            int length;
            IntPtr ptr;

            hkyStruct.num_of_console = (uint)BitConverter.ToUInt32(msg, indexReader);
            indexReader += 4;
            hkyStruct.num_of_trans = (uint)BitConverter.ToUInt32(msg, indexReader);
            indexReader += 4;
            hkyStruct.num_of_led = (uint)BitConverter.ToUInt32(msg, indexReader);
            indexReader += 4;
            hkyStruct.num_of_key = (uint)BitConverter.ToUInt32(msg, indexReader);
            indexReader += 4;
            hkyStruct.num_of_discr = (uint)BitConverter.ToUInt32(msg, indexReader);
            indexReader += 4;
            hkyStruct.HKYConsole = new HKYEntry[hkyStruct.num_of_console];
            // loop over all console
            for (int i = 0; i < hkyStruct.num_of_console; i++)
            {
                hkyStruct.HKYConsole[i].trans = new HKYTypeStruct[hkyStruct.num_of_trans];
                // loop over all trans
                for (int j = 0; j < hkyStruct.num_of_trans; j++)
                {
                    hkyStruct.HKYConsole[i].trans[j].hhky = new KeyAttribTypeStruct[hkyStruct.num_of_key];
                    // loop over all hhky
                    for (int k = 0; k < hkyStruct.num_of_key; k++)
                    {
                        //read key type
                        hkyStruct.HKYConsole[i].trans[j].hhky[k].type = (int)BitConverter.ToInt32(msg, indexReader);
                        indexReader += 4;

                        hkyStruct.HKYConsole[i].trans[j].hhky[k].discr = new DiscrTypeStruct[hkyStruct.num_of_discr];
                        // loop over all Discrete States
                        for (int t = 0; t < hkyStruct.num_of_discr; t++)
                        {
                            hkyStruct.HKYConsole[i].trans[j].hhky[k].discr[t].state = (uint)BitConverter.ToUInt32(msg, indexReader);
                            indexReader += 4;
                            hkyStruct.HKYConsole[i].trans[j].hhky[k].discr[t].icd = (int)BitConverter.ToInt32(msg, indexReader);
                            indexReader += 4;
                        }
                        hkyStruct.HKYConsole[i].trans[j].hhky[k].state = (int)BitConverter.ToInt32(msg, indexReader);
                        indexReader += 4;
                        hkyStruct.HKYConsole[i].trans[j].hhky[k].msg.state = (uint)BitConverter.ToUInt32(msg, indexReader);
                        indexReader += 4;
                        hkyStruct.HKYConsole[i].trans[j].hhky[k].msg.is_cont = (uint)BitConverter.ToUInt32(msg, indexReader);
                        indexReader += 4;
                        hkyStruct.HKYConsole[i].trans[j].hhky[k].msg.cntr = (uint)BitConverter.ToUInt32(msg, indexReader);
                        indexReader += 4;
                        hkyStruct.HKYConsole[i].trans[j].hhky[k].hk_id = (int)BitConverter.ToInt32(msg, indexReader);
                        indexReader += 4;
                    }
                }

                hkyStruct.HKYConsole[i].led = new LedTypeStruct[hkyStruct.num_of_led];
                // loop over all leds
                for (int j = 0; j < hkyStruct.num_of_led; j++)
                {
                    hkyStruct.HKYConsole[i].led[j].mode = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                    hkyStruct.HKYConsole[i].led[j].state = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                    hkyStruct.HKYConsole[i].led[j].blink_cntr = (uint)BitConverter.ToUInt32(msg, indexReader);
                    indexReader += 4;
                    hkyStruct.HKYConsole[i].led[j].icd = (int)BitConverter.ToInt32(msg, indexReader);
                    indexReader += 4;
                }

                // Console Number .
                hkyStruct.HKYConsole[i].console_num = (uint)BitConverter.ToUInt32(msg, indexReader);
                indexReader += 4;

                // Heading Knob .
                hkyStruct.HKYConsole[i].HeadingData = new HKYHeadingKnobStruct();

                length = Marshal.SizeOf(hkyStruct.HKYConsole[i].HeadingData);
                ptr = Marshal.AllocHGlobal(length);
                Marshal.Copy(msg, indexReader, ptr, length);
                hkyStruct.HKYConsole[i].HeadingData = (HKYHeadingKnobStruct)Marshal.PtrToStructure(ptr, hkyStruct.HKYConsole[i].HeadingData.GetType());
                Marshal.FreeHGlobal(ptr);
                indexReader += length;
             }

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }

        public string ledIntToEnum(int num)
        {

            if (enumHKY_LedType.IsDefined(typeof(enumHKY_LedType), num))
            {
                enumHKY_LedType e = (enumHKY_LedType)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }

        public string keysIntToEnum(int num)
        {

            if (enumHKY_KeysType.IsDefined(typeof(enumHKY_KeysType), num))
            {
                enumHKY_KeysType e = (enumHKY_KeysType)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }


        public string functionIntToEnum(int num)
        {

            if (enumHKY_FunctionType.IsDefined(typeof(enumHKY_FunctionType), num))
            {
                enumHKY_FunctionType e = (enumHKY_FunctionType)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }
    }
}
