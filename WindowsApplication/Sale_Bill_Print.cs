using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace WindowsApplication
{
    public partial class Sale_Bill_Print : Form
    {
        string sbno,username;
        Connect c = new Connect();
        public Sale_Bill_Print(String sbid,string str)
        {
            InitializeComponent();
            username = str;
            sbno = sbid;
        }

        private void Sale_Bill_Print_Load(object sender, EventArgs e)
        {
            label27.Text = username;
            c.cmd.CommandText = "select Customer.Name from Customer inner join Sale_Bill on Customer.Contact_No = Sale_Bill.Contact_No where Sale_Bill.SB_No='" + sbno + "'";
            label9.Text = c.cmd.ExecuteScalar().ToString();
            label11.Text = sbno.ToString();
            c.cmd.CommandText = "select Contact_No from Sale_Bill where Sale_Bill.SB_No='" + sbno + "'";
            label10.Text = c.cmd.ExecuteScalar().ToString();
            label12.Text = DateTime.Now.ToString();
            c.cmd.CommandText = "select Total_Amount from Sale_Bill where Sale_Bill.SB_No='" + sbno + "'";
            label15.Text = c.cmd.ExecuteScalar().ToString();
            c.cmd.CommandText = "select Discount from Sale_Bill where Sale_Bill.SB_No='" + sbno + "'";
            label16.Text = c.cmd.ExecuteScalar().ToString();
            c.cmd.CommandText = "select Net_Amount from Sale_Bill where Sale_Bill.SB_No='" + sbno + "'";
            label18.Text = (c.cmd.ExecuteScalar()).ToString();
            string amt = label18.Text;
            label27.Text = username;
            String word = ConvertNumbertoWords(Convert.ToInt32(amt.Split('.')[0])) + ' ' + "RUPEES" + ' ' + ConvertNumbertoWords(Convert.ToInt32(amt.Split('.')[1])) + ' ' + "PAISE ONLY";
            label26.Text = word;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Arial", 10.25f, FontStyle.Bold);
            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10.25f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            SqlDataAdapter adp1 = new SqlDataAdapter("select Inventory.Name ,Inventory.Warranty ,Sale_Bill_Detail.Qty,Sale_Bill_Detail.Rate,Sale_Bill_Detail.Price,Sale_Bill_Detail.Tax,Sale_Bill_Detail.Amount from Sale_Bill_Detail inner join Inventory on Sale_Bill_Detail.Item_Id=Inventory.Item_Id where SB_No='" + sbno + "' ", c.cn);
            DataSet ds2 = new DataSet();
            adp1.Fill(ds2, "dt2");
            dataGridView1.DataSource = ds2.Tables["dt2"];
            dataGridView1.Columns["Name"].HeaderText = "Detail of Product";
            dataGridView1.Columns["Qty"].HeaderText = "Quantity";
            dataGridView1.Columns["Warranty"].HeaderText = "Warranty in Years";
        }

        Bitmap img;
        private void capturescreen()
        {
            Panel p = new Panel();
            this.Controls.Add(p);
            Graphics g = p.CreateGraphics();
            Size s = this.ClientSize;
            img = new Bitmap(s.Width, s.Height, g);
            Graphics mg = Graphics.FromImage(img);
            Point pt = PointToScreen(p.Location);
            mg.CopyFromScreen(pt.X, pt.Y, 0, 0, s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //print
            try
            {
                button1.Visible = false;
                capturescreen();
                printDocument1.Print();
            }
            catch (Exception)
            {
                MessageBox.Show("bill cannot be printed");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(img, 50, 100);
        }

        public static string ConvertNumbertoWords(int number)
        {
            //amount in words
            if (number == 0)
                return "ZERO";
            if (number < 0)
                return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000000000) + " Billion ";
                number %= 1000000000;
            }
            if ((number / 10000000) > 0)
            {
                words += ConvertNumbertoWords(number / 10000000) + " CRORE ";
                number %= 10000000;
            }
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000000) + " MILLION ";
                number %= 1000000;
            }
            if ((number / 100000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKH ";
                number %= 100000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += "AND ";
                string[] unitsMap = new string[20] { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
                string[] tensMap = new string[10] { "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };
                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }
    }
}