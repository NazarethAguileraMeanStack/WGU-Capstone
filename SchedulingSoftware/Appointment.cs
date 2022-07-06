using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class Appointment : DateTimeRecord
    {
        private int _appointmentID = -1;
        private int _customerID = -1;
        private int _userID = -1;
        private string _title = "not needed";
        private string _description = "not needed";
        private string _location = "not needed";
        private string _contact = "not needed";
        private string _type = "";
        private string _url = "not needed";
        private string _start = DateTime.Now.ToString();
        private string _end = DateTime.Now.ToString();

        public int AppointmentID {
            get { return _appointmentID; }
            set { _appointmentID = value; }
        }
        public int CustomerID {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public int UserID {
            get { return _userID; }
            set { _userID = value; }
        }
        public string Title {
            get { return _title; }
            set { _title = value; }
        }
        public string Description {
            get { return _description; }
            set { _description = value; }
        }
        public string Location {
            get { return _location; }
            set { _location = value; }
        }
        public string Contact {
            get { return _contact; }
            set { _contact = value; }
        }
        public string Type {
            get { return _type; }
            set { _type = value; }
        }
        public string URL {
            get { return _url; }
            set { _url = value; }
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
