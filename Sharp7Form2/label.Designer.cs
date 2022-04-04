namespace Sharp7Form2
{
    partial class label
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 51);
            this.panel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.propertesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
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
            this.bitToolStripMenuItem});
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.propertyToolStripMenuItem.Text = "Edit";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaComboBox});
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.datatypeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeToolStripMenuItem.Text = "Remove";
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
            // label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "label";
            this.Size = new System.Drawing.Size(148, 55);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertesToolStripMenuItem;
    }
}
