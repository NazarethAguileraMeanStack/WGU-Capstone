using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class UserTableReference
    {
        private int _userId = 0;
        private int _userName = 1;
        private int _password = 2;
        private int _active = 3;
        private int _createDate = 4;
        private int _createdBy = 5;
        private int _lastUpdate = 6;
        private int _lastUpdatBy = 7;
        public int UserID {
            get { return _userId; }
        }
        public int UserName {
            get { return _userName; }
        }
        public int Password {
            get { return _password; }
        }
        public int Active {
            get { return _active; }
        }
        public int CreateDate {
            get { return _createDate; }
        }
        public int CreatedBy {
            get { return _createdBy; }
        }
        public int LastUpdate {
            get { return _lastUpdate; }
        }
        public int LastUpdateBy {
            get { return _lastUpdatBy; }
        }
    }
}
