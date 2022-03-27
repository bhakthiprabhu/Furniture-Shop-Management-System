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
    public partial class Sale_Bill : Form
    {
        Connect c = new Connect();
        String itemid, cno,sbid,pitemid,username;
        int qty;
        double totalamt,netamt,discount;
        public Sale_Bill(string str)
        {
            username = str;
            InitializeComponent();
        }

        private void Sale_Bill_Load(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.datagridviewstyle(dgvsalebilld);
            s.datagridviewstyle(dgvcustomerd);
            s.datagridviewstyle(dgvinventoryd);
            dgvinventoryd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvsalebilld.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            btnnext.Enabled = false;
            dateTimePicker1.Value = DateTime.Today;
            displayall1();
            display();
        }

        private void display()
        {
            dgvcustomerd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter adp = new SqlDataAdapter("select Name,Contact_No,Address from Customer", c.cn);
            DataSet ds1 = new DataSet();
            adp.Fill(ds1, "dt1");
            dgvcustomerd.DataSource = ds1.Tables["dt1"];
        }

        private void displayall1()
        {
            dgvinventoryd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter sda = new SqlDataAdapter("select Item_Id,Name,Qty,Price,Material,Color,Category,Warranty from Inventory where Status='Active'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvinventoryd.DataSource = ds.Tables["dt"];
        }

        private void displayall()
        {
            dgvsalebilld.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvinventoryd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter sda = new SqlDataAdapter("select Item_Id,Name,Qty,Price,Material,Color,Category,Warranty from Inventory where Status='Active'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvinventoryd.DataSource = ds.Tables["dt"];
            
            SqlDataAdapter adp1 = new SqlDataAdapter("select Sale_Bill_Detail.SB_No,Sale_Bill_Detail.Item_Id,Sale_Bill_Detail.Qty,Sale_Bill_Detail.Rate,Sale_Bill_Detail.Price,Sale_Bill_Detail.Tax,Sale_Bill_Detail.Amount,Inventory.Warranty from Sale_Bill_Detail inner join Inventory on Sale_Bill_Detail.Item_Id=Inventory.Item_Id where SB_No='" + sbid + "' ", c.cn);
            DataSet ds2 = new DataSet();
            adp1.Fill(ds2, "dt2");
            dgvsalebilld.DataSource = ds2.Tables["dt2"];
        }

        private void clearall()
        {
            dateTimePicker1.Text = "";
            tqty.Text = "";
            tprice.Text = "";
            twarranty.Text = "";
            dateTimePicker1.Enabled = true;
            btnnext.Enabled = false;
            btnsave.Enabled = true;
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            ttamt.Text = "";
            tnetamt.Text = "";
            tdiscount.Text = "";
            searchcno.Text = "search...";
            searchcno.ForeColor = Color.Silver;
            searchitem.Text = "search...";
            searchitem.ForeColor = Color.Silver;
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
            SqlDataAdapter sda = new SqlDataAdapter("select Item_Id,Name,Qty,Price,Material,Color,Category,Warranty from Inventory where Status='Active' and Name like '" + searchitem.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvinventoryd.DataSource = ds.Tables["dt"];
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from Customer where Contact_No like '" + searchcno.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvcustomerd.DataSource = ds.Tables["dt"];
        }

        private void searchcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvinventoryd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvinventoryd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvinventoryd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvinventoryd.CurrentRow.Selected = true;
                itemid = dgvinventoryd.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
                qty = Convert.ToInt32(dgvinventoryd.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString());
                twarranty.Text = dgvinventoryd.Rows[e.RowIndex].Cells["Warranty"].FormattedValue.ToString();
            }
        }

        private void dgvcustomerd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcustomerd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvcustomerd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvcustomerd.CurrentRow.Selected = true;
                cno = dgvcustomerd.Rows[e.RowIndex].Cells["Contact_No"].FormattedValue.ToString();
            }
        }

        private void totalamts()
        {
            c.cmd.CommandText = "Select Amount from Sale_Bill_Detail where SB_No='" + sbid + "'";
            if (!(c.cmd.ExecuteScalar() == null))
            {
                c.cmd.CommandText = "Select sum(Amount) from Sale_Bill_Detail where SB_No='" + sbid + "'";
                totalamt = Convert.ToDouble(c.cmd.ExecuteScalar());
                ttamt.Text = Math.Round(totalamt,2).ToString();
                if (totalamt >= 10000.0)
                    discount = totalamt * 0.15;
                else if (totalamt >= 5000.0 )
                    discount = totalamt * 0.1;
                else if (totalamt >= 1000.0 && totalamt<5000.0)
                    discount = totalamt * 0.05;
                else
                    discount = totalamt * 0.0;
                tdiscount.Text =Math.Round(discount,2).ToString();
                netamt = totalamt - discount;
                tnetamt.Text =Math.Round(netamt,2).ToString();
            }
            else
            {
                ttamt.Text = "";
                tnetamt.Text = "";
                tdiscount.Text = "";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!(dgvcustomerd.SelectionMode == DataGridViewSelectionMode.FullRowSelect))
                MessageBox.Show("please select Customer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                groupBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
                SqlCommand cmd = new SqlCommand("Select * from Sale_Bill where Total_Amount is Null", c.cn);
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    c.cmd.CommandText = "delete from Sale_Bill_Detail where SB_No='" + r["SB_No"] + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "delete from Sale_Bill where SB_No='" + r["SB_No"] + "'";
                    c.cmd.ExecuteNonQuery();
                }
                c.cmd.CommandText = "select Count(*) from Sale_Bill";
                int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                cnt++;
                sbid = "sb" + cnt;
                String date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                c.cmd.CommandText = "insert into Sale_Bill(SB_No,Date,Contact_No) values('" + sbid + "','" + date + "','" + cno + "')";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnnext.Enabled = true;
                btnsave.Enabled = false;
            }
        }

        private void tprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceept only decimal numbers
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

        private void twarranty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceept only decimal numbers
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

        private void tqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select SB_No,Item_Id,Qty,Rate,Price,Tax,Amount from Sale_Bill_Detail where SB_No='" + sbid + "' and Item_Id='" + itemid + "'", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            try
            {
                if (!(dgvinventoryd.SelectionMode == DataGridViewSelectionMode.FullRowSelect))
                    MessageBox.Show("please select Item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tqty.Text == "" || tqty.Text == "0")
                    errorProvider1.SetError(tqty, "Required!");
                else if (Convert.ToInt64(tqty.Text) > qty)
                    errorProvider1.SetError(tqty, "Quantity should be equal or less than specified!");
                else if (tprice.Text == "" || tprice.Text == "0.0" || tprice.Text == "0")
                    errorProvider2.SetError(tprice, "Required!");
                else if (dt.Rows.Count > 0)
                    MessageBox.Show("You already added this item.\nPlease edit item if you want to make changes.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    double price = Convert.ToDouble(tqty.Text) * Convert.ToDouble(tprice.Text);
                    double tax = price * 0.18;
                    double amt = price + tax;
                    c.cmd.CommandText = "insert into Sale_Bill_Detail (SB_No,Item_Id,Qty,Rate,Price,Tax,Amount) values('" + sbid + "','" + itemid + "'," + tqty.Text + "," + tprice.Text + "," + price + "," + tax + "," + amt + ")";
                    c.cmd.ExecuteNonQuery();
                    tqty.Text = "";
                    tprice.Text = "";
                    twarranty.Text = "";
                    displayall1();
                    displayall();
                    totalamts();
                }
            }
            catch (OverflowException)
            {
                errorProvider1.SetError(tqty, "Invalid Quantity!");
            }
            catch (SqlException)
            {
                errorProvider2.SetError(tprice, "Invalid Price!");
            }
        }

        private void tqty_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void tprice_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void btngeneratebil_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select Count(*) from Sale_Bill_Detail where SB_No='" + sbid + "'";
            int rc = Convert.ToInt16(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select Count(*) from Sale_Bill where SB_No='" + sbid + "'";
            int rc2 = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (rc >= 1 && rc2 == 1)
            {
              if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "update Sale_Bill set Total_Amount=" + ttamt.Text + ",Discount="+tdiscount.Text+",Net_Amount="+tnetamt.Text+" where SB_No='" + sbid + "'";
                    c.cmd.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("select * from Sale_Bill_Detail where SB_No='" + sbid + "'", c.cn);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    foreach (DataRow r in dt.Rows)
                    {
                        c.cmd.CommandText = "Select Qty from Inventory where Item_Id='" + r["Item_Id"] + "'";
                        int qt = Convert.ToInt32(c.cmd.ExecuteScalar());
                        qt = qt - Convert.ToInt32(r["Qty"]);
                        if (qt <= 0)
                        {
                            c.cmd.CommandText = "update Inventory set Status ='Inactive',Qty=0 where Item_Id='" + r["Item_Id"] + "'";
                            c.cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            c.cmd.CommandText = "update Inventory set Qty =" + qt + " where Item_Id='" + r["Item_Id"] + "'";
                            c.cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Bill generated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Sale_Bill_Print(sbid,username).Show();
                    clearall();
                    sbid = null;
                    displayall();
                    displayall1();
                    display();
                    ttamt.Text = "";
                    tprice.Text = "";
                    twarranty.Text = "";
                    groupBox1.Enabled = true;
                }            
            }
            else
                MessageBox.Show("You have not stored the details!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select Count(*) from Sale_Bill_Detail where SB_No='" + sbid + "'";
            int rc = Convert.ToInt16(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select Count(*) from Sale_Bill where SB_No='" + sbid + "'";
            int rc2 = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (rc >= 1 && rc2 == 1)
            {
                if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "delete from Sale_Bill_Detail where SB_No='" + sbid + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "delete from Sale_Bill where SB_No='" + sbid + "'";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Generation Cancelled!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearall();
                    sbid = null;
                    displayall();
                    displayall1();
                    display();
                    ttamt.Text = "";
                    tprice.Text = "";
                    twarranty.Text = "";
                    groupBox1.Enabled = true;
                }
            }
            else
                MessageBox.Show("You have not stored the details!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvsalebilld_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsalebilld.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                ndelete.Enabled = true;
                btnnext.Enabled = false;
                dgvsalebilld.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvsalebilld.CurrentRow.Selected = true;
                tqty.Text = dgvsalebilld.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString();
                tprice.Text = dgvsalebilld.Rows[e.RowIndex].Cells["Rate"].FormattedValue.ToString();
                twarranty.Text = dgvsalebilld.Rows[e.RowIndex].Cells["Warranty"].FormattedValue.ToString();
                pitemid = dgvsalebilld.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tqty.Text == "" || tqty.Text == "0")
                    errorProvider1.SetError(tqty, "Required!");
                else if (Convert.ToInt16(tqty.Text) > qty)
                    errorProvider1.SetError(tqty, "Quantity should be equal or less than specified!");
                else if (tprice.Text == "" || tprice.Text == "0")
                    errorProvider2.SetError(tprice, "Required!");
                else
                {
                    double price = Convert.ToDouble(tqty.Text) * Convert.ToDouble(tprice.Text);
                    double tax = price * 0.18;
                    double amt = price + tax;
                    c.cmd.CommandText = "update Sale_Bill_Detail set Qty=" + tqty.Text + ",Rate=" + tprice.Text + ",Price=" + price + ",Tax=" + tax + ",Amount=" + amt + " where SB_No='" + sbid + "' and Item_Id='" + pitemid + "' ";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tqty.Text = "";
                    tprice.Text = "";
                    twarranty.Text = "";
                    displayall();
                    displayall1();
                    totalamts();
                    nupdate.Enabled = false;
                    ndelete.Enabled = false;
                    btnnext.Enabled = true;
                }
            }
            catch (OverflowException)
            {
                errorProvider1.SetError(tqty, "Invalid Quantity!");
            }
            catch (SqlException)
            {
                errorProvider2.SetError(tprice, "Invalid Price!");
            }
        }

        private void ndelete_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "delete from Sale_Bill_Detail where SB_No='" + sbid+ "' and Item_Id='" + pitemid + "'";
            c.cmd.ExecuteNonQuery();
            MessageBox.Show("Item Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            totalamts();
            tqty.Text = "";
            tprice.Text = "";
            twarranty.Text = "";
            displayall1();
            displayall();
            totalamts();
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            btnnext.Enabled = true;
        }

        private void searchitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar));
        }

    }
}