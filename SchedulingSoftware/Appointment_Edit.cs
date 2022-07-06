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
    public partial class Appointment_Edit : Form
    {
        public Appointment_Edit()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Appointment_Edit_Load(object sender, EventArgs e)
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

            textBox_user_id.Text = DataTrackingService.CurrentAppointment.UserID.ToString();
            textBox_customer_id.Text = DataTrackingService.CurrentAppointment.CustomerID.ToString();
            textBox_type.Text = DataTrackingService.CurrentAppointment.Type;
            dateTimePicker_startDate.Value = DateTime.Parse(DataTrackingService.CurrentAppointment.Start);
            dateTimePicker_endDate.Value = DateTime.Parse(DataTrackingService.CurrentAppointment.End);
            checkFormIsValid();
        }

        private void checkFormIsValid() {
            bool user = (textBox_user_id.Text != "") ? true : false;
            bool customer = (textBox_customer_id.Text != "") ? true : false;
            string start = dateTimePicker_startDate.Value.ToString();
            string end = dateTimePicker_endDate.Value.ToString();
            bool validAppoiment = (DateTime.Parse(start).Hour > 8 && DateTime.Parse(end).Hour < 18) ? true : false;
            bool type = (textBox_type.Text != "") ? true : false;

            if (user && customer && validAppoiment && type)
            {
                button_save.Enabled = true;
            }
            else
            {
                button_save.Enabled = false;
            }
        }

        private void updateSelectedUser(object sender, DataGridViewCellEventArgs e) {
            textBox_user_id.Text = dataGridView2.SelectedCells[0].Value.ToString();
            checkFormIsValid();
        }

        private void updateSelectedCustomer(object sender, DataGridViewCellEventArgs e) {
            textBox_customer_id.Text = dataGridView1.SelectedCells[0].Value.ToString();
            checkFormIsValid();
        }

        private void updateEndTime() {
            dateTimePicker_endDate.Value = dateTimePicker_startDate.Value.AddMinutes(30);
            checkFormIsValid();
        }

        private void updateAppointmentType() {
            if (textBox_type.Text == "")
            {
                textBox_type.BackColor = Color.Red;
                checkFormIsValid();
            }
            else {
                textBox_type.BackColor = Color.White;
                checkFormIsValid();
            }
        }



        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            updateEndTime();
        }

        private void textBox_type_TextChanged(object sender, EventArgs e)
        {
            updateAppointmentType();
        }

        private bool isTimeslotAlreadyTaken()
        {
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

        private void button_save_Click_1(object sender, EventArgs e)
        {
            if (isTimeslotAlreadyTaken())
            {
                button_save.Enabled = false;
                return;
            }

            DatabaseHandler db = new DatabaseHandler();
            DataTrackingService.CurrentAppointment.UserID = Int32.Parse(textBox_user_id.Text);
            DataTrackingService.CurrentAppointment.CustomerID = Int32.Parse(textBox_customer_id.Text);
            DataTrackingService.CurrentAppointment.Type = textBox_type.Text;
            DataTrackingService.CurrentAppointment.Start = dateTimePicker_startDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            DataTrackingService.CurrentAppointment.End = dateTimePicker_endDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            DataTrackingService.CurrentAppointment.LastUpdate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            DataTrackingService.CurrentAppointment.LastUpdateBy = DataTrackingService.CurrentUser.UserName;
            string appointmentTable = $"UPDATE appointment SET customerId={DataTrackingService.CurrentAppointment.CustomerID}, userId={DataTrackingService.CurrentAppointment.UserID}, type='{DataTrackingService.CurrentAppointment.Type}', start='{DataTrackingService.CurrentAppointment.Start}', end='{DataTrackingService.CurrentAppointment.End}', lastUpdate='{DataTrackingService.CurrentAppointment.LastUpdate}', lastUpdateBy='{DataTrackingService.CurrentAppointment.LastUpdateBy}' WHERE appointmentId={DataTrackingService.CurrentAppointment.AppointmentID};";
            
            try
            {
                string query = appointmentTable;
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Appointment has been updated!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            this.Close();
        }
    }
}
