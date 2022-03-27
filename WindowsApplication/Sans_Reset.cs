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
    public partial class Sans_Reset : Form
    {
        public Sans_Reset()
        {
            InitializeComponent();
        }

        private void Sans_Reset_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            this.Owner.Hide();
            this.WindowState = FormWindowState.Normal;
            Connect c = new Connect();
            c.cmd.CommandText = "select email from Admin_Create";
            String email = Convert.ToString(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select sans from Admin_Create";
            String sans = Convert.ToString(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select sqns from Admin_Create";
            String sqns = Convert.ToString(c.cmd.ExecuteScalar());
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("bhakthiprabhu15@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Forgot your security answer?";
                mail.Body = "The security answer for the security question\n" + sqns + " is\n" + sans;
                smtpserver.Port = 587;
                smtpserver.Credentials = new NetworkCredential("bhakthiprabhu15@gmail.com", "bhakthi15");
                smtpserver.EnableSsl = true;
                smtpserver.Send(mail);
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                label2.Text = "We sent an email to " + email + " with a security answer. Don't forget to check your spam folder.";
            }
            catch (Exception)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                label1.Text = "Connection Error!";
                label2.Text = "No data connection.Consider turning on mobile data or turning on Wi-Fi";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            //close
            this.Owner.Enabled = true;
            this.Owner.Show();
            this.WindowState = FormWindowState.Normal;
            this.Close();
        }
    }
}