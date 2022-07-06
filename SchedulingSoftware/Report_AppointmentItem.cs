using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class Report_AppointmentItem
    {
        private string _customerName = "";
        private string _type;
        private string _start = "";
        private string _end = "";

        public string CustomerName {
            get { return _customerName; }
            set { _customerName = value; }
        }
        public string Type {
            get { return _type; }
            set { _type = value; }
        }

        public string Start {
            get { return _start; }
            set { _start = value; }
        }
        public string End {
            get { return _end; }
            set { _end = value; }
        }
    }
}
