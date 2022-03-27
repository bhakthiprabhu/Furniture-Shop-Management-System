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
    public partial class Service : Form
    {
        Connect c = new Connect();
        string srno;
        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.datagridviewstyle(dataGridView1);
            dateTimePicker1.Value = DateTime.Today;
            displayall();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            SqlCommand sc = new SqlCommand("select * from Sale_Bill where Net_Amount is not null", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            cb1.DataSource = ds.Tables[0];
            cb1.DisplayMember = "SB_No";
            cb1.ValueMember = "SB_No";
            cb1.Text = "Select";
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(cb1.Text == "" || cb1.Text == "Select"))
                {
                    SqlCommand sc = new SqlCommand("select * from Sale_Bill_Detail where SB_No='" + cb1.SelectedValue.ToString() + "'", c.cn);
                    SqlDataAdapter adp = new SqlDataAdapter(sc);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    sc.ExecuteNonQuery();
                    cb2.DataSource = ds.Tables[0];
                    cb2.DisplayMember = "Item_Id";
                    cb2.ValueMember = "Item_Id";
                    cb2.Text = "Select";
                }
            }
            catch (Exception)
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Warranty")
            {
                ttamt.Text = "0.0";
                ttax.Text = "0.0";
                tgtotal.Text = "0.0";
                ttamt.ReadOnly = true;
            }
            else
            {
                ttamt.Text = "";
                ttax.Text = "";
                tgtotal.Text = "";
                ttamt.ReadOnly = false;
            }
        }

        private void clearall()
        {
            ttamt.Text = "";
            ttax.Text = "";
            tgtotal.Text = "";
            ttamt.ReadOnly = false;
            cb2.Text = "Select";
            cb1.Text = "Select";
            comboBox1.Text = "Select";
            dateTimePicker1.Text = "";
            tremark.Text = "";
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            btngeneratebil.Enabled = true;
        }

        private void displayall()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter adp1 = new SqlDataAdapter("select * from Service", c.cn);
            DataSet ds2 = new DataSet();
            adp1.Fill(ds2, "dt2");
            dataGridView1.DataSource = ds2.Tables["dt2"];
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clearall();
            displayall();
        }

        private void ttamt_KeyUp(object sender, KeyEventArgs e)
        {
            if (ttamt.Text != "")
            {
                ttax.Text = (Convert.ToDouble(ttamt.Text) * 0.18).ToString();
                tgtotal.Text = (Convert.ToDouble(ttamt.Text) + Convert.ToDouble(ttax.Text)).ToString();
            }
            else
            {
                ttax.Text = "";
                tgtotal.Text = "";
            }
        }

        private void tsearch_KeyUp(object sender, KeyEventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Service where SR_No like '" + tsearch.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void tsearch_Leave(object sender, EventArgs e)
        {
            if (tsearch.Text == "")
                tsearch.Text = "search...";
            tsearch.ForeColor = Color.Silver;
        }

        private void tsearch_Click(object sender, EventArgs e)
        {
            if (tsearch.Text == "search...")
                tsearch.Text = "";
            tsearch.ForeColor = Color.FromArgb(20, 168, 0);
        }

        private void btngeneratebil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb1.Text == "" || cb1.Text == "Select" || cb2.Text == "" || cb2.Text == "Select" || comboBox1.Text == "" || comboBox1.Text == "Select" || ttamt.Text == "" || tremark.Text == "")
                    throw new ArgumentException();
                else
                {
                    if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "select Count(*) from Service";
                        int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                        cnt++;
                        srno = "sr" + cnt;
                        String date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                        c.cmd.CommandText = "insert into Service (SR_No,Date,SB_No,Service_Type,Total_Amount,Tax,Grand_Total,Remark,Item_Id) values('" + srno + "','" + date + "','" + cb1.Text + "','" + comboBox1.Text + "','" + ttamt.Text + "','" + ttax.Text + "','" + tgtotal.Text + "','" + tremark.Text + "','" + cb2.Text + "')";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill generated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayall();
                        clearall();
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException)
            {
                errorProvider1.SetError(ttamt,"Invalid Amount!");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                ndelete.Enabled = true;
                btngeneratebil.Enabled = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.CurrentRow.Selected = true;
                srno = dataGridView1.Rows[e.RowIndex].Cells["SR_No"].FormattedValue.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["Date"].FormattedValue.ToString();
                cb1.Text = dataGridView1.Rows[e.RowIndex].Cells["SB_No"].FormattedValue.ToString();
                cb2.Text = dataGridView1.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Service_Type"].FormattedValue.ToString();
                ttamt.Text = dataGridView1.Rows[e.RowIndex].Cells["Total_Amount"].FormattedValue.ToString();
                ttax.Text = dataGridView1.Rows[e.RowIndex].Cells["Tax"].FormattedValue.ToString();
                tgtotal.Text = dataGridView1.Rows[e.RowIndex].Cells["Grand_Total"].FormattedValue.ToString();
                tremark.Text =dataGridView1.Rows[e.RowIndex].Cells["Remark"].FormattedValue.ToString();
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb1.Text == "" || cb1.Text == "Select" || cb2.Text == "" || cb2.Text == "Select" || comboBox1.Text == "" || comboBox1.Text == "Select" || ttamt.Text == "" || tremark.Text == "")
                    throw new ArgumentException();
                else
                {
                    if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                        c.cmd.CommandText = "update Service set SR_No='" + srno + "',Date='" + date + "',SB_No='" + cb1.Text + "',Service_Type='" + comboBox1.Text + "',Total_Amount='" + ttamt.Text + "',Tax='" + ttax.Text + "',Grand_Total='" + tgtotal.Text + "',Remark='" + tremark.Text + "',Item_Id='"+cb2.Text+"' where SR_No='"+srno+"'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill updated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb1.Text == "" || cb1.Text == "Select" || cb2.Text == "" || cb2.Text == "Select" || comboBox1.Text == "" || comboBox1.Text == "Select" || ttamt.Text == "" || tremark.Text == "")
                    throw new ArgumentException();
                else
                {
                    if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "delete from Service where SR_No='" + srno + "'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill deleted Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ttamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back);
        }

        private void tremark_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar));
        }

        private void tsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar));
        }

        private void ttamt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}