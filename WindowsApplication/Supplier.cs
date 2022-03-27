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
    public partial class Supplier : Form
    {
        Connect c = new Connect();
        String sid;
        public Supplier()
        {
            InitializeComponent();
        }

        private void displayall()
        {
            //display function
            if ((cbactive.Checked == true && cbinactive.Checked == true) || (cbactive.Checked == false && cbinactive.Checked == false))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
            else if (cbactive.Checked == true && cbinactive.Checked == false)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier where Status='Active'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
            else if (cbactive.Checked == false && cbinactive.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier where Status='Inactive'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
        }

        private void clearall()
        {
            //clear function
            supname.Text = "";
            address.Text = "";
            email.Text = "";
            cno.Text = "";
            vsupname.Text = "";
            filter.ResetText();
            filter.Text = "Sort By";
            msg.Text = "";
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            nadd.Enabled = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            vsupname.Text = "search...";
            vsupname.ForeColor = Color.Silver;
        }

        public void datagridviewstyle(DataGridView dgv)
        {
            //datagridview
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.BackgroundColor = Color.FromArgb(30, 35, 38);
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ShowEditingIcon = false;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.Gainsboro;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 236, 240);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10.25f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        } 

        private void Supplier_Load(object sender, EventArgs e)
        {
            //page load
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            displayall();
            datagridviewstyle(dataGridView1);
        }

        private void nadd_Click(object sender, EventArgs e)
        {
            //register
            try
            {
                Regex cnum = new Regex("^[6-9][0-9]{9}$");
                if (supname.Text == "" || address.Text == "" || Convert.ToString(cno.Text) == "" || email.Text == "")
                    throw new ArgumentException();
                else
                {
                    new MailAddress(email.Text);
                    if (!(cnum.IsMatch(cno.Text)))
                        errorProvider1.SetError(cno, "Enter valid mobile number");
                    else
                    {
                        SqlCommand cmd = new SqlCommand("Select * from Supplier where Name='" + supname.Text + "' and Contact_No='" + cno.Text + "' and Email='" + email.Text + "'", c.cn);
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        if (dt.Rows.Count > 0)
                            MessageBox.Show("Record Exists!\n Please Edit Supplier if you want to make changes!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            String supid;
                            c.cmd.CommandText = "select Count(*) from Supplier";
                            int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                            cnt++;
                            supid = "sup" + cnt;
                            c.cmd.CommandText = "insert into Supplier (Sup_Id) values('" + supid + "')";
                            c.cmd.ExecuteNonQuery();
                            c.cmd.CommandText = "update Supplier set Name='" + supname.Text + "',Address='" + address.Text + "',Email='" + email.Text + "',Contact_No= '" + cno.Text + "',Status='Active' where Sup_Id='" + supid + "'";
                            c.cmd.ExecuteNonQuery();
                            MessageBox.Show("Supplier Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayall();
                            clearall();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                errorProvider2.SetError(email, "Enter valid format email");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void cno_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void nclear_Click(object sender, EventArgs e)
        {
            //clear
            clearall();
            cbinactive.Checked = false;
            cbactive.Checked = false;
            displayall();
        }

        private void vsupname_Click(object sender, EventArgs e)
        {
            if (vsupname.Text == "search...")
                vsupname.Text = "";
            vsupname.ForeColor = Color.FromArgb(20, 168, 0);
        }

        private void vsupname_Leave(object sender, EventArgs e)
        {
            if (vsupname.Text == "")
                vsupname.Text = "search...";
            vsupname.ForeColor = Color.Silver;
        }

        private void vsupname_KeyUp(object sender, KeyEventArgs e)
        {
            filter.ResetText();
            filter.Text = "Sort By";
            cbinactive.Checked = false;
            cbactive.Checked = false;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier where Name like '" + vsupname.Text + "%' or Sup_Id like '" + vsupname.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filter by
            vsupname.Text = "search...";
            cbactive.Checked = false;
            cbinactive.Checked = false;
            sortfunc(filter.SelectedItem.ToString());
        }

        private void sortfunc(String value)
        {
            //sortfunc function
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            c.cmd = new SqlCommand("select * from Supplier", c.cn);
            adp.SelectCommand = c.cmd;
            ds.Clear();
            adp.Fill(ds);
            dataGridView1.Sort(dataGridView1.Columns[value],ListSortDirection.Ascending);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            msg.Visible = false;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                ndelete.Enabled = true;
                nadd.Enabled = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.CurrentRow.Selected = true;
                sid = dataGridView1.Rows[e.RowIndex].Cells["Sup_Id"].FormattedValue.ToString();
                supname.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                email.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                cno.Text = dataGridView1.Rows[e.RowIndex].Cells["Contact_No"].FormattedValue.ToString();
                address.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                Regex rx = new Regex("^[6-9][0-9]{9}$");
                if (supname.Text == "" || address.Text == "" || Convert.ToString(cno.Text) == "" || email.Text == "")
                    throw new ArgumentException();
                else if (!(rx.IsMatch(cno.Text)))
                    errorProvider1.SetError(cno, "Enter valid mobile number");
                else
                {
                    new MailAddress(email.Text);
                    if (MessageBox.Show("Are You Sure want to Update ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "update Supplier set Name='" + supname.Text + "',Address='" + address.Text + "',Email='" + email.Text + "',Contact_No= '" + cno.Text + "' where Sup_Id='" + sid + "'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Supplier Updated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        dataGridView1.Rows[0].Cells[0].Selected = true;
                        displayall();
                        clearall();
                    }
                }
            }
            catch (FormatException)
            {
                errorProvider2.SetError(email, "Enter valid format email");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ndelete_Click(object sender, EventArgs e)
        {
            //delete
            c.cmd.CommandText = "select Status from Supplier where Sup_Id='" + sid + "'";
            if (Convert.ToString(c.cmd.ExecuteScalar()) == "Inactive")
            {
                msg.Visible = true;
                msg.Text = "Supplier already Inactivated!";
            }
            else
            {
                if (MessageBox.Show("Are You Sure want to Inactivate " + supname.Text + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "update Supplier set Status='Inactive' where Sup_Id='" + sid + "'";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Inactivated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            vsupname.Text = "Search...";
            filter.ResetText();
            filter.Text = "Sort By";
            displayall();
        }

        private void cbinactive_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox inactive
            vsupname.Text = "Search...";
            filter.ResetText();
            filter.Text = "Sort By";
            displayall();
        }

        private void supname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '.');
        }

        private void address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == '&' || e.KeyChar == '.');
        }

        private void vsupname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar));
        }        
    }
}