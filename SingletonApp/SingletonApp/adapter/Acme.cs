using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class Acme : IAcme
    {
        private string firstName;
        private string lastName;

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setFirstName(string fName)
        {
            firstName = fName;
        }

        public void setLastName(string lName)
        {
            lastName = lName;
        }
    }
}
