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
    public partial class CalendarViews : Form
    {
        public CalendarViews()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_view_all_appointments_Click(object sender, EventArgs e)
        {
            Calendar_All calendarAll = new Calendar_All();
            calendarAll.Show();
        }

        private void button_view_week_appointments_Click(object sender, EventArgs e)
        {
            Calendar_Week calendarWeek = new Calendar_Week();
            calendarWeek.Show();
        }

        private void button_month_appointment_Click(object sender, EventArgs e)
        {
            Calendar_Month calendarMonth = new Calendar_Month();
            calendarMonth.Show();
        }
    }
}
