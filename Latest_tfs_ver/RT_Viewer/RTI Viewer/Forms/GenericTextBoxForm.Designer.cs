namespace RT_Viewer.Forms
{
    partial class GenericTextBoxForm
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
            this.content_panel = new System.Windows.Forms.Panel();
            this.content_richTextBox = new System.Windows.Forms.RichTextBox();
            this.content_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // content_panel
            // 
            this.content_panel.Controls.Add(this.content_richTextBox);
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_panel.Location = new System.Drawing.Point(0, 0);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(1101, 425);
            this.content_panel.TabIndex = 1;
            // 
            // content_richTextBox
            // 
            this.content_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_richTextBox.Location = new System.Drawing.Point(0, 0);
            this.content_richTextBox.Name = "content_richTextBox";
            this.content_richTextBox.Size = new System.Drawing.Size(1101, 425);
            this.content_richTextBox.TabIndex = 0;
            this.content_richTextBox.Text = "";
            // 
            // GenericTextBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 425);
            this.Controls.Add(this.content_panel);
            this.Name = "GenericTextBoxForm";
            this.Text = "GenericTextBoxForm";
            this.Load += new System.EventHandler(this.GenericTextBoxForm_Load);
            this.content_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.RichTextBox content_richTextBox;
    }
}