namespace WindowsApplication
{
    partial class Sale_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale_Order));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchitem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvinventoryd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchcno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvcustomerd = new System.Windows.Forms.DataGridView();
            this.btnplaceorder = new System.Windows.Forms.Button();
            this.dgvsaleorder = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventoryd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(525, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 189;
            this.label3.Text = "Select Customer Here :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 188;
            this.label1.Text = "Select Item Here :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.searchitem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvinventoryd);
            this.groupBox2.Location = new System.Drawing.Point(22, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 229);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(274, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 165;
            this.pictureBox2.TabStop = false;
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
            this.searchitem.Location = new System.Drawing.Point(116, 18);
            this.searchitem.Name = "searchitem";
            this.searchitem.Size = new System.Drawing.Size(183, 26);
            this.searchitem.TabIndex = 164;
            this.searchitem.Text = "search...";
            this.searchitem.Click += new System.EventHandler(this.searchitem_Click);
            this.searchitem.Leave += new System.EventHandler(this.searchitem_Leave);
            this.searchitem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchitem_KeyUp);
            this.searchitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchitem_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 163;
            this.label6.Text = "Item Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvinventoryd
            // 
            this.dgvinventoryd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvinventoryd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvinventoryd.Location = new System.Drawing.Point(16, 61);
            this.dgvinventoryd.Name = "dgvinventoryd";
            this.dgvinventoryd.Size = new System.Drawing.Size(450, 150);
            this.dgvinventoryd.TabIndex = 131;
            this.dgvinventoryd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinventoryd_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.searchcno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvcustomerd);
            this.groupBox1.Location = new System.Drawing.Point(528, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 229);
            this.groupBox1.TabIndex = 183;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 135;
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
            this.searchcno.Location = new System.Drawing.Point(120, 20);
            this.searchcno.Name = "searchcno";
            this.searchcno.Size = new System.Drawing.Size(183, 26);
            this.searchcno.TabIndex = 134;
            this.searchcno.Text = "search...";
            this.searchcno.Click += new System.EventHandler(this.searchcno_Click);
            this.searchcno.Leave += new System.EventHandler(this.searchcno_Leave);
            this.searchcno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchcno_KeyUp);
            this.searchcno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchcno_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 133;
            this.label4.Text = "Contact No.";
            // 
            // dgvcustomerd
            // 
            this.dgvcustomerd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcustomerd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvcustomerd.Location = new System.Drawing.Point(16, 61);
            this.dgvcustomerd.Name = "dgvcustomerd";
            this.dgvcustomerd.Size = new System.Drawing.Size(450, 150);
            this.dgvcustomerd.TabIndex = 132;
            this.dgvcustomerd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustomerd_CellContentClick);
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.BackColor = System.Drawing.Color.Green;
            this.btnplaceorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplaceorder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(175)))), ((int)(((byte)(56)))));
            this.btnplaceorder.FlatAppearance.BorderSize = 2;
            this.btnplaceorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplaceorder.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplaceorder.ForeColor = System.Drawing.Color.White;
            this.btnplaceorder.Location = new System.Drawing.Point(383, 287);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.Size = new System.Drawing.Size(121, 32);
            this.btnplaceorder.TabIndex = 181;
            this.btnplaceorder.Text = "Place Order";
            this.btnplaceorder.UseVisualStyleBackColor = false;
            this.btnplaceorder.Click += new System.EventHandler(this.btnplaceorder_Click);
            // 
            // dgvsaleorder
            // 
            this.dgvsaleorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsaleorder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvsaleorder.Location = new System.Drawing.Point(117, 385);
            this.dgvsaleorder.Name = "dgvsaleorder";
            this.dgvsaleorder.Size = new System.Drawing.Size(799, 185);
            this.dgvsaleorder.TabIndex = 179;
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
            this.btncancel.Location = new System.Drawing.Point(521, 287);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(121, 32);
            this.btncancel.TabIndex = 209;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(455, 343);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 212;
            this.pictureBox3.TabStop = false;
            // 
            // tsearch
            // 
            this.tsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tsearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tsearch.ForeColor = System.Drawing.Color.Silver;
            this.tsearch.Location = new System.Drawing.Point(297, 342);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(183, 26);
            this.tsearch.TabIndex = 211;
            this.tsearch.Text = "search...";
            this.tsearch.Click += new System.EventHandler(this.tsearch_Click);
            this.tsearch.Leave += new System.EventHandler(this.tsearch_Leave);
            this.tsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tsearch_KeyUp);
            this.tsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(114, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 210;
            this.label2.Text = "Contact No. / Item Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Sale_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1031, 582);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnplaceorder);
            this.Controls.Add(this.dgvsaleorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sale_Order";
            this.Text = "Sale_Order";
            this.Load += new System.EventHandler(this.Sale_Order_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventoryd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox searchitem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvinventoryd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvcustomerd;
        private System.Windows.Forms.Button btnplaceorder;
        private System.Windows.Forms.DataGridView dgvsaleorder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchcno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.Label label2;
    }
}