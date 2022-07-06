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
    public partial class Report_ConsultantSchedule : Form
    {
        List<Report_AppointmentItem> appointment = new List<Report_AppointmentItem>();
        public Report_ConsultantSchedule()
        {
            InitializeComponent();
        }

        private void Report_ConsultantSchedule_Load(object sender, EventArgs e)
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

        private void countTotalNumberOfAppointments(string userName) {
            int totalAppointmentsScheduled = appointment.Count;
            label_count.Text = $"{userName} has been scheduled {totalAppointmentsScheduled} appointments.";
        }

        private void getUserSchedule(object sender, DataGridViewCellEventArgs e) {
            try
            {
                int userID = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string userName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                DatabaseHandler db = new DatabaseHandler();
                string query = $"SELECT customer.customerName, appointment.type, appointment.start, appointment.end FROM appointment LEFT JOIN customer ON appointment.customerId=customer.customerId WHERE appointment.userId={userID} ORDER BY start;";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                // this for loop adjusts the time displayed on the datagrid view from universal time to local time.
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    DateTime startTime = (DateTime)dataSet.Tables[0].Rows[i]["start"];
                    DateTime endTime = (DateTime)dataSet.Tables[0].Rows[i]["end"];
                    dataSet.Tables[0].Rows[i]["start"] = startTime.ToLocalTime();
                    dataSet.Tables[0].Rows[i]["end"] = endTime.ToLocalTime();
                }
                appointment.Clear();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Report_AppointmentItem item = new Report_AppointmentItem();
                    item.CustomerName = dataSet.Tables[0].Rows[i]["customerName"].ToString();
                    item.Type = dataSet.Tables[0].Rows[i]["type"].ToString();
                    item.Start = dataSet.Tables[0].Rows[i]["start"].ToString();
                    item.End = dataSet.Tables[0].Rows[i]["end"].ToString();
                    appointment.Add(item);
                }
                dataGridView2.DataSource = dataSet.Tables[0];
                dataGridView2.AutoResizeColumns();
                countTotalNumberOfAppointments(userName);
                label_count.Visible = true;
                connection.Close();

            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
