namespace WindowsApplication
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.tname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.temail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nclear = new System.Windows.Forms.Button();
            this.nadd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nupdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchcno = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tname
            // 
            this.tname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tname.Location = new System.Drawing.Point(314, 60);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(198, 19);
            this.tname.TabIndex = 73;
            this.tname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(230, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Full Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taddr
            // 
            this.taddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.taddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.taddr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.taddr.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.taddr.Location = new System.Drawing.Point(314, 107);
            this.taddr.Name = "taddr";
            this.taddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taddr.Size = new System.Drawing.Size(198, 19);
            this.taddr.TabIndex = 80;
            this.taddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taddr_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(242, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // temail
            // 
            this.temail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.temail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.temail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.temail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.temail.Location = new System.Drawing.Point(314, 201);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(198, 19);
            this.temail.TabIndex = 88;
            this.temail.TextChanged += new System.EventHandler(this.temail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(243, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 86;
            this.label5.Text = "Email ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(216, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 85;
            this.label4.Text = "Contact No.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.nclear.Location = new System.Drawing.Point(560, 194);
            this.nclear.Name = "nclear";
            this.nclear.Size = new System.Drawing.Size(80, 32);
            this.nclear.TabIndex = 91;
            this.nclear.Text = "Reset";
            this.nclear.UseVisualStyleBackColor = false;
            this.nclear.Click += new System.EventHandler(this.nclear_Click);
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
            this.nadd.Location = new System.Drawing.Point(560, 71);
            this.nadd.Name = "nadd";
            this.nadd.Size = new System.Drawing.Size(80, 32);
            this.nadd.TabIndex = 89;
            this.nadd.Text = "Add";
            this.nadd.UseVisualStyleBackColor = false;
            this.nadd.Click += new System.EventHandler(this.nadd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label8.Location = new System.Drawing.Point(80, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 94;
            this.label8.Text = "Contact No.";
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
            this.nupdate.Location = new System.Drawing.Point(560, 132);
            this.nupdate.Name = "nupdate";
            this.nupdate.Size = new System.Drawing.Size(80, 32);
            this.nupdate.TabIndex = 100;
            this.nupdate.Text = "Update";
            this.nupdate.UseVisualStyleBackColor = false;
            this.nupdate.Click += new System.EventHandler(this.nupdate_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(314, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 2);
            this.label9.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(314, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(314, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 2);
            this.label6.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(314, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 2);
            this.label7.TabIndex = 106;
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
            "Address"});
            this.filter.Location = new System.Drawing.Point(691, 323);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(78, 24);
            this.filter.TabIndex = 109;
            this.filter.TabStop = false;
            this.filter.Text = "Sort By";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.maskedTextBox2.Location = new System.Drawing.Point(314, 154);
            this.maskedTextBox2.Mask = "0000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(198, 19);
            this.maskedTextBox2.TabIndex = 118;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox2.TextChanged += new System.EventHandler(this.maskedTextBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // searchcno
            // 
            this.searchcno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchcno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchcno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.searchcno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchcno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.searchcno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.searchcno.ForeColor = System.Drawing.Color.Silver;
            this.searchcno.Location = new System.Drawing.Point(177, 320);
            this.searchcno.Name = "searchcno";
            this.searchcno.Size = new System.Drawing.Size(183, 26);
            this.searchcno.TabIndex = 121;
            this.searchcno.Text = "search...";
            this.searchcno.Click += new System.EventHandler(this.searchcno_Click);
            this.searchcno.Leave += new System.EventHandler(this.searchcno_Leave);
            this.searchcno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchcno_KeyUp);
            this.searchcno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vsupname_KeyPress);
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
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 123;
            this.statusStrip1.Text = "click";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.MergeIndex = 0;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(332, 17);
            this.toolStripStatusLabel1.Text = "*** Click Above Cell Content to Edit Customer Details ***";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridView1.Location = new System.Drawing.Point(44, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 220);
            this.dataGridView1.TabIndex = 124;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(851, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchcno);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nupdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nclear);
            this.Controls.Add(this.nadd);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taddr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button nclear;
        private System.Windows.Forms.Button nadd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button nupdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchcno;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}