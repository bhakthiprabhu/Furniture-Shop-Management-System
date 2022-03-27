namespace WindowsApplication
{
    partial class btn_calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_calculate));
            this.cbempid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbasicpay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ttotaldays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textraleave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.thra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tpf = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tnetpay = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ttotalpay = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ttax = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.nadd = new System.Windows.Forms.Button();
            this.nclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchemp = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbempid
            // 
            this.cbempid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbempid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbempid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbempid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbempid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbempid.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cbempid.FormattingEnabled = true;
            this.cbempid.Location = new System.Drawing.Point(198, 35);
            this.cbempid.Name = "cbempid";
            this.cbempid.Size = new System.Drawing.Size(198, 26);
            this.cbempid.TabIndex = 113;
            this.cbempid.Text = "Select";
            this.cbempid.Leave += new System.EventHandler(this.cbempid_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(98, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 112;
            this.label3.Text = "Employee Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbmonth
            // 
            this.cbmonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbmonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbmonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmonth.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Location = new System.Drawing.Point(198, 133);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(198, 26);
            this.cbmonth.TabIndex = 145;
            this.cbmonth.Text = "Select";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label13.Location = new System.Drawing.Point(139, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 144;
            this.label13.Text = "Month";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.CustomFormat = "yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(198, 84);
            this.dateTimePicker2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(198, 26);
            this.dateTimePicker2.TabIndex = 147;
            this.dateTimePicker2.Value = new System.DateTime(2021, 6, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(152, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 146;
            this.label5.Text = "Year";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(571, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 150;
            // 
            // tname
            // 
            this.tname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tname.Cursor = System.Windows.Forms.Cursors.No;
            this.tname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tname.Location = new System.Drawing.Point(571, 34);
            this.tname.Name = "tname";
            this.tname.ReadOnly = true;
            this.tname.Size = new System.Drawing.Size(198, 19);
            this.tname.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(484, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 148;
            this.label1.Text = "Full Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Gray;
            this.label19.Cursor = System.Windows.Forms.Cursors.No;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Location = new System.Drawing.Point(573, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(200, 2);
            this.label19.TabIndex = 156;
            // 
            // tbasicpay
            // 
            this.tbasicpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbasicpay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbasicpay.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbasicpay.Cursor = System.Windows.Forms.Cursors.No;
            this.tbasicpay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbasicpay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tbasicpay.Location = new System.Drawing.Point(573, 84);
            this.tbasicpay.Name = "tbasicpay";
            this.tbasicpay.ReadOnly = true;
            this.tbasicpay.Size = new System.Drawing.Size(198, 19);
            this.tbasicpay.TabIndex = 155;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.No;
            this.label12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label12.Location = new System.Drawing.Point(491, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 154;
            this.label12.Text = "Basic Pay";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(571, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 2);
            this.label6.TabIndex = 162;
            // 
            // ttotaldays
            // 
            this.ttotaldays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ttotaldays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttotaldays.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ttotaldays.Cursor = System.Windows.Forms.Cursors.No;
            this.ttotaldays.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ttotaldays.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ttotaldays.Location = new System.Drawing.Point(571, 133);
            this.ttotaldays.Name = "ttotaldays";
            this.ttotaldays.ReadOnly = true;
            this.ttotaldays.Size = new System.Drawing.Size(198, 19);
            this.ttotaldays.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.No;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label7.Location = new System.Drawing.Point(487, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 160;
            this.label7.Text = "Total Days";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Cursor = System.Windows.Forms.Cursors.No;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(571, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 2);
            this.label9.TabIndex = 165;
            // 
            // textraleave
            // 
            this.textraleave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textraleave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textraleave.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textraleave.Cursor = System.Windows.Forms.Cursors.No;
            this.textraleave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.textraleave.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textraleave.Location = new System.Drawing.Point(571, 182);
            this.textraleave.Name = "textraleave";
            this.textraleave.ReadOnly = true;
            this.textraleave.Size = new System.Drawing.Size(198, 19);
            this.textraleave.TabIndex = 164;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.No;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label10.Location = new System.Drawing.Point(468, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 163;
            this.label10.Text = "Extra Leave";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gray;
            this.label14.Cursor = System.Windows.Forms.Cursors.No;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(198, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 2);
            this.label14.TabIndex = 168;
            // 
            // thra
            // 
            this.thra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.thra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thra.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.thra.Cursor = System.Windows.Forms.Cursors.No;
            this.thra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.thra.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.thra.Location = new System.Drawing.Point(198, 228);
            this.thra.Name = "thra";
            this.thra.ReadOnly = true;
            this.thra.Size = new System.Drawing.Size(198, 19);
            this.thra.TabIndex = 167;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.No;
            this.label15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label15.Location = new System.Drawing.Point(145, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 18);
            this.label15.TabIndex = 166;
            this.label15.Text = "H.R.A";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Gray;
            this.label18.Cursor = System.Windows.Forms.Cursors.No;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Location = new System.Drawing.Point(198, 296);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 2);
            this.label18.TabIndex = 171;
            // 
            // tpf
            // 
            this.tpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tpf.Cursor = System.Windows.Forms.Cursors.No;
            this.tpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tpf.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tpf.Location = new System.Drawing.Point(198, 274);
            this.tpf.Name = "tpf";
            this.tpf.ReadOnly = true;
            this.tpf.Size = new System.Drawing.Size(198, 19);
            this.tpf.TabIndex = 170;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.No;
            this.label20.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label20.Location = new System.Drawing.Point(74, 278);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 18);
            this.label20.TabIndex = 169;
            this.label20.Text = "Provident Fund";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Gray;
            this.label23.Cursor = System.Windows.Forms.Cursors.No;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Location = new System.Drawing.Point(571, 296);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 2);
            this.label23.TabIndex = 177;
            // 
            // tnetpay
            // 
            this.tnetpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tnetpay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnetpay.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tnetpay.Cursor = System.Windows.Forms.Cursors.No;
            this.tnetpay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tnetpay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tnetpay.Location = new System.Drawing.Point(571, 274);
            this.tnetpay.Name = "tnetpay";
            this.tnetpay.ReadOnly = true;
            this.tnetpay.Size = new System.Drawing.Size(198, 19);
            this.tnetpay.TabIndex = 176;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Cursor = System.Windows.Forms.Cursors.No;
            this.label24.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label24.Location = new System.Drawing.Point(503, 279);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 18);
            this.label24.TabIndex = 175;
            this.label24.Text = "Net Pay";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Gray;
            this.label21.Cursor = System.Windows.Forms.Cursors.No;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Location = new System.Drawing.Point(571, 250);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(200, 2);
            this.label21.TabIndex = 182;
            // 
            // ttotalpay
            // 
            this.ttotalpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ttotalpay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttotalpay.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ttotalpay.Cursor = System.Windows.Forms.Cursors.No;
            this.ttotalpay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ttotalpay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ttotalpay.Location = new System.Drawing.Point(571, 228);
            this.ttotalpay.Name = "ttotalpay";
            this.ttotalpay.ReadOnly = true;
            this.ttotalpay.Size = new System.Drawing.Size(198, 19);
            this.ttotalpay.TabIndex = 181;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.No;
            this.label22.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label22.Location = new System.Drawing.Point(493, 234);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 18);
            this.label22.TabIndex = 180;
            this.label22.Text = "Total Pay";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Gray;
            this.label25.Cursor = System.Windows.Forms.Cursors.No;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Location = new System.Drawing.Point(198, 204);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(200, 2);
            this.label25.TabIndex = 185;
            // 
            // ttax
            // 
            this.ttax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ttax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttax.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ttax.Cursor = System.Windows.Forms.Cursors.No;
            this.ttax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ttax.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ttax.Location = new System.Drawing.Point(198, 182);
            this.ttax.Name = "ttax";
            this.ttax.ReadOnly = true;
            this.ttax.Size = new System.Drawing.Size(198, 19);
            this.ttax.TabIndex = 184;
            this.ttax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbonus_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Cursor = System.Windows.Forms.Cursors.No;
            this.label26.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label26.Location = new System.Drawing.Point(159, 187);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 18);
            this.label26.TabIndex = 183;
            this.label26.Text = "Tax";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.nadd.Location = new System.Drawing.Point(249, 328);
            this.nadd.Name = "nadd";
            this.nadd.Size = new System.Drawing.Size(97, 32);
            this.nadd.TabIndex = 186;
            this.nadd.Text = "Generate";
            this.nadd.UseVisualStyleBackColor = false;
            this.nadd.Click += new System.EventHandler(this.nadd_Click);
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
            this.nclear.Location = new System.Drawing.Point(496, 328);
            this.nclear.Name = "nclear";
            this.nclear.Size = new System.Drawing.Size(85, 32);
            this.nclear.TabIndex = 187;
            this.nclear.Text = "Reset";
            this.nclear.UseVisualStyleBackColor = false;
            this.nclear.Click += new System.EventHandler(this.nclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Teal;
            this.btncalculate.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncalculate.Location = new System.Drawing.Point(371, 328);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(98, 32);
            this.btncalculate.TabIndex = 188;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 194;
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
            this.searchemp.Location = new System.Drawing.Point(213, 398);
            this.searchemp.Name = "searchemp";
            this.searchemp.Size = new System.Drawing.Size(183, 26);
            this.searchemp.TabIndex = 193;
            this.searchemp.Text = "search...";
            this.searchemp.Click += new System.EventHandler(this.searchemp_Click);
            this.searchemp.Leave += new System.EventHandler(this.searchemp_Leave);
            this.searchemp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchemp_KeyUp);
            this.searchemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchemp_KeyPress);
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
            "Year",
            "Month"});
            this.filter.Location = new System.Drawing.Point(694, 395);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(78, 24);
            this.filter.TabIndex = 192;
            this.filter.TabStop = false;
            this.filter.Text = "Sort By";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(111, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 190;
            this.label4.Text = "Employee ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 188);
            this.dataGridView1.TabIndex = 189;
            // 
            // btn_calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(851, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchemp);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.nclear);
            this.Controls.Add(this.nadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ttotaldays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textraleave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ttax);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.ttotalpay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tbasicpay);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tnetpay);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tpf);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.thra);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbmonth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbempid);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btn_calculate";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Emp_Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbempid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmonth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbasicpay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttotaldays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textraleave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox thra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tpf;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tnetpay;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox ttotalpay;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox ttax;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button nadd;
        private System.Windows.Forms.Button nclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchemp;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}