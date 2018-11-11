using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RT_Viewer.Framework
{
    public class OffllineParamsModule: IModule
    {

        public const int C_NVM_COMM_TYPE_UPL_MAX = 10;
        public const int C_NVM_IP_ADDR_ARR_SIZE = 4;
        public const int C_NVM_EXTRA_VAR_MAX = 20;
        public const int C_NVM_UDP_MGC_MAX_PORTS = 5;
        public const int C_NVM_GDT_TABLE_SIZE = 15;

        public struct DT_NVM_configFileVer_type
        {
            public int ver;  /* Configuration File Structure Version . */
            public int type; /* Configuration File Structure Type . */
        }

        public struct DT_NVM_configFileGdtPrm_type
        {
            public int cband_port;                                      /* C-Band Port . */
            public int cband_ip_format1;                                /* C-Band IP address . */
            public int cband_ip_format2;                                /* C-Band IP address . */
            public int cband_ip_format3;                                /* C-Band IP address . */
            public int cband_ip_format4;                                /* C-Band IP address . */
            public int uhf_port;                                        /* UHF Port . */
            public int uhf_ip_format1;                                  /* UHF IP address . */
            public int uhf_ip_format2;                                  /* UHF IP address . */
            public int uhf_ip_format3;                                    /* UHF IP address . */
            public int uhf_ip_format4;                                 /* UHF IP address . */
        }

        public struct DT_NVM_configFileGdtSet_type
        {
            public int site_id;
            public int gdt_id;
        }
        
        public struct OfflineStruct
        {
            /* ------------------------------------------------------------- */
            /* V e r s i o n   P a r a m e t e r s .                         */
            /* ------------------------------------------------------------- */
            public DT_NVM_configFileVer_type version;            /* Version Structure of Configuration File . */
            /* ------------------------------------------------------------- */
            /* D a t a   P a m e t e r s .                                   */
            /* ------------------------------------------------------------- */
            public int    monitor_ka;                               /* Frequancy of KA between RTC and internal monitor . */
            public int    udp_rtc_c_and_s_port;                     /* RTC UDP port of Control and status between APS and RTC . */
            public int    udp_aps_rtc1_c_and_s_port;                /* APS UDP port of Control and Status from RTC1 . */
            public int    udp_aps_rtc2_c_and_s_port;                /* APS UDP port of Control and Status from RTC2 . */
            public int    udp_max_retries;                          /* C&S session retries before BIT failure is raised . */
            public int    rtc_ka_freq;                              /* Frequancy of app. KA messages from RTC . */
            public int    aps_ka_freq;                              /* Frequancy of app. KA messages from APS . */
            public int    rtc_ka_timeout;                           /* RTC timeout to close connection . */
            public int    aps_ka_timeout;                           /* APS timeout to close connection . */
            public int    uplink_aps_rtc_1;                         /* APS udp port for A-G thru RTC1 . */
            public int    uplink_aps_rtc_2;                         /* APS udp port for A-G thru RTC2 . */
            public int    uplink_rtc;                               /* RTC udp port for incoming A-G from APS . */
            public int    comm_type_number1;                        /* Uplink ID's of communication types to UAV . */
            public int    comm_type_number2;                  
            public int    comm_type_number3;                  
            public int    comm_type_number4;                  
            public int    comm_type_number5;                  
            public int    comm_type_number6;                  
            public int    comm_type_number7;                  
            public int    comm_type_number8;                  
            public int    comm_type_number9;                  
            public int    comm_type_number10;                 
            public int    uav_uplink_port;                          /* UDP port for A-G messages to UAV . */
            public int    uav_downlink_port;                        /* UDP port for A-G messages from UAV . */
            public int    cband_upl_ip_format1;                     /* C-Band Uplink IP address . */
            public int    cband_upl_ip_format2;                      
            public int    cband_upl_ip_format3;                      
            public int    cband_upl_ip_format4;                      
            public int    uhf_upl_ip_format1;                        /* UHF Uplink IP address . */
            public int    uhf_upl_ip_format2;                         
            public int    uhf_upl_ip_format3;                  
            public int    uhf_upl_ip_format4; 
            public int    satcom_upl_vms1_format1;                   /* SATCOM VMS1 Uplink IP address . */
            public int    satcom_upl_vms1_format2;
            public int    satcom_upl_vms1_format3;
            public int    satcom_upl_vms1_format4;
            public int    satcom_upl_vms2_format1;                   /* SATCOM VMS2 Uplink IP address . */
            public int    satcom_upl_vms2_format2;
            public int    satcom_upl_vms2_format3;
            public int    satcom_upl_vms2_format4;
            public int    iridium_upl_ip_format1;                    /* Iridium Uplink IP address . */
            public int    iridium_upl_ip_format2;
            public int    iridium_upl_ip_format3;
            public int    iridium_upl_ip_format4;          
            public int    mobilicom_upl_ip_format1;                  /* Mobilicom Uplink IP address . */
            public int    mobilicom_upl_ip_format2;
            public int    mobilicom_upl_ip_format3;
            public int    mobilicom_upl_ip_format4; 
            public int    spare1_upl_ip_format1;                     /* Spare1 Uplink IP address . */
            public int    spare1_upl_ip_format2;
            public int    spare1_upl_ip_format3;
            public int    spare1_upl_ip_format4;  
            public int    spare2_upl_ip_format1;                     /* Spare2 Uplink IP address . */
            public int    spare2_upl_ip_format2;
            public int    spare2_upl_ip_format3;
            public int    spare2_upl_ip_format4;
            public int    spare3_upl_ip_format1;                     /* Spare3 Uplink IP address . */
            public int    spare3_upl_ip_format2;
            public int    spare3_upl_ip_format3;
            public int    spare3_upl_ip_format4; 
            public int    spare4_upl_ip_format1;                     /* Spare4 Uplink IP address . */
            public int    spare4_upl_ip_format2;
            public int    spare4_upl_ip_format3;
            public int    spare4_upl_ip_format4; 
            public int    cband_dnl_ip_format1;                      /* C-Band Downlink IP address . */
            public int    cband_dnl_ip_format2;
            public int    cband_dnl_ip_format3;
            public int    cband_dnl_ip_format4;
            public int    uhf_dnl_ip_format1;                        /* UHF Downlink IP address . */
            public int    uhf_dnl_ip_format2;
            public int    uhf_dnl_ip_format3;
            public int    uhf_dnl_ip_format4;
            public int    satcom_dnl_ip_format1;                     /* SATCOM Downlink IP address . */
            public int    satcom_dnl_ip_format2;
            public int    satcom_dnl_ip_format3;
            public int    satcom_dnl_ip_format4;

            
            public int    iridium_dnl_ip_format1;                   /* IRIDIUM Downlink IP address . */
            public int    iridium_dnl_ip_format2;
            public int    iridium_dnl_ip_format3;
            public int    iridium_dnl_ip_format4;
            public int	  iridium_dnl_mcst_ttl;							 /* IRIDIUM dnl mcst TTL . */
            public int    gvs_ip_format1;                               /* GVS IP address for Iridium. */
            public int    gvs_ip_format2;
            public int    gvs_ip_format3;
            public int    gvs_ip_format4;
            public int    gvs_udp1_port;                                   /* GVS UDP1 port for Iridium . */
            public int    gvs_udp2_port;                                   /* GVS UDP2 port for Iridium . */
            public int    gvs_rtp_port;                                    /* GVS RTP port for Iridium . */

            
            
            public int    ntp_server_ip_address1;                    /* IP address of NTP server in GCS . */
            public int    ntp_server_ip_address2;
            public int    ntp_server_ip_address3;
            public int    ntp_server_ip_address4;
            public int    ntp_sync_period;                          /* Frequancy for NTP time syncronization . */
            public int    rt_number;                                /* Number of RT . */
            public uint   vehicle_type;                             /* Vehicle Type (UAV / USV) . */
            public int    rtc_continues_hk_freq;                    /* Frequency of A-G message from RTC to UAV when HK is pressed . */
            public int    aps_continues_hk_freq;                    /* Frequency of KeyPress message from RTC to APS when HK is pressed . */
            public int    hk_blink_freq;                            /* Frequency of LED blink in Hz . */

            public int    rtc_uav_primary_ka_timeout_param;                /* Primary UAV KA Timeout for C-BAND messages from RTC . */
            public int    rtc_uav_secondary_ka_timeout_param;              /* Primary UAV KA Timeout for UHF messages from RTC . */
            public int    rtc_uav_satcom_ka_timeout_param;                 /* Primary UAV KA Timeout for SATCOM messages from RTC . */
            public int    rtc_uav_iridium_ka_timeout_param;                /* Primary UAV KA Timeout for IRIDIUM messages from RTC . */

            
            public int    cbit_freq;                                /* Frequancy of C-BIT messages from RTC in seconds . */
            public int    log_ip_adress1;                           /* RTCLogger Multicast IP address[0] . */
            public int    log_ip_adress2;                           /* RTCLogger Multicast IP address[1] . */
            public int    log_ip_adress3;                           /* RTCLogger Multicast IP address[2] . */
            public int    log_ip_adress4;                           /* RTCLogger Multicast IP address[3] . */
            public int    log_side_a_tx_port;                       /* RTCLogger Side A Tx Port .*/
            public int    log_side_b_tx_port;                       /* RTCLogger Side B Tx Port .*/
            public int    pfd_left_ip_adress1;                      /* PFD Left IP address[0] . */
            public int    pfd_left_ip_adress2;                      /* PFD Left IP address[1] . */
            public int    pfd_left_ip_adress3;                      /* PFD Left IP address[2] . */
            public int    pfd_left_ip_adress4;                      /* PFD Left IP address[3] . */
            public int    pfd_left_tx_port;                         /* PFD Left Tx Port .*/
            public int    pfd_left_rx_port;                         /* PFD Left Rx Port .*/
            public int    pfd_right_ip_adress1;                     /* PFD Right IP address[0] . */
            public int    pfd_right_ip_adress2;                     /* PFD Right IP address[1] . */
            public int    pfd_right_ip_adress3;                     /* PFD Right IP address[2] . */
            public int    pfd_right_ip_adress4;                     /* PFD Right IP address[3] . */
            public int    pfd_right_tx_port;                        /* PFD Right Tx Port .*/
            public int    pfd_right_rx_port;                        /* PFD Right Rx Port .*/
            public int    pfd_remove_uav_failure;                   /* PFD Remove UAV Failure . */
            public int    vtu_multicast_ip1;                        /*  VTU Multicast Tx IP address[0] .*/
            public int    vtu_multicast_ip2;                        /*  VTU Multicast Tx IP address[1] .*/
            public int    vtu_multicast_ip3;                        /*  VTU Multicast Tx IP address[2] .*/
            public int    vtu_multicast_ip4;                        /*  VTU Multicast Tx IP address[3] .*/
            public int    vtu_side_a_tx_port;                       /* VTU Side A Tx Port . */
            public int    vtu_side_a_rx_port;                       /* VTU Side A Rx Port . */
            public int    vtu_side_b_tx_port;                       /* VTU Side B Tx Port . */
            public int    vtu_side_b_rx_port;                       /* VTU Side B Rx Port . */
            public int    running_mode;                             /* Running Mode (0 = Operation / 1 = Debug) .*/
            public int    gcs_id;                                   /* GCS ID Number . */
            public int    fcv_validator;                            /* FCV Validator Flag . */

            public int    rtc_link_status_timer;                            /* RTC Link Status Timer Value in Seconds . */
            public int    rtc_remove_uplink_timer;                          /* RTC Remove Uplink Timer Maximum Value in Seconds . */

            public int    rtc_no_downlink_timer_exceeded;                   /* RTC No Downlink Timer Exceeded Value in Seconds . */
            public int    uav_distance_from_gdt;                            /* UAV Distance from GDT . */
            public int	  heading_knob_state_timer;						    /* Timer in ms to waiting DNL M2201 upon send Upl M2101 */
            public int	  atol_id1;			 		                        /* ATOL_ID MOB 22 state (0 = Inactive/ 1 = Active) . */
            public int	  atol_id2;                                         /* ATOL_ID MOB 04 state (0 = Inactive/ 1 = Active) . */
            public int	  atol_id3;                                         /* ATOL_ID ALT 01 state (0 = Inactive/ 1 = Active) . */
            public int	  atol_id4;                                         /* ATOL_ID ALT 02 state (0 = Inactive/ 1 = Active) . */
            public int	  atol_id5;                                         /* ATOL_ID ALT 03 state (0 = Inactive/ 1 = Active) . */

            public int mgc_rx_regular_port1;    /* Magic Rx Regular Ports 1. */
            public int mgc_rx_regular_port2;    /* Magic Rx Regular Ports 2. */
            public int mgc_rx_regular_port3;    /* Magic Rx Regular Ports 3. */
            public int mgc_rx_regular_port4;    /* Magic Rx Regular Ports 4. */
            public int mgc_rx_regular_port5;    /* Magic Rx Regular Ports 5. */

            public int mgc_rx_fast_port1;       /* Magic Rx Fast Ports 1. */
            public int mgc_rx_fast_port2;       /* Magic Rx Fast Ports 2. */
            public int mgc_rx_fast_port3;       /* Magic Rx Fast Ports 3. */
            public int mgc_rx_fast_port4;       /* Magic Rx Fast Ports 4. */
            public int mgc_rx_fast_port5;       /* Magic Rx Fast Ports 5. */

            public int mgc_uni_src_ip1;                        /*  Magic Unicast Rx IP Source address[0]. */
            public int mgc_uni_src_ip2;                        /*  Magic Unicast Rx IP Source address[1] .*/
            public int mgc_uni_src_ip3;                        /*  Magic Unicast Rx IP Source address[2] .*/
            public int mgc_uni_src_ip4;                        /*  Magic Unicast Rx IP Source address[3] .*/


            public int tail_list1;                                       /*Tail List 1*/
            public int tail_list2;                                       /*Tail List 2*/
            public int tail_list3;                                       /*Tail List 3*/
            public int tail_list4;                                       /*Tail List 4*/
            public int tail_list5;                                       /*Tail List 5*/
            public int tail_list6;                                       /*Tail List 6*/
            public int tail_list7;                                       /*Tail List 7*/
            public int tail_list8;                                       /*Tail List 8*/
            public int tail_list9;                                       /*Tail List 9*/
            public int tail_list10;                                      /*Tail List 10*/

            public DT_NVM_configFileGdtPrm_type gdt_rx_cs_channel;                               /* GDT Rx Control & Status Channel Parameters . */
            public DT_NVM_configFileGdtPrm_type gdt_rx_channel;                                  /* GDT Rx Channel Parameters . */
            public DT_NVM_configFileGdtPrm_type gdt_tx_channel;                                  /* GDT Tx Channel Parameters . */
            public DT_NVM_configFileGdtSet_type gdt_table1;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table2;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table3;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table4;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table5;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table6;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table7;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table8;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table9;                                      /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table10;                                     /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table11;                                     /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table12;                                     /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table13;                                     /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table14;                                     /* Unique GDT Table (site_id, gdt_id} . */
            public DT_NVM_configFileGdtSet_type gdt_table15;                                     /* Unique GDT Table (site_id, gdt_id} . */ 


           /* ------------------------------------------------------------- */
           /* I R D   config data                                           */
           /* ------------------------------------------------------------- */
           public int                        ird_cmd_retries;                                 /* Iridium Command Retries . */
           public int                        ird_cmd_delay_timeout;                           /* Iridium Command Delay Timeout . */
           public int                        ird_signal_qual_timeout;                         /* Iridium Signal Quality Timeout . */
           public int                        ird_connect_delay_timeout;                       /* Iridium Connect Delay Timeout . */
           public int                        ird_replace_char;                                /* Iridium Replace Character . */
           public int                        ird_unknown_signal_quality;                      /* Iridium Unknown Signal Quality . */
           public int                        ird_start_state_listen_timeout;                  /* Iridium Start State Listen Timeout . */
           public int                        ird_ring_inhibit_timeout;                        /* Iridium Ring Inhibit Timeout . */
           public int                        ird_modem_config;                                /* Iridium Modem Config . */
           public int                        ird_init_sequence1;                              /* Iridium Init Sequence . */
           public int                        ird_init_sequence2;
           public int                        ird_init_sequence3;
           public int                        ird_init_sequence4;
           public int                        ird_init_sequence5;
           public int                        ird_init_sequence6;
           public int ird_init_sequence7;
           public int ird_init_sequence8;
           public int ird_init_sequence9;
           public int ird_init_sequence10;
           public int ird_init_sequence11;                              
           public int ird_init_sequence12;
           public int ird_init_sequence13;
           public int ird_init_sequence14;
           public int ird_init_sequence15;
           public int ird_init_sequence16;
           public int ird_init_sequence17;
           public int ird_init_sequence18;
           public int ird_init_sequence19;
           public int ird_init_sequence20;
           public int ird_init_sequence21;                              
           public int ird_init_sequence22;

            
            
            
            /* ------------------------------------------------------------- */
            /* E x t r a   D a t a   P a r a m e t e r s .                   */
            /* ------------------------------------------------------------- */
            public Int64  extra1;                                   /* Extra Variable for Future Use . */
            public Int64 extra2;                                   /* Extra Variable for Future Use . */
            public int extra3;
            /* ------------------------------------------------------------- */
        }

        public OfflineStruct offlineStruct;
        public bool isFirstTime = true;
        public bool isRTConfigurationArrived = false;

        public DataTable OfflineDataTable;
        public DataGridViewTextBoxColumn valueColumn;
        public DataGridViewTextBoxColumn descriptionColumn;



        public OffllineParamsModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            offlineStruct = new OfflineStruct();

            OfflineDataTable = new DataTable();

            OfflineDataTable.Columns.Add("Description", typeof(String));
            OfflineDataTable.Columns.Add("Value", typeof(String));

            valueColumn = new DataGridViewTextBoxColumn();
            valueColumn.HeaderText = "Value";
            valueColumn.DataPropertyName = "Value";
            valueColumn.ReadOnly = true;
            valueColumn.FillWeight = 70;
            valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.ReadOnly = true;
            descriptionColumn.FillWeight = 100;
            descriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

        }
        public string offlineParamsContent;
      

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int length;
            IntPtr ptr;
            if (isFirstTime)
            {
                isFirstTime = false;
                length = Marshal.SizeOf(offlineStruct);
                ptr = Marshal.AllocHGlobal(length);
                Marshal.Copy(msg, 0, ptr, length);
                offlineStruct = (OfflineStruct)Marshal.PtrToStructure(ptr, offlineStruct.GetType());
                Marshal.FreeHGlobal(ptr);

                OfflineDataTable.Rows.Clear();

                OfflineDataTable.Rows.Add(new object[] {"Configuration File Structure Version", offlineStruct.version.ver.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Configuration File Structure Type", offlineStruct.version.type.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"Frequancy of KA between RTC and internal monitor ", offlineStruct.monitor_ka.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"RTC UDP port of Control and status between APS and RTC ", offlineStruct.udp_rtc_c_and_s_port.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"APS UDP port of Control and Status from RTC1", offlineStruct.udp_aps_rtc1_c_and_s_port.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"APS UDP port of Control and Status from RTC2", offlineStruct.udp_aps_rtc2_c_and_s_port.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"C&S session retries before BIT failure is raised", offlineStruct.udp_max_retries.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Frequancy of app. KA messages from RTC", offlineStruct.rtc_ka_freq.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Frequancy of app. KA messages from APS", offlineStruct.aps_ka_freq.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"RTC timeout to close connection", offlineStruct.rtc_ka_timeout.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"APS timeout to close connection", offlineStruct.aps_ka_timeout.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"APS udp port for A-G thru RTC1", offlineStruct.uplink_aps_rtc_1.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"APS udp port for A-G thru RTC2", offlineStruct.uplink_aps_rtc_2.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"RTC udp port for incoming A-G from APS", offlineStruct.uplink_rtc.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of C-Band communication type to UAV", offlineStruct.comm_type_number1.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of UHF communication type to UAV", offlineStruct.comm_type_number2.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of Satcom VMS1 communication type to UAV", offlineStruct.comm_type_number3.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of Satcom VMS2 communication type to UAV", offlineStruct.comm_type_number4.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of Iridium communication type to UAV", offlineStruct.comm_type_number5.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of Mobilicom communication type to UAV", offlineStruct.comm_type_number6.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of Spare 1 communication type to UAV", offlineStruct.comm_type_number7.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of Spare 2 communication type to UAV", offlineStruct.comm_type_number8.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of Spare 3 communication type to UAV", offlineStruct.comm_type_number9.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Uplink ID of Spare 4 communication type to UAV", offlineStruct.comm_type_number10.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"UDP port for A-G messages to UAV", offlineStruct.uav_uplink_port.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"UDP port for A-G messages from UAV", offlineStruct.uav_downlink_port.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"C-Band Uplink IP address", offlineStruct.cband_upl_ip_format1.ToString() + "." + offlineStruct.cband_upl_ip_format2.ToString() +
                                                                                    "." + offlineStruct.cband_upl_ip_format3.ToString() + "." + offlineStruct.cband_upl_ip_format4.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"UHF Uplink IP address", offlineStruct.uhf_upl_ip_format1.ToString() + "." + offlineStruct.uhf_upl_ip_format2.ToString() +
                                                                                   "." + offlineStruct.uhf_upl_ip_format3.ToString() + "." + offlineStruct.uhf_upl_ip_format4.ToString()});
                
                OfflineDataTable.Rows.Add(new object[] {"SATCOM VMS1 Uplink IP address", offlineStruct.satcom_upl_vms1_format1.ToString() + "." + offlineStruct.satcom_upl_vms1_format2.ToString() +
                                                                                       "." + offlineStruct.satcom_upl_vms1_format3.ToString() + "." + offlineStruct.satcom_upl_vms1_format4.ToString()});
                                                        
                OfflineDataTable.Rows.Add(new object[] {"SATCOM VMS2 Uplink IP address", offlineStruct.satcom_upl_vms2_format1.ToString() + "." + offlineStruct.satcom_upl_vms2_format2.ToString() +
                                                                                       "." + offlineStruct.satcom_upl_vms2_format3.ToString() + "." + offlineStruct.satcom_upl_vms2_format4.ToString()});
                                                        
                                                        
                OfflineDataTable.Rows.Add(new object[] {"Iridium Uplink IP address", offlineStruct.iridium_upl_ip_format1.ToString() + "." + offlineStruct.iridium_upl_ip_format2.ToString() +
                                                                                      "." + offlineStruct.iridium_upl_ip_format3.ToString() + "." + offlineStruct.iridium_upl_ip_format4.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"Mobilicom Uplink IP address", offlineStruct.mobilicom_upl_ip_format1.ToString() + "." + offlineStruct.mobilicom_upl_ip_format2.ToString() +
                                                                                        "." + offlineStruct.mobilicom_upl_ip_format3.ToString() + "." + offlineStruct.mobilicom_upl_ip_format4.ToString()});
               
                OfflineDataTable.Rows.Add(new object[] {"Spare 1 Uplink IP address", offlineStruct.spare1_upl_ip_format1.ToString() + "." + offlineStruct.spare1_upl_ip_format2.ToString() +
                                                                                     "." + offlineStruct.spare3_upl_ip_format1.ToString() + "." + offlineStruct.spare1_upl_ip_format4.ToString()});
               
                OfflineDataTable.Rows.Add(new object[] {"Spare 2 Uplink IP address", offlineStruct.spare2_upl_ip_format1.ToString() + "." + offlineStruct.spare2_upl_ip_format2.ToString() +
                                                                                       "." + offlineStruct.spare2_upl_ip_format3.ToString() + "." + offlineStruct.spare2_upl_ip_format4.ToString()});
               
                OfflineDataTable.Rows.Add(new object[] {"Spare 3 Uplink IP address", offlineStruct.spare3_upl_ip_format1.ToString() + "." + offlineStruct.spare3_upl_ip_format2.ToString() +
                                                                                      "." + offlineStruct.spare3_upl_ip_format3.ToString() + "." + offlineStruct.spare3_upl_ip_format4.ToString()});
               
                OfflineDataTable.Rows.Add(new object[] {"Spare 4 Uplink IP address", offlineStruct.spare4_upl_ip_format1.ToString() + "." + offlineStruct.spare4_upl_ip_format2.ToString() +
                                                                                    "." + offlineStruct.spare4_upl_ip_format3.ToString() + "." + offlineStruct.spare4_upl_ip_format4.ToString()});
                
                OfflineDataTable.Rows.Add(new object[] {"C-Band Downlink IP address", offlineStruct.cband_dnl_ip_format1.ToString() + "." + offlineStruct.cband_dnl_ip_format2.ToString() +
                                                                                     "." + offlineStruct.cband_dnl_ip_format3.ToString() + "." + offlineStruct.cband_dnl_ip_format4.ToString()});
                
                OfflineDataTable.Rows.Add(new object[] {"UHF Downlink IP address", offlineStruct.uhf_dnl_ip_format1.ToString() + "." + offlineStruct.uhf_dnl_ip_format2.ToString() +
                                                                                   "." + offlineStruct.uhf_dnl_ip_format3.ToString() + "." + offlineStruct.uhf_dnl_ip_format4.ToString()});
                
                OfflineDataTable.Rows.Add(new object[] {"SATCOM Downlink IP address", offlineStruct.satcom_dnl_ip_format1.ToString() + "." + offlineStruct.satcom_dnl_ip_format2.ToString() +
                                                                                      "." + offlineStruct.satcom_dnl_ip_format3.ToString() + "." + offlineStruct.satcom_dnl_ip_format4.ToString()});
                
                OfflineDataTable.Rows.Add(new object[] {"IRIDIUM Downlink IP address", offlineStruct.iridium_dnl_ip_format1.ToString() + "." + offlineStruct.iridium_dnl_ip_format2.ToString() +
                                                                                      "." + offlineStruct.iridium_dnl_ip_format3.ToString() + "." + offlineStruct.iridium_dnl_ip_format4.ToString()});
                
                OfflineDataTable.Rows.Add(new object[] {"IRIDIUM dnl mcst TTL", offlineStruct.iridium_dnl_mcst_ttl.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"GVS IP address for Iridium", offlineStruct.gvs_ip_format1.ToString() + "." + offlineStruct.gvs_ip_format2.ToString() +
                                                                                      "." + offlineStruct.gvs_ip_format3.ToString() + "." + offlineStruct.gvs_ip_format4.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"GVS UDP1 port for Iridium", offlineStruct.gvs_udp1_port.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"GVS UDP2 port for Iridium", offlineStruct.gvs_udp2_port.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"GVS RTP port for Iridium", offlineStruct.gvs_rtp_port.ToString()});



                OfflineDataTable.Rows.Add(new object[] {"IP address of NTP server in GCS", offlineStruct.ntp_server_ip_address1.ToString() + "." + offlineStruct.ntp_server_ip_address2.ToString() +
                                                                                          "." + offlineStruct.ntp_server_ip_address3.ToString() + "." + offlineStruct.ntp_server_ip_address4.ToString()});
                                                            
                                                            
                OfflineDataTable.Rows.Add(new object[] {"Frequancy for NTP time syncronization", offlineStruct.ntp_sync_period.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Number of RT", offlineStruct.rt_number.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Vehicle Type (UAV / USV)", offlineStruct.vehicle_type.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Frequency of A-G message from RTC to UAV when HK is pressed", offlineStruct.rtc_continues_hk_freq.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Frequency of KeyPress message from RTC to APS when HK is pressed", offlineStruct.aps_continues_hk_freq.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Frequency of LED blink in Hz", offlineStruct.hk_blink_freq.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"Primary UAV KA Timeout for C-BAND messages from RTC", offlineStruct.rtc_uav_primary_ka_timeout_param.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Primary UAV KA Timeout for UHF messages from RTC", offlineStruct.rtc_uav_secondary_ka_timeout_param.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Primary UAV KA Timeout for SATCOM messages from RTC", offlineStruct.rtc_uav_satcom_ka_timeout_param.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"Primary UAV KA Timeout for IRIDIUM messages from RTC", offlineStruct.rtc_uav_iridium_ka_timeout_param.ToString()});


                OfflineDataTable.Rows.Add(new object[] {"Frequancy of C-BIT messages from RTC in seconds", offlineStruct.cbit_freq.ToString() });

                OfflineDataTable.Rows.Add(new object[] {"LOG Multicast Tx IP address", offlineStruct.log_ip_adress1.ToString() + "." + offlineStruct.log_ip_adress2.ToString() +
                                                                                          "." + offlineStruct.log_ip_adress3.ToString() + "." + offlineStruct.log_ip_adress4.ToString()});
                OfflineDataTable.Rows.Add(new object[] {"LOG Side A Tx Port", offlineStruct.log_side_a_tx_port.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"LOG Side B Tx Port", offlineStruct.log_side_b_tx_port.ToString() });

                
                OfflineDataTable.Rows.Add(new object[] {"IP address of Left PFD", offlineStruct.pfd_left_ip_adress1.ToString() + "." + offlineStruct.pfd_left_ip_adress2.ToString() +
                                                                                          "." + offlineStruct.pfd_left_ip_adress3.ToString() + "." + offlineStruct.pfd_left_ip_adress4.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"PFD Left Tx Port", offlineStruct.pfd_left_tx_port.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"PFD Left Rx Port", offlineStruct.pfd_left_rx_port.ToString() });

                OfflineDataTable.Rows.Add(new object[] {"IP address of Right PFD", offlineStruct.pfd_right_ip_adress1.ToString() + "." + offlineStruct.pfd_right_ip_adress2.ToString() +
                                                                                          "." + offlineStruct.pfd_right_ip_adress3.ToString() + "." + offlineStruct.pfd_right_ip_adress4.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"PFD Right Tx Port", offlineStruct.pfd_right_tx_port.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"PFD Right Rx Port", offlineStruct.pfd_right_rx_port.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"PFD Remove UAV Failure", offlineStruct.pfd_remove_uav_failure.ToString() });
                
                OfflineDataTable.Rows.Add(new object[] {"VTU Multicast Tx IP address", offlineStruct.vtu_multicast_ip1.ToString() + "." + offlineStruct.vtu_multicast_ip2.ToString() +
                                                                                     "." + offlineStruct.vtu_multicast_ip3.ToString() + "." + offlineStruct.vtu_multicast_ip4.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"VTU Side A Tx Port", offlineStruct.vtu_side_a_tx_port.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"VTU Side A Rx Port", offlineStruct.vtu_side_a_rx_port.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"VTU Side B Tx Port", offlineStruct.vtu_side_b_tx_port.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"VTU Side B Rx Port", offlineStruct.vtu_side_b_rx_port.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Running Mode (0 = Operation / 1 = Debug)", offlineStruct.running_mode.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"GCS ID", offlineStruct.gcs_id.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"FCV Validator Flag", offlineStruct.fcv_validator.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"RTC Link Status Timer Value in Seconds", offlineStruct.rtc_link_status_timer.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"RTC Remove Uplink Timer Maximum Value in Seconds", offlineStruct.rtc_remove_uplink_timer.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"RTC No Downlink Timer Exceeded Value in Seconds", offlineStruct.rtc_no_downlink_timer_exceeded.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"UAV Distance from GDT .", offlineStruct.uav_distance_from_gdt.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Timer in ms to waiting DNL M2201 upon send Upl M2101", offlineStruct.heading_knob_state_timer.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"ATOL_ID MOB 22 state (0 = Inactive/ 1 = Active)", offlineStruct.atol_id1.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"ATOL_ID MOB 04 state (0 = Inactive/ 1 = Active)", offlineStruct.atol_id2.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"ATOL_ID ALT 01 state (0 = Inactive/ 1 = Active)", offlineStruct.atol_id3.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"ATOL_ID ALT 02 state (0 = Inactive/ 1 = Active)", offlineStruct.atol_id4.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"ATOL_ID ALT 03 state (0 = Inactive/ 1 = Active)", offlineStruct.atol_id5.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Regular Ports 1", offlineStruct.mgc_rx_regular_port1.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Regular Ports 2", offlineStruct.mgc_rx_regular_port2.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Regular Ports 3", offlineStruct.mgc_rx_regular_port3.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Regular Ports 4", offlineStruct.mgc_rx_regular_port4.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Regular Ports 5", offlineStruct.mgc_rx_regular_port5.ToString() });

                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Fast Ports 1", offlineStruct.mgc_rx_fast_port1.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Fast Ports 2", offlineStruct.mgc_rx_fast_port2.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Fast Ports 3", offlineStruct.mgc_rx_fast_port3.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Fast Ports 4", offlineStruct.mgc_rx_fast_port4.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Magic Rx Fast Ports 5", offlineStruct.mgc_rx_fast_port5.ToString() });

                OfflineDataTable.Rows.Add(new object[] {"Magic Unicast Rx IP Source address", offlineStruct.mgc_uni_src_ip1.ToString() + "." + offlineStruct.mgc_uni_src_ip2.ToString() +
                                                                                          "." + offlineStruct.mgc_uni_src_ip3.ToString() + "." + offlineStruct.mgc_uni_src_ip4.ToString()});

                OfflineDataTable.Rows.Add(new object[] { "Tail List 1", offlineStruct.tail_list1.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 2", offlineStruct.tail_list2.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 3", offlineStruct.tail_list3.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 4", offlineStruct.tail_list4.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 5", offlineStruct.tail_list5.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 6", offlineStruct.tail_list6.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 7", offlineStruct.tail_list7.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 8", offlineStruct.tail_list8.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 9", offlineStruct.tail_list9.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Tail List 10", offlineStruct.tail_list10.ToString() });

                OfflineDataTable.Rows.Add(new object[] {"GDT Rx Control & Status Channel Parameters",
                    "CBAND: " + offlineStruct.gdt_rx_cs_channel.cband_ip_format1.ToString() + "." + offlineStruct.gdt_rx_cs_channel.cband_ip_format2.ToString() + "." + offlineStruct.gdt_rx_cs_channel.cband_ip_format3.ToString() + "." + offlineStruct.gdt_rx_cs_channel.cband_ip_format4.ToString() + ":" + offlineStruct.gdt_rx_cs_channel.cband_port.ToString() +
                    " UHF: " + offlineStruct.gdt_rx_cs_channel.uhf_ip_format1.ToString() + "." + offlineStruct.gdt_rx_cs_channel.uhf_ip_format2.ToString() + "." + offlineStruct.gdt_rx_cs_channel.uhf_ip_format3.ToString() + "." + offlineStruct.gdt_rx_cs_channel.uhf_ip_format4.ToString() + ":" + offlineStruct.gdt_rx_cs_channel.uhf_port.ToString()});
                
                OfflineDataTable.Rows.Add(new object[] {"GDT Rx Channel Parameters",
                    "CBAND: " + offlineStruct.gdt_rx_channel.cband_ip_format1.ToString() + "." + offlineStruct.gdt_rx_channel.cband_ip_format2.ToString() + "." + offlineStruct.gdt_rx_channel.cband_ip_format3.ToString() + "." + offlineStruct.gdt_rx_channel.cband_ip_format4.ToString() + ":" + offlineStruct.gdt_rx_channel.cband_port.ToString() +
                    " UHF: " + offlineStruct.gdt_rx_channel.uhf_ip_format1.ToString() + "." + offlineStruct.gdt_rx_channel.uhf_ip_format2.ToString() + "." + offlineStruct.gdt_rx_channel.uhf_ip_format3.ToString() + "." + offlineStruct.gdt_rx_channel.uhf_ip_format4.ToString() + ":" + offlineStruct.gdt_rx_channel.uhf_port.ToString()});

                OfflineDataTable.Rows.Add(new object[] {"GDT Tx Channel Parameters",
                    "CBAND: " + offlineStruct.gdt_tx_channel.cband_ip_format1.ToString() + "." + offlineStruct.gdt_tx_channel.cband_ip_format2.ToString() + "." + offlineStruct.gdt_tx_channel.cband_ip_format3.ToString() + "." + offlineStruct.gdt_tx_channel.cband_ip_format4.ToString() + ":" + offlineStruct.gdt_tx_channel.cband_port.ToString() +
                    " UHF: " + offlineStruct.gdt_tx_channel.uhf_ip_format1.ToString() + "." + offlineStruct.gdt_tx_channel.uhf_ip_format2.ToString() + "." + offlineStruct.gdt_tx_channel.uhf_ip_format3.ToString() + "." + offlineStruct.gdt_tx_channel.uhf_ip_format4.ToString() + ":" + offlineStruct.gdt_tx_channel.uhf_port.ToString()});


                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 1 (site_id, gdt_id}", "(" + offlineStruct.gdt_table1.site_id.ToString() + ", " + offlineStruct.gdt_table1.gdt_id.ToString() + ")"});
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 2 (site_id, gdt_id}", "(" + offlineStruct.gdt_table2.site_id.ToString() + ", " + offlineStruct.gdt_table2.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 3 (site_id, gdt_id}", "(" + offlineStruct.gdt_table3.site_id.ToString() + ", " + offlineStruct.gdt_table3.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 4 (site_id, gdt_id}", "(" + offlineStruct.gdt_table4.site_id.ToString() + ", " + offlineStruct.gdt_table4.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 5 (site_id, gdt_id}", "(" + offlineStruct.gdt_table5.site_id.ToString() + ", " + offlineStruct.gdt_table5.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 6 (site_id, gdt_id}", "(" + offlineStruct.gdt_table6.site_id.ToString() + ", " + offlineStruct.gdt_table6.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 7 (site_id, gdt_id}", "(" + offlineStruct.gdt_table7.site_id.ToString() + ", " + offlineStruct.gdt_table7.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 8 (site_id, gdt_id}", "(" + offlineStruct.gdt_table8.site_id.ToString() + ", " + offlineStruct.gdt_table8.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 9 (site_id, gdt_id}", "(" + offlineStruct.gdt_table9.site_id.ToString() + ", " + offlineStruct.gdt_table9.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 10 (site_id, gdt_id}", "(" + offlineStruct.gdt_table10.site_id.ToString() + ", " + offlineStruct.gdt_table10.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 11 (site_id, gdt_id}", "(" + offlineStruct.gdt_table11.site_id.ToString() + ", " + offlineStruct.gdt_table11.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 12 (site_id, gdt_id}", "(" + offlineStruct.gdt_table12.site_id.ToString() + ", " + offlineStruct.gdt_table12.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 13 (site_id, gdt_id}", "(" + offlineStruct.gdt_table13.site_id.ToString() + ", " + offlineStruct.gdt_table13.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 14 (site_id, gdt_id}", "(" + offlineStruct.gdt_table14.site_id.ToString() + ", " + offlineStruct.gdt_table14.gdt_id.ToString() + ")" });
                OfflineDataTable.Rows.Add(new object[] {"Unique GDT Entry 15 (site_id, gdt_id}", "(" + offlineStruct.gdt_table15.site_id.ToString() + ", " + offlineStruct.gdt_table15.gdt_id.ToString() + ")" });


                OfflineDataTable.Rows.Add(new object[] {"Iridium Command Retries", offlineStruct.ird_cmd_retries.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Command Delay Timeout", offlineStruct.ird_cmd_delay_timeout.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Signal Quality Timeout", offlineStruct.ird_signal_qual_timeout.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Connect Delay Timeout", offlineStruct.ird_connect_delay_timeout.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Replace Character", offlineStruct.ird_replace_char.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Unknown Signal Quality", offlineStruct.ird_unknown_signal_quality.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Start State Listen Timeout", offlineStruct.ird_start_state_listen_timeout.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Ring Inhibit Timeout", offlineStruct.ird_ring_inhibit_timeout.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Modem Config", offlineStruct.ird_modem_config.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 1", offlineStruct.ird_init_sequence1.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 2", offlineStruct.ird_init_sequence2.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 3", offlineStruct.ird_init_sequence3.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 4", offlineStruct.ird_init_sequence4.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 5", offlineStruct.ird_init_sequence5.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 6", offlineStruct.ird_init_sequence6.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 7", offlineStruct.ird_init_sequence7.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 8", offlineStruct.ird_init_sequence8.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 9", offlineStruct.ird_init_sequence9.ToString() });
                OfflineDataTable.Rows.Add(new object[] {"Iridium Init Sequence 10", offlineStruct.ird_init_sequence10.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 11", offlineStruct.ird_init_sequence11.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 12", offlineStruct.ird_init_sequence12.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 13", offlineStruct.ird_init_sequence13.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 14", offlineStruct.ird_init_sequence14.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 15", offlineStruct.ird_init_sequence15.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 16", offlineStruct.ird_init_sequence16.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 17", offlineStruct.ird_init_sequence17.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 18", offlineStruct.ird_init_sequence18.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 19", offlineStruct.ird_init_sequence19.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 20", offlineStruct.ird_init_sequence20.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 21", offlineStruct.ird_init_sequence21.ToString() });
                OfflineDataTable.Rows.Add(new object[] { "Iridium Init Sequence 22", offlineStruct.ird_init_sequence22.ToString() });

 

                isRTConfigurationArrived = true;                                                                                                                                                       
                DoInvoke(new IModuleEventArgs(this.deviceIdConnected));                                                                                                                                
            }                                                                                                                                                                                          
            return true;
        }
        public void setFirstTime(bool firstTimeArg)
        {
            isFirstTime = firstTimeArg;
            isRTConfigurationArrived = firstTimeArg;
        }
        public string getIPStringFromInt(int ip)
        {
            string result = BitConverter.GetBytes(ip)[0] + "." + BitConverter.GetBytes(ip)[1] + "." + BitConverter.GetBytes(ip)[2] + "." + BitConverter.GetBytes(ip)[3];
            return result;
        }
    }
}
