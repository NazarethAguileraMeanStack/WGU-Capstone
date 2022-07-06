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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            

        }

        private void closeDashboard(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string currentUserName = DataTrackingService.CurrentUser.UserName;
            label_welcome_user.Text = $"Hello {currentUserName}";

            DatabaseHandler db = new DatabaseHandler();
            Appointment appointment = new Appointment();

            // Check For Appointment
            
            DateTime startRange = DateTime.Now;
            DateTime endRange = startRange.AddMinutes(15);

            try
            {
                //string query = $"SELECT * FROM appointment WHERE (start >= '{startRange.ToString("yyyy-MM-dd HH:mm:ss")}' AND end <= '{endRange.ToString("yyyy-MM-dd HH:mm:ss")}');";
                string query = $"SELECT appointment.start, customer.customerName FROM appointment LEFT JOIN customer ON appointment.customerid=customer.customerId WHERE (appointment.userId ='{DataTrackingService.CurrentUser.UserID}' AND appointment.start >= '{startRange.ToString("yyyy-MM-dd HH:mm:ss")}' AND appointment.start <= '{endRange.ToString("yyyy-MM-dd HH:mm:ss")}');";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();

                if (dataGridView1.Rows.Count > 1)
                {
                    DateTime appointmentStart = DateTime.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                    string customerName = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    label_alert.Text = $"REMINDER: You have an upcoming appointment with {customerName} at {appointmentStart.ToString("HH:mm tt")}!";
                }
                else {
                    label_alert.Text = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            CustomerRecords customerRecords = new CustomerRecords();
            customerRecords.Show();
        }

        private void button_appointments_Click(object sender, EventArgs e)
        {
            AppointmentRecords appointmentRecords = new AppointmentRecords();
            appointmentRecords.Show();
        }

        private void button_calendar_Click(object sender, EventArgs e)
        {
            CalendarViews calendarViews = new CalendarViews();
            calendarViews.Show();
        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
