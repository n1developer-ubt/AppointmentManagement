using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Properties;
using MySql.Data.MySqlClient;

namespace Management.Controllers
{
    public class Authentication
    {
        private MySqlConnection con;
        private MySqlCommand cmd;

        public Authentication()
        {
            con = new MySqlConnection(new MySqlConnectionStringBuilder() { Server = Settings.Default.Server, UserID = Settings.Default.Username, Port = (uint)Settings.Default.Port, Database = Settings.Default.Database, Password = Settings.Default.Password }.ConnectionString);

            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                throw new Exception();
            }

            cmd = con.CreateCommand();
        }

        public bool Register(string username, string password, string email, string fullName)
        {
            string query =
                $"INSERT INTO {Settings.Default.LoginTable} (Username, Password, Email, FullName) VALUES ('{username}','{password}','{email}','{fullName}')";

            if (ExecuteQuery(query) > 0)
                return true;

            return false;

        }

        private int ExecuteQuery(string query)
        {
            cmd.CommandText = query;
            int row = 0;

            try
            {
                row = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
            }

            return row;
        }

        public bool Authenticate(string username, string password)
        {
            return HasRow($"SELECT ID FROM {Settings.Default.LoginTable} WHERE Username = '{username}' AND Password = '{password}'");
        }

        public bool HasRow(string query)
        {
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();

            bool result = reader.HasRows;

            reader.Close();

            return result;

        }

    }
}
