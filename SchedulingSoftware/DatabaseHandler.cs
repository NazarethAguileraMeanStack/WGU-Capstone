using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    class DatabaseHandler
    {
        private string _connectionString = "server=127.0.0.1;database=client_schedule;uid=sqlUser;pwd=Passw0rd!";
        //private string _connectionString = "server=169.254.144.254;port=3306;database=client_schedule;uid=sqlUser;pwd=Passw0rd!";
        //private string _connectionString = "server=192.168.1.100;port=3306;database=client_schedule;uid=sqlUser;pwd=Passw0rd!";

        public string ConnectionString {
            get { return _connectionString; }
        }
    }
}
