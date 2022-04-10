namespace Sharp7Form2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableEditModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(260, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1556, 715);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1556, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1,
            this.infoToolStripMenuItem});
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.connectToolStripMenuItem.Text = "Configuration";
            // 
            // connectToolStripMenuItem1
            // 
            this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            this.connectToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.connectToolStripMenuItem1.Text = "Connect";
            this.connectToolStripMenuItem1.Click += new System.EventHandler(this.connectToolStripMenuItem1_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonToolStripMenuItem,
            this.writeToolStripMenuItem});
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // buttonToolStripMenuItem
            // 
            this.buttonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelToolStripMenuItem,
            this.processBarToolStripMenuItem,
            this.lEDToolStripMenuItem});
            this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            this.buttonToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.buttonToolStripMenuItem.Text = "Read";
            // 
            // labelToolStripMenuItem
            // 
            this.labelToolStripMenuItem.Name = "labelToolStripMenuItem";
            this.labelToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.labelToolStripMenuItem.Text = "Label";
            this.labelToolStripMenuItem.Click += new System.EventHandler(this.labelToolStripMenuItem_Click);
            // 
            // processBarToolStripMenuItem
            // 
            this.processBarToolStripMenuItem.Name = "processBarToolStripMenuItem";
            this.processBarToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.processBarToolStripMenuItem.Text = "Process bar";
            this.processBarToolStripMenuItem.Click += new System.EventHandler(this.processBarToolStripMenuItem_Click);
            // 
            // lEDToolStripMenuItem
            // 
            this.lEDToolStripMenuItem.Name = "lEDToolStripMenuItem";
            this.lEDToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.lEDToolStripMenuItem.Text = "LED";
            this.lEDToolStripMenuItem.Click += new System.EventHandler(this.lEDToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonStripMenuItem,
            this.trackbarToolStripMenuItem});
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.writeToolStripMenuItem.Text = "Write";
            // 
            // buttonStripMenuItem
            // 
            this.buttonStripMenuItem.Name = "buttonStripMenuItem";
            this.buttonStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.buttonStripMenuItem.Text = "Button";
            this.buttonStripMenuItem.Click += new System.EventHandler(this.buttonToolStripMenuItem_Click);
            // 
            // trackbarToolStripMenuItem
            // 
            this.trackbarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.trackbarToolStripMenuItem.Name = "trackbarToolStripMenuItem";
            this.trackbarToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.trackbarToolStripMenuItem.Text = "Trackbar";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableEditModeToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // enableEditModeToolStripMenuItem
            // 
            this.enableEditModeToolStripMenuItem.Name = "enableEditModeToolStripMenuItem";
            this.enableEditModeToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.enableEditModeToolStripMenuItem.Text = "Enable edit mode";
            this.enableEditModeToolStripMenuItem.Click += new System.EventHandler(this.enableEditModeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 721);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1556, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1556, 743);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Triple H";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableEditModeToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem labelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

