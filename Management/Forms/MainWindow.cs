using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Management.Controllers;

namespace Management.Forms
{
    public partial class MainWindow : UBTStandardLibrary.Forms.N1Form
    {
        private AddAppointment addAppointment;
        private CustomerManagement customerManagement;
        private AppointmentQuery q;
        private AddCustomer addCustomer;
        
        public MainWindow()
        {
            InitializeComponent();
            q = new AppointmentQuery();
            addAppointment = new AddAppointment();
            addAppointment.AppointmentAdded += AddAppointmentOnAppointmentAdded;
            CheckForIllegalCrossThreadCalls = false;
            customerManagement = new CustomerManagement();
            addCustomer = new AddCustomer();
            addCustomer.NewCustomerAdded+=AddCustomerOnNewCustomerAdded;
            LoadAllCustomers();
            LoadAllAppointments("*");
            addCustomer.CustomerUpdated += AddCustomerOnCustomerUpdated;
            addAppointment.AppointmentUpdated += AddAppointmentOnAppointmentUpdated;
            this.Closing+=OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void AddAppointmentOnAppointmentUpdated()
        {
            Appointment a = addAppointment.CurrentAppointment;

            for (int x = 0; x < dgvData.Rows.Count; x++)
            {
                if (dgvData.Rows[x].Cells[0].Value.Equals(a.ID))
                {
                    dgvData.Rows[x].Cells[1].Value = a.StartTime;
                    dgvData.Rows[x].Cells[2].Value = a.EndTime;
                    dgvData.Rows[x].Cells[3].Value = a.Date.ToString("yyyy-MM-dd");
                    dgvData.Rows[x].Cells[4].Value = a.CustomerName;
                    dgvData.Rows[x].Cells[5].Value = a.CustomerGroup;
                    dgvData.Rows[x].Cells[6].Value = a.Location;
                    dgvData.Rows[x].Cells[7].Value = a.Requestor;
                    dgvData.Rows[x].Cells[8].Value = a.ConfirmedBy;
                    break;
                }
            }

        }

        private void AddCustomerOnCustomerUpdated()
        {
            Customer c = addCustomer.CurrentCustomer;

            for (int x = 0; x < dgvCustomers.Rows.Count; x++)
            {
                if (dgvCustomers.Rows[x].Cells[0].Value.Equals(c.ID))
                {
                    dgvCustomers.Rows[x].Cells[1].Value = c.Name;
                    dgvCustomers.Rows[x].Cells[2].Value = c.PhoneNumber;
                    dgvCustomers.Rows[x].Cells[3].Value = c.Address1 + " " +c.Address2;
                    break;
                }
            }

        }

        private void AddCustomerOnNewCustomerAdded()
        {
            Customer newCustomer = addCustomer.CurrentCustomer;
            //MessageBox.Show(newCustomer.ID, newCustomer.Name);
            
            dgvCustomers.Rows.Add(newCustomer.ID,newCustomer.Name, newCustomer.PhoneNumber,
                newCustomer.Address1 + " " + newCustomer.Address2);
        }

        private void LoadAllAppointments(string range)
        {
            
            Thread th = new Thread(() =>
            {
                EnableAllAppointmentsButtons(false);
                dgvData.SuspendLayout();
                dgvData.Rows.Clear();
                List<Appointment> app = q.GetAllAppointment(range);

                foreach (Appointment appointment in app)
                {
                    dgvData.Rows.Add(appointment.ID, appointment.StartTime, appointment.EndTime, appointment.Date.ToString("yyyy-MM-dd"), appointment.CustomerName, appointment.CustomerGroup,appointment.Location, appointment.Requestor, appointment.ConfirmedBy);
                }
                dgvData.ResumeLayout();
                EnableAllAppointmentsButtons(true);
            });
            th.Start();
        }

        private void EnableAllAppointmentsButtons(bool enable)
        {
            btnNewAppointment.Enabled = enable;
            btnDeleteAppointment.Enabled = enable;
            btnUpdateAppointment.Enabled = enable;
        }

        private void AddAppointmentOnAppointmentAdded()
        {
            Appointment newAppointment = addAppointment.CurrentAppointment;
            dgvData.Rows.Add(newAppointment.ID,newAppointment.StartTime, newAppointment.EndTime,
                newAppointment.Date.ToString("yyyy-MM-dd"), newAppointment.CustomerName, newAppointment.CustomerGroup,
                newAppointment.Location, newAppointment.Requestor, newAppointment.ConfirmedBy);

        }

        private void rgType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (rgType.SelectedIndex)
            {
                case 0:
                    LoadAllAppointments("*");
                    break;
                case 1:
                    LoadAllAppointments("7");
                    break;
                case 2:
                    LoadAllAppointments("30");
                    break;
            }
        }

