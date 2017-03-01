using System;

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
            // gets command line input to override name
            Console.Write("What is your name?\n-->  ");
            name = Console.ReadLine();
        }

        public void finishHim()
        {
            // sadly, not as violent as Mortal Combat
            Console.WriteLine("\nAlright, I think we're done here {0}.", name);
        }

        public Hello(string n = "Person of the World")
        {
            name = n;
        }

    }
}
