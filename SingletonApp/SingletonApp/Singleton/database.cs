using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class database
    {
        private static database _instance =new database("product");
        public int record { get; set; }
        public string name { get; set; }
        private database(string n)
        {
            name = n;
            record = 0;
        }
        public static   database   getInstance()
        {
            return _instance;

        }
    }
}
