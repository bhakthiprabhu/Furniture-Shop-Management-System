namespace WindowsApplication
{
    partial class Emp_Add_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_Add_New));
            this.nadd = new System.Windows.Forms.Button();
            this.nupdate = new System.Windows.Forms.Button();
            this.nclear = new System.Windows.Forms.Button();
            this.ndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tdesgn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.taddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbinactive = new System.Windows.Forms.CheckBox();
            this.cbactive = new System.Windows.Forms.CheckBox();
            this.tbasicpay = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.temail = new System.Windows.Forms.TextBox();
            this.tage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchemp = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // nadd
            // 
            this.nadd.BackColor = System.Drawing.Color.Green;
            this.nadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nadd.FlatAppearance.BorderSize = 2;
            this.nadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nadd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.nadd.ForeColor = System.Drawing.Color.White;
            this.nadd.Location = new System.Drawing.Point(180, 267);
            this.nadd.Name = "nadd";
            this.nadd.Size = new System.Drawing.Size(85, 32);
            this.nadd.TabIndex = 38;
            this.nadd.Text = "Register";
            this.nadd.UseVisualStyleBackColor = false;
            this.nadd.Click += new System.EventHandler(this.nadd_Click);
            // 
            // nupdate
            // 
            this.nupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.nupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nupdate.Enabled = false;
            this.nupdate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.nupdate.FlatAppearance.BorderSize = 2;
            this.nupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nupdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.nupdate.ForeColor = System.Drawing.Color.White;
            this.nupdate.Location = new System.Drawing.Point(318, 267);
            this.nupdate.Name = "nupdate";
            this.nupdate.Size = new System.Drawing.Size(85, 32);
            this.nupdate.TabIndex = 39;
            this.nupdate.Text = "Update";
            this.nupdate.UseVisualStyleBackColor = false;
            this.nupdate.Click += new System.EventHandler(this.nupdate_Click);
            // 
            // nclear
            // 
            this.nclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(2)))));
            this.nclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nclear.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.nclear.FlatAppearance.BorderSize = 2;
            this.nclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nclear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.nclear.ForeColor = System.Drawing.Color.White;
            this.nclear.Location = new System.Drawing.Point(597, 267);
            this.nclear.Name = "nclear";
            this.nclear.Size = new System.Drawing.Size(85, 32);
            this.nclear.TabIndex = 40;
            this.nclear.Text = "Reset";
            this.nclear.UseVisualStyleBackColor = false;
            this.nclear.Click += new System.EventHandler(this.nclear_Click);
            // 
            // ndelete
            // 
            this.ndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ndelete.Enabled = false;
            this.ndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.ndelete.FlatAppearance.BorderSize = 2;
            this.ndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ndelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ndelete.ForeColor = System.Drawing.Color.White;
            this.ndelete.Location = new System.Drawing.Point(456, 267);
            this.ndelete.Name = "ndelete";
            this.ndelete.Size = new System.Drawing.Size(85, 32);
            this.ndelete.TabIndex = 41;
            this.ndelete.Text = "Delete";
            this.ndelete.UseVisualStyleBackColor = false;
            this.ndelete.Click += new System.EventHandler(this.ndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 200);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label10.Location = new System.Drawing.Point(54, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Employee Name / ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tdesgn
            // 
            this.tdesgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tdesgn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tdesgn.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tdesgn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tdesgn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tdesgn.Location = new System.Drawing.Point(205, 212);
            this.tdesgn.Name = "tdesgn";
            this.tdesgn.Size = new System.Drawing.Size(198, 19);
            this.tdesgn.TabIndex = 89;
            this.tdesgn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tdesgn_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label12.Location = new System.Drawing.Point(464, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 88;
            this.label12.Text = "Basic Pay";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label11.Location = new System.Drawing.Point(105, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 18);
            this.label11.TabIndex = 85;
            this.label11.Text = "Designation";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label8.Location = new System.Drawing.Point(448, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 86;
            this.label8.Text = "Joined Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(477, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 82;
            this.label5.Text = "Email ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(449, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Contact No.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label9.Location = new System.Drawing.Point(167, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 79;
            this.label9.Text = "Age";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taddr
            // 
            this.taddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.taddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.taddr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.taddr.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.taddr.Location = new System.Drawing.Point(205, 166);
            this.taddr.Name = "taddr";
            this.taddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taddr.Size = new System.Drawing.Size(198, 19);
            this.taddr.TabIndex = 78;
            this.taddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taddr_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(133, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.radioButton2.Location = new System.Drawing.Point(634, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 22);
            this.radioButton2.TabIndex = 76;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.radioButton1.Location = new System.Drawing.Point(552, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 22);
            this.radioButton1.TabIndex = 75;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(478, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.maskedTextBox1.Location = new System.Drawing.Point(205, 74);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(198, 19);
            this.maskedTextBox1.TabIndex = 73;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label7.Location = new System.Drawing.Point(102, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "Date of Birth";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tname
            // 
            this.tname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tname.Location = new System.Drawing.Point(205, 28);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(198, 19);
            this.tname.TabIndex = 71;
            this.tname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(121, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Full Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(551, 172);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 26);
            this.dateTimePicker1.TabIndex = 91;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radioButton3.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.radioButton3.Location = new System.Drawing.Point(699, 36);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 22);
            this.radioButton3.TabIndex = 92;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Others";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbinactive);
            this.groupBox1.Controls.Add(this.cbactive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(461, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 44);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By";
            // 
            // cbinactive
            // 
            this.cbinactive.AutoSize = true;
            this.cbinactive.FlatAppearance.BorderSize = 0;
            this.cbinactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbinactive.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbinactive.ForeColor = System.Drawing.Color.Pink;
            this.cbinactive.Location = new System.Drawing.Point(108, 19);
            this.cbinactive.Name = "cbinactive";
            this.cbinactive.Size = new System.Drawing.Size(88, 22);
            this.cbinactive.TabIndex = 45;
            this.cbinactive.Text = "Inactive";
            this.cbinactive.UseVisualStyleBackColor = true;
            this.cbinactive.CheckedChanged += new System.EventHandler(this.cbinactive_CheckedChanged);
            // 
            // cbactive
            // 
            this.cbactive.AutoSize = true;
            this.cbactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbactive.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbactive.ForeColor = System.Drawing.Color.Pink;
            this.cbactive.Location = new System.Drawing.Point(27, 19);
            this.cbactive.Name = "cbactive";
            this.cbactive.Size = new System.Drawing.Size(72, 22);
            this.cbactive.TabIndex = 44;
            this.cbactive.Text = "Active";
            this.cbactive.UseVisualStyleBackColor = false;
            this.cbactive.CheckedChanged += new System.EventHandler(this.cbactive_CheckedChanged);
            // 
            // tbasicpay
            // 
            this.tbasicpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbasicpay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbasicpay.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbasicpay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbasicpay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tbasicpay.Location = new System.Drawing.Point(551, 216);
            this.tbasicpay.Name = "tbasicpay";
            this.tbasicpay.Size = new System.Drawing.Size(198, 19);
            this.tbasicpay.TabIndex = 98;
            this.tbasicpay.TextChanged += new System.EventHandler(this.tbasicpay_TextChanged);
            this.tbasicpay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbasicpay_KeyPress);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.ForeColor = System.Drawing.Color.Red;
            this.msg.Location = new System.Drawing.Point(394, 314);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(56, 22);
            this.msg.TabIndex = 95;
            this.msg.Text = "label1";
            this.msg.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(205, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 106;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gray;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(205, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 2);
            this.label14.TabIndex = 108;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gray;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Location = new System.Drawing.Point(205, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 2);
            this.label15.TabIndex = 109;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Gray;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Location = new System.Drawing.Point(205, 234);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 2);
            this.label16.TabIndex = 110;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Gray;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Location = new System.Drawing.Point(551, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 2);
            this.label17.TabIndex = 111;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Gray;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Location = new System.Drawing.Point(551, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 2);
            this.label18.TabIndex = 112;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Gray;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Location = new System.Drawing.Point(551, 238);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(200, 2);
            this.label19.TabIndex = 113;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Location = new System.Drawing.Point(205, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 2);
            this.label13.TabIndex = 107;
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Name",
            "Status",
            "Gender"});
            this.filter.Location = new System.Drawing.Point(699, 350);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(78, 24);
            this.filter.TabIndex = 116;
            this.filter.TabStop = false;
            this.filter.Text = "Sort By";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.maskedTextBox2.Location = new System.Drawing.Point(551, 79);
            this.maskedTextBox2.Mask = "0000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(198, 19);
            this.maskedTextBox2.TabIndex = 117;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox2.TextChanged += new System.EventHandler(this.maskedTextBox2_TextChanged);
            // 
            // temail
            // 
            this.temail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.temail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.temail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.temail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.temail.Location = new System.Drawing.Point(551, 126);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(198, 19);
            this.temail.TabIndex = 84;
            this.temail.TextChanged += new System.EventHandler(this.temail_TextChanged);
            // 
            // tage
            // 
            this.tage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tage.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tage.Cursor = System.Windows.Forms.Cursors.No;
            this.tage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tage.Location = new System.Drawing.Point(205, 123);
            this.tage.Name = "tage";
            this.tage.ReadOnly = true;
            this.tage.Size = new System.Drawing.Size(198, 19);
            this.tage.TabIndex = 118;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // searchemp
            // 
            this.searchemp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchemp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.searchemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.searchemp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.searchemp.ForeColor = System.Drawing.Color.Silver;
            this.searchemp.Location = new System.Drawing.Point(208, 361);
            this.searchemp.Name = "searchemp";
            this.searchemp.Size = new System.Drawing.Size(183, 26);
            this.searchemp.TabIndex = 119;
            this.searchemp.Text = "search...";
            this.searchemp.Click += new System.EventHandler(this.searchemp_Click);
            this.searchemp.Leave += new System.EventHandler(this.searchemp_Leave);
            this.searchemp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchemp_KeyUp);
            this.searchemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchemp_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(220, 610);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(408, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 124;
            this.statusStrip1.Text = "click";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.MergeIndex = 0;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(391, 17);
            this.toolStripStatusLabel1.Text = "*** Click Above Cell Content to Edit or Delete Employee Details ***";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // Emp_Add_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(851, 640);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchemp);
            this.Controls.Add(this.tage);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbasicpay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tdesgn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.taddr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ndelete);
            this.Controls.Add(this.nclear);
            this.Controls.Add(this.nupdate);
            this.Controls.Add(this.nadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emp_Add_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nadd;
        private System.Windows.Forms.Button nupdate;
        private System.Windows.Forms.Button nclear;
        private System.Windows.Forms.Button ndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tdesgn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox taddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbinactive;
        private System.Windows.Forms.CheckBox cbactive;
        private System.Windows.Forms.TextBox tbasicpay;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.TextBox tage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchemp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}