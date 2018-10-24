using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace RT_Viewer.Framework
{
    public class IRDModule : IModule
    {
        enum enumIRD_modem_kindType
        {
	        FLIGHT               = 0,  /* COM2-COM5  ??? */
            ATC                  = 1,   /* COM4-COM9  ??? */
            NONE					= 2
        } ;

        enum enumIRD_modem_stateType
        {
	            START             = 0,
                STBY                 ,
                INIT                 ,
                CONNECTED            ,
                CONNECTING
        } ;



        enum enumIRD_modem_init_substateType
        {
	        NONE                 = 0,
	        PRE_INIT                ,
            CMD_SEQ                 
        } ;

         enum enumIRD_telegram_type
        {
	        FLIGHT = 0,
	        ATC_UDP1,
	        ATC_UDP2,
	        ATC_RTP,
	        NONE
        } ;

         enum enumIRD_message_kind
        {
	        MODEM_MESSAGE,
	        UAV_TELEGRAM,
	        UNKNOWN
        } ;

         enum Bool
         {
             False = 0,
             True = 1
         }


         enum enumIRD_modem_response_kind
        {
	        INIT_SEQUENCE			= 0,
	        RECEPTION_QUALITY_REPORT = 1,
	        RING					= 2,
	        HANGUP					= 3,
	        CONNECT					= 4,
	        ACK						= 5,
	        NACK					= 6,
	        HARDWARE_FAILURE		= 7,
	        UNKNOWN					= 8
        } ;

         enum enumIRD_modem_command_kind
        {
	        NONE 	 					= 0,
	        ACCEPT_CALL 				= 1,
	        DENY_CALL					= 2,
	        INIT_COMBINED				= 3,
	        HANGUP_PART1 				= 4,
	        HANGUP_PART2 				= 5,
	        SIGNAL_QUALITY_REQUEST	    = 6,
	        LAST						= 7
        };

         enum enumIRD_ASP_response_kind
        {
	        ACCEPT_CALL = 0,
	        DENY_CALL,
	        NONE
        } ;


         public class IRDModemTable
        {
            public string tail_number { get; set; }
            public string modem_kind { get; set; }
            public string is_active { get; set; }
            public string modem_state { get; set; }
            public string modem_init_substate { get; set; }
            public string modem_init_done { get; set; }
            public string modem_last_message_kind { get; set; }
            public string modem_last_telegram_kind { get; set; }
            public string modem_last_respons { get; set; }
            public string modem_last_command { get; set; }
            public string modem_last_acked_command { get; set; }
            public string modem_reception_quality { get; set; }
            public string received_reception_quality { get; set; }
            public string modem_is_ready_to_connect { get; set; }
            public string last_aps_response_to_ring { get; set; }
        }

        public struct ModemStructEntry
        {
            public uint tail_number;
            public Int32 modem_kind; // enumIRD_modem_kindType
            public Int32 is_active;  // bool
            public Int32 modem_state; // enumIRD_modem_stateType
            public Int32 modem_init_substate; // enumIRD_modem_init_substateType
            public Int32 modem_init_done; // bool
            public uint modem_reception_quality;
            public Int32 received_reception_quality; // bool
            public Int32 modem_last_message_kind; // enumIRD_message_kind
            public Int32 modem_last_telegram_kind; // enumIRD_telegram_type
            public Int32 modem_last_respons; // enumIRD_modem_response_kind
            public Int32 modem_last_command; // enumIRD_modem_command_kind
            public Int32 modem_last_acked_command; // enumIRD_modem_command_kind
            public Int32 modem_is_ready_to_connect; // bool
            public Int32 last_aps_response_to_ring; // enumIRD_ASP_response_kind
            public uint connecting_state_counter;
            public uint preinit_substate_counter;
            public uint ring_inhibit_counter;
            public uint start_state_silence_counter;
            public uint send_reception_quality_request_counter;
            public uint moden_command_ack_counter;
            public uint modem_command_retry_counter;


        }
        public struct IRDStruct
        {
            public ModemStructEntry modemStructEntry0;
            public ModemStructEntry modemStructEntry1;
            public ModemStructEntry modemStructEntry2;
            public ModemStructEntry modemStructEntry3;
            public ModemStructEntry modemStructEntry4;
            public ModemStructEntry modemStructEntry5;
            public ModemStructEntry modemStructEntry6;
            public ModemStructEntry modemStructEntry7;
        }

        public IRDStruct irdStruct;
        public BindingList<IRDModemTable> BL_IRDModemTable;

        public IRDModule(SocketHandler.enumDevice_id deviceID)
        {
            irdStruct = new IRDStruct();
            deviceIdConnected = deviceID;   
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            try
            {
                int length;
                IntPtr ptr;
                length = Marshal.SizeOf(irdStruct);

                if (length +2 == size) // removed CRC ???
                {
                    ptr = Marshal.AllocHGlobal(length);
                    Marshal.Copy(msg, 0, ptr, length);
                    IRDStruct tempModemBlock = (IRDStruct)Marshal.PtrToStructure(ptr, irdStruct.GetType());
                    Marshal.FreeHGlobal(ptr);
                    BL_IRDModemTable = new BindingList<IRDModemTable>();

                    //while (true)
                    {

                        if (tempModemBlock.modemStructEntry0.is_active == 1)
                        {

                            BL_IRDModemTable.Add(new IRDModemTable
                            {
                                tail_number = tempModemBlock.modemStructEntry0.tail_number.ToString(),
                                modem_kind = intToEnumIRD_modem_kindType(tempModemBlock.modemStructEntry0.modem_kind),
                                is_active = intToEnumBool(tempModemBlock.modemStructEntry0.is_active),
                                modem_state = intToEnumIRD_modem_stateType(tempModemBlock.modemStructEntry0.modem_state),
                                modem_init_substate = intToEnumIRD_modem_init_substateType(tempModemBlock.modemStructEntry0.modem_init_substate),
                                modem_init_done = intToEnumBool(tempModemBlock.modemStructEntry0.modem_init_done),
                                modem_last_message_kind = intToEnumIRD_message_kind(tempModemBlock.modemStructEntry0.modem_last_message_kind),
                                modem_last_telegram_kind = intToEnumIRD_telegram_type(tempModemBlock.modemStructEntry0.modem_last_telegram_kind),
                                modem_last_respons = intToEnumIRD_modem_response_kind(tempModemBlock.modemStructEntry0.modem_last_respons),
                                modem_last_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry0.modem_last_command),
                                modem_last_acked_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry0.modem_last_acked_command),
                                modem_reception_quality = tempModemBlock.modemStructEntry0.modem_reception_quality.ToString(),
                                received_reception_quality = intToEnumBool(tempModemBlock.modemStructEntry0.received_reception_quality),
                                modem_is_ready_to_connect = intToEnumBool(tempModemBlock.modemStructEntry0.modem_is_ready_to_connect),
                                last_aps_response_to_ring = intToEnumIRD_ASP_response_kind(tempModemBlock.modemStructEntry0.last_aps_response_to_ring),

                            });
                        }

                        if (tempModemBlock.modemStructEntry1.is_active == 1)
                        {

                            BL_IRDModemTable.Add(new IRDModemTable
                            {
                                tail_number = tempModemBlock.modemStructEntry1.tail_number.ToString(),
                                modem_kind = intToEnumIRD_modem_kindType(tempModemBlock.modemStructEntry1.modem_kind),
                                is_active = intToEnumBool(tempModemBlock.modemStructEntry1.is_active),
                                modem_state = intToEnumIRD_modem_stateType(tempModemBlock.modemStructEntry1.modem_state),
                                modem_init_substate = intToEnumIRD_modem_init_substateType(tempModemBlock.modemStructEntry1.modem_init_substate),
                                modem_init_done = intToEnumBool(tempModemBlock.modemStructEntry1.modem_init_done),
                                modem_last_message_kind = intToEnumIRD_message_kind(tempModemBlock.modemStructEntry1.modem_last_message_kind),
                                modem_last_telegram_kind = intToEnumIRD_telegram_type(tempModemBlock.modemStructEntry1.modem_last_telegram_kind),
                                modem_last_respons = intToEnumIRD_modem_response_kind(tempModemBlock.modemStructEntry1.modem_last_respons),
                                modem_last_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry1.modem_last_command),
                                modem_last_acked_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry1.modem_last_acked_command),
                                modem_reception_quality = tempModemBlock.modemStructEntry1.modem_reception_quality.ToString(),
                                received_reception_quality = intToEnumBool(tempModemBlock.modemStructEntry1.received_reception_quality),
                                modem_is_ready_to_connect = intToEnumBool(tempModemBlock.modemStructEntry1.modem_is_ready_to_connect),
                                last_aps_response_to_ring = intToEnumIRD_ASP_response_kind(tempModemBlock.modemStructEntry1.last_aps_response_to_ring),

                            });
                        }

                        if (tempModemBlock.modemStructEntry2.is_active == 1)
                        {

                            BL_IRDModemTable.Add(new IRDModemTable
                            {
                                tail_number = tempModemBlock.modemStructEntry2.tail_number.ToString(),
                                modem_kind = intToEnumIRD_modem_kindType(tempModemBlock.modemStructEntry2.modem_kind),
                                is_active = intToEnumBool(tempModemBlock.modemStructEntry2.is_active),
                                modem_state = intToEnumIRD_modem_stateType(tempModemBlock.modemStructEntry2.modem_state),
                                modem_init_substate = intToEnumIRD_modem_init_substateType(tempModemBlock.modemStructEntry2.modem_init_substate),
                                modem_init_done = intToEnumBool(tempModemBlock.modemStructEntry2.modem_init_done),
                                modem_last_message_kind = intToEnumIRD_message_kind(tempModemBlock.modemStructEntry2.modem_last_message_kind),
                                modem_last_telegram_kind = intToEnumIRD_telegram_type(tempModemBlock.modemStructEntry2.modem_last_telegram_kind),
                                modem_last_respons = intToEnumIRD_modem_response_kind(tempModemBlock.modemStructEntry2.modem_last_respons),
                                modem_last_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry2.modem_last_command),
                                modem_last_acked_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry2.modem_last_acked_command),
                                modem_reception_quality = tempModemBlock.modemStructEntry2.modem_reception_quality.ToString(),
                                received_reception_quality = intToEnumBool(tempModemBlock.modemStructEntry2.received_reception_quality),
                                modem_is_ready_to_connect = intToEnumBool(tempModemBlock.modemStructEntry2.modem_is_ready_to_connect),
                                last_aps_response_to_ring = intToEnumIRD_ASP_response_kind(tempModemBlock.modemStructEntry2.last_aps_response_to_ring),

                            });
                        }

                        if (tempModemBlock.modemStructEntry3.is_active == 1)
                        {

                            BL_IRDModemTable.Add(new IRDModemTable
                            {
                                tail_number = tempModemBlock.modemStructEntry3.tail_number.ToString(),
                                modem_kind = intToEnumIRD_modem_kindType(tempModemBlock.modemStructEntry3.modem_kind),
                                is_active = intToEnumBool(tempModemBlock.modemStructEntry3.is_active),
                                modem_state = intToEnumIRD_modem_stateType(tempModemBlock.modemStructEntry3.modem_state),
                                modem_init_substate = intToEnumIRD_modem_init_substateType(tempModemBlock.modemStructEntry3.modem_init_substate),
                                modem_init_done = intToEnumBool(tempModemBlock.modemStructEntry3.modem_init_done),
                                modem_last_message_kind = intToEnumIRD_message_kind(tempModemBlock.modemStructEntry3.modem_last_message_kind),
                                modem_last_telegram_kind = intToEnumIRD_telegram_type(tempModemBlock.modemStructEntry3.modem_last_telegram_kind),
                                modem_last_respons = intToEnumIRD_modem_response_kind(tempModemBlock.modemStructEntry3.modem_last_respons),
                                modem_last_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry3.modem_last_command),
                                modem_last_acked_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry3.modem_last_acked_command),
                                modem_reception_quality = tempModemBlock.modemStructEntry3.modem_reception_quality.ToString(),
                                received_reception_quality = intToEnumBool(tempModemBlock.modemStructEntry3.received_reception_quality),
                                modem_is_ready_to_connect = intToEnumBool(tempModemBlock.modemStructEntry3.modem_is_ready_to_connect),
                                last_aps_response_to_ring = intToEnumIRD_ASP_response_kind(tempModemBlock.modemStructEntry3.last_aps_response_to_ring),

                            });
                        }

                        if (tempModemBlock.modemStructEntry4.is_active == 1)
                        {

                            BL_IRDModemTable.Add(new IRDModemTable
                            {
                                tail_number = tempModemBlock.modemStructEntry4.tail_number.ToString(),
                                modem_kind = intToEnumIRD_modem_kindType(tempModemBlock.modemStructEntry4.modem_kind),
                                is_active = intToEnumBool(tempModemBlock.modemStructEntry4.is_active),
                                modem_state = intToEnumIRD_modem_stateType(tempModemBlock.modemStructEntry4.modem_state),
                                modem_init_substate = intToEnumIRD_modem_init_substateType(tempModemBlock.modemStructEntry4.modem_init_substate),
                                modem_init_done = intToEnumBool(tempModemBlock.modemStructEntry4.modem_init_done),
                                modem_last_message_kind = intToEnumIRD_message_kind(tempModemBlock.modemStructEntry4.modem_last_message_kind),
                                modem_last_telegram_kind = intToEnumIRD_telegram_type(tempModemBlock.modemStructEntry4.modem_last_telegram_kind),
                                modem_last_respons = intToEnumIRD_modem_response_kind(tempModemBlock.modemStructEntry4.modem_last_respons),
                                modem_last_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry4.modem_last_command),
                                modem_last_acked_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry4.modem_last_acked_command),
                                modem_reception_quality = tempModemBlock.modemStructEntry4.modem_reception_quality.ToString(),
                                received_reception_quality = intToEnumBool(tempModemBlock.modemStructEntry4.received_reception_quality),
                                modem_is_ready_to_connect = intToEnumBool(tempModemBlock.modemStructEntry4.modem_is_ready_to_connect),
                                last_aps_response_to_ring = intToEnumIRD_ASP_response_kind(tempModemBlock.modemStructEntry4.last_aps_response_to_ring),

                            });
                        }

                        if (tempModemBlock.modemStructEntry5.is_active == 1)
                        {

                            BL_IRDModemTable.Add(new IRDModemTable
                            {
                                tail_number = tempModemBlock.modemStructEntry5.tail_number.ToString(),
                                modem_kind = intToEnumIRD_modem_kindType(tempModemBlock.modemStructEntry5.modem_kind),
                                is_active = intToEnumBool(tempModemBlock.modemStructEntry5.is_active),
                                modem_state = intToEnumIRD_modem_stateType(tempModemBlock.modemStructEntry5.modem_state),
                                modem_init_substate = intToEnumIRD_modem_init_substateType(tempModemBlock.modemStructEntry5.modem_init_substate),
                                modem_init_done = intToEnumBool(tempModemBlock.modemStructEntry5.modem_init_done),
                                modem_last_message_kind = intToEnumIRD_message_kind(tempModemBlock.modemStructEntry5.modem_last_message_kind),
                                modem_last_telegram_kind = intToEnumIRD_telegram_type(tempModemBlock.modemStructEntry5.modem_last_telegram_kind),
                                modem_last_respons = intToEnumIRD_modem_response_kind(tempModemBlock.modemStructEntry5.modem_last_respons),
                                modem_last_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry5.modem_last_command),
                                modem_last_acked_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry5.modem_last_acked_command),
                                modem_reception_quality = tempModemBlock.modemStructEntry5.modem_reception_quality.ToString(),
                                received_reception_quality = intToEnumBool(tempModemBlock.modemStructEntry5.received_reception_quality),
                                modem_is_ready_to_connect = intToEnumBool(tempModemBlock.modemStructEntry5.modem_is_ready_to_connect),
                                last_aps_response_to_ring = intToEnumIRD_ASP_response_kind(tempModemBlock.modemStructEntry5.last_aps_response_to_ring),

                            });
                        }

                        if (tempModemBlock.modemStructEntry6.is_active == 1)
                        {

                            BL_IRDModemTable.Add(new IRDModemTable
                            {
                                tail_number = tempModemBlock.modemStructEntry6.tail_number.ToString(),
                                modem_kind = intToEnumIRD_modem_kindType(tempModemBlock.modemStructEntry6.modem_kind),
                                is_active = intToEnumBool(tempModemBlock.modemStructEntry6.is_active),
                                modem_state = intToEnumIRD_modem_stateType(tempModemBlock.modemStructEntry6.modem_state),
                                modem_init_substate = intToEnumIRD_modem_init_substateType(tempModemBlock.modemStructEntry6.modem_init_substate),
                                modem_init_done = intToEnumBool(tempModemBlock.modemStructEntry6.modem_init_done),
                                modem_last_message_kind = intToEnumIRD_message_kind(tempModemBlock.modemStructEntry6.modem_last_message_kind),
                                modem_last_telegram_kind = intToEnumIRD_telegram_type(tempModemBlock.modemStructEntry6.modem_last_telegram_kind),
                                modem_last_respons = intToEnumIRD_modem_response_kind(tempModemBlock.modemStructEntry6.modem_last_respons),
                                modem_last_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry6.modem_last_command),
                                modem_last_acked_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry6.modem_last_acked_command),
                                modem_reception_quality = tempModemBlock.modemStructEntry6.modem_reception_quality.ToString(),
                                received_reception_quality = intToEnumBool(tempModemBlock.modemStructEntry6.received_reception_quality),
                                modem_is_ready_to_connect = intToEnumBool(tempModemBlock.modemStructEntry6.modem_is_ready_to_connect),
                                last_aps_response_to_ring = intToEnumIRD_ASP_response_kind(tempModemBlock.modemStructEntry6.last_aps_response_to_ring),

                            });
                        }

                        if (tempModemBlock.modemStructEntry7.is_active == 1)
                        {

                            BL_IRDModemTable.Add(new IRDModemTable
                            {
                                tail_number = tempModemBlock.modemStructEntry7.tail_number.ToString(),
                                modem_kind = intToEnumIRD_modem_kindType(tempModemBlock.modemStructEntry7.modem_kind),
                                is_active = intToEnumBool(tempModemBlock.modemStructEntry7.is_active),
                                modem_state = intToEnumIRD_modem_stateType(tempModemBlock.modemStructEntry7.modem_state),
                                modem_init_substate = intToEnumIRD_modem_init_substateType(tempModemBlock.modemStructEntry7.modem_init_substate),
                                modem_init_done = intToEnumBool(tempModemBlock.modemStructEntry7.modem_init_done),
                                modem_last_message_kind = intToEnumIRD_message_kind(tempModemBlock.modemStructEntry7.modem_last_message_kind),
                                modem_last_telegram_kind = intToEnumIRD_telegram_type(tempModemBlock.modemStructEntry7.modem_last_telegram_kind),
                                modem_last_respons = intToEnumIRD_modem_response_kind(tempModemBlock.modemStructEntry7.modem_last_respons),
                                modem_last_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry7.modem_last_command),
                                modem_last_acked_command = intToEnumIRD_modem_command_kind(tempModemBlock.modemStructEntry7.modem_last_acked_command),
                                modem_reception_quality = tempModemBlock.modemStructEntry7.modem_reception_quality.ToString(),
                                received_reception_quality = intToEnumBool(tempModemBlock.modemStructEntry7.received_reception_quality),
                                modem_is_ready_to_connect = intToEnumBool(tempModemBlock.modemStructEntry7.modem_is_ready_to_connect),
                                last_aps_response_to_ring = intToEnumIRD_ASP_response_kind(tempModemBlock.modemStructEntry7.last_aps_response_to_ring),

                            });
                        }



                    }
                }
            }
            catch (Exception e)
            {
            }

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));

            return true;
        }

        public string intToEnumIRD_modem_init_substateType(Int32 num)
        {

            if (enumIRD_modem_init_substateType.IsDefined(typeof(enumIRD_modem_init_substateType), num))
            {
                enumIRD_modem_init_substateType e = (enumIRD_modem_init_substateType)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }


        public string intToEnumIRD_modem_kindType(Int32 num)
        {

            if (enumIRD_modem_kindType.IsDefined(typeof(enumIRD_modem_kindType), num))
            {
                enumIRD_modem_kindType e = (enumIRD_modem_kindType)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }

        public string intToEnumIRD_modem_stateType(Int32 num)
        {

            if (enumIRD_modem_stateType.IsDefined(typeof(enumIRD_modem_stateType), num))
            {
                enumIRD_modem_stateType e = (enumIRD_modem_stateType)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }

        public string intToEnumBool(Int32 num)
        {

            if (Bool.IsDefined(typeof(Bool), num))
            {
                Bool e = (Bool)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }



        public string intToEnumIRD_message_kind(Int32 num)
        {

            if (enumIRD_message_kind.IsDefined(typeof(enumIRD_message_kind), num))
            {
                enumIRD_message_kind e = (enumIRD_message_kind)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }



        public string intToEnumIRD_telegram_type(Int32 num)
        {

            if (enumIRD_telegram_type.IsDefined(typeof(enumIRD_telegram_type), num))
            {
                enumIRD_telegram_type e = (enumIRD_telegram_type)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }

        public string intToEnumIRD_modem_response_kind(Int32 num)
        {

            if (enumIRD_modem_response_kind.IsDefined(typeof(enumIRD_modem_response_kind), num))
            {
                enumIRD_modem_response_kind e = (enumIRD_modem_response_kind)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }



        public string intToEnumIRD_modem_command_kind(Int32 num)
        {

            if (enumIRD_modem_command_kind.IsDefined(typeof(enumIRD_modem_command_kind), num))
            {
                enumIRD_modem_command_kind e = (enumIRD_modem_command_kind)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }

        public string intToEnumIRD_ASP_response_kind(Int32 num)
        {

            if (enumIRD_ASP_response_kind.IsDefined(typeof(enumIRD_ASP_response_kind), num))
            {
                enumIRD_ASP_response_kind e = (enumIRD_ASP_response_kind)num;
                return e.ToString() + " (" + num.ToString() + ")";
            }
            else
            {
                return num.ToString();
            }

        }


    }
}
