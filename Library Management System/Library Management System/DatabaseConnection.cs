using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Library_Management_System
{
    internal class DatabaseConnection
    {

        private const string host = "localhost";
        private const string port = "3307";
        private const string username = "root";
        private const string password = "";
        private const string database = "lib_management_system";


        const string conString = "Server =" + host +
            "; Port =" + port +
            "; Username =" + username +
            "; Password =" + password +
            "; Database =" + database + ";";


       public static DataTable queryData(String sql)
        {
            using(MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //cmd.Connection = con;
                    //cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = sql;

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        con.Close();
                        return data;
                    }
                } catch(MySqlException exc)
                {
                    MessageBox.Show("Error Connection: " + exc.Message);
                    return null;
                }
            }
        }


        public static void executeQuery(String sql)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand(sql, con);
                    command.ExecuteNonQuery();

                }
                catch (MySqlException exc)
                {
                    MessageBox.Show("Error Connection: " + exc.Message.ToString());
                }
            }
        }

    }
}
