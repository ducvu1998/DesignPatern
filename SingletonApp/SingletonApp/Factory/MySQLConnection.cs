using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class MySQLConnection:Connection
    {
        public MySQLConnection() {  }
        
        public override string description()
        {
            return "MySQL Connecting";
        }
    }
}
