using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WindowsApplication
{
    class Connect
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public Connect()
        {
            cn.ConnectionString = "data source = DESKTOP-LSCV7TC\\SQLEXPRESS;initial catalog = Project;integrated security = true";
            cn.Open();
            cmd.Connection = cn;
        }
    }
}
