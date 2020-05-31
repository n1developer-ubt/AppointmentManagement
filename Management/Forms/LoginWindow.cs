using System;

namespace Management
{
    public partial class LoginWindow : MetroFramework.Forms.MetroForm
    {
        public LoginWindow()
        {
            InitializeComponent();
            if (DesignMode)
                return;
            signup.Hide();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            login.MoveToSignup += LoginOnMoveToSignup;
            signup.MoveToLogin+=SignupOnMoveToLogin;
        }

        private void SignupOnMoveToLogin()
        {
            transition.HideSync(signup);
            transition.ShowSync(login);
            Text = "Login";
        }

        private void LoginOnMoveToSignup()
        {
            transition.HideSync(login);
            transition.ShowSync(signup);
            Text = "Signup";
        }
    }
}
