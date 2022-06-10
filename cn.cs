using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace New_Appli
{
    class cn
    {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-3A96GRL\SQLEXPRESS;Initial Catalog=de;Integrated Security=True");
        public static void ouvrircnx()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }





        }
        public static void fermercnx()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
    }
}
