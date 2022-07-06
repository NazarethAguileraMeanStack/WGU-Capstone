using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    public static class FormInputValidator
    {
        public static bool checkValidInputString(string customerName) {
            if (customerName == "" || customerName.Length > 45) return false;
            return true;
        }

        public static bool checkCustomerPhoneNumber(string customerPhoneNumber) {
            if (customerPhoneNumber == "" || !customerPhoneNumber.All(char.IsDigit) || customerPhoneNumber.Length > 15 || customerPhoneNumber.Length < 7) return false;
            return true;
        }

        public static bool checkCustomerPostalCode(string customerPostalCode) {
            if (customerPostalCode == "" || customerPostalCode.Length != 5 || !customerPostalCode.All(char.IsDigit)) return false;
            return true;
        }

        public static bool checkValidAppointmentTime(string appointmentStartTime, string appointmentEndTime) {
            if (DateTime.Parse(appointmentStartTime).Hour > 8 && DateTime.Parse(appointmentEndTime).Hour < 18) {
                return true;
            }
            return false;
        }

    }
}
