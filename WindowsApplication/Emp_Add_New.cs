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
    public partial class Emp_Add_New : Form
    {
        Connect c = new Connect();
        DateTime dt1, dt2;
        String dob, gender, doj,empid;
        public Emp_Add_New()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            //page load
            Supplier s = new Supplier();
            s.datagridviewstyle(dataGridView1);
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            displayall();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            //dob leave
            try
            {
                dt1 = Convert.ToDateTime(maskedTextBox1.Text);
                dt2 = DateTime.Today.Date;
                Regex rx = new Regex("^([0-2][0-9]|[3][0-1])[-]([0][1-9]|[1][0-2])[-]([0-9]{4})$");
                if (!(rx.IsMatch(maskedTextBox1.Text)))
                    errorProvider3.SetError(maskedTextBox1, "Enter valid birth date in format dd/mm/yyyy");
                else if (dt2 < dt1)
                    errorProvider3.SetError(maskedTextBox1, "Enter valid birth date in format dd/mm/yyyy");
                else
                {
                    int d = (int)(dt2 - dt1).TotalDays;
                    tage.Text = (d / 365).ToString();
                }
            }
            catch (Exception)
            {
                errorProvider3.SetError(maskedTextBox1, "Enter valid birth date in format dd/mm/yyyy");
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            //dob textchanged
            errorProvider3.Clear();
        }

        private void tbasicpay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceept only decimal numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void displayall()
        {
            //display function
            if ((cbactive.Checked == true && cbinactive.Checked == true) || (cbactive.Checked == false && cbinactive.Checked == false))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
            else if (cbactive.Checked == true && cbinactive.Checked == false)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee where Status='Active'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
            else if (cbactive.Checked == false && cbinactive.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee where Status='Inactive'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
        }

        private void clearall()
        {
            //clear function
            tname.Text = "";
            taddr.Text = "";
            temail.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            tage.Text = "";
            tdesgn.Text = "";
            tbasicpay.Text = "";
            searchemp.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            dateTimePicker1.Text = "";
            radioButton1.Checked = true;
            msg.Text = "";
            filter.ResetText();
            filter.Text = "Sort By";
            msg.Text = "";
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            nadd.Enabled = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            searchemp.Text = "search...";
            searchemp.ForeColor = Color.Silver;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
        }

        private void nadd_Click(object sender, EventArgs e)
        {
            //register
            dob = dt1.ToString("MM-dd-yyyy");
            doj = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            gender="";
            DateTime db = new DateTime(Convert.ToInt16(dt1.ToString("yyyy")),Convert.ToInt16(dt1.ToString("MM")),Convert.ToInt16(dt1.ToString("dd")),12,00,00);
            DateTime dj = new DateTime(Convert.ToInt16(dateTimePicker1.Value.ToString("yyyy")), Convert.ToInt16(dateTimePicker1.Value.ToString("MM")), Convert.ToInt16(dateTimePicker1.Value.ToString("dd")), 12, 00, 00);
            if (radioButton1.Checked == true)
                gender = "Female";
            else if (radioButton2.Checked == true)
                gender = "Male";
            else if (radioButton3.Checked == true)
                gender = "Other";
            try
            {
                Regex rx1 = new Regex("^[6-9][0-9]{9}$");
                if (tname.Text == "" || taddr.Text == "" || Convert.ToString(maskedTextBox2.Text) == "" || temail.Text == "" || maskedTextBox2.Text == "" || tdesgn.Text == "" || tbasicpay.Text == "")
                    throw new ArgumentException();
                else if (!(rx1.IsMatch(maskedTextBox2.Text)))
                    errorProvider1.SetError(maskedTextBox2, "Enter valid mobile number");
                else
                {
                    new MailAddress(temail.Text);
                    SqlCommand cmd = new SqlCommand("Select * from Employee where Name='" + tname.Text + "' and Contact_No='" + maskedTextBox2.Text + "' and Email='" + temail.Text + "'", c.cn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (db.AddYears(18) > dj)
                        errorProvider4.SetError(dateTimePicker1, "invalid DOJ\n age should be atleast 18 years");
                    else if (dt.Rows.Count > 0)
                        MessageBox.Show("Record Exists!\n Please Edit Employee if you want to make changes!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "select Count(*) from Employee";
                        int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                        cnt++;
                        empid = "emp" + cnt;
                        c.cmd.CommandText = "insert into Employee (Emp_Id) values('" + empid + "')";
                        c.cmd.ExecuteNonQuery();
                        c.cmd.CommandText = "update Employee set Name='" + tname.Text + "',Address='" + taddr.Text + "',Email='" + temail.Text + "',Contact_No= '" + Convert.ToString(maskedTextBox2.Text) + "',Status='Active',Dob='" + dob + "',Gender='" + gender + "',Age='" + tage.Text + "',Doj='" + doj + "',Designation='" + tdesgn.Text + "',Basic_Pay='" + tbasicpay.Text + "' where Emp_Id='" + empid + "'";
                        c.cmd.ExecuteNonQuery();
                        //update employee login 
                        String password = empid + "123";
                        c.cmd.CommandText = "insert into Login values('" + empid + "','" + password + "')";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (SqlException)
            {
                errorProvider5.SetError(tbasicpay, "Invalid Basic Pay");
            }
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            //contact no textchanged
            errorProvider1.Clear();
        }

        private void temail_TextChanged(object sender, EventArgs e)
        {
            //email textchanged
            errorProvider2.Clear();
        }

        private void nclear_Click(object sender, EventArgs e)
        {
            //clear
            clearall();
            cbinactive.Checked = false;
            cbactive.Checked = false;
            displayall();
        }

        private void searchemp_Click(object sender, EventArgs e)
        {
            //search employee Click
            if (searchemp.Text == "search...")
                searchemp.Text = "";
            searchemp.ForeColor = Color.FromArgb(20, 168, 0);
        }

        private void searchemp_Leave(object sender, EventArgs e)
        {
            //search employee leave
            if (searchemp.Text == "")
                searchemp.Text = "search...";
            searchemp.ForeColor = Color.Silver;
        }

        private void searchemp_KeyUp(object sender, KeyEventArgs e)
        {
            //search employee keyup
            filter.ResetText();
            filter.Text = "Sort By";
            cbinactive.Checked = false;
            cbactive.Checked = false;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Employee where Name like '" + searchemp.Text + "%' or Emp_Id like '" + searchemp.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filter by
            searchemp.Text = "search...";
            cbactive.Checked = false;
            cbinactive.Checked = false;
            sortfunc(filter.SelectedItem.ToString());
        }

        private void sortfunc(String value)
        {
            //sortfunc function
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            c.cmd = new SqlCommand("select * from Employee", c.cn);
            adp.SelectCommand = c.cmd;
            ds.Clear();
            adp.Fill(ds);
            dataGridView1.Sort(dataGridView1.Columns[value], ListSortDirection.Ascending);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1_CellContentClick
            msg.Visible = false;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                ndelete.Enabled = true;
                nadd.Enabled = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.CurrentRow.Selected = true;
                empid = dataGridView1.Rows[e.RowIndex].Cells["Emp_Id"].FormattedValue.ToString();
                tname.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                temail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                maskedTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Contact_No"].FormattedValue.ToString();
                taddr.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Dob"].FormattedValue.ToString();
                tage.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["Doj"].FormattedValue.ToString();
                tdesgn.Text = dataGridView1.Rows[e.RowIndex].Cells["Designation"].FormattedValue.ToString();
                tbasicpay.Text = dataGridView1.Rows[e.RowIndex].Cells["Basic_Pay"].FormattedValue.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString() == "Female")
                    radioButton1.Checked = true;
                else if (dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString() == "Male")
                    radioButton2.Checked = true;
                else if (dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString() == "Other")
                    radioButton3.Checked = true;
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            //update
            dob = dt1.ToString("MM-dd-yyyy");
            doj = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            DateTime db = new DateTime(Convert.ToInt16(dt1.ToString("yyyy")), Convert.ToInt16(dt1.ToString("MM")), Convert.ToInt16(dt1.ToString("dd")), 12, 00, 00);
            DateTime dj = new DateTime(Convert.ToInt16(dateTimePicker1.Value.ToString("yyyy")), Convert.ToInt16(dateTimePicker1.Value.ToString("MM")), Convert.ToInt16(dateTimePicker1.Value.ToString("dd")), 12, 00, 00);
            gender = "";
            if (radioButton1.Checked == true)
                gender = "Female";
            else if (radioButton2.Checked == true)
                gender = "Male";
            else if (radioButton3.Checked == true)
                gender = "Other";
            try
            {
                Regex rx = new Regex("^[6-9][0-9]{9}$");
                if (tname.Text == "" || taddr.Text == "" || Convert.ToString(maskedTextBox2.Text) == "" || temail.Text == "" || maskedTextBox2.Text == "" || tdesgn.Text == "" || tbasicpay.Text == "")
                    throw new ArgumentException();
                else if (!(rx.IsMatch(maskedTextBox2.Text)))
                    errorProvider1.SetError(maskedTextBox2, "Enter valid mobile number");
                else
                {
                    new MailAddress(temail.Text);
                    if (db.AddYears(18) > dj)
                        errorProvider4.SetError(dateTimePicker1, "invalid DOJ\n age should be atleast 18 years");
                    else if (MessageBox.Show("Are You Sure want to Update ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "update Employee set Name='" + tname.Text + "',Address='" + taddr.Text + "',Email='" + temail.Text + "',Contact_No= '" + Convert.ToString(maskedTextBox2.Text) + "',Dob='" + dob + "',Gender='" + gender + "',Age='" + tage.Text + "',Doj='" + doj + "',Designation='" + tdesgn.Text + "',Basic_Pay='" + tbasicpay.Text + "' where Emp_Id='" + empid + "'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Updated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (SqlException)
            {
                errorProvider5.SetError(tbasicpay, "Invalid Basic Pay");
            }
        }

        private void ndelete_Click(object sender, EventArgs e)
        {
            //delete
            c.cmd.CommandText = "select Status from Employee where Emp_Id='" + empid + "'";
            if (Convert.ToString(c.cmd.ExecuteScalar()) == "Inactive")
            {
                msg.Visible = true;
                msg.Text = "Employee already Inactivated!";
            }
            else
            {
                if (MessageBox.Show("Are You Sure want to Inactivate " + tname.Text + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "update Employee set Status='Inactive' where Emp_Id='" + empid + "'";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Inactivated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    dataGridView1.Rows[0].Cells[0].Selected = true;
                    displayall();
                    clearall();
                }
            }
        }

        private void cbactive_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox active
            searchemp.Text = "Search...";
            filter.ResetText();
            filter.Text = "Sort By";
            displayall();
        }

        private void cbinactive_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox inactive
            searchemp.Text = "Search...";
            filter.ResetText();
            filter.Text = "Sort By";
            displayall();
        }

        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '.');
        }

        private void tdesgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar));
        }

        private void taddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == '&' || e.KeyChar == '.');
        }

        private void searchemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void tbasicpay_TextChanged(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }
    }
}