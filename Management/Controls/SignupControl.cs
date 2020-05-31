using System;
using System.Threading;
using System.Windows.Forms;
using Management.Controllers;
using Management.Delegation;
using Management.Forms;

namespace Management.Controls
{
    public partial class SignupControl : UserControl
    {
        public event Dalegates.PerformAction MoveToLogin;

        private Authentication auth;
        private bool Do = false;
        public SignupControl()
        {
            InitializeComponent();
            new Thread(() =>
            {
                try
                {
                    auth = new Authentication();
                    Do = true;
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Thread.CurrentThread.Abort();
            }).Start();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (!btnSignup.Enabled)
                return;

            if (!Do)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error\nOpen settings by Control+Alt+Shift+A\n Then restart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MessageBox.Show(txtFullName.Text.Trim());
            if (txtFullName.isEmptyOrHint())
            {
                txtFullName.Focus();
                return;
            }

            if (txtEmail.isEmptyOrHint())
            {
                txtEmail.Focus();
                return;
            }
            if (txtUsername.isEmptyOrHint())
            {
                txtUsername.Focus();
                return;
            }

            if (txtPassword.isEmptyOrHint())
            {
                txtPassword.Focus();
                return;
            }

            btnSignup.Enabled = false;
            lblLogin.Enabled = false;
            txtUsername.Enabled = false;

            new Thread(() =>
            {
                bool isOkay = auth.Register(txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtEmail.Text.Trim(),
                    txtFullName.Text.Trim());

                if (isOkay)
                {
                    
                    Thread mainThread = new Thread(() =>
                    {
                        MainWindow w = new MainWindow();
                        Application.Run(w);
                    }) { Name = "Main" };
                    mainThread.SetApartmentState(ApartmentState.STA);
                    mainThread.Start();
                    ParentForm?.Hide();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Registered Failed!\nMaybe username or email already exist!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtUsername.Enabled = true;
                    lblLogin.Enabled = true;
                    btnSignup.Enabled = true;
                }
            }).Start();
            
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoveToLogin?.Invoke();
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnSignup_Click(null,null);
        }
    }
}
