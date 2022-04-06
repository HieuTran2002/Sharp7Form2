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
    public partial class panel : UserControl
    {
        #region Initialize variables 
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

        internal static bool MouseIsInLeftEdge { get; set; }
        internal static bool MouseIsInRightEdge { get; set; }
        internal static bool MouseIsInTopEdge { get; set; }
        internal static bool MouseIsInBottomEdge { get; set; }

        private System.Windows.Forms.Timer timer1;
        #endregion

        /// <summary>
        /// ContrucTor
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
        public panel(S7Driver c, string name, string datatype, int max, int min, string area, int pos, int bit, bool currentEditMode)
        {
            InitializeComponent();
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;
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
                bool result = driver.client.read(mArea, mPos, mBit);
                if (result)
                {
                    button1.BackColor = ColorTranslator.FromHtml("#0A7029");
                }
                else
                {
                    button1.BackColor = ColorTranslator.FromHtml("#DB1F48");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
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
                this.button1.Capture = true;
            }

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
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

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            stopDragOrResizing();
        }
        #endregion

        #region Method
        private void updateMouseEdgeProperties(Point mouseLocationInControl)
        {
            MouseIsInLeftEdge = Math.Abs(mouseLocationInControl.X) <= 2;
            MouseIsInRightEdge = Math.Abs(mouseLocationInControl.X - Width) <= 2;
            MouseIsInTopEdge = Math.Abs(mouseLocationInControl.Y) <= 2;
            MouseIsInBottomEdge = Math.Abs(mouseLocationInControl.Y - Height) <= 2;
        }

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
            button1.Capture = false;
            updateMouseCursor();
        }

        public void edit(bool enableEdit)
        {
            editable = enableEdit;
        }
        #endregion
    }
}
