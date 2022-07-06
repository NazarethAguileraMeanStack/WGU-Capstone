using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class LoginRecordSuccess : LoginRecord
    {
        public override string logToFile() 
        {
            return $"\nLogin Success!\tUsername: {this.CreatedBy}\tTime: {this.CreateDate}.";
        }
    }
}
