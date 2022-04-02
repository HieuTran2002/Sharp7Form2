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
    public partial class configDialog : Form
    {
        public string name;
        public string dataType;
        public string area;
        public int pos;
        public int bit;
        public int max;
        public int min;
        private bool ReturnValueRange;
        
        public configDialog(bool isReturnValueRange)
        {
            InitializeComponent();

            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            ReturnValueRange = isReturnValueRange;
            if (!ReturnValueRange)
            {
                label4.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("closing");
                name = textBox1.Text;
                dataType = comboBox1.Text;
                area = comboBox2.Text;
                pos = Convert.ToInt16(textBox2.Text);
                bit = Convert.ToInt16(comboBox3.Text);
                if (ReturnValueRange)
                {
                    max = Convert.ToInt16(textBox3.Text);
                    min = Convert.ToInt16(textBox4.Text);
                }
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
