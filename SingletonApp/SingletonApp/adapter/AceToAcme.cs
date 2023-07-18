using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class AceToAcme : IAcme
    {
        private Ace a;
        private string firstName;
        private string lastName;
        public AceToAcme(Ace a)
        {
            this.a = a;
            firstName = a.getName().Split(" ")[0];
            lastName = a.getName().Split(" ")[1];
        }
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
