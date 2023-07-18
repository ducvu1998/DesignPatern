using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class SecureFactory:ConnectionFactory
    {
        public SecureFactory() {  }
        public override Connection createConnection(string type)
        {
            switch (type)
            {
                case "SQLSERVER":
                    return new SqlServerConnection();
                    break;
                case "MYSQL":
                    return new MySQLConnection();
                    break;
                default:
                    return null;
                    break;
        }
        }
    }
}
