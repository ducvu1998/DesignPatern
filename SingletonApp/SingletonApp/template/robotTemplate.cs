using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
     public class robotTemplate
    {
        public void go()
        {
            start();
            getParts();
            assemble();
            test();
            stop();
        }
        public void start()
        {
            Console.WriteLine("starting...");
        }
        public virtual void getParts()
        {
            Console.WriteLine("getting part...");
        }
        public virtual void assemble()
        {
            Console.WriteLine("assembling...");
        }
        public virtual void test()
        {
            Console.WriteLine("testing...");
        }
        public void stop()
        {
            Console.WriteLine("stopping...");
        }
        
    }
}
