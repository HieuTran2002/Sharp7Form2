using System.Drawing;
using System.Windows.Forms;
using Sharp7;

namespace Sharp7Form2
{
    public partial class HTrackBar : UserControl
    {
        private Point MouseDownLocation;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;
        private Client mClient;
        

        public HTrackBar(Client c, string name, string datatype, int maxRange, string area, int pos, int bit)
        {
            InitializeComponent();
            label1.Text = name;
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            mClient = c;

            trackBar1.Maximum = maxRange;
            


        }

        public void showEdit()
        {
            this.BackColor = Color.White;
        }
        public void closeEdit()
        {
            this.BackColor = ColorTranslator.FromHtml("#90ADC6");
        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void TrackBar_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void trackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                mClient.Write(trackBar1.Value.ToString(), mDatatype, mArea, mPos, mBit);
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw ex;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            } 
        }

   }
}
