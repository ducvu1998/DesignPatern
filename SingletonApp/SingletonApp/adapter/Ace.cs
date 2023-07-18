using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class Ace : IAce
    {
        private string name;
        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name=name;
        }
    }
}
