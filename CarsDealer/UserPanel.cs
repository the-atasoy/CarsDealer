using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarsDealer
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
            this.FormClosing += UserPanel_FormClosing;
        }

        SqlConnection conn = new SqlConnection(DatabaseManager.GetConnectionString());

        private void UserPanel_Load(object sender, EventArgs e)
        {
            LoadMakes();
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

                carsTable.Columns["make"].Width = 100;
                carsTable.Columns["model"].Width = 100;
                carsTable.Columns["year"].Width = 60;
                carsTable.Columns["version"].Width = 100;
                carsTable.Columns["color"].Width = 80;
                carsTable.Columns["km"].Width = 80;
                carsTable.Columns["cylinder_capacity"].Width = 100;
                carsTable.Columns["hp"].Width = 80;
                carsTable.Columns["price"].Width = 80;

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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Hide();
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
