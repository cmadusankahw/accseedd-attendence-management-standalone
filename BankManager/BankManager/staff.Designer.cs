namespace BankManager
{
    partial class txtContact
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmpid = new System.Windows.Forms.MaskedTextBox();
            this.txtNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtContactno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.regdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combostart = new System.Windows.Forms.ComboBox();
            this.comboOT = new System.Windows.Forms.ComboBox();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnresetemp = new System.Windows.Forms.Button();
            this.btnupdateemp = new System.Windows.Forms.Button();
            this.btnremoveemp = new System.Windows.Forms.Button();
            this.btnaddemp = new System.Windows.Forms.Button();
            this.empTbl = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empTbl)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Location = new System.Drawing.Point(278, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 10);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(11, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 347);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.41667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.58334F));
            this.tableLayoutPanel1.Controls.Add(this.txtEmpid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNIC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtContactno, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboGender, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.regdatePicker, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.combostart, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboOT, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.comboDept, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6267F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6267F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.35422F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(603, 319);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // txtEmpid
            // 
            this.txtEmpid.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpid.Location = new System.Drawing.Point(126, 3);
            this.txtEmpid.Mask = "0000000000";
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.Size = new System.Drawing.Size(455, 28);
            this.txtEmpid.TabIndex = 16;
            this.txtEmpid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtEmpid_MaskInputRejected);
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(126, 37);
            this.txtNIC.Mask = "000000000000000";
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(455, 28);
            this.txtNIC.TabIndex = 16;
            this.txtNIC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNIC_MaskInputRejected);
            // 
            // txtContactno
            // 
            this.txtContactno.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactno.Location = new System.Drawing.Point(126, 139);
            this.txtContactno.Mask = "000-0000000";
            this.txtContactno.Name = "txtContactno";
            this.txtContactno.Size = new System.Drawing.Size(455, 28);
            this.txtContactno.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "NIC (Exclude V)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(125, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(476, 28);
            this.txtName.TabIndex = 11;
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(125, 104);
            this.comboGender.Margin = new System.Windows.Forms.Padding(2);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(291, 31);
            this.comboGender.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 34);
            this.label11.TabIndex = 12;
            this.label11.Text = "Gender";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 136);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 34);
            this.label15.TabIndex = 12;
            this.label15.Text = "Contact Number";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // regdatePicker
            // 
            this.regdatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regdatePicker.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regdatePicker.Location = new System.Drawing.Point(125, 172);
            this.regdatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.regdatePicker.Name = "regdatePicker";
            this.regdatePicker.Size = new System.Drawing.Size(291, 28);
            this.regdatePicker.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reg Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 37);
            this.label9.TabIndex = 12;
            this.label9.Text = "Department";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combostart
            // 
            this.combostart.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combostart.Location = new System.Drawing.Point(125, 245);
            this.combostart.Margin = new System.Windows.Forms.Padding(2);
            this.combostart.Name = "combostart";
            this.combostart.Size = new System.Drawing.Size(291, 31);
            this.combostart.TabIndex = 23;
            this.combostart.SelectedIndexChanged += new System.EventHandler(this.combostart_SelectedIndexChanged);
            this.combostart.Click += new System.EventHandler(this.combostart_Click);
            // 
            // comboOT
            // 
            this.comboOT.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOT.Location = new System.Drawing.Point(125, 282);
            this.comboOT.Margin = new System.Windows.Forms.Padding(2);
            this.comboOT.Name = "comboOT";
            this.comboOT.Size = new System.Drawing.Size(291, 31);
            this.comboOT.TabIndex = 20;
            this.comboOT.Click += new System.EventHandler(this.comboOT_Click);
            // 
            // comboDept
            // 
            this.comboDept.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDept.Location = new System.Drawing.Point(125, 208);
            this.comboDept.Margin = new System.Windows.Forms.Padding(2);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(291, 31);
            this.comboDept.TabIndex = 20;
            this.comboDept.SelectedIndexChanged += new System.EventHandler(this.comboDept_SelectedIndexChanged);
            this.comboDept.Click += new System.EventHandler(this.comboDept_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 280);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 39);
            this.label10.TabIndex = 12;
            this.label10.Text = "OT Class";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "Start Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnresetemp);
            this.panel3.Controls.Add(this.btnupdateemp);
            this.panel3.Controls.Add(this.btnremoveemp);
            this.panel3.Controls.Add(this.btnaddemp);
            this.panel3.Location = new System.Drawing.Point(641, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 347);
            this.panel3.TabIndex = 13;
            // 
            // btnresetemp
            // 
            this.btnresetemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnresetemp.BackColor = System.Drawing.Color.Aquamarine;
            this.btnresetemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresetemp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetemp.Location = new System.Drawing.Point(11, 84);
            this.btnresetemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnresetemp.Name = "btnresetemp";
            this.btnresetemp.Size = new System.Drawing.Size(150, 46);
            this.btnresetemp.TabIndex = 3;
            this.btnresetemp.Text = "Reset Fields";
            this.btnresetemp.UseVisualStyleBackColor = false;
            this.btnresetemp.Click += new System.EventHandler(this.btnresetemp_Click);
            // 
            // btnupdateemp
            // 
            this.btnupdateemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdateemp.Enabled = false;
            this.btnupdateemp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnupdateemp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateemp.Location = new System.Drawing.Point(11, 220);
            this.btnupdateemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdateemp.Name = "btnupdateemp";
            this.btnupdateemp.Size = new System.Drawing.Size(150, 48);
            this.btnupdateemp.TabIndex = 2;
            this.btnupdateemp.Text = "Update";
            this.btnupdateemp.UseVisualStyleBackColor = true;
            this.btnupdateemp.Click += new System.EventHandler(this.btnupdateemp_Click);
            // 
            // btnremoveemp
            // 
            this.btnremoveemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnremoveemp.Enabled = false;
            this.btnremoveemp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnremoveemp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveemp.Location = new System.Drawing.Point(11, 281);
            this.btnremoveemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnremoveemp.Name = "btnremoveemp";
            this.btnremoveemp.Size = new System.Drawing.Size(150, 50);
            this.btnremoveemp.TabIndex = 1;
            this.btnremoveemp.Text = "Remove";
            this.btnremoveemp.UseVisualStyleBackColor = true;
            this.btnremoveemp.Click += new System.EventHandler(this.btnremoveemp_Click);
            // 
            // btnaddemp
            // 
            this.btnaddemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddemp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnaddemp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddemp.Location = new System.Drawing.Point(11, 15);
            this.btnaddemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnaddemp.Name = "btnaddemp";
            this.btnaddemp.Size = new System.Drawing.Size(150, 59);
            this.btnaddemp.TabIndex = 0;
            this.btnaddemp.Text = "Add";
            this.btnaddemp.UseVisualStyleBackColor = true;
            this.btnaddemp.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // empTbl
            // 
            this.empTbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empTbl.DefaultCellStyle = dataGridViewCellStyle1;
            this.empTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.empTbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.empTbl.Location = new System.Drawing.Point(11, 366);
            this.empTbl.MultiSelect = false;
            this.empTbl.Name = "empTbl";
            this.empTbl.RowHeadersWidth = 45;
            this.empTbl.Size = new System.Drawing.Size(811, 181);
            this.empTbl.TabIndex = 14;
            this.empTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empTbl_CellClick);
            this.empTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empTbl_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.empTbl);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(70, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(840, 560);
            this.panel4.TabIndex = 15;
            // 
            // txtContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "txtContact";
            this.Size = new System.Drawing.Size(1600, 1000);
            this.Load += new System.EventHandler(this.txtContact_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empTbl)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboOT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnaddemp;
        private System.Windows.Forms.DateTimePicker regdatePicker;
        private System.Windows.Forms.Button btnresetemp;
        private System.Windows.Forms.Button btnupdateemp;
        private System.Windows.Forms.Button btnremoveemp;
        private System.Windows.Forms.DataGridView empTbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combostart;
        private System.Windows.Forms.MaskedTextBox txtContactno;
        private System.Windows.Forms.MaskedTextBox txtEmpid;
        private System.Windows.Forms.MaskedTextBox txtNIC;
        private System.Windows.Forms.Panel panel4;
    }
}
