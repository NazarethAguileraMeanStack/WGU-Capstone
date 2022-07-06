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
    public partial class Calendar_All : Form
    {
        public Calendar_All()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Calendar_All_Load(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            Appointment appointment = new Appointment();

            try
            {
                string query = "SELECT appointment.appointmentID, appointment.start, appointment.end, user.userName, customer.customerName, appointment.type FROM appointment LEFT JOIN customer ON appointment.customerId=customer.customerId LEFT JOIN user ON user.userId=appointment.userId ORDER BY appointment.start;";
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
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.AutoResizeColumns();
                connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
