using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Password_Reset : Form
    {
        Connect c = new Connect();
        string sans;
        int i = 0;
        public Password_Reset()
        {
            InitializeComponent();
        }

        private void Password_Reset_Load(object sender, EventArgs e)
        {
            this.Text = "Forgot Password";
            this.Location = new Point(500, 200);
            this.Size = new Size(320, 380);
            Connect c = new Connect();
            c.cmd.CommandText = "select sqns from Admin_Create";
            lsqns.Text = Convert.ToString(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select sans from Admin_Create";
            sans = Convert.ToString(c.cmd.ExecuteScalar());
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(back,"Back");
        }

        private void tsans_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void fconfirm_Click(object sender, EventArgs e)
        {
            //confirm button
            if (tsans.Text == "")
                errorProvider1.SetError(tsans, "Required!");
            else if (tsans.Text == sans)
            {
                this.Text = "Reset Password";
                this.Size = new Size(659, 380);
                tsans.ReadOnly = true;
                tsans.Cursor = Cursors.No;
                fconfirm.Enabled = false;
                fconfirm.Cursor = Cursors.No;
                linkLabel1.Enabled = false;
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(350, 200);
            }
            else
            {
                i++;
                MessageBox.Show("Incorrect Answer", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (i > 2)
                {
                    this.Hide();
                    new Login_User().Show();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //forgot security answer
            linkLabel1.Cursor = Cursors.WaitCursor;
            Sans_Reset sr = new Sans_Reset();
            sr.Owner = this;
            sr.Show();
            linkLabel1.Cursor = Cursors.Default;
        }

        private void back_Click(object sender, EventArgs e)
        {
            //back
            this.Hide();
            new Login_User().Show();
        }

        private void tnewpassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void rconfirm_Click(object sender, EventArgs e)
        {
            //confirm button
            c.cmd.CommandText = "select password from Admin_Create";
            String password = Convert.ToString(c.cmd.ExecuteScalar());
            if (tnewpassword.Text == "")
                errorProvider2.SetError(tnewpassword, "Required!");
            else if(tnewpassword.Text.Length<=7)
                MessageBox.Show("Password Must be atleast 8 characters long!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    c.cmd.CommandText = "update Admin_Create set password ='" + tnewpassword.Text + "'";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Changed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Login_User().Show();
                }
            }
        }
    }
}