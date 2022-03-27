namespace WindowsApplication
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tqty = new System.Windows.Forms.TextBox();
            this.twarranty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titemname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tmaterial = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tcolor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tprice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.ndelete = new System.Windows.Forms.Button();
            this.nclear = new System.Windows.Forms.Button();
            this.nupdate = new System.Windows.Forms.Button();
            this.nadd = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchitem = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbinactive = new System.Windows.Forms.CheckBox();
            this.cbactive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(181, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 2);
            this.label9.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(181, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 2);
            this.label7.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(181, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(181, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 2);
            this.label1.TabIndex = 126;
            // 
            // tqty
            // 
            this.tqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tqty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tqty.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tqty.Location = new System.Drawing.Point(181, 94);
            this.tqty.Name = "tqty";
            this.tqty.Size = new System.Drawing.Size(200, 19);
            this.tqty.TabIndex = 125;
            this.tqty.Text = "0";
            this.tqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tqty_KeyPress);
            // 
            // twarranty
            // 
            this.twarranty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.twarranty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.twarranty.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.twarranty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.twarranty.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.twarranty.Location = new System.Drawing.Point(181, 183);
            this.twarranty.Name = "twarranty";
            this.twarranty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.twarranty.Size = new System.Drawing.Size(200, 19);
            this.twarranty.TabIndex = 124;
            this.twarranty.Text = "0.0";
            this.twarranty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.twarranty_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label6.Location = new System.Drawing.Point(133, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 123;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(111, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 122;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(111, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 121;
            this.label4.Text = "Warranty";
            // 
            // titemname
            // 
            this.titemname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.titemname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titemname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.titemname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titemname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.titemname.Location = new System.Drawing.Point(181, 50);
            this.titemname.Name = "titemname";
            this.titemname.Size = new System.Drawing.Size(200, 19);
            this.titemname.TabIndex = 120;
            this.titemname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.titemname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(97, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 119;
            this.label3.Text = "Item Name";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(509, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 2);
            this.label11.TabIndex = 139;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(509, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 2);
            this.label12.TabIndex = 138;
            // 
            // tmaterial
            // 
            this.tmaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tmaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tmaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tmaterial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tmaterial.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tmaterial.Location = new System.Drawing.Point(509, 183);
            this.tmaterial.Name = "tmaterial";
            this.tmaterial.Size = new System.Drawing.Size(200, 19);
            this.tmaterial.TabIndex = 137;
            this.tmaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tmaterial_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.Location = new System.Drawing.Point(507, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(200, 19);
            this.textBox2.TabIndex = 136;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label14.Location = new System.Drawing.Point(438, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 18);
            this.label14.TabIndex = 134;
            this.label14.Text = "Material";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label15.Location = new System.Drawing.Point(460, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 18);
            this.label15.TabIndex = 133;
            this.label15.Text = "Date";
            // 
            // tcolor
            // 
            this.tcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tcolor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcolor.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tcolor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcolor.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tcolor.Location = new System.Drawing.Point(509, 139);
            this.tcolor.Name = "tcolor";
            this.tcolor.Size = new System.Drawing.Size(200, 19);
            this.tcolor.TabIndex = 132;
            this.tcolor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcolor_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label16.Location = new System.Drawing.Point(456, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 18);
            this.label16.TabIndex = 131;
            this.label16.Text = "Color";
            // 
            // tprice
            // 
            this.tprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tprice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tprice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tprice.Location = new System.Drawing.Point(181, 139);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(200, 19);
            this.tprice.TabIndex = 143;
            this.tprice.Text = "0.0";
            this.tprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tprice_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label18.Location = new System.Drawing.Point(429, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 18);
            this.label18.TabIndex = 145;
            this.label18.Text = "Category";
            // 
            // cbcategory
            // 
            this.cbcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategory.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.IntegralHeight = false;
            this.cbcategory.Items.AddRange(new object[] {
            "Couch",
            "Bed",
            "Chair",
            "Coffee table",
            "Desk",
            "Chest of drawers",
            "Ottoman",
            "Nightstand",
            "Recliner",
            "Chaise longue",
            "Mattress",
            "Loveseat",
            "Stool",
            "Console table",
            "Sleeper sofa",
            "Accent chairs",
            "Dining chairs",
            "Sectional sofa"});
            this.cbcategory.Location = new System.Drawing.Point(512, 97);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(200, 24);
            this.cbcategory.TabIndex = 148;
            this.cbcategory.Text = "Select";
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
            this.ndelete.Location = new System.Drawing.Point(441, 243);
            this.ndelete.Name = "ndelete";
            this.ndelete.Size = new System.Drawing.Size(85, 32);
            this.ndelete.TabIndex = 155;
            this.ndelete.Text = "Delete";
            this.ndelete.UseVisualStyleBackColor = false;
            this.ndelete.Click += new System.EventHandler(this.ndelete_Click);
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
            this.nclear.Location = new System.Drawing.Point(582, 243);
            this.nclear.Name = "nclear";
            this.nclear.Size = new System.Drawing.Size(85, 32);
            this.nclear.TabIndex = 154;
            this.nclear.Text = "Reset";
            this.nclear.UseVisualStyleBackColor = false;
            this.nclear.Click += new System.EventHandler(this.nclear_Click);
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
            this.nupdate.Location = new System.Drawing.Point(303, 243);
            this.nupdate.Name = "nupdate";
            this.nupdate.Size = new System.Drawing.Size(85, 32);
            this.nupdate.TabIndex = 153;
            this.nupdate.Text = "Update";
            this.nupdate.UseVisualStyleBackColor = false;
            this.nupdate.Click += new System.EventHandler(this.nupdate_Click);
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
            this.nadd.Location = new System.Drawing.Point(165, 243);
            this.nadd.Name = "nadd";
            this.nadd.Size = new System.Drawing.Size(85, 32);
            this.nadd.TabIndex = 152;
            this.nadd.Text = "Add";
            this.nadd.UseVisualStyleBackColor = false;
            this.nadd.Click += new System.EventHandler(this.nadd_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.ForeColor = System.Drawing.Color.Red;
            this.msg.Location = new System.Drawing.Point(379, 300);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(56, 22);
            this.msg.TabIndex = 156;
            this.msg.Text = "label1";
            this.msg.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(241, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(404, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 163;
            this.statusStrip1.Text = "click";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.MergeIndex = 0;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(387, 17);
            this.toolStripStatusLabel1.Text = "*** Click Above Cell Content to Edit or Delete Inventory Details ***";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // searchitem
            // 
            this.searchitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.searchitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchitem.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.searchitem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.searchitem.ForeColor = System.Drawing.Color.Silver;
            this.searchitem.Location = new System.Drawing.Point(151, 358);
            this.searchitem.Name = "searchitem";
            this.searchitem.Size = new System.Drawing.Size(183, 26);
            this.searchitem.TabIndex = 161;
            this.searchitem.Text = "search...";
            this.searchitem.Click += new System.EventHandler(this.searchitem_Click);
            this.searchitem.Leave += new System.EventHandler(this.searchitem_Leave);
            this.searchitem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchitem_KeyUp);
            this.searchitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchitem_KeyPress);
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
            "Status"});
            this.filter.Location = new System.Drawing.Point(696, 355);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(78, 24);
            this.filter.TabIndex = 160;
            this.filter.TabStop = false;
            this.filter.Text = "Sort By";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbinactive);
            this.groupBox1.Controls.Add(this.cbactive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(467, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 44);
            this.groupBox1.TabIndex = 159;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label8.Location = new System.Drawing.Point(55, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 158;
            this.label8.Text = "Item Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 50);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 26);
            this.dateTimePicker1.TabIndex = 164;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 21, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridView1.Location = new System.Drawing.Point(43, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 209);
            this.dataGridView1.TabIndex = 165;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinventoryd_CellContentClick);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(851, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchitem);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.ndelete);
            this.Controls.Add(this.nclear);
            this.Controls.Add(this.nupdate);
            this.Controls.Add(this.nadd);
            this.Controls.Add(this.cbcategory);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tmaterial);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tcolor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tqty);
            this.Controls.Add(this.twarranty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titemname);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tqty;
        private System.Windows.Forms.TextBox twarranty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titemname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tmaterial;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tcolor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Button ndelete;
        private System.Windows.Forms.Button nclear;
        private System.Windows.Forms.Button nupdate;
        private System.Windows.Forms.Button nadd;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchitem;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbinactive;
        private System.Windows.Forms.CheckBox cbactive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}