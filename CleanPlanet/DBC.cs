using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CleanPlanet
{
    public class DBC
    {
        private static SqlConnection _conn;

        public static SqlConnection Conn { get { return _conn; } }

        public static void Open()
        {
            string con_strnig = "Data Source = ADCLG1;Initial Catalog=Yasinskij_CleanPlanet;Integrated Security=True;TrustServerCertificate=True;";
            _conn = new SqlConnection(con_strnig);
            _conn.Open();
        }

        public static void Close()
        {
            _conn.Close();
        }
    }
}
