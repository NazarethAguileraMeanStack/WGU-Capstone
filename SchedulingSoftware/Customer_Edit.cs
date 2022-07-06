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
    public partial class Customer_Edit : Form
    {
        public Customer_Edit()
        {
            InitializeComponent();
        }

        private void Customer_Edit_Load(object sender, EventArgs e)
        {
            textBox_name.Text = DataTrackingService.CurrentCustomer.CustomerName;
            textBox_phone.Text = DataTrackingService.CurrentCustomer.Phone;
            textBox_city.Text = DataTrackingService.CurrentCustomer.City;
            textBox_address.Text = DataTrackingService.CurrentCustomer.Address;
            textBox_address2.Text = DataTrackingService.CurrentCustomer.Address2;
            textBox_country.Text = DataTrackingService.CurrentCustomer.Country;
            textBox_postalCode.Text = DataTrackingService.CurrentCustomer.PostalCode;
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

        private void FormValidator(object sender, EventArgs e)
        {
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
                button_save.Enabled = true;
            }
            else
            {
                button_save.Enabled = false;
            }
        }
        

        private void button_save_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            DataTrackingService.CurrentCustomer.CustomerName = textBox_name.Text;
            DataTrackingService.CurrentCustomer.Phone = textBox_phone.Text;
            DataTrackingService.CurrentCustomer.PostalCode = textBox_postalCode.Text;
            DataTrackingService.CurrentCustomer.Address = textBox_address.Text;
            DataTrackingService.CurrentCustomer.Address2 = textBox_address2.Text;
            DataTrackingService.CurrentCustomer.City = textBox_city.Text;
            DataTrackingService.CurrentCustomer.Country = textBox_country.Text;
            DataTrackingService.CurrentCustomer.LastUpdate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            DataTrackingService.CurrentCustomer.LastUpdateBy = DataTrackingService.CurrentUser.UserName;

            string begin = "BEGIN;";
            string countryTable = $"UPDATE country SET country='{DataTrackingService.CurrentCustomer.Country}', lastUpdate='{DataTrackingService.CurrentCustomer.LastUpdate}', lastUpdateBy='{DataTrackingService.CurrentCustomer.LastUpdateBy}' WHERE countryId={DataTrackingService.CurrentCustomer.CountryID};";
            string cityTable = $"UPDATE city SET city='{DataTrackingService.CurrentCustomer.City}', lastUpdate='{DataTrackingService.CurrentCustomer.LastUpdate}', lastUpdateBy='{DataTrackingService.CurrentCustomer.LastUpdateBy}' WHERE cityId={DataTrackingService.CurrentCustomer.CityID};";
            string addressTable = $"UPDATE address SET address='{DataTrackingService.CurrentCustomer.Address}', address2='{DataTrackingService.CurrentCustomer.Address2}', postalCode='{DataTrackingService.CurrentCustomer.PostalCode}', phone='{DataTrackingService.CurrentCustomer.Phone}', lastUpdate='{DataTrackingService.CurrentCustomer.LastUpdate}', lastUpdateBy='{DataTrackingService.CurrentCustomer.LastUpdateBy}' WHERE addressId={DataTrackingService.CurrentCustomer.AddressID};";
            string customerTable = $"UPDATE customer SET customerName='{DataTrackingService.CurrentCustomer.CustomerName}', lastUpdate='{DataTrackingService.CurrentCustomer.LastUpdate}', lastUpdateBy='{DataTrackingService.CurrentCustomer.LastUpdateBy}' WHERE customerId={DataTrackingService.CurrentCustomer.CustomerID};";
            string commit = "COMMIT;";
            try
            {
                string query = begin + countryTable + cityTable + addressTable + customerTable + commit;
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{DataTrackingService.CurrentCustomer.CustomerName} has been updated!.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
