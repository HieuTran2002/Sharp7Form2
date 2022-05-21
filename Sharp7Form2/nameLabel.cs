using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlManager;


namespace Sharp7Form2
{
    public partial class nameLabel : UserControl
    {
        #region Properties 
        private moveAndResize manager;
        private bool editMode = false;
        #endregion

        #region Contructor
        public nameLabel()
        {
            InitializeComponent();
            manager = new moveAndResize();
            manager.Initialize(label1, this, editMode);
        }
        #endregion

        #region UI event handler
        public void edit(bool enableEdit)
        {
            editMode = enableEdit;
            manager.changeEditMode(enableEdit);
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
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

        private void fontStyleComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(fontStyleComboBox1.Text, label1.Font.Size);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            label1.Text = nameTextBox.Text;
        }

        private void colorToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label1.ForeColor = ColorTranslator.FromHtml(colorTextBox.Text);
            }
            catch (Exception)
            {
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void fontSizeTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Font = new Font(label1.Font.FontFamily, Convert.ToInt16( fontSizeTextBox1.Text )) ;
            }
            catch (Exception)
            {
            }
        }

        #endregion
    }
}
