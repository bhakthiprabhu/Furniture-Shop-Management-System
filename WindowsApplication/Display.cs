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
    public partial class Display : Form
    {
        Connect c = new Connect();
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            panelpo.BringToFront();
            po.BackColor = Color.FromArgb(24, 123, 205);
            pb.BackColor = Color.Gray;
            pr.BackColor = Color.Gray;
            sb.BackColor = Color.Gray;

            Supplier s = new Supplier();
            s.datagridviewstyle(dgvpo);
            s.datagridviewstyle(dgvpod);
            SqlCommand sc = new SqlCommand("select * from Purchase_Order", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            cbpurchaseorder.DataSource = ds.Tables[0];
            cbpurchaseorder.DisplayMember = "PO_No";
            cbpurchaseorder.ValueMember = "PO_No";
            cbpurchaseorder.Text = "Select";
        }

        private void po_Click(object sender, EventArgs e)
        {
            panelpo.BringToFront();
            panelpo.Show();
            po.BackColor = Color.FromArgb(24, 123, 205);
            pb.BackColor = Color.Gray;
            pr.BackColor = Color.Gray;
            sb.BackColor = Color.Gray;

            Supplier s = new Supplier();
            s.datagridviewstyle(dgvpo);
            s.datagridviewstyle(dgvpod);
            SqlCommand sc = new SqlCommand("select * from Purchase_Order", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            cbpurchaseorder.DataSource = ds.Tables[0];
            cbpurchaseorder.DisplayMember = "PO_No";
            cbpurchaseorder.ValueMember = "PO_No";
            cbpurchaseorder.Text = "Select";
        }

        private void cbpurchaseorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbpurchaseorder.Text == "" || cbpurchaseorder.Text == "Select"))
            {
                dgvpo.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SqlCommand sc = new SqlCommand("select * from Purchase_Order where PO_No='" + cbpurchaseorder.SelectedValue.ToString() + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                adp.Fill(ds,"dt");
                dgvpo.DataSource = ds.Tables["dt"];

                dgvpod.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SqlCommand sc1 = new SqlCommand("select Purchase_Order_Detail.PO_No,Purchase_Order_Detail.Item_Id,Inventory.Name,Purchase_Order_Detail.Qty from Purchase_Order_Detail inner join Inventory on Purchase_Order_Detail.Item_Id = Inventory.Item_Id where Purchase_Order_Detail.PO_No='" + cbpurchaseorder.SelectedValue.ToString() + "'", c.cn);
                SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "dt1");
                dgvpod.DataSource = ds1.Tables["dt1"];
            }
        }

        private void searchitem_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbpurchaseorder.Text == "Select" || cbpurchaseorder.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Purchase_Order_Detail.PO_No,Purchase_Order_Detail.Item_Id,Inventory.Name,Purchase_Order_Detail.Qty from Purchase_Order_Detail inner join Inventory on Purchase_Order_Detail.Item_Id = Inventory.Item_Id where Inventory.Name like '" + searchitem.Text + "%'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dgvpod.DataSource = ds.Tables["dt"];
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Purchase_Order_Detail.PO_No,Purchase_Order_Detail.Item_Id,Inventory.Name,Purchase_Order_Detail.Qty  from Purchase_Order_Detail inner join Inventory on Purchase_Order_Detail.Item_Id = Inventory.Item_Id where Inventory.Name like '" + searchitem.Text + "%' and Purchase_Order_Detail.PO_No='" + cbpurchaseorder.SelectedValue.ToString() + "'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dgvpod.DataSource = ds.Tables["dt"];
            } 
        }

        private void searchitem_Leave(object sender, EventArgs e)
        {
            if (searchitem.Text == "")
                searchitem.Text = "search...";
            searchitem.ForeColor = Color.Silver;
        }

        private void searchitem_Click(object sender, EventArgs e)
        {
            if (searchitem.Text == "search...")
                searchitem.Text = "";
            searchitem.ForeColor = Color.FromArgb(20, 168, 0);
        }

        private void cbpurchaseorder_TextChanged(object sender, EventArgs e)
        {
            searchitem.Text = "search...";
            dgvpo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlCommand sc = new SqlCommand("select * from Purchase_Order", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds, "dt");
            dgvpo.DataSource = ds.Tables["dt"];

            dgvpod.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlCommand sc1 = new SqlCommand("select Purchase_Order_Detail.PO_No,Purchase_Order_Detail.Item_Id,Inventory.Name,Purchase_Order_Detail.Qty from Purchase_Order_Detail inner join Inventory on Purchase_Order_Detail.Item_Id = Inventory.Item_Id", c.cn);
            SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1, "dt1");
            dgvpod.DataSource = ds1.Tables["dt1"];
        }

        private void pb_Click(object sender, EventArgs e)
        {
            panelpb.BringToFront();
            po.BackColor = Color.Gray;
            pb.BackColor = Color.FromArgb(24, 123, 205);
            pr.BackColor = Color.Gray;
            sb.BackColor = Color.Gray;

            Supplier s = new Supplier();
            s.datagridviewstyle(dgvpb);
            s.datagridviewstyle(dgvpbd);
            SqlCommand sc = new SqlCommand("select * from Purchase_Bill", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "PB_No";
            comboBox1.ValueMember = "PB_No";
            comboBox1.Text = "Select";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboBox1.Text == "" || comboBox1.Text == "Select"))
            {
                dgvpb.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SqlCommand sc = new SqlCommand("select * from Purchase_Bill where PB_No='" + comboBox1.SelectedValue.ToString() + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                adp.Fill(ds, "dt");
                dgvpb.DataSource = ds.Tables["dt"];

                dgvpbd.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SqlCommand sc1 = new SqlCommand("select Purchase_Bill_Detail.PB_No,Purchase_Bill_Detail.Item_Id,Inventory.Name,Purchase_Bill_Detail.Qty,Purchase_Bill_Detail.Price,Purchase_Bill_Detail.Amount,Purchase_Bill_Detail.Warranty from Purchase_Bill_Detail inner join Inventory on Purchase_Bill_Detail.Item_Id = Inventory.Item_Id where Purchase_Bill_Detail.PB_No='" + comboBox1.SelectedValue.ToString() + "'", c.cn);
                SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "dt1");
                dgvpbd.DataSource = ds1.Tables["dt1"];
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            tsearch.Text="search...";
            dgvpb.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlCommand sc = new SqlCommand("select * from Purchase_Bill", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds, "dt");
            dgvpb.DataSource = ds.Tables["dt"];

            dgvpbd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlCommand sc1 = new SqlCommand("select Purchase_Bill_Detail.PB_No,Purchase_Bill_Detail.Item_Id,Inventory.Name,Purchase_Bill_Detail.Qty,Purchase_Bill_Detail.Price,Purchase_Bill_Detail.Amount,Purchase_Bill_Detail.Warranty from Purchase_Bill_Detail inner join Inventory on Purchase_Bill_Detail.Item_Id = Inventory.Item_Id", c.cn);
            SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1, "dt1");
            dgvpbd.DataSource = ds1.Tables["dt1"];
        }

        private void tsearch_Leave(object sender, EventArgs e)
        {
            if (tsearch.Text == "")
                tsearch.Text = "search...";
            tsearch.ForeColor = Color.Silver;
        }

        private void tsearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBox1.Text == "Select" || comboBox1.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Purchase_Bill_Detail.PB_No,Purchase_Bill_Detail.Item_Id,Inventory.Name,Purchase_Bill_Detail.Qty,Purchase_Bill_Detail.Price,Purchase_Bill_Detail.Amount,Purchase_Bill_Detail.Warranty from Purchase_Bill_Detail inner join Inventory on Purchase_Bill_Detail.Item_Id = Inventory.Item_Id where Inventory.Name like '" + tsearch.Text + "%'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dgvpbd.DataSource = ds.Tables["dt"];
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Purchase_Bill_Detail.PB_No,Purchase_Bill_Detail.Item_Id,Inventory.Name,Purchase_Bill_Detail.Qty,Purchase_Bill_Detail.Price,Purchase_Bill_Detail.Amount,Purchase_Bill_Detail.Warranty from Purchase_Bill_Detail inner join Inventory on Purchase_Bill_Detail.Item_Id = Inventory.Item_Id where Inventory.Name like '" + tsearch.Text + "%' and Purchase_Bill_Detail.PB_No='"+comboBox1.SelectedValue.ToString()+"'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dgvpbd.DataSource = ds.Tables["dt"];
            }
        }

        private void tsearch_Click(object sender, EventArgs e)
        {
            if (tsearch.Text == "search...")
                tsearch.Text = "";
            tsearch.ForeColor = Color.FromArgb(20, 168, 0);
        }

        private void pr_Click(object sender, EventArgs e)
        {
            panelpr.BringToFront();
            po.BackColor = Color.Gray;
            pb.BackColor = Color.Gray;
            pr.BackColor = Color.FromArgb(24, 123, 205);
            sb.BackColor = Color.Gray;

            Supplier s = new Supplier();
            s.datagridviewstyle(dgvpr);
            s.datagridviewstyle(dgvprd);
            SqlCommand sc = new SqlCommand("select * from Purchase_Return", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "PR_No";
            comboBox2.ValueMember = "PR_No";
            comboBox2.Text = "Select";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboBox2.Text == "" || comboBox2.Text == "Select"))
            {
                dgvpr.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SqlCommand sc = new SqlCommand("select * from Purchase_Return where PR_No='" + comboBox2.SelectedValue.ToString() + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                adp.Fill(ds, "dt");
                dgvpr.DataSource = ds.Tables["dt"];

                dgvprd.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SqlCommand sc1 = new SqlCommand("select Purchase_Return_Detail.PR_No,Purchase_Return_Detail.Item_Id,Inventory.Name,Purchase_Return_Detail.Qty from Purchase_Return_Detail inner join Inventory on Purchase_Return_Detail.Item_Id = Inventory.Item_Id where Purchase_Return_Detail.PR_No='" + comboBox2.SelectedValue.ToString() + "'", c.cn);
                SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "dt1");
                dgvprd.DataSource = ds1.Tables["dt1"];
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "search...";
            dgvpr.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlCommand sc = new SqlCommand("select * from Purchase_Return", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds, "dt");
            dgvpr.DataSource = ds.Tables["dt"];

            dgvprd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlCommand sc1 = new SqlCommand("select Purchase_Return_Detail.PR_No,Purchase_Return_Detail.Item_Id,Inventory.Name,Purchase_Return_Detail.Qty from Purchase_Return_Detail inner join Inventory on Purchase_Return_Detail.Item_Id = Inventory.Item_Id", c.cn);
            SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1, "dt1");
            dgvprd.DataSource = ds1.Tables["dt1"];
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBox2.Text == "Select" || comboBox2.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Purchase_Return_Detail.PR_No,Purchase_Return_Detail.Item_Id,Inventory.Name,Purchase_Return_Detail.Qty from Purchase_Return_Detail inner join Inventory on Purchase_Return_Detail.Item_Id = Inventory.Item_Id where Inventory.Name like '" + textBox1.Text + "%'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dgvprd.DataSource = ds.Tables["dt"];
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Purchase_Return_Detail.PR_No,Purchase_Return_Detail.Item_Id,Inventory.Name,Purchase_Return_Detail.Qty from Purchase_Return_Detail inner join Inventory on Purchase_Return_Detail.Item_Id = Inventory.Item_Id where Inventory.Name like '" + textBox1.Text + "%' and Purchase_Return_Detail.PR_No='"+comboBox2.SelectedValue.ToString()+"'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dgvprd.DataSource = ds.Tables["dt"];
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "search...";
            textBox1.ForeColor = Color.Silver;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "search...")
                textBox1.Text = "";
            textBox1.ForeColor = Color.FromArgb(20, 168, 0);
        }

        private void sb_Click(object sender, EventArgs e)
        {
            panelsb.BringToFront();
            po.BackColor = Color.Gray;
            pb.BackColor = Color.Gray;
            pr.BackColor = Color.Gray;
            sb.BackColor = Color.FromArgb(24, 123, 205);

            Supplier s = new Supplier();
            s.datagridviewstyle(dgvsb);
            s.datagridviewstyle(dgvsbd);
            SqlCommand sc = new SqlCommand("select * from Sale_Bill", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            sc.ExecuteNonQuery();
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "SB_No";
            comboBox3.ValueMember = "SB_No";
            comboBox3.Text = "Select";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboBox3.Text == "" || comboBox3.Text == "Select"))
            {
                dgvsb.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SqlCommand sc = new SqlCommand("select * from Sale_Bill where SB_No='" + comboBox3.SelectedValue.ToString() + "'", c.cn);
                SqlDataAdapter adp = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                adp.Fill(ds, "dt");
                dgvsb.DataSource = ds.Tables["dt"];

                dgvsbd.SelectionMode = DataGridViewSelectionMode.CellSelect;
                SqlCommand sc1 = new SqlCommand("select Sale_Bill_Detail.SB_No,Sale_Bill_Detail.Item_Id,Inventory.Name,Sale_Bill_Detail.Qty,Sale_Bill_Detail.Rate,Sale_Bill_Detail.Price,Sale_Bill_Detail.Tax,Sale_Bill_Detail.Amount from Sale_Bill_Detail inner join Inventory on Sale_Bill_Detail.Item_Id=Inventory.Item_Id where Sale_Bill_Detail.SB_No='" + comboBox3.SelectedValue.ToString() + "'", c.cn);
                SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "dt1");
                dgvsbd.DataSource = ds1.Tables["dt1"];
            }
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "search...";
            dgvsb.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlCommand sc = new SqlCommand("select * from Sale_Bill", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds, "dt");
            dgvsb.DataSource = ds.Tables["dt"];

            dgvsbd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SqlCommand sc1 = new SqlCommand("select Sale_Bill_Detail.SB_No,Sale_Bill_Detail.Item_Id,Inventory.Name,Sale_Bill_Detail.Qty,Sale_Bill_Detail.Rate,Sale_Bill_Detail.Price,Sale_Bill_Detail.Tax,Sale_Bill_Detail.Amount from Sale_Bill_Detail inner join Inventory on Sale_Bill_Detail.Item_Id=Inventory.Item_Id", c.cn);
            SqlDataAdapter adp1 = new SqlDataAdapter(sc1);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1, "dt1");
            dgvsbd.DataSource = ds1.Tables["dt1"];
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBox3.Text == "Select" || comboBox3.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Sale_Bill_Detail.SB_No,Sale_Bill_Detail.Item_Id,Inventory.Name,Sale_Bill_Detail.Qty,Sale_Bill_Detail.Rate,Sale_Bill_Detail.Price,Sale_Bill_Detail.Tax,Sale_Bill_Detail.Amount from Sale_Bill_Detail inner join Inventory on Sale_Bill_Detail.Item_Id=Inventory.Item_Id where Inventory.Name like '" + textBox2.Text + "%'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dgvsbd.DataSource = ds.Tables["dt"];
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Sale_Bill_Detail.SB_No,Sale_Bill_Detail.Item_Id,Inventory.Name,Sale_Bill_Detail.Qty,Sale_Bill_Detail.Rate,Sale_Bill_Detail.Price,Sale_Bill_Detail.Tax,Sale_Bill_Detail.Amount from Sale_Bill_Detail inner join Inventory on Sale_Bill_Detail.Item_Id=Inventory.Item_Id where Inventory.Name like '" + textBox2.Text + "%' and Sale_Bill_Detail.SB_No='"+comboBox3.SelectedValue.ToString()+"'", c.cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "dt");
                dgvsbd.DataSource = ds.Tables["dt"];
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = "search...";
            textBox2.ForeColor = Color.Silver;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "search...")
                textBox2.Text = "";
            textBox2.ForeColor = Color.FromArgb(20, 168, 0);
        }
        private void nadd_Click(object sender, EventArgs e)
        {
            DateTime dt1, dt2;
            dt1 = Convert.ToDateTime(maskedTextBox3.Text);
            dt2 = Convert.ToDateTime(maskedTextBox4.Text);
            SqlCommand sc = new SqlCommand("select * from Sale_Bill where Date between '"+dt1.ToString("MM-dd-yyyy")+"' and '"+dt2.ToString("MM-dd-yyyy")+"'", c.cn);
            SqlDataAdapter adp = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            adp.Fill(ds, "dt");
            dgvsb.DataSource = ds.Tables["dt"];
        }
    }
}