using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsApplication
{
    public partial class Login_User : Form
    {
        Connect c = new Connect();
        String username, password, usern, userp;
        int cnt = 1;
        public Login_User()
        {
            InitializeComponent();
        }

        private void Login_Admin_Load(object sender, EventArgs e)
        {
            //page load
            this.Text = "Login";
            textBox2.Text = "PASSWORD";
            textBox1.Text = "USERNAME";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //password textchanged
            errorProvider2.Clear();
            label2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //username textchanged
            errorProvider1.Clear();
            label2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //username click
            if (textBox1.Text == "USERNAME")
                textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //password click
            if (textBox2.Text == "PASSWORD")
                textBox2.Text = "";
            eye.Visible = true;
            hide.Visible = false;
            textBox2.TabStop = true;
            textBox2.ForeColor = Color.Black;
            textBox2.PasswordChar = '•';
        }

        private void hide_Click(object sender, EventArgs e)
        {
            //hide password
            textBox2.PasswordChar = '•';
            eye.Visible = true;
            hide.Visible = false;
        }

        private void eye_Click(object sender, EventArgs e)
        {
            //show password
            textBox2.PasswordChar = '\0';
            eye.Visible = false;
            hide.Visible = true;
        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            //login_MouseHover
            toolTip1.SetToolTip(login, "Login");
        }

        private void notyou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //not you
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Text = "PASSWORD";
            textBox1.Text = "USERNAME";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox2.PasswordChar = '\0';
        }

        public void info()
        {
            //info function
            c.cmd.CommandText = "Select username from Admin_Create";
            username = c.cmd.ExecuteScalar().ToString();

            c.cmd.CommandText = "Select password from Admin_Create";
            password = c.cmd.ExecuteScalar().ToString();
        }

        private void login_Click(object sender, EventArgs e)
        {
            info();

            SqlCommand cmd = new SqlCommand("Select * from Login where Emp_Id='" + textBox1.Text + "' and password='" + textBox2.Text + "'", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            SqlCommand cmd1 = new SqlCommand("Select * from Employee where Emp_Id='" + textBox1.Text + "' and Status='Locked' or Emp_Id='" + textBox1.Text + "' and Status='Inactive'", c.cn);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adp1.Fill(dt1);

            if (textBox1.Text == "" || textBox1.Text == "USERNAME")
                errorProvider1.SetError(textBox1, "Requied!");
            else if (textBox2.Text == "" || textBox2.Text == "PASSWORD")
                errorProvider2.SetError(textBox2, "Requied!");
            else if (textBox2.Text == password && textBox1.Text == username)
            {
                this.Hide();
                new Nav_Admin(textBox1.Text).Show();
            }
            else if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    usern = dt.Rows[i]["Emp_Id"].ToString();
                    userp = dt.Rows[i]["password"].ToString();
                    if (textBox2.Text == userp && textBox1.Text == usern)
                    {
                        if (dt1.Rows.Count > 0)
                        {
                            MessageBox.Show("You cannot login here because your account is locked/Inactivated!. \nContact admin for more!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Hide();
                            new Nav_User(usern).Show();
                        }
                    }
                }
            }
            else
            {
                c.cmd.CommandText = "Select Emp_Id from Login where Emp_Id='"+textBox1.Text+"'";
                try
                {
                    if (textBox1.Text == c.cmd.ExecuteScalar().ToString())
                    {
                        cnt++;
                        if (dt1.Rows.Count > 0)
                        {
                            MessageBox.Show("You cannot login here because your account is locked. \nContact admin for more!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (cnt > 3)
                        {
                            c.cmd.CommandText = "update Employee set status='Locked' where Emp_Id='" + textBox1.Text + "'";
                            c.cmd.ExecuteNonQuery();
                            MessageBox.Show("Account has been locked.\nContact the Administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            label2.Visible = true;
                            label2.Text = "Invalid Username / Password!";
                        }
                    }
                    else
                    {
                        label2.Visible = true;
                        label2.Text = "Invalid Username / Password!";
                    }
                }
                catch (Exception)
                {
                    label2.Visible = true;
                    label2.Text = "Invalid Username / Password!";
                }
            }
        }

        private void forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                info();
                c.cmd.CommandText = "Select Emp_Id from Login where Emp_Id='" + textBox1.Text + "'";
                if (textBox1.Text == "" || textBox1.Text == "USERNAME")
                    errorProvider1.SetError(textBox1, "Requied!");
                else if (textBox1.Text == username)
                {
                    this.Hide();
                    new Password_Reset().Show();
                }
                else if (textBox1.Text == c.cmd.ExecuteScalar().ToString())
                {
                    MessageBox.Show("Contact Admin If you forgot your password", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = "Invalid Username / Password!";
                }
            }
            catch (Exception)
            {
                label2.Visible = true;
                label2.Text = "Invalid Username / Password!";
            }
        }
    }
}

        