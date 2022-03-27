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
    public partial class Purchase_Bill : Form
    {
        Connect c = new Connect();
        String pbid,itemid,pitemid;
        int qty;
        double totalamt;
        public Purchase_Bill()
        {
            InitializeComponent();
        }

        private void Purchase_Bill_Load(object sender, EventArgs e)
        {
            //page load
            Supplier s = new Supplier();
            s.datagridviewstyle(dgvpurchasebilld);
            s.datagridviewstyle(dgvpurchaseoraderd);
            btnnext.Enabled = false;
            dateTimePicker1.Value = DateTime.Today;
            dropdownpurchaseorer();
        }

        private void dropdownpurchaseorer()
        {
            SqlCommand sc = new SqlCommand("select distinct Purchase_Order.PO_No from Purchase_Order inner join Purchase_Order_Detail on Purchase_Order.PO_No=Purchase_Order_Detail.PO_No where Purchase_Order.Status='Ordered'", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            cbpurchaseorder.DataSource = ds.Tables[0];
            cbpurchaseorder.DisplayMember = "PO_No";
            cbpurchaseorder.ValueMember = "PO_No";
            cbpurchaseorder.Text = "Select";
        }

        private void displayall()
        {
            dgvpurchaseoraderd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter adp1 = new SqlDataAdapter("select Purchase_Order_Detail.Item_Id,Inventory.Name,Purchase_Order_Detail.Qty,Inventory.Price,Inventory.Warranty from Purchase_Order_Detail inner join Purchase_Order on Purchase_Order.PO_No = Purchase_Order_Detail.PO_No inner join Inventory on Purchase_Order_Detail.Item_Id = Inventory.Item_Id where Purchase_Order.PO_No='" + cbpurchaseorder.Text + "' ", c.cn);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1, "dt1");
            dgvpurchaseoraderd.DataSource = ds1.Tables["dt1"];
        }

        private void displayall1()
        {
            dgvpurchasebilld.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter adp1 = new SqlDataAdapter("select PB_No,Item_Id,Qty,Price,Amount,Warranty from Purchase_Bill_Detail where PB_No='" + pbid + "' ", c.cn);
            DataSet ds2 = new DataSet();
            adp1.Fill(ds2, "dt2");
            dgvpurchasebilld.DataSource = ds2.Tables["dt2"];
        }

        private void totalamts()
        {
            c.cmd.CommandText = "Select Amount from Purchase_Bill_Detail where PB_No='" + pbid + "'";
            if (!(c.cmd.ExecuteScalar() == null))
            {
                c.cmd.CommandText = "Select sum(Amount) from Purchase_Bill_Detail where PB_No='" + pbid + "'";
                totalamt = Convert.ToDouble(c.cmd.ExecuteScalar());
                ttamt.Text = totalamt.ToString();
            }
            else
                ttamt.Text = "";
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
            cbpurchaseorder.Enabled = true;
            cbpurchaseorder.Text = "Select";
            tsupid.Text = "";
            tsupname.Text = "";
            ttamt.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cbpurchaseorder.Text == "Select" || cbpurchaseorder.Text == "")
                MessageBox.Show("please select Purchase Order Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dateTimePicker1.Enabled = false;
                SqlCommand cmd = new SqlCommand("Select * from Purchase_Bill where Total_Amount is Null", c.cn);
                DataTable dtb = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dtb);
                foreach (DataRow r in dtb.Rows)
                {
                    c.cmd.CommandText = "delete from Purchase_Bill_Detail where PB_No='" + r["PB_No"] + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "delete from Purchase_Bill where PB_No='" + r["PB_No"] + "'";
                    c.cmd.ExecuteNonQuery();
                }
                c.cmd.CommandText = "select Count(*) from Purchase_Bill";
                int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                cnt++;
                pbid = "pb" + cnt;
                String date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                c.cmd.CommandText = "insert into Purchase_Bill(PB_No,Date,PO_No) values('" + pbid + "','"+date+"','"+cbpurchaseorder.Text+"')";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnnext.Enabled = true;
                btnsave.Enabled = false;
                cbpurchaseorder.Enabled = false;
                displayall();
                c.cmd.CommandText = "select Sup_Id from Purchase_Order where PO_No='" + cbpurchaseorder.Text + "' ";
                tsupid.Text = c.cmd.ExecuteScalar().ToString();
                c.cmd.CommandText = "select Name from Supplier where Sup_Id='" + tsupid.Text + "' ";
                tsupname.Text = c.cmd.ExecuteScalar().ToString();
            }
        }

        private void dgvpurchaseoraderd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpurchaseoraderd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvpurchaseoraderd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvpurchaseoraderd.CurrentRow.Selected = true;
                itemid = dgvpurchaseoraderd.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
                qty = Convert.ToInt32(dgvpurchaseoraderd.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString());
                tprice.Text = dgvpurchaseoraderd.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                twarranty.Text = dgvpurchaseoraderd.Rows[e.RowIndex].Cells["Warranty"].FormattedValue.ToString();
                tqty.Text = qty.ToString();
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
            try
            {
                SqlCommand cmd = new SqlCommand("select PB_No,Item_Id,Qty,Price,Amount,Warranty from Purchase_Bill_Detail where PB_No='" + pbid + "' and Item_Id='" + itemid + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (!(dgvpurchaseoraderd.SelectionMode == DataGridViewSelectionMode.FullRowSelect))
                    MessageBox.Show("please select Item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tqty.Text == "" || tqty.Text == "0")
                    errorProvider1.SetError(tqty, "Required!");
                else if (Convert.ToInt16(tqty.Text) > qty)
                    errorProvider1.SetError(tqty, "Quantity should be equal or less than specified!");
                else if (tprice.Text == "" || tprice.Text == "0.0" || tprice.Text == "0")
                    errorProvider2.SetError(tprice, "Required!");
                else if (twarranty.Text == "")
                    errorProvider3.SetError(twarranty, "Required!");
                else if (dt.Rows.Count > 0)
                    MessageBox.Show("You already added this item.\nPlease edititem if you want to make changes.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    double amt = Convert.ToDouble(tqty.Text) * Convert.ToDouble(tprice.Text);
                    c.cmd.CommandText = "insert into Purchase_Bill_Detail (PB_No,Item_Id,Qty,Price,Amount,Warranty) values('" + pbid + "','" + itemid + "'," + tqty.Text + "," + tprice.Text + "," + amt + "," + twarranty.Text + ")";
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

        private void btngeneratebil_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select Count(*) from Purchase_Bill_Detail where PB_No='" + pbid + "'";
            int rc = Convert.ToInt16(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select Count(*) from Purchase_Bill where PB_No='" + pbid + "'";
            int rc2 = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (rc >= 1 && rc2 == 1)
            {
                if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "update Purchase_Bill set Total_Amount=" + ttamt.Text+ " where PB_No='" + pbid + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "update Purchase_Order set Status='Invoiced' where PO_No='" + cbpurchaseorder.Text + "'";
                    c.cmd.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand("select * from Purchase_Bill_Detail where PB_No='" + pbid + "'", c.cn);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    foreach (DataRow r in dt.Rows)
                    {
                        c.cmd.CommandText = "Select Qty from Inventory where Item_Id='" + r["Item_Id"] + "'";
                        int qt = Convert.ToInt32(c.cmd.ExecuteScalar());
                        c.cmd.CommandText = "update Inventory set Qty=" + qt + "+" + r["Qty"] + ",Price=" + r["Price"] + ",Warranty=" + r["Warranty"] + ",Status='Active' where Item_Id='" + r["Item_Id"] + "'";
                        c.cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Bill generated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearall();
                    dropdownpurchaseorer();
                    pbid = null;
                    displayall();
                    displayall1();
                    ttamt.Text = "";
                }
            }
            else
                MessageBox.Show("You have not stored the details!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select Count(*) from Purchase_Bill_Detail where PB_No='" + pbid+ "'";
            int rc1 = Convert.ToInt16(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select Count(*) from Purchase_Bill where PB_No='" + pbid + "'";
            int rc2 = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (rc1 >= 1 && rc2 == 1)
            {
                if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "delete from Purchase_Bill_Detail where PB_No='" + pbid + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "delete from Purchase_Bill where PB_No='" + pbid + "'";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Generation Cancelled!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dropdownpurchaseorer();
                    clearall();
                    pbid = null;
                    displayall();
                    displayall1();
                    ttamt.Text = "";
                }
            }
            else
                MessageBox.Show("You have not stored the details!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvpurchasebilld_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpurchasebilld.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                ndelete.Enabled = true;
                btnnext.Enabled = false;
                dgvpurchasebilld.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvpurchasebilld.CurrentRow.Selected = true;
                tqty.Text = dgvpurchasebilld.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString();
                tprice.Text = dgvpurchasebilld.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                twarranty.Text = dgvpurchasebilld.Rows[e.RowIndex].Cells["Warranty"].FormattedValue.ToString();
                pitemid = dgvpurchasebilld.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
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
                else if (twarranty.Text == "")
                    errorProvider3.SetError(twarranty, "Required!");
                else
                {
                    double amt = Convert.ToDouble(tqty.Text) * Convert.ToDouble(tprice.Text);
                    c.cmd.CommandText = "update Purchase_Bill_Detail set Qty=" + tqty.Text + ",Price=" + tprice.Text + ",Warranty=" + twarranty.Text + ",Amount=" + amt + " where PB_No='" + pbid + "' and Item_Id='" + pitemid + "' ";
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
            c.cmd.CommandText = "delete from Purchase_Bill_Detail where PB_No='" + pbid + "' and Item_Id='" + pitemid + "'";
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

        private void tqty_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void tprice_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void twarranty_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }
    }
}