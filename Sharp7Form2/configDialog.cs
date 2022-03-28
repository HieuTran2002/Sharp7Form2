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
        public configDialog()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            textBox2.Text = "60";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            dataType = comboBox1.Text;
            area = comboBox2.Text;
            pos = Convert.ToInt16(textBox2.Text);
            bit = Convert.ToInt16(comboBox3.Text);
            this.Close();
        }
    }
}
