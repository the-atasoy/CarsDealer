using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Cars
{
    public partial class RegisterPanel : Form
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7B11AB0;Initial Catalog=cars.com;Integrated Security=True");

        private void register_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            string usernameQuery = "SELECT COUNT(*) FROM users WHERE username = '"+usernameTextboox.Text+"'";
            SqlCommand userCheck = new SqlCommand(usernameQuery, conn);
            string emailQuery = "SELECT COUNT(*) FROM users WHERE email = '" + emailTextboox.Text + "'";
            SqlCommand emailCheck = new SqlCommand(emailQuery, conn);
            string phonenumberQuery = "SELECT COUNT(*) FROM users WHERE email = '" + phoneTextbox.Text + "'";
            SqlCommand phoneCheck = new SqlCommand(phonenumberQuery, conn);
            bool anyTrue = false;

            if ((int)userCheck.ExecuteScalar() > 0)
            {
                is_username_label.Text = "'" + usernameTextboox.Text + "' belongs to another user!";
                anyTrue = true;
            }

            if (String.IsNullOrEmpty(usernameTextboox.Text))
            {
                is_username_label.Text = "Username cannot be empty!";
                anyTrue = true;
            }

            if ((int)emailCheck.ExecuteScalar() > 0)
            {
                is_email_label.Text = "'" + emailTextboox.Text + "' belongs to another user!";
                anyTrue = true;
            }

            if (String.IsNullOrEmpty(emailTextboox.Text))
            {
                is_email_label.Text = "Email cannot be empty!";
                anyTrue = true;
            }

            if ((int)phoneCheck.ExecuteScalar() > 0)
            {
                is_phonenumber_label.Text = "'" + phoneTextbox.Text + "' belongs to another user!";
                anyTrue = true;
            }

            if (String.IsNullOrEmpty(phoneTextbox.Text))
            {
                is_phonenumber_label.Text = "Phone number cannot be empty!";
                anyTrue = true;
            }

            if (!Regex.IsMatch(phoneTextbox.Text, @"^\d+$"))
            {
                is_phonenumber_label.Text = "Invalid Type!";
                anyTrue = true;
            }

            if(phoneTextbox.Text.Length < 10)
            {
                is_phonenumber_label.Text = "Phone number must be 10 digits!";
            }

            if (String.IsNullOrEmpty(passwordTextbox.Text))
            {
                is_password_label.Text = "Password cannot be empty!";
                anyTrue = true;
            }

            if (!anyTrue)
            {
                SqlCommand cmd1 = new SqlCommand("insert into users (username, email, phonenumber, password)values('" + usernameTextboox.Text + "','" + emailTextboox.Text + "', '" + phoneTextbox.Text + "', '" + passwordTextbox.Text + "')", conn);
                cmd1.ExecuteNonQuery();
                register_label.Text = "Register Successful";
            }


            conn.Close();
        }

        private void usernameTextboox_TextChanged(object sender, EventArgs e)
        {
            is_username_label.Text = String.Empty;
        }

        private void emailTextboox_TextChanged(object sender, EventArgs e)
        {
            is_email_label.Text = String.Empty;
        }

        private void phoneTextbox_TextChanged(object sender, EventArgs e)
        {
            is_phonenumber_label.Text = String.Empty;
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            is_password_label.Text = String.Empty;
        }

        private void showCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckbox.Checked)
            {
                passwordTextbox.PasswordChar = '\0'; // Show password as plain text
            }
            else
            {
                passwordTextbox.PasswordChar = '*'; // Hide password
            }
        }

        private void loginPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Hide();
        }
    }
}
