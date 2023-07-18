using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    abstract class ConnectionFactory
    {
        //string type;
        public ConnectionFactory() { }
        public abstract Connection createConnection(string type);
    }
}
