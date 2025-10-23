using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CleanPlanet
{
    internal class DBGetter
    {
        
        public static List<Partner> GetPartners(
            string name = ""
            )
        {
            List<Partner> res = new List<Partner>();
            DBC.Open();

            SqlCommand com = DBC.Conn.CreateCommand();
            com.CommandText = "select * from Partners";
            if (name != "") com.CommandText += $" where name = '{name}'";
            using (SqlDataReader reader = com.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Partner el = new Partner();
                        el.type = reader.GetString(0);
                        el.name = reader.GetString(1);
                        el.director = reader.GetString(2);
                        el.email = reader.GetString(3);
                        el.phone = reader.GetString(4);
                        el.address = reader.GetString(5);
                        el.inn = reader.GetString(6);
                        el.rating = reader.GetInt32(7);
                        res.Add(el);
                    }
                }
            }
            DBC.Close();
            return res;
        }
    }
}
