using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management.Delegation;

namespace Management.Controls
{
    public partial class Signup : UserControl
    {
        public event Dalegates.PerformAction MoveToLogin;

        public Signup()
        {
            InitializeComponent();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoveToLogin?.Invoke();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

        }
    }
}
