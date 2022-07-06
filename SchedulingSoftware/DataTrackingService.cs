using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    static class DataTrackingService
    {
        private static User _currentUser;
        private static Customer _currentCustomer;
        private static Appointment _currentAppointment;

        public static User CurrentUser {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public static Customer CurrentCustomer {
            get { return _currentCustomer; }
            set { _currentCustomer = value; }
        }

        public static Appointment CurrentAppointment {
            get { return _currentAppointment; }
            set { _currentAppointment = value; }
        }
    }
}
