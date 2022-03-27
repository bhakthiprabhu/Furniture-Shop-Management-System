namespace WindowsApplication
{
    partial class Purchase_Return
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
            this.cbpbno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvpurbil = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsupname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsupid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tqty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvpreturn = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.ndelete = new System.Windows.Forms.Button();
            this.nupdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpurbil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpreturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbpbno
            // 
            this.cbpbno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbpbno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbpbno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbpbno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbpbno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpbno.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cbpbno.FormattingEnabled = true;
            this.cbpbno.Location = new System.Drawing.Point(197, 73);
            this.cbpbno.Name = "cbpbno";
            this.cbpbno.Size = new System.Drawing.Size(198, 26);
            this.cbpbno.TabIndex = 117;
            this.cbpbno.Text = "Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(61, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 116;
            this.label3.Text = "Purchase Bill No.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvpurbil
            // 
            this.dgvpurbil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpurbil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvpurbil.Location = new System.Drawing.Point(64, 117);
            this.dgvpurbil.Name = "dgvpurbil";
            this.dgvpurbil.Size = new System.Drawing.Size(505, 150);
            this.dgvpurbil.TabIndex = 133;
            this.dgvpurbil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpurbil_CellContentClick);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(895, 74);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(71, 28);
            this.btnsave.TabIndex = 177;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(624, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 176;
            this.label4.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(746, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 175;
            // 
            // tsupname
            // 
            this.tsupname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tsupname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsupname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tsupname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tsupname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tsupname.Location = new System.Drawing.Point(746, 194);
            this.tsupname.Name = "tsupname";
            this.tsupname.ReadOnly = true;
            this.tsupname.Size = new System.Drawing.Size(200, 19);
            this.tsupname.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(746, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 2);
            this.label1.TabIndex = 173;
            // 
            // tsupid
            // 
            this.tsupid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tsupid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsupid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tsupid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tsupid.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tsupid.Location = new System.Drawing.Point(746, 145);
            this.tsupid.Name = "tsupid";
            this.tsupid.ReadOnly = true;
            this.tsupid.Size = new System.Drawing.Size(200, 19);
            this.tsupid.TabIndex = 172;
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
            this.dateTimePicker1.Location = new System.Drawing.Point(658, 73);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 26);
            this.dateTimePicker1.TabIndex = 171;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 21, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label8.Location = new System.Drawing.Point(607, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 170;
            this.label8.Text = "Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(651, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 169;
            this.label5.Text = "Supplier Id";
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.DeepPink;
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnext.Location = new System.Drawing.Point(162, 384);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(71, 28);
            this.btnnext.TabIndex = 181;
            this.btnnext.Text = "Add";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(134, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 2);
            this.label6.TabIndex = 180;
            // 
            // tqty
            // 
            this.tqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tqty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tqty.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tqty.Location = new System.Drawing.Point(134, 331);
            this.tqty.Name = "tqty";
            this.tqty.Size = new System.Drawing.Size(200, 19);
            this.tqty.TabIndex = 179;
            this.tqty.TextChanged += new System.EventHandler(this.tqty_TextChanged);
            this.tqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tqty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label7.Location = new System.Drawing.Point(64, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 178;
            this.label7.Text = "Quantity";
            // 
            // dgvpreturn
            // 
            this.dgvpreturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpreturn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvpreturn.Location = new System.Drawing.Point(351, 289);
            this.dgvpreturn.Name = "dgvpreturn";
            this.dgvpreturn.Size = new System.Drawing.Size(505, 168);
            this.dgvpreturn.TabIndex = 182;
            this.dgvpreturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpreturn_CellContentClick);
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
            this.btncancel.Location = new System.Drawing.Point(627, 492);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(147, 32);
            this.btncancel.TabIndex = 185;
            this.btncancel.Text = "Cancel Return";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Green;
            this.btnreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(175)))), ((int)(((byte)(56)))));
            this.btnreturn.FlatAppearance.BorderSize = 2;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.Color.White;
            this.btnreturn.Location = new System.Drawing.Point(461, 492);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(147, 32);
            this.btnreturn.TabIndex = 184;
            this.btnreturn.Text = "Return Purchase";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
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
            this.ndelete.Location = new System.Drawing.Point(876, 371);
            this.ndelete.Name = "ndelete";
            this.ndelete.Size = new System.Drawing.Size(121, 32);
            this.ndelete.TabIndex = 187;
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
            this.nupdate.Location = new System.Drawing.Point(876, 317);
            this.nupdate.Name = "nupdate";
            this.nupdate.Size = new System.Drawing.Size(121, 32);
            this.nupdate.TabIndex = 186;
            this.nupdate.Text = "Edit Item";
            this.nupdate.UseVisualStyleBackColor = false;
            this.nupdate.Click += new System.EventHandler(this.nupdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Purchase_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1031, 582);
            this.Controls.Add(this.ndelete);
            this.Controls.Add(this.nupdate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.dgvpreturn);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tqty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsupname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsupid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvpurbil);
            this.Controls.Add(this.cbpbno);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase_Return";
            this.Text = "Purchase_Return";
            this.Load += new System.EventHandler(this.Purchase_Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpurbil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpreturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbpbno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvpurbil;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tsupname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsupid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tqty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvpreturn;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button ndelete;
        private System.Windows.Forms.Button nupdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}