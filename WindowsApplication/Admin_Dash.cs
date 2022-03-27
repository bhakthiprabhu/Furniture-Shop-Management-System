using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Admin_Dash : Form
    {
        Connect c = new Connect();
        public Admin_Dash()
        {
            InitializeComponent();
        }

        private void Admin_Dash_Load(object sender, EventArgs e)
        {
            try
            {
                c.cmd.CommandText = "Select count(*) from Customer";
                tcust.Text = c.cmd.ExecuteScalar().ToString();
                c.cmd.CommandText = "Select count(*) from Supplier where Status='Active'";
                tsup.Text = c.cmd.ExecuteScalar().ToString();
                c.cmd.CommandText = "Select count(*) from Employee where Status='Active'";
                temp.Text = c.cmd.ExecuteScalar().ToString();
                c.cmd.CommandText = "Select count(*) from Sale_Bill";
                int s = Convert.ToInt32(c.cmd.ExecuteScalar());
                c.cmd.CommandText = "Select count(*) from Purchase_Order where Status='Invoiced' ";
                int p = Convert.ToInt32(c.cmd.ExecuteScalar());
                tsales.Text = s.ToString();
                ttransactions.Text = (s + p).ToString();
                c.cmd.CommandText = "select Qty from Inventory where Status='Active' and Qty is not null";
                c.cmd.CommandText = "Select sum(Qty) from Inventory";
                titems.Text = c.cmd.ExecuteScalar().ToString();
                c.cmd.CommandText = "Select count(*) from Sale_Order";
                tsalesorder.Text = c.cmd.ExecuteScalar().ToString();
                c.cmd.CommandText = "Select sum(Total_Amount) from Sale_Bill where Net_Amount is not null";
                netrevenue.Text = c.cmd.ExecuteScalar().ToString();
                if (netrevenue.Text == "")
                    netrevenue.Text = "0";
                double nr, pr;
                c.cmd.CommandText = "Select sum(Net_Amount) from Sale_Bill where Net_Amount is not null";
                nr = Convert.ToDouble(c.cmd.ExecuteScalar());
                c.cmd.CommandText = "Select sum(Rate) from Sale_Bill_Detail where Rate is not null";
                pr = Convert.ToDouble(c.cmd.ExecuteScalar());
                double tt = nr - pr;
                if (tt < 0)
                    netprofit.Text = "0";
                else
                    netprofit.Text = tt.ToString();

            }
            catch (Exception)
            {
               
            }
        }
    }
}