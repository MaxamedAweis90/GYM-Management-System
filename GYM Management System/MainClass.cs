using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management_System
{
    class MainClass
    {
        //check validation
        public static bool isValidUser(string user, string pass)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=Asli-pc;Initial Catalog=GYM_Managing;User ID=sa;Password=l23;Integrated Security=SSPI;");


            bool isValid = false;

            string qry = @"select * from Users where username = '"+user+"' and upass = '"+pass+"' ";
            SqlCommand cmd = new SqlCommand(qry, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count >0)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}


