using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Nav_Admin : Form
    {
        string username;
        public Nav_Admin(string str)
        {
            username = str;
            InitializeComponent();
        }

        private void Nav_Admin_Load(object sender, EventArgs e)
        {
            //page load
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            panelleft.BackColor = Color.FromArgb(46,46,46);
            panelbottom.Visible = false;
            panelsale.Visible = false;
            this.Text = "Admin Dashboard";
            Admin_Dash frm = new Admin_Dash();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
        }

        private void Nav_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close button
            if (MessageBox.Show("Are you sure want to Exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void expand_Click(object sender, EventArgs e)
        {
            //expand
            if (panelsub.Visible == true)
            {
                panelsub.Visible = false;
            }
            else
            {
                panelsub.Visible = true;
                panelsub.BringToFront();
            }
        }

        private void profile_Click(object sender, EventArgs e)
        {
            //profile
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            panelsub.Visible = false;
            panelbottom.Visible = false;
            panelsale.Visible = false;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.Transparent;
            btnstock.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            this.Text = "Profile Page";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Profile frm = new Profile();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //logout
            this.Hide();
            new Login_User().Show();
        }

        private void fadmindash()
        {
            //admin dashboard
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            this.Text = "Admin Dashboard";
            panelsub.Visible = false;
            panelsale.Visible = false;
            panelbottom.Visible = false;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btncust.BackColor = Color.Transparent;
            btnstock.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;

            this.Text = "Admin Dashboard";
            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Admin_Dash frm = new Admin_Dash();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void fsupplier()
        {
            //supplier
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            panelsub.Visible = false;
            panelbottom.Visible = false;
            panelsale.Visible = false;
            btnsupp.BackColor = Color.FromArgb(33, 33, 33);
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_service.BackColor = Color.Transparent;
            btnstock.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;
            this.Text = "Supplier Page";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Supplier frm = new Supplier();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void femployee()
        {
            //employee page
            this.Size = new Size(1136, 720);
            panelmain.Location = new Point(104, 46);
            panelmain.Size = new Size(851, 645);
            panelsub.Visible = false;
            panelsale.Visible = false;
            panelbottom.Visible = false;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.FromArgb(33, 33, 33);
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.Transparent;
            btnstock.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            this.Text ="Employee Page - Add New";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Emp_Add_New frm = new Emp_Add_New();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void fcustomer()
        {
            //customer page
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            panelsub.Visible = false;
            panelsale.Visible = false;
            panelbottom.Visible = false;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.FromArgb(33, 33, 33);
            btnstock.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;
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
            panelsub.Visible = false;
            panelsale.Visible = false;
            panelbottom.Visible = false;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_service.BackColor = Color.FromArgb(33, 33, 33);
            btncust.BackColor = Color.Transparent;
            btnstock.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;
            this.Text = "Service Page";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Service frm = new Service();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void finventory()
        {
             //inventory page
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            panelsub.Visible = false;
            panelsale.Visible = false;
            panelbottom.Visible = false;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.Transparent;
            btnstock.BackColor = Color.FromArgb(33, 33, 33);
            btn_logout.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;
            this.Text = "Inventory Page";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Inventory frm = new Inventory();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void fpurchase()
        {
            //purchase page
            this.Size = new Size(1136, 720);
            panelmain.Location = new Point(104, 46);
            panelmain.Size = new Size(1031, 580);
            panelsub.Visible = false;
            panelsale.Visible = false;
            panelbottom.Visible = true;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.FromArgb(33, 33, 33);
            btn_emp.BackColor = Color.Transparent;
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.Transparent;
            btnstock.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;
            this.Text = "Purchase Page - Order";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Purchase_Order frm = new Purchase_Order();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void fsale()
        {
            //sale page
            this.Size = new Size(1136, 720);
            panelmain.Location = new Point(104, 46);
            panelmain.Size = new Size(1031, 645);
            panelsub.Visible = false;
            panelbottom.Visible = false;
            panelsale.Visible = true;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.FromArgb(33, 33, 33);
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.Transparent;
            btnstock.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            btn_display.BackColor = Color.Transparent;
            this.Text = "Sale Page - Bill";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Sale_Bill frm = new Sale_Bill(username);
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void display()
        {
            //display page
            this.Size = new Size(960, 720);
            panelmain.Location = new Point(104, 46);
            panelmain.Size = new Size(851, 645);
            panelsub.Visible = false;
            panelsale.Visible = false;
            panelbottom.Visible = false;
            btnsupp.BackColor = Color.Transparent;
            btn__sales.BackColor = Color.Transparent;
            btn_pur.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_service.BackColor = Color.Transparent;
            btncust.BackColor = Color.Transparent;
            btnstock.BackColor = Color.Transparent;
            btn_logout.BackColor = Color.Transparent;
            btn_display.BackColor = Color.FromArgb(33, 33, 33);
            this.Text = "Display Page";

            panelleft.Cursor = Cursors.WaitCursor;
            this.panelmain.Controls.Clear();
            Display frm = new Display();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            panelleft.Cursor = Cursors.Default;
        }

        private void admindashboard_Click(object sender, EventArgs e)
        {
            fadmindash();
        }

        private void pbadmindash_Click(object sender, EventArgs e)
        {
            fadmindash();
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            fsupplier();
        }

        private void pbsup_Click(object sender, EventArgs e)
        {
            fsupplier();
        }

        private void bsup_Click(object sender, EventArgs e)
        {
            fsupplier();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            femployee();
        }

        private void pbemp_Click(object sender, EventArgs e)
        {
            femployee();
        }

        private void bemp_Click(object sender, EventArgs e)
        {
            femployee();
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

        private void plockorunlock_Click_1(object sender, EventArgs e)
        {
            //manage user
            this.Text = "Employee Page - Manage Employee";
            this.panelmain.Controls.Clear();
            Emp_Manage_User frm = new Emp_Manage_User();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
        }

        private void padd_Click(object sender, EventArgs e)
        {
            //new employee add
            this.Text = "Employee Page - Add New";
            this.panelmain.Controls.Clear();
            Emp_Add_New frm = new Emp_Add_New();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
        }

        private void pbstock_Click(object sender, EventArgs e)
        {
            finventory();
        }

        private void bstock_Click(object sender, EventArgs e)
        {
            finventory();
        }

        private void pattendence_Click(object sender, EventArgs e)
        {
            //attendence
            this.Text = "Employee Page - Attendence";
            this.panelmain.Controls.Clear();
            Emp_Attendence frm = new Emp_Attendence();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
        }

        private void psalary_Click(object sender, EventArgs e)
        {
            //salary
            this.Text = "Employee Page - Salary Calculation";
            this.panelmain.Controls.Clear();
            btn_calculate frm = new btn_calculate();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
        }

        private void pbpur_Click(object sender, EventArgs e)
        {
            fpurchase();
        }

        private void bpur_Click(object sender, EventArgs e)
        {
            fpurchase();
        }

        private void btn_pur_Click(object sender, EventArgs e)
        {
            fpurchase();
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

        private void btnstock_Click(object sender, EventArgs e)
        {
            finventory();
        }

        private void purchaseorder_Click(object sender, EventArgs e)
        {
            //purchase order
            this.panelmain.Controls.Clear();
            Purchase_Order frm = new Purchase_Order();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            this.Text = "Purchase Page - Order";
        }

        private void purchasebill_Click(object sender, EventArgs e)
        {
            //purchase bill
            this.panelmain.Controls.Clear();
            Purchase_Bill frm = new Purchase_Bill();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            this.Text = "Purchase Page - Bill";
        }

        private void purchasereturn_Click(object sender, EventArgs e)
        {
            //purchase return
            this.panelmain.Controls.Clear();
            Purchase_Return frm = new Purchase_Return();
            frm.TopLevel = false;
            this.panelmain.Controls.Add(frm);
            frm.Show();
            this.Text = "Purchase Page - Return";
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

        private void pbdisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        private void bdisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}