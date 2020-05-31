using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Management.Controllers;

namespace Management.Forms
{
    public struct Appointment
    {
        public string ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public string CustomerGroup { get; set; }
        public string Location { get; set; }
        public string Requestor { get; set; }
        public string ConfirmedBy { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

    }
    public partial class AddAppointment : UBTStandardLibrary.Forms.N1Form
    {
        
        public event Delegation.Dalegates.PerformAction AppointmentAdded;
        public event Delegation.Dalegates.PerformAction AppointmentUpdated;
        public Appointment CurrentAppointment;
        private CustomerManagement m;
        private AppointmentQuery ap;
        private bool Update = false;
        private string UpdateId;
        public AddAppointment()
        {
            InitializeComponent();
            ap = new AppointmentQuery();
            m = new CustomerManagement();
            this.Closing += delegate(object sender, CancelEventArgs args)
            {
                args.Cancel = true; Reset();this.Hide(); };
            cbEndTime.SelectedIndex = 1;
            cbStartTime.SelectedIndex = 1;
            
            //cbStartTime.Hide();
            //cbEndTime.Hide();
        }

        public void SetUpdate(Appointment a)
        {
            txtTitle.Text = a.CustomerName;
            txtConfirmedBy.Text = a.ConfirmedBy;
            cbCustomerGroup.Text= a.CustomerGroup;
            txtLocation.Text = a.Location;
            txtRequestor.Text = a.Requestor;
            date.Value= a.Date;

            MyTime startTime = new MyTime(a.StartTime);
            MyTime endTime= new MyTime(a.EndTime);

            cbEndTime.SelectedIndex = endTime.Type;
            cbStartTime.SelectedIndex = startTime.Type;

            nudStartMin.Value = startTime.Min;
            nudEndMin.Value = endTime.Min;
            
            nudStartHour.Value = startTime.Hour;
            nudEndHour.Value = endTime.Hour;

            Update = true;

            Text = "Update";

            btnAdd.Text = "Update";

            UpdateId = a.ID;

        }



        private void Reset()
        {
            Text = "Add Appointment";
            btnAdd.Text = "Add";

            txtTitle.Text = txtTitle.Hint;
            txtConfirmedBy.Text = txtConfirmedBy.Hint;
            txtCustomerName.Text = txtCustomerName.Hint;
            txtRequestor.Text = txtRequestor.Hint;
            txtLocation.Text = txtLocation.Hint;

            date.Value = DateTime.Now;

            nudStartHour.Value = 1;
            nudEndHour.Value = 1;
            nudStartMin.Value = 0;
            nudEndMin.Value = 0;


            Update = false;

        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                List<string> s = m.GetAllCustomerName("");
                AddAllCustomer(s);
            }).Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;

            Appointment ap = new Appointment();
            ap.ConfirmedBy = txtConfirmedBy.Text;
            ap.CustomerGroup = cbCustomerGroup.Text;
            ap.Date = date.Value;


            string startTime = GetTime((int)nudStartHour.Value, (int)nudStartMin.Value,
                cbStartTime.SelectedIndex == 0 ? "AM" : "PM");
            string endTime = GetTime((int)nudEndHour.Value, (int)nudEndMin.Value,
                cbEndTime.SelectedIndex == 0 ? "AM" : "PM");

            ap.StartTime = startTime;
            ap.EndTime = endTime;

            ap.Location = txtLocation.Text.Trim();

            ap.Requestor = txtRequestor.Text.Trim();
            ap.CustomerName = txtTitle.Text.Trim();


            CurrentAppointment = ap;

            if (Update)
            {
                CurrentAppointment.ID = UpdateId;
                this.ap.Update(CurrentAppointment);
                AppointmentUpdated?.Invoke();
            }
            else
            {
                CurrentAppointment.ID = this.ap.AddAppointment(ap, UserData.UserId);
                AppointmentAdded?.Invoke();
            }

            Reset();
            this.Hide();
        }

        private bool Check()
        {
            if (txtTitle.isEmptyOrHint())
            {
                txtTitle.Focus();
                return false;
            }

            if (txtLocation.isEmptyOrHint())
            {      
                txtLocation.Focus();
                return false;
            }

            if (txtRequestor.isEmptyOrHint())
            {      
                txtRequestor.Focus();
                return false;
            }

            if (txtConfirmedBy.isEmptyOrHint())
            {      
                txtConfirmedBy.Focus();
                return false;
            }

            
            return true;
        }

        private string GetTime(int hour, int min, string t)
        {
            return $"{hour}:{min} {t}";
            DateTime dt = DateTime.Parse($"{hour}:{min} {t}");
            return dt.ToString("T");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool loading = false;
        private int sleep = 500;
        private string name = "";
        private void LoadCustomers(string n)
        {
            name = n;
            if (loading)
            {
                sleep = 500;
                return;
            }

            loading = true;
             new Thread(() =>
            {
                if (sleep != 0)
                {
                    sleep--;
                    Thread.Sleep(1);
                }

                loading = false;
                sleep = 500;
                List<string> customers = m.GetAllCustomerName(name);
                AddAllCustomer(customers);
                Thread.CurrentThread.Abort();
            }).Start();
        }

        private void AddAllCustomer(List<string> s)
        {
            dgvCustomers.Rows.Clear();
            dgvCustomers.SuspendLayout();
            foreach (string s1 in s)
            {
                dgvCustomers.Rows.Add(s1);
            }
            dgvCustomers.ResumeLayout();
        }

        private void txtCustomerName_OnValueChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtCustomerName.isEmptyOrHint()?"":txtCustomerName.Text.Trim());
        }

        private void dgvCustomers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                DataGridViewRow r = dgvCustomers.SelectedRows[0];

                if (r != null)
                {
                    txtTitle.Text = r.Cells[0].Value.ToString();
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
    public class MyTime
    {
        public int Hour { get; private set; }
        public int Min { get; private set; }
        public int Type { get; private set; }

        public MyTime(string time)
        {
            string[] data = time.Split(new char[] {':', ' '});
            Hour = Convert.ToInt16(data[0]);
            Min = Convert.ToInt16(data[1]);
            Type = data[2].Trim().ToLower().Equals("am") ? 0 : 1;
        }
    }
}
