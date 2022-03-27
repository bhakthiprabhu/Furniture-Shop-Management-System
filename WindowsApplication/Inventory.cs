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
    public partial class Inventory : Form
    {
        Connect c = new Connect();
        string itemid, date;
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //page load
            Supplier s = new Supplier();
            s.datagridviewstyle(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            displayall();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void displayall()
        {
            //display function
            if ((cbactive.Checked == true && cbinactive.Checked == true) || (cbactive.Checked == false && cbinactive.Checked == false))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Inventory", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
            else if (cbactive.Checked == true && cbinactive.Checked == false)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Inventory where Status='Active'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
            else if (cbactive.Checked == false && cbinactive.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Inventory where Status='Inactive'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dataGridView1.DataSource = ds.Tables["dt"];
            }
        }

        private void clearall()
        {
            //clear function
            titemname.Text = "";
            tqty.Text = "0";
            tprice.Text = "0.0";
            twarranty.Text = "0.0";
            tcolor.Text = "";
            tmaterial.Text = "";
            dateTimePicker1.Text = "";
            cbcategory.ResetText();
            cbcategory.Text = "Select";
            filter.ResetText();
            filter.Text = "Sort By";
            msg.Text = "";
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            nadd.Enabled = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            searchitem.Text = "search...";
            searchitem.ForeColor = Color.Silver;
        }

        private void tsaleprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only decimal numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void tqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void twarranty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only decimal numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void tprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only decimal numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void nclear_Click(object sender, EventArgs e)
        {
            //clear
            clearall();
            cbinactive.Checked = false;
            cbactive.Checked = false;
            displayall();
        }

        private void nadd_Click(object sender, EventArgs e)
        {
            //add
            date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            try
            {
                if (titemname.Text == "" || tprice.Text == "" || twarranty.Text == "" || tcolor.Text == "" || tmaterial.Text == "" || cbcategory.Text == "Select")
                    throw new ArgumentException();
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * from Inventory where Name='" + titemname.Text + "' and Color='" + tcolor.Text + "' and Material='" + tmaterial.Text + "'", c.cn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                        MessageBox.Show("Record Exists!\n Please Edit item if you want to make changes!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "select Count(*) from Inventory";
                        int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                        cnt++;
                        itemid = "item" + cnt;
                        c.cmd.CommandText = "insert into Inventory (Item_Id) values('" + itemid + "')";
                        c.cmd.ExecuteNonQuery();
                        c.cmd.CommandText = "update Inventory set Name='" + titemname.Text + "',Qty='" + tqty.Text + "',Date='" + date + "',Category='" + cbcategory.SelectedItem.ToString() + "',Color='" + tcolor.Text + "',Material='" + tmaterial.Text + "',Price='" + tprice.Text + "',Warranty='" + twarranty.Text + "' where Item_Id='" + itemid + "'";
                        c.cmd.ExecuteNonQuery();
                        c.cmd.CommandText = "Select Qty from Inventory where Item_Id='" + itemid + "'";
                        int qt = Convert.ToInt32(c.cmd.ExecuteScalar());
                        if (qt <= 0)
                        {
                            c.cmd.CommandText = "update Inventory set Status ='Inactive',Qty=0 where Item_Id='" +itemid + "'";
                            c.cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            c.cmd.CommandText = "update Inventory set Qty =" + qt + ",Status ='Active' where Item_Id='" + itemid + "'";
                            c.cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Item Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void searchitem_Click(object sender, EventArgs e)
        {
            //search item Click
            if (searchitem.Text == "search...")
                searchitem.Text = "";
            searchitem.ForeColor = Color.FromArgb(20, 168, 0);
        }

        private void searchitem_Leave(object sender, EventArgs e)
        {
            //search item leave
            if (searchitem.Text == "")
                searchitem.Text = "search...";
            searchitem.ForeColor = Color.Silver;
        }

        private void searchitem_KeyUp(object sender, KeyEventArgs e)
        {
            //search item keyup
            filter.ResetText();
            filter.Text = "Sort By";
            cbinactive.Checked = false;
            cbactive.Checked = false;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Inventory where Name like '" + searchitem.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dataGridView1.DataSource = ds.Tables["dt"];
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filter by
            searchitem.Text = "search...";
            cbactive.Checked = false;
            cbinactive.Checked = false;
            sortfunc(filter.SelectedItem.ToString());
        }

        private void sortfunc(String value)
        {
            //sortfunc function
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            c.cmd = new SqlCommand("select * from Inventory", c.cn);
            adp.SelectCommand = c.cmd;
            ds.Clear();
            adp.Fill(ds);
            dataGridView1.Sort(dataGridView1.Columns[value], ListSortDirection.Ascending);
        }

        private void dgvinventoryd_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                itemid = dataGridView1.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
                titemname.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                tmaterial.Text = dataGridView1.Rows[e.RowIndex].Cells["Material"].FormattedValue.ToString();
                tcolor.Text = dataGridView1.Rows[e.RowIndex].Cells["Color"].FormattedValue.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["Date"].FormattedValue.ToString();
                cbcategory.Text = dataGridView1.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
                tqty.Text = dataGridView1.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString();
                tprice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                twarranty.Text = dataGridView1.Rows[e.RowIndex].Cells["Warranty"].FormattedValue.ToString();
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            //update
            date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            try
            {
                if (titemname.Text == "" || tprice.Text == "" || twarranty.Text == "" || tcolor.Text == "" || tmaterial.Text == "" || cbcategory.Text == "Select")
                    throw new ArgumentException();
                else
                {
                    if (MessageBox.Show("Are You Sure want to Update ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.cmd.CommandText = "update Inventory set Name='" + titemname.Text + "',Date='" + date + "',Category='" + cbcategory.SelectedItem.ToString() + "',Color='" + tcolor.Text + "',Material='" + tmaterial.Text + "',Price='" + tprice.Text + "',Warranty='" + twarranty.Text + "',Qty='"+tqty.Text+"' where Item_Id='" + itemid + "'";
                        c.cmd.ExecuteNonQuery();
                        c.cmd.CommandText = "Select Qty from Inventory where Item_Id='" + itemid + "'";
                        int qt = Convert.ToInt32(c.cmd.ExecuteScalar());
                        if (qt <= 0)
                        {
                            c.cmd.CommandText = "update Inventory set Status ='Inactive',Qty=0 where Item_Id='" + itemid + "'";
                            c.cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            c.cmd.CommandText = "update Inventory set Qty =" + qt + ",Status ='Active' where Item_Id='" + itemid + "'";
                            c.cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Inventory Updated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        dataGridView1.Rows[0].Cells[0].Selected = true;
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
            //delete
            c.cmd.CommandText = "select Status from Inventory where Item_Id='" + itemid + "'";
            if (Convert.ToString(c.cmd.ExecuteScalar()) == "Inactive")
            {
                msg.Visible = true;
                msg.Text = "Item already Inactivated!";
            }
            else
            {
                if (MessageBox.Show("Are You Sure want to Inactivate " + titemname.Text + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "update Inventory set Status='Inactive',Qty=0 where Item_Id='" + itemid + "'";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Inactivated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            searchitem.Text = "Search...";
            filter.ResetText();
            filter.Text = "Sort By";
            displayall();
        }

        private void cbinactive_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox inactive
            searchitem.Text = "Search...";
            filter.ResetText();
            filter.Text = "Sort By";
            displayall();
        }

        private void tcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        private void tmaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        private void searchitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void titemname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar));
        }
    }
}