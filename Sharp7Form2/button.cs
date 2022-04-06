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
    public partial class button : UserControl
    {
        #region Initialze variables
        internal bool editable;
        private string mDatatype;
        private Point MouseDownLocation;
        private string mArea;
        private int mPos;
        private int mBit;
        private S7Driver driver;

        //private bool isResize;
        //private bool isMove;
        private bool isResizing;
        private bool isMoving;
        private Size ControlStartSize;

        private bool lastValue = false;
        private bool stink = false;

        internal static bool MouseIsInLeftEdge { get; set; }
        internal static bool MouseIsInRightEdge { get; set; }
        internal static bool MouseIsInTopEdge { get; set; }
        internal static bool MouseIsInBottomEdge { get; set; }

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
            editable = currentEditMode;



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
            else
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
                        MessageBox.Show(ex.TargetSite.ToString());
                    }
                }
                else
                {
                    try
                    {
                        int result = driver.client.Write(true, mArea, mPos, mBit);
                        if (result == 0)
                        {
                            lastValue = true;
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.TargetSite.ToString());
                    }
                }
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (editable)
            {
                stopDragOrResizing();

            }
            if (!stink && !editable)
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

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if(editable)
            {

                if (!isResizing && !isMoving)
                {
                    updateMouseEdgeProperties(new Point(e.X, e.Y));
                    updateMouseCursor();
                }

                else if(isResizing)
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
            //this.Cursor = Cursors.Default;
        }

        public void edit(bool enableEdit)
        {
            editable = enableEdit;
        }

        #endregion

    }
}
