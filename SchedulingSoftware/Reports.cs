using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_appointment_types_Click(object sender, EventArgs e)
        {
            Report_AppointmentTypes appointmentTypes = new Report_AppointmentTypes();
            appointmentTypes.Show();
        }

        private void button_consultant_schedule_Click(object sender, EventArgs e)
        {
            Report_ConsultantSchedule consultantSchedule = new Report_ConsultantSchedule();
            consultantSchedule.Show();
        }

        private void button_appointment_statistics_Click(object sender, EventArgs e)
        {
            Report_AppointmentStatistics appointmentStatistics = new Report_AppointmentStatistics();
            appointmentStatistics.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
