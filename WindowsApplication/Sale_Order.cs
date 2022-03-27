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
    public partial class Sale_Order : Form
    {
        Connect c = new Connect();
        string cno, itemid,soid;
        public Sale_Order()
        {
            InitializeComponent();
        }

        private void Sale_Order_Load(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.datagridviewstyle(dgvinventoryd);
            s.datagridviewstyle(dgvcustomerd);
            s.datagridviewstyle(dgvsaleorder);
            dgvinventoryd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayall();
        }

        private void displayall()
        {
            dgvcustomerd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvsaleorder.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvinventoryd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlDataAdapter sda = new SqlDataAdapter("select Item_Id,Name,Qty,Material,Color,Category from Inventory where Status='Inactive'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvinventoryd.DataSource = ds.Tables["dt"];

            SqlDataAdapter adp = new SqlDataAdapter("select Name,Contact_No,Address from Customer", c.cn);
            DataSet ds1 = new DataSet();
            adp.Fill(ds1, "dt1");
            dgvcustomerd.DataSource = ds1.Tables["dt1"];

            SqlDataAdapter adp2 = new SqlDataAdapter("select Sale_Order.SO_No,Sale_Order.Date,Sale_Order.Contact_No,Sale_Order.Item_Id,Inventory.Name from Sale_Order inner join Inventory on Sale_Order.Item_Id=Inventory.Item_Id", c.cn);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2, "dt2");
            dgvsaleorder.DataSource = ds2.Tables["dt2"];
        }

        private void clearall()
        {
            searchcno.Text = "search...";
            searchcno.ForeColor = Color.Silver;
            searchitem.Text = "search...";
            searchitem.ForeColor = Color.Silver;
            tsearch.Text = "search...";
            tsearch.ForeColor = Color.Silver;
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
            SqlDataAdapter sda = new SqlDataAdapter("select Item_Id,Name,Qty,Material,Color,Category from Inventory where Status='Inactive' and Name like '" + searchitem.Text + "%'", c.cn);
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

        private void tsearch_KeyUp(object sender, KeyEventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Sale_Order.SO_No,Sale_Order.Date,Sale_Order.Contact_No,Sale_Order.Item_Id,Inventory.Name from Sale_Order inner join Inventory on Sale_Order.Item_Id=Inventory.Item_Id where Sale_Order.Contact_No like '" + tsearch.Text + "%' or Inventory.Name like '" + tsearch.Text + "%'", c.cn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dt");
            dgvsaleorder.DataSource = ds.Tables["dt"];
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

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            if (!(dgvinventoryd.SelectionMode == DataGridViewSelectionMode.FullRowSelect))
                MessageBox.Show("please select Item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!(dgvcustomerd.SelectionMode == DataGridViewSelectionMode.FullRowSelect))
                MessageBox.Show("please select Customer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.cmd.CommandText = "select Count(*) from Sale_Order";
                    int cnt = Convert.ToInt16(c.cmd.ExecuteScalar());
                    cnt++;
                    soid = "so" + cnt;
                    String date = DateTime.Now.ToString("MM-dd-yyyy");
                    c.cmd.CommandText = "insert into Sale_Order (SO_No,Date,Item_Id,Contact_No) values('" + soid + "','" + date + "','" + itemid + "','" + cno + "')";
                    c.cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Placed Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayall();
                    clearall();
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            displayall();
            clearall();
        }

        private void searchitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar));
        }

        private void tsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar));
        }
    }
}