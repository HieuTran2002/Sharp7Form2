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
    public partial class ProgressBar : UserControl
    {
        private Point MouseDownLocation;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;
        private S7Driver driver;

        public ProgressBar(S7Driver c, string name, string datatype, int max, int min, string area, int pos, int bit)
        {
            InitializeComponent();
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;
            progressBar1.Maximum = max;
            progressBar1.Minimum = min;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
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

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }


        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
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

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            mPos = Convert.ToInt16(PositionTextBox.Text);
            mArea = AreaComboBox.Text;
            mBit = Convert.ToInt16(BitComboBox.Text);
            mDatatype = DatatypeComboBox.Text;
            progressBar1.Maximum = Convert.ToInt16(maxTextBox.Text);
            progressBar1.Minimum = Convert.ToInt16(minTextBox.Text);
            progressBar1.Width = Convert.ToInt16(widthTextBox.Text);
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            AreaComboBox.Text = mArea;
            DatatypeComboBox.Text = mDatatype;
            PositionTextBox.Text = mPos.ToString();
            BitComboBox.Text = mBit.ToString();
            maxTextBox.Text = progressBar1.Maximum.ToString();
            minTextBox.Text = progressBar1.Minimum.ToString();
            widthTextBox.Text = progressBar1.Width.ToString();
        }
    }
}
