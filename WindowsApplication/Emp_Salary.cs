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
    public partial class btn_calculate : Form
    {
        Connect c = new Connect();
        public btn_calculate()
        {
            InitializeComponent();
        }

        private void Emp_Salary_Load(object sender, EventArgs e)
        {
            //page load
            Supplier s = new Supplier();
            s.datagridviewstyle(dataGridView1);
            SqlCommand sc = new SqlCommand("select * from Employee where Status='Active' ", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            cbempid.DataSource = ds.Tables[0];
            cbempid.DisplayMember = "Emp_Id";
            cbempid.ValueMember = "Emp_Id";
            cbempid.Text = "Select";
            dateTimePicker2.MaxDate = DateTime.Today;
            displayall();
        }

        private void displayall()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Salary", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void tbonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceept only decimal numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void cbempid_Leave(object sender, EventArgs e)
        {
            //employeeid leave
            try
            {
                if (!(cbempid.Text == "Select" || cbempid.Text == ""))
                {
                    SqlCommand cmd = new SqlCommand("Select * from Employee where Emp_Id='" + cbempid.Text + "'", c.cn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tname.Text = dt.Rows[i]["Name"].ToString();
                            tbasicpay.Text = dt.Rows[i]["Basic_Pay"].ToString();

                        }
                    }
                    SqlDataAdapter adp1 = new SqlDataAdapter("select * from Attendence where Emp_Id='" + cbempid.Text + "' and Year='" + dateTimePicker2.Text + "'", c.cn);
                    DataSet ds = new DataSet();
                    adp1.Fill(ds);
                    cbmonth.DataSource = ds.Tables[0];
                    cbmonth.DisplayMember = "Month";
                    cbmonth.ValueMember = "Month";
                    cbmonth.Text = "Select";
                }
            }
            catch (Exception)
            {
               
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adp1 = new SqlDataAdapter("select * from Attendence where Emp_Id='" + cbempid.Text + "' and Year='" + dateTimePicker2.Text + "'", c.cn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                cbmonth.DataSource = ds.Tables[0];
                cbmonth.DisplayMember = "Month";
                cbmonth.ValueMember = "Month";
                cbmonth.Text = "Select";
            }
            catch (Exception)
            {
            }
        }

        private void clearall()
        {
            cbempid.Text = "Select";
            cbmonth.Text = "Select";
            dateTimePicker2.Text = DateTime.Today.ToString(); 
            ttax.Text = "";
            tname.Text = "";
            tbasicpay.Text = "";
            thra.Text = "";
            tpf.Text = "";
            ttotaldays.Text = "";
            textraleave.Text = "";
            ttotalpay.Text = "";
            tnetpay.Text = "";
            filter.ResetText();
            filter.Text = "Sort By";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            searchemp.Text = "search...";
            searchemp.ForeColor = Color.Silver;
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
                if (cbempid.Text == "Select" || cbmonth.Text == "Select")
                    throw new ArgumentException();
                else if (ttax.Text == "")
                    MessageBox.Show("Please calculate salary first!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * from Salary where Emp_Id='" + cbempid.Text + "' and Month='" + cbmonth.Text + "' and Year='" + dateTimePicker2.Text + "'", c.cn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                        MessageBox.Show("Salary details exist for this month!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "select Count(*) from Salary";
                        int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                        cnt++;
                        String payid = "pay" + cnt;
                        c.cmd.CommandText = "insert into Salary (Pay_Id) values('" + payid + "')";
                        c.cmd.ExecuteNonQuery();

                        c.cmd.CommandText = "update Salary set Emp_Id='" + cbempid.Text + "',Date='" + DateTime.Now.ToString("MM.dd.yyyy") +"',Year='" + dateTimePicker2.Text + "',Month='" + cbmonth.Text + "',Tax='" + ttax.Text + "',HRA='" + thra.Text + "',PF='" + tpf.Text + "',Total_Pay='" + ttotalpay.Text + "',Net_Pay='" + tnetpay.Text + "' where Pay_Id='" + payid + "'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Salary Details Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Emp_Salary_Print(cbempid.Text,cbmonth.Text,dateTimePicker2.Text).Show();
                        clearall();
                        displayall();
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //calculate
            try
            {
                if (cbempid.Text == "Select" || cbmonth.Text == "Select")
                    throw new ArgumentException();
                SqlCommand cmd = new SqlCommand("Select * from Attendence where Emp_Id='" + cbempid.Text + "' and Month='" + cbmonth.Text + "' and Year='" + dateTimePicker2.Text + "' and Emp_Id='" + cbempid.Text + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ttotaldays.Text = dt.Rows[i]["Total_days"].ToString();
                        textraleave.Text = dt.Rows[i]["Extra_leave"].ToString();
                    }
                    double basic = Convert.ToDouble(tbasicpay.Text);
                    double totaldays = Convert.ToDouble(ttotaldays.Text);
                    double extraleave = Convert.ToDouble(textraleave.Text);
                    basic = (basic / totaldays) * (totaldays - extraleave);
                    double tax = basic * 0.15;
                    double hra = basic * 0.4;
                    double pf = basic * 0.12;
                    double totalpay = hra + basic;
                    double netpay = totalpay - (pf + tax);
                    ttax.Text = Math.Round(tax, 2).ToString();
                    thra.Text = Math.Round(hra, 2).ToString();
                    tpf.Text = Math.Round(pf, 2).ToString();
                    ttotalpay.Text = Math.Round(totalpay, 2).ToString();
                    tnetpay.Text = Math.Round(netpay, 2).ToString();

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
            SqlDataAdapter sda = new SqlDataAdapter("select * from Salary where Emp_Id like '" + searchemp.Text + "%'", c.cn);
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
            c.cmd = new SqlCommand("select * from Salary", c.cn);
            adp.SelectCommand = c.cmd;
            ds.Clear();
            adp.Fill(ds);
            dataGridView1.Sort(dataGridView1.Columns[value], ListSortDirection.Ascending);
        }

        private void searchemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar));
        }
    }
}