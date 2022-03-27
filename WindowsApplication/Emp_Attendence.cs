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
    public partial class Emp_Attendence : Form
    {
        Connect c = new Connect();
        int totaldays;
        public Emp_Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            //page load
            Supplier s = new Supplier();
            s.datagridviewstyle(dataGridView1);
            displayall();
            SqlCommand sc = new SqlCommand("select * from Employee where Status='Active'", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            cbempid.DataSource = ds.Tables[0];
            cbempid.DisplayMember = "Emp_Id";
            cbempid.ValueMember = "Emp_Id";
            cbempid.Text = "Select";
            dateTimePicker2.MaxDate = DateTime.Today;
        }

        private void displayall()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Attendence", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void clearall()
        {
            cbempid.Text = "Select";
            cbmonth.Text = "Select";
            dateTimePicker2.Text = DateTime.Today.ToString(); 
            tname.Text = "";
            tltaken.Text = "";
            tlgiven.Text = "";
            searchemp.Text = "";
            filter.ResetText();
            filter.Text = "Sort By";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            searchemp.Text = "search...";
            nadd.Enabled = true;
            searchemp.ForeColor = Color.Silver;
            cbempid.Enabled = true;
            cbmonth.Enabled = true;
            dateTimePicker2.Enabled = true;
            nupdate.Enabled = false;
            nadd.Enabled = true;
        }

        private void nclear_Click(object sender, EventArgs e)
        {
            //clear
            clearall();
            displayall();
        }

        private void nadd_Click(object sender, EventArgs e)
        {
            //save
            try
            {
                if (cbempid.Text == "Select" || tname.Text == "" || tltaken.Text == "" || tlgiven.Text == "" || cbmonth.Text=="Select" ||cbmonth.Text=="...............")
                    throw new ArgumentException();
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * from Attendence where Emp_Id='" + cbempid.Text + "' and Month='" + cbmonth.SelectedItem.ToString() + "' and Year='" + dateTimePicker2.Text + "' and Emp_Id='" + cbempid.Text + "'", c.cn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    c.cmd.CommandText = "select Doj from Employee where Emp_Id='" + cbempid.Text + "' ";
                    DateTime doj = Convert.ToDateTime(c.cmd.ExecuteScalar());
                    DateTime date = new DateTime(Convert.ToInt16(dateTimePicker2.Text), cbmonth.SelectedIndex, Convert.ToInt16(DateTime.Today.ToString("dd")), 12, 00, 00);
                    if ((cbmonth.SelectedIndex > DateTime.Now.Month && Convert.ToInt16(dateTimePicker2.Text) == DateTime.Now.Year))
                        MessageBox.Show("Invalid Month!\n this month yet to come!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if ((cbmonth.SelectedIndex == DateTime.Now.Month && Convert.ToInt16(dateTimePicker2.Text) == DateTime.Now.Year))
                        MessageBox.Show("Invalid Month!\n this month is not ended!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if( doj>date)
                        MessageBox.Show("Invalid Month!\n joined date is "+doj.ToShortDateString(),"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        totaldays = DateTime.DaysInMonth(Convert.ToInt16(dateTimePicker2.Text), cbmonth.SelectedIndex);
                        if (Convert.ToInt16(tltaken.Text) > totaldays || Convert.ToInt16(tlgiven.Text) > totaldays)
                            MessageBox.Show("Please enter valid days.\nThe days must be less than total number of days in month.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (dt.Rows.Count > 0)
                            MessageBox.Show("Attendence already exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int extral = 0;
                            int l = Convert.ToInt16(tlgiven.Text) - Convert.ToInt16(tltaken.Text);
                            if (l > 0)
                                extral = 0;
                            else
                                extral = -1 * l;
                            c.cmd.CommandText = "insert into Attendence (Emp_Id,Month,Year,Total_days,Leave_taken,Leave_given,Extra_leave) values('" + cbempid.Text + "','" + cbmonth.SelectedItem.ToString() + "','" + dateTimePicker2.Text + "','" + totaldays + "','" + tltaken.Text + "','" + tlgiven.Text + "'," + extral + ")";
                            c.cmd.ExecuteNonQuery();
                            MessageBox.Show("Attendence Details Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayall();
                            clearall();
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from Attendence where Emp_Id like '" + searchemp.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filter by
            searchemp.Text = "search...";
            sortfunc(filter.SelectedItem.ToString());
        }

        private void sortfunc(String value)
        {
            //sortfunc function
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            c.cmd = new SqlCommand("select * from Attendence", c.cn);
            adp.SelectCommand = c.cmd;
            ds.Clear();
            adp.Fill(ds);
            dataGridView1.Sort(dataGridView1.Columns[value], ListSortDirection.Ascending);
        }

        private void cbempid_Leave(object sender, EventArgs e)
        {
            if (!(cbempid.Text == "Select" || cbempid.Text==""))
            {
                SqlCommand cmd = new SqlCommand("select Name from Employee where Emp_Id='" + cbempid.Text + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tname.Text = dt.Rows[i]["Name"].ToString();
                    }
                }
            }
        }

        private void tltaken_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tlgiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                nadd.Enabled = false;
                cbempid.Enabled = false;
                cbmonth.Enabled = false;
                dateTimePicker2.Enabled = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.CurrentRow.Selected = true;
                cbempid.Text = dataGridView1.Rows[e.RowIndex].Cells["Emp_Id"].FormattedValue.ToString();
                cbmonth.Text = dataGridView1.Rows[e.RowIndex].Cells["Month"].FormattedValue.ToString();
                String year = dataGridView1.Rows[e.RowIndex].Cells["Year"].FormattedValue.ToString();
                dateTimePicker2.Text= DateTime.ParseExact(year, "yyyy",null).ToShortDateString();
                tlgiven.Text = dataGridView1.Rows[e.RowIndex].Cells["Leave_given"].FormattedValue.ToString();
                tltaken.Text = dataGridView1.Rows[e.RowIndex].Cells["Leave_taken"].FormattedValue.ToString();
                c.cmd.CommandText = "select Name from Employee where Emp_Id='" + cbempid.Text + "'";
                tname.Text = c.cmd.ExecuteScalar().ToString();
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tltaken.Text == "" || tlgiven.Text == "")
                    throw new ArgumentException();
                else
                {
                    int totaldays = DateTime.DaysInMonth(Convert.ToInt16(dateTimePicker2.Text), cbmonth.SelectedIndex);
                    if (Convert.ToInt16(tltaken.Text) > totaldays || Convert.ToInt16(tlgiven.Text) > totaldays)
                        MessageBox.Show("Please enter valid days.\nThe days must be less than total number of days in month.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int extral = 0;
                        int l = Convert.ToInt16(tlgiven.Text) - Convert.ToInt16(tltaken.Text);
                        if (l > 0)
                            extral = 0;
                        else
                            extral = -1 * l;
                        c.cmd.CommandText = "update Attendence set Total_days="+totaldays+",Leave_taken="+tltaken.Text+",Leave_given="+tlgiven.Text+",Extra_leave="+extral+"  where Emp_Id='" + cbempid.Text + "' and Month='"+cbmonth.SelectedItem.ToString()+"' and Year='"+dateTimePicker2.Text+"'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Attendence Details Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayall();
                        clearall();
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back ||  char.IsDigit(e.KeyChar));
        }
    }
}