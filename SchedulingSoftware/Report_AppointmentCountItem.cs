using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class Report_AppointmentCountItem
    {
        private string _date = "";
        private string _type = "";

        public string Date {
            get { return _date; }
            set { _date = value; }
        }

        public string Type {
            get { return _type; }
            set { _type = value; }
        }
    }
}
