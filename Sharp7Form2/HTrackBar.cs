using System;
using System.Drawing;
using System.Windows.Forms;
using Sharp7;

namespace Sharp7Form2
{
    public partial class HTrackBar : UserControl
    {
        internal bool editable;
        private string mDatatype;
        private string mArea;
        private Point MouseDownLocation;
        private int mPos;
        private int mBit;
        private S7Driver driver;

        //private bool isResize;
        //private bool isMove;
        private bool isResizing;
        private bool isMoving;
        private Size ControlStartSize;

        internal static bool MouseIsInLeftEdge { get; set; }
        internal static bool MouseIsInRightEdge { get; set; }
        internal static bool MouseIsInTopEdge { get; set; }
        internal static bool MouseIsInBottomEdge { get; set; }


        internal enum moveOrResize
        {
            Move,
            Resize,
            MoveAndResize
        }
        internal static moveOrResize workMode { get; set; }


        public HTrackBar(S7Driver c, string name, string datatype, int max, int min, string area, int pos, int bit, bool currentEditMode)
        {
            InitializeComponent();
            //label1.Text = name;
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;
            trackBar1.Maximum = max;
            trackBar1.Minimum = min;
            editable = currentEditMode;
            workMode = moveOrResize.MoveAndResize;
        }

        public void edit(bool enableEdit)
        {
            editable = enableEdit;
        }


        private void trackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                int writeResult = driver.client.Write(trackBar1.Value.ToString(), mDatatype, mArea, mPos, mBit);
                if (writeResult != 0)
                {
                    throw new Exception(driver.client.ErrorText(writeResult));
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
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
            trackBar1.Minimum =  Convert.ToInt16(minTextBox.Text);
 
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

        
        private void minTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }

            if (editable)
            {

                if (isMoving || isResizing)
                {
                    return;
                }
                if (MouseIsInRightEdge || MouseIsInLeftEdge || MouseIsInTopEdge || MouseIsInBottomEdge)
                {
                    isResizing = true;
                    ControlStartSize = Size;
                }
                else
                {
                    isMoving = true;
                    Cursor = Cursors.Hand;
                }
                MouseDownLocation = new Point(e.X, e.Y);
                this.trackBar1.Capture = true;
            }

        }

        private void trackBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (editable)
            {

                if (!isResizing && !isMoving)
                {
                    updateMouseEdgeProperties(new Point(e.X, e.Y));
                    updateMouseCursor();
                }

                if (isResizing)
                {
                    if (MouseIsInLeftEdge)
                    {
                        if (MouseIsInTopEdge)
                        {
                            Width -= (e.X - MouseDownLocation.X);
                            Left += (e.X - MouseDownLocation.X);
                            Height -= (e.Y - MouseDownLocation.Y);
                            Top += (e.Y - MouseDownLocation.Y);
                        }
                        else if (MouseIsInBottomEdge)
                        {
                            Width -= (e.X - MouseDownLocation.X);
                            Left += (e.X - MouseDownLocation.X);
                            Height = (e.Y - MouseDownLocation.Y) + ControlStartSize.Height;
                        }
                        else
                        {
                            Width -= (e.X - MouseDownLocation.X);
                            Left += (e.X - MouseDownLocation.X);
                        }
                    }
                    else if (MouseIsInRightEdge)
                    {
                        if (MouseIsInTopEdge)
                        {
                            Width = (e.X - MouseDownLocation.X) + ControlStartSize.Width;
                            Height -= (e.Y - MouseDownLocation.Y);
                            Top += (e.Y - MouseDownLocation.Y);

                        }
                        else if (MouseIsInBottomEdge)
                        {
                            Width = (e.X - MouseDownLocation.X) + ControlStartSize.Width;
                            Height = (e.Y - MouseDownLocation.Y) + ControlStartSize.Height;
                        }
                        else
                        {
                            Width = (e.X - MouseDownLocation.X) + ControlStartSize.Width;
                        }
                    }
                    else if (MouseIsInTopEdge)
                    {
                        Height -= (e.Y - MouseDownLocation.Y);
                        Top += (e.Y - MouseDownLocation.Y);
                    }
                    else if (MouseIsInBottomEdge)
                    {
                        Height = (e.Y - MouseDownLocation.Y) + ControlStartSize.Height;
                    }
                    else
                    {
                        stopDragOrResizing();
                    }
                }
                else if (isMoving)
                {
                    if (this.Left + (e.X - MouseDownLocation.X) > 0 && this.Right + (e.X - MouseDownLocation.X) < Parent.Width)
                    {
                        this.Left = e.X + this.Left - MouseDownLocation.X;
                    }
                    if (this.Top + (e.Y - MouseDownLocation.Y) > 0 && this.Bottom + (e.Y - MouseDownLocation.Y) < Parent.Height)
                    {
                        this.Top = e.Y + this.Top - MouseDownLocation.Y;
                    }
                }
            }
            else
            {
                Cursor = Cursors.Default;
            }

        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            stopDragOrResizing();

        }

        private void updateMouseEdgeProperties(Point mouseLocationInControl)
        {
            if (workMode == moveOrResize.Move)
            {
                return;
            }
            MouseIsInLeftEdge = Math.Abs(mouseLocationInControl.X) <= 2;
            MouseIsInRightEdge = Math.Abs(mouseLocationInControl.X - Width) <= 2;
            MouseIsInTopEdge = Math.Abs(mouseLocationInControl.Y) <= 2;
            MouseIsInBottomEdge = Math.Abs(mouseLocationInControl.Y - Height) <= 2;
        }

        private void updateMouseCursor()
        {
            if (workMode == moveOrResize.Move)
            {
                return;
            }
            if (MouseIsInLeftEdge)
            {
                if (MouseIsInTopEdge)
                {
                    Cursor = Cursors.SizeNWSE;
                }
                else if (MouseIsInBottomEdge)
                {
                    Cursor = Cursors.SizeNESW;
                }
                else
                {
                    Cursor = Cursors.SizeWE;
                }
            }
            else if (MouseIsInRightEdge)
            {
                if (MouseIsInTopEdge)
                {
                    Cursor = Cursors.SizeNESW;
                }
                else if (MouseIsInBottomEdge)
                {
                    Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    Cursor = Cursors.SizeWE;
                }
            }
            else if (MouseIsInTopEdge || MouseIsInBottomEdge)
            {
                Cursor = Cursors.SizeNS;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void stopDragOrResizing()
        {
            isResizing = false;
            isMoving = false;
            trackBar1.Capture = false;
            updateMouseCursor();
        }

    }
}
