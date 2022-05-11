namespace Sharp7Form2
{
    partial class nameLabel
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fontStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyleComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem,
            this.fontStyleToolStripMenuItem,
            this.textToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeTextBox1});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.fontSizeToolStripMenuItem.Text = "Font size";
            // 
            // fontSizeTextBox1
            // 
            this.fontSizeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontSizeTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fontSizeTextBox1.Name = "fontSizeTextBox1";
            this.fontSizeTextBox1.Size = new System.Drawing.Size(100, 27);
            this.fontSizeTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            this.fontSizeTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // fontStyleToolStripMenuItem
            // 
            this.fontStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontStyleComboBox1});
            this.fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
            this.fontStyleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.fontStyleToolStripMenuItem.Text = "Font style";
            // 
            // fontStyleComboBox1
            // 
            this.fontStyleComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.fontStyleComboBox1.Name = "fontStyleComboBox1";
            this.fontStyleComboBox1.Size = new System.Drawing.Size(121, 28);
            this.fontStyleComboBox1.SelectedIndexChanged += new System.EventHandler(this.fontStyleComboBox1_SelectedIndexChanged);
            this.fontStyleComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameTextBox});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.OwnerChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 27);
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTextBox});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.TextChanged += new System.EventHandler(this.colorToolStripMenuItem_TextChanged);
            // 
            // colorTextBox
            // 
            this.colorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 27);
            this.colorTextBox.TextChanged += new System.EventHandler(this.colorToolStripMenuItem_TextChanged);
            // 
            // nameLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.label1);
            this.Name = "nameLabel";
            this.Size = new System.Drawing.Size(92, 32);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox fontSizeTextBox1;
        internal System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox fontStyleComboBox1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox nameTextBox;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox colorTextBox;
    }
}
