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
    public partial class AppointmentRecords : Form
    {
        public AppointmentRecords()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AppointmentRecords_Load(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();

            try
            {
                string query = "SELECT appointment.appointmentID, user.userName, customer.customerName, appointment.start, appointment.end, appointment.userId, customer.customerId, appointment.type FROM appointment LEFT JOIN customer ON appointment.customerId=customer.customerId LEFT JOIN user ON user.userId=appointment.userId ORDER BY appointment.start;";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                // this for loop adjusts the time displayed on the datagrid view from universal time to local time.
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                    DateTime startTime = (DateTime)dataSet.Tables[0].Rows[i]["start"];
                    DateTime endTime = (DateTime)dataSet.Tables[0].Rows[i]["end"];
                    dataSet.Tables[0].Rows[i]["start"] = startTime.ToLocalTime();
                    dataSet.Tables[0].Rows[i]["end"] = endTime.ToLocalTime();
                }
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.AutoResizeColumns();
                dataGridView1.Columns["customerId"].Visible = false;
                dataGridView1.Columns["userId"].Visible = false;
                dataGridView1.Columns["type"].Visible = false;
                connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            if (dataGridView1.Rows.Count == 0 || dataGridView1 == null) {
                button_view_details.Enabled = false;
                button_edit.Enabled = false;
                button_delete.Enabled = false;
            }
        }

        private void updateCurrentAppointment(object sender, DataGridViewCellEventArgs e) {
            Appointment appointment = new Appointment();
            appointment.AppointmentID = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            appointment.Start = dataGridView1.SelectedCells[3].Value.ToString();
            appointment.End = dataGridView1.SelectedCells[4].Value.ToString();
            appointment.UserID = Int32.Parse(dataGridView1.SelectedCells[5].Value.ToString());
            appointment.CustomerID = Int32.Parse(dataGridView1.SelectedCells[6].Value.ToString());
            appointment.Type = dataGridView1.SelectedCells[7].Value.ToString();
            DataTrackingService.CurrentAppointment = appointment;

            button_view_details.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Appointment_Create appointmentCreate = new Appointment_Create();
            appointmentCreate.Show();
            this.Close();
        }

        private void button_view_details_Click(object sender, EventArgs e)
        {
            Appointment_View appointmentView = new Appointment_View();
            appointmentView.Show();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Appointment_Edit appointmentEdit = new Appointment_Edit();
            appointmentEdit.Show();
            this.Hide();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DatabaseHandler db = new DatabaseHandler();

                string appointmentTable = $"DELETE FROM appointment WHERE appointment.appointmentId={DataTrackingService.CurrentAppointment.AppointmentID};";
                try
                {
                    string query = appointmentTable;
                    MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show($"Appointment has been removed from the database!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string name = textBox_search.Text;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"customerName LIKE '%{name}%'";
        }

        private void search(object sender, EventArgs e)
        {
            string name = textBox_search.Text;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"customerName LIKE '%{name}%'";
        }
    }
}
