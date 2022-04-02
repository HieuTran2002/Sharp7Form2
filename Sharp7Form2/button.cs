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
        private S7Driver driver;
        private bool lastValue = false;
        private bool stink = false;
        public button(S7Driver c, string name, string datatype, string area, int pos, int bit)
        {
            InitializeComponent();
            button1.Text = name;
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;



        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Left + (e.X - MouseDownLocation.X) > 0 && this.Right + (e.X - MouseDownLocation.X) < Parent.Width)
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
            if (stink)
            {
                try
                {
                    int result = driver.client.Write(!lastValue, mArea, mPos, mBit);
                    if (result == 0)
                    {
                        lastValue = !lastValue;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.TargetSite.ToString());
                }

            }
            else
            {
                try
                {
                    int result = driver.client.Write(true, mArea, mPos, mBit);
                    if (result == 0)
                    {
                        lastValue = true;
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.TargetSite.ToString());
                }

            }

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!stink)
            {
                try
                {
                    int result = driver.client.Write(false, mArea, mPos, mBit);
                    if (result == 0)
                    {
                        lastValue = !lastValue;
                    }
                    else
                    {
                        throw new Exception(driver.client.ErrorText(result));
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
        
        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            try
            {
                button1.Text = NameTextBox.Text;
                mArea = areaToolStripMenuItem.Text;
                mPos = Convert.ToInt16(PositionTextBox.Text);
                mBit = Convert.ToInt16(BitComboBox.Text);
                mDatatype = datatypeToolStripMenuItem.Text;
            }
            catch (Exception)
            {

            }
        }

        private void stinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stink)
            { 
                stinkToolStripMenuItem.Text = "Disable stink";
            }
            else
            {
                stinkToolStripMenuItem.Text = "Enable stink";
            }
            stink = !stink;
        }

        private void propertesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Area : {mArea} \nDatatype : {mDatatype} \nPosition: {mPos} \nBit: {mBit}");
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            NameTextBox.Text = button1.Text;
            AreaComboBox.Text = mArea;
            DatatypeComboBox.Text = "Bit";
            PositionTextBox.Text = mPos.ToString();
            BitComboBox.Text = mBit.ToString();
        }

        private void PositionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
