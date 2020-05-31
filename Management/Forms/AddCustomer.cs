using System;
using System.ComponentModel;
using System.Windows.Forms;
using Management.Controllers;
using Management.Delegation;

namespace Management.Forms
{
    public partial class AddCustomer : UBTStandardLibrary.Forms.N1Form
    {
        private CustomerManagement m;
        public event Dalegates.PerformAction NewCustomerAdded;
        public event Dalegates.PerformAction CustomerUpdated;
        public Customer CurrentCustomer;
        private bool Update = false;
        private string UpdateID = "";

        public AddCustomer()
        {
            InitializeComponent();
            this.Closing += OnClosing;
            m = new CustomerManagement();
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Reset();
            this.Hide();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }


        private void Reset()
        {
            btnAdd.Text = "Add";
            Text = "Add Customer";
            txtName.Text = txtName.Hint;
            txtAddress1.Text = txtAddress1.Hint;
            txtAddress2.Text = txtAddress2.Hint;
            txtCity.Text = txtCity.Hint; 
            txtCountry.Text = txtCountry.Hint; 
            txtPostalAddress.Text = txtPostalAddress.Hint; 
            txtPhoneNumber.Text = txtPhoneNumber.Hint;
            Update = false;
        }
        public void SetUpdate(string id)
        {
            //MessageBox.Show(id);
            Update = true;
            Customer c = m.GetCustomer(id);

            txtName.Text = c.Name;
            txtAddress1.Text = c.Address1;
            txtAddress2.Text = c.Address2;
            txtCity.Text = c.City;
            txtCountry.Text = c.Country;
            txtPostalAddress.Text = c.PostalAddress;
            txtPhoneNumber.Text =c.PhoneNumber;
            UpdateID = c.ID;

            btnAdd.Text = "Update";
            Text = "Update Customer";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.isEmptyOrHint())
            {
                txtName.Focus();
                return;
            }

            if (txtAddress1.isEmptyOrHint())
            {      
                txtAddress1.Focus();
                return;
            }

            if (txtCity.isEmptyOrHint())
            {      
                txtCity.Focus();
                return;
            }

            if (txtCountry.isEmptyOrHint())
            {      
                txtCountry.Focus();
                return;
            }

            if (txtPostalAddress.isEmptyOrHint())
            {      
                txtPostalAddress.Focus();
                return;
            }

            if (txtPhoneNumber.isEmptyOrHint())
            {      
                txtPhoneNumber.Focus();
                return;
            }

            

            Customer c = new Customer();
            
            c.Name = txtName.Text.Trim();
            c.PhoneNumber = txtPhoneNumber.Text.Trim();
            c.PostalAddress = txtPostalAddress.Text.Trim();
            c.City = txtCity.Text.Trim();
            c.Country = txtCountry.Text.Trim();
            c.Address2 = txtAddress2.isEmptyOrHint() ? "":txtAddress2.Text.Trim();
            c.Address1 = txtAddress1.Text.Trim();

            CurrentCustomer = c;

            if (Update)
            {
                CurrentCustomer.ID = UpdateID;
                c.ID = UpdateID;
                m.UpdateCustomer(c);
                CustomerUpdated?.Invoke();
            }
            else
            {
                CurrentCustomer.ID = m.AddCustomer(c);
                //MessageBox.Show(c.ID);
                NewCustomerAdded?.Invoke();
            }

            
            Reset();
            this.Hide();

        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnAdd_Click(null, null);
        }
    }
}
