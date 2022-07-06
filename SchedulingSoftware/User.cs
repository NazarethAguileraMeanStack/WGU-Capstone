using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class User : DateTimeRecord
    {
        private int _userId = -1;
        private string _userName = "";
        private string _password = "";
        private int _active = -1;
        public int UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int Active
        {
            get { return _active; }
            set { _active = value; }
        }
        
    }
}
