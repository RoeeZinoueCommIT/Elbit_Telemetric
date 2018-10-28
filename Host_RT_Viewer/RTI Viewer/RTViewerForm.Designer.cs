using System.Windows.Forms;
using System.Drawing;
namespace RT_Viewer
{
    partial class RTViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTViewerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pause_button = new System.Windows.Forms.Button();
            this.startRecieve_button = new System.Windows.Forms.Button();
            this.uplTable_groupBox = new System.Windows.Forms.GroupBox();
            this.uplTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPLTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdtTable_groupBox = new System.Windows.Forms.GroupBox();
            this.gdtTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn101 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn102 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn103 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn104 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn105 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn106 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdtTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.upTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnlTable_groupBox = new System.Windows.Forms.GroupBox();
            this.lopTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isselectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOPTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stopRecieve_button = new System.Windows.Forms.Button();
            this.cleanScreen_button = new System.Windows.Forms.Button();
            this.application_tabControl = new System.Windows.Forms.TabControl();
            this.version_tabPage = new System.Windows.Forms.TabPage();
            this.general_groupBox = new System.Windows.Forms.GroupBox();
            this.ipRT1_textBox = new System.Windows.Forms.TextBox();
            this.rtDefualtGatway_textBox = new System.Windows.Forms.TextBox();
            this.ipRTA_label = new System.Windows.Forms.Label();
            this.rtDefualtGatway_label = new System.Windows.Forms.Label();
            this.ipRTB_label = new System.Windows.Forms.Label();
            this.ipRT2_textBox = new System.Windows.Forms.TextBox();
            this.versions_groupBox = new System.Windows.Forms.GroupBox();
            this.rtMode_textBox = new System.Windows.Forms.TextBox();
            this.rtMode_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewerVersion_textBox = new System.Windows.Forms.TextBox();
            this.viewerVersion_label = new System.Windows.Forms.Label();
            this.hbsVersion_textBox = new System.Windows.Forms.TextBox();
            this.buildDate_textBox = new System.Windows.Forms.TextBox();
            this.hbsVersion_label = new System.Windows.Forms.Label();
            this.rtVersion_textBox = new System.Windows.Forms.TextBox();
            this.rtBuildDate_label = new System.Windows.Forms.Label();
            this.rtVersion_label = new System.Windows.Forms.Label();
            this.rti_tabPage = new System.Windows.Forms.TabPage();
            this.lopCounter_textBox = new System.Windows.Forms.TextBox();
            this.lopCounter_label = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.uavRtiTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.hstTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcsextraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplinkID10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvramReadData_groupBox = new System.Windows.Forms.GroupBox();
            this.transactionMode_textBox = new System.Windows.Forms.TextBox();
            this.mainRTCounter_lable = new System.Windows.Forms.Label();
            this.mainRTCounter_textBox = new System.Windows.Forms.TextBox();
            this.uavCounter_lable = new System.Windows.Forms.Label();
            this.uavCounter_textBox = new System.Windows.Forms.TextBox();
            this.transactionMode_lable = new System.Windows.Forms.Label();
            this.hstCounter_lable = new System.Windows.Forms.Label();
            this.hstCounter_textBox = new System.Windows.Forms.TextBox();
            this.uav_tabPage = new System.Windows.Forms.TabPage();
            this.dnlinkTable_groupBox = new System.Windows.Forms.GroupBox();
            this.uavTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.tailnumberDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBANDCOUNTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBANDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uHFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sATCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cH4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cH5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cH6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cH7DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cH8DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cH9DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cH10DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNLTableBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.ntp_tabPage = new System.Windows.Forms.TabPage();
            this.convertTimeStamp_groupBox = new System.Windows.Forms.GroupBox();
            this.copyTimeStamp_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.convertTimeStamp_button = new System.Windows.Forms.Button();
            this.utcConvert_textBox = new System.Windows.Forms.MaskedTextBox();
            this.timestampConvert_textBox = new System.Windows.Forms.MaskedTextBox();
            this.utcConvert_label = new System.Windows.Forms.Label();
            this.timestampConvert_label = new System.Windows.Forms.Label();
            this.ntpInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.NtpServerIp_label = new System.Windows.Forms.Label();
            this.ntpServerIP_textBox = new System.Windows.Forms.TextBox();
            this.ntpServerConnection_textBox = new System.Windows.Forms.TextBox();
            this.ntpServerConnection_pictureBox = new System.Windows.Forms.PictureBox();
            this.ntpServerConnection_label = new System.Windows.Forms.Label();
            this.utc_label = new System.Windows.Forms.Label();
            this.timeStamp_label = new System.Windows.Forms.Label();
            this.utc_textBox = new System.Windows.Forms.TextBox();
            this.timeStamp_textBox = new System.Windows.Forms.MaskedTextBox();
            this.frm_tabPage = new System.Windows.Forms.TabPage();
            this.fault_tabControl = new System.Windows.Forms.TabControl();
            this.frmFault_tabPage = new System.Windows.Forms.TabPage();
            this.frmFaults_groupBox = new System.Windows.Forms.GroupBox();
            this.frmFaultMaxRecords_label = new System.Windows.Forms.Label();
            this.frmFaultCntr_label = new System.Windows.Forms.Label();
            this.frmFaultMaxRecords_textBox = new System.Windows.Forms.TextBox();
            this.frmFaultCntr_textBox = new System.Windows.Forms.TextBox();
            this.frm_panel = new System.Windows.Forms.Panel();
            this.frm_dataGridView = new System.Windows.Forms.DataGridView();
            this.mFLIDnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultcurrentlyexistsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNoofappearancesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstappearanceVMSCcycleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstappearancetimeinmsecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstdisappearancetimeinmsecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRMTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pflFault_tabPage = new System.Windows.Forms.TabPage();
            this.pfl_groupBox = new System.Windows.Forms.GroupBox();
            this.pfl_panel = new System.Windows.Forms.Panel();
            this.pflFault_dataGridView = new System.Windows.Forms.DataGridView();
            this.pFLIDnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFLLABELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFLTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalPFLRecords_label = new System.Windows.Forms.Label();
            this.pflFaultReported_label = new System.Windows.Forms.Label();
            this.totalPFLRecords_textBox = new System.Windows.Forms.TextBox();
            this.pflFaultsReported_textBox = new System.Windows.Forms.TextBox();
            this.log_tabPage = new System.Windows.Forms.TabPage();
            this.log_tabControl = new System.Windows.Forms.TabControl();
            this.logProperties_tabPage = new System.Windows.Forms.TabPage();
            this.RTCLogger_groupBox = new System.Windows.Forms.GroupBox();
            this.setRTLogLevel_groupBox = new System.Windows.Forms.GroupBox();
            this.setLogLevelAllModule_comboBox = new System.Windows.Forms.GroupBox();
            this.setRTLogLevelForAllModules_button = new System.Windows.Forms.Button();
            this.setLogLevelForAllModules_comboBox = new System.Windows.Forms.ComboBox();
            this.setRTLogLevel_panel = new System.Windows.Forms.Panel();
            this.setRTLogLevel_dataGridView = new System.Windows.Forms.DataGridView();
            this.undoRTCLogLevel_Button = new System.Windows.Forms.Button();
            this.setRTLogLevel_button = new System.Windows.Forms.Button();
            this.rtcLoggerControl_groupBox = new System.Windows.Forms.GroupBox();
            this.logShellSideB_button = new System.Windows.Forms.Button();
            this.logShellSideA_button = new System.Windows.Forms.Button();
            this.startRtcLogger_button = new System.Windows.Forms.Button();
            this.LogSearch_tabPage = new System.Windows.Forms.TabPage();
            this.ContentNavigation_groupBox = new System.Windows.Forms.GroupBox();
            this.logPageNumber_label = new System.Windows.Forms.Label();
            this.showPrevLogResult_button = new System.Windows.Forms.Button();
            this.showNextLogResult_button = new System.Windows.Forms.Button();
            this.setRTCLoggerFilter_groupBox = new System.Windows.Forms.GroupBox();
            this.openFilteredFile_Button = new System.Windows.Forms.Button();
            this.setRTCLoggerFilter_panel = new System.Windows.Forms.Panel();
            this.setRTCLoggerFilter_dataGridView = new System.Windows.Forms.DataGridView();
            this.setLogFilter_button = new System.Windows.Forms.Button();
            this.logContent_groupBox = new System.Windows.Forms.GroupBox();
            this.logContent_splitContainer = new System.Windows.Forms.SplitContainer();
            this.logContent_textBox = new System.Windows.Forms.TextBox();
            this.LogSearchStatus_groupBox = new System.Windows.Forms.GroupBox();
            this.searchStatus_richTextBox = new System.Windows.Forms.RichTextBox();
            this.selectLogFolder_button = new System.Windows.Forms.Button();
            this.newSearchLogContent_button = new System.Windows.Forms.Button();
            this.isOnlineSearch_radioButton = new System.Windows.Forms.RadioButton();
            this.isOfflineSearch_radioButton = new System.Windows.Forms.RadioButton();
            this.onlineLogSearch_panel = new System.Windows.Forms.Panel();
            this.logEnd_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.logDateOperand2_label = new System.Windows.Forms.Label();
            this.logStart_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.logDateOperand1_label = new System.Windows.Forms.Label();
            this.logDateOperator_comboBox = new System.Windows.Forms.ComboBox();
            this.caseSensitiveFilterSearch_checkbox = new System.Windows.Forms.CheckBox();
            this.reloadLogFile_button = new System.Windows.Forms.Button();
            this.stopFilterByStringInLog_button = new System.Windows.Forms.Button();
            this.loadingLogFilter_pictureBox = new System.Windows.Forms.PictureBox();
            this.searchStringInLog_label = new System.Windows.Forms.Label();
            this.filterByStringInLog_button = new System.Windows.Forms.Button();
            this.searchStringInLog_textBox = new System.Windows.Forms.TextBox();
            this.stk_tabPage = new System.Windows.Forms.TabPage();
            this.stk_groupBox = new System.Windows.Forms.GroupBox();
            this.stk_panel = new System.Windows.Forms.Panel();
            this.stick_dataGridView = new System.Windows.Forms.DataGridView();
            this.tailnumberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ongroundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxienabledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxireportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxicommandsentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kacntrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTKTaxiTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ird_tabPage = new System.Windows.Forms.TabPage();
            this.ird_groupBox = new System.Windows.Forms.GroupBox();
            this.ird_panel = new System.Windows.Forms.Panel();
            this.iridium_dataGridView = new System.Windows.Forms.DataGridView();
            this.ird_tailnumber_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_kind_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_is_active_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_state_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_init_substate_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_init_done_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_last_message_kind_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_last_telegram_kind_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_last_respons_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_last_command_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_last_acked_command_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_reception_quality_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_received_reception_quality_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ird_last_aps_response_to_ring_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irdTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvm_tabPage = new System.Windows.Forms.TabPage();
            this.nvramWrite_groupBox = new System.Windows.Forms.GroupBox();
            this.loadingNVRAMWrite_pictureBox = new System.Windows.Forms.PictureBox();
            this.idGcsWriteData_button = new System.Windows.Forms.Button();
            this.idGcsWriteData_textBox = new System.Windows.Forms.TextBox();
            this.idGcsWriteData_label = new System.Windows.Forms.Label();
            this.nvramRead_groupBox = new System.Windows.Forms.GroupBox();
            this.idGCSRead_button = new System.Windows.Forms.Button();
            this.idGcsReadData_textBox = new System.Windows.Forms.TextBox();
            this.idGcsReadData_label = new System.Windows.Forms.Label();
            this.hky_tabPage = new System.Windows.Forms.TabPage();
            this.hky_tabControl = new System.Windows.Forms.TabControl();
            this.keys_tabPage = new System.Windows.Forms.TabPage();
            this.hky_keys_Console2_groupBox = new System.Windows.Forms.GroupBox();
            this.console2Keys_panel = new System.Windows.Forms.Panel();
            this.keysHKYConsole2_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hky_keys_Console1_groupBox = new System.Windows.Forms.GroupBox();
            this.console1Keys_panel = new System.Windows.Forms.Panel();
            this.keysHKYConsole1_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.led_tabPage = new System.Windows.Forms.TabPage();
            this.stkConsole2_groupBox = new System.Windows.Forms.GroupBox();
            this.console1Led_panel = new System.Windows.Forms.Panel();
            this.ledHKYConsole2_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hkyConsole2Tail_textBox = new System.Windows.Forms.TextBox();
            this.hkyConsole2Tail_label = new System.Windows.Forms.Label();
            this.stkConsole1_groupBox = new System.Windows.Forms.GroupBox();
            this.console2Led_panel = new System.Windows.Forms.Panel();
            this.ledHKYConsole1_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hkyConsole1Tail_label = new System.Windows.Forms.Label();
            this.hkyConsole1Tail_textBox = new System.Windows.Forms.TextBox();
            this.headingKnob_tabPage = new System.Windows.Forms.TabPage();
            this.headingKnob_groupBox = new System.Windows.Forms.GroupBox();
            this.HKY_KnobConsole2Gb = new System.Windows.Forms.GroupBox();
            this.PresetKnob2Btn = new System.Windows.Forms.Button();
            this.StartStopKnob2Btn = new System.Windows.Forms.Button();
            this.HN2_raw_position_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HN2Position_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HN2VendorID3_textBox = new System.Windows.Forms.TextBox();
            this.HN2VendorID2_textBox = new System.Windows.Forms.TextBox();
            this.HN2InitStatus_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HN2VendorID1_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.HN2Calculated_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HN2Read4_textBox = new System.Windows.Forms.TextBox();
            this.HN2Read3_textBox = new System.Windows.Forms.TextBox();
            this.HN2Read2_textBox = new System.Windows.Forms.TextBox();
            this.HN2Read1_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.HKY_KnobConsole1Gb = new System.Windows.Forms.GroupBox();
            this.PresetKnob1Btn = new System.Windows.Forms.Button();
            this.StartStopKnob1Btn = new System.Windows.Forms.Button();
            this.HN1_raw_position_textBox = new System.Windows.Forms.TextBox();
            this.rowPosition_label = new System.Windows.Forms.Label();
            this.HN1Position_textBox = new System.Windows.Forms.TextBox();
            this.HNPosition_label = new System.Windows.Forms.Label();
            this.HN1VendorID3_textBox = new System.Windows.Forms.TextBox();
            this.HN1VendorID2_textBox = new System.Windows.Forms.TextBox();
            this.HN1InitStatus_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HN1VendorID1_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HN1Calculated_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HN1Read4_textBox = new System.Windows.Forms.TextBox();
            this.HN1Read3_textBox = new System.Windows.Forms.TextBox();
            this.HN1Read2_textBox = new System.Windows.Forms.TextBox();
            this.HN1Read1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pfd_tabPage = new System.Windows.Forms.TabPage();
            this.pfdUpl_groupBox = new System.Windows.Forms.GroupBox();
            this.rollData_textBox = new System.Windows.Forms.TextBox();
            this.roll_label = new System.Windows.Forms.Label();
            this.pitchData_textBox = new System.Windows.Forms.TextBox();
            this.pitch_label = new System.Windows.Forms.Label();
            this.mgc_tabPage = new System.Windows.Forms.TabPage();
            this.gru5Info_groupBox = new System.Windows.Forms.GroupBox();
            this.gru5Info_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCIPConfigurationTableDBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gru4Info_groupBox = new System.Windows.Forms.GroupBox();
            this.gru4Info_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gru3Info_groupBox = new System.Windows.Forms.GroupBox();
            this.gru3Info_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gru2Info_groupBox = new System.Windows.Forms.GroupBox();
            this.gru2Info_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgcInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.HstGruConfTableCntr_textBox = new System.Windows.Forms.TextBox();
            this.hstGruConftableCntr_label = new System.Windows.Forms.Label();
            this.hstGruConfTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.aTOLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAVIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSTGruConfTableDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gru1Info_groupBox = new System.Windows.Forms.GroupBox();
            this.gru1Info_dataGridView = new System.Windows.Forms.DataGridView();
            this.gruIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailNumberAttachedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apsRTCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtGRUCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRURegularCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUFastCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruAlives_groupBox = new System.Windows.Forms.GroupBox();
            this.gru5Configure_label = new System.Windows.Forms.Label();
            this.gru4Configure_label = new System.Windows.Forms.Label();
            this.gru3Configure_label = new System.Windows.Forms.Label();
            this.gru2Configure_label = new System.Windows.Forms.Label();
            this.gru1Configure_label = new System.Windows.Forms.Label();
            this.gru5name_label = new System.Windows.Forms.Label();
            this.gru4name_label = new System.Windows.Forms.Label();
            this.gru3name_label = new System.Windows.Forms.Label();
            this.gru2name_label = new System.Windows.Forms.Label();
            this.gru1name_label = new System.Windows.Forms.Label();
            this.gru5Conection_pictureBox = new System.Windows.Forms.PictureBox();
            this.gru4Conection_pictureBox = new System.Windows.Forms.PictureBox();
            this.gru3Conection_pictureBox = new System.Windows.Forms.PictureBox();
            this.gru2Conection_pictureBox = new System.Windows.Forms.PictureBox();
            this.gru1Conection_pictureBox = new System.Windows.Forms.PictureBox();
            this.gdt_tabPage = new System.Windows.Forms.TabPage();
            this.tlm_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tlm_tbx_PathConfigFiles = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tlm_rdb_DataTypeOrginal = new System.Windows.Forms.RadioButton();
            this.tlm_rdb_DataTypeChars = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tlm_rdb_SortLowHigh = new System.Windows.Forms.RadioButton();
            this.tlm_rdb_SortHighLow = new System.Windows.Forms.RadioButton();
            this.tlm_rdb_SortByGroups = new System.Windows.Forms.RadioButton();
            this.tlm_btn_SaveConfigurations = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tlm_btn_FigureDataMember = new System.Windows.Forms.Button();
            this.tlm_cbx_FindGroup = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tlm_tbx_FindName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlm_rdb_ReadSourceFile = new System.Windows.Forms.RadioButton();
            this.tlm_gbx_fileUpdate = new System.Windows.Forms.GroupBox();
            this.tlm_tbx_ForceUpdatePath = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tlm_btn_ForceUpdate = new System.Windows.Forms.Button();
            this.tlm_rdb_ReadSourceCurrent = new System.Windows.Forms.RadioButton();
            this.tlm_rdb_ReadSourceFlash = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tlm_data_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tlm_cbx_SaveBigTableType = new System.Windows.Forms.ComboBox();
            this.tlm_btn_SaveBigTableSelect = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tlm_tbx_SaveBigTablePath = new System.Windows.Forms.TextBox();
            this.tlmTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlmTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlm_visual_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tlm_cbx_ViewerSaveType = new System.Windows.Forms.ComboBox();
            this.tlm_btn_ViewerSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tlm_btn_ViewerSavePath = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tlm_rtb_view_res_table_time = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tlm_rtb_view_res_table_value = new System.Windows.Forms.RichTextBox();
            this.tlm_gbx_view_figure = new System.Windows.Forms.GroupBox();
            this.tlm_chart_view = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statistics_tabPage = new System.Windows.Forms.TabPage();
            this.Status_groupBox = new System.Windows.Forms.GroupBox();
            this.Config_Diff_Tb = new System.Windows.Forms.TextBox();
            this.configurationSync_pictureBox = new System.Windows.Forms.PictureBox();
            this.versionSync_pictureBox = new System.Windows.Forms.PictureBox();
            this.configurationSync_label = new System.Windows.Forms.Label();
            this.versionsSync_label = new System.Windows.Forms.Label();
            this.taskStackUsage_groupBox = new System.Windows.Forms.GroupBox();
            this.pfdStackUsage_textBox = new System.Windows.Forms.TextBox();
            this.pfdTaskUsage_label = new System.Windows.Forms.Label();
            this.vtuStackUsage_textBox = new System.Windows.Forms.TextBox();
            this.logStackUsage_textBox = new System.Windows.Forms.TextBox();
            this.mainStackUsage_textBox = new System.Windows.Forms.TextBox();
            this.vtuTaskUsage_label = new System.Windows.Forms.Label();
            this.logTaskUsage_label = new System.Windows.Forms.Label();
            this.mainTaskUsage_label = new System.Windows.Forms.Label();
            this.cpuUsage_groupBox = new System.Windows.Forms.GroupBox();
            this.cpuUsage_textBox = new System.Windows.Forms.TextBox();
            this.cpuUsage_label = new System.Windows.Forms.Label();
            this.offlineParameters_tabPage = new System.Windows.Forms.TabPage();
            this.offlineParameters_groupBox = new System.Windows.Forms.GroupBox();
            this.offlineParam_panel = new System.Windows.Forms.Panel();
            this.offlineParam_dataGridView = new System.Windows.Forms.DataGridView();
            this.dNLTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dNLTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mGCIPConfigurationTableDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRMTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keepAliveRX_label = new System.Windows.Forms.Label();
            this.keepAliveRXCntr_textBox = new System.Windows.Forms.TextBox();
            this.rtMainStatus_panel = new System.Windows.Forms.Panel();
            this.gcsIdTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rt2Selected_radioButton = new System.Windows.Forms.RadioButton();
            this.selectedRT_label = new System.Windows.Forms.Label();
            this.rt1Selected_radioButton = new System.Windows.Forms.RadioButton();
            this.rtComStatus_textBox = new System.Windows.Forms.TextBox();
            this.rtStatus_textBox = new System.Windows.Forms.TextBox();
            this.kaTX_pictureBox = new System.Windows.Forms.PictureBox();
            this.kaRX_pictureBox = new System.Windows.Forms.PictureBox();
            this.keepAliveTXCntr_textBox = new System.Windows.Forms.TextBox();
            this.keepAliveTX_label = new System.Windows.Forms.Label();
            this.rtComStatus_label = new System.Windows.Forms.Label();
            this.rtComStatus_pictureBox = new System.Windows.Forms.PictureBox();
            this.rtStatus_label = new System.Windows.Forms.Label();
            this.menu_menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logLevelTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dNLTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logLevelTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.levelOfReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logLevelTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.logLevelTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.logLevelTableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.loadLogFile_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mGCIPConfDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGCIPConfigurationTableDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dNLTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dNLTableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.Tlm_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uplTable_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uplTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPLTableBindingSource)).BeginInit();
            this.gdtTable_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdtTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdtTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upTableBindingSource)).BeginInit();
            this.dnlTable_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTableBindingSource)).BeginInit();
            this.application_tabControl.SuspendLayout();
            this.version_tabPage.SuspendLayout();
            this.general_groupBox.SuspendLayout();
            this.versions_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rti_tabPage.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uavRtiTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTEntryBindingSource)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hstTable_dataGridView)).BeginInit();
            this.nvramReadData_groupBox.SuspendLayout();
            this.uav_tabPage.SuspendLayout();
            this.dnlinkTable_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uavTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource5)).BeginInit();
            this.ntp_tabPage.SuspendLayout();
            this.convertTimeStamp_groupBox.SuspendLayout();
            this.ntpInfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntpServerConnection_pictureBox)).BeginInit();
            this.frm_tabPage.SuspendLayout();
            this.fault_tabControl.SuspendLayout();
            this.frmFault_tabPage.SuspendLayout();
            this.frmFaults_groupBox.SuspendLayout();
            this.frm_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRMTableBindingSource1)).BeginInit();
            this.pflFault_tabPage.SuspendLayout();
            this.pfl_groupBox.SuspendLayout();
            this.pfl_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pflFault_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFLTableBindingSource)).BeginInit();
            this.log_tabPage.SuspendLayout();
            this.log_tabControl.SuspendLayout();
            this.logProperties_tabPage.SuspendLayout();
            this.RTCLogger_groupBox.SuspendLayout();
            this.setRTLogLevel_groupBox.SuspendLayout();
            this.setLogLevelAllModule_comboBox.SuspendLayout();
            this.setRTLogLevel_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setRTLogLevel_dataGridView)).BeginInit();
            this.rtcLoggerControl_groupBox.SuspendLayout();
            this.LogSearch_tabPage.SuspendLayout();
            this.ContentNavigation_groupBox.SuspendLayout();
            this.setRTCLoggerFilter_groupBox.SuspendLayout();
            this.setRTCLoggerFilter_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setRTCLoggerFilter_dataGridView)).BeginInit();
            this.logContent_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logContent_splitContainer)).BeginInit();
            this.logContent_splitContainer.Panel1.SuspendLayout();
            this.logContent_splitContainer.Panel2.SuspendLayout();
            this.logContent_splitContainer.SuspendLayout();
            this.LogSearchStatus_groupBox.SuspendLayout();
            this.onlineLogSearch_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingLogFilter_pictureBox)).BeginInit();
            this.stk_tabPage.SuspendLayout();
            this.stk_groupBox.SuspendLayout();
            this.stk_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stick_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTKTaxiTableBindingSource)).BeginInit();
            this.ird_tabPage.SuspendLayout();
            this.ird_groupBox.SuspendLayout();
            this.ird_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iridium_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.irdTableBindingSource)).BeginInit();
            this.nvm_tabPage.SuspendLayout();
            this.nvramWrite_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingNVRAMWrite_pictureBox)).BeginInit();
            this.nvramRead_groupBox.SuspendLayout();
            this.hky_tabPage.SuspendLayout();
            this.hky_tabControl.SuspendLayout();
            this.keys_tabPage.SuspendLayout();
            this.hky_keys_Console2_groupBox.SuspendLayout();
            this.console2Keys_panel.SuspendLayout();
            this.hky_keys_Console1_groupBox.SuspendLayout();
            this.console1Keys_panel.SuspendLayout();
            this.led_tabPage.SuspendLayout();
            this.stkConsole2_groupBox.SuspendLayout();
            this.console1Led_panel.SuspendLayout();
            this.stkConsole1_groupBox.SuspendLayout();
            this.console2Led_panel.SuspendLayout();
            this.headingKnob_tabPage.SuspendLayout();
            this.headingKnob_groupBox.SuspendLayout();
            this.HKY_KnobConsole2Gb.SuspendLayout();
            this.HKY_KnobConsole1Gb.SuspendLayout();
            this.pfd_tabPage.SuspendLayout();
            this.pfdUpl_groupBox.SuspendLayout();
            this.mgc_tabPage.SuspendLayout();
            this.gru5Info_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru5Info_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGCIPConfigurationTableDBBindingSource2)).BeginInit();
            this.gru4Info_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru4Info_dataGridView)).BeginInit();
            this.gru3Info_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru3Info_dataGridView)).BeginInit();
            this.gru2Info_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru2Info_dataGridView)).BeginInit();
            this.mgcInfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hstGruConfTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hSTGruConfTableDBBindingSource)).BeginInit();
            this.gru1Info_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru1Info_dataGridView)).BeginInit();
            this.gruAlives_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru5Conection_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gru4Conection_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gru3Conection_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gru2Conection_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gru1Conection_pictureBox)).BeginInit();
            this.gdt_tabPage.SuspendLayout();
            this.tlm_tabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tlm_gbx_fileUpdate.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tlm_data_tabPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlmTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlmTableBindingSource)).BeginInit();
            this.tlm_visual_tabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tlm_gbx_view_figure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlm_chart_view)).BeginInit();
            this.statistics_tabPage.SuspendLayout();
            this.Status_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationSync_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionSync_pictureBox)).BeginInit();
            this.taskStackUsage_groupBox.SuspendLayout();
            this.cpuUsage_groupBox.SuspendLayout();
            this.offlineParameters_tabPage.SuspendLayout();
            this.offlineParameters_groupBox.SuspendLayout();
            this.offlineParam_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offlineParam_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGCIPConfigurationTableDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRMTableBindingSource)).BeginInit();
            this.rtMainStatus_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaTX_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaRX_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtComStatus_pictureBox)).BeginInit();
            this.menu_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGCIPConfDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGCIPConfigurationTableDBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // pause_button
            // 
            this.pause_button.BackColor = System.Drawing.SystemColors.Control;
            this.pause_button.Enabled = false;
            this.pause_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pause_button.Location = new System.Drawing.Point(106, 658);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(121, 27);
            this.pause_button.TabIndex = 5;
            this.pause_button.Text = "Pause";
            this.pause_button.UseVisualStyleBackColor = false;
            this.pause_button.Click += new System.EventHandler(this.continuePause_Click);
            // 
            // startRecieve_button
            // 
            this.startRecieve_button.BackColor = System.Drawing.SystemColors.Control;
            this.startRecieve_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startRecieve_button.Location = new System.Drawing.Point(-29, 659);
            this.startRecieve_button.Name = "startRecieve_button";
            this.startRecieve_button.Size = new System.Drawing.Size(121, 27);
            this.startRecieve_button.TabIndex = 1;
            this.startRecieve_button.Text = "Start Receive";
            this.startRecieve_button.UseVisualStyleBackColor = false;
            this.startRecieve_button.Click += new System.EventHandler(this.startListening_click);
            // 
            // uplTable_groupBox
            // 
            this.uplTable_groupBox.Controls.Add(this.uplTable_dataGridView);
            this.uplTable_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uplTable_groupBox.Location = new System.Drawing.Point(6, 6);
            this.uplTable_groupBox.Name = "uplTable_groupBox";
            this.uplTable_groupBox.Size = new System.Drawing.Size(1240, 228);
            this.uplTable_groupBox.TabIndex = 2;
            this.uplTable_groupBox.TabStop = false;
            this.uplTable_groupBox.Text = "RTI Table (Uplink)";
            this.uplTable_groupBox.Enter += new System.EventHandler(this.uplTable_groupBox_Enter);
            // 
            // uplTable_dataGridView
            // 
            this.uplTable_dataGridView.AllowUserToAddRows = false;
            this.uplTable_dataGridView.AllowUserToDeleteRows = false;
            this.uplTable_dataGridView.AutoGenerateColumns = false;
            this.uplTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uplTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50});
            this.uplTable_dataGridView.DataSource = this.uPLTableBindingSource;
            this.uplTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uplTable_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.uplTable_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.uplTable_dataGridView.Name = "uplTable_dataGridView";
            this.uplTable_dataGridView.ReadOnly = true;
            this.uplTable_dataGridView.RowHeadersVisible = false;
            this.uplTable_dataGridView.Size = new System.Drawing.Size(1234, 209);
            this.uplTable_dataGridView.TabIndex = 0;
            this.uplTable_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uplTable_dataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn29.DataPropertyName = "tail_number";
            this.dataGridViewTextBoxColumn29.FillWeight = 30F;
            this.dataGridViewTextBoxColumn29.HeaderText = "Tail";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn41.DataPropertyName = "CBand";
            this.dataGridViewTextBoxColumn41.HeaderText = "CBand";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn42.DataPropertyName = "UHF";
            this.dataGridViewTextBoxColumn42.HeaderText = "UHF";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn43.DataPropertyName = "SATCOM1";
            this.dataGridViewTextBoxColumn43.HeaderText = "SATCOM1";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn44.DataPropertyName = "SATCOM2";
            this.dataGridViewTextBoxColumn44.HeaderText = "SATCOM2";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn45.DataPropertyName = "IRIDIUM";
            this.dataGridViewTextBoxColumn45.HeaderText = "IRIDIUM";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn46.DataPropertyName = "MOBILICOM";
            this.dataGridViewTextBoxColumn46.HeaderText = "MOBILICOM";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn47.DataPropertyName = "CH_7";
            this.dataGridViewTextBoxColumn47.FillWeight = 40F;
            this.dataGridViewTextBoxColumn47.HeaderText = "CH_7";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn48.DataPropertyName = "CH_8";
            this.dataGridViewTextBoxColumn48.FillWeight = 40F;
            this.dataGridViewTextBoxColumn48.HeaderText = "CH_8";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn49.DataPropertyName = "CH_9";
            this.dataGridViewTextBoxColumn49.FillWeight = 40F;
            this.dataGridViewTextBoxColumn49.HeaderText = "CH_9";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn50.DataPropertyName = "CH_10";
            this.dataGridViewTextBoxColumn50.FillWeight = 40F;
            this.dataGridViewTextBoxColumn50.HeaderText = "CH_10";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            // 
            // uPLTableBindingSource
            // 
            this.uPLTableBindingSource.DataSource = typeof(RT_Viewer.Framework.RTIModule.UPLTable);
            // 
            // gdtTable_groupBox
            // 
            this.gdtTable_groupBox.Controls.Add(this.gdtTable_dataGridView);
            this.gdtTable_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gdtTable_groupBox.Location = new System.Drawing.Point(6, 6);
            this.gdtTable_groupBox.Name = "gdtTable_groupBox";
            this.gdtTable_groupBox.Size = new System.Drawing.Size(1251, 500);
            this.gdtTable_groupBox.TabIndex = 2;
            this.gdtTable_groupBox.TabStop = false;
            this.gdtTable_groupBox.Text = "GDT Table ";
            // 
            // gdtTable_dataGridView
            // 
            this.gdtTable_dataGridView.AllowUserToAddRows = false;
            this.gdtTable_dataGridView.AllowUserToDeleteRows = false;
            this.gdtTable_dataGridView.AutoGenerateColumns = false;
            this.gdtTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdtTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn100,
            this.dataGridViewTextBoxColumn101,
            this.dataGridViewTextBoxColumn102,
            this.dataGridViewTextBoxColumn103,
            this.dataGridViewTextBoxColumn104,
            this.dataGridViewTextBoxColumn105,
            this.dataGridViewTextBoxColumn106});
            this.gdtTable_dataGridView.DataSource = this.gdtTableBindingSource;
            this.gdtTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdtTable_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gdtTable_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.gdtTable_dataGridView.Name = "gdtTable_dataGridView";
            this.gdtTable_dataGridView.ReadOnly = true;
            this.gdtTable_dataGridView.RowHeadersVisible = false;
            this.gdtTable_dataGridView.Size = new System.Drawing.Size(1245, 481);
            this.gdtTable_dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn100
            // 
            this.dataGridViewTextBoxColumn100.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn100.DataPropertyName = "GdtId";
            this.dataGridViewTextBoxColumn100.FillWeight = 30F;
            this.dataGridViewTextBoxColumn100.HeaderText = "GDT {Site Id, Gdt Id}";
            this.dataGridViewTextBoxColumn100.Name = "dataGridViewTextBoxColumn100";
            this.dataGridViewTextBoxColumn100.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn101
            // 
            this.dataGridViewTextBoxColumn101.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn101.DataPropertyName = "Rx_CBand";
            this.dataGridViewTextBoxColumn101.FillWeight = 30F;
            this.dataGridViewTextBoxColumn101.HeaderText = "RX C-Band";
            this.dataGridViewTextBoxColumn101.Name = "dataGridViewTextBoxColumn101";
            this.dataGridViewTextBoxColumn101.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn102
            // 
            this.dataGridViewTextBoxColumn102.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn102.DataPropertyName = "Rx_UHF";
            this.dataGridViewTextBoxColumn102.FillWeight = 30F;
            this.dataGridViewTextBoxColumn102.HeaderText = "RX-UHF";
            this.dataGridViewTextBoxColumn102.Name = "dataGridViewTextBoxColumn102";
            this.dataGridViewTextBoxColumn102.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn103
            // 
            this.dataGridViewTextBoxColumn103.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn103.DataPropertyName = "Tx_CBand";
            this.dataGridViewTextBoxColumn103.FillWeight = 30F;
            this.dataGridViewTextBoxColumn103.HeaderText = "TX C-Band";
            this.dataGridViewTextBoxColumn103.Name = "dataGridViewTextBoxColumn103";
            this.dataGridViewTextBoxColumn103.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn104
            // 
            this.dataGridViewTextBoxColumn104.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn104.DataPropertyName = "Tx_UHF";
            this.dataGridViewTextBoxColumn104.FillWeight = 30F;
            this.dataGridViewTextBoxColumn104.HeaderText = "TX-UHF";
            this.dataGridViewTextBoxColumn104.Name = "dataGridViewTextBoxColumn104";
            this.dataGridViewTextBoxColumn104.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn105
            // 
            this.dataGridViewTextBoxColumn105.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn105.DataPropertyName = "GDT_Rx_CBand";
            this.dataGridViewTextBoxColumn105.FillWeight = 30F;
            this.dataGridViewTextBoxColumn105.HeaderText = "GDT RX C-Band";
            this.dataGridViewTextBoxColumn105.Name = "dataGridViewTextBoxColumn105";
            this.dataGridViewTextBoxColumn105.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn106
            // 
            this.dataGridViewTextBoxColumn106.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn106.DataPropertyName = "GDT_Rx_UHF";
            this.dataGridViewTextBoxColumn106.FillWeight = 30F;
            this.dataGridViewTextBoxColumn106.HeaderText = "GDT TX-UHF";
            this.dataGridViewTextBoxColumn106.Name = "dataGridViewTextBoxColumn106";
            this.dataGridViewTextBoxColumn106.ReadOnly = true;
            // 
            // gdtTableBindingSource
            // 
            this.gdtTableBindingSource.DataSource = typeof(RT_Viewer.Framework.GDTModule.GDTTable);
            // 
            // dnlTable_groupBox
            // 
            this.dnlTable_groupBox.Controls.Add(this.lopTable_dataGridView);
            this.dnlTable_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dnlTable_groupBox.Location = new System.Drawing.Point(971, 240);
            this.dnlTable_groupBox.Name = "dnlTable_groupBox";
            this.dnlTable_groupBox.Size = new System.Drawing.Size(275, 273);
            this.dnlTable_groupBox.TabIndex = 6;
            this.dnlTable_groupBox.TabStop = false;
            this.dnlTable_groupBox.Text = "Lop Table";
            this.dnlTable_groupBox.Enter += new System.EventHandler(this.dnlTable_groupBox_Enter);
            // 
            // lopTable_dataGridView
            // 
            this.lopTable_dataGridView.AllowUserToAddRows = false;
            this.lopTable_dataGridView.AllowUserToDeleteRows = false;
            this.lopTable_dataGridView.AutoGenerateColumns = false;
            this.lopTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lopTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn53,
            this.consoleDataGridViewTextBoxColumn,
            this.permissionDataGridViewTextBoxColumn,
            this.isselectedDataGridViewTextBoxColumn});
            this.lopTable_dataGridView.DataSource = this.lOPTableBindingSource2;
            this.lopTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lopTable_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.lopTable_dataGridView.Name = "lopTable_dataGridView";
            this.lopTable_dataGridView.ReadOnly = true;
            this.lopTable_dataGridView.RowHeadersVisible = false;
            this.lopTable_dataGridView.Size = new System.Drawing.Size(269, 254);
            this.lopTable_dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn53.DataPropertyName = "tail_number";
            this.dataGridViewTextBoxColumn53.HeaderText = "Tail";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            // 
            // consoleDataGridViewTextBoxColumn
            // 
            this.consoleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consoleDataGridViewTextBoxColumn.DataPropertyName = "console";
            this.consoleDataGridViewTextBoxColumn.HeaderText = "Console";
            this.consoleDataGridViewTextBoxColumn.Name = "consoleDataGridViewTextBoxColumn";
            this.consoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissionDataGridViewTextBoxColumn
            // 
            this.permissionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.permissionDataGridViewTextBoxColumn.DataPropertyName = "permission";
            this.permissionDataGridViewTextBoxColumn.HeaderText = "Permission";
            this.permissionDataGridViewTextBoxColumn.Name = "permissionDataGridViewTextBoxColumn";
            this.permissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isselectedDataGridViewTextBoxColumn
            // 
            this.isselectedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isselectedDataGridViewTextBoxColumn.DataPropertyName = "is_selected";
            this.isselectedDataGridViewTextBoxColumn.HeaderText = "Is Selected";
            this.isselectedDataGridViewTextBoxColumn.Name = "isselectedDataGridViewTextBoxColumn";
            this.isselectedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOPTableBindingSource2
            // 
            this.lOPTableBindingSource2.DataSource = typeof(RT_Viewer.Framework.RTIModule.LOPTable);
            // 
            // stopRecieve_button
            // 
            this.stopRecieve_button.BackColor = System.Drawing.SystemColors.Control;
            this.stopRecieve_button.Enabled = false;
            this.stopRecieve_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.stopRecieve_button.Location = new System.Drawing.Point(238, 658);
            this.stopRecieve_button.Name = "stopRecieve_button";
            this.stopRecieve_button.Size = new System.Drawing.Size(121, 27);
            this.stopRecieve_button.TabIndex = 7;
            this.stopRecieve_button.Text = "Stop Receive";
            this.stopRecieve_button.UseVisualStyleBackColor = false;
            this.stopRecieve_button.Click += new System.EventHandler(this.stopListening_Click);
            // 
            // cleanScreen_button
            // 
            this.cleanScreen_button.Enabled = false;
            this.cleanScreen_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cleanScreen_button.Location = new System.Drawing.Point(370, 658);
            this.cleanScreen_button.Name = "cleanScreen_button";
            this.cleanScreen_button.Size = new System.Drawing.Size(121, 27);
            this.cleanScreen_button.TabIndex = 8;
            this.cleanScreen_button.Text = "Clean Screen";
            this.cleanScreen_button.UseVisualStyleBackColor = true;
            this.cleanScreen_button.Click += new System.EventHandler(this.cleanData_click);
            // 
            // application_tabControl
            // 
            this.application_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.application_tabControl.Controls.Add(this.version_tabPage);
            this.application_tabControl.Controls.Add(this.rti_tabPage);
            this.application_tabControl.Controls.Add(this.uav_tabPage);
            this.application_tabControl.Controls.Add(this.ntp_tabPage);
            this.application_tabControl.Controls.Add(this.frm_tabPage);
            this.application_tabControl.Controls.Add(this.log_tabPage);
            this.application_tabControl.Controls.Add(this.stk_tabPage);
            this.application_tabControl.Controls.Add(this.ird_tabPage);
            this.application_tabControl.Controls.Add(this.nvm_tabPage);
            this.application_tabControl.Controls.Add(this.hky_tabPage);
            this.application_tabControl.Controls.Add(this.pfd_tabPage);
            this.application_tabControl.Controls.Add(this.mgc_tabPage);
            this.application_tabControl.Controls.Add(this.gdt_tabPage);
            this.application_tabControl.Controls.Add(this.tlm_tabPage);
            this.application_tabControl.Controls.Add(this.statistics_tabPage);
            this.application_tabControl.Controls.Add(this.offlineParameters_tabPage);
            this.application_tabControl.Location = new System.Drawing.Point(-12, 27);
            this.application_tabControl.MaximumSize = new System.Drawing.Size(1307, 616);
            this.application_tabControl.MinimumSize = new System.Drawing.Size(1307, 616);
            this.application_tabControl.Multiline = true;
            this.application_tabControl.Name = "application_tabControl";
            this.application_tabControl.SelectedIndex = 0;
            this.application_tabControl.Size = new System.Drawing.Size(1307, 616);
            this.application_tabControl.TabIndex = 9;
            // 
            // version_tabPage
            // 
            this.version_tabPage.Controls.Add(this.general_groupBox);
            this.version_tabPage.Controls.Add(this.versions_groupBox);
            this.version_tabPage.Location = new System.Drawing.Point(4, 22);
            this.version_tabPage.Name = "version_tabPage";
            this.version_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.version_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.version_tabPage.TabIndex = 12;
            this.version_tabPage.Text = "Versions";
            this.version_tabPage.UseVisualStyleBackColor = true;
            // 
            // general_groupBox
            // 
            this.general_groupBox.Controls.Add(this.ipRT1_textBox);
            this.general_groupBox.Controls.Add(this.rtDefualtGatway_textBox);
            this.general_groupBox.Controls.Add(this.ipRTA_label);
            this.general_groupBox.Controls.Add(this.rtDefualtGatway_label);
            this.general_groupBox.Controls.Add(this.ipRTB_label);
            this.general_groupBox.Controls.Add(this.ipRT2_textBox);
            this.general_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.general_groupBox.Location = new System.Drawing.Point(6, 343);
            this.general_groupBox.Name = "general_groupBox";
            this.general_groupBox.Size = new System.Drawing.Size(1274, 241);
            this.general_groupBox.TabIndex = 3;
            this.general_groupBox.TabStop = false;
            this.general_groupBox.Text = "General";
            // 
            // ipRT1_textBox
            // 
            this.ipRT1_textBox.Enabled = false;
            this.ipRT1_textBox.Location = new System.Drawing.Point(141, 51);
            this.ipRT1_textBox.Name = "ipRT1_textBox";
            this.ipRT1_textBox.Size = new System.Drawing.Size(195, 20);
            this.ipRT1_textBox.TabIndex = 32;
            this.ipRT1_textBox.Text = "N/A";
            // 
            // rtDefualtGatway_textBox
            // 
            this.rtDefualtGatway_textBox.Enabled = false;
            this.rtDefualtGatway_textBox.Location = new System.Drawing.Point(141, 134);
            this.rtDefualtGatway_textBox.Name = "rtDefualtGatway_textBox";
            this.rtDefualtGatway_textBox.Size = new System.Drawing.Size(195, 20);
            this.rtDefualtGatway_textBox.TabIndex = 36;
            this.rtDefualtGatway_textBox.Text = "N/A";
            // 
            // ipRTA_label
            // 
            this.ipRTA_label.AutoSize = true;
            this.ipRTA_label.Location = new System.Drawing.Point(17, 54);
            this.ipRTA_label.Name = "ipRTA_label";
            this.ipRTA_label.Size = new System.Drawing.Size(81, 13);
            this.ipRTA_label.TabIndex = 31;
            this.ipRTA_label.Text = "RT Side A IP";
            // 
            // rtDefualtGatway_label
            // 
            this.rtDefualtGatway_label.AutoSize = true;
            this.rtDefualtGatway_label.Location = new System.Drawing.Point(17, 137);
            this.rtDefualtGatway_label.Name = "rtDefualtGatway_label";
            this.rtDefualtGatway_label.Size = new System.Drawing.Size(115, 13);
            this.rtDefualtGatway_label.TabIndex = 35;
            this.rtDefualtGatway_label.Text = "RT Default Gatway";
            // 
            // ipRTB_label
            // 
            this.ipRTB_label.AutoSize = true;
            this.ipRTB_label.Location = new System.Drawing.Point(17, 95);
            this.ipRTB_label.Name = "ipRTB_label";
            this.ipRTB_label.Size = new System.Drawing.Size(81, 13);
            this.ipRTB_label.TabIndex = 33;
            this.ipRTB_label.Text = "RT Side B IP";
            // 
            // ipRT2_textBox
            // 
            this.ipRT2_textBox.Enabled = false;
            this.ipRT2_textBox.Location = new System.Drawing.Point(141, 95);
            this.ipRT2_textBox.Name = "ipRT2_textBox";
            this.ipRT2_textBox.Size = new System.Drawing.Size(195, 20);
            this.ipRT2_textBox.TabIndex = 34;
            this.ipRT2_textBox.Text = "N/A";
            // 
            // versions_groupBox
            // 
            this.versions_groupBox.Controls.Add(this.rtMode_textBox);
            this.versions_groupBox.Controls.Add(this.rtMode_label);
            this.versions_groupBox.Controls.Add(this.pictureBox1);
            this.versions_groupBox.Controls.Add(this.viewerVersion_textBox);
            this.versions_groupBox.Controls.Add(this.viewerVersion_label);
            this.versions_groupBox.Controls.Add(this.hbsVersion_textBox);
            this.versions_groupBox.Controls.Add(this.buildDate_textBox);
            this.versions_groupBox.Controls.Add(this.hbsVersion_label);
            this.versions_groupBox.Controls.Add(this.rtVersion_textBox);
            this.versions_groupBox.Controls.Add(this.rtBuildDate_label);
            this.versions_groupBox.Controls.Add(this.rtVersion_label);
            this.versions_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.versions_groupBox.Location = new System.Drawing.Point(6, 6);
            this.versions_groupBox.Name = "versions_groupBox";
            this.versions_groupBox.Size = new System.Drawing.Size(1274, 331);
            this.versions_groupBox.TabIndex = 2;
            this.versions_groupBox.TabStop = false;
            this.versions_groupBox.Text = "Versions";
            // 
            // rtMode_textBox
            // 
            this.rtMode_textBox.Enabled = false;
            this.rtMode_textBox.Location = new System.Drawing.Point(141, 228);
            this.rtMode_textBox.Name = "rtMode_textBox";
            this.rtMode_textBox.Size = new System.Drawing.Size(340, 20);
            this.rtMode_textBox.TabIndex = 39;
            this.rtMode_textBox.Text = "N/A";
            // 
            // rtMode_label
            // 
            this.rtMode_label.AutoSize = true;
            this.rtMode_label.Location = new System.Drawing.Point(22, 231);
            this.rtMode_label.Name = "rtMode_label";
            this.rtMode_label.Size = new System.Drawing.Size(59, 13);
            this.rtMode_label.TabIndex = 38;
            this.rtMode_label.Text = "RT Mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::RT_Viewer.Properties.Resources.ElbitLogo;
            this.pictureBox1.Location = new System.Drawing.Point(927, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // viewerVersion_textBox
            // 
            this.viewerVersion_textBox.Enabled = false;
            this.viewerVersion_textBox.Location = new System.Drawing.Point(141, 185);
            this.viewerVersion_textBox.Name = "viewerVersion_textBox";
            this.viewerVersion_textBox.Size = new System.Drawing.Size(340, 20);
            this.viewerVersion_textBox.TabIndex = 30;
            this.viewerVersion_textBox.Text = "N/A";
            // 
            // viewerVersion_label
            // 
            this.viewerVersion_label.AutoSize = true;
            this.viewerVersion_label.Location = new System.Drawing.Point(20, 188);
            this.viewerVersion_label.Name = "viewerVersion_label";
            this.viewerVersion_label.Size = new System.Drawing.Size(112, 13);
            this.viewerVersion_label.TabIndex = 29;
            this.viewerVersion_label.Text = "RT Viewer Version";
            // 
            // hbsVersion_textBox
            // 
            this.hbsVersion_textBox.Enabled = false;
            this.hbsVersion_textBox.Location = new System.Drawing.Point(141, 140);
            this.hbsVersion_textBox.Name = "hbsVersion_textBox";
            this.hbsVersion_textBox.Size = new System.Drawing.Size(340, 20);
            this.hbsVersion_textBox.TabIndex = 28;
            this.hbsVersion_textBox.Text = "N/A";
            // 
            // buildDate_textBox
            // 
            this.buildDate_textBox.Enabled = false;
            this.buildDate_textBox.Location = new System.Drawing.Point(141, 97);
            this.buildDate_textBox.Name = "buildDate_textBox";
            this.buildDate_textBox.Size = new System.Drawing.Size(340, 20);
            this.buildDate_textBox.TabIndex = 22;
            this.buildDate_textBox.Text = "N/A";
            // 
            // hbsVersion_label
            // 
            this.hbsVersion_label.AutoSize = true;
            this.hbsVersion_label.Location = new System.Drawing.Point(20, 143);
            this.hbsVersion_label.Name = "hbsVersion_label";
            this.hbsVersion_label.Size = new System.Drawing.Size(78, 13);
            this.hbsVersion_label.TabIndex = 27;
            this.hbsVersion_label.Text = "HBS Version";
            // 
            // rtVersion_textBox
            // 
            this.rtVersion_textBox.Enabled = false;
            this.rtVersion_textBox.Location = new System.Drawing.Point(141, 50);
            this.rtVersion_textBox.Name = "rtVersion_textBox";
            this.rtVersion_textBox.Size = new System.Drawing.Size(340, 20);
            this.rtVersion_textBox.TabIndex = 21;
            this.rtVersion_textBox.Text = "N/A";
            // 
            // rtBuildDate_label
            // 
            this.rtBuildDate_label.AutoSize = true;
            this.rtBuildDate_label.Location = new System.Drawing.Point(20, 100);
            this.rtBuildDate_label.Name = "rtBuildDate_label";
            this.rtBuildDate_label.Size = new System.Drawing.Size(87, 13);
            this.rtBuildDate_label.TabIndex = 24;
            this.rtBuildDate_label.Text = "RT Build Date";
            // 
            // rtVersion_label
            // 
            this.rtVersion_label.AutoSize = true;
            this.rtVersion_label.Location = new System.Drawing.Point(20, 57);
            this.rtVersion_label.Name = "rtVersion_label";
            this.rtVersion_label.Size = new System.Drawing.Size(70, 13);
            this.rtVersion_label.TabIndex = 23;
            this.rtVersion_label.Text = "RT Version";
            // 
            // rti_tabPage
            // 
            this.rti_tabPage.Controls.Add(this.lopCounter_textBox);
            this.rti_tabPage.Controls.Add(this.lopCounter_label);
            this.rti_tabPage.Controls.Add(this.groupBox14);
            this.rti_tabPage.Controls.Add(this.groupBox13);
            this.rti_tabPage.Controls.Add(this.nvramReadData_groupBox);
            this.rti_tabPage.Controls.Add(this.uplTable_groupBox);
            this.rti_tabPage.Controls.Add(this.dnlTable_groupBox);
            this.rti_tabPage.Location = new System.Drawing.Point(4, 22);
            this.rti_tabPage.Name = "rti_tabPage";
            this.rti_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rti_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.rti_tabPage.TabIndex = 0;
            this.rti_tabPage.Text = "RTI";
            this.rti_tabPage.UseVisualStyleBackColor = true;
            this.rti_tabPage.Click += new System.EventHandler(this.rti_tabPage_Click);
            // 
            // lopCounter_textBox
            // 
            this.lopCounter_textBox.Enabled = false;
            this.lopCounter_textBox.Location = new System.Drawing.Point(1019, 519);
            this.lopCounter_textBox.Name = "lopCounter_textBox";
            this.lopCounter_textBox.Size = new System.Drawing.Size(100, 20);
            this.lopCounter_textBox.TabIndex = 10;
            this.lopCounter_textBox.Text = "0";
            // 
            // lopCounter_label
            // 
            this.lopCounter_label.AutoSize = true;
            this.lopCounter_label.Location = new System.Drawing.Point(985, 522);
            this.lopCounter_label.Name = "lopCounter_label";
            this.lopCounter_label.Size = new System.Drawing.Size(28, 13);
            this.lopCounter_label.TabIndex = 11;
            this.lopCounter_label.Text = "LOP";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.uavRtiTable_dataGridView);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox14.Location = new System.Drawing.Point(6, 389);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(959, 152);
            this.groupBox14.TabIndex = 10;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "UAV - RT Table";
            // 
            // uavRtiTable_dataGridView
            // 
            this.uavRtiTable_dataGridView.AllowUserToAddRows = false;
            this.uavRtiTable_dataGridView.AllowUserToDeleteRows = false;
            this.uavRtiTable_dataGridView.AutoGenerateColumns = false;
            this.uavRtiTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uavRtiTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn52});
            this.uavRtiTable_dataGridView.DataSource = this.rTEntryBindingSource;
            this.uavRtiTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uavRtiTable_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.uavRtiTable_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.uavRtiTable_dataGridView.Name = "uavRtiTable_dataGridView";
            this.uavRtiTable_dataGridView.ReadOnly = true;
            this.uavRtiTable_dataGridView.RowHeadersVisible = false;
            this.uavRtiTable_dataGridView.Size = new System.Drawing.Size(953, 133);
            this.uavRtiTable_dataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn30.DataPropertyName = "tail_number";
            this.dataGridViewTextBoxColumn30.FillWeight = 40F;
            this.dataGridViewTextBoxColumn30.HeaderText = "Tail";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn31.DataPropertyName = "gcs_extra";
            this.dataGridViewTextBoxColumn31.HeaderText = "GCS Extra";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn32.DataPropertyName = "uplinkID1";
            this.dataGridViewTextBoxColumn32.HeaderText = "CBAND";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn33.DataPropertyName = "uplinkID2";
            this.dataGridViewTextBoxColumn33.HeaderText = "UHF";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn34.DataPropertyName = "uplinkID3";
            this.dataGridViewTextBoxColumn34.HeaderText = "SATCOM1";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn35.DataPropertyName = "uplinkID4";
            this.dataGridViewTextBoxColumn35.HeaderText = "SATCOM2";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn36.DataPropertyName = "uplinkID5";
            this.dataGridViewTextBoxColumn36.HeaderText = "IRIDIUM";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn37.DataPropertyName = "uplinkID6";
            this.dataGridViewTextBoxColumn37.HeaderText = "MOBILCOM";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn38.DataPropertyName = "uplinkID7";
            this.dataGridViewTextBoxColumn38.FillWeight = 50F;
            this.dataGridViewTextBoxColumn38.HeaderText = "CH7";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn39.DataPropertyName = "uplinkID8";
            this.dataGridViewTextBoxColumn39.FillWeight = 50F;
            this.dataGridViewTextBoxColumn39.HeaderText = "CH8";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn40.DataPropertyName = "uplinkID9";
            this.dataGridViewTextBoxColumn40.FillWeight = 50F;
            this.dataGridViewTextBoxColumn40.HeaderText = "CH9";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn52.DataPropertyName = "uplinkID10";
            this.dataGridViewTextBoxColumn52.FillWeight = 50F;
            this.dataGridViewTextBoxColumn52.HeaderText = "CH10";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            // 
            // rTEntryBindingSource
            // 
            this.rTEntryBindingSource.DataSource = typeof(RT_Viewer.Framework.RTIModule.RTEntry);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.hstTable_dataGridView);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox13.Location = new System.Drawing.Point(3, 240);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(962, 146);
            this.groupBox13.TabIndex = 9;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "HST- RT Table";
            // 
            // hstTable_dataGridView
            // 
            this.hstTable_dataGridView.AllowUserToAddRows = false;
            this.hstTable_dataGridView.AllowUserToDeleteRows = false;
            this.hstTable_dataGridView.AutoGenerateColumns = false;
            this.hstTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hstTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn51,
            this.gcsextraDataGridViewTextBoxColumn,
            this.uplinkID1DataGridViewTextBoxColumn,
            this.uplinkID2DataGridViewTextBoxColumn,
            this.uplinkID3DataGridViewTextBoxColumn,
            this.uplinkID4DataGridViewTextBoxColumn,
            this.uplinkID5DataGridViewTextBoxColumn,
            this.uplinkID6DataGridViewTextBoxColumn,
            this.uplinkID7DataGridViewTextBoxColumn,
            this.uplinkID8DataGridViewTextBoxColumn,
            this.uplinkID9DataGridViewTextBoxColumn,
            this.uplinkID10DataGridViewTextBoxColumn});
            this.hstTable_dataGridView.DataSource = this.rTEntryBindingSource;
            this.hstTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hstTable_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.hstTable_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.hstTable_dataGridView.Name = "hstTable_dataGridView";
            this.hstTable_dataGridView.ReadOnly = true;
            this.hstTable_dataGridView.RowHeadersVisible = false;
            this.hstTable_dataGridView.Size = new System.Drawing.Size(956, 127);
            this.hstTable_dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn51.DataPropertyName = "tail_number";
            this.dataGridViewTextBoxColumn51.FillWeight = 40F;
            this.dataGridViewTextBoxColumn51.HeaderText = "Tail";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            // 
            // gcsextraDataGridViewTextBoxColumn
            // 
            this.gcsextraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcsextraDataGridViewTextBoxColumn.DataPropertyName = "gcs_extra";
            this.gcsextraDataGridViewTextBoxColumn.HeaderText = "GCS Extra";
            this.gcsextraDataGridViewTextBoxColumn.Name = "gcsextraDataGridViewTextBoxColumn";
            this.gcsextraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID1DataGridViewTextBoxColumn
            // 
            this.uplinkID1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID1DataGridViewTextBoxColumn.DataPropertyName = "uplinkID1";
            this.uplinkID1DataGridViewTextBoxColumn.HeaderText = "CBAND";
            this.uplinkID1DataGridViewTextBoxColumn.Name = "uplinkID1DataGridViewTextBoxColumn";
            this.uplinkID1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID2DataGridViewTextBoxColumn
            // 
            this.uplinkID2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID2DataGridViewTextBoxColumn.DataPropertyName = "uplinkID2";
            this.uplinkID2DataGridViewTextBoxColumn.HeaderText = "UHF";
            this.uplinkID2DataGridViewTextBoxColumn.Name = "uplinkID2DataGridViewTextBoxColumn";
            this.uplinkID2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID3DataGridViewTextBoxColumn
            // 
            this.uplinkID3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID3DataGridViewTextBoxColumn.DataPropertyName = "uplinkID3";
            this.uplinkID3DataGridViewTextBoxColumn.HeaderText = "SATCOM1";
            this.uplinkID3DataGridViewTextBoxColumn.Name = "uplinkID3DataGridViewTextBoxColumn";
            this.uplinkID3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID4DataGridViewTextBoxColumn
            // 
            this.uplinkID4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID4DataGridViewTextBoxColumn.DataPropertyName = "uplinkID4";
            this.uplinkID4DataGridViewTextBoxColumn.HeaderText = "SATCOM2";
            this.uplinkID4DataGridViewTextBoxColumn.Name = "uplinkID4DataGridViewTextBoxColumn";
            this.uplinkID4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID5DataGridViewTextBoxColumn
            // 
            this.uplinkID5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID5DataGridViewTextBoxColumn.DataPropertyName = "uplinkID5";
            this.uplinkID5DataGridViewTextBoxColumn.HeaderText = "IRIDIUM";
            this.uplinkID5DataGridViewTextBoxColumn.Name = "uplinkID5DataGridViewTextBoxColumn";
            this.uplinkID5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID6DataGridViewTextBoxColumn
            // 
            this.uplinkID6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID6DataGridViewTextBoxColumn.DataPropertyName = "uplinkID6";
            this.uplinkID6DataGridViewTextBoxColumn.HeaderText = "MOBILCOM";
            this.uplinkID6DataGridViewTextBoxColumn.Name = "uplinkID6DataGridViewTextBoxColumn";
            this.uplinkID6DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID7DataGridViewTextBoxColumn
            // 
            this.uplinkID7DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID7DataGridViewTextBoxColumn.DataPropertyName = "uplinkID7";
            this.uplinkID7DataGridViewTextBoxColumn.FillWeight = 50F;
            this.uplinkID7DataGridViewTextBoxColumn.HeaderText = "CH7";
            this.uplinkID7DataGridViewTextBoxColumn.Name = "uplinkID7DataGridViewTextBoxColumn";
            this.uplinkID7DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID8DataGridViewTextBoxColumn
            // 
            this.uplinkID8DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID8DataGridViewTextBoxColumn.DataPropertyName = "uplinkID8";
            this.uplinkID8DataGridViewTextBoxColumn.FillWeight = 50F;
            this.uplinkID8DataGridViewTextBoxColumn.HeaderText = "CH8";
            this.uplinkID8DataGridViewTextBoxColumn.Name = "uplinkID8DataGridViewTextBoxColumn";
            this.uplinkID8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID9DataGridViewTextBoxColumn
            // 
            this.uplinkID9DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID9DataGridViewTextBoxColumn.DataPropertyName = "uplinkID9";
            this.uplinkID9DataGridViewTextBoxColumn.FillWeight = 50F;
            this.uplinkID9DataGridViewTextBoxColumn.HeaderText = "CH9";
            this.uplinkID9DataGridViewTextBoxColumn.Name = "uplinkID9DataGridViewTextBoxColumn";
            this.uplinkID9DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplinkID10DataGridViewTextBoxColumn
            // 
            this.uplinkID10DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uplinkID10DataGridViewTextBoxColumn.DataPropertyName = "uplinkID10";
            this.uplinkID10DataGridViewTextBoxColumn.FillWeight = 50F;
            this.uplinkID10DataGridViewTextBoxColumn.HeaderText = "CH10";
            this.uplinkID10DataGridViewTextBoxColumn.Name = "uplinkID10DataGridViewTextBoxColumn";
            this.uplinkID10DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nvramReadData_groupBox
            // 
            this.nvramReadData_groupBox.Controls.Add(this.transactionMode_textBox);
            this.nvramReadData_groupBox.Controls.Add(this.mainRTCounter_lable);
            this.nvramReadData_groupBox.Controls.Add(this.mainRTCounter_textBox);
            this.nvramReadData_groupBox.Controls.Add(this.uavCounter_lable);
            this.nvramReadData_groupBox.Controls.Add(this.uavCounter_textBox);
            this.nvramReadData_groupBox.Controls.Add(this.transactionMode_lable);
            this.nvramReadData_groupBox.Controls.Add(this.hstCounter_lable);
            this.nvramReadData_groupBox.Controls.Add(this.hstCounter_textBox);
            this.nvramReadData_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvramReadData_groupBox.Location = new System.Drawing.Point(6, 547);
            this.nvramReadData_groupBox.Name = "nvramReadData_groupBox";
            this.nvramReadData_groupBox.Size = new System.Drawing.Size(1287, 40);
            this.nvramReadData_groupBox.TabIndex = 7;
            this.nvramReadData_groupBox.TabStop = false;
            this.nvramReadData_groupBox.Text = "Messages";
            this.nvramReadData_groupBox.Enter += new System.EventHandler(this.nvramReadData_groupBox_Enter);
            // 
            // transactionMode_textBox
            // 
            this.transactionMode_textBox.Enabled = false;
            this.transactionMode_textBox.Location = new System.Drawing.Point(631, 14);
            this.transactionMode_textBox.Name = "transactionMode_textBox";
            this.transactionMode_textBox.Size = new System.Drawing.Size(190, 20);
            this.transactionMode_textBox.TabIndex = 15;
            this.transactionMode_textBox.Text = "N\\A";
            // 
            // mainRTCounter_lable
            // 
            this.mainRTCounter_lable.AutoSize = true;
            this.mainRTCounter_lable.Location = new System.Drawing.Point(349, 17);
            this.mainRTCounter_lable.Name = "mainRTCounter_lable";
            this.mainRTCounter_lable.Size = new System.Drawing.Size(48, 13);
            this.mainRTCounter_lable.TabIndex = 14;
            this.mainRTCounter_lable.Text = "Main-RT";
            // 
            // mainRTCounter_textBox
            // 
            this.mainRTCounter_textBox.Enabled = false;
            this.mainRTCounter_textBox.Location = new System.Drawing.Point(408, 14);
            this.mainRTCounter_textBox.Name = "mainRTCounter_textBox";
            this.mainRTCounter_textBox.Size = new System.Drawing.Size(100, 20);
            this.mainRTCounter_textBox.TabIndex = 13;
            this.mainRTCounter_textBox.Text = "0";
            // 
            // uavCounter_lable
            // 
            this.uavCounter_lable.AutoSize = true;
            this.uavCounter_lable.Location = new System.Drawing.Point(169, 17);
            this.uavCounter_lable.Name = "uavCounter_lable";
            this.uavCounter_lable.Size = new System.Drawing.Size(47, 13);
            this.uavCounter_lable.TabIndex = 12;
            this.uavCounter_lable.Text = "UAV-RT";
            // 
            // uavCounter_textBox
            // 
            this.uavCounter_textBox.Enabled = false;
            this.uavCounter_textBox.Location = new System.Drawing.Point(222, 13);
            this.uavCounter_textBox.Name = "uavCounter_textBox";
            this.uavCounter_textBox.Size = new System.Drawing.Size(100, 20);
            this.uavCounter_textBox.TabIndex = 11;
            this.uavCounter_textBox.Text = "0";
            // 
            // transactionMode_lable
            // 
            this.transactionMode_lable.AutoSize = true;
            this.transactionMode_lable.Location = new System.Drawing.Point(532, 17);
            this.transactionMode_lable.Name = "transactionMode_lable";
            this.transactionMode_lable.Size = new System.Drawing.Size(93, 13);
            this.transactionMode_lable.TabIndex = 10;
            this.transactionMode_lable.Text = "Transaction Mode";
            // 
            // hstCounter_lable
            // 
            this.hstCounter_lable.AutoSize = true;
            this.hstCounter_lable.Location = new System.Drawing.Point(6, 17);
            this.hstCounter_lable.Name = "hstCounter_lable";
            this.hstCounter_lable.Size = new System.Drawing.Size(47, 13);
            this.hstCounter_lable.TabIndex = 9;
            this.hstCounter_lable.Text = "HST-RT";
            // 
            // hstCounter_textBox
            // 
            this.hstCounter_textBox.Enabled = false;
            this.hstCounter_textBox.Location = new System.Drawing.Point(59, 14);
            this.hstCounter_textBox.Name = "hstCounter_textBox";
            this.hstCounter_textBox.Size = new System.Drawing.Size(100, 20);
            this.hstCounter_textBox.TabIndex = 8;
            this.hstCounter_textBox.Text = "0";
            this.hstCounter_textBox.TextChanged += new System.EventHandler(this.rtiCounter_texBox_TextChanged);
            // 
            // uav_tabPage
            // 
            this.uav_tabPage.Controls.Add(this.dnlinkTable_groupBox);
            this.uav_tabPage.Location = new System.Drawing.Point(4, 22);
            this.uav_tabPage.Name = "uav_tabPage";
            this.uav_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.uav_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.uav_tabPage.TabIndex = 1;
            this.uav_tabPage.Text = "UAV";
            this.uav_tabPage.UseVisualStyleBackColor = true;
            // 
            // dnlinkTable_groupBox
            // 
            this.dnlinkTable_groupBox.Controls.Add(this.uavTable_dataGridView);
            this.dnlinkTable_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dnlinkTable_groupBox.Location = new System.Drawing.Point(3, 6);
            this.dnlinkTable_groupBox.Name = "dnlinkTable_groupBox";
            this.dnlinkTable_groupBox.Size = new System.Drawing.Size(1254, 334);
            this.dnlinkTable_groupBox.TabIndex = 4;
            this.dnlinkTable_groupBox.TabStop = false;
            this.dnlinkTable_groupBox.Text = "Dnlink Table";
            // 
            // uavTable_dataGridView
            // 
            this.uavTable_dataGridView.AllowUserToAddRows = false;
            this.uavTable_dataGridView.AllowUserToDeleteRows = false;
            this.uavTable_dataGridView.AutoGenerateColumns = false;
            this.uavTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uavTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tailnumberDataGridViewTextBoxColumn4,
            this.cBANDCOUNTERDataGridViewTextBoxColumn,
            this.cBANDDataGridViewTextBoxColumn1,
            this.uHFDataGridViewTextBoxColumn1,
            this.sATCOMDataGridViewTextBoxColumn,
            this.cH4DataGridViewTextBoxColumn,
            this.cH5DataGridViewTextBoxColumn,
            this.cH6DataGridViewTextBoxColumn,
            this.cH7DataGridViewTextBoxColumn1,
            this.cH8DataGridViewTextBoxColumn1,
            this.cH9DataGridViewTextBoxColumn1,
            this.cH10DataGridViewTextBoxColumn1});
            this.uavTable_dataGridView.DataSource = this.dNLTableBindingSource5;
            this.uavTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uavTable_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.uavTable_dataGridView.Name = "uavTable_dataGridView";
            this.uavTable_dataGridView.ReadOnly = true;
            this.uavTable_dataGridView.RowHeadersVisible = false;
            this.uavTable_dataGridView.Size = new System.Drawing.Size(1248, 315);
            this.uavTable_dataGridView.TabIndex = 0;
            this.uavTable_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uavTable_dataGridView_CellContentClick);
            // 
            // tailnumberDataGridViewTextBoxColumn4
            // 
            this.tailnumberDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tailnumberDataGridViewTextBoxColumn4.DataPropertyName = "tail_number";
            this.tailnumberDataGridViewTextBoxColumn4.FillWeight = 50F;
            this.tailnumberDataGridViewTextBoxColumn4.HeaderText = "Tail";
            this.tailnumberDataGridViewTextBoxColumn4.Name = "tailnumberDataGridViewTextBoxColumn4";
            this.tailnumberDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cBANDCOUNTERDataGridViewTextBoxColumn
            // 
            this.cBANDCOUNTERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cBANDCOUNTERDataGridViewTextBoxColumn.DataPropertyName = "CBAND_COUNTER";
            this.cBANDCOUNTERDataGridViewTextBoxColumn.FillWeight = 50F;
            this.cBANDCOUNTERDataGridViewTextBoxColumn.HeaderText = "CNTR";
            this.cBANDCOUNTERDataGridViewTextBoxColumn.Name = "cBANDCOUNTERDataGridViewTextBoxColumn";
            this.cBANDCOUNTERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cBANDDataGridViewTextBoxColumn1
            // 
            this.cBANDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cBANDDataGridViewTextBoxColumn1.DataPropertyName = "CBAND";
            this.cBANDDataGridViewTextBoxColumn1.HeaderText = "CBAND";
            this.cBANDDataGridViewTextBoxColumn1.Name = "cBANDDataGridViewTextBoxColumn1";
            this.cBANDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // uHFDataGridViewTextBoxColumn1
            // 
            this.uHFDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uHFDataGridViewTextBoxColumn1.DataPropertyName = "UHF";
            this.uHFDataGridViewTextBoxColumn1.HeaderText = "UHF";
            this.uHFDataGridViewTextBoxColumn1.Name = "uHFDataGridViewTextBoxColumn1";
            this.uHFDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sATCOMDataGridViewTextBoxColumn
            // 
            this.sATCOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sATCOMDataGridViewTextBoxColumn.DataPropertyName = "SATCOM";
            this.sATCOMDataGridViewTextBoxColumn.HeaderText = "SATCOM";
            this.sATCOMDataGridViewTextBoxColumn.Name = "sATCOMDataGridViewTextBoxColumn";
            this.sATCOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cH4DataGridViewTextBoxColumn
            // 
            this.cH4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cH4DataGridViewTextBoxColumn.DataPropertyName = "CH_4";
            this.cH4DataGridViewTextBoxColumn.FillWeight = 50F;
            this.cH4DataGridViewTextBoxColumn.HeaderText = "CH_4";
            this.cH4DataGridViewTextBoxColumn.Name = "cH4DataGridViewTextBoxColumn";
            this.cH4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cH5DataGridViewTextBoxColumn
            // 
            this.cH5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cH5DataGridViewTextBoxColumn.DataPropertyName = "CH_5";
            this.cH5DataGridViewTextBoxColumn.FillWeight = 50F;
            this.cH5DataGridViewTextBoxColumn.HeaderText = "CH_5";
            this.cH5DataGridViewTextBoxColumn.Name = "cH5DataGridViewTextBoxColumn";
            this.cH5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cH6DataGridViewTextBoxColumn
            // 
            this.cH6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cH6DataGridViewTextBoxColumn.DataPropertyName = "CH_6";
            this.cH6DataGridViewTextBoxColumn.FillWeight = 50F;
            this.cH6DataGridViewTextBoxColumn.HeaderText = "CH_6";
            this.cH6DataGridViewTextBoxColumn.Name = "cH6DataGridViewTextBoxColumn";
            this.cH6DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cH7DataGridViewTextBoxColumn1
            // 
            this.cH7DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cH7DataGridViewTextBoxColumn1.DataPropertyName = "CH_7";
            this.cH7DataGridViewTextBoxColumn1.FillWeight = 50F;
            this.cH7DataGridViewTextBoxColumn1.HeaderText = "CH_7";
            this.cH7DataGridViewTextBoxColumn1.Name = "cH7DataGridViewTextBoxColumn1";
            this.cH7DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cH8DataGridViewTextBoxColumn1
            // 
            this.cH8DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cH8DataGridViewTextBoxColumn1.DataPropertyName = "CH_8";
            this.cH8DataGridViewTextBoxColumn1.FillWeight = 50F;
            this.cH8DataGridViewTextBoxColumn1.HeaderText = "CH_8";
            this.cH8DataGridViewTextBoxColumn1.Name = "cH8DataGridViewTextBoxColumn1";
            this.cH8DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cH9DataGridViewTextBoxColumn1
            // 
            this.cH9DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cH9DataGridViewTextBoxColumn1.DataPropertyName = "CH_9";
            this.cH9DataGridViewTextBoxColumn1.FillWeight = 50F;
            this.cH9DataGridViewTextBoxColumn1.HeaderText = "CH_9";
            this.cH9DataGridViewTextBoxColumn1.Name = "cH9DataGridViewTextBoxColumn1";
            this.cH9DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cH10DataGridViewTextBoxColumn1
            // 
            this.cH10DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cH10DataGridViewTextBoxColumn1.DataPropertyName = "CH_10";
            this.cH10DataGridViewTextBoxColumn1.FillWeight = 50F;
            this.cH10DataGridViewTextBoxColumn1.HeaderText = "CH_10";
            this.cH10DataGridViewTextBoxColumn1.Name = "cH10DataGridViewTextBoxColumn1";
            this.cH10DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dNLTableBindingSource5
            // 
            this.dNLTableBindingSource5.DataSource = typeof(RT_Viewer.Framework.UAVModule.DNLTable);
            // 
            // ntp_tabPage
            // 
            this.ntp_tabPage.Controls.Add(this.convertTimeStamp_groupBox);
            this.ntp_tabPage.Controls.Add(this.ntpInfo_groupBox);
            this.ntp_tabPage.Location = new System.Drawing.Point(4, 22);
            this.ntp_tabPage.Name = "ntp_tabPage";
            this.ntp_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ntp_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.ntp_tabPage.TabIndex = 2;
            this.ntp_tabPage.Text = "NTP";
            this.ntp_tabPage.UseVisualStyleBackColor = true;
            // 
            // convertTimeStamp_groupBox
            // 
            this.convertTimeStamp_groupBox.Controls.Add(this.copyTimeStamp_button);
            this.convertTimeStamp_groupBox.Controls.Add(this.label1);
            this.convertTimeStamp_groupBox.Controls.Add(this.convertTimeStamp_button);
            this.convertTimeStamp_groupBox.Controls.Add(this.utcConvert_textBox);
            this.convertTimeStamp_groupBox.Controls.Add(this.timestampConvert_textBox);
            this.convertTimeStamp_groupBox.Controls.Add(this.utcConvert_label);
            this.convertTimeStamp_groupBox.Controls.Add(this.timestampConvert_label);
            this.convertTimeStamp_groupBox.Location = new System.Drawing.Point(6, 252);
            this.convertTimeStamp_groupBox.Name = "convertTimeStamp_groupBox";
            this.convertTimeStamp_groupBox.Size = new System.Drawing.Size(1240, 332);
            this.convertTimeStamp_groupBox.TabIndex = 1;
            this.convertTimeStamp_groupBox.TabStop = false;
            this.convertTimeStamp_groupBox.Text = "Convert Timestamp To UTC";
            // 
            // copyTimeStamp_button
            // 
            this.copyTimeStamp_button.Location = new System.Drawing.Point(232, 75);
            this.copyTimeStamp_button.Name = "copyTimeStamp_button";
            this.copyTimeStamp_button.Size = new System.Drawing.Size(103, 26);
            this.copyTimeStamp_button.TabIndex = 7;
            this.copyTimeStamp_button.Text = "Copy Timestamp";
            this.copyTimeStamp_button.UseVisualStyleBackColor = true;
            this.copyTimeStamp_button.Click += new System.EventHandler(this.copyTimestamp_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Note: The timestamp input is the milisecond passed since 1/1/2000";
            // 
            // convertTimeStamp_button
            // 
            this.convertTimeStamp_button.Location = new System.Drawing.Point(111, 162);
            this.convertTimeStamp_button.Name = "convertTimeStamp_button";
            this.convertTimeStamp_button.Size = new System.Drawing.Size(103, 26);
            this.convertTimeStamp_button.TabIndex = 8;
            this.convertTimeStamp_button.Text = "Convert";
            this.convertTimeStamp_button.UseVisualStyleBackColor = true;
            this.convertTimeStamp_button.Click += new System.EventHandler(this.convertTimeStamp_button_Click);
            // 
            // utcConvert_textBox
            // 
            this.utcConvert_textBox.Location = new System.Drawing.Point(114, 119);
            this.utcConvert_textBox.Name = "utcConvert_textBox";
            this.utcConvert_textBox.ReadOnly = true;
            this.utcConvert_textBox.Size = new System.Drawing.Size(169, 20);
            this.utcConvert_textBox.TabIndex = 6;
            // 
            // timestampConvert_textBox
            // 
            this.timestampConvert_textBox.Location = new System.Drawing.Point(114, 79);
            this.timestampConvert_textBox.Name = "timestampConvert_textBox";
            this.timestampConvert_textBox.Size = new System.Drawing.Size(100, 20);
            this.timestampConvert_textBox.TabIndex = 5;
            // 
            // utcConvert_label
            // 
            this.utcConvert_label.AutoSize = true;
            this.utcConvert_label.Location = new System.Drawing.Point(27, 122);
            this.utcConvert_label.Name = "utcConvert_label";
            this.utcConvert_label.Size = new System.Drawing.Size(29, 13);
            this.utcConvert_label.TabIndex = 4;
            this.utcConvert_label.Text = "UTC";
            // 
            // timestampConvert_label
            // 
            this.timestampConvert_label.AutoSize = true;
            this.timestampConvert_label.Location = new System.Drawing.Point(27, 82);
            this.timestampConvert_label.Name = "timestampConvert_label";
            this.timestampConvert_label.Size = new System.Drawing.Size(80, 13);
            this.timestampConvert_label.TabIndex = 3;
            this.timestampConvert_label.Text = "Timestamp (ms)";
            // 
            // ntpInfo_groupBox
            // 
            this.ntpInfo_groupBox.Controls.Add(this.NtpServerIp_label);
            this.ntpInfo_groupBox.Controls.Add(this.ntpServerIP_textBox);
            this.ntpInfo_groupBox.Controls.Add(this.ntpServerConnection_textBox);
            this.ntpInfo_groupBox.Controls.Add(this.ntpServerConnection_pictureBox);
            this.ntpInfo_groupBox.Controls.Add(this.ntpServerConnection_label);
            this.ntpInfo_groupBox.Controls.Add(this.utc_label);
            this.ntpInfo_groupBox.Controls.Add(this.timeStamp_label);
            this.ntpInfo_groupBox.Controls.Add(this.utc_textBox);
            this.ntpInfo_groupBox.Controls.Add(this.timeStamp_textBox);
            this.ntpInfo_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntpInfo_groupBox.Location = new System.Drawing.Point(6, 6);
            this.ntpInfo_groupBox.Name = "ntpInfo_groupBox";
            this.ntpInfo_groupBox.Size = new System.Drawing.Size(1240, 240);
            this.ntpInfo_groupBox.TabIndex = 0;
            this.ntpInfo_groupBox.TabStop = false;
            this.ntpInfo_groupBox.Text = "NTP Information";
            this.ntpInfo_groupBox.Enter += new System.EventHandler(this.ntpGroupBox_Enter);
            // 
            // NtpServerIp_label
            // 
            this.NtpServerIp_label.AutoSize = true;
            this.NtpServerIp_label.Location = new System.Drawing.Point(240, 175);
            this.NtpServerIp_label.Name = "NtpServerIp_label";
            this.NtpServerIp_label.Size = new System.Drawing.Size(76, 13);
            this.NtpServerIp_label.TabIndex = 8;
            this.NtpServerIp_label.Text = "NTP Server IP";
            // 
            // ntpServerIP_textBox
            // 
            this.ntpServerIP_textBox.Location = new System.Drawing.Point(334, 172);
            this.ntpServerIP_textBox.Name = "ntpServerIP_textBox";
            this.ntpServerIP_textBox.ReadOnly = true;
            this.ntpServerIP_textBox.Size = new System.Drawing.Size(100, 20);
            this.ntpServerIP_textBox.TabIndex = 7;
            // 
            // ntpServerConnection_textBox
            // 
            this.ntpServerConnection_textBox.Location = new System.Drawing.Point(114, 172);
            this.ntpServerConnection_textBox.Name = "ntpServerConnection_textBox";
            this.ntpServerConnection_textBox.ReadOnly = true;
            this.ntpServerConnection_textBox.Size = new System.Drawing.Size(100, 20);
            this.ntpServerConnection_textBox.TabIndex = 6;
            this.ntpServerConnection_textBox.Text = "Disconnected";
            // 
            // ntpServerConnection_pictureBox
            // 
            this.ntpServerConnection_pictureBox.Image = global::RT_Viewer.Properties.Resources.redLed;
            this.ntpServerConnection_pictureBox.InitialImage = global::RT_Viewer.Properties.Resources.redLed;
            this.ntpServerConnection_pictureBox.Location = new System.Drawing.Point(91, 172);
            this.ntpServerConnection_pictureBox.Name = "ntpServerConnection_pictureBox";
            this.ntpServerConnection_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.ntpServerConnection_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ntpServerConnection_pictureBox.TabIndex = 5;
            this.ntpServerConnection_pictureBox.TabStop = false;
            // 
            // ntpServerConnection_label
            // 
            this.ntpServerConnection_label.AutoSize = true;
            this.ntpServerConnection_label.Location = new System.Drawing.Point(22, 175);
            this.ntpServerConnection_label.Name = "ntpServerConnection_label";
            this.ntpServerConnection_label.Size = new System.Drawing.Size(63, 13);
            this.ntpServerConnection_label.TabIndex = 4;
            this.ntpServerConnection_label.Text = "NTP Server";
            // 
            // utc_label
            // 
            this.utc_label.AutoSize = true;
            this.utc_label.Location = new System.Drawing.Point(22, 117);
            this.utc_label.Name = "utc_label";
            this.utc_label.Size = new System.Drawing.Size(29, 13);
            this.utc_label.TabIndex = 3;
            this.utc_label.Text = "UTC";
            // 
            // timeStamp_label
            // 
            this.timeStamp_label.AutoSize = true;
            this.timeStamp_label.Location = new System.Drawing.Point(22, 58);
            this.timeStamp_label.Name = "timeStamp_label";
            this.timeStamp_label.Size = new System.Drawing.Size(58, 13);
            this.timeStamp_label.TabIndex = 2;
            this.timeStamp_label.Text = "Timestamp";
            // 
            // utc_textBox
            // 
            this.utc_textBox.Location = new System.Drawing.Point(114, 114);
            this.utc_textBox.Name = "utc_textBox";
            this.utc_textBox.ReadOnly = true;
            this.utc_textBox.Size = new System.Drawing.Size(169, 20);
            this.utc_textBox.TabIndex = 1;
            this.utc_textBox.Text = "N/A";
            // 
            // timeStamp_textBox
            // 
            this.timeStamp_textBox.Location = new System.Drawing.Point(114, 58);
            this.timeStamp_textBox.Name = "timeStamp_textBox";
            this.timeStamp_textBox.ReadOnly = true;
            this.timeStamp_textBox.Size = new System.Drawing.Size(100, 20);
            this.timeStamp_textBox.TabIndex = 0;
            this.timeStamp_textBox.Text = "N/A";
            // 
            // frm_tabPage
            // 
            this.frm_tabPage.Controls.Add(this.fault_tabControl);
            this.frm_tabPage.Location = new System.Drawing.Point(4, 22);
            this.frm_tabPage.Name = "frm_tabPage";
            this.frm_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.frm_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.frm_tabPage.TabIndex = 3;
            this.frm_tabPage.Text = "FRM";
            this.frm_tabPage.UseVisualStyleBackColor = true;
            // 
            // fault_tabControl
            // 
            this.fault_tabControl.Controls.Add(this.frmFault_tabPage);
            this.fault_tabControl.Controls.Add(this.pflFault_tabPage);
            this.fault_tabControl.Location = new System.Drawing.Point(6, 8);
            this.fault_tabControl.Name = "fault_tabControl";
            this.fault_tabControl.SelectedIndex = 0;
            this.fault_tabControl.Size = new System.Drawing.Size(1251, 581);
            this.fault_tabControl.TabIndex = 5;
            // 
            // frmFault_tabPage
            // 
            this.frmFault_tabPage.Controls.Add(this.frmFaults_groupBox);
            this.frmFault_tabPage.Location = new System.Drawing.Point(4, 22);
            this.frmFault_tabPage.Name = "frmFault_tabPage";
            this.frmFault_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.frmFault_tabPage.Size = new System.Drawing.Size(1243, 555);
            this.frmFault_tabPage.TabIndex = 0;
            this.frmFault_tabPage.Text = "MFL";
            this.frmFault_tabPage.UseVisualStyleBackColor = true;
            // 
            // frmFaults_groupBox
            // 
            this.frmFaults_groupBox.Controls.Add(this.frmFaultMaxRecords_label);
            this.frmFaults_groupBox.Controls.Add(this.frmFaultCntr_label);
            this.frmFaults_groupBox.Controls.Add(this.frmFaultMaxRecords_textBox);
            this.frmFaults_groupBox.Controls.Add(this.frmFaultCntr_textBox);
            this.frmFaults_groupBox.Controls.Add(this.frm_panel);
            this.frmFaults_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmFaults_groupBox.Location = new System.Drawing.Point(8, 6);
            this.frmFaults_groupBox.Name = "frmFaults_groupBox";
            this.frmFaults_groupBox.Size = new System.Drawing.Size(1271, 543);
            this.frmFaults_groupBox.TabIndex = 0;
            this.frmFaults_groupBox.TabStop = false;
            this.frmFaults_groupBox.Text = "MFL Faults";
            // 
            // frmFaultMaxRecords_label
            // 
            this.frmFaultMaxRecords_label.AutoSize = true;
            this.frmFaultMaxRecords_label.Location = new System.Drawing.Point(6, 513);
            this.frmFaultMaxRecords_label.Name = "frmFaultMaxRecords_label";
            this.frmFaultMaxRecords_label.Size = new System.Drawing.Size(100, 13);
            this.frmFaultMaxRecords_label.TabIndex = 4;
            this.frmFaultMaxRecords_label.Text = "Total FRM Records";
            // 
            // frmFaultCntr_label
            // 
            this.frmFaultCntr_label.AutoSize = true;
            this.frmFaultCntr_label.Location = new System.Drawing.Point(6, 481);
            this.frmFaultCntr_label.Name = "frmFaultCntr_label";
            this.frmFaultCntr_label.Size = new System.Drawing.Size(108, 13);
            this.frmFaultCntr_label.TabIndex = 3;
            this.frmFaultCntr_label.Text = "FRM Faults Reported";
            // 
            // frmFaultMaxRecords_textBox
            // 
            this.frmFaultMaxRecords_textBox.Location = new System.Drawing.Point(120, 513);
            this.frmFaultMaxRecords_textBox.Name = "frmFaultMaxRecords_textBox";
            this.frmFaultMaxRecords_textBox.Size = new System.Drawing.Size(100, 20);
            this.frmFaultMaxRecords_textBox.TabIndex = 2;
            this.frmFaultMaxRecords_textBox.Text = "N\\A";
            // 
            // frmFaultCntr_textBox
            // 
            this.frmFaultCntr_textBox.Location = new System.Drawing.Point(120, 478);
            this.frmFaultCntr_textBox.Name = "frmFaultCntr_textBox";
            this.frmFaultCntr_textBox.Size = new System.Drawing.Size(100, 20);
            this.frmFaultCntr_textBox.TabIndex = 1;
            this.frmFaultCntr_textBox.Text = "N\\A";
            // 
            // frm_panel
            // 
            this.frm_panel.Controls.Add(this.frm_dataGridView);
            this.frm_panel.Location = new System.Drawing.Point(9, 35);
            this.frm_panel.Name = "frm_panel";
            this.frm_panel.Size = new System.Drawing.Size(1256, 437);
            this.frm_panel.TabIndex = 0;
            // 
            // frm_dataGridView
            // 
            this.frm_dataGridView.AllowUserToAddRows = false;
            this.frm_dataGridView.AllowUserToDeleteRows = false;
            this.frm_dataGridView.AutoGenerateColumns = false;
            this.frm_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frm_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mFLIDnumberDataGridViewTextBoxColumn,
            this.faultcurrentlyexistsDataGridViewTextBoxColumn,
            this.totalNoofappearancesDataGridViewTextBoxColumn,
            this.firstappearanceVMSCcycleNoDataGridViewTextBoxColumn,
            this.firstappearancetimeinmsecDataGridViewTextBoxColumn,
            this.firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn,
            this.firstdisappearancetimeinmsecDataGridViewTextBoxColumn,
            this.spareDataGridViewTextBoxColumn});
            this.frm_dataGridView.DataSource = this.fRMTableBindingSource1;
            this.frm_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.frm_dataGridView.Name = "frm_dataGridView";
            this.frm_dataGridView.ReadOnly = true;
            this.frm_dataGridView.RowHeadersVisible = false;
            this.frm_dataGridView.Size = new System.Drawing.Size(1256, 437);
            this.frm_dataGridView.TabIndex = 0;
            // 
            // mFLIDnumberDataGridViewTextBoxColumn
            // 
            this.mFLIDnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mFLIDnumberDataGridViewTextBoxColumn.DataPropertyName = "MFL_ID_number";
            this.mFLIDnumberDataGridViewTextBoxColumn.HeaderText = "MFL ID";
            this.mFLIDnumberDataGridViewTextBoxColumn.Name = "mFLIDnumberDataGridViewTextBoxColumn";
            this.mFLIDnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faultcurrentlyexistsDataGridViewTextBoxColumn
            // 
            this.faultcurrentlyexistsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.faultcurrentlyexistsDataGridViewTextBoxColumn.DataPropertyName = "Fault_currently_exists";
            this.faultcurrentlyexistsDataGridViewTextBoxColumn.HeaderText = "Currently Exists";
            this.faultcurrentlyexistsDataGridViewTextBoxColumn.Name = "faultcurrentlyexistsDataGridViewTextBoxColumn";
            this.faultcurrentlyexistsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalNoofappearancesDataGridViewTextBoxColumn
            // 
            this.totalNoofappearancesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalNoofappearancesDataGridViewTextBoxColumn.DataPropertyName = "Total_No_of_appearances";
            this.totalNoofappearancesDataGridViewTextBoxColumn.HeaderText = "No Of Appearances";
            this.totalNoofappearancesDataGridViewTextBoxColumn.Name = "totalNoofappearancesDataGridViewTextBoxColumn";
            this.totalNoofappearancesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstappearanceVMSCcycleNoDataGridViewTextBoxColumn
            // 
            this.firstappearanceVMSCcycleNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstappearanceVMSCcycleNoDataGridViewTextBoxColumn.DataPropertyName = "First_appearance_VMSC_cycle_No";
            this.firstappearanceVMSCcycleNoDataGridViewTextBoxColumn.HeaderText = "First Appearance (RTC Cycle No.)";
            this.firstappearanceVMSCcycleNoDataGridViewTextBoxColumn.Name = "firstappearanceVMSCcycleNoDataGridViewTextBoxColumn";
            this.firstappearanceVMSCcycleNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstappearancetimeinmsecDataGridViewTextBoxColumn
            // 
            this.firstappearancetimeinmsecDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstappearancetimeinmsecDataGridViewTextBoxColumn.DataPropertyName = "First_appearance_time_in_msec";
            this.firstappearancetimeinmsecDataGridViewTextBoxColumn.HeaderText = "First Appearance (ms)";
            this.firstappearancetimeinmsecDataGridViewTextBoxColumn.Name = "firstappearancetimeinmsecDataGridViewTextBoxColumn";
            this.firstappearancetimeinmsecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn
            // 
            this.firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn.DataPropertyName = "First_disappearance_VMSC_cycle_No";
            this.firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn.HeaderText = "First Disappearance (RTC Cycle No.)";
            this.firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn.Name = "firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn";
            this.firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstdisappearancetimeinmsecDataGridViewTextBoxColumn
            // 
            this.firstdisappearancetimeinmsecDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstdisappearancetimeinmsecDataGridViewTextBoxColumn.DataPropertyName = "First_disappearance_time_in_msec";
            this.firstdisappearancetimeinmsecDataGridViewTextBoxColumn.HeaderText = "First Disappearance (ms)";
            this.firstdisappearancetimeinmsecDataGridViewTextBoxColumn.Name = "firstdisappearancetimeinmsecDataGridViewTextBoxColumn";
            this.firstdisappearancetimeinmsecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spareDataGridViewTextBoxColumn
            // 
            this.spareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.spareDataGridViewTextBoxColumn.DataPropertyName = "spare";
            this.spareDataGridViewTextBoxColumn.HeaderText = "Spare";
            this.spareDataGridViewTextBoxColumn.Name = "spareDataGridViewTextBoxColumn";
            this.spareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fRMTableBindingSource1
            // 
            this.fRMTableBindingSource1.DataSource = typeof(RT_Viewer.Framework.FRMModule.FRMTable);
            // 
            // pflFault_tabPage
            // 
            this.pflFault_tabPage.Controls.Add(this.pfl_groupBox);
            this.pflFault_tabPage.Location = new System.Drawing.Point(4, 22);
            this.pflFault_tabPage.Name = "pflFault_tabPage";
            this.pflFault_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pflFault_tabPage.Size = new System.Drawing.Size(1243, 555);
            this.pflFault_tabPage.TabIndex = 1;
            this.pflFault_tabPage.Text = "PFL";
            this.pflFault_tabPage.UseVisualStyleBackColor = true;
            // 
            // pfl_groupBox
            // 
            this.pfl_groupBox.Controls.Add(this.pfl_panel);
            this.pfl_groupBox.Controls.Add(this.totalPFLRecords_label);
            this.pfl_groupBox.Controls.Add(this.pflFaultReported_label);
            this.pfl_groupBox.Controls.Add(this.totalPFLRecords_textBox);
            this.pfl_groupBox.Controls.Add(this.pflFaultsReported_textBox);
            this.pfl_groupBox.Location = new System.Drawing.Point(6, 6);
            this.pfl_groupBox.Name = "pfl_groupBox";
            this.pfl_groupBox.Size = new System.Drawing.Size(1231, 548);
            this.pfl_groupBox.TabIndex = 0;
            this.pfl_groupBox.TabStop = false;
            this.pfl_groupBox.Text = "PFL Faults";
            // 
            // pfl_panel
            // 
            this.pfl_panel.Controls.Add(this.pflFault_dataGridView);
            this.pfl_panel.Location = new System.Drawing.Point(18, 37);
            this.pfl_panel.Name = "pfl_panel";
            this.pfl_panel.Size = new System.Drawing.Size(462, 402);
            this.pfl_panel.TabIndex = 9;
            // 
            // pflFault_dataGridView
            // 
            this.pflFault_dataGridView.AllowUserToAddRows = false;
            this.pflFault_dataGridView.AllowUserToDeleteRows = false;
            this.pflFault_dataGridView.AutoGenerateColumns = false;
            this.pflFault_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pflFault_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pFLIDnumberDataGridViewTextBoxColumn,
            this.pFLLABELDataGridViewTextBoxColumn});
            this.pflFault_dataGridView.DataSource = this.pFLTableBindingSource;
            this.pflFault_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pflFault_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.pflFault_dataGridView.Name = "pflFault_dataGridView";
            this.pflFault_dataGridView.ReadOnly = true;
            this.pflFault_dataGridView.RowHeadersVisible = false;
            this.pflFault_dataGridView.Size = new System.Drawing.Size(462, 402);
            this.pflFault_dataGridView.TabIndex = 0;
            // 
            // pFLIDnumberDataGridViewTextBoxColumn
            // 
            this.pFLIDnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pFLIDnumberDataGridViewTextBoxColumn.DataPropertyName = "PFL_ID_number";
            this.pFLIDnumberDataGridViewTextBoxColumn.HeaderText = "PFL Number";
            this.pFLIDnumberDataGridViewTextBoxColumn.Name = "pFLIDnumberDataGridViewTextBoxColumn";
            this.pFLIDnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pFLLABELDataGridViewTextBoxColumn
            // 
            this.pFLLABELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pFLLABELDataGridViewTextBoxColumn.DataPropertyName = "PFL_LABEL";
            this.pFLLABELDataGridViewTextBoxColumn.HeaderText = "PFL Label";
            this.pFLLABELDataGridViewTextBoxColumn.Name = "pFLLABELDataGridViewTextBoxColumn";
            this.pFLLABELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pFLTableBindingSource
            // 
            this.pFLTableBindingSource.DataSource = typeof(RT_Viewer.Framework.FRMModule.PFLTable);
            // 
            // totalPFLRecords_label
            // 
            this.totalPFLRecords_label.AutoSize = true;
            this.totalPFLRecords_label.Location = new System.Drawing.Point(15, 515);
            this.totalPFLRecords_label.Name = "totalPFLRecords_label";
            this.totalPFLRecords_label.Size = new System.Drawing.Size(96, 13);
            this.totalPFLRecords_label.TabIndex = 8;
            this.totalPFLRecords_label.Text = "Total PFL Records";
            // 
            // pflFaultReported_label
            // 
            this.pflFaultReported_label.AutoSize = true;
            this.pflFaultReported_label.Location = new System.Drawing.Point(15, 484);
            this.pflFaultReported_label.Name = "pflFaultReported_label";
            this.pflFaultReported_label.Size = new System.Drawing.Size(104, 13);
            this.pflFaultReported_label.TabIndex = 7;
            this.pflFaultReported_label.Text = "PFL Faults Reported";
            // 
            // totalPFLRecords_textBox
            // 
            this.totalPFLRecords_textBox.Location = new System.Drawing.Point(129, 512);
            this.totalPFLRecords_textBox.Name = "totalPFLRecords_textBox";
            this.totalPFLRecords_textBox.Size = new System.Drawing.Size(100, 20);
            this.totalPFLRecords_textBox.TabIndex = 6;
            this.totalPFLRecords_textBox.Text = "N\\A";
            // 
            // pflFaultsReported_textBox
            // 
            this.pflFaultsReported_textBox.Location = new System.Drawing.Point(129, 481);
            this.pflFaultsReported_textBox.Name = "pflFaultsReported_textBox";
            this.pflFaultsReported_textBox.Size = new System.Drawing.Size(100, 20);
            this.pflFaultsReported_textBox.TabIndex = 5;
            this.pflFaultsReported_textBox.Text = "N\\A";
            // 
            // log_tabPage
            // 
            this.log_tabPage.Controls.Add(this.log_tabControl);
            this.log_tabPage.Location = new System.Drawing.Point(4, 22);
            this.log_tabPage.Name = "log_tabPage";
            this.log_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.log_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.log_tabPage.TabIndex = 4;
            this.log_tabPage.Text = "LOG";
            this.log_tabPage.UseVisualStyleBackColor = true;
            // 
            // log_tabControl
            // 
            this.log_tabControl.Controls.Add(this.logProperties_tabPage);
            this.log_tabControl.Controls.Add(this.LogSearch_tabPage);
            this.log_tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.log_tabControl.Location = new System.Drawing.Point(6, 6);
            this.log_tabControl.Multiline = true;
            this.log_tabControl.Name = "log_tabControl";
            this.log_tabControl.SelectedIndex = 0;
            this.log_tabControl.Size = new System.Drawing.Size(1251, 578);
            this.log_tabControl.TabIndex = 2;
            // 
            // logProperties_tabPage
            // 
            this.logProperties_tabPage.Controls.Add(this.RTCLogger_groupBox);
            this.logProperties_tabPage.Location = new System.Drawing.Point(4, 22);
            this.logProperties_tabPage.Name = "logProperties_tabPage";
            this.logProperties_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.logProperties_tabPage.Size = new System.Drawing.Size(1243, 552);
            this.logProperties_tabPage.TabIndex = 0;
            this.logProperties_tabPage.Text = "RT LOG Properties";
            this.logProperties_tabPage.UseVisualStyleBackColor = true;
            // 
            // RTCLogger_groupBox
            // 
            this.RTCLogger_groupBox.Controls.Add(this.setRTLogLevel_groupBox);
            this.RTCLogger_groupBox.Controls.Add(this.rtcLoggerControl_groupBox);
            this.RTCLogger_groupBox.Location = new System.Drawing.Point(3, 3);
            this.RTCLogger_groupBox.Name = "RTCLogger_groupBox";
            this.RTCLogger_groupBox.Size = new System.Drawing.Size(1267, 540);
            this.RTCLogger_groupBox.TabIndex = 0;
            this.RTCLogger_groupBox.TabStop = false;
            this.RTCLogger_groupBox.Text = "RTCLogger";
            this.RTCLogger_groupBox.Enter += new System.EventHandler(this.RTCLogger_groupBox_Enter);
            // 
            // setRTLogLevel_groupBox
            // 
            this.setRTLogLevel_groupBox.Controls.Add(this.setLogLevelAllModule_comboBox);
            this.setRTLogLevel_groupBox.Controls.Add(this.setRTLogLevel_panel);
            this.setRTLogLevel_groupBox.Controls.Add(this.undoRTCLogLevel_Button);
            this.setRTLogLevel_groupBox.Controls.Add(this.setRTLogLevel_button);
            this.setRTLogLevel_groupBox.Location = new System.Drawing.Point(456, 19);
            this.setRTLogLevel_groupBox.Name = "setRTLogLevel_groupBox";
            this.setRTLogLevel_groupBox.Size = new System.Drawing.Size(794, 511);
            this.setRTLogLevel_groupBox.TabIndex = 20;
            this.setRTLogLevel_groupBox.TabStop = false;
            this.setRTLogLevel_groupBox.Text = "Set RT LOG Level";
            // 
            // setLogLevelAllModule_comboBox
            // 
            this.setLogLevelAllModule_comboBox.Controls.Add(this.setRTLogLevelForAllModules_button);
            this.setLogLevelAllModule_comboBox.Controls.Add(this.setLogLevelForAllModules_comboBox);
            this.setLogLevelAllModule_comboBox.Location = new System.Drawing.Point(447, 215);
            this.setLogLevelAllModule_comboBox.Name = "setLogLevelAllModule_comboBox";
            this.setLogLevelAllModule_comboBox.Size = new System.Drawing.Size(341, 83);
            this.setLogLevelAllModule_comboBox.TabIndex = 23;
            this.setLogLevelAllModule_comboBox.TabStop = false;
            this.setLogLevelAllModule_comboBox.Text = "Set Level For All Modules";
            // 
            // setRTLogLevelForAllModules_button
            // 
            this.setRTLogLevelForAllModules_button.Enabled = false;
            this.setRTLogLevelForAllModules_button.Location = new System.Drawing.Point(189, 20);
            this.setRTLogLevelForAllModules_button.Name = "setRTLogLevelForAllModules_button";
            this.setRTLogLevelForAllModules_button.Size = new System.Drawing.Size(101, 38);
            this.setRTLogLevelForAllModules_button.TabIndex = 22;
            this.setRTLogLevelForAllModules_button.Text = "Set Changes";
            this.setRTLogLevelForAllModules_button.UseVisualStyleBackColor = true;
            this.setRTLogLevelForAllModules_button.Click += new System.EventHandler(this.setRTLogLevelForAllModules_button_Click);
            // 
            // setLogLevelForAllModules_comboBox
            // 
            this.setLogLevelForAllModules_comboBox.FormattingEnabled = true;
            this.setLogLevelForAllModules_comboBox.Location = new System.Drawing.Point(42, 30);
            this.setLogLevelForAllModules_comboBox.Name = "setLogLevelForAllModules_comboBox";
            this.setLogLevelForAllModules_comboBox.Size = new System.Drawing.Size(121, 21);
            this.setLogLevelForAllModules_comboBox.TabIndex = 21;
            // 
            // setRTLogLevel_panel
            // 
            this.setRTLogLevel_panel.AutoScroll = true;
            this.setRTLogLevel_panel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.setRTLogLevel_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setRTLogLevel_panel.Controls.Add(this.setRTLogLevel_dataGridView);
            this.setRTLogLevel_panel.Location = new System.Drawing.Point(27, 34);
            this.setRTLogLevel_panel.Name = "setRTLogLevel_panel";
            this.setRTLogLevel_panel.Size = new System.Drawing.Size(392, 459);
            this.setRTLogLevel_panel.TabIndex = 6;
            // 
            // setRTLogLevel_dataGridView
            // 
            this.setRTLogLevel_dataGridView.AllowUserToAddRows = false;
            this.setRTLogLevel_dataGridView.AllowUserToDeleteRows = false;
            this.setRTLogLevel_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setRTLogLevel_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setRTLogLevel_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.setRTLogLevel_dataGridView.Name = "setRTLogLevel_dataGridView";
            this.setRTLogLevel_dataGridView.RowHeadersVisible = false;
            this.setRTLogLevel_dataGridView.Size = new System.Drawing.Size(392, 459);
            this.setRTLogLevel_dataGridView.TabIndex = 0;
            this.setRTLogLevel_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.setRTLogLevel_dataGridView_CellContentClick);
            // 
            // undoRTCLogLevel_Button
            // 
            this.undoRTCLogLevel_Button.Enabled = false;
            this.undoRTCLogLevel_Button.Location = new System.Drawing.Point(628, 133);
            this.undoRTCLogLevel_Button.Name = "undoRTCLogLevel_Button";
            this.undoRTCLogLevel_Button.Size = new System.Drawing.Size(109, 38);
            this.undoRTCLogLevel_Button.TabIndex = 19;
            this.undoRTCLogLevel_Button.Text = "Reset Changes";
            this.undoRTCLogLevel_Button.UseVisualStyleBackColor = true;
            this.undoRTCLogLevel_Button.Click += new System.EventHandler(this.undoRTCLogLevel_Button_Click);
            // 
            // setRTLogLevel_button
            // 
            this.setRTLogLevel_button.Enabled = false;
            this.setRTLogLevel_button.Location = new System.Drawing.Point(489, 133);
            this.setRTLogLevel_button.Name = "setRTLogLevel_button";
            this.setRTLogLevel_button.Size = new System.Drawing.Size(109, 38);
            this.setRTLogLevel_button.TabIndex = 15;
            this.setRTLogLevel_button.Text = "Set Changes";
            this.setRTLogLevel_button.UseVisualStyleBackColor = true;
            this.setRTLogLevel_button.Click += new System.EventHandler(this.setRTLogLevel_button_Click);
            // 
            // rtcLoggerControl_groupBox
            // 
            this.rtcLoggerControl_groupBox.Controls.Add(this.logShellSideB_button);
            this.rtcLoggerControl_groupBox.Controls.Add(this.logShellSideA_button);
            this.rtcLoggerControl_groupBox.Controls.Add(this.startRtcLogger_button);
            this.rtcLoggerControl_groupBox.Location = new System.Drawing.Point(96, 19);
            this.rtcLoggerControl_groupBox.Name = "rtcLoggerControl_groupBox";
            this.rtcLoggerControl_groupBox.Size = new System.Drawing.Size(207, 233);
            this.rtcLoggerControl_groupBox.TabIndex = 18;
            this.rtcLoggerControl_groupBox.TabStop = false;
            this.rtcLoggerControl_groupBox.Text = "RTCLogger Control";
            // 
            // logShellSideB_button
            // 
            this.logShellSideB_button.Location = new System.Drawing.Point(45, 160);
            this.logShellSideB_button.Name = "logShellSideB_button";
            this.logShellSideB_button.Size = new System.Drawing.Size(108, 36);
            this.logShellSideB_button.TabIndex = 2;
            this.logShellSideB_button.Text = "Open RTC2 Log Shell";
            this.logShellSideB_button.UseVisualStyleBackColor = true;
            this.logShellSideB_button.Click += new System.EventHandler(this.LogShellSideB_button_Click);
            // 
            // logShellSideA_button
            // 
            this.logShellSideA_button.Location = new System.Drawing.Point(45, 97);
            this.logShellSideA_button.Name = "logShellSideA_button";
            this.logShellSideA_button.Size = new System.Drawing.Size(108, 36);
            this.logShellSideA_button.TabIndex = 1;
            this.logShellSideA_button.Text = "Open RTC1 Log Shell";
            this.logShellSideA_button.UseVisualStyleBackColor = true;
            this.logShellSideA_button.Click += new System.EventHandler(this.LogShellSideA_button_Click);
            // 
            // startRtcLogger_button
            // 
            this.startRtcLogger_button.BackColor = System.Drawing.Color.Transparent;
            this.startRtcLogger_button.Location = new System.Drawing.Point(44, 34);
            this.startRtcLogger_button.Name = "startRtcLogger_button";
            this.startRtcLogger_button.Size = new System.Drawing.Size(109, 38);
            this.startRtcLogger_button.TabIndex = 0;
            this.startRtcLogger_button.Text = "Start RTCLogger";
            this.startRtcLogger_button.UseVisualStyleBackColor = false;
            this.startRtcLogger_button.Click += new System.EventHandler(this.startStopRTCLogger_Click);
            // 
            // LogSearch_tabPage
            // 
            this.LogSearch_tabPage.Controls.Add(this.ContentNavigation_groupBox);
            this.LogSearch_tabPage.Controls.Add(this.setRTCLoggerFilter_groupBox);
            this.LogSearch_tabPage.Controls.Add(this.logContent_groupBox);
            this.LogSearch_tabPage.Location = new System.Drawing.Point(4, 22);
            this.LogSearch_tabPage.Name = "LogSearch_tabPage";
            this.LogSearch_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogSearch_tabPage.Size = new System.Drawing.Size(1243, 552);
            this.LogSearch_tabPage.TabIndex = 1;
            this.LogSearch_tabPage.Text = "Search Content";
            this.LogSearch_tabPage.UseVisualStyleBackColor = true;
            // 
            // ContentNavigation_groupBox
            // 
            this.ContentNavigation_groupBox.Controls.Add(this.logPageNumber_label);
            this.ContentNavigation_groupBox.Controls.Add(this.showPrevLogResult_button);
            this.ContentNavigation_groupBox.Controls.Add(this.showNextLogResult_button);
            this.ContentNavigation_groupBox.Location = new System.Drawing.Point(985, 461);
            this.ContentNavigation_groupBox.Name = "ContentNavigation_groupBox";
            this.ContentNavigation_groupBox.Size = new System.Drawing.Size(286, 88);
            this.ContentNavigation_groupBox.TabIndex = 24;
            this.ContentNavigation_groupBox.TabStop = false;
            this.ContentNavigation_groupBox.Text = "Log Content Navigation";
            // 
            // logPageNumber_label
            // 
            this.logPageNumber_label.AutoSize = true;
            this.logPageNumber_label.Location = new System.Drawing.Point(6, 66);
            this.logPageNumber_label.Name = "logPageNumber_label";
            this.logPageNumber_label.Size = new System.Drawing.Size(98, 13);
            this.logPageNumber_label.TabIndex = 25;
            this.logPageNumber_label.Text = "Page Number: N\\A";
            // 
            // showPrevLogResult_button
            // 
            this.showPrevLogResult_button.Enabled = false;
            this.showPrevLogResult_button.Location = new System.Drawing.Point(6, 26);
            this.showPrevLogResult_button.Name = "showPrevLogResult_button";
            this.showPrevLogResult_button.Size = new System.Drawing.Size(118, 31);
            this.showPrevLogResult_button.TabIndex = 24;
            this.showPrevLogResult_button.Text = "Show Prev Result";
            this.showPrevLogResult_button.UseVisualStyleBackColor = true;
            this.showPrevLogResult_button.Click += new System.EventHandler(this.showPrevLogResult_button_Click);
            // 
            // showNextLogResult_button
            // 
            this.showNextLogResult_button.Enabled = false;
            this.showNextLogResult_button.Location = new System.Drawing.Point(152, 26);
            this.showNextLogResult_button.Name = "showNextLogResult_button";
            this.showNextLogResult_button.Size = new System.Drawing.Size(118, 31);
            this.showNextLogResult_button.TabIndex = 23;
            this.showNextLogResult_button.Text = "Show Next Result";
            this.showNextLogResult_button.UseVisualStyleBackColor = true;
            this.showNextLogResult_button.Click += new System.EventHandler(this.showNextLogResult_button_Click);
            // 
            // setRTCLoggerFilter_groupBox
            // 
            this.setRTCLoggerFilter_groupBox.Controls.Add(this.openFilteredFile_Button);
            this.setRTCLoggerFilter_groupBox.Controls.Add(this.setRTCLoggerFilter_panel);
            this.setRTCLoggerFilter_groupBox.Controls.Add(this.setLogFilter_button);
            this.setRTCLoggerFilter_groupBox.Location = new System.Drawing.Point(985, 3);
            this.setRTCLoggerFilter_groupBox.Name = "setRTCLoggerFilter_groupBox";
            this.setRTCLoggerFilter_groupBox.Size = new System.Drawing.Size(286, 452);
            this.setRTCLoggerFilter_groupBox.TabIndex = 21;
            this.setRTCLoggerFilter_groupBox.TabStop = false;
            this.setRTCLoggerFilter_groupBox.Text = "Set RTCLogger Filter";
            // 
            // openFilteredFile_Button
            // 
            this.openFilteredFile_Button.Enabled = false;
            this.openFilteredFile_Button.Location = new System.Drawing.Point(151, 407);
            this.openFilteredFile_Button.Name = "openFilteredFile_Button";
            this.openFilteredFile_Button.Size = new System.Drawing.Size(109, 38);
            this.openFilteredFile_Button.TabIndex = 17;
            this.openFilteredFile_Button.Text = "Open Filtered File";
            this.openFilteredFile_Button.UseVisualStyleBackColor = true;
            this.openFilteredFile_Button.Click += new System.EventHandler(this.openFilteredFile_Button_Click);
            // 
            // setRTCLoggerFilter_panel
            // 
            this.setRTCLoggerFilter_panel.AutoScroll = true;
            this.setRTCLoggerFilter_panel.Controls.Add(this.setRTCLoggerFilter_dataGridView);
            this.setRTCLoggerFilter_panel.Location = new System.Drawing.Point(21, 19);
            this.setRTCLoggerFilter_panel.Name = "setRTCLoggerFilter_panel";
            this.setRTCLoggerFilter_panel.Size = new System.Drawing.Size(249, 383);
            this.setRTCLoggerFilter_panel.TabIndex = 16;
            // 
            // setRTCLoggerFilter_dataGridView
            // 
            this.setRTCLoggerFilter_dataGridView.AllowDrop = true;
            this.setRTCLoggerFilter_dataGridView.AllowUserToAddRows = false;
            this.setRTCLoggerFilter_dataGridView.AllowUserToDeleteRows = false;
            this.setRTCLoggerFilter_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setRTCLoggerFilter_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setRTCLoggerFilter_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.setRTCLoggerFilter_dataGridView.Name = "setRTCLoggerFilter_dataGridView";
            this.setRTCLoggerFilter_dataGridView.RowHeadersVisible = false;
            this.setRTCLoggerFilter_dataGridView.Size = new System.Drawing.Size(249, 383);
            this.setRTCLoggerFilter_dataGridView.TabIndex = 0;
            // 
            // setLogFilter_button
            // 
            this.setLogFilter_button.Enabled = false;
            this.setLogFilter_button.Location = new System.Drawing.Point(36, 408);
            this.setLogFilter_button.Name = "setLogFilter_button";
            this.setLogFilter_button.Size = new System.Drawing.Size(109, 38);
            this.setLogFilter_button.TabIndex = 9;
            this.setLogFilter_button.Text = "Set Filter";
            this.setLogFilter_button.UseVisualStyleBackColor = true;
            this.setLogFilter_button.Click += new System.EventHandler(this.SetFilter_Click);
            // 
            // logContent_groupBox
            // 
            this.logContent_groupBox.Controls.Add(this.logContent_splitContainer);
            this.logContent_groupBox.Controls.Add(this.selectLogFolder_button);
            this.logContent_groupBox.Controls.Add(this.newSearchLogContent_button);
            this.logContent_groupBox.Controls.Add(this.isOnlineSearch_radioButton);
            this.logContent_groupBox.Controls.Add(this.isOfflineSearch_radioButton);
            this.logContent_groupBox.Controls.Add(this.onlineLogSearch_panel);
            this.logContent_groupBox.Controls.Add(this.caseSensitiveFilterSearch_checkbox);
            this.logContent_groupBox.Controls.Add(this.reloadLogFile_button);
            this.logContent_groupBox.Controls.Add(this.stopFilterByStringInLog_button);
            this.logContent_groupBox.Controls.Add(this.loadingLogFilter_pictureBox);
            this.logContent_groupBox.Controls.Add(this.searchStringInLog_label);
            this.logContent_groupBox.Controls.Add(this.filterByStringInLog_button);
            this.logContent_groupBox.Controls.Add(this.searchStringInLog_textBox);
            this.logContent_groupBox.Location = new System.Drawing.Point(6, 3);
            this.logContent_groupBox.Name = "logContent_groupBox";
            this.logContent_groupBox.Size = new System.Drawing.Size(973, 543);
            this.logContent_groupBox.TabIndex = 1;
            this.logContent_groupBox.TabStop = false;
            this.logContent_groupBox.Text = "View Log Content";
            this.logContent_groupBox.Enter += new System.EventHandler(this.logContent_groupBox_Enter);
            // 
            // logContent_splitContainer
            // 
            this.logContent_splitContainer.IsSplitterFixed = true;
            this.logContent_splitContainer.Location = new System.Drawing.Point(10, 102);
            this.logContent_splitContainer.Name = "logContent_splitContainer";
            this.logContent_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // logContent_splitContainer.Panel1
            // 
            this.logContent_splitContainer.Panel1.Controls.Add(this.logContent_textBox);
            // 
            // logContent_splitContainer.Panel2
            // 
            this.logContent_splitContainer.Panel2.Controls.Add(this.LogSearchStatus_groupBox);
            this.logContent_splitContainer.Size = new System.Drawing.Size(957, 435);
            this.logContent_splitContainer.SplitterDistance = 352;
            this.logContent_splitContainer.TabIndex = 30;
            // 
            // logContent_textBox
            // 
            this.logContent_textBox.Location = new System.Drawing.Point(3, 3);
            this.logContent_textBox.MaxLength = 2147483647;
            this.logContent_textBox.Multiline = true;
            this.logContent_textBox.Name = "logContent_textBox";
            this.logContent_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logContent_textBox.Size = new System.Drawing.Size(951, 347);
            this.logContent_textBox.TabIndex = 0;
            this.logContent_textBox.WordWrap = false;
            this.logContent_textBox.TextChanged += new System.EventHandler(this.logContent_textBox_TextChanged);
            this.logContent_textBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.logContent_textBox_MouseDoubleClick);
            // 
            // LogSearchStatus_groupBox
            // 
            this.LogSearchStatus_groupBox.Controls.Add(this.searchStatus_richTextBox);
            this.LogSearchStatus_groupBox.Location = new System.Drawing.Point(3, 10);
            this.LogSearchStatus_groupBox.Name = "LogSearchStatus_groupBox";
            this.LogSearchStatus_groupBox.Size = new System.Drawing.Size(951, 62);
            this.LogSearchStatus_groupBox.TabIndex = 22;
            this.LogSearchStatus_groupBox.TabStop = false;
            this.LogSearchStatus_groupBox.Text = "Search Status";
            // 
            // searchStatus_richTextBox
            // 
            this.searchStatus_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchStatus_richTextBox.Location = new System.Drawing.Point(3, 16);
            this.searchStatus_richTextBox.Name = "searchStatus_richTextBox";
            this.searchStatus_richTextBox.Size = new System.Drawing.Size(945, 43);
            this.searchStatus_richTextBox.TabIndex = 0;
            this.searchStatus_richTextBox.Text = "";
            this.searchStatus_richTextBox.TextChanged += new System.EventHandler(this.searchStatus_richTextBox_TextChanged);
            this.searchStatus_richTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.searchStatus_richTextBox_MouseDoubleClick);
            // 
            // selectLogFolder_button
            // 
            this.selectLogFolder_button.Location = new System.Drawing.Point(173, 65);
            this.selectLogFolder_button.Name = "selectLogFolder_button";
            this.selectLogFolder_button.Size = new System.Drawing.Size(108, 23);
            this.selectLogFolder_button.TabIndex = 4;
            this.selectLogFolder_button.Text = "Select Folder";
            this.selectLogFolder_button.UseVisualStyleBackColor = true;
            this.selectLogFolder_button.Click += new System.EventHandler(this.selectLogFolder_button_Click);
            // 
            // newSearchLogContent_button
            // 
            this.newSearchLogContent_button.Location = new System.Drawing.Point(613, 24);
            this.newSearchLogContent_button.Name = "newSearchLogContent_button";
            this.newSearchLogContent_button.Size = new System.Drawing.Size(96, 24);
            this.newSearchLogContent_button.TabIndex = 22;
            this.newSearchLogContent_button.Text = "New Search";
            this.newSearchLogContent_button.UseVisualStyleBackColor = true;
            this.newSearchLogContent_button.Click += new System.EventHandler(this.clearLogContent_button_Click);
            // 
            // isOnlineSearch_radioButton
            // 
            this.isOnlineSearch_radioButton.AutoSize = true;
            this.isOnlineSearch_radioButton.Checked = true;
            this.isOnlineSearch_radioButton.Location = new System.Drawing.Point(23, 55);
            this.isOnlineSearch_radioButton.Name = "isOnlineSearch_radioButton";
            this.isOnlineSearch_radioButton.Size = new System.Drawing.Size(108, 17);
            this.isOnlineSearch_radioButton.TabIndex = 29;
            this.isOnlineSearch_radioButton.TabStop = true;
            this.isOnlineSearch_radioButton.Text = "Load From Online";
            this.isOnlineSearch_radioButton.UseVisualStyleBackColor = true;
            this.isOnlineSearch_radioButton.CheckedChanged += new System.EventHandler(this.isOfflineSearch_radioButton_CheckedChanged);
            // 
            // isOfflineSearch_radioButton
            // 
            this.isOfflineSearch_radioButton.AutoSize = true;
            this.isOfflineSearch_radioButton.Location = new System.Drawing.Point(23, 78);
            this.isOfflineSearch_radioButton.Name = "isOfflineSearch_radioButton";
            this.isOfflineSearch_radioButton.Size = new System.Drawing.Size(140, 17);
            this.isOfflineSearch_radioButton.TabIndex = 28;
            this.isOfflineSearch_radioButton.Text = "Load From Offline Folder";
            this.isOfflineSearch_radioButton.UseVisualStyleBackColor = true;
            this.isOfflineSearch_radioButton.CheckedChanged += new System.EventHandler(this.isOnlineSearch_radioButton_CheckedChanged);
            // 
            // onlineLogSearch_panel
            // 
            this.onlineLogSearch_panel.Controls.Add(this.logEnd_dateTimePicker);
            this.onlineLogSearch_panel.Controls.Add(this.logDateOperand2_label);
            this.onlineLogSearch_panel.Controls.Add(this.logStart_dateTimePicker);
            this.onlineLogSearch_panel.Controls.Add(this.logDateOperand1_label);
            this.onlineLogSearch_panel.Controls.Add(this.logDateOperator_comboBox);
            this.onlineLogSearch_panel.Location = new System.Drawing.Point(315, 55);
            this.onlineLogSearch_panel.Name = "onlineLogSearch_panel";
            this.onlineLogSearch_panel.Size = new System.Drawing.Size(545, 41);
            this.onlineLogSearch_panel.TabIndex = 26;
            // 
            // logEnd_dateTimePicker
            // 
            this.logEnd_dateTimePicker.CustomFormat = "dd:MM:yyyy hh:mm:ss";
            this.logEnd_dateTimePicker.Location = new System.Drawing.Point(369, 18);
            this.logEnd_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.logEnd_dateTimePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.logEnd_dateTimePicker.Name = "logEnd_dateTimePicker";
            this.logEnd_dateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.logEnd_dateTimePicker.TabIndex = 22;
            // 
            // logDateOperand2_label
            // 
            this.logDateOperand2_label.AutoSize = true;
            this.logDateOperand2_label.Location = new System.Drawing.Point(308, 20);
            this.logDateOperand2_label.Name = "logDateOperand2_label";
            this.logDateOperand2_label.Size = new System.Drawing.Size(52, 13);
            this.logDateOperand2_label.TabIndex = 25;
            this.logDateOperand2_label.Text = "End Date";
            // 
            // logStart_dateTimePicker
            // 
            this.logStart_dateTimePicker.CustomFormat = "dd:MM:yyyy hh:mm:ss";
            this.logStart_dateTimePicker.Location = new System.Drawing.Point(87, 17);
            this.logStart_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.logStart_dateTimePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.logStart_dateTimePicker.Name = "logStart_dateTimePicker";
            this.logStart_dateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.logStart_dateTimePicker.TabIndex = 20;
            // 
            // logDateOperand1_label
            // 
            this.logDateOperand1_label.AutoSize = true;
            this.logDateOperand1_label.Location = new System.Drawing.Point(10, 20);
            this.logDateOperand1_label.Name = "logDateOperand1_label";
            this.logDateOperand1_label.Size = new System.Drawing.Size(55, 13);
            this.logDateOperand1_label.TabIndex = 24;
            this.logDateOperand1_label.Text = "Start Date";
            // 
            // logDateOperator_comboBox
            // 
            this.logDateOperator_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logDateOperator_comboBox.FormattingEnabled = true;
            this.logDateOperator_comboBox.Items.AddRange(new object[] {
            ">=",
            "<=",
            "-"});
            this.logDateOperator_comboBox.Location = new System.Drawing.Point(254, 17);
            this.logDateOperator_comboBox.Name = "logDateOperator_comboBox";
            this.logDateOperator_comboBox.Size = new System.Drawing.Size(40, 21);
            this.logDateOperator_comboBox.TabIndex = 23;
            this.logDateOperator_comboBox.SelectedIndexChanged += new System.EventHandler(this.logDateOperator_comboBox_SelectedIndexChanged);
            // 
            // caseSensitiveFilterSearch_checkbox
            // 
            this.caseSensitiveFilterSearch_checkbox.AutoSize = true;
            this.caseSensitiveFilterSearch_checkbox.Location = new System.Drawing.Point(728, 29);
            this.caseSensitiveFilterSearch_checkbox.Name = "caseSensitiveFilterSearch_checkbox";
            this.caseSensitiveFilterSearch_checkbox.Size = new System.Drawing.Size(100, 17);
            this.caseSensitiveFilterSearch_checkbox.TabIndex = 18;
            this.caseSensitiveFilterSearch_checkbox.Text = "Case Sensetive";
            this.caseSensitiveFilterSearch_checkbox.UseVisualStyleBackColor = true;
            this.caseSensitiveFilterSearch_checkbox.CheckedChanged += new System.EventHandler(this.caseSensitiveFilterSearch_checkbox_CheckedChanged);
            // 
            // reloadLogFile_button
            // 
            this.reloadLogFile_button.Location = new System.Drawing.Point(515, 24);
            this.reloadLogFile_button.Name = "reloadLogFile_button";
            this.reloadLogFile_button.Size = new System.Drawing.Size(91, 24);
            this.reloadLogFile_button.TabIndex = 8;
            this.reloadLogFile_button.Text = "Reload";
            this.reloadLogFile_button.UseVisualStyleBackColor = true;
            this.reloadLogFile_button.Click += new System.EventHandler(this.reloadLogFile_button_Click);
            // 
            // stopFilterByStringInLog_button
            // 
            this.stopFilterByStringInLog_button.Enabled = false;
            this.stopFilterByStringInLog_button.Location = new System.Drawing.Point(398, 25);
            this.stopFilterByStringInLog_button.Name = "stopFilterByStringInLog_button";
            this.stopFilterByStringInLog_button.Size = new System.Drawing.Size(111, 22);
            this.stopFilterByStringInLog_button.TabIndex = 7;
            this.stopFilterByStringInLog_button.Text = "Stop";
            this.stopFilterByStringInLog_button.UseVisualStyleBackColor = true;
            this.stopFilterByStringInLog_button.Click += new System.EventHandler(this.stopFilterByStringInLog_button_Click);
            // 
            // loadingLogFilter_pictureBox
            // 
            this.loadingLogFilter_pictureBox.InitialImage = null;
            this.loadingLogFilter_pictureBox.Location = new System.Drawing.Point(835, 26);
            this.loadingLogFilter_pictureBox.Name = "loadingLogFilter_pictureBox";
            this.loadingLogFilter_pictureBox.Size = new System.Drawing.Size(25, 23);
            this.loadingLogFilter_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingLogFilter_pictureBox.TabIndex = 6;
            this.loadingLogFilter_pictureBox.TabStop = false;
            // 
            // searchStringInLog_label
            // 
            this.searchStringInLog_label.AutoSize = true;
            this.searchStringInLog_label.Location = new System.Drawing.Point(7, 27);
            this.searchStringInLog_label.Name = "searchStringInLog_label";
            this.searchStringInLog_label.Size = new System.Drawing.Size(71, 13);
            this.searchStringInLog_label.TabIndex = 4;
            this.searchStringInLog_label.Text = "Search String";
            // 
            // filterByStringInLog_button
            // 
            this.filterByStringInLog_button.Enabled = false;
            this.filterByStringInLog_button.Location = new System.Drawing.Point(287, 24);
            this.filterByStringInLog_button.Name = "filterByStringInLog_button";
            this.filterByStringInLog_button.Size = new System.Drawing.Size(108, 23);
            this.filterByStringInLog_button.TabIndex = 3;
            this.filterByStringInLog_button.Text = "Search";
            this.filterByStringInLog_button.UseVisualStyleBackColor = true;
            this.filterByStringInLog_button.Click += new System.EventHandler(this.filterByStringInLog_button_Click);
            // 
            // searchStringInLog_textBox
            // 
            this.searchStringInLog_textBox.Location = new System.Drawing.Point(82, 26);
            this.searchStringInLog_textBox.Name = "searchStringInLog_textBox";
            this.searchStringInLog_textBox.Size = new System.Drawing.Size(199, 20);
            this.searchStringInLog_textBox.TabIndex = 2;
            this.searchStringInLog_textBox.TextChanged += new System.EventHandler(this.searchStringInLog_textBox_TextChanged);
            // 
            // stk_tabPage
            // 
            this.stk_tabPage.Controls.Add(this.stk_groupBox);
            this.stk_tabPage.Location = new System.Drawing.Point(4, 22);
            this.stk_tabPage.Name = "stk_tabPage";
            this.stk_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.stk_tabPage.TabIndex = 8;
            this.stk_tabPage.Text = "STK";
            this.stk_tabPage.UseVisualStyleBackColor = true;
            // 
            // stk_groupBox
            // 
            this.stk_groupBox.Controls.Add(this.stk_panel);
            this.stk_groupBox.Location = new System.Drawing.Point(5, 10);
            this.stk_groupBox.Name = "stk_groupBox";
            this.stk_groupBox.Size = new System.Drawing.Size(1242, 565);
            this.stk_groupBox.TabIndex = 0;
            this.stk_groupBox.TabStop = false;
            this.stk_groupBox.Text = "Stick ";
            // 
            // stk_panel
            // 
            this.stk_panel.Controls.Add(this.stick_dataGridView);
            this.stk_panel.Location = new System.Drawing.Point(25, 31);
            this.stk_panel.Name = "stk_panel";
            this.stk_panel.Size = new System.Drawing.Size(1240, 497);
            this.stk_panel.TabIndex = 0;
            // 
            // stick_dataGridView
            // 
            this.stick_dataGridView.AllowUserToAddRows = false;
            this.stick_dataGridView.AllowUserToDeleteRows = false;
            this.stick_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stick_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stick_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stick_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tailnumberDataGridViewTextBoxColumn3,
            this.ongroundDataGridViewTextBoxColumn,
            this.taxienabledDataGridViewTextBoxColumn,
            this.taxireportDataGridViewTextBoxColumn,
            this.taxicommandsentDataGridViewTextBoxColumn,
            this.kacntrDataGridViewTextBoxColumn});
            this.stick_dataGridView.DataSource = this.sTKTaxiTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stick_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.stick_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stick_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.stick_dataGridView.Name = "stick_dataGridView";
            this.stick_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stick_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stick_dataGridView.RowHeadersVisible = false;
            this.stick_dataGridView.Size = new System.Drawing.Size(1240, 497);
            this.stick_dataGridView.TabIndex = 0;
            // 
            // tailnumberDataGridViewTextBoxColumn3
            // 
            this.tailnumberDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tailnumberDataGridViewTextBoxColumn3.DataPropertyName = "tail_number";
            this.tailnumberDataGridViewTextBoxColumn3.HeaderText = "Tail";
            this.tailnumberDataGridViewTextBoxColumn3.Name = "tailnumberDataGridViewTextBoxColumn3";
            this.tailnumberDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ongroundDataGridViewTextBoxColumn
            // 
            this.ongroundDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ongroundDataGridViewTextBoxColumn.DataPropertyName = "on_ground";
            this.ongroundDataGridViewTextBoxColumn.HeaderText = "On Ground";
            this.ongroundDataGridViewTextBoxColumn.Name = "ongroundDataGridViewTextBoxColumn";
            this.ongroundDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxienabledDataGridViewTextBoxColumn
            // 
            this.taxienabledDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taxienabledDataGridViewTextBoxColumn.DataPropertyName = "taxi_enabled";
            this.taxienabledDataGridViewTextBoxColumn.HeaderText = "Taxi Enable\\Disable";
            this.taxienabledDataGridViewTextBoxColumn.Name = "taxienabledDataGridViewTextBoxColumn";
            this.taxienabledDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxireportDataGridViewTextBoxColumn
            // 
            this.taxireportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taxireportDataGridViewTextBoxColumn.DataPropertyName = "taxi_report";
            this.taxireportDataGridViewTextBoxColumn.HeaderText = "Taxi Report";
            this.taxireportDataGridViewTextBoxColumn.Name = "taxireportDataGridViewTextBoxColumn";
            this.taxireportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxicommandsentDataGridViewTextBoxColumn
            // 
            this.taxicommandsentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taxicommandsentDataGridViewTextBoxColumn.DataPropertyName = "taxi_command_sent";
            this.taxicommandsentDataGridViewTextBoxColumn.HeaderText = "Taxi Command Sent";
            this.taxicommandsentDataGridViewTextBoxColumn.Name = "taxicommandsentDataGridViewTextBoxColumn";
            this.taxicommandsentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kacntrDataGridViewTextBoxColumn
            // 
            this.kacntrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kacntrDataGridViewTextBoxColumn.DataPropertyName = "ka_cntr";
            this.kacntrDataGridViewTextBoxColumn.HeaderText = "Keep Alive Counter";
            this.kacntrDataGridViewTextBoxColumn.Name = "kacntrDataGridViewTextBoxColumn";
            this.kacntrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTKTaxiTableBindingSource
            // 
            this.sTKTaxiTableBindingSource.DataSource = typeof(RT_Viewer.Framework.STKModule.STKTaxiTable);
            // 
            // ird_tabPage
            // 
            this.ird_tabPage.Controls.Add(this.ird_groupBox);
            this.ird_tabPage.Location = new System.Drawing.Point(4, 22);
            this.ird_tabPage.Name = "ird_tabPage";
            this.ird_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.ird_tabPage.TabIndex = 15;
            this.ird_tabPage.Text = "IRD";
            this.ird_tabPage.UseVisualStyleBackColor = true;
            // 
            // ird_groupBox
            // 
            this.ird_groupBox.Controls.Add(this.ird_panel);
            this.ird_groupBox.Location = new System.Drawing.Point(5, 10);
            this.ird_groupBox.Name = "ird_groupBox";
            this.ird_groupBox.Size = new System.Drawing.Size(1243, 565);
            this.ird_groupBox.TabIndex = 0;
            this.ird_groupBox.TabStop = false;
            this.ird_groupBox.Text = "Iridium ";
            // 
            // ird_panel
            // 
            this.ird_panel.Controls.Add(this.iridium_dataGridView);
            this.ird_panel.Location = new System.Drawing.Point(25, 31);
            this.ird_panel.Name = "ird_panel";
            this.ird_panel.Size = new System.Drawing.Size(1240, 497);
            this.ird_panel.TabIndex = 0;
            // 
            // iridium_dataGridView
            // 
            this.iridium_dataGridView.AllowUserToAddRows = false;
            this.iridium_dataGridView.AllowUserToDeleteRows = false;
            this.iridium_dataGridView.AutoGenerateColumns = false;
            this.iridium_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iridium_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ird_tailnumber_DataGridViewTextBoxColumn,
            this.ird_modem_kind_DataGridViewTextBoxColumn,
            this.ird_is_active_DataGridViewTextBoxColumn,
            this.ird_modem_state_DataGridViewTextBoxColumn,
            this.ird_modem_init_substate_DataGridViewTextBoxColumn,
            this.ird_modem_init_done_DataGridViewTextBoxColumn,
            this.ird_modem_last_message_kind_DataGridViewTextBoxColumn,
            this.ird_modem_last_telegram_kind_DataGridViewTextBoxColumn,
            this.ird_modem_last_respons_DataGridViewTextBoxColumn,
            this.ird_modem_last_command_DataGridViewTextBoxColumn,
            this.ird_modem_last_acked_command_DataGridViewTextBoxColumn,
            this.ird_modem_reception_quality_DataGridViewTextBoxColumn,
            this.ird_received_reception_quality_DataGridViewTextBoxColumn,
            this.ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn,
            this.ird_last_aps_response_to_ring_DataGridViewTextBoxColumn});
            this.iridium_dataGridView.DataSource = this.irdTableBindingSource;
            this.iridium_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iridium_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.iridium_dataGridView.Name = "iridium_dataGridView";
            this.iridium_dataGridView.ReadOnly = true;
            this.iridium_dataGridView.RowHeadersVisible = false;
            this.iridium_dataGridView.Size = new System.Drawing.Size(1240, 497);
            this.iridium_dataGridView.TabIndex = 0;
            // 
            // ird_tailnumber_DataGridViewTextBoxColumn
            // 
            this.ird_tailnumber_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ird_tailnumber_DataGridViewTextBoxColumn.DataPropertyName = "tail_number";
            this.ird_tailnumber_DataGridViewTextBoxColumn.HeaderText = "Tail";
            this.ird_tailnumber_DataGridViewTextBoxColumn.Name = "ird_tailnumber_DataGridViewTextBoxColumn";
            this.ird_tailnumber_DataGridViewTextBoxColumn.ReadOnly = true;
            this.ird_tailnumber_DataGridViewTextBoxColumn.Width = 49;
            // 
            // ird_modem_kind_DataGridViewTextBoxColumn
            // 
            this.ird_modem_kind_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_kind_DataGridViewTextBoxColumn.DataPropertyName = "modem_kind";
            this.ird_modem_kind_DataGridViewTextBoxColumn.HeaderText = "Modem Kind";
            this.ird_modem_kind_DataGridViewTextBoxColumn.Name = "ird_modem_kind_DataGridViewTextBoxColumn";
            this.ird_modem_kind_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_is_active_DataGridViewTextBoxColumn
            // 
            this.ird_is_active_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_is_active_DataGridViewTextBoxColumn.DataPropertyName = "is_active";
            this.ird_is_active_DataGridViewTextBoxColumn.HeaderText = "Is Active";
            this.ird_is_active_DataGridViewTextBoxColumn.Name = "ird_is_active_DataGridViewTextBoxColumn";
            this.ird_is_active_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_state_DataGridViewTextBoxColumn
            // 
            this.ird_modem_state_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_state_DataGridViewTextBoxColumn.DataPropertyName = "modem_state";
            this.ird_modem_state_DataGridViewTextBoxColumn.HeaderText = "Modem State";
            this.ird_modem_state_DataGridViewTextBoxColumn.Name = "ird_modem_state_DataGridViewTextBoxColumn";
            this.ird_modem_state_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_init_substate_DataGridViewTextBoxColumn
            // 
            this.ird_modem_init_substate_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_init_substate_DataGridViewTextBoxColumn.DataPropertyName = "modem_init_substate";
            this.ird_modem_init_substate_DataGridViewTextBoxColumn.HeaderText = "Init Sub-State";
            this.ird_modem_init_substate_DataGridViewTextBoxColumn.Name = "ird_modem_init_substate_DataGridViewTextBoxColumn";
            this.ird_modem_init_substate_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_init_done_DataGridViewTextBoxColumn
            // 
            this.ird_modem_init_done_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_init_done_DataGridViewTextBoxColumn.DataPropertyName = "modem_init_done";
            this.ird_modem_init_done_DataGridViewTextBoxColumn.HeaderText = "Init Done";
            this.ird_modem_init_done_DataGridViewTextBoxColumn.Name = "ird_modem_init_done_DataGridViewTextBoxColumn";
            this.ird_modem_init_done_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_last_message_kind_DataGridViewTextBoxColumn
            // 
            this.ird_modem_last_message_kind_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_last_message_kind_DataGridViewTextBoxColumn.DataPropertyName = "modem_last_message_kind";
            this.ird_modem_last_message_kind_DataGridViewTextBoxColumn.FillWeight = 170F;
            this.ird_modem_last_message_kind_DataGridViewTextBoxColumn.HeaderText = "Last Message From Modem";
            this.ird_modem_last_message_kind_DataGridViewTextBoxColumn.Name = "ird_modem_last_message_kind_DataGridViewTextBoxColumn";
            this.ird_modem_last_message_kind_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_last_telegram_kind_DataGridViewTextBoxColumn
            // 
            this.ird_modem_last_telegram_kind_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_last_telegram_kind_DataGridViewTextBoxColumn.DataPropertyName = "modem_last_telegram_kind";
            this.ird_modem_last_telegram_kind_DataGridViewTextBoxColumn.HeaderText = "Last Telegram Kind from Modem";
            this.ird_modem_last_telegram_kind_DataGridViewTextBoxColumn.Name = "ird_modem_last_telegram_kind_DataGridViewTextBoxColumn";
            this.ird_modem_last_telegram_kind_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_last_respons_DataGridViewTextBoxColumn
            // 
            this.ird_modem_last_respons_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_last_respons_DataGridViewTextBoxColumn.DataPropertyName = "modem_last_respons";
            this.ird_modem_last_respons_DataGridViewTextBoxColumn.FillWeight = 150F;
            this.ird_modem_last_respons_DataGridViewTextBoxColumn.HeaderText = "Modem Last Response";
            this.ird_modem_last_respons_DataGridViewTextBoxColumn.Name = "ird_modem_last_respons_DataGridViewTextBoxColumn";
            this.ird_modem_last_respons_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_last_command_DataGridViewTextBoxColumn
            // 
            this.ird_modem_last_command_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_last_command_DataGridViewTextBoxColumn.DataPropertyName = "modem_last_command";
            this.ird_modem_last_command_DataGridViewTextBoxColumn.FillWeight = 150F;
            this.ird_modem_last_command_DataGridViewTextBoxColumn.HeaderText = "Last command sent to modem";
            this.ird_modem_last_command_DataGridViewTextBoxColumn.Name = "ird_modem_last_command_DataGridViewTextBoxColumn";
            this.ird_modem_last_command_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_last_acked_command_DataGridViewTextBoxColumn
            // 
            this.ird_modem_last_acked_command_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_last_acked_command_DataGridViewTextBoxColumn.DataPropertyName = "modem_last_acked_command";
            this.ird_modem_last_acked_command_DataGridViewTextBoxColumn.HeaderText = "Last command acked by modem";
            this.ird_modem_last_acked_command_DataGridViewTextBoxColumn.Name = "ird_modem_last_acked_command_DataGridViewTextBoxColumn";
            this.ird_modem_last_acked_command_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_reception_quality_DataGridViewTextBoxColumn
            // 
            this.ird_modem_reception_quality_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_reception_quality_DataGridViewTextBoxColumn.DataPropertyName = "modem_reception_quality";
            this.ird_modem_reception_quality_DataGridViewTextBoxColumn.HeaderText = "Signal Qual";
            this.ird_modem_reception_quality_DataGridViewTextBoxColumn.Name = "ird_modem_reception_quality_DataGridViewTextBoxColumn";
            this.ird_modem_reception_quality_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_received_reception_quality_DataGridViewTextBoxColumn
            // 
            this.ird_received_reception_quality_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_received_reception_quality_DataGridViewTextBoxColumn.DataPropertyName = "received_reception_quality";
            this.ird_received_reception_quality_DataGridViewTextBoxColumn.HeaderText = "Received signal quality";
            this.ird_received_reception_quality_DataGridViewTextBoxColumn.Name = "ird_received_reception_quality_DataGridViewTextBoxColumn";
            this.ird_received_reception_quality_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn
            // 
            this.ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn.DataPropertyName = "modem_is_ready_to_connect";
            this.ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn.HeaderText = "Modem is ready to connect";
            this.ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn.Name = "ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn";
            this.ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ird_last_aps_response_to_ring_DataGridViewTextBoxColumn
            // 
            this.ird_last_aps_response_to_ring_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ird_last_aps_response_to_ring_DataGridViewTextBoxColumn.DataPropertyName = "last_aps_response_to_ring";
            this.ird_last_aps_response_to_ring_DataGridViewTextBoxColumn.HeaderText = "Last ASP respons to RING";
            this.ird_last_aps_response_to_ring_DataGridViewTextBoxColumn.Name = "ird_last_aps_response_to_ring_DataGridViewTextBoxColumn";
            this.ird_last_aps_response_to_ring_DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // irdTableBindingSource
            // 
            this.irdTableBindingSource.DataSource = typeof(RT_Viewer.Framework.IRDModule.IRDModemTable);
            // 
            // nvm_tabPage
            // 
            this.nvm_tabPage.Controls.Add(this.nvramWrite_groupBox);
            this.nvm_tabPage.Controls.Add(this.nvramRead_groupBox);
            this.nvm_tabPage.Location = new System.Drawing.Point(4, 22);
            this.nvm_tabPage.Name = "nvm_tabPage";
            this.nvm_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nvm_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.nvm_tabPage.TabIndex = 6;
            this.nvm_tabPage.Text = "NVM";
            this.nvm_tabPage.UseVisualStyleBackColor = true;
            // 
            // nvramWrite_groupBox
            // 
            this.nvramWrite_groupBox.Controls.Add(this.loadingNVRAMWrite_pictureBox);
            this.nvramWrite_groupBox.Controls.Add(this.idGcsWriteData_button);
            this.nvramWrite_groupBox.Controls.Add(this.idGcsWriteData_textBox);
            this.nvramWrite_groupBox.Controls.Add(this.idGcsWriteData_label);
            this.nvramWrite_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvramWrite_groupBox.Location = new System.Drawing.Point(6, 135);
            this.nvramWrite_groupBox.Name = "nvramWrite_groupBox";
            this.nvramWrite_groupBox.Size = new System.Drawing.Size(1240, 127);
            this.nvramWrite_groupBox.TabIndex = 1;
            this.nvramWrite_groupBox.TabStop = false;
            this.nvramWrite_groupBox.Text = "NVRAM Write Data";
            // 
            // loadingNVRAMWrite_pictureBox
            // 
            this.loadingNVRAMWrite_pictureBox.InitialImage = null;
            this.loadingNVRAMWrite_pictureBox.Location = new System.Drawing.Point(319, 51);
            this.loadingNVRAMWrite_pictureBox.Name = "loadingNVRAMWrite_pictureBox";
            this.loadingNVRAMWrite_pictureBox.Size = new System.Drawing.Size(25, 23);
            this.loadingNVRAMWrite_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingNVRAMWrite_pictureBox.TabIndex = 7;
            this.loadingNVRAMWrite_pictureBox.TabStop = false;
            // 
            // idGcsWriteData_button
            // 
            this.idGcsWriteData_button.Location = new System.Drawing.Point(225, 51);
            this.idGcsWriteData_button.Name = "idGcsWriteData_button";
            this.idGcsWriteData_button.Size = new System.Drawing.Size(75, 25);
            this.idGcsWriteData_button.TabIndex = 5;
            this.idGcsWriteData_button.Text = "Write Data";
            this.idGcsWriteData_button.UseVisualStyleBackColor = true;
            this.idGcsWriteData_button.Click += new System.EventHandler(this.idGcsWriteData_button_Click);
            // 
            // idGcsWriteData_textBox
            // 
            this.idGcsWriteData_textBox.Location = new System.Drawing.Point(103, 54);
            this.idGcsWriteData_textBox.Name = "idGcsWriteData_textBox";
            this.idGcsWriteData_textBox.Size = new System.Drawing.Size(100, 20);
            this.idGcsWriteData_textBox.TabIndex = 4;
            this.idGcsWriteData_textBox.TextChanged += new System.EventHandler(this.idGCSWriteData_TextChanged);
            // 
            // idGcsWriteData_label
            // 
            this.idGcsWriteData_label.AutoSize = true;
            this.idGcsWriteData_label.Location = new System.Drawing.Point(28, 57);
            this.idGcsWriteData_label.Name = "idGcsWriteData_label";
            this.idGcsWriteData_label.Size = new System.Drawing.Size(43, 13);
            this.idGcsWriteData_label.TabIndex = 3;
            this.idGcsWriteData_label.Text = "GCS ID";
            // 
            // nvramRead_groupBox
            // 
            this.nvramRead_groupBox.Controls.Add(this.idGCSRead_button);
            this.nvramRead_groupBox.Controls.Add(this.idGcsReadData_textBox);
            this.nvramRead_groupBox.Controls.Add(this.idGcsReadData_label);
            this.nvramRead_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvramRead_groupBox.Location = new System.Drawing.Point(6, 6);
            this.nvramRead_groupBox.Name = "nvramRead_groupBox";
            this.nvramRead_groupBox.Size = new System.Drawing.Size(1240, 123);
            this.nvramRead_groupBox.TabIndex = 0;
            this.nvramRead_groupBox.TabStop = false;
            this.nvramRead_groupBox.Text = "NVRAM Read Data";
            // 
            // idGCSRead_button
            // 
            this.idGCSRead_button.Location = new System.Drawing.Point(225, 48);
            this.idGCSRead_button.Name = "idGCSRead_button";
            this.idGCSRead_button.Size = new System.Drawing.Size(75, 23);
            this.idGCSRead_button.TabIndex = 2;
            this.idGCSRead_button.Text = "Read Data from NVRAM";
            this.idGCSRead_button.UseVisualStyleBackColor = true;
            this.idGCSRead_button.Click += new System.EventHandler(this.idGCSRead_button_Click);
            // 
            // idGcsReadData_textBox
            // 
            this.idGcsReadData_textBox.Enabled = false;
            this.idGcsReadData_textBox.Location = new System.Drawing.Point(103, 50);
            this.idGcsReadData_textBox.Name = "idGcsReadData_textBox";
            this.idGcsReadData_textBox.Size = new System.Drawing.Size(100, 20);
            this.idGcsReadData_textBox.TabIndex = 1;
            this.idGcsReadData_textBox.TextChanged += new System.EventHandler(this.idGCSReadData_TextChanged);
            // 
            // idGcsReadData_label
            // 
            this.idGcsReadData_label.AutoSize = true;
            this.idGcsReadData_label.Location = new System.Drawing.Point(28, 53);
            this.idGcsReadData_label.Name = "idGcsReadData_label";
            this.idGcsReadData_label.Size = new System.Drawing.Size(43, 13);
            this.idGcsReadData_label.TabIndex = 0;
            this.idGcsReadData_label.Text = "GCS ID";
            // 
            // hky_tabPage
            // 
            this.hky_tabPage.Controls.Add(this.hky_tabControl);
            this.hky_tabPage.Location = new System.Drawing.Point(4, 22);
            this.hky_tabPage.Name = "hky_tabPage";
            this.hky_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.hky_tabPage.TabIndex = 9;
            this.hky_tabPage.Text = "HKY";
            this.hky_tabPage.UseVisualStyleBackColor = true;
            // 
            // hky_tabControl
            // 
            this.hky_tabControl.Controls.Add(this.keys_tabPage);
            this.hky_tabControl.Controls.Add(this.led_tabPage);
            this.hky_tabControl.Controls.Add(this.headingKnob_tabPage);
            this.hky_tabControl.Location = new System.Drawing.Point(3, 3);
            this.hky_tabControl.Name = "hky_tabControl";
            this.hky_tabControl.SelectedIndex = 0;
            this.hky_tabControl.Size = new System.Drawing.Size(1254, 584);
            this.hky_tabControl.TabIndex = 16;
            // 
            // keys_tabPage
            // 
            this.keys_tabPage.Controls.Add(this.hky_keys_Console2_groupBox);
            this.keys_tabPage.Controls.Add(this.hky_keys_Console1_groupBox);
            this.keys_tabPage.Location = new System.Drawing.Point(4, 22);
            this.keys_tabPage.Name = "keys_tabPage";
            this.keys_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.keys_tabPage.Size = new System.Drawing.Size(1246, 558);
            this.keys_tabPage.TabIndex = 1;
            this.keys_tabPage.Text = "Hard Keys";
            this.keys_tabPage.UseVisualStyleBackColor = true;
            // 
            // hky_keys_Console2_groupBox
            // 
            this.hky_keys_Console2_groupBox.Controls.Add(this.console2Keys_panel);
            this.hky_keys_Console2_groupBox.Location = new System.Drawing.Point(7, 282);
            this.hky_keys_Console2_groupBox.Name = "hky_keys_Console2_groupBox";
            this.hky_keys_Console2_groupBox.Size = new System.Drawing.Size(1274, 273);
            this.hky_keys_Console2_groupBox.TabIndex = 2;
            this.hky_keys_Console2_groupBox.TabStop = false;
            this.hky_keys_Console2_groupBox.Text = "Console 2 (Right)";
            // 
            // console2Keys_panel
            // 
            this.console2Keys_panel.Controls.Add(this.keysHKYConsole2_flowLayoutPanel);
            this.console2Keys_panel.Location = new System.Drawing.Point(12, 17);
            this.console2Keys_panel.Name = "console2Keys_panel";
            this.console2Keys_panel.Size = new System.Drawing.Size(1242, 250);
            this.console2Keys_panel.TabIndex = 2;
            // 
            // keysHKYConsole2_flowLayoutPanel
            // 
            this.keysHKYConsole2_flowLayoutPanel.AutoSize = true;
            this.keysHKYConsole2_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysHKYConsole2_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.keysHKYConsole2_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.keysHKYConsole2_flowLayoutPanel.Name = "keysHKYConsole2_flowLayoutPanel";
            this.keysHKYConsole2_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.keysHKYConsole2_flowLayoutPanel.Size = new System.Drawing.Size(1242, 250);
            this.keysHKYConsole2_flowLayoutPanel.TabIndex = 0;
            // 
            // hky_keys_Console1_groupBox
            // 
            this.hky_keys_Console1_groupBox.Controls.Add(this.console1Keys_panel);
            this.hky_keys_Console1_groupBox.Location = new System.Drawing.Point(7, 6);
            this.hky_keys_Console1_groupBox.Name = "hky_keys_Console1_groupBox";
            this.hky_keys_Console1_groupBox.Size = new System.Drawing.Size(1270, 270);
            this.hky_keys_Console1_groupBox.TabIndex = 3;
            this.hky_keys_Console1_groupBox.TabStop = false;
            this.hky_keys_Console1_groupBox.Text = "Console 1 (Left)";
            // 
            // console1Keys_panel
            // 
            this.console1Keys_panel.Controls.Add(this.keysHKYConsole1_flowLayoutPanel);
            this.console1Keys_panel.Location = new System.Drawing.Point(12, 12);
            this.console1Keys_panel.Name = "console1Keys_panel";
            this.console1Keys_panel.Size = new System.Drawing.Size(1242, 251);
            this.console1Keys_panel.TabIndex = 3;
            // 
            // keysHKYConsole1_flowLayoutPanel
            // 
            this.keysHKYConsole1_flowLayoutPanel.AutoSize = true;
            this.keysHKYConsole1_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysHKYConsole1_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.keysHKYConsole1_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.keysHKYConsole1_flowLayoutPanel.Name = "keysHKYConsole1_flowLayoutPanel";
            this.keysHKYConsole1_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.keysHKYConsole1_flowLayoutPanel.Size = new System.Drawing.Size(1242, 251);
            this.keysHKYConsole1_flowLayoutPanel.TabIndex = 1;
            // 
            // led_tabPage
            // 
            this.led_tabPage.Controls.Add(this.stkConsole2_groupBox);
            this.led_tabPage.Controls.Add(this.stkConsole1_groupBox);
            this.led_tabPage.Location = new System.Drawing.Point(4, 22);
            this.led_tabPage.Name = "led_tabPage";
            this.led_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.led_tabPage.Size = new System.Drawing.Size(1246, 558);
            this.led_tabPage.TabIndex = 0;
            this.led_tabPage.Text = "Leds";
            this.led_tabPage.UseVisualStyleBackColor = true;
            // 
            // stkConsole2_groupBox
            // 
            this.stkConsole2_groupBox.Controls.Add(this.console1Led_panel);
            this.stkConsole2_groupBox.Controls.Add(this.hkyConsole2Tail_textBox);
            this.stkConsole2_groupBox.Controls.Add(this.hkyConsole2Tail_label);
            this.stkConsole2_groupBox.Location = new System.Drawing.Point(8, 278);
            this.stkConsole2_groupBox.Name = "stkConsole2_groupBox";
            this.stkConsole2_groupBox.Size = new System.Drawing.Size(1274, 274);
            this.stkConsole2_groupBox.TabIndex = 0;
            this.stkConsole2_groupBox.TabStop = false;
            this.stkConsole2_groupBox.Text = "Console 2 (Right)";
            // 
            // console1Led_panel
            // 
            this.console1Led_panel.Controls.Add(this.ledHKYConsole2_flowLayoutPanel);
            this.console1Led_panel.Location = new System.Drawing.Point(12, 49);
            this.console1Led_panel.Name = "console1Led_panel";
            this.console1Led_panel.Size = new System.Drawing.Size(1242, 216);
            this.console1Led_panel.TabIndex = 2;
            // 
            // ledHKYConsole2_flowLayoutPanel
            // 
            this.ledHKYConsole2_flowLayoutPanel.AutoSize = true;
            this.ledHKYConsole2_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledHKYConsole2_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ledHKYConsole2_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ledHKYConsole2_flowLayoutPanel.Name = "ledHKYConsole2_flowLayoutPanel";
            this.ledHKYConsole2_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ledHKYConsole2_flowLayoutPanel.Size = new System.Drawing.Size(1242, 216);
            this.ledHKYConsole2_flowLayoutPanel.TabIndex = 0;
            // 
            // hkyConsole2Tail_textBox
            // 
            this.hkyConsole2Tail_textBox.Location = new System.Drawing.Point(89, 23);
            this.hkyConsole2Tail_textBox.Name = "hkyConsole2Tail_textBox";
            this.hkyConsole2Tail_textBox.ReadOnly = true;
            this.hkyConsole2Tail_textBox.Size = new System.Drawing.Size(92, 20);
            this.hkyConsole2Tail_textBox.TabIndex = 2;
            this.hkyConsole2Tail_textBox.Text = "N/A";
            // 
            // hkyConsole2Tail_label
            // 
            this.hkyConsole2Tail_label.AutoSize = true;
            this.hkyConsole2Tail_label.Location = new System.Drawing.Point(9, 26);
            this.hkyConsole2Tail_label.Name = "hkyConsole2Tail_label";
            this.hkyConsole2Tail_label.Size = new System.Drawing.Size(64, 13);
            this.hkyConsole2Tail_label.TabIndex = 1;
            this.hkyConsole2Tail_label.Text = "Tail Number";
            // 
            // stkConsole1_groupBox
            // 
            this.stkConsole1_groupBox.Controls.Add(this.console2Led_panel);
            this.stkConsole1_groupBox.Controls.Add(this.hkyConsole1Tail_label);
            this.stkConsole1_groupBox.Controls.Add(this.hkyConsole1Tail_textBox);
            this.stkConsole1_groupBox.Location = new System.Drawing.Point(8, 6);
            this.stkConsole1_groupBox.Name = "stkConsole1_groupBox";
            this.stkConsole1_groupBox.Size = new System.Drawing.Size(1270, 266);
            this.stkConsole1_groupBox.TabIndex = 1;
            this.stkConsole1_groupBox.TabStop = false;
            this.stkConsole1_groupBox.Text = "Console 1 (Left)";
            // 
            // console2Led_panel
            // 
            this.console2Led_panel.Controls.Add(this.ledHKYConsole1_flowLayoutPanel);
            this.console2Led_panel.Location = new System.Drawing.Point(12, 41);
            this.console2Led_panel.Name = "console2Led_panel";
            this.console2Led_panel.Size = new System.Drawing.Size(1242, 219);
            this.console2Led_panel.TabIndex = 3;
            // 
            // ledHKYConsole1_flowLayoutPanel
            // 
            this.ledHKYConsole1_flowLayoutPanel.AutoSize = true;
            this.ledHKYConsole1_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledHKYConsole1_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ledHKYConsole1_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ledHKYConsole1_flowLayoutPanel.Name = "ledHKYConsole1_flowLayoutPanel";
            this.ledHKYConsole1_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ledHKYConsole1_flowLayoutPanel.Size = new System.Drawing.Size(1242, 219);
            this.ledHKYConsole1_flowLayoutPanel.TabIndex = 1;
            // 
            // hkyConsole1Tail_label
            // 
            this.hkyConsole1Tail_label.AutoSize = true;
            this.hkyConsole1Tail_label.Location = new System.Drawing.Point(9, 19);
            this.hkyConsole1Tail_label.Name = "hkyConsole1Tail_label";
            this.hkyConsole1Tail_label.Size = new System.Drawing.Size(64, 13);
            this.hkyConsole1Tail_label.TabIndex = 0;
            this.hkyConsole1Tail_label.Text = "Tail Number";
            // 
            // hkyConsole1Tail_textBox
            // 
            this.hkyConsole1Tail_textBox.Location = new System.Drawing.Point(89, 15);
            this.hkyConsole1Tail_textBox.Name = "hkyConsole1Tail_textBox";
            this.hkyConsole1Tail_textBox.ReadOnly = true;
            this.hkyConsole1Tail_textBox.Size = new System.Drawing.Size(92, 20);
            this.hkyConsole1Tail_textBox.TabIndex = 1;
            this.hkyConsole1Tail_textBox.Text = "N/A";
            // 
            // headingKnob_tabPage
            // 
            this.headingKnob_tabPage.Controls.Add(this.headingKnob_groupBox);
            this.headingKnob_tabPage.Location = new System.Drawing.Point(4, 22);
            this.headingKnob_tabPage.Name = "headingKnob_tabPage";
            this.headingKnob_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.headingKnob_tabPage.Size = new System.Drawing.Size(1246, 558);
            this.headingKnob_tabPage.TabIndex = 2;
            this.headingKnob_tabPage.Text = "Heading Knob";
            this.headingKnob_tabPage.UseVisualStyleBackColor = true;
            // 
            // headingKnob_groupBox
            // 
            this.headingKnob_groupBox.Controls.Add(this.HKY_KnobConsole2Gb);
            this.headingKnob_groupBox.Controls.Add(this.HKY_KnobConsole1Gb);
            this.headingKnob_groupBox.Location = new System.Drawing.Point(8, 6);
            this.headingKnob_groupBox.Name = "headingKnob_groupBox";
            this.headingKnob_groupBox.Size = new System.Drawing.Size(1274, 546);
            this.headingKnob_groupBox.TabIndex = 0;
            this.headingKnob_groupBox.TabStop = false;
            this.headingKnob_groupBox.Text = "Heading Knob";
            // 
            // HKY_KnobConsole2Gb
            // 
            this.HKY_KnobConsole2Gb.Controls.Add(this.PresetKnob2Btn);
            this.HKY_KnobConsole2Gb.Controls.Add(this.StartStopKnob2Btn);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2_raw_position_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.label6);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2Position_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.label7);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2VendorID3_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2VendorID2_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2InitStatus_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.label8);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2VendorID1_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.label9);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2Calculated_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.label10);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2Read4_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2Read3_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2Read2_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.HN2Read1_textBox);
            this.HKY_KnobConsole2Gb.Controls.Add(this.label11);
            this.HKY_KnobConsole2Gb.Location = new System.Drawing.Point(15, 257);
            this.HKY_KnobConsole2Gb.Name = "HKY_KnobConsole2Gb";
            this.HKY_KnobConsole2Gb.Size = new System.Drawing.Size(1084, 199);
            this.HKY_KnobConsole2Gb.TabIndex = 20;
            this.HKY_KnobConsole2Gb.TabStop = false;
            this.HKY_KnobConsole2Gb.Text = "Console 2 (Right)";
            // 
            // PresetKnob2Btn
            // 
            this.PresetKnob2Btn.Enabled = false;
            this.PresetKnob2Btn.Location = new System.Drawing.Point(932, 161);
            this.PresetKnob2Btn.Name = "PresetKnob2Btn";
            this.PresetKnob2Btn.Size = new System.Drawing.Size(130, 23);
            this.PresetKnob2Btn.TabIndex = 18;
            this.PresetKnob2Btn.Text = "Preset";
            this.PresetKnob2Btn.UseVisualStyleBackColor = true;
            this.PresetKnob2Btn.Click += new System.EventHandler(this.PresetKnob2Btn_Click);
            // 
            // StartStopKnob2Btn
            // 
            this.StartStopKnob2Btn.Enabled = false;
            this.StartStopKnob2Btn.Location = new System.Drawing.Point(725, 161);
            this.StartStopKnob2Btn.Name = "StartStopKnob2Btn";
            this.StartStopKnob2Btn.Size = new System.Drawing.Size(145, 23);
            this.StartStopKnob2Btn.TabIndex = 17;
            this.StartStopKnob2Btn.Text = "Press to Start Reading";
            this.StartStopKnob2Btn.UseVisualStyleBackColor = true;
            this.StartStopKnob2Btn.Click += new System.EventHandler(this.StartStopKnob2Btn_Click);
            // 
            // HN2_raw_position_textBox
            // 
            this.HN2_raw_position_textBox.Location = new System.Drawing.Point(171, 91);
            this.HN2_raw_position_textBox.Name = "HN2_raw_position_textBox";
            this.HN2_raw_position_textBox.ReadOnly = true;
            this.HN2_raw_position_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2_raw_position_textBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Raw Position (No Inverse)";
            // 
            // HN2Position_textBox
            // 
            this.HN2Position_textBox.Location = new System.Drawing.Point(438, 88);
            this.HN2Position_textBox.Name = "HN2Position_textBox";
            this.HN2Position_textBox.ReadOnly = true;
            this.HN2Position_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2Position_textBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Heading Knob Position";
            // 
            // HN2VendorID3_textBox
            // 
            this.HN2VendorID3_textBox.Location = new System.Drawing.Point(438, 128);
            this.HN2VendorID3_textBox.Name = "HN2VendorID3_textBox";
            this.HN2VendorID3_textBox.ReadOnly = true;
            this.HN2VendorID3_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2VendorID3_textBox.TabIndex = 12;
            // 
            // HN2VendorID2_textBox
            // 
            this.HN2VendorID2_textBox.Location = new System.Drawing.Point(308, 128);
            this.HN2VendorID2_textBox.Name = "HN2VendorID2_textBox";
            this.HN2VendorID2_textBox.ReadOnly = true;
            this.HN2VendorID2_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2VendorID2_textBox.TabIndex = 11;
            // 
            // HN2InitStatus_textBox
            // 
            this.HN2InitStatus_textBox.Location = new System.Drawing.Point(171, 166);
            this.HN2InitStatus_textBox.Name = "HN2InitStatus_textBox";
            this.HN2InitStatus_textBox.ReadOnly = true;
            this.HN2InitStatus_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2InitStatus_textBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Init Status";
            // 
            // HN2VendorID1_textBox
            // 
            this.HN2VendorID1_textBox.Location = new System.Drawing.Point(171, 128);
            this.HN2VendorID1_textBox.Name = "HN2VendorID1_textBox";
            this.HN2VendorID1_textBox.ReadOnly = true;
            this.HN2VendorID1_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2VendorID1_textBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Vendor ID";
            // 
            // HN2Calculated_textBox
            // 
            this.HN2Calculated_textBox.Location = new System.Drawing.Point(171, 55);
            this.HN2Calculated_textBox.Name = "HN2Calculated_textBox";
            this.HN2Calculated_textBox.ReadOnly = true;
            this.HN2Calculated_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2Calculated_textBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Calculated CRC";
            // 
            // HN2Read4_textBox
            // 
            this.HN2Read4_textBox.Location = new System.Drawing.Point(574, 18);
            this.HN2Read4_textBox.Name = "HN2Read4_textBox";
            this.HN2Read4_textBox.ReadOnly = true;
            this.HN2Read4_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2Read4_textBox.TabIndex = 4;
            // 
            // HN2Read3_textBox
            // 
            this.HN2Read3_textBox.Location = new System.Drawing.Point(438, 18);
            this.HN2Read3_textBox.Name = "HN2Read3_textBox";
            this.HN2Read3_textBox.ReadOnly = true;
            this.HN2Read3_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2Read3_textBox.TabIndex = 3;
            // 
            // HN2Read2_textBox
            // 
            this.HN2Read2_textBox.Location = new System.Drawing.Point(311, 18);
            this.HN2Read2_textBox.Name = "HN2Read2_textBox";
            this.HN2Read2_textBox.ReadOnly = true;
            this.HN2Read2_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2Read2_textBox.TabIndex = 2;
            // 
            // HN2Read1_textBox
            // 
            this.HN2Read1_textBox.Location = new System.Drawing.Point(171, 18);
            this.HN2Read1_textBox.Name = "HN2Read1_textBox";
            this.HN2Read1_textBox.ReadOnly = true;
            this.HN2Read1_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN2Read1_textBox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Reading Response";
            // 
            // HKY_KnobConsole1Gb
            // 
            this.HKY_KnobConsole1Gb.Controls.Add(this.PresetKnob1Btn);
            this.HKY_KnobConsole1Gb.Controls.Add(this.StartStopKnob1Btn);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1_raw_position_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.rowPosition_label);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1Position_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HNPosition_label);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1VendorID3_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1VendorID2_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1InitStatus_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.label5);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1VendorID1_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.label4);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1Calculated_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.label3);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1Read4_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1Read3_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1Read2_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.HN1Read1_textBox);
            this.HKY_KnobConsole1Gb.Controls.Add(this.label2);
            this.HKY_KnobConsole1Gb.Location = new System.Drawing.Point(15, 24);
            this.HKY_KnobConsole1Gb.Name = "HKY_KnobConsole1Gb";
            this.HKY_KnobConsole1Gb.Size = new System.Drawing.Size(1084, 199);
            this.HKY_KnobConsole1Gb.TabIndex = 19;
            this.HKY_KnobConsole1Gb.TabStop = false;
            this.HKY_KnobConsole1Gb.Text = "Console 1 (Left)";
            // 
            // PresetKnob1Btn
            // 
            this.PresetKnob1Btn.Enabled = false;
            this.PresetKnob1Btn.Location = new System.Drawing.Point(932, 161);
            this.PresetKnob1Btn.Name = "PresetKnob1Btn";
            this.PresetKnob1Btn.Size = new System.Drawing.Size(130, 23);
            this.PresetKnob1Btn.TabIndex = 18;
            this.PresetKnob1Btn.Text = "Preset";
            this.PresetKnob1Btn.UseVisualStyleBackColor = true;
            this.PresetKnob1Btn.Click += new System.EventHandler(this.PresetKnob1Btn_Click);
            // 
            // StartStopKnob1Btn
            // 
            this.StartStopKnob1Btn.Enabled = false;
            this.StartStopKnob1Btn.Location = new System.Drawing.Point(725, 161);
            this.StartStopKnob1Btn.Name = "StartStopKnob1Btn";
            this.StartStopKnob1Btn.Size = new System.Drawing.Size(145, 23);
            this.StartStopKnob1Btn.TabIndex = 17;
            this.StartStopKnob1Btn.Text = "Press to Start Reading";
            this.StartStopKnob1Btn.UseVisualStyleBackColor = true;
            this.StartStopKnob1Btn.Click += new System.EventHandler(this.StartStopKnob1Btn_Click);
            // 
            // HN1_raw_position_textBox
            // 
            this.HN1_raw_position_textBox.Location = new System.Drawing.Point(171, 91);
            this.HN1_raw_position_textBox.Name = "HN1_raw_position_textBox";
            this.HN1_raw_position_textBox.ReadOnly = true;
            this.HN1_raw_position_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1_raw_position_textBox.TabIndex = 16;
            // 
            // rowPosition_label
            // 
            this.rowPosition_label.AutoSize = true;
            this.rowPosition_label.Location = new System.Drawing.Point(14, 91);
            this.rowPosition_label.Name = "rowPosition_label";
            this.rowPosition_label.Size = new System.Drawing.Size(130, 13);
            this.rowPosition_label.TabIndex = 15;
            this.rowPosition_label.Text = "Raw Position (No Inverse)";
            // 
            // HN1Position_textBox
            // 
            this.HN1Position_textBox.Location = new System.Drawing.Point(438, 88);
            this.HN1Position_textBox.Name = "HN1Position_textBox";
            this.HN1Position_textBox.ReadOnly = true;
            this.HN1Position_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1Position_textBox.TabIndex = 14;
            // 
            // HNPosition_label
            // 
            this.HNPosition_label.AutoSize = true;
            this.HNPosition_label.Location = new System.Drawing.Point(305, 94);
            this.HNPosition_label.Name = "HNPosition_label";
            this.HNPosition_label.Size = new System.Drawing.Size(115, 13);
            this.HNPosition_label.TabIndex = 13;
            this.HNPosition_label.Text = "Heading Knob Position";
            // 
            // HN1VendorID3_textBox
            // 
            this.HN1VendorID3_textBox.Location = new System.Drawing.Point(438, 128);
            this.HN1VendorID3_textBox.Name = "HN1VendorID3_textBox";
            this.HN1VendorID3_textBox.ReadOnly = true;
            this.HN1VendorID3_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1VendorID3_textBox.TabIndex = 12;
            // 
            // HN1VendorID2_textBox
            // 
            this.HN1VendorID2_textBox.Location = new System.Drawing.Point(308, 128);
            this.HN1VendorID2_textBox.Name = "HN1VendorID2_textBox";
            this.HN1VendorID2_textBox.ReadOnly = true;
            this.HN1VendorID2_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1VendorID2_textBox.TabIndex = 11;
            // 
            // HN1InitStatus_textBox
            // 
            this.HN1InitStatus_textBox.Location = new System.Drawing.Point(171, 166);
            this.HN1InitStatus_textBox.Name = "HN1InitStatus_textBox";
            this.HN1InitStatus_textBox.ReadOnly = true;
            this.HN1InitStatus_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1InitStatus_textBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Init Status";
            // 
            // HN1VendorID1_textBox
            // 
            this.HN1VendorID1_textBox.Location = new System.Drawing.Point(171, 128);
            this.HN1VendorID1_textBox.Name = "HN1VendorID1_textBox";
            this.HN1VendorID1_textBox.ReadOnly = true;
            this.HN1VendorID1_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1VendorID1_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vendor ID";
            // 
            // HN1Calculated_textBox
            // 
            this.HN1Calculated_textBox.Location = new System.Drawing.Point(171, 56);
            this.HN1Calculated_textBox.Name = "HN1Calculated_textBox";
            this.HN1Calculated_textBox.ReadOnly = true;
            this.HN1Calculated_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1Calculated_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calculated CRC";
            // 
            // HN1Read4_textBox
            // 
            this.HN1Read4_textBox.Location = new System.Drawing.Point(574, 18);
            this.HN1Read4_textBox.Name = "HN1Read4_textBox";
            this.HN1Read4_textBox.ReadOnly = true;
            this.HN1Read4_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1Read4_textBox.TabIndex = 4;
            // 
            // HN1Read3_textBox
            // 
            this.HN1Read3_textBox.Location = new System.Drawing.Point(438, 18);
            this.HN1Read3_textBox.Name = "HN1Read3_textBox";
            this.HN1Read3_textBox.ReadOnly = true;
            this.HN1Read3_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1Read3_textBox.TabIndex = 3;
            // 
            // HN1Read2_textBox
            // 
            this.HN1Read2_textBox.Location = new System.Drawing.Point(311, 18);
            this.HN1Read2_textBox.Name = "HN1Read2_textBox";
            this.HN1Read2_textBox.ReadOnly = true;
            this.HN1Read2_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1Read2_textBox.TabIndex = 2;
            // 
            // HN1Read1_textBox
            // 
            this.HN1Read1_textBox.Location = new System.Drawing.Point(174, 18);
            this.HN1Read1_textBox.Name = "HN1Read1_textBox";
            this.HN1Read1_textBox.ReadOnly = true;
            this.HN1Read1_textBox.Size = new System.Drawing.Size(106, 20);
            this.HN1Read1_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reading Response";
            // 
            // pfd_tabPage
            // 
            this.pfd_tabPage.Controls.Add(this.pfdUpl_groupBox);
            this.pfd_tabPage.Location = new System.Drawing.Point(4, 22);
            this.pfd_tabPage.Name = "pfd_tabPage";
            this.pfd_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pfd_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.pfd_tabPage.TabIndex = 11;
            this.pfd_tabPage.Text = "PFD";
            this.pfd_tabPage.UseVisualStyleBackColor = true;
            // 
            // pfdUpl_groupBox
            // 
            this.pfdUpl_groupBox.Controls.Add(this.rollData_textBox);
            this.pfdUpl_groupBox.Controls.Add(this.roll_label);
            this.pfdUpl_groupBox.Controls.Add(this.pitchData_textBox);
            this.pfdUpl_groupBox.Controls.Add(this.pitch_label);
            this.pfdUpl_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pfdUpl_groupBox.Location = new System.Drawing.Point(6, 3);
            this.pfdUpl_groupBox.Name = "pfdUpl_groupBox";
            this.pfdUpl_groupBox.Size = new System.Drawing.Size(1243, 282);
            this.pfdUpl_groupBox.TabIndex = 1;
            this.pfdUpl_groupBox.TabStop = false;
            this.pfdUpl_groupBox.Text = "PFD Upl";
            // 
            // rollData_textBox
            // 
            this.rollData_textBox.AllowDrop = true;
            this.rollData_textBox.Enabled = false;
            this.rollData_textBox.Location = new System.Drawing.Point(89, 80);
            this.rollData_textBox.Name = "rollData_textBox";
            this.rollData_textBox.Size = new System.Drawing.Size(166, 20);
            this.rollData_textBox.TabIndex = 3;
            // 
            // roll_label
            // 
            this.roll_label.AutoSize = true;
            this.roll_label.Location = new System.Drawing.Point(19, 83);
            this.roll_label.Name = "roll_label";
            this.roll_label.Size = new System.Drawing.Size(29, 13);
            this.roll_label.TabIndex = 2;
            this.roll_label.Text = "Roll";
            // 
            // pitchData_textBox
            // 
            this.pitchData_textBox.AllowDrop = true;
            this.pitchData_textBox.Enabled = false;
            this.pitchData_textBox.Location = new System.Drawing.Point(89, 41);
            this.pitchData_textBox.Name = "pitchData_textBox";
            this.pitchData_textBox.Size = new System.Drawing.Size(166, 20);
            this.pitchData_textBox.TabIndex = 1;
            // 
            // pitch_label
            // 
            this.pitch_label.AutoSize = true;
            this.pitch_label.Location = new System.Drawing.Point(19, 44);
            this.pitch_label.Name = "pitch_label";
            this.pitch_label.Size = new System.Drawing.Size(36, 13);
            this.pitch_label.TabIndex = 0;
            this.pitch_label.Text = "Pitch";
            // 
            // mgc_tabPage
            // 
            this.mgc_tabPage.Controls.Add(this.gru5Info_groupBox);
            this.mgc_tabPage.Controls.Add(this.gru4Info_groupBox);
            this.mgc_tabPage.Controls.Add(this.gru3Info_groupBox);
            this.mgc_tabPage.Controls.Add(this.gru2Info_groupBox);
            this.mgc_tabPage.Controls.Add(this.mgcInfo_groupBox);
            this.mgc_tabPage.Controls.Add(this.gru1Info_groupBox);
            this.mgc_tabPage.Controls.Add(this.gruAlives_groupBox);
            this.mgc_tabPage.Location = new System.Drawing.Point(4, 22);
            this.mgc_tabPage.Name = "mgc_tabPage";
            this.mgc_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mgc_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.mgc_tabPage.TabIndex = 13;
            this.mgc_tabPage.Text = "MGC";
            this.mgc_tabPage.UseVisualStyleBackColor = true;
            // 
            // gru5Info_groupBox
            // 
            this.gru5Info_groupBox.Controls.Add(this.gru5Info_dataGridView);
            this.gru5Info_groupBox.Location = new System.Drawing.Point(283, 277);
            this.gru5Info_groupBox.Name = "gru5Info_groupBox";
            this.gru5Info_groupBox.Size = new System.Drawing.Size(965, 64);
            this.gru5Info_groupBox.TabIndex = 4;
            this.gru5Info_groupBox.TabStop = false;
            this.gru5Info_groupBox.Text = "GRU 5 Information";
            // 
            // gru5Info_dataGridView
            // 
            this.gru5Info_dataGridView.AllowUserToAddRows = false;
            this.gru5Info_dataGridView.AllowUserToDeleteRows = false;
            this.gru5Info_dataGridView.AutoGenerateColumns = false;
            this.gru5Info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gru5Info_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.gru5Info_dataGridView.DataSource = this.mGCIPConfigurationTableDBBindingSource2;
            this.gru5Info_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gru5Info_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.gru5Info_dataGridView.Name = "gru5Info_dataGridView";
            this.gru5Info_dataGridView.ReadOnly = true;
            this.gru5Info_dataGridView.RowHeadersVisible = false;
            this.gru5Info_dataGridView.Size = new System.Drawing.Size(959, 45);
            this.gru5Info_dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "gruId";
            this.dataGridViewTextBoxColumn22.FillWeight = 50F;
            this.dataGridViewTextBoxColumn22.HeaderText = "GRU ID";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn23.HeaderText = "State";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "tailNumberAttached";
            this.dataGridViewTextBoxColumn24.FillWeight = 60F;
            this.dataGridViewTextBoxColumn24.HeaderText = "Tail Attached";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn25.DataPropertyName = "apsRTCH";
            this.dataGridViewTextBoxColumn25.HeaderText = "APS -> RT CH";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn26.DataPropertyName = "rtGRUCH";
            this.dataGridViewTextBoxColumn26.HeaderText = "RT -> GRU CH";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn27.DataPropertyName = "GRURegularCH";
            this.dataGridViewTextBoxColumn27.HeaderText = "GRU Regular CH -> RT";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn28.DataPropertyName = "GRUFastCH";
            this.dataGridViewTextBoxColumn28.HeaderText = "GRU Fast CH -> RT";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // mGCIPConfigurationTableDBBindingSource2
            // 
            this.mGCIPConfigurationTableDBBindingSource2.DataSource = typeof(RT_Viewer.Framework.MGCModule.MGCIPConfigurationTableDB);
            // 
            // gru4Info_groupBox
            // 
            this.gru4Info_groupBox.Controls.Add(this.gru4Info_dataGridView);
            this.gru4Info_groupBox.Location = new System.Drawing.Point(285, 207);
            this.gru4Info_groupBox.Name = "gru4Info_groupBox";
            this.gru4Info_groupBox.Size = new System.Drawing.Size(963, 64);
            this.gru4Info_groupBox.TabIndex = 5;
            this.gru4Info_groupBox.TabStop = false;
            this.gru4Info_groupBox.Text = "GRU 4 Information";
            // 
            // gru4Info_dataGridView
            // 
            this.gru4Info_dataGridView.AllowUserToAddRows = false;
            this.gru4Info_dataGridView.AllowUserToDeleteRows = false;
            this.gru4Info_dataGridView.AutoGenerateColumns = false;
            this.gru4Info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gru4Info_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.gru4Info_dataGridView.DataSource = this.mGCIPConfigurationTableDBBindingSource2;
            this.gru4Info_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gru4Info_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.gru4Info_dataGridView.Name = "gru4Info_dataGridView";
            this.gru4Info_dataGridView.ReadOnly = true;
            this.gru4Info_dataGridView.RowHeadersVisible = false;
            this.gru4Info_dataGridView.Size = new System.Drawing.Size(957, 45);
            this.gru4Info_dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "gruId";
            this.dataGridViewTextBoxColumn15.FillWeight = 50F;
            this.dataGridViewTextBoxColumn15.HeaderText = "GRU ID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn16.HeaderText = "State";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "tailNumberAttached";
            this.dataGridViewTextBoxColumn17.FillWeight = 60F;
            this.dataGridViewTextBoxColumn17.HeaderText = "Tail Attached";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "apsRTCH";
            this.dataGridViewTextBoxColumn18.HeaderText = "APS -> RT CH";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "rtGRUCH";
            this.dataGridViewTextBoxColumn19.HeaderText = "RT -> GRU CH";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "GRURegularCH";
            this.dataGridViewTextBoxColumn20.HeaderText = "GRU Regular CH -> RT";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "GRUFastCH";
            this.dataGridViewTextBoxColumn21.HeaderText = "GRU Fast CH -> RT";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // gru3Info_groupBox
            // 
            this.gru3Info_groupBox.Controls.Add(this.gru3Info_dataGridView);
            this.gru3Info_groupBox.Location = new System.Drawing.Point(285, 140);
            this.gru3Info_groupBox.Name = "gru3Info_groupBox";
            this.gru3Info_groupBox.Size = new System.Drawing.Size(966, 64);
            this.gru3Info_groupBox.TabIndex = 4;
            this.gru3Info_groupBox.TabStop = false;
            this.gru3Info_groupBox.Text = "GRU 3 Information";
            // 
            // gru3Info_dataGridView
            // 
            this.gru3Info_dataGridView.AllowUserToAddRows = false;
            this.gru3Info_dataGridView.AllowUserToDeleteRows = false;
            this.gru3Info_dataGridView.AutoGenerateColumns = false;
            this.gru3Info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gru3Info_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.gru3Info_dataGridView.DataSource = this.mGCIPConfigurationTableDBBindingSource2;
            this.gru3Info_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gru3Info_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.gru3Info_dataGridView.Name = "gru3Info_dataGridView";
            this.gru3Info_dataGridView.ReadOnly = true;
            this.gru3Info_dataGridView.RowHeadersVisible = false;
            this.gru3Info_dataGridView.Size = new System.Drawing.Size(960, 45);
            this.gru3Info_dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "gruId";
            this.dataGridViewTextBoxColumn8.FillWeight = 50F;
            this.dataGridViewTextBoxColumn8.HeaderText = "GRU ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn9.HeaderText = "State";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tailNumberAttached";
            this.dataGridViewTextBoxColumn10.FillWeight = 60F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Tail Attached";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "apsRTCH";
            this.dataGridViewTextBoxColumn11.HeaderText = "APS -> RT CH";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "rtGRUCH";
            this.dataGridViewTextBoxColumn12.HeaderText = "RT -> GRU CH";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "GRURegularCH";
            this.dataGridViewTextBoxColumn13.HeaderText = "GRU Regular CH -> RT";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "GRUFastCH";
            this.dataGridViewTextBoxColumn14.HeaderText = "GRU Fast CH -> RT";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // gru2Info_groupBox
            // 
            this.gru2Info_groupBox.Controls.Add(this.gru2Info_dataGridView);
            this.gru2Info_groupBox.Location = new System.Drawing.Point(285, 73);
            this.gru2Info_groupBox.Name = "gru2Info_groupBox";
            this.gru2Info_groupBox.Size = new System.Drawing.Size(969, 64);
            this.gru2Info_groupBox.TabIndex = 4;
            this.gru2Info_groupBox.TabStop = false;
            this.gru2Info_groupBox.Text = "GRU 2 Information";
            // 
            // gru2Info_dataGridView
            // 
            this.gru2Info_dataGridView.AllowUserToAddRows = false;
            this.gru2Info_dataGridView.AllowUserToDeleteRows = false;
            this.gru2Info_dataGridView.AutoGenerateColumns = false;
            this.gru2Info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gru2Info_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gru2Info_dataGridView.DataSource = this.mGCIPConfigurationTableDBBindingSource2;
            this.gru2Info_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gru2Info_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.gru2Info_dataGridView.Name = "gru2Info_dataGridView";
            this.gru2Info_dataGridView.ReadOnly = true;
            this.gru2Info_dataGridView.RowHeadersVisible = false;
            this.gru2Info_dataGridView.Size = new System.Drawing.Size(963, 45);
            this.gru2Info_dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "gruId";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "GRU ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn2.HeaderText = "State";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tailNumberAttached";
            this.dataGridViewTextBoxColumn3.FillWeight = 60F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tail Attached";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "apsRTCH";
            this.dataGridViewTextBoxColumn4.HeaderText = "APS -> RT CH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rtGRUCH";
            this.dataGridViewTextBoxColumn5.HeaderText = "RT -> GRU CH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GRURegularCH";
            this.dataGridViewTextBoxColumn6.HeaderText = "GRU Regular CH -> RT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GRUFastCH";
            this.dataGridViewTextBoxColumn7.HeaderText = "GRU Fast CH -> RT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // mgcInfo_groupBox
            // 
            this.mgcInfo_groupBox.Controls.Add(this.HstGruConfTableCntr_textBox);
            this.mgcInfo_groupBox.Controls.Add(this.hstGruConftableCntr_label);
            this.mgcInfo_groupBox.Controls.Add(this.hstGruConfTable_dataGridView);
            this.mgcInfo_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgcInfo_groupBox.Location = new System.Drawing.Point(6, 6);
            this.mgcInfo_groupBox.Name = "mgcInfo_groupBox";
            this.mgcInfo_groupBox.Size = new System.Drawing.Size(267, 330);
            this.mgcInfo_groupBox.TabIndex = 1;
            this.mgcInfo_groupBox.TabStop = false;
            this.mgcInfo_groupBox.Text = "Unicon - ConfGruMsg";
            // 
            // HstGruConfTableCntr_textBox
            // 
            this.HstGruConfTableCntr_textBox.Location = new System.Drawing.Point(74, 257);
            this.HstGruConfTableCntr_textBox.Name = "HstGruConfTableCntr_textBox";
            this.HstGruConfTableCntr_textBox.Size = new System.Drawing.Size(113, 20);
            this.HstGruConfTableCntr_textBox.TabIndex = 2;
            this.HstGruConfTableCntr_textBox.Text = "N\\A";
            // 
            // hstGruConftableCntr_label
            // 
            this.hstGruConftableCntr_label.AutoSize = true;
            this.hstGruConftableCntr_label.Location = new System.Drawing.Point(15, 260);
            this.hstGruConftableCntr_label.Name = "hstGruConftableCntr_label";
            this.hstGruConftableCntr_label.Size = new System.Drawing.Size(44, 13);
            this.hstGruConftableCntr_label.TabIndex = 1;
            this.hstGruConftableCntr_label.Text = "Counter";
            // 
            // hstGruConfTable_dataGridView
            // 
            this.hstGruConfTable_dataGridView.AllowUserToAddRows = false;
            this.hstGruConfTable_dataGridView.AllowUserToDeleteRows = false;
            this.hstGruConfTable_dataGridView.AutoGenerateColumns = false;
            this.hstGruConfTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hstGruConfTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aTOLIDDataGridViewTextBoxColumn,
            this.uAVIDDataGridViewTextBoxColumn});
            this.hstGruConfTable_dataGridView.DataSource = this.hSTGruConfTableDBBindingSource;
            this.hstGruConfTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.hstGruConfTable_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.hstGruConfTable_dataGridView.Name = "hstGruConfTable_dataGridView";
            this.hstGruConfTable_dataGridView.ReadOnly = true;
            this.hstGruConfTable_dataGridView.RowHeadersVisible = false;
            this.hstGruConfTable_dataGridView.Size = new System.Drawing.Size(261, 230);
            this.hstGruConfTable_dataGridView.TabIndex = 0;
            // 
            // aTOLIDDataGridViewTextBoxColumn
            // 
            this.aTOLIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aTOLIDDataGridViewTextBoxColumn.DataPropertyName = "ATOL_ID";
            this.aTOLIDDataGridViewTextBoxColumn.HeaderText = "ATOL_ID";
            this.aTOLIDDataGridViewTextBoxColumn.Name = "aTOLIDDataGridViewTextBoxColumn";
            this.aTOLIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uAVIDDataGridViewTextBoxColumn
            // 
            this.uAVIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uAVIDDataGridViewTextBoxColumn.DataPropertyName = "UAV_ID";
            this.uAVIDDataGridViewTextBoxColumn.HeaderText = "UAV_ID";
            this.uAVIDDataGridViewTextBoxColumn.Name = "uAVIDDataGridViewTextBoxColumn";
            this.uAVIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hSTGruConfTableDBBindingSource
            // 
            this.hSTGruConfTableDBBindingSource.DataSource = typeof(RT_Viewer.Framework.MGCModule.HSTGruConfTableDB);
            // 
            // gru1Info_groupBox
            // 
            this.gru1Info_groupBox.Controls.Add(this.gru1Info_dataGridView);
            this.gru1Info_groupBox.Location = new System.Drawing.Point(282, 6);
            this.gru1Info_groupBox.Name = "gru1Info_groupBox";
            this.gru1Info_groupBox.Size = new System.Drawing.Size(975, 64);
            this.gru1Info_groupBox.TabIndex = 3;
            this.gru1Info_groupBox.TabStop = false;
            this.gru1Info_groupBox.Text = "GRU 1 Information";
            // 
            // gru1Info_dataGridView
            // 
            this.gru1Info_dataGridView.AllowUserToAddRows = false;
            this.gru1Info_dataGridView.AllowUserToDeleteRows = false;
            this.gru1Info_dataGridView.AutoGenerateColumns = false;
            this.gru1Info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gru1Info_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gruIdDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.tailNumberAttachedDataGridViewTextBoxColumn,
            this.apsRTCHDataGridViewTextBoxColumn,
            this.rtGRUCHDataGridViewTextBoxColumn,
            this.gRURegularCHDataGridViewTextBoxColumn,
            this.gRUFastCHDataGridViewTextBoxColumn});
            this.gru1Info_dataGridView.DataSource = this.mGCIPConfigurationTableDBBindingSource2;
            this.gru1Info_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gru1Info_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.gru1Info_dataGridView.Name = "gru1Info_dataGridView";
            this.gru1Info_dataGridView.ReadOnly = true;
            this.gru1Info_dataGridView.RowHeadersVisible = false;
            this.gru1Info_dataGridView.Size = new System.Drawing.Size(969, 45);
            this.gru1Info_dataGridView.TabIndex = 0;
            // 
            // gruIdDataGridViewTextBoxColumn
            // 
            this.gruIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gruIdDataGridViewTextBoxColumn.DataPropertyName = "gruId";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gruIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.gruIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.gruIdDataGridViewTextBoxColumn.HeaderText = "GRU ID";
            this.gruIdDataGridViewTextBoxColumn.Name = "gruIdDataGridViewTextBoxColumn";
            this.gruIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tailNumberAttachedDataGridViewTextBoxColumn
            // 
            this.tailNumberAttachedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tailNumberAttachedDataGridViewTextBoxColumn.DataPropertyName = "tailNumberAttached";
            this.tailNumberAttachedDataGridViewTextBoxColumn.FillWeight = 60F;
            this.tailNumberAttachedDataGridViewTextBoxColumn.HeaderText = "Tail Attached";
            this.tailNumberAttachedDataGridViewTextBoxColumn.Name = "tailNumberAttachedDataGridViewTextBoxColumn";
            this.tailNumberAttachedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apsRTCHDataGridViewTextBoxColumn
            // 
            this.apsRTCHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apsRTCHDataGridViewTextBoxColumn.DataPropertyName = "apsRTCH";
            this.apsRTCHDataGridViewTextBoxColumn.HeaderText = "APS -> RT CH";
            this.apsRTCHDataGridViewTextBoxColumn.Name = "apsRTCHDataGridViewTextBoxColumn";
            this.apsRTCHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rtGRUCHDataGridViewTextBoxColumn
            // 
            this.rtGRUCHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rtGRUCHDataGridViewTextBoxColumn.DataPropertyName = "rtGRUCH";
            this.rtGRUCHDataGridViewTextBoxColumn.HeaderText = "RT -> GRU CH";
            this.rtGRUCHDataGridViewTextBoxColumn.Name = "rtGRUCHDataGridViewTextBoxColumn";
            this.rtGRUCHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gRURegularCHDataGridViewTextBoxColumn
            // 
            this.gRURegularCHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gRURegularCHDataGridViewTextBoxColumn.DataPropertyName = "GRURegularCH";
            this.gRURegularCHDataGridViewTextBoxColumn.HeaderText = "GRU Regular CH -> RT";
            this.gRURegularCHDataGridViewTextBoxColumn.Name = "gRURegularCHDataGridViewTextBoxColumn";
            this.gRURegularCHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gRUFastCHDataGridViewTextBoxColumn
            // 
            this.gRUFastCHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gRUFastCHDataGridViewTextBoxColumn.DataPropertyName = "GRUFastCH";
            this.gRUFastCHDataGridViewTextBoxColumn.HeaderText = "GRU Fast CH -> RT";
            this.gRUFastCHDataGridViewTextBoxColumn.Name = "gRUFastCHDataGridViewTextBoxColumn";
            this.gRUFastCHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gruAlives_groupBox
            // 
            this.gruAlives_groupBox.Controls.Add(this.gru5Configure_label);
            this.gruAlives_groupBox.Controls.Add(this.gru4Configure_label);
            this.gruAlives_groupBox.Controls.Add(this.gru3Configure_label);
            this.gruAlives_groupBox.Controls.Add(this.gru2Configure_label);
            this.gruAlives_groupBox.Controls.Add(this.gru1Configure_label);
            this.gruAlives_groupBox.Controls.Add(this.gru5name_label);
            this.gruAlives_groupBox.Controls.Add(this.gru4name_label);
            this.gruAlives_groupBox.Controls.Add(this.gru3name_label);
            this.gruAlives_groupBox.Controls.Add(this.gru2name_label);
            this.gruAlives_groupBox.Controls.Add(this.gru1name_label);
            this.gruAlives_groupBox.Controls.Add(this.gru5Conection_pictureBox);
            this.gruAlives_groupBox.Controls.Add(this.gru4Conection_pictureBox);
            this.gruAlives_groupBox.Controls.Add(this.gru3Conection_pictureBox);
            this.gruAlives_groupBox.Controls.Add(this.gru2Conection_pictureBox);
            this.gruAlives_groupBox.Controls.Add(this.gru1Conection_pictureBox);
            this.gruAlives_groupBox.Location = new System.Drawing.Point(9, 342);
            this.gruAlives_groupBox.Name = "gruAlives_groupBox";
            this.gruAlives_groupBox.Size = new System.Drawing.Size(264, 242);
            this.gruAlives_groupBox.TabIndex = 2;
            this.gruAlives_groupBox.TabStop = false;
            this.gruAlives_groupBox.Text = "GRU\'s Connections Status";
            // 
            // gru5Configure_label
            // 
            this.gru5Configure_label.AutoSize = true;
            this.gru5Configure_label.Location = new System.Drawing.Point(176, 182);
            this.gru5Configure_label.Name = "gru5Configure_label";
            this.gru5Configure_label.Size = new System.Drawing.Size(78, 13);
            this.gru5Configure_label.TabIndex = 31;
            this.gru5Configure_label.Text = "Not Configured";
            // 
            // gru4Configure_label
            // 
            this.gru4Configure_label.AutoSize = true;
            this.gru4Configure_label.Location = new System.Drawing.Point(176, 149);
            this.gru4Configure_label.Name = "gru4Configure_label";
            this.gru4Configure_label.Size = new System.Drawing.Size(78, 13);
            this.gru4Configure_label.TabIndex = 30;
            this.gru4Configure_label.Text = "Not Configured";
            // 
            // gru3Configure_label
            // 
            this.gru3Configure_label.AutoSize = true;
            this.gru3Configure_label.Location = new System.Drawing.Point(176, 115);
            this.gru3Configure_label.Name = "gru3Configure_label";
            this.gru3Configure_label.Size = new System.Drawing.Size(78, 13);
            this.gru3Configure_label.TabIndex = 29;
            this.gru3Configure_label.Text = "Not Configured";
            // 
            // gru2Configure_label
            // 
            this.gru2Configure_label.AutoSize = true;
            this.gru2Configure_label.Location = new System.Drawing.Point(176, 80);
            this.gru2Configure_label.Name = "gru2Configure_label";
            this.gru2Configure_label.Size = new System.Drawing.Size(78, 13);
            this.gru2Configure_label.TabIndex = 28;
            this.gru2Configure_label.Text = "Not Configured";
            // 
            // gru1Configure_label
            // 
            this.gru1Configure_label.AutoSize = true;
            this.gru1Configure_label.Location = new System.Drawing.Point(176, 47);
            this.gru1Configure_label.Name = "gru1Configure_label";
            this.gru1Configure_label.Size = new System.Drawing.Size(78, 13);
            this.gru1Configure_label.TabIndex = 27;
            this.gru1Configure_label.Text = "Not Configured";
            // 
            // gru5name_label
            // 
            this.gru5name_label.AutoSize = true;
            this.gru5name_label.Location = new System.Drawing.Point(38, 182);
            this.gru5name_label.Name = "gru5name_label";
            this.gru5name_label.Size = new System.Drawing.Size(132, 13);
            this.gru5name_label.TabIndex = 26;
            this.gru5name_label.Text = "ATOL_ID ALT 04 (GRU 5)";
            // 
            // gru4name_label
            // 
            this.gru4name_label.AutoSize = true;
            this.gru4name_label.Location = new System.Drawing.Point(38, 149);
            this.gru4name_label.Name = "gru4name_label";
            this.gru4name_label.Size = new System.Drawing.Size(132, 13);
            this.gru4name_label.TabIndex = 25;
            this.gru4name_label.Text = "ATOL_ID ALT 02 (GRU 4)";
            // 
            // gru3name_label
            // 
            this.gru3name_label.AutoSize = true;
            this.gru3name_label.Location = new System.Drawing.Point(38, 115);
            this.gru3name_label.Name = "gru3name_label";
            this.gru3name_label.Size = new System.Drawing.Size(132, 13);
            this.gru3name_label.TabIndex = 24;
            this.gru3name_label.Text = "ATOL_ID ALT 01 (GRU 3)";
            // 
            // gru2name_label
            // 
            this.gru2name_label.AutoSize = true;
            this.gru2name_label.Location = new System.Drawing.Point(38, 80);
            this.gru2name_label.Name = "gru2name_label";
            this.gru2name_label.Size = new System.Drawing.Size(136, 13);
            this.gru2name_label.TabIndex = 23;
            this.gru2name_label.Text = "ATOL_ID MOB 04 (GRU 2)";
            // 
            // gru1name_label
            // 
            this.gru1name_label.AutoSize = true;
            this.gru1name_label.Location = new System.Drawing.Point(38, 47);
            this.gru1name_label.Name = "gru1name_label";
            this.gru1name_label.Size = new System.Drawing.Size(136, 13);
            this.gru1name_label.TabIndex = 22;
            this.gru1name_label.Text = "ATOL_ID MOB 22 (GRU 1)";
            // 
            // gru5Conection_pictureBox
            // 
            this.gru5Conection_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gru5Conection_pictureBox.Image")));
            this.gru5Conection_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("gru5Conection_pictureBox.InitialImage")));
            this.gru5Conection_pictureBox.Location = new System.Drawing.Point(15, 182);
            this.gru5Conection_pictureBox.Name = "gru5Conection_pictureBox";
            this.gru5Conection_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.gru5Conection_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gru5Conection_pictureBox.TabIndex = 21;
            this.gru5Conection_pictureBox.TabStop = false;
            // 
            // gru4Conection_pictureBox
            // 
            this.gru4Conection_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gru4Conection_pictureBox.Image")));
            this.gru4Conection_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("gru4Conection_pictureBox.InitialImage")));
            this.gru4Conection_pictureBox.Location = new System.Drawing.Point(15, 146);
            this.gru4Conection_pictureBox.Name = "gru4Conection_pictureBox";
            this.gru4Conection_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.gru4Conection_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gru4Conection_pictureBox.TabIndex = 20;
            this.gru4Conection_pictureBox.TabStop = false;
            // 
            // gru3Conection_pictureBox
            // 
            this.gru3Conection_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gru3Conection_pictureBox.Image")));
            this.gru3Conection_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("gru3Conection_pictureBox.InitialImage")));
            this.gru3Conection_pictureBox.Location = new System.Drawing.Point(15, 112);
            this.gru3Conection_pictureBox.Name = "gru3Conection_pictureBox";
            this.gru3Conection_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.gru3Conection_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gru3Conection_pictureBox.TabIndex = 19;
            this.gru3Conection_pictureBox.TabStop = false;
            // 
            // gru2Conection_pictureBox
            // 
            this.gru2Conection_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gru2Conection_pictureBox.Image")));
            this.gru2Conection_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("gru2Conection_pictureBox.InitialImage")));
            this.gru2Conection_pictureBox.Location = new System.Drawing.Point(15, 80);
            this.gru2Conection_pictureBox.Name = "gru2Conection_pictureBox";
            this.gru2Conection_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.gru2Conection_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gru2Conection_pictureBox.TabIndex = 18;
            this.gru2Conection_pictureBox.TabStop = false;
            // 
            // gru1Conection_pictureBox
            // 
            this.gru1Conection_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gru1Conection_pictureBox.Image")));
            this.gru1Conection_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("gru1Conection_pictureBox.InitialImage")));
            this.gru1Conection_pictureBox.Location = new System.Drawing.Point(15, 44);
            this.gru1Conection_pictureBox.Name = "gru1Conection_pictureBox";
            this.gru1Conection_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.gru1Conection_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gru1Conection_pictureBox.TabIndex = 17;
            this.gru1Conection_pictureBox.TabStop = false;
            // 
            // gdt_tabPage
            // 
            this.gdt_tabPage.Controls.Add(this.gdtTable_groupBox);
            this.gdt_tabPage.Location = new System.Drawing.Point(4, 22);
            this.gdt_tabPage.Name = "gdt_tabPage";
            this.gdt_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gdt_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.gdt_tabPage.TabIndex = 14;
            this.gdt_tabPage.Text = "GDT";
            this.gdt_tabPage.UseVisualStyleBackColor = true;
            // 
            // tlm_tabPage
            // 
            this.tlm_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_tabPage.Controls.Add(this.groupBox1);
            this.tlm_tabPage.Controls.Add(this.tabControl1);
            this.tlm_tabPage.Location = new System.Drawing.Point(4, 22);
            this.tlm_tabPage.Name = "tlm_tabPage";
            this.tlm_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.tlm_tabPage.TabIndex = 16;
            this.tlm_tabPage.Text = "TLM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tlm_btn_SaveConfigurations);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 587);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telemetric configuration";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.tlm_tbx_PathConfigFiles);
            this.groupBox9.Location = new System.Drawing.Point(9, 30);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(332, 47);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Configuration files folder";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Path";
            // 
            // tlm_tbx_PathConfigFiles
            // 
            this.tlm_tbx_PathConfigFiles.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_tbx_PathConfigFiles.Location = new System.Drawing.Point(79, 15);
            this.tlm_tbx_PathConfigFiles.Name = "tlm_tbx_PathConfigFiles";
            this.tlm_tbx_PathConfigFiles.Size = new System.Drawing.Size(241, 20);
            this.tlm_tbx_PathConfigFiles.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.tlm_rdb_DataTypeOrginal);
            this.groupBox6.Controls.Add(this.tlm_rdb_DataTypeChars);
            this.groupBox6.Location = new System.Drawing.Point(9, 139);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(326, 60);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Type";
            // 
            // tlm_rdb_DataTypeOrginal
            // 
            this.tlm_rdb_DataTypeOrginal.AutoSize = true;
            this.tlm_rdb_DataTypeOrginal.Location = new System.Drawing.Point(123, 24);
            this.tlm_rdb_DataTypeOrginal.Name = "tlm_rdb_DataTypeOrginal";
            this.tlm_rdb_DataTypeOrginal.Size = new System.Drawing.Size(60, 17);
            this.tlm_rdb_DataTypeOrginal.TabIndex = 12;
            this.tlm_rdb_DataTypeOrginal.TabStop = true;
            this.tlm_rdb_DataTypeOrginal.Text = "Original";
            this.tlm_rdb_DataTypeOrginal.UseVisualStyleBackColor = true;
            // 
            // tlm_rdb_DataTypeChars
            // 
            this.tlm_rdb_DataTypeChars.AutoSize = true;
            this.tlm_rdb_DataTypeChars.Location = new System.Drawing.Point(63, 25);
            this.tlm_rdb_DataTypeChars.Name = "tlm_rdb_DataTypeChars";
            this.tlm_rdb_DataTypeChars.Size = new System.Drawing.Size(51, 17);
            this.tlm_rdb_DataTypeChars.TabIndex = 11;
            this.tlm_rdb_DataTypeChars.TabStop = true;
            this.tlm_rdb_DataTypeChars.Text = "Bytes";
            this.tlm_rdb_DataTypeChars.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tlm_rdb_SortLowHigh);
            this.groupBox3.Controls.Add(this.tlm_rdb_SortHighLow);
            this.groupBox3.Controls.Add(this.tlm_rdb_SortByGroups);
            this.groupBox3.Location = new System.Drawing.Point(9, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 50);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort data mode";
            // 
            // tlm_rdb_SortLowHigh
            // 
            this.tlm_rdb_SortLowHigh.AutoSize = true;
            this.tlm_rdb_SortLowHigh.Location = new System.Drawing.Point(200, 24);
            this.tlm_rdb_SortLowHigh.Name = "tlm_rdb_SortLowHigh";
            this.tlm_rdb_SortLowHigh.Size = new System.Drawing.Size(80, 17);
            this.tlm_rdb_SortLowHigh.TabIndex = 15;
            this.tlm_rdb_SortLowHigh.TabStop = true;
            this.tlm_rdb_SortLowHigh.Text = "Low to high";
            this.tlm_rdb_SortLowHigh.UseVisualStyleBackColor = true;
            // 
            // tlm_rdb_SortHighLow
            // 
            this.tlm_rdb_SortHighLow.AutoSize = true;
            this.tlm_rdb_SortHighLow.Location = new System.Drawing.Point(116, 24);
            this.tlm_rdb_SortHighLow.Name = "tlm_rdb_SortHighLow";
            this.tlm_rdb_SortHighLow.Size = new System.Drawing.Size(78, 17);
            this.tlm_rdb_SortHighLow.TabIndex = 14;
            this.tlm_rdb_SortHighLow.TabStop = true;
            this.tlm_rdb_SortHighLow.Text = "High to low";
            this.tlm_rdb_SortHighLow.UseVisualStyleBackColor = true;
            // 
            // tlm_rdb_SortByGroups
            // 
            this.tlm_rdb_SortByGroups.AutoSize = true;
            this.tlm_rdb_SortByGroups.Location = new System.Drawing.Point(42, 24);
            this.tlm_rdb_SortByGroups.Name = "tlm_rdb_SortByGroups";
            this.tlm_rdb_SortByGroups.Size = new System.Drawing.Size(72, 17);
            this.tlm_rdb_SortByGroups.TabIndex = 13;
            this.tlm_rdb_SortByGroups.TabStop = true;
            this.tlm_rdb_SortByGroups.Text = "By groups";
            this.tlm_rdb_SortByGroups.UseVisualStyleBackColor = true;
            // 
            // tlm_btn_SaveConfigurations
            // 
            this.tlm_btn_SaveConfigurations.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_btn_SaveConfigurations.Location = new System.Drawing.Point(108, 350);
            this.tlm_btn_SaveConfigurations.Name = "tlm_btn_SaveConfigurations";
            this.tlm_btn_SaveConfigurations.Size = new System.Drawing.Size(129, 27);
            this.tlm_btn_SaveConfigurations.TabIndex = 14;
            this.tlm_btn_SaveConfigurations.Text = "Save configurations";
            this.tlm_btn_SaveConfigurations.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tlm_btn_FigureDataMember);
            this.groupBox4.Controls.Add(this.tlm_cbx_FindGroup);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.tlm_tbx_FindName);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(0, 493);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 87);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find data member";
            // 
            // tlm_btn_FigureDataMember
            // 
            this.tlm_btn_FigureDataMember.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_btn_FigureDataMember.Location = new System.Drawing.Point(226, 39);
            this.tlm_btn_FigureDataMember.Name = "tlm_btn_FigureDataMember";
            this.tlm_btn_FigureDataMember.Size = new System.Drawing.Size(106, 27);
            this.tlm_btn_FigureDataMember.TabIndex = 17;
            this.tlm_btn_FigureDataMember.Text = "Visual view";
            this.tlm_btn_FigureDataMember.UseVisualStyleBackColor = false;
            this.tlm_btn_FigureDataMember.Click += new System.EventHandler(this.tlm_btn_FigureDataMember_Click);
            // 
            // tlm_cbx_FindGroup
            // 
            this.tlm_cbx_FindGroup.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_cbx_FindGroup.FormattingEnabled = true;
            this.tlm_cbx_FindGroup.Location = new System.Drawing.Point(85, 45);
            this.tlm_cbx_FindGroup.Name = "tlm_cbx_FindGroup";
            this.tlm_cbx_FindGroup.Size = new System.Drawing.Size(123, 21);
            this.tlm_cbx_FindGroup.TabIndex = 8;
            this.tlm_cbx_FindGroup.Text = "Please select";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Module";
            // 
            // tlm_tbx_FindName
            // 
            this.tlm_tbx_FindName.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_tbx_FindName.Location = new System.Drawing.Point(85, 18);
            this.tlm_tbx_FindName.Name = "tlm_tbx_FindName";
            this.tlm_tbx_FindName.Size = new System.Drawing.Size(123, 20);
            this.tlm_tbx_FindName.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Name / idx";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tlm_rdb_ReadSourceFile);
            this.groupBox2.Controls.Add(this.tlm_gbx_fileUpdate);
            this.groupBox2.Controls.Add(this.tlm_rdb_ReadSourceCurrent);
            this.groupBox2.Controls.Add(this.tlm_rdb_ReadSourceFlash);
            this.groupBox2.Location = new System.Drawing.Point(9, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read Source";
            // 
            // tlm_rdb_ReadSourceFile
            // 
            this.tlm_rdb_ReadSourceFile.AutoSize = true;
            this.tlm_rdb_ReadSourceFile.Location = new System.Drawing.Point(190, 25);
            this.tlm_rdb_ReadSourceFile.Name = "tlm_rdb_ReadSourceFile";
            this.tlm_rdb_ReadSourceFile.Size = new System.Drawing.Size(41, 17);
            this.tlm_rdb_ReadSourceFile.TabIndex = 10;
            this.tlm_rdb_ReadSourceFile.TabStop = true;
            this.tlm_rdb_ReadSourceFile.Text = "File";
            this.tlm_rdb_ReadSourceFile.UseVisualStyleBackColor = true;
            this.tlm_rdb_ReadSourceFile.CheckedChanged += new System.EventHandler(this.tlm_rdb_ReadSourceFile_CheckedChanged);
            this.tlm_rdb_ReadSourceFile.Click += new System.EventHandler(this.tlm_rdb_ReadSourceFile_Click);
            // 
            // tlm_gbx_fileUpdate
            // 
            this.tlm_gbx_fileUpdate.Controls.Add(this.tlm_tbx_ForceUpdatePath);
            this.tlm_gbx_fileUpdate.Controls.Add(this.label19);
            this.tlm_gbx_fileUpdate.Controls.Add(this.tlm_btn_ForceUpdate);
            this.tlm_gbx_fileUpdate.Location = new System.Drawing.Point(9, 48);
            this.tlm_gbx_fileUpdate.Name = "tlm_gbx_fileUpdate";
            this.tlm_gbx_fileUpdate.Size = new System.Drawing.Size(311, 61);
            this.tlm_gbx_fileUpdate.TabIndex = 2;
            this.tlm_gbx_fileUpdate.TabStop = false;
            this.tlm_gbx_fileUpdate.Text = "Force update";
            this.tlm_gbx_fileUpdate.Visible = false;
            // 
            // tlm_tbx_ForceUpdatePath
            // 
            this.tlm_tbx_ForceUpdatePath.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_tbx_ForceUpdatePath.Location = new System.Drawing.Point(6, 31);
            this.tlm_tbx_ForceUpdatePath.Name = "tlm_tbx_ForceUpdatePath";
            this.tlm_tbx_ForceUpdatePath.Size = new System.Drawing.Size(168, 20);
            this.tlm_tbx_ForceUpdatePath.TabIndex = 8;
            this.tlm_tbx_ForceUpdatePath.Text = "C:\\Software_projects\\Elbit\\ElbitMalat\\Telemetric\\Raw files\\raw_25_10_4.txt";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Path";
            // 
            // tlm_btn_ForceUpdate
            // 
            this.tlm_btn_ForceUpdate.Location = new System.Drawing.Point(200, 28);
            this.tlm_btn_ForceUpdate.Name = "tlm_btn_ForceUpdate";
            this.tlm_btn_ForceUpdate.Size = new System.Drawing.Size(58, 23);
            this.tlm_btn_ForceUpdate.TabIndex = 1;
            this.tlm_btn_ForceUpdate.Text = "read";
            this.tlm_btn_ForceUpdate.UseVisualStyleBackColor = true;
            this.tlm_btn_ForceUpdate.Click += new System.EventHandler(this.tlm_btn_ForceUpdate_Click);
            // 
            // tlm_rdb_ReadSourceCurrent
            // 
            this.tlm_rdb_ReadSourceCurrent.AutoSize = true;
            this.tlm_rdb_ReadSourceCurrent.Location = new System.Drawing.Point(90, 25);
            this.tlm_rdb_ReadSourceCurrent.Name = "tlm_rdb_ReadSourceCurrent";
            this.tlm_rdb_ReadSourceCurrent.Size = new System.Drawing.Size(83, 17);
            this.tlm_rdb_ReadSourceCurrent.TabIndex = 1;
            this.tlm_rdb_ReadSourceCurrent.TabStop = true;
            this.tlm_rdb_ReadSourceCurrent.Text = "Current data";
            this.tlm_rdb_ReadSourceCurrent.UseVisualStyleBackColor = true;
            this.tlm_rdb_ReadSourceCurrent.Click += new System.EventHandler(this.tlm_rdb_ReadSourceFile_Click);
            // 
            // tlm_rdb_ReadSourceFlash
            // 
            this.tlm_rdb_ReadSourceFlash.AutoSize = true;
            this.tlm_rdb_ReadSourceFlash.Location = new System.Drawing.Point(9, 25);
            this.tlm_rdb_ReadSourceFlash.Name = "tlm_rdb_ReadSourceFlash";
            this.tlm_rdb_ReadSourceFlash.Size = new System.Drawing.Size(50, 17);
            this.tlm_rdb_ReadSourceFlash.TabIndex = 0;
            this.tlm_rdb_ReadSourceFlash.TabStop = true;
            this.tlm_rdb_ReadSourceFlash.Text = "Flash";
            this.tlm_rdb_ReadSourceFlash.UseVisualStyleBackColor = true;
            this.tlm_rdb_ReadSourceFlash.Click += new System.EventHandler(this.tlm_rdb_ReadSourceFile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tlm_data_tabPage);
            this.tabControl1.Controls.Add(this.tlm_visual_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(378, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // tlm_data_tabPage
            // 
            this.tlm_data_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_data_tabPage.Controls.Add(this.groupBox7);
            this.tlm_data_tabPage.Controls.Add(this.tlmTable_dataGridView);
            this.tlm_data_tabPage.Location = new System.Drawing.Point(4, 22);
            this.tlm_data_tabPage.Name = "tlm_data_tabPage";
            this.tlm_data_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tlm_data_tabPage.Size = new System.Drawing.Size(886, 558);
            this.tlm_data_tabPage.TabIndex = 0;
            this.tlm_data_tabPage.Text = "Data view";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tlm_cbx_SaveBigTableType);
            this.groupBox7.Controls.Add(this.tlm_btn_SaveBigTableSelect);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.tlm_tbx_SaveBigTablePath);
            this.groupBox7.Location = new System.Drawing.Point(6, 484);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(282, 68);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "File save configuration";
            // 
            // tlm_cbx_SaveBigTableType
            // 
            this.tlm_cbx_SaveBigTableType.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_cbx_SaveBigTableType.FormattingEnabled = true;
            this.tlm_cbx_SaveBigTableType.Items.AddRange(new object[] {
            "Raw file",
            "Text file",
            "Both"});
            this.tlm_cbx_SaveBigTableType.Location = new System.Drawing.Point(116, 15);
            this.tlm_cbx_SaveBigTableType.Name = "tlm_cbx_SaveBigTableType";
            this.tlm_cbx_SaveBigTableType.Size = new System.Drawing.Size(89, 21);
            this.tlm_cbx_SaveBigTableType.TabIndex = 12;
            this.tlm_cbx_SaveBigTableType.Text = "Please select";
            // 
            // tlm_btn_SaveBigTableSelect
            // 
            this.tlm_btn_SaveBigTableSelect.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_btn_SaveBigTableSelect.Location = new System.Drawing.Point(220, 37);
            this.tlm_btn_SaveBigTableSelect.Name = "tlm_btn_SaveBigTableSelect";
            this.tlm_btn_SaveBigTableSelect.Size = new System.Drawing.Size(56, 23);
            this.tlm_btn_SaveBigTableSelect.TabIndex = 9;
            this.tlm_btn_SaveBigTableSelect.Text = "Save";
            this.tlm_btn_SaveBigTableSelect.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Path";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Output format";
            // 
            // tlm_tbx_SaveBigTablePath
            // 
            this.tlm_tbx_SaveBigTablePath.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_tbx_SaveBigTablePath.Location = new System.Drawing.Point(39, 39);
            this.tlm_tbx_SaveBigTablePath.Name = "tlm_tbx_SaveBigTablePath";
            this.tlm_tbx_SaveBigTablePath.Size = new System.Drawing.Size(166, 20);
            this.tlm_tbx_SaveBigTablePath.TabIndex = 10;
            // 
            // tlmTable_dataGridView
            // 
            this.tlmTable_dataGridView.AutoGenerateColumns = false;
            this.tlmTable_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tlmTable_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tlmTable_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tlmTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlmTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.idxDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.tlmTable_dataGridView.DataSource = this.tlmTableBindingSource;
            this.tlmTable_dataGridView.Location = new System.Drawing.Point(45, 18);
            this.tlmTable_dataGridView.Name = "tlmTable_dataGridView";
            this.tlmTable_dataGridView.Size = new System.Drawing.Size(815, 447);
            this.tlmTable_dataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // idxDataGridViewTextBoxColumn
            // 
            this.idxDataGridViewTextBoxColumn.DataPropertyName = "idx";
            this.idxDataGridViewTextBoxColumn.HeaderText = "idx";
            this.idxDataGridViewTextBoxColumn.Name = "idxDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // tlmTableBindingSource
            // 
            this.tlmTableBindingSource.DataSource = typeof(RT_Viewer.Framework.TLMModule.TLMDataTable);
            // 
            // tlm_visual_tabPage
            // 
            this.tlm_visual_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_visual_tabPage.Controls.Add(this.groupBox5);
            this.tlm_visual_tabPage.Controls.Add(this.groupBox10);
            this.tlm_visual_tabPage.Controls.Add(this.tlm_gbx_view_figure);
            this.tlm_visual_tabPage.Location = new System.Drawing.Point(4, 22);
            this.tlm_visual_tabPage.Name = "tlm_visual_tabPage";
            this.tlm_visual_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tlm_visual_tabPage.Size = new System.Drawing.Size(886, 558);
            this.tlm_visual_tabPage.TabIndex = 1;
            this.tlm_visual_tabPage.Text = "Visual view";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tlm_cbx_ViewerSaveType);
            this.groupBox5.Controls.Add(this.tlm_btn_ViewerSave);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.tlm_btn_ViewerSavePath);
            this.groupBox5.Location = new System.Drawing.Point(12, 484);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 68);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Results save";
            // 
            // tlm_cbx_ViewerSaveType
            // 
            this.tlm_cbx_ViewerSaveType.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_cbx_ViewerSaveType.FormattingEnabled = true;
            this.tlm_cbx_ViewerSaveType.Items.AddRange(new object[] {
            "Chart [png format]",
            "Results table",
            "Both"});
            this.tlm_cbx_ViewerSaveType.Location = new System.Drawing.Point(116, 15);
            this.tlm_cbx_ViewerSaveType.Name = "tlm_cbx_ViewerSaveType";
            this.tlm_cbx_ViewerSaveType.Size = new System.Drawing.Size(89, 21);
            this.tlm_cbx_ViewerSaveType.TabIndex = 12;
            this.tlm_cbx_ViewerSaveType.Text = "Please select";
            // 
            // tlm_btn_ViewerSave
            // 
            this.tlm_btn_ViewerSave.Location = new System.Drawing.Point(220, 37);
            this.tlm_btn_ViewerSave.Name = "tlm_btn_ViewerSave";
            this.tlm_btn_ViewerSave.Size = new System.Drawing.Size(56, 23);
            this.tlm_btn_ViewerSave.TabIndex = 9;
            this.tlm_btn_ViewerSave.Text = "Save";
            this.tlm_btn_ViewerSave.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Path";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "What to save";
            // 
            // tlm_btn_ViewerSavePath
            // 
            this.tlm_btn_ViewerSavePath.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_btn_ViewerSavePath.Location = new System.Drawing.Point(42, 39);
            this.tlm_btn_ViewerSavePath.Name = "tlm_btn_ViewerSavePath";
            this.tlm_btn_ViewerSavePath.Size = new System.Drawing.Size(163, 20);
            this.tlm_btn_ViewerSavePath.TabIndex = 10;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Controls.Add(this.tlm_rtb_view_res_table_time);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.tlm_rtb_view_res_table_value);
            this.groupBox10.Location = new System.Drawing.Point(620, 22);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(258, 443);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "table";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(145, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Time stamp [mSec]";
            // 
            // tlm_rtb_view_res_table_time
            // 
            this.tlm_rtb_view_res_table_time.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_rtb_view_res_table_time.Location = new System.Drawing.Point(148, 36);
            this.tlm_rtb_view_res_table_time.Name = "tlm_rtb_view_res_table_time";
            this.tlm_rtb_view_res_table_time.Size = new System.Drawing.Size(104, 356);
            this.tlm_rtb_view_res_table_time.TabIndex = 2;
            this.tlm_rtb_view_res_table_time.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Value";
            // 
            // tlm_rtb_view_res_table_value
            // 
            this.tlm_rtb_view_res_table_value.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_rtb_view_res_table_value.Location = new System.Drawing.Point(19, 36);
            this.tlm_rtb_view_res_table_value.Name = "tlm_rtb_view_res_table_value";
            this.tlm_rtb_view_res_table_value.Size = new System.Drawing.Size(104, 356);
            this.tlm_rtb_view_res_table_value.TabIndex = 0;
            this.tlm_rtb_view_res_table_value.Text = "";
            // 
            // tlm_gbx_view_figure
            // 
            this.tlm_gbx_view_figure.Controls.Add(this.tlm_chart_view);
            this.tlm_gbx_view_figure.Location = new System.Drawing.Point(6, 14);
            this.tlm_gbx_view_figure.Name = "tlm_gbx_view_figure";
            this.tlm_gbx_view_figure.Size = new System.Drawing.Size(591, 451);
            this.tlm_gbx_view_figure.TabIndex = 0;
            this.tlm_gbx_view_figure.TabStop = false;
            this.tlm_gbx_view_figure.Text = "2D figure";
            // 
            // tlm_chart_view
            // 
            this.tlm_chart_view.BackColor = System.Drawing.SystemColors.Control;
            this.tlm_chart_view.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.tlm_chart_view.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.tlm_chart_view.Legends.Add(legend1);
            this.tlm_chart_view.Location = new System.Drawing.Point(6, 36);
            this.tlm_chart_view.Name = "tlm_chart_view";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Main line";
            this.tlm_chart_view.Series.Add(series1);
            this.tlm_chart_view.Size = new System.Drawing.Size(602, 415);
            this.tlm_chart_view.TabIndex = 0;
            this.tlm_chart_view.Text = "chart1";
            // 
            // statistics_tabPage
            // 
            this.statistics_tabPage.Controls.Add(this.Status_groupBox);
            this.statistics_tabPage.Controls.Add(this.taskStackUsage_groupBox);
            this.statistics_tabPage.Controls.Add(this.cpuUsage_groupBox);
            this.statistics_tabPage.Location = new System.Drawing.Point(4, 22);
            this.statistics_tabPage.Name = "statistics_tabPage";
            this.statistics_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.statistics_tabPage.TabIndex = 10;
            this.statistics_tabPage.Text = "Statistics & Status";
            this.statistics_tabPage.UseVisualStyleBackColor = true;
            // 
            // Status_groupBox
            // 
            this.Status_groupBox.Controls.Add(this.Config_Diff_Tb);
            this.Status_groupBox.Controls.Add(this.configurationSync_pictureBox);
            this.Status_groupBox.Controls.Add(this.versionSync_pictureBox);
            this.Status_groupBox.Controls.Add(this.configurationSync_label);
            this.Status_groupBox.Controls.Add(this.versionsSync_label);
            this.Status_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Status_groupBox.Location = new System.Drawing.Point(598, 3);
            this.Status_groupBox.Name = "Status_groupBox";
            this.Status_groupBox.Size = new System.Drawing.Size(649, 123);
            this.Status_groupBox.TabIndex = 2;
            this.Status_groupBox.TabStop = false;
            this.Status_groupBox.Text = "Status";
            // 
            // Config_Diff_Tb
            // 
            this.Config_Diff_Tb.Location = new System.Drawing.Point(211, 75);
            this.Config_Diff_Tb.Name = "Config_Diff_Tb";
            this.Config_Diff_Tb.Size = new System.Drawing.Size(425, 20);
            this.Config_Diff_Tb.TabIndex = 19;
            // 
            // configurationSync_pictureBox
            // 
            this.configurationSync_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("configurationSync_pictureBox.Image")));
            this.configurationSync_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("configurationSync_pictureBox.InitialImage")));
            this.configurationSync_pictureBox.Location = new System.Drawing.Point(167, 75);
            this.configurationSync_pictureBox.Name = "configurationSync_pictureBox";
            this.configurationSync_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.configurationSync_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.configurationSync_pictureBox.TabIndex = 18;
            this.configurationSync_pictureBox.TabStop = false;
            // 
            // versionSync_pictureBox
            // 
            this.versionSync_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("versionSync_pictureBox.Image")));
            this.versionSync_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("versionSync_pictureBox.InitialImage")));
            this.versionSync_pictureBox.Location = new System.Drawing.Point(167, 41);
            this.versionSync_pictureBox.Name = "versionSync_pictureBox";
            this.versionSync_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.versionSync_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.versionSync_pictureBox.TabIndex = 17;
            this.versionSync_pictureBox.TabStop = false;
            // 
            // configurationSync_label
            // 
            this.configurationSync_label.AutoSize = true;
            this.configurationSync_label.Location = new System.Drawing.Point(19, 78);
            this.configurationSync_label.Name = "configurationSync_label";
            this.configurationSync_label.Size = new System.Drawing.Size(118, 13);
            this.configurationSync_label.TabIndex = 1;
            this.configurationSync_label.Text = "Configuration  Sync";
            // 
            // versionsSync_label
            // 
            this.versionsSync_label.AutoSize = true;
            this.versionsSync_label.Location = new System.Drawing.Point(19, 44);
            this.versionsSync_label.Name = "versionsSync_label";
            this.versionsSync_label.Size = new System.Drawing.Size(81, 13);
            this.versionsSync_label.TabIndex = 0;
            this.versionsSync_label.Text = "Version Sync";
            // 
            // taskStackUsage_groupBox
            // 
            this.taskStackUsage_groupBox.Controls.Add(this.pfdStackUsage_textBox);
            this.taskStackUsage_groupBox.Controls.Add(this.pfdTaskUsage_label);
            this.taskStackUsage_groupBox.Controls.Add(this.vtuStackUsage_textBox);
            this.taskStackUsage_groupBox.Controls.Add(this.logStackUsage_textBox);
            this.taskStackUsage_groupBox.Controls.Add(this.mainStackUsage_textBox);
            this.taskStackUsage_groupBox.Controls.Add(this.vtuTaskUsage_label);
            this.taskStackUsage_groupBox.Controls.Add(this.logTaskUsage_label);
            this.taskStackUsage_groupBox.Controls.Add(this.mainTaskUsage_label);
            this.taskStackUsage_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.taskStackUsage_groupBox.Location = new System.Drawing.Point(4, 131);
            this.taskStackUsage_groupBox.Name = "taskStackUsage_groupBox";
            this.taskStackUsage_groupBox.Size = new System.Drawing.Size(588, 185);
            this.taskStackUsage_groupBox.TabIndex = 1;
            this.taskStackUsage_groupBox.TabStop = false;
            this.taskStackUsage_groupBox.Text = "Task Stack Usage";
            // 
            // pfdStackUsage_textBox
            // 
            this.pfdStackUsage_textBox.Enabled = false;
            this.pfdStackUsage_textBox.Location = new System.Drawing.Point(168, 128);
            this.pfdStackUsage_textBox.Name = "pfdStackUsage_textBox";
            this.pfdStackUsage_textBox.Size = new System.Drawing.Size(86, 20);
            this.pfdStackUsage_textBox.TabIndex = 8;
            // 
            // pfdTaskUsage_label
            // 
            this.pfdTaskUsage_label.AutoSize = true;
            this.pfdTaskUsage_label.Location = new System.Drawing.Point(15, 135);
            this.pfdTaskUsage_label.Name = "pfdTaskUsage_label";
            this.pfdTaskUsage_label.Size = new System.Drawing.Size(140, 13);
            this.pfdTaskUsage_label.TabIndex = 7;
            this.pfdTaskUsage_label.Text = "PFD Task Stack Usage";
            // 
            // vtuStackUsage_textBox
            // 
            this.vtuStackUsage_textBox.Enabled = false;
            this.vtuStackUsage_textBox.Location = new System.Drawing.Point(168, 98);
            this.vtuStackUsage_textBox.Name = "vtuStackUsage_textBox";
            this.vtuStackUsage_textBox.Size = new System.Drawing.Size(86, 20);
            this.vtuStackUsage_textBox.TabIndex = 6;
            // 
            // logStackUsage_textBox
            // 
            this.logStackUsage_textBox.Enabled = false;
            this.logStackUsage_textBox.Location = new System.Drawing.Point(168, 72);
            this.logStackUsage_textBox.Name = "logStackUsage_textBox";
            this.logStackUsage_textBox.Size = new System.Drawing.Size(86, 20);
            this.logStackUsage_textBox.TabIndex = 5;
            // 
            // mainStackUsage_textBox
            // 
            this.mainStackUsage_textBox.Enabled = false;
            this.mainStackUsage_textBox.Location = new System.Drawing.Point(168, 46);
            this.mainStackUsage_textBox.Name = "mainStackUsage_textBox";
            this.mainStackUsage_textBox.Size = new System.Drawing.Size(86, 20);
            this.mainStackUsage_textBox.TabIndex = 4;
            // 
            // vtuTaskUsage_label
            // 
            this.vtuTaskUsage_label.AutoSize = true;
            this.vtuTaskUsage_label.Location = new System.Drawing.Point(15, 105);
            this.vtuTaskUsage_label.Name = "vtuTaskUsage_label";
            this.vtuTaskUsage_label.Size = new System.Drawing.Size(141, 13);
            this.vtuTaskUsage_label.TabIndex = 3;
            this.vtuTaskUsage_label.Text = "VTU Task Stack Usage";
            // 
            // logTaskUsage_label
            // 
            this.logTaskUsage_label.AutoSize = true;
            this.logTaskUsage_label.Location = new System.Drawing.Point(15, 76);
            this.logTaskUsage_label.Name = "logTaskUsage_label";
            this.logTaskUsage_label.Size = new System.Drawing.Size(141, 13);
            this.logTaskUsage_label.TabIndex = 2;
            this.logTaskUsage_label.Text = "LOG Task Stack Usage";
            // 
            // mainTaskUsage_label
            // 
            this.mainTaskUsage_label.AutoSize = true;
            this.mainTaskUsage_label.Location = new System.Drawing.Point(15, 46);
            this.mainTaskUsage_label.Name = "mainTaskUsage_label";
            this.mainTaskUsage_label.Size = new System.Drawing.Size(147, 13);
            this.mainTaskUsage_label.TabIndex = 1;
            this.mainTaskUsage_label.Text = "MAIN Task Stack Usage";
            // 
            // cpuUsage_groupBox
            // 
            this.cpuUsage_groupBox.Controls.Add(this.cpuUsage_textBox);
            this.cpuUsage_groupBox.Controls.Add(this.cpuUsage_label);
            this.cpuUsage_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cpuUsage_groupBox.Location = new System.Drawing.Point(3, 3);
            this.cpuUsage_groupBox.Name = "cpuUsage_groupBox";
            this.cpuUsage_groupBox.Size = new System.Drawing.Size(589, 123);
            this.cpuUsage_groupBox.TabIndex = 0;
            this.cpuUsage_groupBox.TabStop = false;
            this.cpuUsage_groupBox.Text = "CPU Usage";
            // 
            // cpuUsage_textBox
            // 
            this.cpuUsage_textBox.AllowDrop = true;
            this.cpuUsage_textBox.Enabled = false;
            this.cpuUsage_textBox.Location = new System.Drawing.Point(169, 41);
            this.cpuUsage_textBox.Name = "cpuUsage_textBox";
            this.cpuUsage_textBox.Size = new System.Drawing.Size(86, 20);
            this.cpuUsage_textBox.TabIndex = 1;
            // 
            // cpuUsage_label
            // 
            this.cpuUsage_label.AutoSize = true;
            this.cpuUsage_label.Location = new System.Drawing.Point(19, 44);
            this.cpuUsage_label.Name = "cpuUsage_label";
            this.cpuUsage_label.Size = new System.Drawing.Size(72, 13);
            this.cpuUsage_label.TabIndex = 0;
            this.cpuUsage_label.Text = "CPU Usage";
            // 
            // offlineParameters_tabPage
            // 
            this.offlineParameters_tabPage.Controls.Add(this.offlineParameters_groupBox);
            this.offlineParameters_tabPage.Location = new System.Drawing.Point(4, 22);
            this.offlineParameters_tabPage.Name = "offlineParameters_tabPage";
            this.offlineParameters_tabPage.Size = new System.Drawing.Size(1299, 590);
            this.offlineParameters_tabPage.TabIndex = 7;
            this.offlineParameters_tabPage.Text = "Offline Parameters";
            this.offlineParameters_tabPage.UseVisualStyleBackColor = true;
            // 
            // offlineParameters_groupBox
            // 
            this.offlineParameters_groupBox.Controls.Add(this.offlineParam_panel);
            this.offlineParameters_groupBox.Location = new System.Drawing.Point(11, 13);
            this.offlineParameters_groupBox.Name = "offlineParameters_groupBox";
            this.offlineParameters_groupBox.Size = new System.Drawing.Size(1237, 565);
            this.offlineParameters_groupBox.TabIndex = 0;
            this.offlineParameters_groupBox.TabStop = false;
            this.offlineParameters_groupBox.Text = "Offline Parametes";
            // 
            // offlineParam_panel
            // 
            this.offlineParam_panel.Controls.Add(this.offlineParam_dataGridView);
            this.offlineParam_panel.Location = new System.Drawing.Point(193, 19);
            this.offlineParam_panel.Name = "offlineParam_panel";
            this.offlineParam_panel.Size = new System.Drawing.Size(765, 529);
            this.offlineParam_panel.TabIndex = 0;
            // 
            // offlineParam_dataGridView
            // 
            this.offlineParam_dataGridView.AllowUserToAddRows = false;
            this.offlineParam_dataGridView.AllowUserToDeleteRows = false;
            this.offlineParam_dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offlineParam_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.offlineParam_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.offlineParam_dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.offlineParam_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offlineParam_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.offlineParam_dataGridView.Name = "offlineParam_dataGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offlineParam_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.offlineParam_dataGridView.RowHeadersVisible = false;
            this.offlineParam_dataGridView.Size = new System.Drawing.Size(765, 529);
            this.offlineParam_dataGridView.TabIndex = 0;
            // 
            // dNLTableBindingSource3
            // 
            this.dNLTableBindingSource3.DataSource = typeof(RT_Viewer.Framework.UAVModule.DNLTable);
            // 
            // mGCIPConfigurationTableDBBindingSource
            // 
            this.mGCIPConfigurationTableDBBindingSource.DataSource = typeof(RT_Viewer.Framework.MGCModule.MGCIPConfigurationTableDB);
            // 
            // fRMTableBindingSource
            // 
            this.fRMTableBindingSource.DataSource = typeof(RT_Viewer.Framework.FRMModule.FRMTable);
            // 
            // keepAliveRX_label
            // 
            this.keepAliveRX_label.AutoSize = true;
            this.keepAliveRX_label.Location = new System.Drawing.Point(26, 7);
            this.keepAliveRX_label.Name = "keepAliveRX_label";
            this.keepAliveRX_label.Size = new System.Drawing.Size(76, 13);
            this.keepAliveRX_label.TabIndex = 13;
            this.keepAliveRX_label.Text = "Keep Alive RX";
            this.keepAliveRX_label.Click += new System.EventHandler(this.keepAliveRX_label_Click);
            // 
            // keepAliveRXCntr_textBox
            // 
            this.keepAliveRXCntr_textBox.Enabled = false;
            this.keepAliveRXCntr_textBox.Location = new System.Drawing.Point(115, 3);
            this.keepAliveRXCntr_textBox.Name = "keepAliveRXCntr_textBox";
            this.keepAliveRXCntr_textBox.Size = new System.Drawing.Size(51, 20);
            this.keepAliveRXCntr_textBox.TabIndex = 12;
            this.keepAliveRXCntr_textBox.Text = "0";
            // 
            // rtMainStatus_panel
            // 
            this.rtMainStatus_panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtMainStatus_panel.Controls.Add(this.gcsIdTextBox);
            this.rtMainStatus_panel.Controls.Add(this.label12);
            this.rtMainStatus_panel.Controls.Add(this.rt2Selected_radioButton);
            this.rtMainStatus_panel.Controls.Add(this.selectedRT_label);
            this.rtMainStatus_panel.Controls.Add(this.rt1Selected_radioButton);
            this.rtMainStatus_panel.Controls.Add(this.rtComStatus_textBox);
            this.rtMainStatus_panel.Controls.Add(this.rtStatus_textBox);
            this.rtMainStatus_panel.Controls.Add(this.kaTX_pictureBox);
            this.rtMainStatus_panel.Controls.Add(this.kaRX_pictureBox);
            this.rtMainStatus_panel.Controls.Add(this.keepAliveTXCntr_textBox);
            this.rtMainStatus_panel.Controls.Add(this.keepAliveTX_label);
            this.rtMainStatus_panel.Controls.Add(this.rtComStatus_label);
            this.rtMainStatus_panel.Controls.Add(this.rtComStatus_pictureBox);
            this.rtMainStatus_panel.Controls.Add(this.rtStatus_label);
            this.rtMainStatus_panel.Controls.Add(this.keepAliveRX_label);
            this.rtMainStatus_panel.Controls.Add(this.keepAliveRXCntr_textBox);
            this.rtMainStatus_panel.Location = new System.Drawing.Point(497, 647);
            this.rtMainStatus_panel.Name = "rtMainStatus_panel";
            this.rtMainStatus_panel.Size = new System.Drawing.Size(762, 55);
            this.rtMainStatus_panel.TabIndex = 14;
            this.rtMainStatus_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.rtiMainStatus_panel_Paint);
            // 
            // gcsIdTextBox
            // 
            this.gcsIdTextBox.Enabled = false;
            this.gcsIdTextBox.Location = new System.Drawing.Point(675, 15);
            this.gcsIdTextBox.Name = "gcsIdTextBox";
            this.gcsIdTextBox.Size = new System.Drawing.Size(41, 20);
            this.gcsIdTextBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(587, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Viewer GCS ID :";
            // 
            // rt2Selected_radioButton
            // 
            this.rt2Selected_radioButton.AutoSize = true;
            this.rt2Selected_radioButton.Location = new System.Drawing.Point(506, 30);
            this.rt2Selected_radioButton.Name = "rt2Selected_radioButton";
            this.rt2Selected_radioButton.Size = new System.Drawing.Size(56, 17);
            this.rt2Selected_radioButton.TabIndex = 7;
            this.rt2Selected_radioButton.Text = "RT - B";
            this.rt2Selected_radioButton.UseVisualStyleBackColor = true;
            this.rt2Selected_radioButton.CheckedChanged += new System.EventHandler(this.rt2Selceted_radioButton_CheckedChanged);
            // 
            // selectedRT_label
            // 
            this.selectedRT_label.AutoSize = true;
            this.selectedRT_label.Location = new System.Drawing.Point(418, 18);
            this.selectedRT_label.Name = "selectedRT_label";
            this.selectedRT_label.Size = new System.Drawing.Size(70, 13);
            this.selectedRT_label.TabIndex = 17;
            this.selectedRT_label.Text = "Selected RT:";
            // 
            // rt1Selected_radioButton
            // 
            this.rt1Selected_radioButton.AutoSize = true;
            this.rt1Selected_radioButton.Checked = true;
            this.rt1Selected_radioButton.Location = new System.Drawing.Point(506, 6);
            this.rt1Selected_radioButton.Name = "rt1Selected_radioButton";
            this.rt1Selected_radioButton.Size = new System.Drawing.Size(56, 17);
            this.rt1Selected_radioButton.TabIndex = 6;
            this.rt1Selected_radioButton.TabStop = true;
            this.rt1Selected_radioButton.Text = "RT - A";
            this.rt1Selected_radioButton.CheckedChanged += new System.EventHandler(this.rt1Selceted_radioButton_CheckedChanged);
            // 
            // rtComStatus_textBox
            // 
            this.rtComStatus_textBox.Enabled = false;
            this.rtComStatus_textBox.Location = new System.Drawing.Point(304, 2);
            this.rtComStatus_textBox.Name = "rtComStatus_textBox";
            this.rtComStatus_textBox.Size = new System.Drawing.Size(108, 20);
            this.rtComStatus_textBox.TabIndex = 19;
            this.rtComStatus_textBox.Text = "N/A";
            this.rtComStatus_textBox.TextChanged += new System.EventHandler(this.rtComStatus_textBox_TextChanged);
            // 
            // rtStatus_textBox
            // 
            this.rtStatus_textBox.Enabled = false;
            this.rtStatus_textBox.Location = new System.Drawing.Point(304, 25);
            this.rtStatus_textBox.Name = "rtStatus_textBox";
            this.rtStatus_textBox.Size = new System.Drawing.Size(108, 20);
            this.rtStatus_textBox.TabIndex = 18;
            this.rtStatus_textBox.Text = "N/A";
            // 
            // kaTX_pictureBox
            // 
            this.kaTX_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kaTX_pictureBox.Image")));
            this.kaTX_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("kaTX_pictureBox.InitialImage")));
            this.kaTX_pictureBox.Location = new System.Drawing.Point(4, 29);
            this.kaTX_pictureBox.Name = "kaTX_pictureBox";
            this.kaTX_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.kaTX_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaTX_pictureBox.TabIndex = 16;
            this.kaTX_pictureBox.TabStop = false;
            // 
            // kaRX_pictureBox
            // 
            this.kaRX_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kaRX_pictureBox.Image")));
            this.kaRX_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("kaRX_pictureBox.InitialImage")));
            this.kaRX_pictureBox.Location = new System.Drawing.Point(4, 7);
            this.kaRX_pictureBox.Name = "kaRX_pictureBox";
            this.kaRX_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.kaRX_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaRX_pictureBox.TabIndex = 16;
            this.kaRX_pictureBox.TabStop = false;
            this.kaRX_pictureBox.Click += new System.EventHandler(this.kaRX_pictureBox_Click);
            // 
            // keepAliveTXCntr_textBox
            // 
            this.keepAliveTXCntr_textBox.Enabled = false;
            this.keepAliveTXCntr_textBox.Location = new System.Drawing.Point(115, 27);
            this.keepAliveTXCntr_textBox.Name = "keepAliveTXCntr_textBox";
            this.keepAliveTXCntr_textBox.Size = new System.Drawing.Size(51, 20);
            this.keepAliveTXCntr_textBox.TabIndex = 17;
            this.keepAliveTXCntr_textBox.Text = "0";
            // 
            // keepAliveTX_label
            // 
            this.keepAliveTX_label.AutoSize = true;
            this.keepAliveTX_label.Location = new System.Drawing.Point(27, 30);
            this.keepAliveTX_label.Name = "keepAliveTX_label";
            this.keepAliveTX_label.Size = new System.Drawing.Size(75, 13);
            this.keepAliveTX_label.TabIndex = 16;
            this.keepAliveTX_label.Text = "Keep Alive TX";
            // 
            // rtComStatus_label
            // 
            this.rtComStatus_label.AutoSize = true;
            this.rtComStatus_label.Location = new System.Drawing.Point(200, 6);
            this.rtComStatus_label.Name = "rtComStatus_label";
            this.rtComStatus_label.Size = new System.Drawing.Size(96, 13);
            this.rtComStatus_label.TabIndex = 16;
            this.rtComStatus_label.Text = "RT communication";
            // 
            // rtComStatus_pictureBox
            // 
            this.rtComStatus_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rtComStatus_pictureBox.Image")));
            this.rtComStatus_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("rtComStatus_pictureBox.InitialImage")));
            this.rtComStatus_pictureBox.Location = new System.Drawing.Point(178, 4);
            this.rtComStatus_pictureBox.Name = "rtComStatus_pictureBox";
            this.rtComStatus_pictureBox.Size = new System.Drawing.Size(17, 16);
            this.rtComStatus_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rtComStatus_pictureBox.TabIndex = 16;
            this.rtComStatus_pictureBox.TabStop = false;
            this.rtComStatus_pictureBox.Click += new System.EventHandler(this.rtComStatus_pictureBox_Click);
            // 
            // rtStatus_label
            // 
            this.rtStatus_label.AutoSize = true;
            this.rtStatus_label.Location = new System.Drawing.Point(200, 30);
            this.rtStatus_label.Name = "rtStatus_label";
            this.rtStatus_label.Size = new System.Drawing.Size(53, 13);
            this.rtStatus_label.TabIndex = 15;
            this.rtStatus_label.Text = "RT status";
            // 
            // menu_menuStrip
            // 
            this.menu_menuStrip.AutoSize = false;
            this.menu_menuStrip.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menu_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menu_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menu_menuStrip.Name = "menu_menuStrip";
            this.menu_menuStrip.Size = new System.Drawing.Size(1317, 24);
            this.menu_menuStrip.TabIndex = 15;
            this.menu_menuStrip.Text = "menuStrip1";
            this.menu_menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.testsToolStripMenuItem.Text = "Tests";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.testsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logLevelTableBindingSource
            // 
            this.logLevelTableBindingSource.DataSource = typeof(RT_Viewer.Framework.LOGModule.LogLevelTable);
            // 
            // logLevelTableBindingSource1
            // 
            this.logLevelTableBindingSource1.DataSource = typeof(RT_Viewer.Framework.LOGModule.LogLevelTable);
            // 
            // logLevelTableBindingSource2
            // 
            this.logLevelTableBindingSource2.DataSource = typeof(RT_Viewer.Framework.LOGModule.LogLevelTable);
            // 
            // logLevelTableBindingSource3
            // 
            this.logLevelTableBindingSource3.DataSource = typeof(RT_Viewer.Framework.LOGModule.LogLevelTable);
            // 
            // logLevelTableBindingSource4
            // 
            this.logLevelTableBindingSource4.DataSource = typeof(RT_Viewer.Framework.LOGModule.LogLevelTable);
            // 
            // mGCIPConfDbBindingSource
            // 
            this.mGCIPConfDbBindingSource.DataSource = typeof(RT_Viewer.Framework.MGCModule.MGCIPConfDb);
            // 
            // mGCIPConfigurationTableDBBindingSource1
            // 
            this.mGCIPConfigurationTableDBBindingSource1.DataSource = typeof(RT_Viewer.Framework.MGCModule.MGCIPConfigurationTableDB);
            // 
            // dNLTableBindingSource2
            // 
            this.dNLTableBindingSource2.DataSource = typeof(RT_Viewer.Framework.UAVModule.DNLTable);
            // 
            // dNLTableBindingSource4
            // 
            this.dNLTableBindingSource4.DataSource = typeof(RT_Viewer.Framework.UAVModule.DNLTable);
            // 
            // RTViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1334, 701);
            this.Controls.Add(this.rtMainStatus_panel);
            this.Controls.Add(this.application_tabControl);
            this.Controls.Add(this.cleanScreen_button);
            this.Controls.Add(this.stopRecieve_button);
            this.Controls.Add(this.startRecieve_button);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.menu_menuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_menuStrip;
            this.MaximumSize = new System.Drawing.Size(1350, 740);
            this.MinimumSize = new System.Drawing.Size(1278, 726);
            this.Name = "RTViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RT Viewer";
            this.Load += new System.EventHandler(this.RTViewerForm_Load);
            this.uplTable_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uplTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPLTableBindingSource)).EndInit();
            this.gdtTable_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdtTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdtTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upTableBindingSource)).EndInit();
            this.dnlTable_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lopTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTableBindingSource)).EndInit();
            this.application_tabControl.ResumeLayout(false);
            this.version_tabPage.ResumeLayout(false);
            this.general_groupBox.ResumeLayout(false);
            this.general_groupBox.PerformLayout();
            this.versions_groupBox.ResumeLayout(false);
            this.versions_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rti_tabPage.ResumeLayout(false);
            this.rti_tabPage.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uavRtiTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTEntryBindingSource)).EndInit();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hstTable_dataGridView)).EndInit();
            this.nvramReadData_groupBox.ResumeLayout(false);
            this.nvramReadData_groupBox.PerformLayout();
            this.uav_tabPage.ResumeLayout(false);
            this.dnlinkTable_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uavTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource5)).EndInit();
            this.ntp_tabPage.ResumeLayout(false);
            this.convertTimeStamp_groupBox.ResumeLayout(false);
            this.convertTimeStamp_groupBox.PerformLayout();
            this.ntpInfo_groupBox.ResumeLayout(false);
            this.ntpInfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntpServerConnection_pictureBox)).EndInit();
            this.frm_tabPage.ResumeLayout(false);
            this.fault_tabControl.ResumeLayout(false);
            this.frmFault_tabPage.ResumeLayout(false);
            this.frmFaults_groupBox.ResumeLayout(false);
            this.frmFaults_groupBox.PerformLayout();
            this.frm_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frm_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRMTableBindingSource1)).EndInit();
            this.pflFault_tabPage.ResumeLayout(false);
            this.pfl_groupBox.ResumeLayout(false);
            this.pfl_groupBox.PerformLayout();
            this.pfl_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pflFault_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFLTableBindingSource)).EndInit();
            this.log_tabPage.ResumeLayout(false);
            this.log_tabControl.ResumeLayout(false);
            this.logProperties_tabPage.ResumeLayout(false);
            this.RTCLogger_groupBox.ResumeLayout(false);
            this.setRTLogLevel_groupBox.ResumeLayout(false);
            this.setLogLevelAllModule_comboBox.ResumeLayout(false);
            this.setRTLogLevel_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setRTLogLevel_dataGridView)).EndInit();
            this.rtcLoggerControl_groupBox.ResumeLayout(false);
            this.LogSearch_tabPage.ResumeLayout(false);
            this.ContentNavigation_groupBox.ResumeLayout(false);
            this.ContentNavigation_groupBox.PerformLayout();
            this.setRTCLoggerFilter_groupBox.ResumeLayout(false);
            this.setRTCLoggerFilter_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setRTCLoggerFilter_dataGridView)).EndInit();
            this.logContent_groupBox.ResumeLayout(false);
            this.logContent_groupBox.PerformLayout();
            this.logContent_splitContainer.Panel1.ResumeLayout(false);
            this.logContent_splitContainer.Panel1.PerformLayout();
            this.logContent_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logContent_splitContainer)).EndInit();
            this.logContent_splitContainer.ResumeLayout(false);
            this.LogSearchStatus_groupBox.ResumeLayout(false);
            this.onlineLogSearch_panel.ResumeLayout(false);
            this.onlineLogSearch_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingLogFilter_pictureBox)).EndInit();
            this.stk_tabPage.ResumeLayout(false);
            this.stk_groupBox.ResumeLayout(false);
            this.stk_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stick_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTKTaxiTableBindingSource)).EndInit();
            this.ird_tabPage.ResumeLayout(false);
            this.ird_groupBox.ResumeLayout(false);
            this.ird_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iridium_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.irdTableBindingSource)).EndInit();
            this.nvm_tabPage.ResumeLayout(false);
            this.nvramWrite_groupBox.ResumeLayout(false);
            this.nvramWrite_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingNVRAMWrite_pictureBox)).EndInit();
            this.nvramRead_groupBox.ResumeLayout(false);
            this.nvramRead_groupBox.PerformLayout();
            this.hky_tabPage.ResumeLayout(false);
            this.hky_tabControl.ResumeLayout(false);
            this.keys_tabPage.ResumeLayout(false);
            this.hky_keys_Console2_groupBox.ResumeLayout(false);
            this.console2Keys_panel.ResumeLayout(false);
            this.console2Keys_panel.PerformLayout();
            this.hky_keys_Console1_groupBox.ResumeLayout(false);
            this.console1Keys_panel.ResumeLayout(false);
            this.console1Keys_panel.PerformLayout();
            this.led_tabPage.ResumeLayout(false);
            this.stkConsole2_groupBox.ResumeLayout(false);
            this.stkConsole2_groupBox.PerformLayout();
            this.console1Led_panel.ResumeLayout(false);
            this.console1Led_panel.PerformLayout();
            this.stkConsole1_groupBox.ResumeLayout(false);
            this.stkConsole1_groupBox.PerformLayout();
            this.console2Led_panel.ResumeLayout(false);
            this.console2Led_panel.PerformLayout();
            this.headingKnob_tabPage.ResumeLayout(false);
            this.headingKnob_groupBox.ResumeLayout(false);
            this.HKY_KnobConsole2Gb.ResumeLayout(false);
            this.HKY_KnobConsole2Gb.PerformLayout();
            this.HKY_KnobConsole1Gb.ResumeLayout(false);
            this.HKY_KnobConsole1Gb.PerformLayout();
            this.pfd_tabPage.ResumeLayout(false);
            this.pfdUpl_groupBox.ResumeLayout(false);
            this.pfdUpl_groupBox.PerformLayout();
            this.mgc_tabPage.ResumeLayout(false);
            this.gru5Info_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gru5Info_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGCIPConfigurationTableDBBindingSource2)).EndInit();
            this.gru4Info_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gru4Info_dataGridView)).EndInit();
            this.gru3Info_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gru3Info_dataGridView)).EndInit();
            this.gru2Info_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gru2Info_dataGridView)).EndInit();
            this.mgcInfo_groupBox.ResumeLayout(false);
            this.mgcInfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hstGruConfTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hSTGruConfTableDBBindingSource)).EndInit();
            this.gru1Info_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gru1Info_dataGridView)).EndInit();
            this.gruAlives_groupBox.ResumeLayout(false);
            this.gruAlives_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru5Conection_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gru4Conection_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gru3Conection_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gru2Conection_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gru1Conection_pictureBox)).EndInit();
            this.gdt_tabPage.ResumeLayout(false);
            this.tlm_tabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tlm_gbx_fileUpdate.ResumeLayout(false);
            this.tlm_gbx_fileUpdate.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tlm_data_tabPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlmTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlmTableBindingSource)).EndInit();
            this.tlm_visual_tabPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tlm_gbx_view_figure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlm_chart_view)).EndInit();
            this.statistics_tabPage.ResumeLayout(false);
            this.Status_groupBox.ResumeLayout(false);
            this.Status_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationSync_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionSync_pictureBox)).EndInit();
            this.taskStackUsage_groupBox.ResumeLayout(false);
            this.taskStackUsage_groupBox.PerformLayout();
            this.cpuUsage_groupBox.ResumeLayout(false);
            this.cpuUsage_groupBox.PerformLayout();
            this.offlineParameters_tabPage.ResumeLayout(false);
            this.offlineParameters_groupBox.ResumeLayout(false);
            this.offlineParam_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offlineParam_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGCIPConfigurationTableDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRMTableBindingSource)).EndInit();
            this.rtMainStatus_panel.ResumeLayout(false);
            this.rtMainStatus_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaTX_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaRX_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtComStatus_pictureBox)).EndInit();
            this.menu_menuStrip.ResumeLayout(false);
            this.menu_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelTableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGCIPConfDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGCIPConfigurationTableDBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLTableBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button startRecieve_button;
        private System.Windows.Forms.GroupBox uplTable_groupBox;
        private System.Windows.Forms.GroupBox gdtTable_groupBox;
        private System.Windows.Forms.GroupBox dnlTable_groupBox;
        private System.Windows.Forms.Button stopRecieve_button;
        private System.Windows.Forms.Button cleanScreen_button;
        private System.Windows.Forms.TabControl application_tabControl;
        private System.Windows.Forms.TabPage rti_tabPage;
        private System.Windows.Forms.TabPage uav_tabPage;
        private System.Windows.Forms.TabPage ntp_tabPage;
        private System.Windows.Forms.TabPage frm_tabPage;
        private System.Windows.Forms.TabPage log_tabPage;
        private System.Windows.Forms.GroupBox RTCLogger_groupBox;
        private System.Windows.Forms.GroupBox logContent_groupBox;
        private System.Windows.Forms.Button startRtcLogger_button;
        private System.Windows.Forms.TextBox logContent_textBox;
        private System.Windows.Forms.GroupBox ntpInfo_groupBox;
        private System.Windows.Forms.Label utc_label;
        private System.Windows.Forms.Label timeStamp_label;
        private System.Windows.Forms.TextBox utc_textBox;
        private System.Windows.Forms.MaskedTextBox timeStamp_textBox;
        private System.Windows.Forms.GroupBox frmFaults_groupBox;
        private System.Windows.Forms.GroupBox dnlinkTable_groupBox;
        private System.Windows.Forms.TabPage nvm_tabPage;
        private System.Windows.Forms.GroupBox nvramRead_groupBox;
        private System.Windows.Forms.TextBox idGcsReadData_textBox;
        private System.Windows.Forms.Label idGcsReadData_label;
        private System.Windows.Forms.Button idGCSRead_button;
        private System.Windows.Forms.GroupBox nvramReadData_groupBox;
        private System.Windows.Forms.Label lopCounter_label;
        private System.Windows.Forms.TextBox lopCounter_textBox;
        private System.Windows.Forms.Label hstCounter_lable;
        private System.Windows.Forms.Label keepAliveRX_label;
        private System.Windows.Forms.TextBox keepAliveRXCntr_textBox;
        private System.Windows.Forms.Panel rtMainStatus_panel;
        private System.Windows.Forms.Label rtComStatus_label;
        private System.Windows.Forms.PictureBox rtComStatus_pictureBox;
        private System.Windows.Forms.Label rtStatus_label;
        private System.Windows.Forms.GroupBox nvramWrite_groupBox;
        private System.Windows.Forms.TextBox idGcsWriteData_textBox;
        private System.Windows.Forms.Label idGcsWriteData_label;
        private System.Windows.Forms.Button idGcsWriteData_button;
        private System.Windows.Forms.DataGridView gdtTable_dataGridView;
        private System.Windows.Forms.DataGridView uplTable_dataGridView;
        private System.Windows.Forms.DataGridView lopTable_dataGridView;
        private System.Windows.Forms.BindingSource upTableBindingSource;
        private System.Windows.Forms.BindingSource lOPTableBindingSource;
        public System.Windows.Forms.TextBox hstCounter_textBox;
        private System.Windows.Forms.Label keepAliveTX_label;
        private System.Windows.Forms.TextBox keepAliveTXCntr_textBox;
        private System.Windows.Forms.PictureBox kaTX_pictureBox;
        private System.Windows.Forms.PictureBox kaRX_pictureBox;
        private System.Windows.Forms.TextBox rtComStatus_textBox;
        private System.Windows.Forms.TextBox rtStatus_textBox;
        private System.Windows.Forms.TextBox buildDate_textBox;
        private System.Windows.Forms.TextBox rtVersion_textBox;
        private System.Windows.Forms.Label selectedRT_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn tailnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView uavTable_dataGridView;
        private System.Windows.Forms.BindingSource dNLTableBindingSource;
        private System.Windows.Forms.BindingSource lOPTableBindingSource1;
        private MenuStrip menu_menuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button filterByStringInLog_button;
        private TextBox searchStringInLog_textBox;
        private Button setLogFilter_button;
        private Label searchStringInLog_label;
        private Button setRTLogLevel_button;
        private Panel setRTLogLevel_panel;
        private Panel setRTCLoggerFilter_panel;
        private RadioButton rt2Selected_radioButton;
        private RadioButton rt1Selected_radioButton;
        private PictureBox loadingLogFilter_pictureBox;
        private DataGridView setRTLogLevel_dataGridView;
        private BindingSource logLevelTableBindingSource;
        private TabControl log_tabControl;
        private TabPage logProperties_tabPage;
        private TabPage LogSearch_tabPage;
        private BindingSource dNLTableBindingSource1;
        private DataGridViewTextBoxColumn tailnumberDataGridViewTextBoxColumn2;
        private BindingSource logLevelTableBindingSource1;
        private BindingSource levelOfReportBindingSource;
        private GroupBox rtcLoggerControl_groupBox;
        private DataGridView setRTCLoggerFilter_dataGridView;
        private Button undoRTCLogLevel_Button;
        private GroupBox setRTLogLevel_groupBox;
        private GroupBox setRTCLoggerFilter_groupBox;
        private GroupBox setLogLevelAllModule_comboBox;
        private Button setRTLogLevelForAllModules_button;
        private ComboBox setLogLevelForAllModules_comboBox;
        private DataGridViewTextBoxColumn tailnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cBandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uHFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sATCOM1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sATCOM2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iRIDIUMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mOBILICOMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cH7DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cH8DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cH9DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cH10DataGridViewTextBoxColumn;
        private BindingSource logLevelTableBindingSource2;
        private BindingSource logLevelTableBindingSource3;
        private BindingSource logLevelTableBindingSource4;
        private Button stopFilterByStringInLog_button;
        private Button openFilteredFile_Button;
        private Button reloadLogFile_button;
        private CheckBox caseSensitiveFilterSearch_checkbox;
        private Label ntpServerConnection_label;
        private PictureBox ntpServerConnection_pictureBox;
        private TextBox ntpServerConnection_textBox;
        private Button copyTimeStamp_button;
        private GroupBox convertTimeStamp_groupBox;
        private Button convertTimeStamp_button;
        private MaskedTextBox utcConvert_textBox;
        private MaskedTextBox timestampConvert_textBox;
        private Label utcConvert_label;
        private Label timestampConvert_label;
        private Label label1;
        private Label frmFaultMaxRecords_label;
        private Label frmFaultCntr_label;
        private TextBox frmFaultMaxRecords_textBox;
        private TextBox frmFaultCntr_textBox;
        private Panel frm_panel;
        private DataGridView frm_dataGridView;
        private BindingSource fRMTableBindingSource;
        private TabPage offlineParameters_tabPage;
        private GroupBox offlineParameters_groupBox;
        private Panel offlineParam_panel;
        private DataGridView offlineParam_dataGridView;
        private TabPage stk_tabPage;
        private TabPage ird_tabPage;
        private GroupBox stk_groupBox;
        private GroupBox ird_groupBox;
        private PictureBox loadingNVRAMWrite_pictureBox;
        private Panel stk_panel;
        private Panel ird_panel;
        private DataGridView stick_dataGridView;
        private DataGridView iridium_dataGridView;
        private BindingSource sTKTaxiTableBindingSource;
        private DataGridViewTextBoxColumn tailnumberDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn ongroundDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxienabledDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxireportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxicommandsentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kacntrDataGridViewTextBoxColumn;

        private BindingSource irdTableBindingSource;
        private DataGridViewTextBoxColumn ird_tailnumber_DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ird_modem_kind_DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ird_is_active_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_state_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_init_substate_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_init_done_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_last_message_kind_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_last_telegram_kind_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_last_respons_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_last_command_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_last_acked_command_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_reception_quality_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_received_reception_quality_DataGridViewTextBoxColumn; 
        private DataGridViewTextBoxColumn ird_modem_is_ready_to_connect_DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ird_last_aps_response_to_ring_DataGridViewTextBoxColumn; 

        private TabPage hky_tabPage;
        private GroupBox stkConsole1_groupBox;
        private GroupBox stkConsole2_groupBox;
        private TextBox hkyConsole2Tail_textBox;
        private Label hkyConsole2Tail_label;
        private TextBox hkyConsole1Tail_textBox;
        private Label hkyConsole1Tail_label;
        private Panel console2Led_panel;
        private Panel console1Led_panel;
        private FlowLayoutPanel ledHKYConsole2_flowLayoutPanel;
        private FlowLayoutPanel ledHKYConsole1_flowLayoutPanel;
        private BindingSource fRMTableBindingSource1;
        private OpenFileDialog loadLogFile_openFileDialog;
        private TabPage statistics_tabPage;
        private GroupBox cpuUsage_groupBox;
        private GroupBox taskStackUsage_groupBox;
        private TextBox cpuUsage_textBox;
        private Label cpuUsage_label;
        private TextBox vtuStackUsage_textBox;
        private TextBox logStackUsage_textBox;
        private TextBox mainStackUsage_textBox;
        private Label vtuTaskUsage_label;
        private Label logTaskUsage_label;
        private Label mainTaskUsage_label;
        private TabControl fault_tabControl;
        private TabPage frmFault_tabPage;
        private TabPage pflFault_tabPage;
        private GroupBox pfl_groupBox;
        private Label totalPFLRecords_label;
        private Label pflFaultReported_label;
        private TextBox totalPFLRecords_textBox;
        private TextBox pflFaultsReported_textBox;
        private Panel pfl_panel;
        private DataGridView pflFault_dataGridView;
        private BindingSource pFLTableBindingSource;
        private DataGridViewTextBoxColumn pFLIDnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pFLLABELDataGridViewTextBoxColumn;
        private TabControl hky_tabControl;
        private TabPage led_tabPage;
        private TabPage keys_tabPage;
        private GroupBox hky_keys_Console2_groupBox;
        private Panel console2Keys_panel;
        private FlowLayoutPanel keysHKYConsole2_flowLayoutPanel;
        private GroupBox hky_keys_Console1_groupBox;
        private Panel console1Keys_panel;
        private FlowLayoutPanel keysHKYConsole1_flowLayoutPanel;
        private TabPage pfd_tabPage;
        private GroupBox pfdUpl_groupBox;
        private TextBox rollData_textBox;
        private Label roll_label;
        private TextBox pitchData_textBox;
        private Label pitch_label;
        private TextBox pfdStackUsage_textBox;
        private Label pfdTaskUsage_label;
        private TabPage version_tabPage;
        private GroupBox versions_groupBox;
        private TextBox viewerVersion_textBox;
        private Label viewerVersion_label;
        private TextBox hbsVersion_textBox;
        private Label hbsVersion_label;
        private Label rtBuildDate_label;
        private Label rtVersion_label;
        private TextBox ipRT2_textBox;
        private Label ipRTB_label;
        private TextBox ipRT1_textBox;
        private Label ipRTA_label;
        private TextBox rtDefualtGatway_textBox;
        private Label rtDefualtGatway_label;
        private PictureBox pictureBox1;
        private GroupBox general_groupBox;
        private TextBox rtMode_textBox;
        private Label rtMode_label;
        //private ToolStripMenuItem settingsToolStripMenuItem;
        private GroupBox Status_groupBox;
        private Label versionsSync_label;
        private Label configurationSync_label;
        private PictureBox configurationSync_pictureBox;
        private PictureBox versionSync_pictureBox;
        private DataGridViewTextBoxColumn mFLIDnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn faultcurrentlyexistsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalNoofappearancesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstappearanceVMSCcycleNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstappearancetimeinmsecDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstdisappearanceVMSCcycleNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstdisappearancetimeinmsecDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn spareDataGridViewTextBoxColumn;
        private DateTimePicker logStart_dateTimePicker;
        private DateTimePicker logEnd_dateTimePicker;
        private ComboBox logDateOperator_comboBox;
        private Label logDateOperand2_label;
        private Label logDateOperand1_label;
        private RadioButton isOfflineSearch_radioButton;
        private Panel onlineLogSearch_panel;
        private Button selectLogFolder_button;
        private RadioButton isOnlineSearch_radioButton;
        private GroupBox LogSearchStatus_groupBox;
        private RichTextBox searchStatus_richTextBox;
        private SplitContainer logContent_splitContainer;
        private Button newSearchLogContent_button;
        private Button showNextLogResult_button;
        private GroupBox ContentNavigation_groupBox;
        private Button logShellSideB_button;
        private Button logShellSideA_button;
        private Button showPrevLogResult_button;
        private Label logPageNumber_label;
        private TabPage mgc_tabPage;
        private GroupBox mgcInfo_groupBox;
        private DataGridView hstGruConfTable_dataGridView;
        private DataGridViewTextBoxColumn aTOLIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uAVIDDataGridViewTextBoxColumn;
        private BindingSource hSTGruConfTableDBBindingSource;
        private Label hstGruConftableCntr_label;
        private TextBox HstGruConfTableCntr_textBox;
        private GroupBox gruAlives_groupBox;
        private PictureBox gru5Conection_pictureBox;
        private PictureBox gru4Conection_pictureBox;
        private PictureBox gru3Conection_pictureBox;
        private PictureBox gru2Conection_pictureBox;
        private PictureBox gru1Conection_pictureBox;
        private Label gru1name_label;
        private Label gru5name_label;
        private Label gru4name_label;
        private Label gru3name_label;
        private Label gru2name_label;
        private Label gru1Configure_label;
        private Label gru5Configure_label;
        private Label gru4Configure_label;
        private Label gru3Configure_label;
        private Label gru2Configure_label;
        private GroupBox gru1Info_groupBox;
        private BindingSource mGCIPConfDbBindingSource;
        private BindingSource mGCIPConfigurationTableDBBindingSource;
        private BindingSource mGCIPConfigurationTableDBBindingSource1;
        private DataGridView gru1Info_dataGridView;
        private BindingSource mGCIPConfigurationTableDBBindingSource2;
        private GroupBox gru5Info_groupBox;
        private DataGridView gru5Info_dataGridView;
        private GroupBox gru4Info_groupBox;
        private DataGridView gru4Info_dataGridView;
        private GroupBox gru3Info_groupBox;
        private DataGridView gru3Info_dataGridView;
        private GroupBox gru2Info_groupBox;
        private DataGridView gru2Info_dataGridView;
        private BindingSource dNLTableBindingSource3;
        private BindingSource dNLTableBindingSource2;
        private BindingSource dNLTableBindingSource5;
        private BindingSource dNLTableBindingSource4;
        private GroupBox groupBox14;
        private GroupBox groupBox13;
        private DataGridView hstTable_dataGridView;
        private Label mainRTCounter_lable;
        public TextBox mainRTCounter_textBox;
        private Label uavCounter_lable;
        public TextBox uavCounter_textBox;
        private Label transactionMode_lable;
        public TextBox transactionMode_textBox;
        private BindingSource gdtTableBindingSource;
        private BindingSource uPLTableBindingSource;
        private BindingSource rTEntryBindingSource;
        private DataGridView uavRtiTable_dataGridView;
        private DataGridViewTextBoxColumn tailnumberDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn cBANDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cBANDCOUNTERDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uHFDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sATCOMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cH4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cH5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cH6DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cH7DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cH8DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cH9DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cH10DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private DataGridViewTextBoxColumn consoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isselectedDataGridViewTextBoxColumn;
        private BindingSource lOPTableBindingSource2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private DataGridViewTextBoxColumn gcsextraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID6DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID7DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID8DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID9DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uplinkID10DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn105;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;
        private TabPage headingKnob_tabPage;
        private GroupBox headingKnob_groupBox;
        private TextBox HN1Calculated_textBox;
        private Label label3;
        private TextBox HN1Read4_textBox;
        private TextBox HN1Read3_textBox;
        private TextBox HN1Read2_textBox;
        private TextBox HN1Read1_textBox;
        private Label label2;
        private TextBox HN1InitStatus_textBox;
        private Label label5;
        private TextBox HN1VendorID1_textBox;
        private Label label4;
        private TextBox HN1VendorID3_textBox;
        private TextBox HN1VendorID2_textBox;
        private TextBox HN1Position_textBox;
        private Label HNPosition_label;
        private TextBox HN1_raw_position_textBox;
        private Label rowPosition_label;
        private Button PresetKnob1Btn;
        private Button StartStopKnob1Btn;
        private GroupBox HKY_KnobConsole1Gb;
        private GroupBox HKY_KnobConsole2Gb;
        private Button PresetKnob2Btn;
        private Button StartStopKnob2Btn;
        private TextBox HN2_raw_position_textBox;
        private Label label6;
        private TextBox HN2Position_textBox;
        private Label label7;
        private TextBox HN2VendorID3_textBox;
        private TextBox HN2VendorID2_textBox;
        private TextBox HN2InitStatus_textBox;
        private Label label8;
        private TextBox HN2VendorID1_textBox;
        private Label label9;
        private TextBox HN2Calculated_textBox;
        private Label label10;
        private TextBox HN2Read4_textBox;
        private TextBox HN2Read3_textBox;
        private TextBox HN2Read2_textBox;
        private TextBox HN2Read1_textBox;
        private Label label11;
		private ToolStripMenuItem testsToolStripMenuItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn gruIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tailNumberAttachedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apsRTCHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rtGRUCHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gRURegularCHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gRUFastCHDataGridViewTextBoxColumn;
        private TabPage gdt_tabPage;
        private Label NtpServerIp_label;
        private TextBox ntpServerIP_textBox;
        private TextBox gcsIdTextBox;
        private Label label12;
        private TextBox Config_Diff_Tb;
        private TabPage tlm_tabPage;
        private TabControl tabControl1;
        private TabPage tlm_data_tabPage;
        private TabPage tlm_visual_tabPage;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private ComboBox tlm_cbx_FindGroup;
        private Label label21;
        private TextBox tlm_tbx_FindName;
        private Label label20;
        private GroupBox groupBox3;
        private Label label18;
        private GroupBox groupBox2;
        private RadioButton tlm_rdb_ReadSourceCurrent;
        private RadioButton tlm_rdb_ReadSourceFlash;
        private DataGridView tlmTable_dataGridView;
        private RadioButton tlm_rdb_ReadSourceFile;
        private GroupBox groupBox6;
        private OpenFileDialog Tlm_openFileDialog;
        private Button tlm_btn_SaveConfigurations;
        private RadioButton tlm_rdb_DataTypeOrginal;
        private RadioButton tlm_rdb_DataTypeChars;
        private RadioButton tlm_rdb_SortLowHigh;
        private RadioButton tlm_rdb_SortHighLow;
        private RadioButton tlm_rdb_SortByGroups;
        private Button tlm_btn_ForceUpdate;
        private GroupBox tlm_gbx_fileUpdate;
        private TextBox tlm_tbx_ForceUpdatePath;
        private Label label19;
        private BindingSource tlmTableBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datatypeDataGridViewTextBoxColumn;
        private GroupBox tlm_gbx_view_figure;
        private System.Windows.Forms.DataVisualization.Charting.Chart tlm_chart_view;
        private Button tlm_btn_FigureDataMember;
        private GroupBox groupBox9;
        private Label label14;
        private TextBox tlm_tbx_PathConfigFiles;
        private GroupBox groupBox10;
        private RichTextBox tlm_rtb_view_res_table_value;
        private Label label23;
        private RichTextBox tlm_rtb_view_res_table_time;
        private Label label17;
        private GroupBox groupBox7;
        private Button tlm_btn_SaveBigTableSelect;
        private Label label24;
        private Label label25;
        private TextBox tlm_tbx_SaveBigTablePath;
        private ComboBox tlm_cbx_SaveBigTableType;
        private GroupBox groupBox5;
        private ComboBox tlm_cbx_ViewerSaveType;
        private Button tlm_btn_ViewerSave;
        private Label label13;
        private Label label15;
        private TextBox tlm_btn_ViewerSavePath;
    }
}

