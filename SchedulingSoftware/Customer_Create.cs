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
    public partial class Customer_Create : Form
    {
        public Customer_Create()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            Customer customer = new Customer();
            customer.CustomerName = textBox_name.Text;
            customer.Phone = textBox_phone.Text;
            customer.PostalCode = textBox_postalCode.Text;
            customer.Address = textBox_address.Text;
            customer.Address2 = textBox_address2.Text;
            customer.City = textBox_city.Text;
            customer.Country = textBox_country.Text;
            customer.CreateDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            customer.CreatedBy = DataTrackingService.CurrentUser.UserName;
            customer.LastUpdate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            customer.LastUpdateBy = DataTrackingService.CurrentUser.UserName;

            string begin = "BEGIN;";
            string countryTable = $"INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{customer.Country}', '{customer.CreateDate}', '{customer.CreatedBy}', '{customer.LastUpdate}', '{customer.LastUpdateBy}');";
            string cityTable = $"INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{customer.City}', LAST_INSERT_ID(), '{customer.CreateDate}', '{customer.CreatedBy}', '{customer.LastUpdate}', '{customer.LastUpdateBy}');";
            string addressTable = $"INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{customer.Address}', '{customer.Address2}', LAST_INSERT_ID(), '{customer.PostalCode}', '{customer.Phone}', '{customer.CreateDate}', '{customer.CreatedBy}', '{customer.LastUpdate}', '{customer.LastUpdateBy}');";
            string customerTable = $"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{customer.CustomerName}', LAST_INSERT_ID(), {customer.Active}, '{customer.CreateDate}', '{customer.CreatedBy}', '{customer.LastUpdate}', '{customer.LastUpdateBy}');";
            string commit = "COMMIT;";
            try
            {
                string query = begin + countryTable + cityTable + addressTable + customerTable + commit;
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{customer.CustomerName} has been added to the database.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            this.Hide();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Customer_Create_Load(object sender, EventArgs e)
        {

        }

        private void setColor(TextBox formField, bool isValid)
        {
            if (isValid)
            {
                formField.BackColor = Color.White;
            }
            else
            {
                formField.BackColor = Color.Red;
            }
        }

        private void FormValidator(object sender, EventArgs e) {
            bool name = FormInputValidator.checkValidInputString(textBox_name.Text);
            bool phone = FormInputValidator.checkCustomerPhoneNumber(textBox_phone.Text);
            bool city = FormInputValidator.checkValidInputString(textBox_city.Text);
            bool address = FormInputValidator.checkValidInputString(textBox_address.Text);
            bool address2 = FormInputValidator.checkValidInputString(textBox_address2.Text);
            bool country = FormInputValidator.checkValidInputString(textBox_country.Text);
            bool postalCode = FormInputValidator.checkCustomerPostalCode(textBox_postalCode.Text);

            setColor(textBox_name, name);
            setColor(textBox_phone, phone);
            setColor(textBox_city, city);
            setColor(textBox_address, address);
            setColor(textBox_address2, address2);
            setColor(textBox_country, country);
            setColor(textBox_postalCode, postalCode);

            if (name && phone && city && address && address2 && country && postalCode)
            {
                button_create.Enabled = true;
            }
            else {
                button_create.Enabled = false;
            }
        }


        private void label_title_Click(object sender, EventArgs e)
        {

        }
    }
}
