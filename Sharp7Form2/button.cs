using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp7Form2
{
    public partial class button : UserControl
    {
        private Point MouseDownLocation;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;
        private Client mClient;
        public button(Client c, string name, string datatype, string area, int pos, int bit)
        {
            InitializeComponent();
            button1.Text = name;
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            mClient = c;



        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Left + (e.X - MouseDownLocation.X) > 0 && this.Right + (e.X - MouseDownLocation.X) < 1016)
                {
                    this.Left = e.X + this.Left - MouseDownLocation.X;
                }
                if (this.Top + (e.Y - MouseDownLocation.Y) > 0 && this.Bottom + (e.Y - MouseDownLocation.Y) < 559)
                {
                    this.Top = e.Y + this.Top - MouseDownLocation.Y;

                }
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                mClient.Write(true, mArea, mPos, mBit);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.TargetSite.ToString());
            }

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                mClient.Write(false, mArea, mPos, mBit);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.TargetSite.ToString());
            }

        }

    }
}
