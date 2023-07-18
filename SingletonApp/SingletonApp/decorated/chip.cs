using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class chip : componentDecorated
    {
        computer c;
        public chip(computer c)
        {
            this.c = c;
        }
        public override string description()
        {
            return c.description()+" and 1 chip";
        }
    }
}
