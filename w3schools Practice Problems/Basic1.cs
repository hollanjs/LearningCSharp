using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3schools_Practice_Problems
{
    public class Basic1
    {
        private string Name;
        public string Greeting;

        public Basic1()
        {
            Name = "No Name";
            Greeting = "Hello!";
        }

        public Basic1(string name)
        {
            Name = name;
            Greeting = createGreeting();
        }

        public void sayHello()
        {
            Console.WriteLine(Greeting);
        }

        public string createGreeting()
        {
            Greeting = "Hello: " + Name;
            return Greeting;
        }
    }
}
