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
    public partial class Calendar_Month : Form
    {
        public Calendar_Month()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Calendar_Month_Load(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            Appointment appointment = new Appointment();
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddSeconds(-1);

            try
            {
                string query = $"SELECT appointment.appointmentId, appointment.start, appointment.end, user.userName, customer.customerName, appointment.type FROM appointment LEFT JOIN user ON appointment.userId=user.userId LEFT JOIN customer ON appointment.customerId=customer.customerId WHERE (start >= '{firstDayOfMonth.ToString("yyyy-MM-dd HH:mm:ss")}' And end <= '{lastDayOfMonth.ToString("yyyy-MM-dd HH:mm:ss")}') ORDER BY appointment.start;";
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
