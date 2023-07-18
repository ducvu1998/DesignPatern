using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace SingletonApp
{
    abstract class Connection
    {
        public Connection() { }
        public abstract string description();
        public string Description()
        {
            return "generel";
        }
        
    }
}
