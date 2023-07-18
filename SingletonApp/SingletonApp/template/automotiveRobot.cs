using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class automotiveRobot:robotTemplate
    {
        public override void getParts()
        {
           
            Console.WriteLine("getting a carburetor...");
        }
       
        public override void assemble()
        {
            Console.WriteLine("installing the carburetor...");
        }
        public override void test()
        {
            Console.WriteLine("revving the engine...");
        }

    }
}
