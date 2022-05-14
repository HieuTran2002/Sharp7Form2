using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace controlManager
{
    public partial class moveAndResize
    {
        #region Initialize variables
        private bool isMoving;
        private  Point MouseDownLocation;
        private  bool isResizing;
        private  Size _currentControlStartSize;
        private  Control mContainer;

        internal  bool editMode;
        internal  bool MouseIsInLeftEdge { get; set; }
        internal  bool MouseIsInRightEdge { get; set; }
        internal  bool MouseIsInTopEdge { get; set; }
        internal  bool MouseIsInBottomEdge { get; set; }

        public enum moveOrResize
        {
            Move,
            Resize,
            moveAndResize
        }

        internal static moveOrResize workMode { get; set; }

        #endregion

        #region Contructor
        public void Initialize(Control control, Control container, bool currentEditMode, moveOrResize workmode = moveOrResize.moveAndResize)
        {
            isMoving = false;
            isResizing = false;
            workMode = workmode;
            MouseDownLocation = Point.Empty;
            MouseIsInLeftEdge = false;
            MouseIsInLeftEdge = false;
            MouseIsInRightEdge = false;
            MouseIsInTopEdge = false;
            MouseIsInBottomEdge = false;
            editMode = currentEditMode;
            mContainer = container;
            control.MouseDown += (sender, e) => startMovingOrResizing(control, e);
            control.MouseUp += (sender, e) => stopDragOrResizing(control);
            control.MouseMove += (sender, e) => moveControl(control, e);

        }

        private  void moveControl(Control control, MouseEventArgs e)
        {
            if (editMode)
            {
                if (!isResizing && !isMoving)
                {
                    updateMouseEdgeProperties(control, new Point(e.X, e.Y));
                    updateMouseCursor();
                }
                if (isResizing)
                {
                    if (MouseIsInLeftEdge)
                    {
                        if (MouseIsInTopEdge)
                        {
                            mContainer.Width -= (e.X - MouseDownLocation.X);
                            mContainer.Left += (e.X - MouseDownLocation.X);
                            mContainer.Height -= (e.Y - MouseDownLocation.Y);
                            mContainer.Top += (e.Y - MouseDownLocation.Y);
                        }
                        else if (MouseIsInBottomEdge)
                        {
                            mContainer.Width -= (e.X - MouseDownLocation.X);
                            mContainer.Left += (e.X - MouseDownLocation.X);
                            mContainer.Height = (e.Y - MouseDownLocation.Y) + _currentControlStartSize.Height;
                        }
                        else
                        {
                            mContainer.Width -= (e.X - MouseDownLocation.X);
                            mContainer.Left += (e.X - MouseDownLocation.X);
                        }
                    }
                    else if (MouseIsInRightEdge)
                    {
                        if (MouseIsInTopEdge)
                        {
                            mContainer.Width = (e.X - MouseDownLocation.X) + _currentControlStartSize.Width;
                            mContainer.Height -= (e.Y - MouseDownLocation.Y);
                            mContainer.Top += (e.Y - MouseDownLocation.Y);

                        }
                        else if (MouseIsInBottomEdge)
                        {
                            mContainer.Width = (e.X - MouseDownLocation.X) + _currentControlStartSize.Width;
                            mContainer.Height = (e.Y - MouseDownLocation.Y) + _currentControlStartSize.Height;
                        }
                        else
                        {
                            mContainer.Width = (e.X - MouseDownLocation.X) + _currentControlStartSize.Width;
                        }
                    }
                    else if (MouseIsInTopEdge)
                    {
                        mContainer.Height -= (e.Y - MouseDownLocation.Y);
                        mContainer.Top += (e.Y - MouseDownLocation.Y);
                    }
                    else if (MouseIsInBottomEdge)
                    {
                        mContainer.Height = (e.Y - MouseDownLocation.Y) + _currentControlStartSize.Height;
                    }
                    else
                    {
                        stopDragOrResizing(control);
                    }
                }
                else if (isMoving)
                {
                    if (mContainer.Left + (e.X - MouseDownLocation.X) > 0 && mContainer.Right + (e.X - MouseDownLocation.X) < mContainer.Parent.Width)

                    {
                        mContainer.Left = e.X + mContainer.Left - MouseDownLocation.X;
                    }
                    if (mContainer.Top + (e.Y - MouseDownLocation.Y) > 0 && mContainer.Bottom + (e.Y - MouseDownLocation.Y) < mContainer.Parent.Height)
                    {
                        mContainer.Top = e.Y + mContainer.Top - MouseDownLocation.Y;
                    }
                }
            }
            else
            {
                mContainer.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Move/Resize method
        private void startMovingOrResizing(Control control, MouseEventArgs e)
        {
            if (editMode)
            {
                if (isMoving || isResizing)
                {
                    return;
                }
                if (workMode != moveOrResize.Move 
                    &&
                    (MouseIsInRightEdge || MouseIsInLeftEdge || MouseIsInTopEdge || MouseIsInBottomEdge))
                {
                    isResizing = true;
                    _currentControlStartSize = control.Size;
                }
                else
                {
                    isMoving = true;
                    mContainer.Cursor = Cursors.Hand;
                }
                MouseDownLocation = new Point(e.X, e.Y);
                control.Capture = true;

            }
        }

        private  void updateMouseEdgeProperties(Control control ,Point mouseLocationInControl)
        {
            if (workMode == moveOrResize.Move)
            {
                return;
            }
            MouseIsInLeftEdge = Math.Abs(mouseLocationInControl.X) <= 2;
            MouseIsInRightEdge = Math.Abs(mouseLocationInControl.X - mContainer.Width) <= 2;
            MouseIsInTopEdge = Math.Abs(mouseLocationInControl.Y) <= 2;
            MouseIsInBottomEdge = Math.Abs(mouseLocationInControl.Y - mContainer.Height) <= 2;
        }

        private  void updateMouseCursor()
        {
            if (workMode == moveOrResize.Move)
            {
                mContainer.Cursor = Cursors.Default;
                return;
            }
            if (MouseIsInLeftEdge)
            {
                if (MouseIsInTopEdge)
                {
                    mContainer.Cursor = Cursors.SizeNWSE;
                }
                else if (MouseIsInBottomEdge)
                {
                    mContainer.Cursor = Cursors.SizeNESW;
                }
                else
                {
                    mContainer.Cursor = Cursors.SizeWE;
                }
            }
            else if (MouseIsInRightEdge)
            {
                if (MouseIsInTopEdge)
                {
                    mContainer.Cursor = Cursors.SizeNESW;
                }
                else if (MouseIsInBottomEdge)
                {
                    mContainer.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    mContainer.Cursor = Cursors.SizeWE;
                }
            }
            else if (MouseIsInTopEdge || MouseIsInBottomEdge)
            {
                mContainer.Cursor = Cursors.SizeNS;
            }
            else
            {
                mContainer.Cursor = Cursors.Default;
                //updateMouseCursor();
            }
        }

        private  void stopDragOrResizing(Control control)
        {
            isResizing = false;
            isMoving = false;
            control.Capture = false;
            updateMouseCursor();
        }
        #endregion

        #region Enable/Disalbe 
        public void changeEditMode(bool editmode)
        {
            editMode = editmode;

        }
        #endregion
    }
}
