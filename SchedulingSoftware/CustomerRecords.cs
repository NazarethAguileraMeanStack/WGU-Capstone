using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class CustomerRecords : Form
    {
        public CustomerRecords()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateCurrentCustomer();
            button_view_customer_details.Enabled = true;
            button_edit_customer.Enabled = true;
            button_delete_customer.Enabled = true;
        }

        private void updateCurrentCustomer() {
            Customer customer = new Customer();
            customer.CustomerID = validateCustomerID();
            customer.CustomerName = validateCustomerName();
            customer.AddressID = validateAddressID();
            customer.Address = validateAddress();
            customer.Address2 = validateAddress2();
            customer.CityID = validateCityID();
            customer.City = validateCity();
            customer.CountryID = validateCountryID();
            customer.Country = validateCountry();
            customer.PostalCode = validatePostalCode();
            customer.Phone = validatePhone();
            DataTrackingService.CurrentCustomer = customer;
        }

        private int validateCustomerID() {
            var targetCellValue = dataGridView1.SelectedCells[0].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString())) {
                return -1;
            }
            return Int32.Parse(targetCellValue.ToString());
        }

        private string validateCustomerName() {
            var targetCellValue = dataGridView1.SelectedCells[1].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return "NULL";
            }
            return targetCellValue.ToString();
        }

        private int validateAddressID()
        {
            var targetCellValue = dataGridView1.SelectedCells[2].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return -1;
            }
            return Int32.Parse(targetCellValue.ToString());
        }

        private string validateAddress()
        {
            var targetCellValue = dataGridView1.SelectedCells[3].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return "NULL";
            }
            return targetCellValue.ToString();
        }

        private string validateAddress2()
        {
            var targetCellValue = dataGridView1.SelectedCells[4].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return "NULL";
            }
            return targetCellValue.ToString();
        }

        private int validateCityID()
        {
            var targetCellValue = dataGridView1.SelectedCells[5].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return -1;
            }
            return Int32.Parse(targetCellValue.ToString());
        }

        private string validateCity()
        {
            var targetCellValue = dataGridView1.SelectedCells[6].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return "NULL";
            }
            return targetCellValue.ToString();
        }

        private int validateCountryID()
        {
            var targetCellValue = dataGridView1.SelectedCells[7].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return -1;
            }
            return Int32.Parse(targetCellValue.ToString());
        }

        private string validateCountry()
        {
            var targetCellValue = dataGridView1.SelectedCells[8].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return "NULL";
            }
            return targetCellValue.ToString();
        }

        private string validatePostalCode()
        {
            var targetCellValue = dataGridView1.SelectedCells[9].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return "NULL";
            }
            return targetCellValue.ToString();
        }

        private string validatePhone()
        {
            var targetCellValue = dataGridView1.SelectedCells[10].Value;
            if (targetCellValue == null ||
                targetCellValue == DBNull.Value ||
                String.IsNullOrEmpty(targetCellValue.ToString()))
            {
                return "NULL";
            }
            return targetCellValue.ToString();
        }

        


        private void CustomerRecords_Load(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();

            try
            {
                string query = "SELECT customer.customerId, customer.customerName, address.addressId, address.address, address.address2, city.cityId, city.city, country.countryID, country.country, address.postalCode, address.phone FROM customer LEFT JOIN address ON customer.addressId=address.addressId LEFT JOIN city ON address.cityId=city.cityId LEFT JOIN country ON city.countryId=country.countryId;";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.Columns["addressId"].Visible = false;
                dataGridView1.Columns["cityId"].Visible = false;
                dataGridView1.Columns["countryId"].Visible = false;
                dataGridView1.Columns["address"].Visible = false;
                dataGridView1.Columns["address2"].Visible = false;
                dataGridView1.Columns["city"].Visible = false;
                dataGridView1.Columns["country"].Visible = false;
                dataGridView1.Columns["postalCode"].Visible = false;
                
                connection.Close();     

            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }

            if (dataGridView1.Rows.Count == 0 || dataGridView1 == null) {
                button_view_customer_details.Enabled = false;
                button_edit_customer.Enabled = false;
                button_delete_customer.Enabled = false;
            }
        }

        private void button_create_customer_Click(object sender, EventArgs e)
        {
            Customer_Create customerCreate = new Customer_Create();
            customerCreate.Show();
            this.Hide();
        }

        private void button_view_customer_details_Click(object sender, EventArgs e)
        {
            Customer_View customerView = new Customer_View();
            customerView.Show();
        }

        private void button_edit_customer_Click(object sender, EventArgs e)
        {
            Customer_Edit customerEdit = new Customer_Edit();
            customerEdit.Show();
            this.Hide();
        }

        private void button_delete_customer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {DataTrackingService.CurrentCustomer.CustomerName}? This will also delete all appointments regarding this user.", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DatabaseHandler db = new DatabaseHandler();

                string appointmentTable = $"DELETE FROM appointment WHERE appointment.customerId={DataTrackingService.CurrentCustomer.CustomerID};";
                try
                {
                    string query = appointmentTable;
                    MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show($"All appointments involving {DataTrackingService.CurrentCustomer.CustomerName} have been removed from the database!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                //string begin = "BEGIN;";
                string countryTable = $"DELETE FROM country WHERE country.countryId={DataTrackingService.CurrentCustomer.CountryID};";
                string cityTable = $"DELETE FROM city WHERE city.cityId={DataTrackingService.CurrentCustomer.CityID};";
                string addressTable = $"DELETE FROM address WHERE address.addressId={DataTrackingService.CurrentCustomer.AddressID};";
                string customerTable = $"DELETE FROM customer WHERE customer.customerId={DataTrackingService.CurrentCustomer.CustomerID};";
                //string commit = "COMMIT;";
                try
                {

                    //string query = begin + countryTable + cityTable + addressTable + customerTable + commit;
                    
                    MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(customerTable, connection);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand(addressTable, connection);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand(cityTable, connection);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand(countryTable, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show($"{DataTrackingService.CurrentCustomer.CustomerName} has been removed from the database!");
                    //throw new Exception("testing exception");
                   

                }
                catch (Exception error)
                {
                    MessageBox.Show("There was an issue processing your request. This page will now close. If the selected customer has not been deleted, please try again.");
                    this.Close();
                }
                this.Close();
            }
            
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string name = textBox_search.Text;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"customerName LIKE '%{name}%'";
        }

        private void search(object sender, EventArgs e) {
            string name = textBox_search.Text;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"customerName LIKE '%{name}%'";
        }
    }
}
