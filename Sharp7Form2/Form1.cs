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
        private Client client;
        private S7Client.S7CpuInfo cpu;
        public Form1()
        {
            InitializeComponent();
            client = new Client();
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
                //client.Disconnect();
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
            int cnnResult = await client.AsyncConnectTo(cnnDialog.ip, cnnDialog.rank, cnnDialog.slot);
            if (cnnResult == 0)
            {
                connected = true;
                cnnDisBtn.Text = "Disconnect";
                toolStripStatusLabel1.Text = "Connected";

                client.client.GetCpuInfo(ref cpu);

                label3.Text = cpu.ModuleName;
                label4.Text = cpu.SerialNumber;
                label5.Text = cpu.ASName;
            }
            else
            {
                toolStripStatusLabel1.Text = client.client.ErrorText(cnnResult);
            }
        }


        private void enableEditModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editable = !editable;
        }

        private void horizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog();
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_trackbar);
        }

        private void configDialogClosed_trackbar(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            HTrackBar trb = new HTrackBar(client, config.name, config.dataType, config.maxRange, config.area, config.pos, config.bit);
            panel1.Controls.Add(trb);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog();
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_button);


        }

        private void configDialogClosed_button(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            button btn = new button(client, config.name, config.dataType, config.area, config.pos, config.bit);
            panel1.Controls.Add(btn);
        }

        private void labelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog configForm = new configDialog();
            configForm.Show();
            configForm.FormClosed += new FormClosedEventHandler(configDialogClosed_label);

        }
        private void configDialogClosed_label(object sender, FormClosedEventArgs e)
        {
            configDialog config = sender as configDialog;
            label lb = new label(client, config.name, config.dataType, config.area, config.pos, config.bit);
            panel1.Controls.Add(lb);

        }
    }
}
