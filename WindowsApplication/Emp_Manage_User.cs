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
    public partial class Emp_Manage_User : Form
    {
        Connect c = new Connect();
        public Emp_Manage_User()
        {
            InitializeComponent();
        }

        private void Manage_User_Load(object sender, EventArgs e)
        {
            refreshPage();
        }

        private void refreshPage()
        {
            //refresh function
            textBox1.Text = "";
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            //Combobox1 - unlock
            SqlCommand sc = new SqlCommand("select * from Employee where Status='Locked'", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Emp_Id";
            comboBox1.ValueMember = "Emp_Id";
            comboBox1.Text = "Select";
            //Combobox2 - lock
            SqlCommand sc1 = new SqlCommand("select * from Employee where Status='Active' or Status='Inactive'", c.cn);
            SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            sc1.ExecuteNonQuery();
            comboBox2.DataSource = ds1.Tables[0];
            comboBox2.DisplayMember = "Emp_Id";
            comboBox2.ValueMember = "Emp_Id";
            comboBox2.Text = "Select";
            //Combobox3 - reset
            SqlCommand sc2 = new SqlCommand("select * from Employee where Status='Active'", c.cn);
            SqlDataAdapter adp2 = new SqlDataAdapter(sc2);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            sc2.ExecuteNonQuery();
            comboBox3.DataSource = ds2.Tables[0];
            comboBox3.DisplayMember = "Emp_Id";
            comboBox3.ValueMember = "Emp_Id";
            comboBox3.Text = "Select";
        }

        private void toplock_Click(object sender, EventArgs e)
        {
            //lock panel
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            panellock.BringToFront();
            toplock.BackColor = Color.FromArgb(176, 0, 32);
            topunlock.BackColor = Color.Gray;
        }

        private void topunlock_Click(object sender, EventArgs e)
        {
            //unlock panel
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            panelunlock.BringToFront();
            topunlock.BackColor = Color.ForestGreen;
            toplock.BackColor = Color.Gray;
        }

        private void btnunlock_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select")
                errorProvider1.SetError(comboBox1, "Please Select Employee Id");
            else
            {
                c.cmd.CommandText = "update Employee set Status='Active' where Emp_Id='" + comboBox1.Text + "'";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Employee unlocked", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshPage();
            }
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Select")
                errorProvider2.SetError(comboBox2, "Please Select Employee Id");
            else
            {
                c.cmd.CommandText = "update Employee set Status='Locked' where Emp_Id='" + comboBox2.Text + "'";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Employee locked", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshPage();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Select")
                errorProvider3.SetError(comboBox3, "Please Select Employee Id");
            else if (textBox1.Text == "")
                errorProvider4.SetError(textBox1, "Required!");
            else
            {
                c.cmd.CommandText = "update Login set password='" + textBox1.Text + "' where Emp_Id='" + comboBox3.Text + "'";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Password Changed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshPage();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

    }
}