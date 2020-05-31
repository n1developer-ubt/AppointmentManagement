using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Management.Properties;
using MySql.Data.MySqlClient;

namespace Management.Controllers
{
    public struct Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address1{ get; set; }
        public string Address2 { get; set; }
        public string City{ get; set; }
        public string Country{ get; set; }
        public string PostalAddress{ get; set; }
        public string PhoneNumber{ get; set; }
    }
    class CustomerManagement
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        public CustomerManagement()
        {
            con = new MySqlConnection(new MySqlConnectionStringBuilder() { Server = Properties.Settings.Default.Server, UserID = Properties.Settings.Default.Username, Port = (uint)Properties.Settings.Default.Port, Database = Properties.Settings.Default.Database, Password = Settings.Default.Password }.ConnectionString);

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

        public void UpdateCustomer(Customer c)
        {
            try
            {
                cmd.CommandText = $"UPDATE {Settings.Default.CustomersTable} SET Name = '{c.Name}', Address1 = '{c.Address1}', Address2 = '{c.Address2}', City = '{c.City}', Country = '{c.Country}', PostalAddress = '{c.PostalAddress}', PhoneNumber = '{c.PhoneNumber}' WHERE ID = {c.ID}";
                //MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> all = new List<Customer>();
            cmd.CommandText =
                $"SELECT ID, Name, Address1, Address2, City, Country, PostalAddress, PhoneNumber FROM {Settings.Default.CustomersTable}";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Customer c = new Customer();
                c.ID = reader.GetValue(0).ToString();
                c.Name = reader.GetValue(1).ToString();
                c.Address1= reader.GetValue(2).ToString();
                c.Address2= reader.GetValue(3).ToString();
                c.City= reader.GetValue(4).ToString();
                c.Country= reader.GetValue(5).ToString();
                c.PostalAddress= reader.GetValue(6).ToString();
                c.PhoneNumber = reader.GetValue(7).ToString();

                all.Add(c);
            }

            reader.Close();
            return all;
        }

        public void DeleteCustomer(string id)
        {
            cmd.CommandText = $"DELETE FROM {Settings.Default.CustomersTable} WHERE ID = {id}";
            cmd.ExecuteNonQuery();
        }

        public List<string> GetAllCustomerName(string n)
        {
            List<string> customerNameList = new List<string>();

            cmd.CommandText = $"SELECT Name FROM {Settings.Default.CustomersTable} WHERE Name LIKE '%{n}%'";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customerNameList.Add(reader.GetValue(0).ToString());
            }

            reader.Close();


            return customerNameList;
        }

        public Customer GetCustomer(string id)
        {
            cmd.CommandText =
                $"SELECT ID, Name, Address1, Address2, City, Country, PostalAddress, PhoneNumber FROM {Settings.Default.CustomersTable} WHERE ID = {id}";
            MySqlDataReader reader = cmd.ExecuteReader();
            Customer c = new Customer(); ;
            while (reader.Read())
            {
                c.ID = reader.GetValue(0).ToString();
                c.Name = reader.GetValue(1).ToString();
                c.Address1 = reader.GetValue(2).ToString();
                c.Address2 = reader.GetValue(3).ToString();
                c.City = reader.GetValue(4).ToString();
                c.Country = reader.GetValue(5).ToString();
                c.PostalAddress = reader.GetValue(6).ToString();
                c.PhoneNumber = reader.GetValue(7).ToString();
            }

            reader.Close();
            return c;
        }

        public string AddCustomer(Customer c)
        {
            string q = $"INSERT INTO {Settings.Default.CustomersTable} (Name, Address1, Address2, City, Country, PostalAddress, PhoneNumber) VALUES ('{c.Name}','{c.Address1}','{c.Address2}','{c.City}','{c.Country}','{c.PostalAddress}','{c.PhoneNumber}')";
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT LAST_INSERT_ID()";
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string r = reader.GetValue(0).ToString();
            reader.Close();

            return r;
        }
    }
}
