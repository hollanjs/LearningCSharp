using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Learning_C_Sharp
{
    public class Hello
    {
        
        public string name { get; set; }

        public void sayHi ()
        {
            Console.WriteLine("\nHello, {0}!\a", name);
        }

        public void getName()
        {
            Console.Write("What is your name?\n-->  ");
            name = Console.ReadLine();
        }

        public void finishHim()
        {
            Console.WriteLine("\nAlright, I think we're done here {0}.", name);
        }

        public Hello(string n = "Person of the World")
        {
            name = n;
        }

    }
}
