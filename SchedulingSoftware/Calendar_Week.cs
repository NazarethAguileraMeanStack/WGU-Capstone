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
    public partial class Calendar_Week : Form
    {
        public Calendar_Week()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Calendar_Week_Load(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            Appointment appointment = new Appointment();

            int today = (int)DateTime.Now.DayOfWeek;
            int difference = (int)DateTime.Now.DayOfWeek * -1;
            DateTime firstOfWeek = DateTime.Now.AddDays(difference);
            DateTime lastOfWeek = firstOfWeek.AddDays(6);

            try
            {
                string query = $"SELECT appointment.appointmentId, appointment.start, appointment.end, user.userName, customer.customerName, appointment.type FROM appointment LEFT JOIN user ON appointment.userId=user.userId LEFT JOIN customer ON appointment.customerId=customer.customerId WHERE (start >= '{firstOfWeek.ToString("yyyy-MM-dd HH:mm:ss")}' And end <= '{lastOfWeek.ToString("yyyy-MM-dd HH:mm:ss")}') ORDER BY appointment.start";
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
