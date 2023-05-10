using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection.Emit;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            string username_query = "SELECT COUNT(*) FROM users WHERE username = '"+username_textboox.Text+"'";
            SqlCommand user_check = new SqlCommand(username_query, conn);
            string email_query = "SELECT COUNT(*) FROM users WHERE email = '" + email_textboox.Text + "'";
            SqlCommand email_check = new SqlCommand(email_query, conn);
            string phonenumber_query = "SELECT COUNT(*) FROM users WHERE email = '" + phone_textbox.Text + "'";
            SqlCommand phone_check = new SqlCommand(email_query, conn);
            bool anyTrue = false;

            if ((int)user_check.ExecuteScalar() > 0)
            {
                is_username_label.Text = "'" + username_textboox.Text + "' belongs to another user!";
                anyTrue = true;
            }

            if (String.IsNullOrEmpty(username_textboox.Text))
            {
                is_username_label.Text = "Username cannot be empty!";
                anyTrue = true;
            }

            if ((int)email_check.ExecuteScalar() > 0)
            {
                is_email_label.Text = "'" + email_textboox.Text + "' belongs to another user!";
                anyTrue = true;
            }

            if (String.IsNullOrEmpty(email_textboox.Text))
            {
                is_email_label.Text = "Email cannot be empty!";
                anyTrue = true;
            }

            if ((int)phone_check.ExecuteScalar() > 0)
            {
                is_phonenumber_label.Text = "'" + phone_textbox.Text + "' belongs to another user!";
                anyTrue = true;
            }

            if (String.IsNullOrEmpty(phone_textbox.Text))
            {
                is_phonenumber_label.Text = "Phone number cannot be empty!";
                anyTrue = true;
            }

            if (!Regex.IsMatch(phone_textbox.Text, @"^\d+$"))
            {
                is_phonenumber_label.Text = "Invalid Type!";
                anyTrue = true;
            }

            if(phone_textbox.Text.Length < 10)
            {
                is_phonenumber_label.Text = "Phone number must be 10 digits!";
            }

            if (String.IsNullOrEmpty(password_textbox.Text))
            {
                is_password_label.Text = "Password cannot be empty!";
                anyTrue = true;
            }

            if (!anyTrue)
            {
                SqlCommand cmd1 = new SqlCommand("insert into users (username, email, phonenumber, password)values('" + username_textboox.Text + "','" + email_textboox.Text + "', '" + phone_textbox.Text + "', '" + password_textbox.Text + "')", conn);
                cmd1.ExecuteNonQuery();
                register_label.Text = "Register Successful";
            }


            conn.Close();
        }

        private void username_textboox_TextChanged(object sender, EventArgs e)
        {
            is_username_label.Text = String.Empty;
        }

        private void email_textboox_TextChanged(object sender, EventArgs e)
        {
            is_email_label.Text = String.Empty;
        }

        private void phone_textbox_TextChanged(object sender, EventArgs e)
        {
            is_phonenumber_label.Text = String.Empty;
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            is_password_label.Text = String.Empty;
        }


        private void register_form_Load(object sender, EventArgs e)
        {

        }

        private void show_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_checkbox.Checked)
            {
                password_textbox.PasswordChar = '\0'; // Show password as plain text
            }
            else
            {
                password_textbox.PasswordChar = '*'; // Hide password
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void login_panel_button_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Hide();
        }
    }
}
