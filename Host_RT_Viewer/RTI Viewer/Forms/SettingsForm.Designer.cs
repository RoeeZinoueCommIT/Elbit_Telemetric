namespace RT_Viewer.Forms
{
    partial class SettingsForm
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
            this.settings_groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoggerRt2PortTb = new System.Windows.Forms.TextBox();
            this.LoggerRt1PortTb = new System.Windows.Forms.TextBox();
            this.LoggerMcstIpTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IpFourthNibleTb = new System.Windows.Forms.TextBox();
            this.IpThirdNibleTb = new System.Windows.Forms.TextBox();
            this.IpSecondNibleTb = new System.Windows.Forms.TextBox();
            this.IpFirstNibleTb = new System.Windows.Forms.TextBox();
            this.selectedGcsID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setSettings_button = new System.Windows.Forms.Button();
            this.rtBRxPort_textBox = new System.Windows.Forms.TextBox();
            this.rtBTxPort_textBox = new System.Windows.Forms.TextBox();
            this.rtARxPort_textBox = new System.Windows.Forms.TextBox();
            this.rtATxPort_textBox = new System.Windows.Forms.TextBox();
            this.rtBRxPort_label = new System.Windows.Forms.Label();
            this.rtBTxPort_label = new System.Windows.Forms.Label();
            this.rtARxPort_label = new System.Windows.Forms.Label();
            this.rtATxPort_label = new System.Windows.Forms.Label();
            this.settingsMulticastIP_label = new System.Windows.Forms.Label();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.settings_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_groupBox
            // 
            this.settings_groupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings_groupBox.Controls.Add(this.groupBox1);
            this.settings_groupBox.Controls.Add(this.label4);
            this.settings_groupBox.Controls.Add(this.label3);
            this.settings_groupBox.Controls.Add(this.label2);
            this.settings_groupBox.Controls.Add(this.IpFourthNibleTb);
            this.settings_groupBox.Controls.Add(this.IpThirdNibleTb);
            this.settings_groupBox.Controls.Add(this.IpSecondNibleTb);
            this.settings_groupBox.Controls.Add(this.IpFirstNibleTb);
            this.settings_groupBox.Controls.Add(this.selectedGcsID_textBox);
            this.settings_groupBox.Controls.Add(this.label1);
            this.settings_groupBox.Controls.Add(this.setSettings_button);
            this.settings_groupBox.Controls.Add(this.rtBRxPort_textBox);
            this.settings_groupBox.Controls.Add(this.rtBTxPort_textBox);
            this.settings_groupBox.Controls.Add(this.rtARxPort_textBox);
            this.settings_groupBox.Controls.Add(this.rtATxPort_textBox);
            this.settings_groupBox.Controls.Add(this.rtBRxPort_label);
            this.settings_groupBox.Controls.Add(this.rtBTxPort_label);
            this.settings_groupBox.Controls.Add(this.rtARxPort_label);
            this.settings_groupBox.Controls.Add(this.rtATxPort_label);
            this.settings_groupBox.Controls.Add(this.settingsMulticastIP_label);
            this.settings_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_groupBox.Location = new System.Drawing.Point(0, 0);
            this.settings_groupBox.Name = "settings_groupBox";
            this.settings_groupBox.Size = new System.Drawing.Size(355, 480);
            this.settings_groupBox.TabIndex = 0;
            this.settings_groupBox.TabStop = false;
            this.settings_groupBox.Text = "Communication Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoggerRt2PortTb);
            this.groupBox1.Controls.Add(this.LoggerRt1PortTb);
            this.groupBox1.Controls.Add(this.LoggerMcstIpTb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(25, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 149);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logger Communication Settings";
            // 
            // LoggerRt2PortTb
            // 
            this.LoggerRt2PortTb.Enabled = false;
            this.LoggerRt2PortTb.Location = new System.Drawing.Point(157, 103);
            this.LoggerRt2PortTb.Name = "LoggerRt2PortTb";
            this.LoggerRt2PortTb.Size = new System.Drawing.Size(122, 20);
            this.LoggerRt2PortTb.TabIndex = 25;
            // 
            // LoggerRt1PortTb
            // 
            this.LoggerRt1PortTb.Enabled = false;
            this.LoggerRt1PortTb.Location = new System.Drawing.Point(157, 62);
            this.LoggerRt1PortTb.Name = "LoggerRt1PortTb";
            this.LoggerRt1PortTb.Size = new System.Drawing.Size(122, 20);
            this.LoggerRt1PortTb.TabIndex = 24;
            // 
            // LoggerMcstIpTb
            // 
            this.LoggerMcstIpTb.Enabled = false;
            this.LoggerMcstIpTb.Location = new System.Drawing.Point(157, 27);
            this.LoggerMcstIpTb.Name = "LoggerMcstIpTb";
            this.LoggerMcstIpTb.Size = new System.Drawing.Size(122, 20);
            this.LoggerMcstIpTb.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Logger RT2 Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Logger RT1 Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Logger Multicast IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = ".";
            // 
            // IpFourthNibleTb
            // 
            this.IpFourthNibleTb.Location = new System.Drawing.Point(298, 63);
            this.IpFourthNibleTb.Name = "IpFourthNibleTb";
            this.IpFourthNibleTb.Size = new System.Drawing.Size(24, 20);
            this.IpFourthNibleTb.TabIndex = 16;
            // 
            // IpThirdNibleTb
            // 
            this.IpThirdNibleTb.Enabled = false;
            this.IpThirdNibleTb.Location = new System.Drawing.Point(256, 64);
            this.IpThirdNibleTb.Name = "IpThirdNibleTb";
            this.IpThirdNibleTb.Size = new System.Drawing.Size(24, 20);
            this.IpThirdNibleTb.TabIndex = 15;
            // 
            // IpSecondNibleTb
            // 
            this.IpSecondNibleTb.Location = new System.Drawing.Point(217, 64);
            this.IpSecondNibleTb.Name = "IpSecondNibleTb";
            this.IpSecondNibleTb.Size = new System.Drawing.Size(24, 20);
            this.IpSecondNibleTb.TabIndex = 14;
            // 
            // IpFirstNibleTb
            // 
            this.IpFirstNibleTb.Location = new System.Drawing.Point(176, 64);
            this.IpFirstNibleTb.Name = "IpFirstNibleTb";
            this.IpFirstNibleTb.Size = new System.Drawing.Size(24, 20);
            this.IpFirstNibleTb.TabIndex = 13;
            // 
            // selectedGcsID_textBox
            // 
            this.selectedGcsID_textBox.Location = new System.Drawing.Point(182, 34);
            this.selectedGcsID_textBox.Name = "selectedGcsID_textBox";
            this.selectedGcsID_textBox.Size = new System.Drawing.Size(122, 20);
            this.selectedGcsID_textBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Viewer GCS ID (1-255)";
            // 
            // setSettings_button
            // 
            this.setSettings_button.Location = new System.Drawing.Point(127, 422);
            this.setSettings_button.Name = "setSettings_button";
            this.setSettings_button.Size = new System.Drawing.Size(98, 28);
            this.setSettings_button.TabIndex = 10;
            this.setSettings_button.Text = "Save Settings";
            this.setSettings_button.UseVisualStyleBackColor = true;
            this.setSettings_button.Click += new System.EventHandler(this.setSettings_button_Click);
            // 
            // rtBRxPort_textBox
            // 
            this.rtBRxPort_textBox.Location = new System.Drawing.Point(182, 177);
            this.rtBRxPort_textBox.Name = "rtBRxPort_textBox";
            this.rtBRxPort_textBox.Size = new System.Drawing.Size(122, 20);
            this.rtBRxPort_textBox.TabIndex = 9;
            // 
            // rtBTxPort_textBox
            // 
            this.rtBTxPort_textBox.Location = new System.Drawing.Point(182, 150);
            this.rtBTxPort_textBox.Name = "rtBTxPort_textBox";
            this.rtBTxPort_textBox.Size = new System.Drawing.Size(122, 20);
            this.rtBTxPort_textBox.TabIndex = 8;
            // 
            // rtARxPort_textBox
            // 
            this.rtARxPort_textBox.Location = new System.Drawing.Point(182, 124);
            this.rtARxPort_textBox.Name = "rtARxPort_textBox";
            this.rtARxPort_textBox.Size = new System.Drawing.Size(122, 20);
            this.rtARxPort_textBox.TabIndex = 7;
            // 
            // rtATxPort_textBox
            // 
            this.rtATxPort_textBox.Location = new System.Drawing.Point(182, 97);
            this.rtATxPort_textBox.Name = "rtATxPort_textBox";
            this.rtATxPort_textBox.Size = new System.Drawing.Size(122, 20);
            this.rtATxPort_textBox.TabIndex = 6;
            // 
            // rtBRxPort_label
            // 
            this.rtBRxPort_label.AutoSize = true;
            this.rtBRxPort_label.Location = new System.Drawing.Point(51, 180);
            this.rtBRxPort_label.Name = "rtBRxPort_label";
            this.rtBRxPort_label.Size = new System.Drawing.Size(103, 13);
            this.rtBRxPort_label.TabIndex = 4;
            this.rtBRxPort_label.Text = "RT - B Receive Port";
            // 
            // rtBTxPort_label
            // 
            this.rtBTxPort_label.AutoSize = true;
            this.rtBTxPort_label.Location = new System.Drawing.Point(51, 150);
            this.rtBTxPort_label.Name = "rtBTxPort_label";
            this.rtBTxPort_label.Size = new System.Drawing.Size(103, 13);
            this.rtBTxPort_label.TabIndex = 3;
            this.rtBTxPort_label.Text = "RT - B Transmit Port";
            // 
            // rtARxPort_label
            // 
            this.rtARxPort_label.AutoSize = true;
            this.rtARxPort_label.Location = new System.Drawing.Point(51, 124);
            this.rtARxPort_label.Name = "rtARxPort_label";
            this.rtARxPort_label.Size = new System.Drawing.Size(103, 13);
            this.rtARxPort_label.TabIndex = 2;
            this.rtARxPort_label.Text = "RT - A Receive Port";
            // 
            // rtATxPort_label
            // 
            this.rtATxPort_label.AutoSize = true;
            this.rtATxPort_label.Location = new System.Drawing.Point(51, 97);
            this.rtATxPort_label.Name = "rtATxPort_label";
            this.rtATxPort_label.Size = new System.Drawing.Size(103, 13);
            this.rtATxPort_label.TabIndex = 1;
            this.rtATxPort_label.Text = "RT - A Transmit Port";
            // 
            // settingsMulticastIP_label
            // 
            this.settingsMulticastIP_label.AutoSize = true;
            this.settingsMulticastIP_label.Location = new System.Drawing.Point(51, 67);
            this.settingsMulticastIP_label.Name = "settingsMulticastIP_label";
            this.settingsMulticastIP_label.Size = new System.Drawing.Size(113, 13);
            this.settingsMulticastIP_label.TabIndex = 0;
            this.settingsMulticastIP_label.Text = "Receiving Multicast IP";
            // 
            // settings_panel
            // 
            this.settings_panel.Controls.Add(this.settings_groupBox);
            this.settings_panel.Location = new System.Drawing.Point(12, 12);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(355, 480);
            this.settings_panel.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 500);
            this.Controls.Add(this.settings_panel);
            this.MaximumSize = new System.Drawing.Size(395, 538);
            this.MinimumSize = new System.Drawing.Size(395, 538);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settings_groupBox.ResumeLayout(false);
            this.settings_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.settings_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settings_groupBox;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Label rtBRxPort_label;
        private System.Windows.Forms.Label rtBTxPort_label;
        private System.Windows.Forms.Label rtARxPort_label;
        private System.Windows.Forms.Label rtATxPort_label;
        private System.Windows.Forms.Label settingsMulticastIP_label;
        private System.Windows.Forms.TextBox rtBRxPort_textBox;
        private System.Windows.Forms.TextBox rtBTxPort_textBox;
        private System.Windows.Forms.TextBox rtARxPort_textBox;
        private System.Windows.Forms.TextBox rtATxPort_textBox;
        private System.Windows.Forms.Button setSettings_button;
        private System.Windows.Forms.TextBox selectedGcsID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IpFourthNibleTb;
        private System.Windows.Forms.TextBox IpThirdNibleTb;
        private System.Windows.Forms.TextBox IpSecondNibleTb;
        private System.Windows.Forms.TextBox IpFirstNibleTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoggerMcstIpTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LoggerRt2PortTb;
        private System.Windows.Forms.TextBox LoggerRt1PortTb;
    }
}