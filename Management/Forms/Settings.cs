using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Management.Forms
{
    public partial class Settings : UBTStandardLibrary.Forms.N1Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtDatabase.Text = Properties.Settings.Default.Database;
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;
            txtPort.Text = Properties.Settings.Default.Port+"";
            txtServer.Text = Properties.Settings.Default.Server;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;

            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = new MySqlConnectionStringBuilder(){Server = txtServer.Text, UserID = txtUsername.Text, Port = (uint)Convert.ToInt16(txtPort.Text),Database = txtDatabase.Text.Trim(),Password = txtPassword.Text.Trim()}.ConnectionString;

                try
                {
                    con.Open();
                }
                catch (Exception exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Can't Connect to the server at this time!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            Properties.Settings.Default.Port = Convert.ToInt16(txtPort.Text.Trim());
            Properties.Settings.Default.Server= txtServer.Text.Trim();
            Properties.Settings.Default.Database= txtDatabase.Text.Trim();
            Properties.Settings.Default.Username= txtUsername.Text.Trim();
            Properties.Settings.Default.Password= txtPassword.Text.Trim();
            Properties.Settings.Default.Save();

            MetroFramework.MetroMessageBox.Show(this, "Settings Saved!", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool Check()
        {
            try
            {
                Convert.ToInt16(txtPort.Text.Trim());
            }
            catch (Exception e)
            {
                txtPort.Focus();

                return false;
            }

            return true;
            if (txtServer.isEmptyOrHint())
            {
                txtServer.Focus();
                
                return false;
            }
            
            if (txtDatabase.isEmptyOrHint())
            {
                txtDatabase.Focus();
                return false;
            }


            if (txtUsername.isEmptyOrHint())
            {
                txtUsername.Focus();
                return false;
            }

            if (txtPassword.isEmptyOrHint())
            {
                txtPassword.Focus();
                return false;
            }


            return true;
        }
    }
}
