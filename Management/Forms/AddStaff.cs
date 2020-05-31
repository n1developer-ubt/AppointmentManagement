using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.DirectXPaint.Svg;
using Management.Controllers;

namespace Management.Forms
{
    public partial class AddStaff : UBTStandardLibrary.Forms.N1Form
    {
        public delegate void Action(Staff s, ActionType t);
        private StaffRepository _sr = new StaffRepository();

        public event Action ActionPerformed;
        private bool _isUpdate = false;
        private Staff _updatedStaff;
        public AddStaff()
        {
            InitializeComponent();
        }

        public void SetUpdate(Staff s)
        {
            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtAddress1.Text = s.Address1;
            txtAddress2.Text = s.Address2;
            txtCountry.Text = s.Country;
            txtCity.Text = s.City;
            txtPostalCode.Text = s.PostalCode;
            txtPhoneNumber.Text = s.PhoneNumber;
            txtQualification.Text = s.Qualification;
            txtUsername.Text = s.Username;
            txtPassword.Text = s.Password;

            Text = "Update Staff";
            _updatedStaff = s;
            TitleText = "Update Staff";
            _isUpdate = true;
            btnAddStaff.Text = "Update Staff";
        }

        public void Clear()
        {
            txtFirstName.Text = txtFirstName.Hint;
            txtLastName.Text = txtLastName.Hint;
            txtAddress1.Text = txtAddress1.Hint;
            txtAddress2.Text = txtAddress2.Hint;
            txtCity.Text = txtCity.Hint;
            txtCountry.Text = txtCountry.Hint;
            txtPostalCode.Text = txtPostalCode.Hint;
            txtPhoneNumber.Text = txtPhoneNumber.Hint;
            txtQualification.Text = txtQualification.Hint;
            txtUsername.Text = txtUsername.Hint;
            txtPassword.Text = txtPassword.Hint;
            btnAddStaff.Text = "Add Staff";
            Text = "Add Staff";
            TitleText = "Add Staff";
            _isUpdate = false;
            _updatedStaff = null;
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (txtFirstName.isEmptyOrHint())
            {
                txtFirstName.Focus();
                return;
            }
            if (txtLastName.isEmptyOrHint())
            {
                txtLastName.Focus();
                return;
            }
            if (txtAddress1.isEmptyOrHint())
            {
                txtAddress1.Focus();
                return;
            }
            if (txtAddress2.isEmptyOrHint())
            {
                txtAddress2.Focus();
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

            if (txtPostalCode.isEmptyOrHint())
            {   
                txtPostalCode.Focus();
                return;
            }

            if (txtPhoneNumber.isEmptyOrHint())
            {   
                txtPhoneNumber.Focus();
                return;
            }
            if (txtQualification.isEmptyOrHint())
            {   
                txtQualification.Focus();
                return;
            }
            Staff newStaff = new Staff()
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Address1 = txtAddress1.Text.Trim(),
                Address2 = txtAddress2.Text.Trim(),
                City = txtCity.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Qualification = txtQualification.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Username= txtUsername.Text.Trim(),
            };
            if (_isUpdate)
            {
                if (_updatedStaff == null)
                {
                    MessageBox.Show("Error in system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                newStaff.Id = _updatedStaff.Id;
                int res = _sr.UpdateStaff(newStaff);

                if (res < 0)
                {
                    MessageBox.Show("Error In Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ActionPerformed?.Invoke(newStaff, ActionType.Updated);
                    Hide();
                }
            }
            else
            {
                int res = _sr.AddStaffMember(newStaff);
                if (res < 0)
                {
                    MessageBox.Show("Error In Adding New Staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    newStaff.Id = res;
                    ActionPerformed?.Invoke(newStaff, ActionType.Added);
                    Hide();
                }
            }
            Clear();
        }
    }

    public enum ActionType
    {
        Added,
        Updated
    }
}
