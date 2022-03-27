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
    public partial class Emp_Salary_Print : Form
    {
        Connect c = new Connect();
        string empid,month,year;
        public Emp_Salary_Print(string empno,string m,string y)
        {
            InitializeComponent();
            empid = empno;
            month = m;
            year = y;
        }

        private void Emp_Salary_Print_Load(object sender, EventArgs e)
        {
            label52.Text = DateTime.Now.ToString();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Employee where Emp_Id='"+empid+"'",c.cn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                label35.Text = dt.Rows[0]["Emp_Id"].ToString();
                label34.Text = dt.Rows[0]["Name"].ToString();
                label36.Text = dt.Rows[0]["Designation"].ToString();
                DateTime dt1 = Convert.ToDateTime(dt.Rows[0]["Doj"]);
                label37.Text = dt1.ToShortDateString();
                label55.Text = dt.Rows[0]["Basic_Pay"].ToString();
                label39.Text = dt.Rows[0]["Contact_No"].ToString();
                label42.Text = dt.Rows[0]["Gender"].ToString();
            }
            SqlDataAdapter adp1 = new SqlDataAdapter("Select * from Attendence where Emp_Id='" + empid + "' and Month='" + month + "' and Year='" + year + "' and Emp_Id='" + empid + "'", c.cn);
            DataTable dt2 = new DataTable();
            adp1.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                label41.Text = dt2.Rows[0]["Total_days"].ToString();
                label45.Text = dt2.Rows[0]["Extra_leave"].ToString();
            }
            SqlDataAdapter adp3 = new SqlDataAdapter("Select * from Salary where Emp_Id='" + empid + "' and Month='" + month + "' and Year='" + year + "' and Emp_Id='" + empid + "'", c.cn);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3);
            if (dt3.Rows.Count > 0)
            {
                double ld = (Convert.ToDouble(label55.Text) / Convert.ToDouble(label41.Text)) * (Convert.ToDouble(label41.Text) - Convert.ToDouble(label45.Text));
                label16.Text= Math.Round((Convert.ToDouble(label55.Text)-ld),2).ToString();
                if (label16.Text == "0")
                    label16.Text = "0.0";
                label46.Text = dt3.Rows[0]["HRA"].ToString();
                label47.Text = dt3.Rows[0]["PF"].ToString();
                label49.Text = dt3.Rows[0]["Tax"].ToString();
                label48.Text = (Convert.ToDouble(label46.Text) + Convert.ToDouble(label55.Text)).ToString();
                label50.Text = (Convert.ToDouble(label47.Text) + Convert.ToDouble(label49.Text)).ToString();
                label51.Text = dt3.Rows[0]["Net_Pay"].ToString();
                string amt = label51.Text;
                String word = ConvertNumbertoWords(Convert.ToInt32(amt.Split('.')[0])) + ' ' + "RUPEES" + ' ' + ConvertNumbertoWords(Convert.ToInt32(amt.Split('.')[1])) + ' ' + "PAISA ONLY";
                label26.Text = word;
                string m = dt3.Rows[0]["Month"].ToString();
                string y = dt3.Rows[0]["Year"].ToString();
                label8.Text = m + " - " + y;
                label53.Text = dt3.Rows[0]["Pay_Id"].ToString();
            }

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
    }
}