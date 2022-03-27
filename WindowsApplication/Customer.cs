using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Data.SqlClient;

namespace WindowsApplication
{
    public partial class Customer : Form
    {
        Connect c = new Connect();
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            //page load
            nupdate.Enabled = false;
            displayall();
            Supplier s = new Supplier();
            s.datagridviewstyle(dataGridView1);
        }

        private void vsupname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void clearall()
        {
            //clear function
            filter.ResetText();
            filter.Text = "Sort By";
            nadd.Enabled = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            searchcno.Text = "search...";
            searchcno.ForeColor = Color.Silver;
            taddr.Text = "";
            temail.Text = "";
            tname.Text = "";
            maskedTextBox2.Text = "";
            nupdate.Enabled = false;
        }

        private void displayall()
        {
            //display function
            SqlDataAdapter sda = new SqlDataAdapter("select * from Customer", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void nclear_Click(object sender, EventArgs e)
        {
            //clear
            clearall();
            displayall();
        }

        private void nadd_Click(object sender, EventArgs e)
        {
            //add
            try
            {
                Regex rx = new Regex("^[6-9][0-9]{9}$");
                if (tname.Text == "" || taddr.Text == "" || Convert.ToString(maskedTextBox2.Text) == "" || temail.Text == "")
                    throw new ArgumentException();
                else if (!(rx.IsMatch(maskedTextBox2.Text)))
                    errorProvider1.SetError(maskedTextBox2, "Enter valid mobile number");
                else
                {
                    new MailAddress(temail.Text);
                    SqlCommand cmd = new SqlCommand("Select * from Customer where Name='" + tname.Text+ "' and Contact_No='" + maskedTextBox2.Text + "' and Email='" + temail.Text + "'", c.cn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                        MessageBox.Show("Record Exists!\n Please Edit Customer if you want to make changes!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "insert into Customer (Contact_No) values('" + Convert.ToString(maskedTextBox2.Text) + "')";
                        c.cmd.ExecuteNonQuery();
                        c.cmd.CommandText = "update Customer set Name='" + tname.Text + "',Address='" + taddr.Text + "',Email='" + temail.Text + "' where Contact_No='" + Convert.ToString(maskedTextBox2.Text)+ "'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayall();
                        clearall();
                    }
                }
            }
            catch (FormatException)
            {
                errorProvider2.SetError(temail, "Enter valid format email");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void temail_TextChanged(object sender, EventArgs e)
        {
            //email textchanged
            errorProvider2.Clear();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            //contact no textchanged
            errorProvider1.Clear();
        }

        private void searchcno_Click(object sender, EventArgs e)
        {
            //search contact no click
            if (searchcno.Text == "search...")
                searchcno.Text = "";
            searchcno.ForeColor = Color.FromArgb(20, 168, 0);
        }

        private void searchcno_Leave(object sender, EventArgs e)
        {
            //search contact no leave
            if (searchcno.Text == "")
                searchcno.Text = "search...";
            searchcno.ForeColor = Color.Silver;
        }

        private void searchcno_KeyUp(object sender, KeyEventArgs e)
        {
            //search contact no keyup
            filter.ResetText();
            filter.Text = "Sort By";
            SqlDataAdapter sda = new SqlDataAdapter("select * from Customer where Contact_No like '" + searchcno.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filter by selected index changed
            searchcno.Text = "search...";
            sortfunc(filter.SelectedItem.ToString());
        }

        private void sortfunc(String value)
        {
            //sortfunc function
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            c.cmd = new SqlCommand("select * from Customer", c.cn);
            adp.SelectCommand = c.cmd;
            ds.Clear();
            adp.Fill(ds);
            dataGridView1.Sort(dataGridView1.Columns[value], ListSortDirection.Ascending);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1_CellContentClick
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                nadd.Enabled = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.CurrentRow.Selected = true;
                tname.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                temail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                maskedTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Contact_No"].FormattedValue.ToString();
                taddr.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                Regex rx = new Regex("^[6-9][0-9]{9}$");
                if (tname.Text == "" || taddr.Text == "" || Convert.ToString(maskedTextBox2.Text) == "" || temail.Text == "")
                    throw new ArgumentException();
                else if (!(rx.IsMatch(maskedTextBox2.Text)))
                    errorProvider1.SetError(maskedTextBox2, "Enter valid mobile number");
                else
                {
                    new MailAddress(temail.Text);
                    if (MessageBox.Show("Are You Sure want to Update ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "update Customer set Name='" + tname.Text + "',Address='" + taddr.Text + "',Email='" + temail.Text + "' where Contact_No='" + Convert.ToString(maskedTextBox2.Text) + "'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Updated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        dataGridView1.Rows[0].Cells[0].Selected = true;
                        displayall();
                        clearall();
                    }
                }
            }
            catch (FormatException)
            {
                errorProvider2.SetError(temail, "Enter valid format email");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '.');
        }

        private void taddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == '&' || e.KeyChar == '.');
        }
    }
}