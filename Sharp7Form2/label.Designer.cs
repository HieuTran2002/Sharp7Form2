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
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.datatypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatatypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PositionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyleComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.propertesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(112)))), ((int)(((byte)(41)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem,
            this.datatypeToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.bitToolStripMenuItem,
            this.styleToolStripMenuItem});
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
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontStyleToolStripMenuItem,
            this.fontSizeToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.foreColorToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // fontStyleToolStripMenuItem
            // 
            this.fontStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontStyleComboBox1});
            this.fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
            this.fontStyleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontStyleToolStripMenuItem.Text = "Font style";
            // 
            // fontStyleComboBox1
            // 
            this.fontStyleComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.fontStyleComboBox1.Name = "fontStyleComboBox1";
            this.fontStyleComboBox1.Size = new System.Drawing.Size(121, 28);
            this.fontStyleComboBox1.SelectedIndexChanged += new System.EventHandler(this.fontStyleComboBox1_SelectedIndexChanged);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeTextBox1});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontSizeToolStripMenuItem.Text = "Font size";
            // 
            // fontSizeTextBox1
            // 
            this.fontSizeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontSizeTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fontSizeTextBox1.Name = "fontSizeTextBox1";
            this.fontSizeTextBox1.Size = new System.Drawing.Size(100, 27);
            this.fontSizeTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fontSizeTextBox1_KeyPress);
            this.fontSizeTextBox1.TextChanged += new System.EventHandler(this.fontSizeTextBox1_TextChanged);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundTextBox1});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // backgroundTextBox1
            // 
            this.backgroundTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backgroundTextBox1.Name = "backgroundTextBox1";
            this.backgroundTextBox1.Size = new System.Drawing.Size(100, 27);
            this.backgroundTextBox1.TextChanged += new System.EventHandler(this.backgroundTextBox1_TextChanged);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorTextBox1});
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.foreColorToolStripMenuItem.Text = "Fore color";
            // 
            // foreColorTextBox1
            // 
            this.foreColorTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foreColorTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.foreColorTextBox1.Name = "foreColorTextBox1";
            this.foreColorTextBox1.Size = new System.Drawing.Size(100, 27);
            this.foreColorTextBox1.TextChanged += new System.EventHandler(this.foreColorTextBox1_TextChanged);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
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
            // label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Name = "label";
            this.Size = new System.Drawing.Size(81, 31);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox fontStyleComboBox1;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox fontSizeTextBox1;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox backgroundTextBox1;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox foreColorTextBox1;
    }
}
