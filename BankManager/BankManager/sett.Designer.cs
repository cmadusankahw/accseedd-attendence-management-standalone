namespace BankManager
{
    partial class sett
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdatedept = new System.Windows.Forms.Button();
            this.DeptView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnremovedept = new System.Windows.Forms.Button();
            this.txtdeptadd = new System.Windows.Forms.TextBox();
            this.adddept = new System.Windows.Forms.Button();
            this.txtstartadd = new System.Windows.Forms.MaskedTextBox();
            this.txtotadd = new System.Windows.Forms.MaskedTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnupdateot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnremoveot = new System.Windows.Forms.Button();
            this.otview = new System.Windows.Forms.DataGridView();
            this.btnaddot = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.startremove = new System.Windows.Forms.Button();
            this.startview = new System.Windows.Forms.DataGridView();
            this.startupdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otview)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 509);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnupdatedept);
            this.panel4.Controls.Add(this.DeptView);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnremovedept);
            this.panel4.Controls.Add(this.txtdeptadd);
            this.panel4.Controls.Add(this.adddept);
            this.panel4.Location = new System.Drawing.Point(13, 14);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(791, 479);
            this.panel4.TabIndex = 19;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnupdatedept
            // 
            this.btnupdatedept.Enabled = false;
            this.btnupdatedept.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnupdatedept.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatedept.Location = new System.Drawing.Point(554, 139);
            this.btnupdatedept.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdatedept.Name = "btnupdatedept";
            this.btnupdatedept.Size = new System.Drawing.Size(207, 42);
            this.btnupdatedept.TabIndex = 22;
            this.btnupdatedept.Text = "Update";
            this.btnupdatedept.UseVisualStyleBackColor = true;
            this.btnupdatedept.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeptView
            // 
            this.DeptView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeptView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeptView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptView.ColumnHeadersVisible = false;
            this.DeptView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DeptView.Location = new System.Drawing.Point(12, 107);
            this.DeptView.MultiSelect = false;
            this.DeptView.Name = "DeptView";
            this.DeptView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DeptView.Size = new System.Drawing.Size(519, 333);
            this.DeptView.TabIndex = 20;
            this.DeptView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeptView_CellClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnremovedept
            // 
            this.btnremovedept.AutoSize = true;
            this.btnremovedept.Enabled = false;
            this.btnremovedept.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnremovedept.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovedept.Location = new System.Drawing.Point(554, 197);
            this.btnremovedept.Margin = new System.Windows.Forms.Padding(2);
            this.btnremovedept.Name = "btnremovedept";
            this.btnremovedept.Size = new System.Drawing.Size(207, 40);
            this.btnremovedept.TabIndex = 16;
            this.btnremovedept.Text = "Remove";
            this.btnremovedept.UseVisualStyleBackColor = true;
            this.btnremovedept.Click += new System.EventHandler(this.btnremovedept_Click);
            // 
            // txtdeptadd
            // 
            this.txtdeptadd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtdeptadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeptadd.Location = new System.Drawing.Point(123, 56);
            this.txtdeptadd.Margin = new System.Windows.Forms.Padding(2);
            this.txtdeptadd.Name = "txtdeptadd";
            this.txtdeptadd.Size = new System.Drawing.Size(408, 28);
            this.txtdeptadd.TabIndex = 11;
            // 
            // adddept
            // 
            this.adddept.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.adddept.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddept.Location = new System.Drawing.Point(554, 56);
            this.adddept.Margin = new System.Windows.Forms.Padding(2);
            this.adddept.Name = "adddept";
            this.adddept.Size = new System.Drawing.Size(207, 54);
            this.adddept.TabIndex = 15;
            this.adddept.Text = "Add New";
            this.adddept.UseVisualStyleBackColor = true;
            this.adddept.Click += new System.EventHandler(this.adddept_Click);
            // 
            // txtstartadd
            // 
            this.txtstartadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstartadd.Location = new System.Drawing.Point(100, 58);
            this.txtstartadd.Mask = "00:00";
            this.txtstartadd.Name = "txtstartadd";
            this.txtstartadd.Size = new System.Drawing.Size(431, 28);
            this.txtstartadd.TabIndex = 16;
            // 
            // txtotadd
            // 
            this.txtotadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotadd.Location = new System.Drawing.Point(90, 57);
            this.txtotadd.Mask = "00:00";
            this.txtotadd.Name = "txtotadd";
            this.txtotadd.Size = new System.Drawing.Size(441, 28);
            this.txtotadd.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Location = new System.Drawing.Point(125, 44);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1519, 10);
            this.panel5.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 34);
            this.label16.TabIndex = 12;
            this.label16.Text = "Settings";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(70, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 560);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Departments";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OT Classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnupdateot);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnremoveot);
            this.panel2.Controls.Add(this.otview);
            this.panel2.Controls.Add(this.btnaddot);
            this.panel2.Controls.Add(this.txtotadd);
            this.panel2.Location = new System.Drawing.Point(18, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 479);
            this.panel2.TabIndex = 21;
            // 
            // btnupdateot
            // 
            this.btnupdateot.Enabled = false;
            this.btnupdateot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnupdateot.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateot.Location = new System.Drawing.Point(555, 139);
            this.btnupdateot.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdateot.Name = "btnupdateot";
            this.btnupdateot.Size = new System.Drawing.Size(207, 42);
            this.btnupdateot.TabIndex = 22;
            this.btnupdateot.Text = "Update";
            this.btnupdateot.UseVisualStyleBackColor = true;
            this.btnupdateot.Click += new System.EventHandler(this.btnupdateot_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "OT Class";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnremoveot
            // 
            this.btnremoveot.AutoSize = true;
            this.btnremoveot.Enabled = false;
            this.btnremoveot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnremoveot.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveot.Location = new System.Drawing.Point(555, 199);
            this.btnremoveot.Margin = new System.Windows.Forms.Padding(2);
            this.btnremoveot.Name = "btnremoveot";
            this.btnremoveot.Size = new System.Drawing.Size(207, 40);
            this.btnremoveot.TabIndex = 19;
            this.btnremoveot.Text = "Remove";
            this.btnremoveot.UseVisualStyleBackColor = true;
            this.btnremoveot.Click += new System.EventHandler(this.btnremoveot_Click);
            // 
            // otview
            // 
            this.otview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.otview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otview.ColumnHeadersVisible = false;
            this.otview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.otview.Location = new System.Drawing.Point(13, 110);
            this.otview.MultiSelect = false;
            this.otview.Name = "otview";
            this.otview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.otview.Size = new System.Drawing.Size(519, 338);
            this.otview.TabIndex = 1;
            this.otview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.otview_CellClick);
            // 
            // btnaddot
            // 
            this.btnaddot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnaddot.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddot.Location = new System.Drawing.Point(555, 57);
            this.btnaddot.Margin = new System.Windows.Forms.Padding(2);
            this.btnaddot.Name = "btnaddot";
            this.btnaddot.Size = new System.Drawing.Size(207, 54);
            this.btnaddot.TabIndex = 15;
            this.btnaddot.Text = "Add New";
            this.btnaddot.UseVisualStyleBackColor = true;
            this.btnaddot.Click += new System.EventHandler(this.btnaddot_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(832, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Start Times";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.startremove);
            this.panel3.Controls.Add(this.txtstartadd);
            this.panel3.Controls.Add(this.startview);
            this.panel3.Controls.Add(this.startupdate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.startadd);
            this.panel3.Location = new System.Drawing.Point(21, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 479);
            this.panel3.TabIndex = 22;
            // 
            // startremove
            // 
            this.startremove.AutoSize = true;
            this.startremove.Enabled = false;
            this.startremove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startremove.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startremove.Location = new System.Drawing.Point(554, 199);
            this.startremove.Margin = new System.Windows.Forms.Padding(2);
            this.startremove.Name = "startremove";
            this.startremove.Size = new System.Drawing.Size(207, 40);
            this.startremove.TabIndex = 20;
            this.startremove.Text = "Remove";
            this.startremove.UseVisualStyleBackColor = true;
            this.startremove.Click += new System.EventHandler(this.startremove_Click);
            // 
            // startview
            // 
            this.startview.AllowDrop = true;
            this.startview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.startview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.startview.ColumnHeadersVisible = false;
            this.startview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.startview.Location = new System.Drawing.Point(12, 107);
            this.startview.MultiSelect = false;
            this.startview.Name = "startview";
            this.startview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.startview.Size = new System.Drawing.Size(519, 341);
            this.startview.TabIndex = 2;
            this.startview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.startview_CellClick);
            // 
            // startupdate
            // 
            this.startupdate.Enabled = false;
            this.startupdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startupdate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupdate.Location = new System.Drawing.Point(554, 139);
            this.startupdate.Margin = new System.Windows.Forms.Padding(2);
            this.startupdate.Name = "startupdate";
            this.startupdate.Size = new System.Drawing.Size(207, 42);
            this.startupdate.TabIndex = 22;
            this.startupdate.Text = "Update";
            this.startupdate.UseVisualStyleBackColor = true;
            this.startupdate.Click += new System.EventHandler(this.startupdate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // startadd
            // 
            this.startadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startadd.Location = new System.Drawing.Point(554, 56);
            this.startadd.Margin = new System.Windows.Forms.Padding(2);
            this.startadd.Name = "startadd";
            this.startadd.Size = new System.Drawing.Size(207, 54);
            this.startadd.TabIndex = 15;
            this.startadd.Text = "Add New";
            this.startadd.UseVisualStyleBackColor = true;
            this.startadd.Click += new System.EventHandler(this.startadd_Click);
            // 
            // sett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label16);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "sett";
            this.Size = new System.Drawing.Size(1600, 1000);
            this.Load += new System.EventHandler(this.sett_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otview)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdeptadd;
        private System.Windows.Forms.Button adddept;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtstartadd;
        private System.Windows.Forms.MaskedTextBox txtotadd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button startremove;
        private System.Windows.Forms.Button btnremoveot;
        private System.Windows.Forms.Button btnremovedept;
        private System.Windows.Forms.DataGridView startview;
        private System.Windows.Forms.DataGridView otview;
        private System.Windows.Forms.DataGridView DeptView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnupdatedept;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnupdateot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button startupdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startadd;
    }
}
