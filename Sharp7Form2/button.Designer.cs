namespace Sharp7Form2
{
    partial class button
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.datatypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatatypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PositionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.propertesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 65);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(112)))), ((int)(((byte)(41)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(3, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stinkToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.propertyToolStripMenuItem,
            this.propertesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // stinkToolStripMenuItem
            // 
            this.stinkToolStripMenuItem.Name = "stinkToolStripMenuItem";
            this.stinkToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.stinkToolStripMenuItem.Text = "Enable stink";
            this.stinkToolStripMenuItem.Click += new System.EventHandler(this.stinkToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.datatypeToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.bitToolStripMenuItem});
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.propertyToolStripMenuItem.Text = "Edit";
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
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 27);
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
            // propertesToolStripMenuItem
            // 
            this.propertesToolStripMenuItem.Name = "propertesToolStripMenuItem";
            this.propertesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.propertesToolStripMenuItem.Text = "Propertes";
            this.propertesToolStripMenuItem.Click += new System.EventHandler(this.propertesToolStripMenuItem_Click);
            // 
            // button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "button";
            this.Size = new System.Drawing.Size(100, 69);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox NameTextBox;
        private System.Windows.Forms.ToolStripMenuItem datatypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox DatatypeComboBox;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox PositionTextBox;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox BitComboBox;
        private System.Windows.Forms.ToolStripMenuItem stinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox AreaComboBox;
    }
}
