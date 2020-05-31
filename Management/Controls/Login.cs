using System.Windows.Forms;
using Management.Delegation;

namespace Management.Controls
{
    public partial class Login : UserControl
    {
        public event Dalegates.PerformAction MoveToSignup;
        public Login()
        {
            InitializeComponent();
        }

        private void lblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoveToSignup?.Invoke();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {

        }
    }
}
