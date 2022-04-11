namespace Sharp7Form2
{
    partial class VTrackBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.datatypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatatypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PositionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyToolStripMenuItem,
            this.propertesToolStripMenuItem,
            this.toolStripSeparator1,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 110);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem,
            this.datatypeToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.bitToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.minToolStripMenuItem});
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.propertyToolStripMenuItem.Text = "Edit";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaComboBox});
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.AreaComboBox.Items.AddRange(new object[] {
            "I",
            "Q",
            "M"});
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(121, 28);
            // 
            // datatypeToolStripMenuItem
            // 
            this.datatypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatatypeComboBox});
            this.datatypeToolStripMenuItem.Name = "datatypeToolStripMenuItem";
            this.datatypeToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.datatypeToolStripMenuItem.Text = "Datatype";
            // 
            // DatatypeComboBox
            // 
            this.DatatypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.DatatypeComboBox.Items.AddRange(new object[] {
            "INT",
            "DINT",
            "WORD",
            "DWORD",
            "REAL",
            "BIT"});
            this.DatatypeComboBox.Name = "DatatypeComboBox";
            this.DatatypeComboBox.Size = new System.Drawing.Size(121, 28);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PositionTextBox});
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.positionToolStripMenuItem.Text = "Position";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 27);
            this.PositionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PositionTextBox_KeyPress);
            // 
            // bitToolStripMenuItem
            // 
            this.bitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BitComboBox});
            this.bitToolStripMenuItem.Name = "bitToolStripMenuItem";
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.bitToolStripMenuItem.Text = "Bit";
            // 
            // BitComboBox
            // 
            this.BitComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.BitComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.BitComboBox.Name = "BitComboBox";
            this.BitComboBox.Size = new System.Drawing.Size(121, 28);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxTextBox});
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.maxToolStripMenuItem.Text = "Max ";
            // 
            // maxTextBox
            // 
            this.maxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 27);
            this.maxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxRangeTextBox_KeyPress);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minTextBox});
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.minToolStripMenuItem.Text = "Min";
            // 
            // minTextBox
            // 
            this.minTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 27);
            this.minTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minTextBox_KeyPress);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // propertesToolStripMenuItem
            // 
            this.propertesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.propertesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.propertesToolStripMenuItem.Name = "propertesToolStripMenuItem";
            this.propertesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.propertesToolStripMenuItem.Text = "Propertes";
            this.propertesToolStripMenuItem.Click += new System.EventHandler(this.propertesToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(50, 326);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // VTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.trackBar1);
            this.Name = "VTrackBar";
            this.Size = new System.Drawing.Size(50, 326);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox AreaComboBox;
        private System.Windows.Forms.ToolStripMenuItem datatypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox DatatypeComboBox;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox PositionTextBox;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox BitComboBox;
        private System.Windows.Forms.ToolStripMenuItem propertesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox maxTextBox;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox minTextBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
