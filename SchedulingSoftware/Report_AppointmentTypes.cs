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
    public partial class Report_AppointmentTypes : Form
    {
        List<Report_AppointmentCountItem> appointmentItems = new List<Report_AppointmentCountItem>();
        
        public Report_AppointmentTypes()
        {
            InitializeComponent();
            
        }

        private void Report_AppointmentTypes_Load(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            Appointment appointment = new Appointment();

            try
            {
                string query = "SELECT appointment.start, appointment.type FROM appointment ORDER BY appointment.start;";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Report_AppointmentCountItem item = new Report_AppointmentCountItem();
                    item.Date = dataSet.Tables[0].Rows[i]["start"].ToString();
                    item.Type = dataSet.Tables[0].Rows[i]["type"].ToString();
                    appointmentItems.Add(item);
                }
                dataGridView1.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_january_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInJanuary = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 1 );
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInJanuary)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for January: {uniqueTypes.Count}";
        }

        private void button_february_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInFebruary = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 2);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInFebruary)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for February: {uniqueTypes.Count}";
        }

        private void button_march_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInMarch = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 3);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInMarch)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for March: {uniqueTypes.Count}";
        }

        private void button_april_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInApril = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 4);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInApril)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for April: {uniqueTypes.Count}";
        }

        private void button_may_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInMay = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 5);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInMay) {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for May: {uniqueTypes.Count}";
        }

        private void button_june_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInJune = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 6);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInJune)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for June: {uniqueTypes.Count}";
        }

        private void button_july_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInJuly = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 7);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInJuly)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for July: {uniqueTypes.Count}";
        }

        private void button_august_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInAugust = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 8);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInAugust)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for August: {uniqueTypes.Count}";
        }

        private void button_september_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInSeptember = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 9);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInSeptember)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for September: {uniqueTypes.Count}";
        }

        private void button_october_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInOctober = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 10);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInOctober)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for October: {uniqueTypes.Count}";
        }

        private void button_november_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInNovember = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 11);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInNovember)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for November: {uniqueTypes.Count}";
        }

        private void button_december_Click(object sender, EventArgs e)
        {
            // this lambda expression simplifies my code from iterating through appointmentItems list, casting each date to a DateTime object, and returning if it is the correct month, into a single statement.
            var typesInDecember = appointmentItems.Where(item => DateTime.Parse(item.Date).Month == 12);
            var uniqueTypes = new HashSet<string>();
            foreach (var item in typesInDecember)
            {
                uniqueTypes.Add(item.Type);
            }
            label_count.Visible = true;
            label_count.Text = $"Number of different types of appointments for December: {uniqueTypes.Count}";
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
