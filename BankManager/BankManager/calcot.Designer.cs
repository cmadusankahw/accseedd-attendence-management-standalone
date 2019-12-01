namespace BankManager
{
    partial class calcot
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
            this.generate = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnresetot = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtempidot = new System.Windows.Forms.MaskedTextBox();
            this.txthr = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tdatePick = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fdatePick = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempdept = new System.Windows.Forms.Label();
            this.lblempothrs = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblemppay = new System.Windows.Forms.Label();
            this.btnGenot = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.TabPage();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblnext = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDatnew = new System.Windows.Forms.Label();
            this.btnimport = new System.Windows.Forms.Button();
            this.lblDat = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dfTable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.generate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.upload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dfTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Location = new System.Drawing.Point(248, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1496, 10);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Over Time Calculation";
            // 
            // generate
            // 
            this.generate.Controls.Add(this.panel2);
            this.generate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(4, 39);
            this.generate.Margin = new System.Windows.Forms.Padding(2);
            this.generate.Name = "generate";
            this.generate.Padding = new System.Windows.Forms.Padding(2);
            this.generate.Size = new System.Drawing.Size(832, 517);
            this.generate.TabIndex = 1;
            this.generate.Text = "Generate OT";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnresetot);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.btnGenot);
            this.panel2.Location = new System.Drawing.Point(18, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 451);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnresetot
            // 
            this.btnresetot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnresetot.BackColor = System.Drawing.Color.Aquamarine;
            this.btnresetot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresetot.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetot.Location = new System.Drawing.Point(593, 124);
            this.btnresetot.Margin = new System.Windows.Forms.Padding(2);
            this.btnresetot.Name = "btnresetot";
            this.btnresetot.Size = new System.Drawing.Size(181, 42);
            this.btnresetot.TabIndex = 13;
            this.btnresetot.Text = "Reset Fields";
            this.btnresetot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnresetot.UseVisualStyleBackColor = false;
            this.btnresetot.Click += new System.EventHandler(this.btnresetot_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.43708F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.56291F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel4.Controls.Add(this.txtempidot, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txthr, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label16, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(21, 44);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(547, 36);
            this.tableLayoutPanel4.TabIndex = 12;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // txtempidot
            // 
            this.txtempidot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtempidot.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempidot.Location = new System.Drawing.Point(103, 3);
            this.txtempidot.Mask = "0000000000";
            this.txtempidot.Name = "txtempidot";
            this.txtempidot.Size = new System.Drawing.Size(184, 28);
            this.txtempidot.TabIndex = 10;
            // 
            // txthr
            // 
            this.txthr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txthr.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthr.Location = new System.Drawing.Point(389, 3);
            this.txthr.Mask = "000.00";
            this.txthr.Name = "txthr";
            this.txthr.Size = new System.Drawing.Size(155, 28);
            this.txthr.TabIndex = 9;
            this.txthr.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(2, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 36);
            this.label17.TabIndex = 10;
            this.label17.Text = "Employee ID :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(292, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 36);
            this.label16.TabIndex = 12;
            this.label16.Text = "Hourly Rate :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.69623F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.30377F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel3.Controls.Add(this.tdatePick, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.fdatePick, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(21, 107);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22622F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.74743F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.49662F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.49662F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(547, 67);
            this.tableLayoutPanel3.TabIndex = 11;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tdatePick
            // 
            this.tdatePick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tdatePick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdatePick.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdatePick.Location = new System.Drawing.Point(273, 35);
            this.tdatePick.Margin = new System.Windows.Forms.Padding(2);
            this.tdatePick.Name = "tdatePick";
            this.tdatePick.Size = new System.Drawing.Size(272, 28);
            this.tdatePick.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 33);
            this.label13.TabIndex = 12;
            this.label13.Text = "From date:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(273, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(272, 33);
            this.label14.TabIndex = 13;
            this.label14.Text = "To date:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fdatePick
            // 
            this.fdatePick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fdatePick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdatePick.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdatePick.Location = new System.Drawing.Point(2, 35);
            this.fdatePick.Margin = new System.Windows.Forms.Padding(2);
            this.fdatePick.Name = "fdatePick";
            this.fdatePick.Size = new System.Drawing.Size(267, 28);
            this.fdatePick.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.12234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.87766F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblempname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblempdept, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblempothrs, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblemppay, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 221);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.74743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.49662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.49662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.672184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 209);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 164);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 45);
            this.label15.TabIndex = 12;
            this.label15.Text = "Due Payment(Rs.)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblempname
            // 
            this.lblempname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(220, 0);
            this.lblempname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(530, 41);
            this.lblempname.TabIndex = 12;
            this.lblempname.Text = "Registered Date";
            this.lblempname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblempdept
            // 
            this.lblempdept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblempdept.AutoSize = true;
            this.lblempdept.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempdept.Location = new System.Drawing.Point(220, 41);
            this.lblempdept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblempdept.Name = "lblempdept";
            this.lblempdept.Size = new System.Drawing.Size(530, 41);
            this.lblempdept.TabIndex = 12;
            this.lblempdept.Text = "Department";
            this.lblempdept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblempothrs
            // 
            this.lblempothrs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblempothrs.AutoSize = true;
            this.lblempothrs.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempothrs.Location = new System.Drawing.Point(220, 82);
            this.lblempothrs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblempothrs.Name = "lblempothrs";
            this.lblempothrs.Size = new System.Drawing.Size(530, 41);
            this.lblempothrs.TabIndex = 13;
            this.lblempothrs.Text = "Registered Date";
            this.lblempothrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 41);
            this.label11.TabIndex = 12;
            this.label11.Text = "OT Hours :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblemppay
            // 
            this.lblemppay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblemppay.AutoSize = true;
            this.lblemppay.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemppay.Location = new System.Drawing.Point(220, 164);
            this.lblemppay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemppay.Name = "lblemppay";
            this.lblemppay.Size = new System.Drawing.Size(530, 45);
            this.lblemppay.TabIndex = 15;
            this.lblemppay.Text = "Registered Date";
            this.lblemppay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenot
            // 
            this.btnGenot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenot.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenot.Image = global::BankManager.Properties.Resources.search_icon_marine_md1;
            this.btnGenot.Location = new System.Drawing.Point(593, 44);
            this.btnGenot.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenot.Name = "btnGenot";
            this.btnGenot.Size = new System.Drawing.Size(181, 64);
            this.btnGenot.TabIndex = 0;
            this.btnGenot.Text = "Generate OT";
            this.btnGenot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenot.UseVisualStyleBackColor = true;
            this.btnGenot.Click += new System.EventHandler(this.btnGenot_Click);
            // 
            // upload
            // 
            this.upload.Controls.Add(this.pbox);
            this.upload.Controls.Add(this.panel4);
            this.upload.Controls.Add(this.panel3);
            this.upload.Controls.Add(this.dfTable);
            this.upload.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(4, 39);
            this.upload.Margin = new System.Windows.Forms.Padding(2);
            this.upload.Name = "upload";
            this.upload.Padding = new System.Windows.Forms.Padding(2);
            this.upload.Size = new System.Drawing.Size(832, 517);
            this.upload.TabIndex = 0;
            this.upload.Text = "Upload Dataset";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.General_Click);
            // 
            // pbox
            // 
            this.pbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox.BackColor = System.Drawing.Color.White;
            this.pbox.ErrorImage = global::BankManager.Properties.Resources.load;
            this.pbox.ImageLocation = "60,60";
            this.pbox.Location = new System.Drawing.Point(16, 4);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(815, 511);
            this.pbox.TabIndex = 19;
            this.pbox.TabStop = false;
            this.pbox.Visible = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Location = new System.Drawing.Point(18, 147);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 95);
            this.panel4.TabIndex = 18;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56946F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.22421F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.54333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.35897F));
            this.tableLayoutPanel2.Controls.Add(this.lblTo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblnext, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 35);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(147, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(236, 35);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "sample_date";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Updated :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 35);
            this.label12.TabIndex = 3;
            this.label12.Text = "Due Update :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblnext
            // 
            this.lblnext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnext.AutoSize = true;
            this.lblnext.Location = new System.Drawing.Point(509, 0);
            this.lblnext.Name = "lblnext";
            this.lblnext.Size = new System.Drawing.Size(262, 35);
            this.lblnext.TabIndex = 5;
            this.lblnext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblnext.Click += new System.EventHandler(this.lblnext_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblDatnew);
            this.panel3.Controls.Add(this.btnimport);
            this.panel3.Controls.Add(this.lblDat);
            this.panel3.Controls.Add(this.btnUpload);
            this.panel3.Location = new System.Drawing.Point(18, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 116);
            this.panel3.TabIndex = 16;
            // 
            // lblDatnew
            // 
            this.lblDatnew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatnew.AutoSize = true;
            this.lblDatnew.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatnew.Location = new System.Drawing.Point(256, 61);
            this.lblDatnew.Name = "lblDatnew";
            this.lblDatnew.Size = new System.Drawing.Size(109, 21);
            this.lblDatnew.TabIndex = 9;
            this.lblDatnew.Text = "No file Uploaded";
            this.lblDatnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnimport
            // 
            this.btnimport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimport.BackColor = System.Drawing.Color.Turquoise;
            this.btnimport.Enabled = false;
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.Location = new System.Drawing.Point(655, 37);
            this.btnimport.Margin = new System.Windows.Forms.Padding(2);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(134, 48);
            this.btnimport.TabIndex = 2;
            this.btnimport.Text = "Import Data";
            this.btnimport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnimport.UseVisualStyleBackColor = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new System.Drawing.Point(341, 48);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(0, 26);
            this.lblDat.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpload.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Image = global::BankManager.Properties.Resources.search_icon_marine_md1;
            this.btnUpload.Location = new System.Drawing.Point(15, 37);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(236, 48);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload DAT File";
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // dfTable
            // 
            this.dfTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dfTable.BackgroundColor = System.Drawing.Color.White;
            this.dfTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dfTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dfTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dfTable.Location = new System.Drawing.Point(18, 259);
            this.dfTable.Margin = new System.Windows.Forms.Padding(2);
            this.dfTable.Name = "dfTable";
            this.dfTable.RowHeadersWidth = 45;
            this.dfTable.RowTemplate.Height = 24;
            this.dfTable.Size = new System.Drawing.Size(804, 247);
            this.dfTable.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.upload);
            this.tabControl1.Controls.Add(this.generate);
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(70, 90);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openDat";
            // 
            // calcot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "calcot";
            this.Size = new System.Drawing.Size(1600, 1000);
            this.Load += new System.EventHandler(this.calcot_Load);
            this.generate.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.upload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dfTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage generate;
        private System.Windows.Forms.TabPage upload;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblempothrs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblnext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker tdatePick;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker fdatePick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnresetot;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txthr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblempdept;
        private System.Windows.Forms.Label lblemppay;
        private System.Windows.Forms.Label lblDatnew;
        private System.Windows.Forms.MaskedTextBox txtempidot;
        private System.Windows.Forms.DataGridView dfTable;
        private System.Windows.Forms.PictureBox pbox;
    }
}
