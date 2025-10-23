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

        public static bool AddPartner(Partner partner)
        {
            try
            {
                DBC.Open();
                SqlCommand com = DBC.Conn.CreateCommand();
                com.CommandText = $"insert into Partners values (" +
                    $"'{partner.type}','{partner.name}','{partner.director}','{partner.email}','{partner.phone}'," +
                    $"'{partner.address}','{partner.inn}',{partner.rating}" +
                    $")";

                com.ExecuteNonQuery();
                DBC.Close();
                return true;
            }
            catch { return false; } 
        }

        public static bool EditPartner(Partner partner)
        {
            try
            {
                DBC.Open();
                SqlCommand com = DBC.Conn.CreateCommand();
                com.CommandText = $"update Partners set " +
                    $"type = '{partner.type}', " +
                    $"name = '{partner.name}', " +
                    $"director = '{partner.director}', " +
                    $"email = '{partner.email}', " +
                    $"phone = '{partner.phone}', " +
                    $"address = '{partner.address}',"  +
                    $"inn = '{partner.inn}', " +
                    $"rating = {partner.rating} " +
                    $"where name = '{partner.old_name}' ";

                com.ExecuteNonQuery();
                DBC.Close();
                return true;
            }
            catch { return false; }
        }

        public static bool DeletePartner(string name)
        {
            try
            {
                DBC.Open();
                SqlCommand com = DBC.Conn.CreateCommand();
                com.CommandText = $"delete from Partners where name = '{name}'";
                com.ExecuteNonQuery();
                DBC.Close();
                return true;
            }
            catch { return false; }
        }
    }
}
