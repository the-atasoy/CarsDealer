using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7B11AB0;Initial Catalog=cars.com;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            string name_password_query = "SELECT COUNT(*) FROM users WHERE username = '"+username_textbox.Text+ "' AND password = '"+password_textbox.Text+"'";
            SqlCommand name_password_check = new SqlCommand(name_password_query, conn);
            string is_admin_query = "SELECT COUNT(*) FROM users WHERE username = '" + username_textbox.Text + "' AND password = '" + password_textbox.Text + "' AND is_admin = '"+true+"'";
            SqlCommand admin_check = new SqlCommand(is_admin_query, conn);

            if ((int)name_password_check.ExecuteScalar() > 0 && (int)admin_check.ExecuteScalar() <= 0)
            {
                UserPanel userPanel = new UserPanel();
                userPanel.Show();
                this.Hide();
                
            }
            else if((int)admin_check.ExecuteScalar() > 0){
                string is_boss_query = "SELECT COUNT(*) FROM users WHERE username = '" + username_textbox.Text + "' AND password = '" + password_textbox.Text + "' AND is_boss = '" + true + "'";
                SqlCommand boss_check = new SqlCommand(is_boss_query, conn);
                UserCredentials.is_boss = ((int)boss_check.ExecuteScalar() > 0);
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                error_label.Text = "Password or username is incorrect!";
            }

            UserCredentials.Username = username_textbox.Text;
            UserCredentials.Password = password_textbox.Text;

            conn.Close();
        }

        private void elseif(bool v)
        {
            throw new NotImplementedException();
        }

        private void isadmin_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            RegisterPanel registerPanel = new RegisterPanel();
            registerPanel.Show();
            this.Hide();
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

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        public string getUserName()
        {
            return username_textbox.Text;
        }

        public string getPassword()
        {
            return password_textbox.Text;
        }
    }
}
