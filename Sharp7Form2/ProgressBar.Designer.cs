namespace Sharp7Form2
{
    partial class ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameTextBox = new System.Windows.Forms.ToolStripTextBox();
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
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 39);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.propertesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 76);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.datatypeToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.bitToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.minToolStripMenuItem,
            this.widthToolStripMenuItem});
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
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
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameTextBox});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 27);
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
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 27);
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
            this.maxToolStripMenuItem.CheckOnClick = true;
            this.maxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxTextBox});
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.maxToolStripMenuItem.Text = "Max ";
            // 
            // maxTextBox
            // 
            this.maxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 27);
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
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widthTextBox});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // widthTextBox
            // 
            this.widthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 27);
            this.widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // propertesToolStripMenuItem
            // 
            this.propertesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.propertesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.propertesToolStripMenuItem.Name = "propertesToolStripMenuItem";
            this.propertesToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.propertesToolStripMenuItem.Text = "Propertes";
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressBar";
            this.Size = new System.Drawing.Size(376, 39);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox AreaComboBox;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox NameTextBox;
        private System.Windows.Forms.ToolStripMenuItem datatypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox DatatypeComboBox;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox PositionTextBox;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox BitComboBox;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox maxTextBox;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox minTextBox;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox widthTextBox;
    }
}
