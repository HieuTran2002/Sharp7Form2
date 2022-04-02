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
        private bool editable = false;
        private bool connected = false;
        private S7Driver driver;
        private S7Client.S7CpuInfo cpu;

        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        public Form1()
        {
            InitializeComponent();
            driver = new S7Driver();
            statusLabel = toolStripStatusLabel1;
        } 

        /// <summary>
        /// ConnBTN clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                cnnDisBtn.Text = "Connect";
                toolStripStatusLabel1.Text = "Disconnected";
            }
            else
            {
                connectDialog connectDialog = new connectDialog();
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
                cnnDisBtn.Text = "Disconnect";
                toolStripStatusLabel1.Text = "Connected";
                driver.client.GetCpuInfo(ref cpu);
                label3.Text = cpu.ModuleName;
                label4.Text = cpu.SerialNumber;
                label5.Text = cpu.ASName;
            }
            else
            {
                toolStripStatusLabel1.Text = driver.client.ErrorText(cnnResult);
            }
        }


        private void enableEditModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editable = !editable;
        }

        private void horizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(true);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_Htrackbar);
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(true);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_Vtrackbar);
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(false);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_button);
        }

        private void labelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog(false);
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_label);
        }

        private void configDialogClosed_button(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult ==  DialogResult.OK)
            {
                button btn = new button(driver, config.name, config.dataType, config.area, config.pos, config.bit);
                panel1.Controls.Add(btn);
            }
        }

        private void configDialogClosed_label(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult ==  DialogResult.OK)
            {
                label lb = new label(driver, config.name, config.dataType, config.area, config.pos, config.bit);
                panel1.Controls.Add(lb);
            }

        }
        private void configDialogClosed_Htrackbar(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult == DialogResult.OK)
            {
                HTrackBar trb = new HTrackBar(driver, config.name, config.dataType, config.max, config.min, config.area, config.pos, config.bit);
                panel1.Controls.Add(trb);
            }
        }
        private void configDialogClosed_Vtrackbar(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            if (config.DialogResult == DialogResult.OK)
            {
                VTrackBar trb = new VTrackBar(driver, config.name, config.dataType, config.max, config.min, config.area, config.pos, config.bit);
                panel1.Controls.Add(trb);
            }
        }

    }
}
