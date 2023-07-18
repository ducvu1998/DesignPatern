using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class mainBoard : componentDecorated
    {
        computer c;
        public mainBoard(computer c) {
            this.c = c;
        }
        public override string description()
        {
            return c.description()+" and 1 main";
        }
    }
}
