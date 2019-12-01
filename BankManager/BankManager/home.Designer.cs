namespace BankManager
{
    partial class homecontrol
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Location = new System.Drawing.Point(103, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1648, 10);
            this.panel1.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 34);
            this.label16.TabIndex = 8;
            this.label16.Text = "Last Updated";
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(641, 12);
            this.lbldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(138, 32);
            this.lbldate.TabIndex = 9;
            this.lbldate.Text = "sample_date\r\n";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.lbldate);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Location = new System.Drawing.Point(64, 190);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(804, 54);
            this.panel7.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 34);
            this.label14.TabIndex = 8;
            this.label14.Text = "Active Employees";
            // 
            // lblcount
            // 
            this.lblcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.Black;
            this.lblcount.Location = new System.Drawing.Point(744, 12);
            this.lblcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(43, 34);
            this.lblcount.TabIndex = 9;
            this.lblcount.Text = "50";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Turquoise;
            this.panel6.Controls.Add(this.lblcount);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(64, 112);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(804, 54);
            this.panel6.TabIndex = 11;
            // 
            // homecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "homecontrol";
            this.Size = new System.Drawing.Size(1600, 1000);
            this.Load += new System.EventHandler(this.homecontrol_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Panel panel6;
    }
}
