using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management.Properties;
using MySql.Data.MySqlClient;

namespace Management.Controllers
{
    
    public class StaffRepository
    {
        private MySqlConnection _con;
        private MySqlCommand _cmd;

        public StaffRepository()
        {
            _con = new MySqlConnection(new MySqlConnectionStringBuilder() { Server = Settings.Default.Server, UserID = Settings.Default.Username, Port = (uint)Settings.Default.Port, Database = Settings.Default.Database, Password = Settings.Default.Password }.ConnectionString);
            _cmd = _con.CreateCommand();
        }

        private bool OpenConnection()
        {
            try
            {
                if(_con.State != ConnectionState.Open)
                    _con.Open();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Staff> GetAllStaff()
        {
            List<Staff> allStaff = new List<Staff>();

            if (!OpenConnection())
                return allStaff;

            _cmd.CommandText = "SELECT * FROM Staff";

            MySqlDataReader reader = _cmd.ExecuteReader();
            while (reader.Read())
            {
                Staff s =new Staff()
                {
                    Id = reader.GetInt32("id"),
                    City = reader.GetString("city"),
                    LastName = reader.GetString("lastname"),
                    Address2 = reader.GetString("address1"),
                    Address1 = reader.GetString("address2"),
                    PostalCode = reader.GetString("postalcode"),
                    Country = reader.GetString("country"),
                    PhoneNumber = reader.GetString("phonenumber"),
                    Qualification = reader.GetString("qualification"),
                    FirstName = reader.GetString("firstname"),
                    Username = reader.GetString("username"),
                    Password= reader.GetString("password")
                };
                allStaff.Add(s);
            }
            reader.Close();
            return allStaff;
        }

        public int AddStaffMember(Staff newStaff)
        {
            if (!OpenConnection())
                return -1;
            int res = Execute(
                $"INSERT INTO Staff (FirstName, LastName, Address1, Address2, City, Country, PostalCode, PhoneNumber, Qualification, Username, Password) VALUES ('{newStaff.FirstName}','{newStaff.LastName}','{newStaff.Address1}','{newStaff.Address2}','{newStaff.City}','{newStaff.Country}','{newStaff.PostalCode}','{newStaff.PhoneNumber}', '{newStaff.Qualification}', '{newStaff.Username}', '{newStaff.Password}')");
            if (res < 0)
                return -1;

            return GetId();
        }

        public int UpdateStaff(Staff updatedStaff)
        {
            return Execute(
                $"UPDATE Staff SET FirstName = '{updatedStaff.FirstName}', LastName = '{updatedStaff.LastName}', Address1 = '{updatedStaff.Address1}', Address2 = '{updatedStaff.Address2}', City = '{updatedStaff.City}', Country = '{updatedStaff.Country}', PostalCode = '{updatedStaff.PostalCode}', PhoneNumber = '{updatedStaff.PhoneNumber}', Qualification = '{updatedStaff.Qualification}', Username = '{updatedStaff.Username}', Password = '{updatedStaff.Password}' WHERE Id = {updatedStaff.Id}");
        }

        public int DeleteStaff(int id)
        {
            if (!OpenConnection())
                return -1;

            return Execute($"DELETE FROM Staff WHERE Id = {id}");
        }

        private int Execute(string cmd)
        {
            if (!OpenConnection())
                return -1;
            _cmd.CommandText = cmd;

            try
            {
                return _cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        private int GetId()
        {
            if (!OpenConnection())
                return -1;

            try
            {
                return Convert.ToInt16(ReadFirstElement("SELECT LAST_INSERT_ID()"));
            }
            catch (Exception r)
            {
                return -1;
            }
        }

        private string ReadFirstElement(string query)
        {
            if (!OpenConnection())
                return null;
            _cmd.CommandText = query;

            MySqlDataReader reader = _cmd.ExecuteReader();

            string output = null;

            if (reader.HasRows)
            {
                reader.Read();
                output = reader.GetValue(0).ToString();
            }

            reader.Close();

            return output;
        }
    }
}
