namespace BankManager
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnOt = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.user1 = new BankManager.user();
            this.loanuc2 = new BankManager.find();
            this.staff1 = new BankManager.txtContact();
            this.calcot = new BankManager.calcot();
            this.homecontrol1 = new BankManager.homecontrol();
            this.transforms1 = new BankManager.calcot();
            this.user = new BankManager.user();
            this.sett1 = new BankManager.sett();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 1059);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = global::BankManager.Properties.Resources.AccSeedd_logo__1_;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(6, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(258, 87);
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnEmp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFind, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUser, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnHome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 119);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.52991F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 916);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // btnEmp
            // 
            this.btnEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnEmp.FlatAppearance.BorderSize = 0;
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmp.Image = global::BankManager.Properties.Resources.search_icon_marine_md__1_;
            this.btnEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.Location = new System.Drawing.Point(2, 132);
            this.btnEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(249, 126);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "Employee Management";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.Acconts_Click);
            // 
            // btnOt
            // 
            this.btnOt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOt.BackColor = System.Drawing.Color.Transparent;
            this.btnOt.FlatAppearance.BorderSize = 0;
            this.btnOt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOt.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOt.Image = global::BankManager.Properties.Resources.search_icon_marine_md__5_;
            this.btnOt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOt.Location = new System.Drawing.Point(2, 262);
            this.btnOt.Margin = new System.Windows.Forms.Padding(2);
            this.btnOt.Name = "btnOt";
            this.btnOt.Size = new System.Drawing.Size(249, 126);
            this.btnOt.TabIndex = 2;
            this.btnOt.Text = "Calculate OT";
            this.btnOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOt.UseVisualStyleBackColor = false;
            this.btnOt.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.Image = global::BankManager.Properties.Resources.search_icon_marine_md__2_;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(2, 392);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(249, 126);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Queries";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUser.Image = global::BankManager.Properties.Resources.search_icon_marine_md__3_;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(2, 522);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(249, 126);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "User Accounts";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.Button6_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Image = global::BankManager.Properties.Resources.search_icon_marine_md__4_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(2, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(249, 126);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Button2_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.Button2_MouseEnter);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Image = global::BankManager.Properties.Resources.settings__184833;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(2, 652);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(249, 126);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 22);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.lbluser);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(1250, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 62);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(71, 19);
            this.lbluser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(120, 25);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "adminName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(285, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.Color.White;
            this.user1.Location = new System.Drawing.Point(268, 86);
            this.user1.Margin = new System.Windows.Forms.Padding(2);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(1600, 1000);
            this.user1.TabIndex = 9;
            // 
            // loanuc2
            // 
            this.loanuc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loanuc2.BackColor = System.Drawing.Color.White;
            this.loanuc2.Location = new System.Drawing.Point(264, 86);
            this.loanuc2.Margin = new System.Windows.Forms.Padding(2);
            this.loanuc2.Name = "loanuc2";
            this.loanuc2.Size = new System.Drawing.Size(1600, 1000);
            this.loanuc2.TabIndex = 7;
            // 
            // staff1
            // 
            this.staff1.BackColor = System.Drawing.Color.White;
            this.staff1.Cursor = System.Windows.Forms.Cursors.Default;
            this.staff1.Location = new System.Drawing.Point(268, 86);
            this.staff1.Margin = new System.Windows.Forms.Padding(2);
            this.staff1.Name = "staff1";
            this.staff1.Size = new System.Drawing.Size(1600, 1000);
            this.staff1.TabIndex = 8;
            // 
            // calcot
            // 
            this.calcot.BackColor = System.Drawing.Color.White;
            this.calcot.Cursor = System.Windows.Forms.Cursors.Default;
            this.calcot.Location = new System.Drawing.Point(266, 86);
            this.calcot.Margin = new System.Windows.Forms.Padding(2);
            this.calcot.Name = "calcot";
            this.calcot.Size = new System.Drawing.Size(1600, 1000);
            this.calcot.TabIndex = 6;
            this.calcot.Load += new System.EventHandler(this.calcot_Load);
            // 
            // homecontrol1
            // 
            this.homecontrol1.BackColor = System.Drawing.Color.White;
            this.homecontrol1.Location = new System.Drawing.Point(268, 86);
            this.homecontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.homecontrol1.Name = "homecontrol1";
            this.homecontrol1.Size = new System.Drawing.Size(1600, 1000);
            this.homecontrol1.TabIndex = 5;
            // 
            // transforms1
            // 
            this.transforms1.BackColor = System.Drawing.Color.White;
            this.transforms1.Location = new System.Drawing.Point(264, 92);
            this.transforms1.Margin = new System.Windows.Forms.Padding(2);
            this.transforms1.Name = "transforms1";
            this.transforms1.Size = new System.Drawing.Size(1238, 753);
            this.transforms1.TabIndex = 11;
            this.transforms1.Load += new System.EventHandler(this.Transforms1_Load);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(0, 0);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(1294, 917);
            this.user.TabIndex = 0;
            // 
            // sett1
            // 
            this.sett1.BackColor = System.Drawing.Color.White;
            this.sett1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sett1.Location = new System.Drawing.Point(266, 86);
            this.sett1.Name = "sett1";
            this.sett1.Size = new System.Drawing.Size(1600, 1000);
            this.sett1.TabIndex = 10;
            this.sett1.Load += new System.EventHandler(this.sett1_Load);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1597, 1059);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calcot);
            this.Controls.Add(this.homecontrol1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.loanuc2);
            this.Controls.Add(this.sett1);
            this.Controls.Add(this.staff1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnOt;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private homecontrol homecontrol1;
        private calcot calcot;
        private find loanuc2;
        private txtContact staff1;
        private calcot transforms1;
        private user user;
        private System.Windows.Forms.PictureBox picLogo;
        private user user1;
        private System.Windows.Forms.Button btnSettings;
        private sett sett1;
    }
}

