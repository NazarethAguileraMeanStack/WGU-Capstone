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
    public partial class Report_AppointmentStatistics : Form
    {
        List<Report_AppointmentItem> appointments = new List<Report_AppointmentItem>();
        string userName = "";
        public Report_AppointmentStatistics()
        {
            InitializeComponent();
        }

        private void calcPercentOfAppointmentsOnSunday(int numOfTotalAppointments) {
            // this lambda expression simplifies my code from iterating through appointments list, casting each date to a DateTime object reprensenting a day of the week, and returning if it is the correct day of week, into a single statement.
            var appointmentsOnSunday = appointments.Where(item => DateTime.Parse(item.Start).DayOfWeek == DayOfWeek.Sunday);
            double percent = ((double)appointmentsOnSunday.ToList().Count / numOfTotalAppointments) * 100;
            if (Double.IsNaN(percent))
            {
                label_sunday.Text = "0.00% of appointments are on Sunday.";
            }
            else 
            {
                label_sunday.Text = $"{String.Format("{0:0.00}", percent)}% of appointments are on Sunday.";
            }
            
        }
        private void calcPercentOfAppointmentsOnMonday(int numOfTotalAppointments)
        {
            // this lambda expression simplifies my code from iterating through appointments list, casting each date to a DateTime object reprensenting a day of the week, and returning if it is the correct day of week, into a single statement.
            var appointmentsOnMonday = appointments.Where(item => DateTime.Parse(item.Start).DayOfWeek == DayOfWeek.Monday);
            double percent = ((double)appointmentsOnMonday.ToList().Count / numOfTotalAppointments) * 100;
            if (Double.IsNaN(percent))
            {
                label_monday.Text = "0.00% of appointments are on Monday.";
            }
            else
            {
                label_monday.Text = $"{String.Format("{0:0.00}", percent)}% of appointments are on Monday.";
            }
            
        }

        private void calcPercentOfAppointmentsOnTuesday(int numOfTotalAppointments)
        {
            // this lambda expression simplifies my code from iterating through appointments list, casting each date to a DateTime object reprensenting a day of the week, and returning if it is the correct day of week, into a single statement.
            var appointmentsOnTuesday = appointments.Where(item => DateTime.Parse(item.Start).DayOfWeek == DayOfWeek.Tuesday);
            double percent = ((double)appointmentsOnTuesday.ToList().Count / numOfTotalAppointments) * 100;
            if (Double.IsNaN(percent))
            {
                label_tuesday.Text = "0.00% of appointments are on Tuesday.";
            }
            else
            {
                label_tuesday.Text = $"{String.Format("{0:0.00}", percent)}% of appointments are on Tuesday.";
            }
            
        }

        private void calcPercentOfAppointmentsOnWednesday(int numOfTotalAppointments)
        {
            // this lambda expression simplifies my code from iterating through appointments list, casting each date to a DateTime object reprensenting a day of the week, and returning if it is the correct day of week, into a single statement.
            var appointmentsOnWednesday = appointments.Where(item => DateTime.Parse(item.Start).DayOfWeek == DayOfWeek.Wednesday);
            double percent = ((double)appointmentsOnWednesday.ToList().Count / numOfTotalAppointments) * 100;
            if (Double.IsNaN(percent))
            {
                label_wednesday.Text = "0.00% of appointments are on Wednesday.";
            }
            else
            {
                label_wednesday.Text = $"{String.Format("{0:0.00}", percent)}% of appointments are on Wednesday.";
            }
            
        }

        private void calcPercentOfAppointmentsOnThursday(int numOfTotalAppointments)
        {
            // this lambda expression simplifies my code from iterating through appointments list, casting each date to a DateTime object reprensenting a day of the week, and returning if it is the correct day of week, into a single statement.
            var appointmentsOnThursday = appointments.Where(item => DateTime.Parse(item.Start).DayOfWeek == DayOfWeek.Thursday);
            double percent = ((double)appointmentsOnThursday.ToList().Count / numOfTotalAppointments) * 100;
            if (Double.IsNaN(percent))
            {
                label_thursday.Text = "0.00% of appointments are on Thursday.";
            }
            else
            {
                label_thursday.Text = $"{String.Format("{0:0.00}", percent)}% of appointments are on Thursday.";
            }
            
        }

        private void calcPercentOfAppointmentsOnFriday(int numOfTotalAppointments)
        {
            // this lambda expression simplifies my code from iterating through appointments list, casting each date to a DateTime object reprensenting a day of the week, and returning if it is the correct day of week, into a single statement.
            var appointmentsOnFriday = appointments.Where(item => DateTime.Parse(item.Start).DayOfWeek == DayOfWeek.Friday);
            double percent = ((double)appointmentsOnFriday.ToList().Count / numOfTotalAppointments) * 100;
            if (Double.IsNaN(percent))
            {
                label_friday.Text = "0.00% of appointments are on Friday.";
            }
            else
            {
                label_friday.Text = $"{String.Format("{0:0.00}", percent)}% of appointments are on Friday.";
            }
            
        }

        private void calcPercentOfAppointmentsOnSaturday(int numOfTotalAppointments)
        {
            // this lambda expression simplifies my code from iterating through appointments list, casting each date to a DateTime object reprensenting a day of the week, and returning if it is the correct day of week, into a single statement.
            var appointmentsOnSaturday = appointments.Where(item => DateTime.Parse(item.Start).DayOfWeek == DayOfWeek.Saturday);
            double percent = ((double)appointmentsOnSaturday.ToList().Count / numOfTotalAppointments) * 100;
            if (Double.IsNaN(percent))
            {
                label_saturday.Text = "0.00% of appointments are on Saturday.";
            }
            else
            {
                label_saturday.Text = $"{String.Format("{0:0.00}", percent)}% of appointments are on Saturday.";
            }
         
        }

        private void loadUserSchedule(object sender, DataGridViewCellEventArgs e) {
            try
            {
                int userID = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                userName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                DatabaseHandler db = new DatabaseHandler();
                string query = $"SELECT appointment.start FROM appointment WHERE appointment.userId={userID} ORDER BY start;";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                appointments.Clear();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Report_AppointmentItem item = new Report_AppointmentItem();
                    item.Start = dataSet.Tables[0].Rows[i]["start"].ToString();
                    appointments.Add(item);
                }
                calcPercentOfAppointmentsOnSunday(dataSet.Tables[0].Rows.Count);
                calcPercentOfAppointmentsOnMonday(dataSet.Tables[0].Rows.Count);
                calcPercentOfAppointmentsOnTuesday(dataSet.Tables[0].Rows.Count);
                calcPercentOfAppointmentsOnWednesday(dataSet.Tables[0].Rows.Count);
                calcPercentOfAppointmentsOnThursday(dataSet.Tables[0].Rows.Count);
                calcPercentOfAppointmentsOnFriday(dataSet.Tables[0].Rows.Count);
                calcPercentOfAppointmentsOnSaturday(dataSet.Tables[0].Rows.Count);
                dataGridView2.DataSource = dataSet.Tables[0];
                dataGridView2.AutoResizeColumns();
                connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Report_AppointmentStatistics_Load(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();

            try
            {
                string query = "SELECT user.userId, user.userName FROM user;";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.AutoResizeColumns();
                dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
