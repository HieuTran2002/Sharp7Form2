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
using controlManager;
using System.Drawing.Text;

namespace Sharp7Form2
{
    public partial class label : UserControl
    {
        #region Initialize variables
        private S7Driver driver;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;

        internal bool editMode;
        private moveAndResize manager;


        private System.Windows.Forms.Timer timer1;
        #endregion

        #region Contructor
        public label(S7Driver c, string name, string datatype, string area, int pos, int bit, bool currentEditMode)
        {
            InitializeComponent();
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;
            editMode = currentEditMode;

            manager = new moveAndResize();
            manager.Initialize(label1, this, editMode, moveAndResize.moveOrResize.Move);

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
        #endregion

        #region UI event handler
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = driver.client.read(mDatatype, mArea, mPos);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void PositionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void propertesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Area : {mArea} \nDatatype : {mDatatype} \nPosition: {mPos} \nBit: {mBit}");
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            mPos = Convert.ToInt16(PositionTextBox.Text);
            mArea = AreaComboBox.Text;
            mBit = Convert.ToInt16(BitComboBox.Text);
            mDatatype = DatatypeComboBox.Text;
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            AreaComboBox.Text = mArea;
            DatatypeComboBox.Text = mDatatype;
            PositionTextBox.Text = mPos.ToString();
            BitComboBox.Text = mBit.ToString();
            getFont();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && editMode)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);

            }
        }

        #endregion

        #region Method

        public void edit(bool enableEdit)
        {
            editMode = enableEdit;
            manager.changeEditMode(enableEdit);
        }
        private void getFont()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            try
            {
                foreach (FontFamily font in fonts.Families)
                {
                    fontStyleComboBox1.Items.Add(font.Name);
                }
            }
            catch
            {

            }
        }

        #endregion

        private void fontStyleComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(fontStyleComboBox1.Text, label1.Font.Size);
        }

        private void fontSizeTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fontSizeTextBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                label1.Font = new Font(label1.Font.FontFamily, Convert.ToInt16(fontSizeTextBox1.Text)) ;
            }
            catch (Exception)
            {
            }
        }

        private void backgroundTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label1.BackColor = ColorTranslator.FromHtml(backgroundTextBox1.Text);
            }
            catch (Exception)
            {
            }
        }

        private void foreColorTextBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                label1.ForeColor = ColorTranslator.FromHtml(foreColorTextBox1.Text);
            }
            catch (Exception)
            {
            }
        }
    }
}
