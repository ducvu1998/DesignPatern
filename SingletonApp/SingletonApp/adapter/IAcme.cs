using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    interface IAcme
    {
        void setFirstName(string fName);
        void setLastName(string lName);
        string getFirstName();
        string getLastName();
    }
}
