namespace Sharp7Form2
{
    partial class connectDialog
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Rank = new System.Windows.Forms.ComboBox();
            this.IpAdressTB = new System.Windows.Forms.TextBox();
            this.CnnBTN = new System.Windows.Forms.Button();
            this.Slot = new System.Windows.Forms.ComboBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rank
            // 
            this.Rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.Rank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.Rank.FormattingEnabled = true;
            this.Rank.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.Rank.Location = new System.Drawing.Point(122, 68);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(114, 28);
            this.Rank.TabIndex = 0;
            // 
            // IpAdressTB
            // 
            this.IpAdressTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.IpAdressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpAdressTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.IpAdressTB.Location = new System.Drawing.Point(122, 19);
            this.IpAdressTB.Name = "IpAdressTB";
            this.IpAdressTB.Size = new System.Drawing.Size(233, 27);
            this.IpAdressTB.TabIndex = 1;
            this.IpAdressTB.Text = "192.168.0.241";
            // 
            // CnnBTN
            // 
            this.CnnBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.CnnBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnnBTN.Location = new System.Drawing.Point(242, 137);
            this.CnnBTN.Name = "CnnBTN";
            this.CnnBTN.Size = new System.Drawing.Size(114, 41);
            this.CnnBTN.TabIndex = 2;
            this.CnnBTN.Text = "Connect";
            this.CnnBTN.UseVisualStyleBackColor = false;
            this.CnnBTN.Click += new System.EventHandler(this.CnnBTN_Click);
            // 
            // Slot
            // 
            this.Slot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.Slot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.Slot.FormattingEnabled = true;
            this.Slot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.Slot.Location = new System.Drawing.Point(242, 68);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(113, 28);
            this.Slot.TabIndex = 3;
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBTN.Location = new System.Drawing.Point(122, 137);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(114, 41);
            this.CancelBTN.TabIndex = 4;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ip Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rank \\ Slot";
            // 
            // connectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(384, 204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.Slot);
            this.Controls.Add(this.CnnBTN);
            this.Controls.Add(this.IpAdressTB);
            this.Controls.Add(this.Rank);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "connectDialog";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox Rank;
        private System.Windows.Forms.TextBox IpAdressTB;
        private System.Windows.Forms.Button CnnBTN;
        private System.Windows.Forms.ComboBox Slot;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}