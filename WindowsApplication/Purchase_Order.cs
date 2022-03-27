using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace WindowsApplication
{
    public partial class Purchase_Order : Form
    {
        Connect c = new Connect();
        String itemid,supid,poid,pitemid,supname;
        int qty;
        public Purchase_Order()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            //page load
            Supplier s = new Supplier();
            s.datagridviewstyle(dgvinventoryd);
            s.datagridviewstyle(dgvsupplierd);
            s.datagridviewstyle(dgvpurchaseorderd);
            dgvinventoryd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayall();
            btnnextpur.Enabled = false;
            dateTimePicker1.Value = DateTime.Today;
            
        }

        private void displayall()
        {
            dgvsupplierd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvinventoryd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter sda = new SqlDataAdapter("select Item_Id,Name,Qty,Material,Color,Category from Inventory ", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvinventoryd.DataSource = ds.Tables["dt"];

            SqlDataAdapter adp = new SqlDataAdapter("select Sup_Id,Name,Contact_No from Supplier where Status='Active'", c.cn);
            DataSet ds1 = new DataSet();
            adp.Fill(ds1, "dt1");
            dgvsupplierd.DataSource = ds1.Tables["dt1"];
        }

        private void displayall1()
        {
            dgvpurchaseorderd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvinventoryd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter sda = new SqlDataAdapter("select Item_Id,Name,Qty,Material,Color,Category from Inventory ", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvinventoryd.DataSource = ds.Tables["dt"];

            SqlDataAdapter adp1 = new SqlDataAdapter("select Purchase_Order_Detail.PO_No,Purchase_Order.Sup_Id,Purchase_Order_Detail.Item_Id,Inventory.Name,Purchase_Order_Detail.Qty from Purchase_Order_Detail inner join Purchase_Order on Purchase_Order_Detail.PO_No=Purchase_Order.PO_No inner join Inventory on Purchase_Order_Detail.Item_Id= Inventory.Item_Id where Purchase_Order.PO_No='" + poid + "' ", c.cn);
            DataSet ds2 = new DataSet();
            adp1.Fill(ds2, "dt2");
            dgvpurchaseorderd.DataSource = ds2.Tables["dt2"];
        }

        private void clearall()
        {
            dateTimePicker1.Text = "";
            tqty.Text = "";
            vsupname.Text = "search...";
            vsupname.ForeColor = Color.Silver;
            searchitem.Text = "search...";
            searchitem.ForeColor = Color.Silver;
            groupBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            btnnextpur.Enabled = false;
            btnsave.Enabled = true;
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            groupBox2.Enabled = true;

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
            SqlDataAdapter sda = new SqlDataAdapter("select Sup_Id,Name,Contact_No from Supplier where Status='Active' and Name like '" + vsupname.Text + "%' or Status='Active' and Sup_Id like '" + vsupname.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvsupplierd.DataSource = ds.Tables["dt"];
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
            SqlDataAdapter sda = new SqlDataAdapter("select Item_Id,Name,Qty,Material,Color,Category from Inventory where Name like '" + searchitem.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvinventoryd.DataSource = ds.Tables["dt"];
        }

        private void dgvinventoryd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvinventoryd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvinventoryd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvinventoryd.CurrentRow.Selected = true;
                itemid = dgvinventoryd.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
                qty = Convert.ToInt32(dgvinventoryd.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString());
                tqty.Text = qty.ToString();
            }
        }

        private void dgvsupplierd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsupplierd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvsupplierd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvsupplierd.CurrentRow.Selected = true;
                supid = dgvsupplierd.Rows[e.RowIndex].Cells["Sup_Id"].FormattedValue.ToString();
                supname = dgvsupplierd.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!(dgvsupplierd.SelectionMode == DataGridViewSelectionMode.FullRowSelect))
                MessageBox.Show("please select supplier", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                groupBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
                SqlCommand cmd = new SqlCommand("Select * from Purchase_Order where Status is Null", c.cn);
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);                
                foreach (DataRow r in dt.Rows)
                {
                        c.cmd.CommandText = "delete from Purchase_Order_Detail where PO_No='" + r["PO_No"] + "'";
                        c.cmd.ExecuteNonQuery();
                        c.cmd.CommandText="delete from Purchase_Order where PO_No='"+r["PO_No"]+"'";
                        c.cmd.ExecuteNonQuery();
                }
                c.cmd.CommandText = "select Count(*) from Purchase_Order";
                int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                cnt++;
                poid = "po" + cnt;
                String date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                c.cmd.CommandText = "insert into Purchase_Order (PO_No,Sup_Id,Date) values('" + poid + "','" + supid + "','"+date+"' )";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnnextpur.Enabled = true;
                btnsave.Enabled = false;
            }
        }

        private void btnnextpur_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select PO_No,Item_Id,Qty from Purchase_Order_Detail  where PO_No='" + poid + "' and Item_Id='" + itemid + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (!(dgvinventoryd.SelectionMode == DataGridViewSelectionMode.FullRowSelect))
                    MessageBox.Show("please select Item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tqty.Text == "" || tqty.Text == "0")
                    errorProvider1.SetError(tqty, "Required!");
                else if (dt.Rows.Count > 0)
                    MessageBox.Show("You already added this item to place order.\nPlease edititem if you want to make changes.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    c.cmd.CommandText = "insert into Purchase_Order_Detail (PO_No,Item_Id,Qty) values('" + poid + "','" + itemid + "'," + tqty.Text + ")";
                    c.cmd.ExecuteNonQuery();
                    tqty.Text = "";
                    displayall1();
                }
            }
            catch (SqlException)
            {
                errorProvider1.SetError(tqty, "Invalid Quantity!");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select Count(*) from Purchase_Order_Detail where PO_No='" + poid + "'";
            int rc1 = Convert.ToInt16(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select Count(*) from Purchase_Order where PO_No='" + poid + "'";
            int rc2 = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (rc1 >= 1 && rc2 == 1)
            {
                if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "delete from Purchase_Order_Detail where PO_No='" + poid + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "delete from Purchase_Order where PO_No='" + poid + "'";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Cancelled!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    poid = null;
                    clearall();
                    displayall();
                    displayall1();
                }
            }
            else
                MessageBox.Show("You have not saved any details to cancel order!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tqty_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        public string gethtml(DataGridView dgv)
        {
            try
            {
                string mb = "<br><br>Supplier Name : " + supname + "<br><br>PO Id : " + poid + "<br><br>Date : " + DateTime.Now + "<br><br>";
                if (dgv.Rows.Count == 0)
                    return mb;
                string hts = "<table border='1' text-align:center;\">";
                string hte = "</table>";
                string hhrs = "<tr style=\"background-color:#6FA1D2;color:#ffffff;\">";
                string hhre = "</tr>";
                string htrs = "<tr style=\"color:#555555;\">";
                string htre = "</tr>";
                string htds = "<td style=\"border-color:#5c87b2;borer-style:solid;border-width:thin;padding:20px;\">";
                string htde = "</td>";
                mb += hts;
                mb += hhrs;
                mb += htds + "Item ID" + htde;
                mb += htds + "Name" + htde;
                mb += htds + "Quantity" + htde;
                mb += hhre;

                for (int i = 0; i <= dgv.Rows.Count-1; i++)
                {
                    mb = mb + htrs;
                    mb = mb + htds + dgv.Rows[i].Cells[2].Value + htde;
                    mb = mb + htds + dgv.Rows[i].Cells[3].Value + htde;
                    mb = mb + htds + dgv.Rows[i].Cells[4].Value + htde;
                    mb = mb + htre;
                }
                mb = mb + hte;
                mb = mb + "<center><b><h3>Furniture Shop Management System </h3><h5> Renovate Your Home</h5><b></center>";
                return mb;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "select Count(*) from Purchase_Order_Detail where PO_No='" + poid + "'";
            int rc1 = Convert.ToInt16(c.cmd.ExecuteScalar());
            c.cmd.CommandText = "select Count(*) from Purchase_Order where PO_No='" + poid + "'";
            int rc2 = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (rc1 >= 1 && rc2 == 1)
            {
                if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string hs = gethtml(dgvpurchaseorderd);
                    try
                    {
                        c.cmd.CommandText = "select Email from Supplier where Sup_Id='"+supid+"'";
                        String email = Convert.ToString(c.cmd.ExecuteScalar());
                        MailMessage mail = new MailMessage();
                        SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("bhakthiprabhu15@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Purchase Order";
                        mail.Body = hs;
                        mail.IsBodyHtml = true;
                        smtpserver.Port = 587;
                        smtpserver.Credentials = new NetworkCredential("bhakthiprabhu15@gmail.com", "bhakthi15");
                        smtpserver.EnableSsl = true;
                        btnplaceorder.Cursor = Cursors.WaitCursor;
                        smtpserver.Send(mail);
                        c.cmd.CommandText = "update Purchase_Order set Status='Ordered' where PO_No='" + poid + "'";
                        c.cmd.ExecuteNonQuery();
                        MessageBox.Show("Order Placed Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        poid = null;
                        displayall();
                        displayall1();
                        clearall();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No internet connection");
                    }
                }
            }
            else
                MessageBox.Show("You have not saved the details to place order!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvpurchaseorderd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpurchaseorderd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                nupdate.Enabled = true;
                ndelete.Enabled = true;
                groupBox2.Enabled = false;
                btnnextpur.Enabled = false;
                dgvpurchaseorderd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvpurchaseorderd.CurrentRow.Selected = true;
                tqty.Text = dgvpurchaseorderd.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString();
                pitemid = dgvpurchaseorderd.Rows[e.RowIndex].Cells["Item_Id"].FormattedValue.ToString();
            }
        }

        private void nupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tqty.Text == "" || tqty.Text == "0")
                    errorProvider1.SetError(tqty, "Required!");
                else
                {
                    c.cmd.CommandText = "update Purchase_Order_Detail set Qty="+tqty.Text+" where PO_No='"+poid+"' and Item_Id='"+pitemid+"' ";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Quantity Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayall1();
                    nupdate.Enabled = false;
                    ndelete.Enabled = false;
                    groupBox2.Enabled = true;
                    tqty.Text = "";
                    btnnextpur.Enabled = true;
                }
            }
            catch (SqlException)
            {
                errorProvider1.SetError(tqty, "Invalid Quantity!");
            }
        }

        private void ndelete_Click(object sender, EventArgs e)
        {
            c.cmd.CommandText = "delete from Purchase_Order_Detail where PO_No='" + poid + "' and Item_Id='" + pitemid + "'";
            c.cmd.ExecuteNonQuery();
            MessageBox.Show("Item Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayall1();
            nupdate.Enabled = false;
            ndelete.Enabled = false;
            groupBox2.Enabled = true;
            tqty.Text = "";
            btnnextpur.Enabled = true;
        }

        private void tqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void searchitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar));
        }

        private void vsupname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar));
        }
    }
}