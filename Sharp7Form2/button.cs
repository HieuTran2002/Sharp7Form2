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
    public partial class button : UserControl
    {
        #region Initialze variables
        internal bool editMode;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;
        private bool lastValue = false;
        private bool stink = false;

        private S7Driver driver;

        moveAndResize manager;
        public delegate void errorHandler(string error);
        public errorHandler ErrorHandler;

        #endregion

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="c"></param>
        /// <param name="name"></param>
        /// <param name="datatype"></param>
        /// <param name="area"></param>
        /// <param name="pos"></param>
        /// <param name="bit"></param>
        /// <param name="currentEditMode"></param>
        public button(S7Driver c, string name, string datatype, string area, int pos, int bit, bool currentEditMode)
        {
            InitializeComponent();
            button1.Text = name;
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;
            editMode = currentEditMode;

            manager = new moveAndResize();
            manager.Initialize(button1, this, editMode);

            

        }

        #region UI event handler
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
        
        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            try
            {
                button1.Text = NameTextBox.Text;
                mArea = AreaComboBox.Text;
                mPos = Convert.ToInt16(PositionTextBox.Text);
                mBit = Convert.ToInt16(BitComboBox.Text);
                mDatatype = DatatypeComboBox.Text;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && editMode)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }

            if (!editMode && e.Button == MouseButtons.Left) 
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
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        driver.client.Write(true, mArea, mPos, mBit);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!stink && !editMode && e.Button == MouseButtons.Left)
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

        #endregion

        #region Method


        public void edit(bool enableEdit)
        {
            editMode = enableEdit;
            manager.changeEditMode(enableEdit);
        }

        #endregion

    }
}
