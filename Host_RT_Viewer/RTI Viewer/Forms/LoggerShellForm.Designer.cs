namespace RT_Viewer.Forms
{
    partial class LoggerShellForm
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
            this.logShellContent_textBox = new System.Windows.Forms.TextBox();
            this.shell_panel = new System.Windows.Forms.Panel();
            this.logShellContent_groupBox = new System.Windows.Forms.GroupBox();
            this.LogShellSettings_groupBox = new System.Windows.Forms.GroupBox();
            this.clearShell_button = new System.Windows.Forms.Button();
            this.speedShell_comboBox = new System.Windows.Forms.ComboBox();
            this.shellSpeed_label = new System.Windows.Forms.Label();
            this.RTLogShell_label = new System.Windows.Forms.Label();
            this.pauseContinueShell_button = new System.Windows.Forms.Button();
            this.shell_panel.SuspendLayout();
            this.logShellContent_groupBox.SuspendLayout();
            this.LogShellSettings_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logShellContent_textBox
            // 
            this.logShellContent_textBox.Location = new System.Drawing.Point(6, 19);
            this.logShellContent_textBox.Multiline = true;
            this.logShellContent_textBox.Name = "logShellContent_textBox";
            this.logShellContent_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logShellContent_textBox.Size = new System.Drawing.Size(958, 447);
            this.logShellContent_textBox.TabIndex = 1;
            this.logShellContent_textBox.TextChanged += new System.EventHandler(this.logShellContent_textBox_TextChanged);
            this.logShellContent_textBox.MouseClick+= new System.Windows.Forms.MouseEventHandler(logShellContent_textBox_MouseClick);
            // 
            // shell_panel
            // 
            this.shell_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shell_panel.Controls.Add(this.logShellContent_groupBox);
            this.shell_panel.Controls.Add(this.LogShellSettings_groupBox);
            this.shell_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shell_panel.Location = new System.Drawing.Point(0, 0);
            this.shell_panel.Name = "shell_panel";
            this.shell_panel.Size = new System.Drawing.Size(984, 562);
            this.shell_panel.TabIndex = 2;
            // 
            // logShellContent_groupBox
            // 
            this.logShellContent_groupBox.Controls.Add(this.logShellContent_textBox);
            this.logShellContent_groupBox.Location = new System.Drawing.Point(8, 84);
            this.logShellContent_groupBox.Name = "logShellContent_groupBox";
            this.logShellContent_groupBox.Size = new System.Drawing.Size(973, 475);
            this.logShellContent_groupBox.TabIndex = 3;
            this.logShellContent_groupBox.TabStop = false;
            this.logShellContent_groupBox.Text = "Log Shell Content";
            // 
            // LogShellSettings_groupBox
            // 
            this.LogShellSettings_groupBox.Controls.Add(this.clearShell_button);
            this.LogShellSettings_groupBox.Controls.Add(this.speedShell_comboBox);
            this.LogShellSettings_groupBox.Controls.Add(this.shellSpeed_label);
            this.LogShellSettings_groupBox.Controls.Add(this.RTLogShell_label);
            this.LogShellSettings_groupBox.Controls.Add(this.pauseContinueShell_button);
            this.LogShellSettings_groupBox.Location = new System.Drawing.Point(12, 3);
            this.LogShellSettings_groupBox.Name = "LogShellSettings_groupBox";
            this.LogShellSettings_groupBox.Size = new System.Drawing.Size(963, 75);
            this.LogShellSettings_groupBox.TabIndex = 2;
            this.LogShellSettings_groupBox.TabStop = false;
            this.LogShellSettings_groupBox.Text = "Shell Settings";
            // 
            // clearShell_button
            // 
            this.clearShell_button.Location = new System.Drawing.Point(412, 26);
            this.clearShell_button.Name = "clearShell_button";
            this.clearShell_button.Size = new System.Drawing.Size(120, 34);
            this.clearShell_button.TabIndex = 5;
            this.clearShell_button.Text = "Clear";
            this.clearShell_button.UseVisualStyleBackColor = true;
            this.clearShell_button.Click += new System.EventHandler(this.clearShell_button_Click);
            // 
            // speedShell_comboBox
            // 
            this.speedShell_comboBox.FormatString = "N2";
            this.speedShell_comboBox.FormattingEnabled = true;
            this.speedShell_comboBox.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.speedShell_comboBox.Location = new System.Drawing.Point(677, 32);
            this.speedShell_comboBox.Name = "speedShell_comboBox";
            this.speedShell_comboBox.Size = new System.Drawing.Size(82, 21);
            this.speedShell_comboBox.TabIndex = 4;
            this.speedShell_comboBox.Text = "200";
            // 
            // shellSpeed_label
            // 
            this.shellSpeed_label.AutoSize = true;
            this.shellSpeed_label.Location = new System.Drawing.Point(571, 37);
            this.shellSpeed_label.Name = "shellSpeed_label";
            this.shellSpeed_label.Size = new System.Drawing.Size(100, 13);
            this.shellSpeed_label.TabIndex = 3;
            this.shellSpeed_label.Text = "Reading Speed[ms]";
            // 
            // RTLogShell_label
            // 
            this.RTLogShell_label.AutoSize = true;
            this.RTLogShell_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RTLogShell_label.Location = new System.Drawing.Point(21, 29);
            this.RTLogShell_label.Name = "RTLogShell_label";
            this.RTLogShell_label.Size = new System.Drawing.Size(213, 24);
            this.RTLogShell_label.TabIndex = 2;
            this.RTLogShell_label.Text = "RTC Side A Log Shell";
            // 
            // pauseContinueShell_button
            // 
            this.pauseContinueShell_button.Location = new System.Drawing.Point(262, 26);
            this.pauseContinueShell_button.Name = "pauseContinueShell_button";
            this.pauseContinueShell_button.Size = new System.Drawing.Size(120, 34);
            this.pauseContinueShell_button.TabIndex = 1;
            this.pauseContinueShell_button.Text = "Pause Shell";
            this.pauseContinueShell_button.UseVisualStyleBackColor = true;
            this.pauseContinueShell_button.Click += new System.EventHandler(this.pauseContinueShell_button_Click);
            // 
            // LoggerShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.shell_panel);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(200, 300);
            this.Name = "LoggerShellForm";
            this.Text = "LoggerShellForm";
            this.Load += new System.EventHandler(this.LoggerShellForm_Load);
            this.shell_panel.ResumeLayout(false);
            this.logShellContent_groupBox.ResumeLayout(false);
            this.logShellContent_groupBox.PerformLayout();
            this.LogShellSettings_groupBox.ResumeLayout(false);
            this.LogShellSettings_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox logShellContent_textBox;
        private System.Windows.Forms.Panel shell_panel;
        private System.Windows.Forms.GroupBox logShellContent_groupBox;
        private System.Windows.Forms.GroupBox LogShellSettings_groupBox;
        private System.Windows.Forms.Button pauseContinueShell_button;
        private System.Windows.Forms.Label RTLogShell_label;
        private System.Windows.Forms.Label shellSpeed_label;
        private System.Windows.Forms.ComboBox speedShell_comboBox;
        private System.Windows.Forms.Button clearShell_button;

    }
}