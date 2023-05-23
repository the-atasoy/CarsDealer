using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cars
{
    public partial class AddCarPanel : Form
    {
        public AddCarPanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(DatabaseManager.GetConnectionString());

        private void addCarButton_Click(object sender, EventArgs e)
        {
            string make = makeTextbox.Text;
            string model = modelTextbox.Text;
            string year = yearTextbox.Text;
            string version = versionTextbox.Text;
            string color = colorTextbox.Text;
            string km = kmTextbox.Text;
            string cc = ccTextbox.Text;
            string hp = hpTextbox.Text;
            string price = priceTextbox.Text;

            string query = "INSERT INTO cars (make, model, year, version, color, km, cylinder_capacity, hp, price) " +
                           "VALUES (@make, @model, @year, @version, @color, @km, @cc, @hp, @price)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@make", make);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@version", version);
            cmd.Parameters.AddWithValue("@color", color);
            cmd.Parameters.AddWithValue("@km", km);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@hp", hp);
            cmd.Parameters.AddWithValue("@price", price);

            if (string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(year) ||
        string.IsNullOrEmpty(version) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(km) ||
        string.IsNullOrEmpty(hp) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("All information should be filled.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Car added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearCarForm();
                }
                else
                {
                    MessageBox.Show("Failed to add car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearCarForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding car: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearCarForm()
        {
            makeTextbox.Clear();
            modelTextbox.Clear();
            yearTextbox.Clear();
            versionTextbox.Clear();
            colorTextbox.Clear();
            kmTextbox.Clear();
            ccTextbox.Clear();
            hpTextbox.Clear();
            priceTextbox.Clear();
        }
    }
}
