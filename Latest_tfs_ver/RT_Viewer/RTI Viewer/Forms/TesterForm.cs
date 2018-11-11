using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT_Viewer.Framework;
using RT_Viewer.Forms;

namespace RT_Viewer.Forms
{
    public partial class TesterForm : Form
    {
        public TesterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// return instance of SocketHandler by selected RT radio button
        /// </summary>
        /// <returns>SocketHandler</returns>
        SocketHandler getSelectedRT()
        {

            if (RTViewerForm.isRTC1Presented == true)
            {
                return RTViewerForm.socketRT1;
            }
            else
            {
                return RTViewerForm.socketRT2;
            }
        }
        /// <summary>
        /// Inject a message to the RT with wrong magic number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void injectWrongMgcNum_button_Click(object sender, EventArgs e)
        {
            SocketHandler socketInstance = getSelectedRT();
            byte[] data = new byte[4];
            socketInstance.sendMsgToRT(data, (uint)SocketHandler.TypeOfTxMessage.WRONG_MAGIC_NUMBER_TYPE, socketInstance.device_id);
        }
        /// <summary>
        /// Inject a message to the RT with wrong opcode number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void injectWrongOpcode_button_Click(object sender, EventArgs e)
        {
            SocketHandler socketInstance = getSelectedRT();
            byte[] data = new byte[4];
            socketInstance.sendMsgToRT(data, (uint)SocketHandler.TypeOfTxMessage.WRONG_OPCODE_TYPE, socketInstance.device_id);
        }
        /// <summary>
        /// Inject a message to the RT with wrong CRC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void injectWrongCrc_button_Click(object sender, EventArgs e)
        {
            SocketHandler socketInstance = getSelectedRT();
            byte[] data = new byte[4];
            socketInstance.sendMsgToRT(data, (uint)SocketHandler.TypeOfTxMessage.WRONG_CHECKSUM_TYPE, socketInstance.device_id);
        }

    }
}
