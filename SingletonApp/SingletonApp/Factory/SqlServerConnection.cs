using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class SqlServerConnection : Connection
    {
        public SqlServerConnection() { }
        public override string description()
        {
            return "SQL server connecting!";
        }

    }
}
