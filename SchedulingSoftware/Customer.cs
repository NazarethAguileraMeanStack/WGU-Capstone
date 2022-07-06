using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class Customer : DateTimeRecord
    {
        private int _customerID = -1;
        private string _customerName = "";
        private int _addressID = -1;
        private string _address = "";
        private string _address2 = "";
        private int _cityID = -1;
        private string _city = "";
        private int _countryID = -1;
        private string _country = "";
        private string _postalCode = "";
        private string _phone = "";
        private int _active = 1;


        public int CustomerID {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public string CustomerName {
            get { return _customerName; }
            set { _customerName = value; }
        }
        public int AddressID { 
            get { return _addressID; }
            set { _addressID = value; }
        }
        public string Address {
            get { return _address; }
            set { _address = value; }
        }
        public string Address2 {
            get { return _address2; }
            set { _address2 = value; }
        }
        public int CityID {
            get { return _cityID; }
            set { _cityID = value; }
        }
        public string City {
            get { return _city; }
            set { _city = value; }
        }
        public int CountryID {
            get { return _countryID; }
            set { _countryID = value; }
        }
        public string Country {
            get { return _country; }
            set { _country = value; }
        }
        public string PostalCode {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        public string Phone {
            get { return _phone; }
            set { _phone = value; }
        }
        public int Active {
            get { return _active; }
            set { _active = value; }
        }

    }
}
