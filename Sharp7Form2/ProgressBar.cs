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

        private bool isResizing;
        private bool isMoving;
        internal bool editable;
        private Size ControlStartSize;
        private Point MouseDownLocation;
        private System.Windows.Forms.Timer timer1;

        internal static bool MouseIsInLeftEdge { get; set; }
        internal static bool MouseIsInRightEdge { get; set; }
        internal static bool MouseIsInTopEdge { get; set; }
        internal static bool MouseIsInBottomEdge { get; set; }
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
            editable = currentEditMode;

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

                throw;
            }
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
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
                this.progressBar1.Capture = true;
            }


        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
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

        private void progressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            stopDragOrResizing();
        }
        #endregion

        #region Method
        private void updateMouseCursor()
        {
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
            progressBar1.Capture = false;
            updateMouseCursor();
        }

        private void updateMouseEdgeProperties(Point mouseLocationInControl)
        {
            MouseIsInLeftEdge = Math.Abs(mouseLocationInControl.X) <= 2;
            MouseIsInRightEdge = Math.Abs(mouseLocationInControl.X - Width) <= 2;
            MouseIsInTopEdge = Math.Abs(mouseLocationInControl.Y) <= 2;
            MouseIsInBottomEdge = Math.Abs(mouseLocationInControl.Y - Height) <= 2;
        }

        public void edit(bool enableEdit)
        {
            editable = enableEdit;
        }
        #endregion

    }
}
