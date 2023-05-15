using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cars
{
    public partial class AdminPanel : Form
    {
        private SqlConnection conn;

        public AdminPanel()
        {
            InitializeComponent();

            // Initialize the SqlConnection
            conn = new SqlConnection("Data Source=DESKTOP-7B11AB0;Initial Catalog=cars.com;Integrated Security=True");
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadMakes();
            LoadUsers();
        }

        private void LoadMakes()
        {
            string query = "SELECT DISTINCT make FROM cars ORDER BY make ASC";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    makeCombobox.Items.Add(reader["make"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading makes: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadModels(string selectedMake)
        {
            modelCombobox.Items.Clear();
            modelCombobox.Text = "Select Model";

            string query = "SELECT DISTINCT model FROM cars WHERE make=@make ORDER BY model ASC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@make", selectedMake);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    modelCombobox.Items.Add(reader["model"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading models: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadUsers()
        {
            string query = "SELECT username, email, phonenumber, password, register_date, is_admin, is_boss FROM users ORDER BY is_boss DESC, is_admin DESC, username ASC";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            userTable.DataSource = dataTable;
            userTable.ReadOnly = true;
        }

        private void makeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMake = makeCombobox.SelectedItem.ToString();
            LoadModels(selectedMake);
        }

        private void showCarsButton_Click(object sender, EventArgs e)
        {
            string selectedMake = makeCombobox.SelectedItem != null ? makeCombobox.SelectedItem.ToString() : "";
            string selectedModel = modelCombobox.SelectedItem != null ? modelCombobox.SelectedItem.ToString() : "";

            string query;
            SqlCommand cmd;

            if (string.IsNullOrEmpty(selectedMake) && string.IsNullOrEmpty(selectedModel))
            {
                query = "SELECT make, model, year, version, color, CONCAT(km, ' km') as km, CONCAT(cylinder_capacity, ' cc') as cylinder_capacity, CONCAT(hp, ' hp') as hp, CONCAT(price, ' $') as price FROM cars ORDER BY make ASC, model ASC";
                cmd = new SqlCommand(query, conn);
            }
            else if (string.IsNullOrEmpty(selectedModel))
            {
                query = "SELECT make, model, year, version, color, CONCAT(km, ' km') as km, CONCAT(cylinder_capacity, ' cc') as cylinder_capacity, CONCAT(hp, ' hp') as hp, CONCAT(price, ' $') as price FROM cars WHERE make=@make ORDER BY make ASC, model ASC";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@make", selectedMake);
            }
            else
            {
                query = "SELECT make, model, year, version, color, CONCAT(km, ' km') as km, CONCAT(cylinder_capacity, ' cc') as cylinder_capacity, CONCAT(hp, ' hp') as hp, CONCAT(price, ' $') as price FROM cars WHERE make=@make AND model=@model ORDER BY make ASC, model ASC";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@make", selectedMake);
                cmd.Parameters.AddWithValue("@model", selectedModel);
            }

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                carsTable.DataSource = dataTable;
                carsTable.ReadOnly = true;

                // Set column widths
                carsTable.Columns["make"].Width = 100;
                carsTable.Columns["model"].Width = 100;
                carsTable.Columns["year"].Width = 60;
                carsTable.Columns["version"].Width = 100;
                carsTable.Columns["color"].Width = 80;
                carsTable.Columns["km"].Width = 80;
                carsTable.Columns["cylinder_capacity"].Width = 100;
                carsTable.Columns["hp"].Width = 80;
                carsTable.Columns["price"].Width = 80;

                // Set column headers
                carsTable.Columns["make"].HeaderText = "Make";
                carsTable.Columns["model"].HeaderText = "Model";
                carsTable.Columns["year"].HeaderText = "Year";
                carsTable.Columns["version"].HeaderText = "Version";
                carsTable.Columns["color"].HeaderText = "Color";
                carsTable.Columns["km"].HeaderText = "Kilometers";
                carsTable.Columns["cylinder_capacity"].HeaderText = "Cylinder Capacity";
                carsTable.Columns["hp"].HeaderText = "Horsepower";
                carsTable.Columns["price"].HeaderText = "Price";

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected user(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in userTable.SelectedRows)
                    {
                        object isBossValue = row.Cells["is_boss"].Value;
                        if (isBossValue != DBNull.Value && Convert.ToBoolean(isBossValue))
                        {
                            MessageBox.Show("Cannot delete a boss user.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue; // Skip deleting this row
                        }

                        string username = row.Cells["username"].Value.ToString();
                        DeleteUser(username);
                        userTable.Rows.Remove(row);
                    }
                }
            }
        }



        private void DeleteUser(string username)
        {
            string query = "DELETE FROM users WHERE username=@username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            if (carsTable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected car(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in carsTable.SelectedRows)
                    {
                        string make = row.Cells["make"].Value.ToString();
                        string model = row.Cells["model"].Value.ToString();
                        DeleteCar(make, model);
                        carsTable.Rows.Remove(row);
                    }
                }
            }
        }

        private void DeleteCar(string make, string model)
        {
            string query = "DELETE FROM cars WHERE make=@make AND model=@model";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@make", make);
            cmd.Parameters.AddWithValue("@model", model);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting car: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserPanel addUserPanel = new AddUserPanel();
            addUserPanel.ShowDialog();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            AddCarPanel addCarPanel = new AddCarPanel();
            addCarPanel.ShowDialog();
        }

        private void modelCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



