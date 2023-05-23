using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarsDealer
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
            this.FormClosing += LoginPanel_FormClosing;
        }

        SqlConnection conn = new SqlConnection(DatabaseManager.GetConnectionString());

        private void loginButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string name_password_query = "SELECT COUNT(*) FROM users WHERE username = '"+usernameTextbox.Text+ "' AND password = '"+passwordTextbox.Text+"'";
            SqlCommand name_password_check = new SqlCommand(name_password_query, conn);
            string is_admin_query = "SELECT COUNT(*) FROM users WHERE username = '" + usernameTextbox.Text + "' AND password = '" + passwordTextbox.Text + "' AND is_admin = '"+true+"'";
            SqlCommand admin_check = new SqlCommand(is_admin_query, conn);

            if ((int)name_password_check.ExecuteScalar() > 0 && (int)admin_check.ExecuteScalar() <= 0)
            {
                UserPanel userPanel = new UserPanel();
                userPanel.Show();
                this.Hide();
                
            }
            else if((int)admin_check.ExecuteScalar() > 0){
                string is_boss_query = "SELECT COUNT(*) FROM users WHERE username = '" + usernameTextbox.Text + "' AND password = '" + passwordTextbox.Text + "' AND is_boss = '" + true + "'";
                SqlCommand boss_check = new SqlCommand(is_boss_query, conn);
                UserCredentials.isBoss = ((int)boss_check.ExecuteScalar() > 0);
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                error_label.Text = "Password or username is incorrect!";
            }

            UserCredentials.Username = usernameTextbox.Text;
            UserCredentials.Password = passwordTextbox.Text;
            UserCredentials.isAdmin = ((int)admin_check.ExecuteScalar() > 0);

            conn.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterPanel registerPanel = new RegisterPanel();
            registerPanel.Show();
            this.Hide();
        }

        private void showCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckbox.Checked)
            {
                passwordTextbox.PasswordChar = '\0';
            }
            else
            {
                passwordTextbox.PasswordChar = '*';
            }
        }

        private void LoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
