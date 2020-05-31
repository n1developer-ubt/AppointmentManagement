using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.DirectX.Common.Direct2D;
using Management.Controllers;
using Management.Forms;

namespace Management.Controls
{
    public partial class StaffControl : UserControl
    {
        private StaffRepository _sr = new StaffRepository();
        private AddStaff _as = new AddStaff();
        public StaffControl()
        {
            InitializeComponent();
            _as.Closing += AsOnClosing;
            _as.ActionPerformed += AsOnActionPerformed;
        }

        private void AsOnActionPerformed(Staff s, ActionType t)
        {
            if (t == ActionType.Added)
            {
                dgvData.Rows.Add(s.Id, s.FirstName, s.LastName, s.Address1, s.Address2, s.City, s.Country, s.PostalCode,
                    s.PhoneNumber, s.Qualification, s.Username, s.Password);
            }
            else if (t == ActionType.Updated)
            {
                foreach (DataGridViewRow r in dgvData.Rows)
                {
                    if (Convert.ToInt32(r.Cells[0].Value.ToString()) == s.Id)
                    {
                        r.Cells[1].Value = s.FirstName;
                        r.Cells[2].Value = s.LastName;
                        r.Cells[3].Value = s.Address1;
                        r.Cells[4].Value = s.Address2;
                        r.Cells[5].Value = s.City;
                        r.Cells[6].Value = s.Country;
                        r.Cells[7].Value = s.PostalCode;
                        r.Cells[8].Value = s.PhoneNumber;
                        r.Cells[9].Value = s.Qualification;
                        r.Cells[10].Value = s.Username;
                        r.Cells[11].Value = s.Password;
                        break;
                    }

                }
            }
        }

        private void AsOnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            _as.Hide();
            _as.Clear();
        }

        private void StaffControl_Load(object sender, EventArgs e)
        {
            List<Staff> all = _sr.GetAllStaff();

            foreach (Staff s in all)
            {
                dgvData.Rows.Add(s.Id, s.FirstName, s.LastName, s.Address1, s.Address2, s.City, s.Country, s.PostalCode,
                    s.PhoneNumber, s.Qualification, s.Username, s.Password);
            }
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            _as.ShowDialog();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = null;
            try
            {
                 r = dgvData.SelectedRows[0];
            }
            catch (Exception exception)
            {
                return;
            }

            Staff s = new Staff();
            s.Id = Convert.ToInt32(r.Cells[0].Value);
            s.FirstName = r.Cells[1].Value.ToString();
            s.LastName = r.Cells[2].Value.ToString();
            s.Address1 = r.Cells[3].Value.ToString();
            s.Address2 = r.Cells[4].Value.ToString();
            s.City= r.Cells[5].Value.ToString();
            s.Country= r.Cells[6].Value.ToString();
            s.PostalCode= r.Cells[7].Value.ToString();
            s.PhoneNumber= r.Cells[8].Value.ToString();
            s.Qualification= r.Cells[9].Value.ToString();
            s.Username= r.Cells[10].Value.ToString();
            s.Password= r.Cells[11].Value.ToString();
            _as.SetUpdate(s);
            _as.ShowDialog();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = null;
            try
            {
                r = dgvData.SelectedRows[0];
            }
            catch (Exception exception)
            {
                return;
            }

            if (MessageBox.Show("Are you sure?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) !=
                DialogResult.Yes)
                return;
            int res = _sr.DeleteStaff(Convert.ToInt32(r.Cells[0].Value.ToString()));

            if (res < 0)
            {
                MessageBox.Show("Unable To Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvData.Rows.Remove(r);
        }
    }
}
