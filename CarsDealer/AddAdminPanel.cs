using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CarsDealer
{
    public partial class AddAdminPanel : Form
    {
        public AddAdminPanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server = .;Database = CarsDealer; Integrated Security=True");

        private void AddUserPanel_Load(object sender, EventArgs e)
        {
            string Username = UserCredentials.Username;
            string Password = UserCredentials.Password;
            bool IsBoss = UserCredentials.isBoss;
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string email = emailTextbox.Text;
            string phonenumber = phonenumberTextbox.Text;
            string password = passwordTextbox.Text;
            bool is_admin = true;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All information should be filled.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO users (username, email, phonenumber, password, is_admin) " +
                           "VALUES (@username, @email, @phonenumber, @password, @is_admin)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@is_admin", is_admin);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAdminForm();
                }
                else
                {
                    MessageBox.Show("Failed to add admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAdminForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearAdminForm()
        {
            usernameTextbox.Clear();
            emailTextbox.Clear();
            phonenumberTextbox.Clear();
            passwordTextbox.Clear();
        }
    }
}
