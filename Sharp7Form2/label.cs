using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharp7;

namespace Sharp7Form2
{
    public partial class label : UserControl
    {
        private byte[] buffer;
        private Point MouseDownLocation;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;
        private Client mClient;

        private System.Windows.Forms.Timer timer1;
        public label(Client c, string name, string datatype, string area, int pos, int bit)
        {
            InitializeComponent();
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            mClient = c;
            timer1 = new System.Windows.Forms.Timer();

            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;

            Thread t = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    timer1.Start();
                });
            });
            t.IsBackground = true;
            t.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = read();
        }
        private string read()
        {
            int readResult = 0;
            switch (mDatatype)
            {
                case "INT":
                    buffer = new byte[2];
                    break;
                case "WORD":
                    buffer = new byte[2];
                    break;
                case "DWORD":
                    buffer = new byte[4];
                    break;
                case "REAL":
                    buffer = new byte[4];
                    break;
            }
            //buffer = new byte[100];

            switch (mArea)
            {
                case "Q":
                    readResult = mClient.client.ABRead(mPos, buffer.Length, buffer);
                    break;
                case "I":
                    readResult = mClient.client.EBRead(0, buffer.Length, buffer);
                    break;
                case "M":
                    readResult = mClient.client.MBRead(0, buffer.Length, buffer);
                    break;
            }
            if (readResult == 0)
            {
                switch (mDatatype)
                {
                    case "INT":
                        return S7.GetIntAt(buffer, 0).ToString();
                    case "REAL":
                        return S7.GetRealAt(buffer, 0).ToString();
                    case "WORD":
                        return S7.GetWordAt(buffer, 0).ToString();
                    case "DWORD":
                        return S7.GetDWordAt(buffer, 0).ToString();
                    default:
                        return "null";
                        
                }
            }
            else
            {
                return mClient.client.ErrorText(readResult);

            }

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Left + (e.X - MouseDownLocation.X) > 0 && this.Right + (e.X - MouseDownLocation.X) < Parent.Width)
                {
                    this.Left = e.X + this.Left - MouseDownLocation.X;
                }
                if (this.Top + (e.Y - MouseDownLocation.Y) > 0 && this.Bottom + (e.Y - MouseDownLocation.Y) < Parent.Height)
                {
                    this.Top = e.Y + this.Top - MouseDownLocation.Y;
                }
            }

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
