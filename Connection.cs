using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity
{

    internal class Connection
    {
        Connection()
        {

        }
        static bool Connect_Check(string user, string pass)
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=DESKTOP-46MR55N;Initial Catalog=Users;Integrated Security=True";

            SqlCommand cmd;
            SqlDataReader dreader;
            string sql;
            conn = new SqlConnection(constr);
            conn.Open();
            sql = "Select Name, Password from UserId";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                // output = output + dreader.GetValue(0) + " - " +
                //                   dreader.GetValue(1) + "\n";
                string us = dreader.GetString(0);
                string ps = dreader.GetString(1);
                if (us == user && ps == pass)
                {
                    return true;
                }
            }
            dreader.Close();
            cmd.Dispose();
            conn.Close();
            return false;
        }
    }
}
