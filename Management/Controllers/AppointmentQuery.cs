using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Forms;
using MySql.Data.MySqlClient;
using Settings = Management.Properties.Settings;

namespace Management.Controllers
{
    class AppointmentQuery
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        public AppointmentQuery()
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

        public void Update(Appointment a)
        {
            string s = $"UPDATE {Settings.Default.AppointmentTable} SET CustomerName = '{a.CustomerName}', CustomerGroup = '{a.CustomerGroup}', Location = '{a.Location}', Requestor = '{a.Requestor}', ConfirmedBy = '{a.ConfirmedBy}', RegisterDate = '{a.Date.ToString("yyyy-MM-dd")}', StartTime = '{a.StartTime}', EndTime = '{a.EndTime}' WHERE ID = {a.ID}";
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
        }
        public void DeleteAppointment(string id)
        {
            ExecuteQuery($"DELETE FROM {Settings.Default.AppointmentTable} WHERE ID = {id}");
        }
        public List<Appointment> GetAllAppointment(string range)
        {
            if(range.Equals("*"))
                cmd.CommandText =
                $"SELECT ID, CustomerName, CustomerGroup, Location, Requestor, ConfirmedBy, RegisterDate, StartTime, EndTime FROM {Settings.Default.AppointmentTable} ";
            else
            {
                cmd.CommandText =
                    $"SELECT ID, CustomerName, CustomerGroup, Location, Requestor, ConfirmedBy, RegisterDate, StartTime, EndTime FROM {Settings.Default.AppointmentTable} WHERE RegisterDate BETWEEN DATE_SUB(NOW(), INTERVAL {range} DAY) AND NOW()";
                
            }
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Appointment> all = new List<Appointment>();

            while (reader.Read())
            {
                Appointment ap = new Appointment();
                ap.ID = reader.GetValue(0).ToString();
                ap.CustomerName = reader.GetValue(1).ToString();
                ap.CustomerGroup= reader.GetValue(2).ToString();
                ap.Location= reader.GetValue(3).ToString();
                ap.Requestor= reader.GetValue(4).ToString();
                ap.ConfirmedBy= reader.GetValue(5).ToString();
                ap.Date= DateTime.Parse(reader.GetValue(6).ToString());
                ap.StartTime= reader.GetValue(7).ToString();
                ap.EndTime= reader.GetValue(8).ToString();

                all.Add(ap);
            }

            reader.Close();

            return all;
        }
        public string AddAppointment(Appointment ap, string userId)
        {
            string q = $"INSERT INTO {Settings.Default.AppointmentTable} (CustomerName, CustomerGroup, Location, Requestor, ConfirmedBy, RegisterDate, StartTime, EndTime, UserID) VALUES ('{ap.CustomerName}','{ap.CustomerGroup}','{ap.Location}','{ap.Requestor}','{ap.ConfirmedBy}','{ap.Date.ToString("yyyy-MM-dd")}','{ap.StartTime}','{ap.EndTime}','{userId}')";
            ExecuteQuery(q);
            cmd.CommandText = "SELECT LAST_INSERT_ID()";
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string r = reader.GetValue(0).ToString();
            reader.Close();

            return r;
        }

        private void ExecuteQuery(string q)
        {
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
        }

    }
}