        private void btnNewAppointment_Click(object sender, System.EventArgs e)
        {
            addAppointment.ShowDialog();
        }

        private void btnDeleteAppointment_Click(object sender, System.EventArgs e)
        {
            DataGridViewRow r = dgvData.SelectedRows[0];

            if (r != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Delete", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    q.DeleteAppointment(r.Cells[0].Value.ToString());
                    try
                    {
                        dgvData.Rows.Remove(r);
                    }
                    catch (Exception exception)
                    {
                        
                    }
                }
            }

        }

        private void btnDeleteCustomer_Click(object sender, System.EventArgs e)
        {
            DataGridViewRow r = dgvCustomers.SelectedRows[0];

            if (r != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Delete", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    customerManagement.DeleteCustomer(r.Cells[0].Value.ToString());
                    dgvCustomers.Rows.Remove(r);
                }
            }
        }

        private void LoadAllCustomers()
        {
            Thread th  = new Thread(() =>
            {
                EnableAllCustomerButton(false);
                dgvCustomers.SuspendLayout();
                List<Customer> c = customerManagement.GetAllCustomer();

                foreach (Customer customer in c)
                {
                    dgvCustomers.Rows.Add(customer.ID,customer.Name, customer.PhoneNumber,
                        customer.Address1 + " " + customer.Address2);
                }

                dgvCustomers.ResumeLayout();
                EnableAllCustomerButton(true);
            });
            th.Start();
        }

        private void EnableAllCustomerButton(bool enable)
        {
            btnNewCustomer.Enabled = enable;
            btnUpdateCustomer.Enabled = enable;
            btnDeleteCustomer.Enabled = enable;
        }

        private void btnNewCustomer_Click(object sender, System.EventArgs e)
        {
            addCustomer.ShowDialog();
        }

        private void btnUpdateCustomer_Click(object sender, System.EventArgs e)
        {
            DataGridViewRow r = null;
            try
            {
                r = dgvCustomers.SelectedRows[0];
            }
            catch (Exception rx)
            {
                //
            }

            if (r == null) return;

            //MessageBox.Show(""+ r.Cells[0].Value);
            addCustomer.SetUpdate(r.Cells[0].Value.ToString());
            addCustomer.ShowDialog();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = null;

            try
            {
                r = dgvData.SelectedRows[0];
            }
            catch (Exception exception)
            {
                
            }

            if (r == null) return;

            Appointment a = new Appointment();

            a.ID = r.Cells[0].Value.ToString();
            a.StartTime = r.Cells[1].Value.ToString();
            a.EndTime = r.Cells[2].Value.ToString();
            a.Date = DateTime.Parse(r.Cells[3].Value.ToString());
            a.CustomerName = r.Cells[4].Value.ToString();
            a.CustomerGroup= r.Cells[5].Value.ToString();
            a.Location= r.Cells[6].Value.ToString();
            a.Requestor= r.Cells[7].Value.ToString();
            a.ConfirmedBy= r.Cells[8].Value.ToString();
            addAppointment.SetUpdate(a);
            addAppointment.ShowDialog();
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {

        }
    }
}
