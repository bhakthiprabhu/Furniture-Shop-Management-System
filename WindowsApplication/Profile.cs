using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace WindowsApplication
{
    public partial class Profile : Form
    {
        Connect c = new Connect();
        String password, otp;
        int num;
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select fname from Admin_Create";
            String fname = Convert.ToString(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select lname from Admin_Create";
            String lname = Convert.ToString(c.cmd.ExecuteScalar());
            tfullname.Text = fname + " " + lname;
            c.cmd.CommandText = "select email from Admin_Create";
            temail.Text = Convert.ToString(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select username from Admin_Create";
            tusername.Text = Convert.ToString(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select password from Admin_Create";
            password = Convert.ToString(c.cmd.ExecuteScalar());
        }

        private void edit_Click(object sender, EventArgs e)
        {
            //edit
            temail.ReadOnly = false;
            edit.Visible = false;
            pictureBox1.Visible = false;
            temail.Cursor = Cursors.IBeam;
            esave.Enabled = true;
            esave.BackColor = Color.Black;
        }

        private void temail_TextChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void esave_Click(object sender, EventArgs e)
        {
            //save
            try
            {
                if (temail.Text == "")
                    errorProvider4.SetError(temail, "Required!");
                else
                {
                    new MailAddress(this.temail.Text);
                    temail.ReadOnly = true;
                    edit.Visible = true;
                    pictureBox1.Visible = true;
                    temail.Cursor = Cursors.No;
                    esave.Enabled = false;
                    esave.BackColor = Color.Gray;
                    c.cmd.CommandText = "update Admin_Create set email='" + temail.Text + "'";
                    c.cmd.ExecuteNonQuery();
                }
            }
            catch (FormatException)
            {
                errorProvider4.SetError(temail, "Enter valid format Email");
            }
        }

        private void clearall()
        {
            tcurr.Text = "";
            errcpass.Visible = false;
            totp.Text = "";
            errotp.Visible = false;
            tnew.Text = "";
            tcnew.Text = "";
            errmsg.Visible = false;
        }

        private void changepassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //change password
            groupBox2.Visible = true;
            pcurrentpass.Visible = true;
            groupBox2.Size = new Size(336, 155);
            clearall();
        }

        private void ceye_MouseHover(object sender, EventArgs e)
        {
            tcurr.UseSystemPasswordChar = false;
        }

        private void ceye_MouseLeave(object sender, EventArgs e)
        {
            tcurr.UseSystemPasswordChar = true;
        }

        private void verifypass_Click(object sender, EventArgs e)
        {
            //verify current password
            c.cmd.CommandText = "select password from Admin_Create";
            password = Convert.ToString(c.cmd.ExecuteScalar());
            if (tcurr.Text == "")
                errorProvider1.SetError(tcurr, "Required!");
            else if (tcurr.Text != password)
            {
                errcpass.Visible = true;
                errcpass.Text = "Invalid Password!";
                pcurrentpass.Cursor = Cursors.Default;
            }
            else if (tcurr.Text == password)
            {
                groupBox2.Size = new Size(330, 245);
                pcurrentpass.Visible = false;
                pnewpass.Visible = true;
                clearall();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //forgot current password
            pcurrentpass.Cursor = Cursors.WaitCursor;
            try
            {
                c.cmd.CommandText = "select email from Admin_Create";
                String email = Convert.ToString(c.cmd.ExecuteScalar());
                Random r = new Random();
                num = r.Next(0, 1000000);
                otp = num.ToString("000000");
                MailMessage mail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("bhakthiprabhu15@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Verify Profile - OTP";
                mail.Body = "Please enter the OTP mentioned below to verify your profile.\n\n"+otp+"\n\nPlease don't share your OTP with anyone.";
                smtpserver.Port = 587;
                smtpserver.Credentials = new NetworkCredential("bhakthiprabhu15@gmail.com", "bhakthi15");
                smtpserver.EnableSsl = true;
                smtpserver.Send(mail);
                potp.Visible = true;
                groupBox2.Size = new Size(336, 155);
                pcurrentpass.Visible = false;
            }
            catch (Exception)
            {
                errcpass.Visible = true;
                errcpass.Text = "No Internet Connection!";
                pcurrentpass.Cursor = Cursors.Default;
            }
        }

        private void totp_TextChanged(object sender, EventArgs e)
        {
            errotp.Visible = false;
        }

        private void verifyotp_Click(object sender, EventArgs e)
        {
            //verify otp
            potp.Cursor = Cursors.WaitCursor;
            if (totp.Text == otp)
            {
                groupBox2.Size = new Size(330, 245);
                potp.Visible = false;
                pnewpass.Visible = true;
                clearall();
            }
            else
            {
                errotp.Visible = true;
                errotp.Text = "Invalid OTP!";
                pcurrentpass.Cursor = Cursors.Default;
            }     
        }

        private void tnew_Leave(object sender, EventArgs e)
        {
            if (tnew.Text.Length <= 7)
            {
                errmsg.Visible = true;
                errmsg.Text = "Be atleast 8 characters!";
            }
        } 

        private void tnew_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            errmsg.Visible = false;
        }

        private void neye_MouseHover(object sender, EventArgs e)
        {
            tcnew.UseSystemPasswordChar = false;
        }

        private void neye_MouseLeave(object sender, EventArgs e)
        {
            tcnew.UseSystemPasswordChar = true;
        }

        private void tcurr_TextChanged(object sender, EventArgs e)
        {
            errcpass.Visible = false;
            errorProvider1.Clear();
        }

        private void tcnew_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
            errmsg.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            //update password  
            if (tnew.Text == "")
                errorProvider2.SetError(tnew, "Required!");
            else if (tcnew.Text == "")
                errorProvider3.SetError(tcnew, "Required!");
            else if (tnew.Text != tcnew.Text)
            {
                errmsg.Visible = true;
                errmsg.Text = "Password must match!";
            }
            else
            {
                c.cmd.CommandText = "update Admin_create set password='" + tcnew.Text + "'";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Password Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox2.Visible = false;
                clearall();
            }
        }

        private void totp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}