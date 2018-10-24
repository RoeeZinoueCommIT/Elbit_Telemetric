namespace RT_Viewer.Forms
{
    partial class TesterForm
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
            this.vtuTests_groupBox = new System.Windows.Forms.GroupBox();
            this.injectWrongCS_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.injectWrongMagic_label = new System.Windows.Forms.Label();
            this.injectWrongOpcode_button = new System.Windows.Forms.Button();
            this.injectWrongMgcNum_button = new System.Windows.Forms.Button();
            this.injectWrongCrc_button = new System.Windows.Forms.Button();
            this.vtuTests_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vtuTests_groupBox
            // 
            this.vtuTests_groupBox.Controls.Add(this.injectWrongCS_label);
            this.vtuTests_groupBox.Controls.Add(this.label2);
            this.vtuTests_groupBox.Controls.Add(this.injectWrongMagic_label);
            this.vtuTests_groupBox.Controls.Add(this.injectWrongOpcode_button);
            this.vtuTests_groupBox.Controls.Add(this.injectWrongMgcNum_button);
            this.vtuTests_groupBox.Controls.Add(this.injectWrongCrc_button);
            this.vtuTests_groupBox.Location = new System.Drawing.Point(8, 2);
            this.vtuTests_groupBox.Name = "vtuTests_groupBox";
            this.vtuTests_groupBox.Size = new System.Drawing.Size(528, 194);
            this.vtuTests_groupBox.TabIndex = 1;
            this.vtuTests_groupBox.TabStop = false;
            this.vtuTests_groupBox.Text = "VTU Tests";
            // 
            // injectWrongCS_label
            // 
            this.injectWrongCS_label.AutoSize = true;
            this.injectWrongCS_label.Location = new System.Drawing.Point(211, 159);
            this.injectWrongCS_label.Name = "injectWrongCS_label";
            this.injectWrongCS_label.Size = new System.Drawing.Size(288, 13);
            this.injectWrongCS_label.TabIndex = 5;
            this.injectWrongCS_label.Text = "Inject a message from Viewer to RTC with wrong checksum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inject a message from Viewer to RTC with invalid Opcode number";
            // 
            // injectWrongMagic_label
            // 
            this.injectWrongMagic_label.AutoSize = true;
            this.injectWrongMagic_label.Location = new System.Drawing.Point(211, 37);
            this.injectWrongMagic_label.Name = "injectWrongMagic_label";
            this.injectWrongMagic_label.Size = new System.Drawing.Size(307, 13);
            this.injectWrongMagic_label.TabIndex = 3;
            this.injectWrongMagic_label.Text = "Inject a message from Viewer to RTC with invalid Magic number";
            // 
            // injectWrongOpcode_button
            // 
            this.injectWrongOpcode_button.Location = new System.Drawing.Point(19, 89);
            this.injectWrongOpcode_button.Name = "injectWrongOpcode_button";
            this.injectWrongOpcode_button.Size = new System.Drawing.Size(167, 26);
            this.injectWrongOpcode_button.TabIndex = 2;
            this.injectWrongOpcode_button.Text = "Inject Wrong Opcode";
            this.injectWrongOpcode_button.UseVisualStyleBackColor = true;
            this.injectWrongOpcode_button.Click += new System.EventHandler(this.injectWrongOpcode_button_Click);
            // 
            // injectWrongMgcNum_button
            // 
            this.injectWrongMgcNum_button.Location = new System.Drawing.Point(19, 30);
            this.injectWrongMgcNum_button.Name = "injectWrongMgcNum_button";
            this.injectWrongMgcNum_button.Size = new System.Drawing.Size(167, 26);
            this.injectWrongMgcNum_button.TabIndex = 1;
            this.injectWrongMgcNum_button.Text = "Inject Wrong Magic Number";
            this.injectWrongMgcNum_button.UseVisualStyleBackColor = true;
            this.injectWrongMgcNum_button.Click += new System.EventHandler(this.injectWrongMgcNum_button_Click);
            // 
            // injectWrongCrc_button
            // 
            this.injectWrongCrc_button.Location = new System.Drawing.Point(19, 152);
            this.injectWrongCrc_button.Name = "injectWrongCrc_button";
            this.injectWrongCrc_button.Size = new System.Drawing.Size(167, 26);
            this.injectWrongCrc_button.TabIndex = 0;
            this.injectWrongCrc_button.Text = "Inject Wrong CRC";
            this.injectWrongCrc_button.UseVisualStyleBackColor = true;
            this.injectWrongCrc_button.Click += new System.EventHandler(this.injectWrongCrc_button_Click);
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(539, 200);
            this.Controls.Add(this.vtuTests_groupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 238);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(555, 238);
            this.Name = "TesterForm";
            this.Text = "TesterForm";
           // this.Load += new System.EventHandler(this.TesterForm_Load);
            this.vtuTests_groupBox.ResumeLayout(false);
            this.vtuTests_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox vtuTests_groupBox;
        private System.Windows.Forms.Label injectWrongCS_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label injectWrongMagic_label;
        private System.Windows.Forms.Button injectWrongOpcode_button;
        private System.Windows.Forms.Button injectWrongMgcNum_button;
        private System.Windows.Forms.Button injectWrongCrc_button;

    }
}