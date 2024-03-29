﻿using System;
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
    public partial class connectDialog : Form
    {
        #region Initialize variables
        Sharp7Client Client = new Sharp7Client();
        public string ip;
        public int rank;
        public int slot;
        private Point startPoint;
        #endregion

        #region Contructor
        public connectDialog(Point _startPoint)
        {
            InitializeComponent();
            IpAdressTB.Text = GetIPAddress();
            //IpAdressTB.Text = "192.168.0.241";
            Rank.SelectedIndex = 0;
            Slot.SelectedIndex = 1;
            startPoint = _startPoint;
            CnnBTN.DialogResult = DialogResult.OK;
            CancelBTN.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region UI event handling
        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CnnBTN_Click(object sender, EventArgs e)
        {
            ip = IpAdressTB.Text;
            rank = Convert.ToInt16( Rank.Text);
            slot = Convert.ToInt16(Slot.Text);
            this.Close();
        }

        public static string GetIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            string result = string.Empty;
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    result = ip.ToString();
                }
            }
            return result;
        }

        private void connectDialog_Load(object sender, EventArgs e)
        {
            SetDesktopLocation(startPoint.X, startPoint.Y);
        }
        #endregion
    }
}
