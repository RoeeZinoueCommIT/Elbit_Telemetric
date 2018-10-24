using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RT_Viewer.Forms
{
    public partial class GenericTextBoxForm : Form
    {
        public GenericTextBoxForm(string formName, string content, int height, int width)
        {
            InitializeComponent();
            this.Text = formName;
            content_richTextBox.AppendText(content);
            this.Height = height;
            this.Width = width;
        }

        private void GenericTextBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
