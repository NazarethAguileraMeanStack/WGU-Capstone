﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class LoginRecordFailure : LoginRecord
    {
        public override string logToFile()
        {
            return $"\nLogin Failure!\tUsername: {this.CreatedBy}\tTime: {this.CreateDate}.";
        }
    }
}
