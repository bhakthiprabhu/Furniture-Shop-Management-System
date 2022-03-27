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
    public partial class Purchase_Return : Form
    {
        Connect c = new Connect();
        String prid,itemid,pitemid;
        int qty;
        public Purchase_Return()
        {
            InitializeComponent();
        }

        private void Purchase_Return_Load(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.datagridviewstyle(dgvpurbil);
            s.datagridviewstyle(dgvpreturn);
            btnnext.Enabled = false;
            dateTimePicker1.Value = DateTime.Today;
            dropdownpurchasereturn();
        }

        private void dropdownpurchasereturn()
        {
            SqlCommand sc = new SqlCommand("select distinct Purchase_Bill.PB_No from Purchase_Bill inner join Purchase_Order on Purchase_Order.PO_No = Purchase_Bill.PO_No where Purchase_Order.Status='Invoiced'", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            cbpbno.DataSource = ds.Tables[0];
            cbpbno.DisplayMember = "PB_No";
            cbpbno.ValueMember = "PB_No";
            cbpbno.Text = "Select";
        }

        private void displayall()
        {
            dgvpurbil.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter adp1 = new SqlDataAdapter("select distinct Purchase_Bill_Detail.Item_Id,Inventory.Name,Purchase_Bill_Detail.Qty from Purchase_Bill_Detail inner join Inventory on Purchase_Bill_Detail.Item_Id = Inventory.Item_Id inner join Purchase_Order_Detail on Purchase_Order_Detail.Item_Id = Inventory.Item_Id where Purchase_Bill_Detail.PB_No='" + cbpbno.Text + "' ", c.cn);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1, "dt1");
            dgvpurbil.DataSource = ds1.Tables["dt1"];
        }

        private void displayall1()
        {
            dgvpreturn.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter adp1 = new SqlDataAdapter("select Purchase_Return_Detail.PR_No,Purchase_Return_Detail.Item_Id,Purchase_Return_Detail.Qty from Purchase_Return_Detail inner join Purchase_Return on Purchase_Return_Detail.PR_No=Purchase_Return.PR_No where Purchase_Return.PR_No='" + prid + "'", c.cn);
            DataSet ds2 = new DataSet();
            adp1.Fill(ds2, "dt2");
            dgvpreturn.DataSource = ds2.Tables["dt2"];
        }

        private void clearall()
        {
            dateTimePicker1.Text = "";
            tqty.Text = "";
            dateTimePicker1.Enabled = true;
            btnnext.Enabled = false;
            btnsave.Enabled = true;
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            cbpbno.Enabled = true;
            cbpbno.Text = "Select";
            tsupid.Text = "";
            tsupname.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cbpbno.Text == "Select" || cbpbno.Text == "")
                MessageBox.Show("please select Purchase Bill Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dateTimePicker1.Enabled = false;
                SqlCommand cmd = new SqlCommand("Select * from Purchase_Return where PB_No is Null", c.cn);
                DataTable dtb = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dtb);
                foreach (DataRow r in dtb.Rows)
                {
                    c.cmd.CommandText = "delete from Purchase_Return_Detail where PR_No='" + r["PR_No"] + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "delete from Purchase_Return where PR_No='" + r["PR_No"] + "'";
                    c.cmd.ExecuteNonQuery();
                }
                c.cmd.CommandText = "select Count(*) from Purchase_Return";
                int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                cnt++;
                prid = "pr" + cnt;
                c.cmd.CommandText = "insert into Purchase_Return(PR_No) values('" + prid + "')";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnnext.Enabled = true;
                btnsave.Enabled = false;
                cbpbno.Enabled = false;
                displayall();
                c.cmd.CommandText = "select Purchase_Order.Sup_Id from Purchase_Order inner join Purchase_Bill on Purchase_Order.PO_No=Purchase_Bill.PO_No where PB_No='" + cbpbno.Text + "' ";
                tsupid.Text = c.cmd.ExecuteScalar().ToString();
                c.cmd.CommandText = "select Name from Supplier where Sup_Id='" + tsupid.Text + "' ";
                tsupname.Text = c.cmd.ExecuteScalar().ToString();
            }
        }

        private void dgvpurbil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpurbil.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvpurbil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvpurbil.CurrentRow.Selected = true;
                itemid = dgvpurbil.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
                qty = Convert.ToInt32(dgvpurbil.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString());
                tqty.Text = qty.ToString();
            }
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
                SqlCommand cmd = new SqlCommand("select PR_No,Item_Id,Qty from Purchase_Return_Detail where PR_No='" + prid + "' and Item_Id='" + itemid + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                c.cmd.CommandText = "Select Qty from Inventory where Item_Id='" + itemid + "'";
                int iqty = Convert.ToInt32(c.cmd.ExecuteScalar());
                if (!(dgvpurbil.SelectionMode == DataGridViewSelectionMode.FullRowSelect))
                    MessageBox.Show("please select Item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tqty.Text == "" || tqty.Text == "0")
                    errorProvider1.SetError(tqty, "Required!");
                else if (Convert.ToInt16(tqty.Text) > qty)
                    errorProvider1.SetError(tqty, "Quantity should be equal or less than specified!");
                else if (Convert.ToInt16(tqty.Text) > iqty)
                    errorProvider1.SetError(tqty, "Invalid Quantity!\nQuantity is greater than the actual quantity of Items in Stock!");
                else if (dt.Rows.Count > 0)
                    MessageBox.Show("You already added this item.\nPlease edititem if you want to make changes.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    c.cmd.CommandText = "insert into Purchase_Return_Detail (PR_No,Item_Id,Qty) values('" + prid + "','" + itemid + "'," + tqty.Text + ")";
                    c.cmd.ExecuteNonQuery();
                    tqty.Text = "";
                    displayall1();
                    displayall();
                }
            }
            catch (OverflowException)
            {
                errorProvider1.SetError(tqty, "Invalid quantity!");
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select Count(*) from Purchase_Return_Detail where PR_No='" + prid + "'";
            int rc = Convert.ToInt16(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select Count(*) from Purchase_Return where PR_No='" + prid + "'";
            int rc2 = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (rc >= 1 && rc2 == 1)
            {
                if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                    c.cmd.CommandText = "update Purchase_Return set PB_No='" + cbpbno.Text + "',Date='" + date + "' where PR_No='" + prid + "'";
                    c.cmd.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand("select * from Purchase_Return_Detail where PR_No='" + prid + "'", c.cn);
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
                    MessageBox.Show("Purchase Returned Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearall();
                    prid = null;
                    displayall();
                    displayall1();
                }
            }
            else
                MessageBox.Show("You have not stored the details!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select Count(*) from Purchase_Return_Detail where PR_No='" + prid + "'";
            int rc1 = Convert.ToInt16(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select Count(*) from Purchase_Return where PR_No='" + prid + "'";
            int rc2 = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (rc1 >= 1 && rc2 == 1)
            {
                if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "delete from Purchase_Return_Detail where PR_No='" + prid + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "delete from Purchase_Return where PR_No='" + prid + "'";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Purchase return Cancelled!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearall();
                    prid = null;
                    displayall();
                    displayall1();
                }
            }
            else
                MessageBox.Show("You have not stored the details!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tqty_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void dgvpreturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpreturn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                ndelete.Enabled = true;
                btnnext.Enabled = false;
                dgvpreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvpreturn.CurrentRow.Selected = true;
                tqty.Text = dgvpreturn.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString();
                pitemid = dgvpreturn.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            if (tqty.Text == "" || tqty.Text == "0")
                errorProvider1.SetError(tqty, "Required!");
            else if (Convert.ToInt16(tqty.Text) > qty)
                errorProvider1.SetError(tqty, "Quantity should be equal or less than specified!");
            else
            {
                c.cmd.CommandText = "update Purchase_Return_Detail set Qty=" + tqty.Text + " where PR_No='" + prid + "' and Item_Id='" + pitemid + "' ";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tqty.Text = "";
                displayall();
                displayall1();
                nupdate.Enabled = false;
                ndelete.Enabled = false;
                btnnext.Enabled = true;
            }
        }

        private void ndelete_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "delete from Purchase_Return_Detail where PR_No='" + prid + "' and Item_Id='" + pitemid + "'";
            c.cmd.ExecuteNonQuery();
            MessageBox.Show("Item Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tqty.Text = "";
            displayall1();
            displayall();
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            btnnext.Enabled = true;
        }   
    }
}