using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsApplication
{
    public partial class Admin_Create : Form
    {
        public Admin_Create()
        {
            InitializeComponent();
        }

        private void Admin_Create_Load(object sender, EventArgs e)
        {
            this.Text = "Admin Creation";
        }

        private void temail_TextChanged(object sender, EventArgs e)
        {
            //email text changed
            errorProvider1.Clear();
        }

        private void tRetype_KeyUp(object sender, KeyEventArgs e)
        {
            //Retypepassword_KeyUp
            if (tpassword.Text == tRetype.Text)
            {
                msg.Visible = true;
                msg.ForeColor = Color.Lime;
                msg.Text = "Matched!";
            }
            else
            {
                msg.Visible = true;
                msg.ForeColor = Color.Red;
                msg.Text = "Not Matched!";
            }
        }

        private void tpassword_TextChanged(object sender, EventArgs e)
        {
            if (tpassword.Text == tRetype.Text)
            {
                msg.Visible = true;
                msg.ForeColor = Color.Lime;
                msg.Text = "Matched!";
            }
            else
            {
                msg.Visible = true;
                msg.ForeColor = Color.Red;
                msg.Text = "Not Matched!";
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            //signup
            try
            {
                if (comboBox1.SelectedItem.ToString() == "" || tsans.Text == "" || tlname.Text == "" || tfname.Text == "" || temail.Text == "" || tpassword.Text == "" || tRetype.Text == "" || comboBox1.Text == "" || tsans.Text == "" || comboBox1.Text == "Select")
                    throw new ArgumentException();
                else
                {
                    new MailAddress(this.temail.Text);
                    if (tpassword.Text.Length <= 7)
                        MessageBox.Show("Password Must be atleast 8 characters long!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (tpassword.Text != tRetype.Text)
                    {
                        msg.Visible = true;
                        msg.ForeColor = Color.Red;
                        msg.Text = "Not Matched!";
                    }
                    else
                    {
                        Connect c = new Connect();
                        c.cmd.CommandText = "insert into Admin_Create values('" + tfname.Text + "','" + tlname.Text + "','" + temail.Text + "','" + tusername.Text + "','" + tpassword.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + tsans.Text + "')";
                        c.cmd.ExecuteNonQuery();
                        this.Hide();
                        new Login_User().Show();
                    }
                }
            }
            catch (FormatException)
            {
                errorProvider1.SetError(temail, "Enter valid format Email");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clear
            tfname.Text = "";
            tlname.Text = "";
            temail.Text = "";
            tusername.Text = "";
            tpassword.Text = "";
            tRetype.Text = "";
            tsans.Text = "";
            comboBox1.ResetText();
            comboBox1.Text = "Select";
            msg.Visible = false;
            msg.ForeColor = Color.Red;
            tusername.Text = "admin";
            tusername.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            msg.Visible = false;
        }

        private void tfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '.');
        }

        private void tlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '.');
        }

    }
}