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
    public partial class AddCarPanel : Form
    {
        public AddCarPanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7B11AB0;Initial Catalog=cars.com;Integrated Security=True");

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void priceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kmTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hpTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ccTextbox_TextChanged(object sender, EventArgs e)
        {
            ccTextbox.Text = string.Empty;
        }

        private void versionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void makeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void ccTextbox_Enter(object sender, EventArgs e)
        {
            if (ccTextbox.Text == "Enter Cylinder Capacity")
            {
                ccTextbox.Text = "";
                ccTextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ccTextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ccTextbox.Text))
            {
                ccTextbox.Text = "Enter Cylinder Capacity";
                ccTextbox.ForeColor = SystemColors.GrayText;
            }
        }

        private void AddCarPanel_Load(object sender, EventArgs e)
        {
            ccTextbox_Enter(sender, e);
            ccTextbox_Leave(sender, e);
        }
    }
}
