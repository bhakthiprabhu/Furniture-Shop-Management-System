namespace WindowsApplication
{
    partial class Purchase_Bill
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
            this.cbpurchaseorder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvpurchaseoraderd = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsupid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsupname = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgvpurchasebilld = new System.Windows.Forms.DataGridView();
            this.tprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tqty = new System.Windows.Forms.TextBox();
            this.twarranty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.ndelete = new System.Windows.Forms.Button();
            this.nupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btngeneratebil = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.ttamt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpurchaseoraderd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpurchasebilld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // cbpurchaseorder
            // 
            this.cbpurchaseorder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbpurchaseorder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbpurchaseorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbpurchaseorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbpurchaseorder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpurchaseorder.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cbpurchaseorder.FormattingEnabled = true;
            this.cbpurchaseorder.Location = new System.Drawing.Point(218, 46);
            this.cbpurchaseorder.Name = "cbpurchaseorder";
            this.cbpurchaseorder.Size = new System.Drawing.Size(198, 26);
            this.cbpurchaseorder.TabIndex = 115;
            this.cbpurchaseorder.Text = "Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(63, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 114;
            this.label3.Text = "Purchase Order No.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvpurchaseoraderd
            // 
            this.dgvpurchaseoraderd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpurchaseoraderd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvpurchaseoraderd.Location = new System.Drawing.Point(60, 88);
            this.dgvpurchaseoraderd.Name = "dgvpurchaseoraderd";
            this.dgvpurchaseoraderd.Size = new System.Drawing.Size(505, 150);
            this.dgvpurchaseoraderd.TabIndex = 132;
            this.dgvpurchaseoraderd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpurchaseoraderd_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(633, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 133;
            this.label5.Text = "Supplier Id";
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
            this.dateTimePicker1.Location = new System.Drawing.Point(640, 43);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 26);
            this.dateTimePicker1.TabIndex = 137;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 21, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label8.Location = new System.Drawing.Point(589, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 136;
            this.label8.Text = "Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(728, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 2);
            this.label1.TabIndex = 140;
            // 
            // tsupid
            // 
            this.tsupid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tsupid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsupid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tsupid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tsupid.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tsupid.Location = new System.Drawing.Point(728, 115);
            this.tsupid.Name = "tsupid";
            this.tsupid.ReadOnly = true;
            this.tsupid.Size = new System.Drawing.Size(200, 19);
            this.tsupid.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(606, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 143;
            this.label4.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(728, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 142;
            // 
            // tsupname
            // 
            this.tsupname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tsupname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsupname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tsupname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tsupname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tsupname.Location = new System.Drawing.Point(728, 164);
            this.tsupname.Name = "tsupname";
            this.tsupname.ReadOnly = true;
            this.tsupname.Size = new System.Drawing.Size(200, 19);
            this.tsupname.TabIndex = 141;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(877, 44);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(71, 28);
            this.btnsave.TabIndex = 168;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgvpurchasebilld
            // 
            this.dgvpurchasebilld.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpurchasebilld.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvpurchasebilld.Location = new System.Drawing.Point(383, 279);
            this.dgvpurchasebilld.Name = "dgvpurchasebilld";
            this.dgvpurchasebilld.Size = new System.Drawing.Size(455, 162);
            this.dgvpurchasebilld.TabIndex = 169;
            this.dgvpurchasebilld.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpurchasebilld_CellContentClick);
            // 
            // tprice
            // 
            this.tprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tprice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tprice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tprice.Location = new System.Drawing.Point(137, 324);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(200, 19);
            this.tprice.TabIndex = 178;
            this.tprice.TextChanged += new System.EventHandler(this.tprice_TextChanged);
            this.tprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tprice_KeyPress);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(137, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 2);
            this.label9.TabIndex = 177;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(137, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 2);
            this.label7.TabIndex = 176;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(137, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 2);
            this.label6.TabIndex = 175;
            // 
            // tqty
            // 
            this.tqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tqty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tqty.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tqty.Location = new System.Drawing.Point(137, 279);
            this.tqty.Name = "tqty";
            this.tqty.ReadOnly = true;
            this.tqty.Size = new System.Drawing.Size(200, 19);
            this.tqty.TabIndex = 174;
            this.tqty.TextChanged += new System.EventHandler(this.tqty_TextChanged);
            this.tqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tqty_KeyPress);
            // 
            // twarranty
            // 
            this.twarranty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.twarranty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.twarranty.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.twarranty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.twarranty.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.twarranty.Location = new System.Drawing.Point(137, 368);
            this.twarranty.MaxLength = 3;
            this.twarranty.Name = "twarranty";
            this.twarranty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.twarranty.Size = new System.Drawing.Size(200, 19);
            this.twarranty.TabIndex = 173;
            this.twarranty.TextChanged += new System.EventHandler(this.twarranty_TextChanged);
            this.twarranty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.twarranty_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label10.Location = new System.Drawing.Point(89, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 172;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label11.Location = new System.Drawing.Point(67, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 18);
            this.label11.TabIndex = 171;
            this.label11.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label12.Location = new System.Drawing.Point(65, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 18);
            this.label12.TabIndex = 170;
            this.label12.Text = "Warranty";
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.DeepPink;
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnext.Location = new System.Drawing.Point(184, 413);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(71, 28);
            this.btnnext.TabIndex = 179;
            this.btnnext.Text = "Add";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // ndelete
            // 
            this.ndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ndelete.Enabled = false;
            this.ndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.ndelete.FlatAppearance.BorderSize = 2;
            this.ndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ndelete.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.ndelete.ForeColor = System.Drawing.Color.White;
            this.ndelete.Location = new System.Drawing.Point(877, 368);
            this.ndelete.Name = "ndelete";
            this.ndelete.Size = new System.Drawing.Size(121, 32);
            this.ndelete.TabIndex = 181;
            this.ndelete.Text = "Remove Item";
            this.ndelete.UseVisualStyleBackColor = false;
            this.ndelete.Click += new System.EventHandler(this.ndelete_Click);
            // 
            // nupdate
            // 
            this.nupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.nupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nupdate.Enabled = false;
            this.nupdate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.nupdate.FlatAppearance.BorderSize = 2;
            this.nupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nupdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.nupdate.ForeColor = System.Drawing.Color.White;
            this.nupdate.Location = new System.Drawing.Point(877, 310);
            this.nupdate.Name = "nupdate";
            this.nupdate.Size = new System.Drawing.Size(121, 32);
            this.nupdate.TabIndex = 180;
            this.nupdate.Text = "Edit Item";
            this.nupdate.UseVisualStyleBackColor = false;
            this.nupdate.Click += new System.EventHandler(this.nupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(2)))));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btncancel.FlatAppearance.BorderSize = 2;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(624, 511);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(121, 32);
            this.btncancel.TabIndex = 183;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btngeneratebil
            // 
            this.btngeneratebil.BackColor = System.Drawing.Color.Green;
            this.btngeneratebil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeneratebil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(175)))), ((int)(((byte)(56)))));
            this.btngeneratebil.FlatAppearance.BorderSize = 2;
            this.btngeneratebil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeneratebil.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratebil.ForeColor = System.Drawing.Color.White;
            this.btngeneratebil.Location = new System.Drawing.Point(485, 511);
            this.btngeneratebil.Name = "btngeneratebil";
            this.btngeneratebil.Size = new System.Drawing.Size(121, 32);
            this.btngeneratebil.TabIndex = 182;
            this.btngeneratebil.Text = "Save";
            this.btngeneratebil.UseVisualStyleBackColor = false;
            this.btngeneratebil.Click += new System.EventHandler(this.btngeneratebil_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label13.Location = new System.Drawing.Point(65, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 14);
            this.label13.TabIndex = 184;
            this.label13.Text = "In years";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gray;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(569, 480);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 2);
            this.label14.TabIndex = 187;
            // 
            // ttamt
            // 
            this.ttamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ttamt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ttamt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ttamt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ttamt.Location = new System.Drawing.Point(569, 458);
            this.ttamt.Name = "ttamt";
            this.ttamt.ReadOnly = true;
            this.ttamt.Size = new System.Drawing.Size(200, 19);
            this.ttamt.TabIndex = 186;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label15.Location = new System.Drawing.Point(464, 459);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 18);
            this.label15.TabIndex = 185;
            this.label15.Text = "Total Amount";
            // 
            // Purchase_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1031, 582);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ttamt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btngeneratebil);
            this.Controls.Add(this.ndelete);
            this.Controls.Add(this.nupdate);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tqty);
            this.Controls.Add(this.twarranty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvpurchasebilld);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsupname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsupid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvpurchaseoraderd);
            this.Controls.Add(this.cbpurchaseorder);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase_Bill";
            this.Text = "Purchase_Bill";
            this.Load += new System.EventHandler(this.Purchase_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpurchaseoraderd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpurchasebilld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbpurchaseorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvpurchaseoraderd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsupid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tsupname;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvpurchasebilld;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tqty;
        private System.Windows.Forms.TextBox twarranty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button ndelete;
        private System.Windows.Forms.Button nupdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btngeneratebil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ttamt;
        private System.Windows.Forms.Label label15;
    }
}