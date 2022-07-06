using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    abstract class DateTimeRecord
    {
        private string _createDate = DateTime.Now.ToString();
        private string _createdBy = "";
        private string _lastUpdate = DateTime.Now.ToString();
        private string _lastUpdateBy = "";

        public string CreateDate {
            get { return _createDate; }
            set { _createDate = value; }
        }

        public string CreatedBy {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string LastUpdate {
            get { return _lastUpdate; }
            set { _lastUpdate = value; }
        }

        public string LastUpdateBy {
            get { return _lastUpdateBy; }
            set { _lastUpdateBy = value; }
        }
    }
}
