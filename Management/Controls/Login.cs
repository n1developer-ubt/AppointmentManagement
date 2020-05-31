using System;
using System.Threading;
using System.Windows.Forms;
using Management.Controllers;
using Management.Delegation;
using Management.Forms;

namespace Management.Controls
{
    public partial class Login : UserControl
    {
        public event Dalegates.PerformAction MoveToSignup;

        private Authentication auth = null;
        private bool Do = false;
        public Login()
        {
            InitializeComponent();
            
            CheckForIllegalCrossThreadCalls = false;
            if (DesignMode)
                return;

            btnLogin.Enabled = false;
            new Thread(() =>
            {
                try
                {
                    auth = new Authentication();
                    Do = true;

                    btnLogin.Enabled = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Thread.CurrentThread.Abort();
            }).Start();
        }

        private void lblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoveToSignup?.Invoke();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {

            if (!btnLogin.Enabled) return;

            if (!Do)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error\nOpen settings by Control+Alt+Shift+A\n Then restart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            new Thread(() =>
            {
                txtUsername.Enabled = false;
                btnLogin.Enabled = false;
                lblSignup.Enabled = false;
                bool isOkay = auth.Authenticate(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (isOkay)
                {
                    
                    Thread mainThread = new Thread(() =>
                    {
                        MainWindow w = new MainWindow();
                        Application.Run(w);
                    }) { Name = "Main" };
                    mainThread.SetApartmentState(ApartmentState.STA);
                    mainThread.Start();
                    this.ParentForm.Hide();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Failed!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtUsername.Enabled = true;
                    btnLogin.Enabled = true;
                    lblSignup.Enabled = true;
                }
                Thread.CurrentThread.Abort();
            }).Start();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null,null);
            }
        }
    }
}
