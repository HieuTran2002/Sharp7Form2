using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharp7;

namespace Sharp7Form2
{
    public partial class Form1 : Form
    {
        #region Initialize variables
        internal bool editable = false;
        private bool connected = false;
        private S7Driver driver;
        private S7Client.S7CpuInfo cpu;

        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        public delegate void enableEdit(bool enable);
       enableEdit myDelegate;
        #endregion

        #region Contructor
        public Form1()
        {
            InitializeComponent();
            driver = new S7Driver();
            statusLabel = toolStripStatusLabel1;
        }
        #endregion

        #region UI event handler
        private void connectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int result;
            if (connected)
            {
                result =  driver.client.Disconnect();
                if (result == 0)
                {
                    connectToolStripMenuItem1.Text = "Connect";
                    toolStripStatusLabel1.Text = "Disconnected";
                    connected = false;

                }
            }
            else
            {
                connectDialog connectDialog = new connectDialog(Cursor.Position);
                connectDialog.Show();
                connectDialog.FormClosed += new FormClosedEventHandler(CnnDialogClosed);
            } 
        }

        private async void CnnDialogClosed(object sender, FormClosedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Connecting pls wait.....";
            connectDialog cnnDialog = sender as connectDialog;
            int cnnResult = await driver.client.AsyncConnectTo(cnnDialog.ip, cnnDialog.rank, cnnDialog.slot);
            if (cnnResult == 0)
            {
                connected = true;
                connectToolStripMenuItem1.Text = "Disconnect";
                toolStripStatusLabel1.Text = "Connected";
                driver.client.GetCpuInfo(ref cpu);
            }
            else
            {
                toolStripStatusLabel1.Text = driver.client.ErrorText(cnnResult);
            }
        }

        private void enableEditModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editable = !editable;
            if (editable)
            {
                enableEditModeToolStripMenuItem.Text = "Disable edit mode";
            }
            if (!editable)
            {
                enableEditModeToolStripMenuItem.Text = "Enable edit mode";
            }
            if (myDelegate != null)
            {
                myDelegate.Invoke(editable);
            }
        }

        private void horizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(Cursor.Position, true);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_Htrackbar);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(Cursor.Position, true);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_Vtrackbar);
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(Cursor.Position, false);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_button);
        }

        private void labelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(Cursor.Position, false);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_label);
        }

        private void processBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(Cursor.Position, true);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_ProcessBar);
        }

        private void lEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(Cursor.Position, false);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_Panel);
        }

        private void configDialogClosed_ProcessBar(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult ==  DialogResult.OK)
            {
                ProgressBar processBar = new ProgressBar(driver, config.name, config.dataType,config.max, config.min,config.area, config.pos, config.bit, editable);
                panel1.Controls.Add(processBar);
                myDelegate += new enableEdit(processBar.edit);
            }
        }

        private void configDialogClosed_button(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult ==  DialogResult.OK)
            {
                button btn = new button(driver, config.name, config.dataType, config.area, config.pos, config.bit, editable);
                panel1.Controls.Add(btn);
                myDelegate += new enableEdit(btn.edit);
                
            }
        }

        private void configDialogClosed_label(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult ==  DialogResult.OK)
            {
                label lb = new label(driver, config.name, config.dataType, config.area, config.pos, config.bit, editable);
                panel1.Controls.Add(lb);
                myDelegate += new enableEdit(lb.edit);
            }

        }

        private void configDialogClosed_Htrackbar(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult == DialogResult.OK)
            {
                HTrackBar trb = new HTrackBar(driver, config.name, config.dataType, config.max, config.min, config.area, config.pos, config.bit, editable);
                panel1.Controls.Add(trb);
                myDelegate += new enableEdit(trb.edit);
            }
        }

        private void configDialogClosed_Vtrackbar(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            
            if (config.DialogResult == DialogResult.OK)
            {
                VTrackBar trb = new VTrackBar(driver, config.name, config.dataType, config.max, config.min, config.area, config.pos, config.bit, editable);
                panel1.Controls.Add(trb);
                myDelegate += new enableEdit(trb.edit);
            }
        }

        private void configDialogClosed_Panel(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult == DialogResult.OK)
            {
                panel pn = new panel(driver, config.name, config.dataType, config.max, config.min, config.area, config.pos, config.bit, editable);
                panel1.Controls.Add(pn);
                myDelegate += new enableEdit(pn.edit);
            }

        }
        #endregion

        private void labelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nameLabel nameLabel = new nameLabel();
            panel1.Controls.Add(nameLabel);
            myDelegate += new enableEdit(nameLabel.edit);

        }

    }
}
