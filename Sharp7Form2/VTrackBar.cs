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
    public partial class VTrackBar : UserControl
    {
        internal bool editable = false;
        private Point MouseDownLocation;
        private string mDatatype;
        private string mArea;
        private int mPos;
        private int mBit;
        private S7Driver driver;

        private bool isResize;
        private bool isMove;
        private bool isResizing;
        private bool isMoving;
        private Size _currentControlStartSize;
        private Point _cursorStartPoint;
        private bool _moveIsInterNal;

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


        public VTrackBar(S7Driver c, string name, string datatype, int max, int min, string area, int pos, int bit)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //label1.Text = name;
            mDatatype = datatype;
            mArea = area;
            mPos = pos;
            mBit = bit;
            driver = c;
            trackBar1.Maximum = max;
            trackBar1.Minimum = min;
            workMode = moveOrResize.MoveAndResize;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int writeResult = driver.client.Write(trackBar1.Value.ToString(), mDatatype, mArea, mPos, mBit);
                if (writeResult != 0)
                {
                    throw new Exception((driver.client.ErrorText(writeResult)));
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //    {
            //        MouseDownLocation = e.Location;
            //    }
            //    else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //    {
            //        contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            //    }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    if (this.Left + (e.X - MouseDownLocation.X) > 0 && this.Right + (e.X - MouseDownLocation.X) < 1016)
            //    {
            //        this.Left = e.X + this.Left - MouseDownLocation.X;
            //    }
            //    if (this.Top + (e.Y - MouseDownLocation.Y) > 0 && this.Bottom + (e.Y - MouseDownLocation.Y) < 559)
            //    {
            //        this.Top = e.Y + this.Top - MouseDownLocation.Y;
            //    }
            //}
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
            trackBar1.Minimum = Convert.ToInt16(minTextBox.Text);
            trackBar1.Height = Convert.ToInt16(heightStripTextBox.Text);
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
            heightStripTextBox.Text = trackBar1.Height.ToString();
        }

        private void minTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    MouseDownLocation = e.Location;
            //}
            //else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            //}
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    if (this.Left + (e.X - MouseDownLocation.X) > 0 && this.Right + (e.X - MouseDownLocation.X) < 1016)
            //    {
            //        this.Left = e.X + this.Left - MouseDownLocation.X;
            //    }
            //    if (this.Top + (e.Y - MouseDownLocation.Y) > 0 && this.Bottom + (e.Y - MouseDownLocation.Y) < 559)
            //    {
            //        this.Top = e.Y + this.Top - MouseDownLocation.Y;
            //    }
            //}

        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateMouseEdgeProperties(Point mouseLocationInControl)
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
        private void UpdateMouseCursor()
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
        private void StopDragOrResizing()
        {
            isResizing = false;
            isMoving = false;
            Capture = false;
            UpdateMouseCursor();
        }

        private void VTrackBar_MouseMove(object sender, MouseEventArgs e)
        {
  
                if (!isResizing && !isMoving)
                {
                    UpdateMouseEdgeProperties(new Point(e.X, e.Y));
                    UpdateMouseCursor();
                }
                if (isResizing)
                {
                    if (MouseIsInLeftEdge)
                    {
                        if (MouseIsInTopEdge)
                        {
                            Width -= (e.X - _cursorStartPoint.X);
                            Left += (e.X - _cursorStartPoint.X);
                            Height -= (e.Y - _cursorStartPoint.Y);
                            Top += (e.Y - _cursorStartPoint.Y);
                        }
                        else if (MouseIsInBottomEdge)
                        {
                            Width -= (e.X - _cursorStartPoint.X);
                            Left += (e.X - _cursorStartPoint.X);
                            Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                        }
                        else
                        {
                            Width -= (e.X - _cursorStartPoint.X);
                            Left += (e.X - _cursorStartPoint.X);
                        }
                    }
                    else if (MouseIsInRightEdge)
                    {
                        if (MouseIsInTopEdge)
                        {
                            Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                            Height -= (e.Y - _cursorStartPoint.Y);
                            Top += (e.Y - _cursorStartPoint.Y);

                        }
                        else if (MouseIsInBottomEdge)
                        {
                            Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                            Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                        }
                        else
                        {
                            Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                        }
                    }
                    else if (MouseIsInTopEdge)
                    {
                        Height -= (e.Y - _cursorStartPoint.Y);
                        Top += (e.Y - _cursorStartPoint.Y);
                    }
                    else if (MouseIsInBottomEdge)
                    {
                        Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                    }
                    else
                    {
                        StopDragOrResizing();
                    }
                }
                else if (isMoving)
                {
                    _moveIsInterNal = !_moveIsInterNal;
                    if (!_moveIsInterNal)
                    {
                        int x = (e.X - _cursorStartPoint.X) + Left;
                        int y = (e.Y - _cursorStartPoint.Y) + Top;
                        Location = new Point(x, y);
                    }
                }
        }
        
        

        private void VTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (isMoving || isResizing)
            {
                return;
            }
            if (workMode != moveOrResize.Move &&
                (MouseIsInRightEdge || MouseIsInLeftEdge || MouseIsInTopEdge || MouseIsInBottomEdge))
            {
                isResizing = true;
                _currentControlStartSize = Size;
            }
            else if (workMode != moveOrResize.Resize)
            {
                isMoving = true;
                Cursor = Cursors.Hand;
            }
            _cursorStartPoint = new Point(e.X, e.Y);
            Capture = true;


        }

        private void VTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            StopDragOrResizing();
        }

        private void trackBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (editable)
            {

            if (!isResizing && !isMoving)
            {
                UpdateMouseEdgeProperties(new Point(e.X, e.Y));
                UpdateMouseCursor();
            }
            if (isResizing)
            {
                if (MouseIsInLeftEdge)
                {
                    if (MouseIsInTopEdge)
                    {
                        Width -= (e.X - _cursorStartPoint.X);
                        Left += (e.X - _cursorStartPoint.X);
                        Height -= (e.Y - _cursorStartPoint.Y);
                        Top += (e.Y - _cursorStartPoint.Y);
                    }
                    else if (MouseIsInBottomEdge)
                    {
                        Width -= (e.X - _cursorStartPoint.X);
                        Left += (e.X - _cursorStartPoint.X);
                        Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                    }
                    else
                    {
                        Width -= (e.X - _cursorStartPoint.X);
                        Left += (e.X - _cursorStartPoint.X);
                    }
                }
                else if (MouseIsInRightEdge)
                {
                    if (MouseIsInTopEdge)
                    {
                        Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                        Height -= (e.Y - _cursorStartPoint.Y);
                        Top += (e.Y - _cursorStartPoint.Y);

                    }
                    else if (MouseIsInBottomEdge)
                    {
                        Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                        Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                    }
                    else
                    {
                        Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                    }
                }
                else if (MouseIsInTopEdge)
                {
                    Height -= (e.Y - _cursorStartPoint.Y);
                    Top += (e.Y - _cursorStartPoint.Y);
                }
                else if (MouseIsInBottomEdge)
                {
                    Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                }
                else
                {
                    StopDragOrResizing();
                }
            }
            else if (isMoving)
            {
                _moveIsInterNal = !_moveIsInterNal;
                if (!_moveIsInterNal)
                {
                    int x = (e.X - _cursorStartPoint.X) + Left;
                    int y = (e.Y - _cursorStartPoint.Y) + Top;
                    Location = new Point(x, y);
                }
            }
            {
                UpdateMouseEdgeProperties(new Point(e.X, e.Y));
                UpdateMouseCursor();
            }
            if (isResizing)
            {
                if (MouseIsInLeftEdge)
                {
                    if (MouseIsInTopEdge)
                    {
                        trackBar1.Width -= (e.X - _cursorStartPoint.X);
                        trackBar1.Left += (e.X - _cursorStartPoint.X);
                        trackBar1.Height -= (e.Y - _cursorStartPoint.Y);
                        trackBar1.Top += (e.Y - _cursorStartPoint.Y);
                    }
                    else if (MouseIsInBottomEdge)
                    {
                        Width -= (e.X - _cursorStartPoint.X);
                        Left += (e.X - _cursorStartPoint.X);
                        Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                    }
                    else
                    {
                        Width -= (e.X - _cursorStartPoint.X);
                        Left += (e.X - _cursorStartPoint.X);
                    }
                }
                else if (MouseIsInRightEdge)
                {
                    if (MouseIsInTopEdge)
                    {
                        Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                        Height -= (e.Y - _cursorStartPoint.Y);
                        Top += (e.Y - _cursorStartPoint.Y);

                    }
                    else if (MouseIsInBottomEdge)
                    {
                        Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                        Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                    }
                    else
                    {
                        Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                    }
                }
                else if (MouseIsInTopEdge)
                {
                    Height -= (e.Y - _cursorStartPoint.Y);
                    Top += (e.Y - _cursorStartPoint.Y);
                }
                else if (MouseIsInBottomEdge)
                {
                    Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;
                }
                else
                {
                    StopDragOrResizing();
                }
            }
            else if (isMoving)
            {
                _moveIsInterNal = !_moveIsInterNal;
                if (!_moveIsInterNal)
                {
                    int x = (e.X - _cursorStartPoint.X) + Left;
                    int y = (e.Y - _cursorStartPoint.Y) + Top;
                    Location = new Point(x, y);
                }
            }

            }
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (editable)
            {

            if (isMoving || isResizing)
            {
                return;
            }
            if (workMode != moveOrResize.Move &&
                (MouseIsInRightEdge || MouseIsInLeftEdge || MouseIsInTopEdge || MouseIsInBottomEdge))
            {
                isResizing = true;
                _currentControlStartSize = Size;
            }
            else if (workMode != moveOrResize.Resize)
            {
                isMoving = true;
                Cursor = Cursors.Hand;
            }
            _cursorStartPoint = new Point(e.X, e.Y);
            Capture = true;
            }

        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {

            StopDragOrResizing();

        }

        public void edit(bool enableEdit)
        {
            editable = enableEdit;

        }
    }
}