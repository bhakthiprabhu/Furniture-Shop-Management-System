using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Nav_User : Form
    {
        String username;
        Connect c = new Connect();
        public Nav_User(String str)
        {
            InitializeComponent();
            username = str; 
        }

        private void Nav_User_Load(object sender, EventArgs e)
        {
            //page load
            panelleft.BackColor = Color.FromArgb(46,46,46);
            this.Text = "Employee Dashboard";
            c.cmd.CommandText="Select Name from Employee where Emp_Id='"+username+"'";
            label1.Text = c.cmd.ExecuteScalar().ToString();
            groupBox10.Visible = false;
            groupBox9.Visible = false;
        }

        private void Nav_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close button
            if (MessageBox.Show("Are you sure want to Exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void logoutpage()
        {
            //logout
            this.Hide();
            new Login_User().Show();
        }

        private void pblogout_Click(object sender, EventArgs e)
        {
            logoutpage();
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            logoutpage();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            logoutpage();
        }

        private void fcustomer()
        {
            //customer page
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            panelsale.Visible = false;
            btn__sales.BackColor = Color.Transparent;
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.FromArgb(33, 33, 33);
            btn_logout.BackColor = Color.Transparent;
            this.Text = "Customer Page";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Customer frm = new Customer();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void fservice()
        {
            //service page
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            panelmain.Size = new Size(851, 645);
            panelsale.Visible = false;
            btn__sales.BackColor = Color.Transparent;
            btn_service.BackColor = Color.FromArgb(33, 33, 33);
            btncust.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            this.Text = "Service Page";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Service frm = new Service();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            fcustomer();
        }

        private void pbcust_Click(object sender, EventArgs e)
        {
            fcustomer();
        }

        private void bcust_Click(object sender, EventArgs e)
        {
            fcustomer();
        }

        private void fsale()
        {
            //sale page
            this.Size = new Size(1136, 720);
            panelmain.Location = new Point(104, 46);
            panelmain.Size = new Size(1031, 645);
            panelsale.Visible = true;
            groupBox10.Visible = true;
            groupBox9.Visible = true;
            btn__sales.BackColor = Color.FromArgb(33, 33, 33);
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            this.Text = "Sale Page - Bill";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Sale_Bill frm = new Sale_Bill(username);
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void pbsale_Click(object sender, EventArgs e)
        {
            fsale();
        }

        private void bsale_Click(object sender, EventArgs e)
        {
            fsale();
        }

        private void btn__sales_Click(object sender, EventArgs e)
        {
            fsale();
        }

        private void pbservice_Click(object sender, EventArgs e)
        {
            fservice();
        }

        private void bservice_Click(object sender, EventArgs e)
        {
            fservice();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            fservice();
        }

        private void saleorder_Click(object sender, EventArgs e)
        {
            //sale order
            this.panelmain.Controls.Clear();
            Sale_Order frm = new Sale_Order();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            this.Text = "Sale Page - Order";
        }

        private void salebill_Click(object sender, EventArgs e)
        {
            //sale bill
            this.panelmain.Controls.Clear();
            Sale_Bill frm = new Sale_Bill(username);
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            this.Text = "Sale Page - Bill";
        }

    }
}