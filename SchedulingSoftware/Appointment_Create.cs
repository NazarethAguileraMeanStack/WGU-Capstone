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
    public partial class Appointment_Create : Form
    {
        public Appointment_Create()
        {
            InitializeComponent();
        }

        private bool isTimeslotAlreadyTaken() {
            // Check For Appointment

            DatabaseHandler db = new DatabaseHandler();
            string startRange = dateTimePicker_startDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string endRange = dateTimePicker_endDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            int userID = Int32.Parse(textBox_user_id.Text);

            try
            {
                string query = $"SELECT appointment.userId, appointment.start, appointment.end FROM appointment WHERE (appointment.userId={userID} AND (appointment.start >= '{startRange}' AND appointment.start <= '{endRange}')) OR (appointment.userId={userID} AND (appointment.end >= '{startRange}' AND appointment.end <= '{endRange}'));";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                connection.Close();

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("That time slot is already taken!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return false;
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            if (isTimeslotAlreadyTaken()) {
                button_create.Enabled = false;
                return;
            }
            
            DatabaseHandler db = new DatabaseHandler();
            Appointment appointment = new Appointment();
            appointment.CustomerID = Int32.Parse(textBox_customer_id.Text);
            appointment.UserID = Int32.Parse(textBox_user_id.Text);
            appointment.Type = textBox_type.Text;
            appointment.Start = dateTimePicker_startDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            appointment.End = dateTimePicker_endDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            appointment.CreateDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            appointment.CreatedBy = DataTrackingService.CurrentUser.UserName;
            appointment.LastUpdate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            appointment.LastUpdateBy = DataTrackingService.CurrentUser.UserName;


            string appointmentTable = $"INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ({appointment.CustomerID}, {appointment.UserID}, '{appointment.Title}', '{appointment.Description}', '{appointment.Location}', '{appointment.Contact}', '{appointment.Type}', '{appointment.URL}', '{appointment.Start}', '{appointment.End}', '{appointment.CreateDate}', '{appointment.CreatedBy}', '{appointment.LastUpdate}', '{appointment.LastUpdateBy}');";
            
            try
            {
                string query = appointmentTable;
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("New appointment has been added to the database.");
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

        private void Appointment_Create_Load(object sender, EventArgs e)
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
                dataGridView1.Columns["phone"].Visible = false;
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
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            try
            {
                string query = "SELECT user.userId, user.userName FROM user;";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void updateSelectedUser(object sender, DataGridViewCellEventArgs e) {
            string selectedUserID = dataGridView2.SelectedCells[0].Value.ToString();
            textBox_user_id.Text = selectedUserID;
            checkValidForm();
        }

        private void updateSelectedCustomer(object sender, DataGridViewCellEventArgs e) {
            string selectedCustomerID = dataGridView1.SelectedCells[0].Value.ToString();
            textBox_customer_id.Text = selectedCustomerID;
            checkValidForm();
        }

        private void validAppointmentType(object sender, EventArgs e) {
            if (textBox_type.Text == "")
            {
                textBox_type.BackColor = Color.Red;
            }
            else {
                textBox_type.BackColor = Color.White;
            }

            checkValidForm();
        }

        private void checkValidForm() {
            bool user = FormInputValidator.checkValidInputString(textBox_user_id.Text);
            bool customer = FormInputValidator.checkValidInputString(textBox_customer_id.Text);
            string start = dateTimePicker_startDate.Value.ToString();
            string end = dateTimePicker_endDate.Value.ToString();
            bool validAppoiment = FormInputValidator.checkValidAppointmentTime(start, end);
            bool type = FormInputValidator.checkValidInputString(textBox_type.Text);

            if (user && customer && validAppoiment && type)
            {
                button_create.Enabled = true;
            }
            else {
                button_create.Enabled = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_endDate.Value = dateTimePicker_startDate.Value.AddMinutes(30);
            checkValidForm();
        }

        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            checkValidForm();
        }
    }
}
