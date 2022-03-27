namespace WindowsApplication
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            this.email = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.supname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vsupname = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbactive = new System.Windows.Forms.CheckBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.msg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nadd = new System.Windows.Forms.Button();
            this.nupdate = new System.Windows.Forms.Button();
            this.nclear = new System.Windows.Forms.Button();
            this.ndelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbinactive = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cno = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.email.Location = new System.Drawing.Point(283, 91);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 19);
            this.email.TabIndex = 29;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.address.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.address.Location = new System.Drawing.Point(283, 180);
            this.address.Name = "address";
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.address.Size = new System.Drawing.Size(200, 19);
            this.address.TabIndex = 28;
            this.address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.address_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label6.Location = new System.Drawing.Point(185, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(213, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(211, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // supname
            // 
            this.supname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.supname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.supname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.supname.Location = new System.Drawing.Point(283, 47);
            this.supname.Name = "supname";
            this.supname.Size = new System.Drawing.Size(200, 19);
            this.supname.TabIndex = 24;
            this.supname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(199, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Full Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label8.Location = new System.Drawing.Point(71, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Supplier Name / ID";
            // 
            // vsupname
            // 
            this.vsupname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.vsupname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.vsupname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.vsupname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vsupname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.vsupname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.vsupname.ForeColor = System.Drawing.Color.Silver;
            this.vsupname.Location = new System.Drawing.Point(216, 302);
            this.vsupname.Name = "vsupname";
            this.vsupname.Size = new System.Drawing.Size(183, 26);
            this.vsupname.TabIndex = 37;
            this.vsupname.Text = "search...";
            this.vsupname.Click += new System.EventHandler(this.vsupname_Click);
            this.vsupname.Leave += new System.EventHandler(this.vsupname_Leave);
            this.vsupname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vsupname_KeyUp);
            this.vsupname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vsupname_KeyPress);
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Name",
            "Status"});
            this.filter.Location = new System.Drawing.Point(698, 299);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(78, 24);
            this.filter.TabIndex = 38;
            this.filter.TabStop = false;
            this.filter.Text = "Sort By";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbactive
            // 
            this.cbactive.AutoSize = true;
            this.cbactive.FlatAppearance.BorderSize = 0;
            this.cbactive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cbactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbactive.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbactive.ForeColor = System.Drawing.Color.Pink;
            this.errorProvider1.SetIconAlignment(this.cbactive, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider2.SetIconAlignment(this.cbactive, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.cbactive.Location = new System.Drawing.Point(31, 20);
            this.cbactive.Name = "cbactive";
            this.cbactive.Size = new System.Drawing.Size(72, 22);
            this.cbactive.TabIndex = 44;
            this.cbactive.Text = "Active";
            this.cbactive.UseVisualStyleBackColor = false;
            this.cbactive.CheckedChanged += new System.EventHandler(this.cbactive_CheckedChanged);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.ForeColor = System.Drawing.Color.Red;
            this.msg.Location = new System.Drawing.Point(302, 244);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(56, 22);
            this.msg.TabIndex = 39;
            this.msg.Text = "label1";
            this.msg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // nadd
            // 
            this.nadd.BackColor = System.Drawing.Color.Green;
            this.nadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(175)))), ((int)(((byte)(56)))));
            this.nadd.FlatAppearance.BorderSize = 2;
            this.nadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nadd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nadd.ForeColor = System.Drawing.Color.White;
            this.nadd.Location = new System.Drawing.Point(549, 50);
            this.nadd.Name = "nadd";
            this.nadd.Size = new System.Drawing.Size(80, 32);
            this.nadd.TabIndex = 31;
            this.nadd.Text = "Add";
            this.nadd.UseVisualStyleBackColor = false;
            this.nadd.Click += new System.EventHandler(this.nadd_Click);
            // 
            // nupdate
            // 
            this.nupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.nupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nupdate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.nupdate.FlatAppearance.BorderSize = 2;
            this.nupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nupdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdate.ForeColor = System.Drawing.Color.White;
            this.nupdate.Location = new System.Drawing.Point(549, 95);
            this.nupdate.Name = "nupdate";
            this.nupdate.Size = new System.Drawing.Size(80, 32);
            this.nupdate.TabIndex = 32;
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
            this.nclear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nclear.ForeColor = System.Drawing.Color.White;
            this.nclear.Location = new System.Drawing.Point(549, 185);
            this.nclear.Name = "nclear";
            this.nclear.Size = new System.Drawing.Size(80, 32);
            this.nclear.TabIndex = 33;
            this.nclear.Text = "Reset";
            this.nclear.UseVisualStyleBackColor = false;
            this.nclear.Click += new System.EventHandler(this.nclear_Click);
            // 
            // ndelete
            // 
            this.ndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.ndelete.FlatAppearance.BorderSize = 2;
            this.ndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ndelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndelete.ForeColor = System.Drawing.Color.White;
            this.ndelete.Location = new System.Drawing.Point(549, 140);
            this.ndelete.Name = "ndelete";
            this.ndelete.Size = new System.Drawing.Size(80, 32);
            this.ndelete.TabIndex = 34;
            this.ndelete.Text = "Delete";
            this.ndelete.UseVisualStyleBackColor = false;
            this.ndelete.Click += new System.EventHandler(this.ndelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbinactive);
            this.groupBox1.Controls.Add(this.cbactive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(459, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 44);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By";
            // 
            // cbinactive
            // 
            this.cbinactive.AutoSize = true;
            this.cbinactive.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbinactive.FlatAppearance.BorderSize = 0;
            this.cbinactive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cbinactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbinactive.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbinactive.ForeColor = System.Drawing.Color.LightPink;
            this.cbinactive.Location = new System.Drawing.Point(109, 20);
            this.cbinactive.Name = "cbinactive";
            this.cbinactive.Size = new System.Drawing.Size(88, 21);
            this.cbinactive.TabIndex = 45;
            this.cbinactive.Text = "Inactive";
            this.cbinactive.UseVisualStyleBackColor = false;
            this.cbinactive.CheckedChanged += new System.EventHandler(this.cbinactive_CheckedChanged);
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
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "click";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.MergeIndex = 0;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(382, 17);
            this.toolStripStatusLabel1.Text = "*** Click Above Cell Content to Edit or Delete Supplier Details ***";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(283, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 2);
            this.label1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(283, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(283, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 2);
            this.label7.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(283, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 2);
            this.label9.TabIndex = 50;
            // 
            // cno
            // 
            this.cno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cno.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cno.Location = new System.Drawing.Point(283, 136);
            this.cno.Mask = "0000000000";
            this.cno.Name = "cno";
            this.cno.Size = new System.Drawing.Size(198, 19);
            this.cno.TabIndex = 118;
            this.cno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cno.TextChanged += new System.EventHandler(this.cno_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridView1.Location = new System.Drawing.Point(41, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 220);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(851, 637);
            this.Controls.Add(this.cno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.vsupname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ndelete);
            this.Controls.Add(this.nclear);
            this.Controls.Add(this.nupdate);
            this.Controls.Add(this.nadd);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supname);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vsupname;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ndelete;
        private System.Windows.Forms.Button nclear;
        private System.Windows.Forms.Button nupdate;
        private System.Windows.Forms.Button nadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbinactive;
        private System.Windows.Forms.CheckBox cbactive;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider3;


    }
}