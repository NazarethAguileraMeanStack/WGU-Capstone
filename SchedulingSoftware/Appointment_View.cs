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
    public partial class Appointment_View : Form
    {
        public Appointment_View()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox_user_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Appointment_View_Load(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();

            try
            {
                int customerID = DataTrackingService.CurrentAppointment.CustomerID;
                string query = $"SELECT customer.customerId, customer.customerName, address.phone, city.city, country.country FROM customer LEFT JOIN address ON customer.addressId=address.addressId LEFT JOIN city ON address.cityId=city.cityId LEFT JOIN country ON city.countryId=country.countryId WHERE customer.customerId={customerID};";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.AutoResizeColumns();

                connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            try
            {
                int userID = DataTrackingService.CurrentAppointment.UserID;
                string query = $"SELECT user.userId, user.userName FROM user WHERE user.userId={userID};";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
                dataGridView2.AutoResizeColumns();
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

        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
