using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //page load
            this.timer1.Start();
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Step = 10;
        }

        private void Loadnext()
        {
            //loadnext function
            Connect c = new Connect();
            c.cmd.CommandText = "select username from Admin_Create";
            string username = Convert.ToString(c.cmd.ExecuteScalar());
            if (username == "")
                new Admin_Create().Show();
            else
                new Login_User().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer tick
            this.progressBar1.Increment(1);
            loading.Text = "Loading..." + progressBar1.Value + "%";
            if (this.progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Loadnext();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close button
            Application.Exit();
        }
    }
}