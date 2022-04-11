using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlManager;

namespace Sharp7Form2
{
    public partial class VTrackBar : UserControl
    {
        #region Initialize variables
        private S7Driver driver;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;
        
        internal bool editMode;
        private moveAndResize manager;

        #endregion

        #region Contructor
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="c"></param>
        /// <param name="name"></param>
        /// <param name="datatype"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="area"></param>
        /// <param name="pos"></param>
        /// <param name="bit"></param>
        /// <param name="currentEditMode"></param>
        public VTrackBar(S7Driver c, string name, string datatype, int max, int min, string area, int pos, int bit, bool currentEditMode)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;
            trackBar1.Maximum = max;
            trackBar1.Minimum = min;
            editMode = currentEditMode;

            manager = new moveAndResize();
            manager.Initialize(trackBar1, this, editMode);
        }
        #endregion

        #region UI event handler
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (!editMode)
            {
                try
                {
                    int writeResult = driver.client.Write(trackBar1.Value.ToString(), mDatatype, mArea, mPos, mBit);
                    if (writeResult != 0)
                    {
                        throw new Exception((driver.client.ErrorText(writeResult)));
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void propertesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Area : {mArea} \nDatatype : {mDatatype} \nPosition: {mPos} \nBit: {mBit} \nMax : {trackBar1.Maximum} \nMin : {trackBar1.Minimum}");
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void minTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maxRangeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PositionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            //label1.Text = NameTextBox.Text;
            mPos = Convert.ToInt16(PositionTextBox.Text);
            mArea = AreaComboBox.Text;
            mBit = Convert.ToInt16(BitComboBox.Text);
            mDatatype = DatatypeComboBox.Text;
            trackBar1.Maximum = Convert.ToInt16(maxTextBox.Text);
            trackBar1.Minimum = Convert.ToInt16(minTextBox.Text);
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            //NameTextBox.Text = label1.Text;
            AreaComboBox.Text = mArea;
            DatatypeComboBox.Text = mDatatype;
            PositionTextBox.Text = mPos.ToString();
            BitComboBox.Text = mBit.ToString();
            maxTextBox.Text = trackBar1.Maximum.ToString();
            minTextBox.Text = trackBar1.Minimum.ToString();
        }
        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && editMode)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        #endregion 

        #region method

        /// <summary>
        /// turn on/off edit mode
        /// </summary>
        /// <param name="enableEdit">Enable or disable</param>
        public void edit(bool enableEdit)
        {
            editMode = enableEdit;
            manager.changeEditMode(enableEdit);
        }

        #endregion

    }
}