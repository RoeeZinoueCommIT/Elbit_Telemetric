namespace RT_Viewer.Forms
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.productName_label = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.copyright_label = new System.Windows.Forms.Label();
            this.companyName_label = new System.Windows.Forms.Label();
            this.aboutDescription_textBox = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logo_pictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.productName_label, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.version_label, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.copyright_label, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.companyName_label, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.aboutDescription_textBox, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.ok_button, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logo_pictureBox.Image")));
            this.logo_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logo_pictureBox, 6);
            this.logo_pictureBox.Size = new System.Drawing.Size(131, 259);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pictureBox.TabIndex = 12;
            this.logo_pictureBox.TabStop = false;
            // 
            // productName_label
            // 
            this.productName_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productName_label.Location = new System.Drawing.Point(143, 0);
            this.productName_label.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.productName_label.MaximumSize = new System.Drawing.Size(0, 17);
            this.productName_label.Name = "productName_label";
            this.productName_label.Size = new System.Drawing.Size(271, 17);
            this.productName_label.TabIndex = 19;
            this.productName_label.Text = "RT Viewer";
            this.productName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // version_label
            // 
            this.version_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.version_label.Location = new System.Drawing.Point(143, 26);
            this.version_label.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.version_label.MaximumSize = new System.Drawing.Size(0, 17);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(271, 17);
            this.version_label.TabIndex = 0;
            this.version_label.Text = "Version";
            this.version_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyright_label
            // 
            this.copyright_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyright_label.Location = new System.Drawing.Point(143, 52);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.copyright_label.MaximumSize = new System.Drawing.Size(0, 17);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(271, 17);
            this.copyright_label.TabIndex = 21;
            this.copyright_label.Text = "Copyright © 2017 Elbit Systems LTD";
            this.copyright_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // companyName_label
            // 
            this.companyName_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyName_label.Location = new System.Drawing.Point(143, 78);
            this.companyName_label.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.companyName_label.MaximumSize = new System.Drawing.Size(0, 17);
            this.companyName_label.Name = "companyName_label";
            this.companyName_label.Size = new System.Drawing.Size(271, 17);
            this.companyName_label.TabIndex = 22;
            this.companyName_label.Text = "Elbit Systems";
            this.companyName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aboutDescription_textBox
            // 
            this.aboutDescription_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutDescription_textBox.Location = new System.Drawing.Point(143, 107);
            this.aboutDescription_textBox.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.aboutDescription_textBox.Multiline = true;
            this.aboutDescription_textBox.Name = "aboutDescription_textBox";
            this.aboutDescription_textBox.ReadOnly = true;
            this.aboutDescription_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.aboutDescription_textBox.Size = new System.Drawing.Size(271, 126);
            this.aboutDescription_textBox.TabIndex = 23;
            this.aboutDescription_textBox.TabStop = false;
            this.aboutDescription_textBox.Text = "Description";
            this.aboutDescription_textBox.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ok_button.Location = new System.Drawing.Point(339, 239);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 24;
            this.ok_button.Text = "&OK";
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox1";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.Label productName_label;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.Label companyName_label;
        private System.Windows.Forms.TextBox aboutDescription_textBox;
        private System.Windows.Forms.Button ok_button;
    }
}
