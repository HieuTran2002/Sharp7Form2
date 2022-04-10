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
using controlManager;

namespace Sharp7Form2
{
    public partial class ProgressBar : UserControl
    {
        #region Initialize variable
        private S7Driver driver;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;
        private bool editMode;
        private System.Windows.Forms.Timer timer1;
        private moveAndResize manager;
        #endregion

        public ProgressBar(S7Driver c, string name, string datatype, int max, int min, string area, int pos, int bit, bool currentEditMode)
        {
            InitializeComponent();
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;
            progressBar1.Maximum = max;
            progressBar1.Minimum = min;
            editMode = currentEditMode;

            manager = new moveAndResize();
            manager.Initialize(progressBar1, this, editMode);

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

        #region UI event handler
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = Convert.ToInt32(driver.client.read(mDatatype, mArea, mPos));
            }
            catch (Exception)
            {
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

        #endregion

        #region Method

        public void edit(bool enableEdit)
        {
            editMode = enableEdit;
            manager.changeEditMode(enableEdit);
        }
        #endregion

        private void ProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (editMode && e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
