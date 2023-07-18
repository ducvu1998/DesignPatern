using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class cardVGA :componentDecorated
    {
        computer c;
        public cardVGA(computer c)
        {
            this.c = c;
        }
        public override string description()
        {
            return c.description()+" and 1 VGA";
        }
    }
}
