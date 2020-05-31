using System;
using System.ComponentModel;
using System.Windows.Forms;
using Management.Forms;

namespace Management
{
    public partial class LoginWindow : UBTStandardLibrary.Forms.N1Form
    {
        private bool isClosing = true;
        public LoginWindow()
        {
            InitializeComponent();
            if (DesignMode)
                return;
            KeyPreview = true;
            signup.Hide();
            this.KeyDown += OnKeyDown;
            this.Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            if(isClosing)
                Environment.Exit(Environment.ExitCode);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.A)
            {
                using (Settings settings = new Settings())
                {
                    settings.ShowDialog();
                }
            }
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            login.MoveToSignup += LoginOnMoveToSignup;
            signup.MoveToLogin+=SignupOnMoveToLogin;
        }

        private void SignupOnMoveToLogin()
        {
            this.Text = "Login";
            login.Show();
            signup.Hide();
        }


        private void LoginOnMoveToSignup()
        {
            this.Text = "Signup";
            signup.Show();
            login.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
