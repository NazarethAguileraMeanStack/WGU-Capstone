using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    abstract class LoginRecord : DateTimeRecord
    {
        abstract public string logToFile();
    }
}
