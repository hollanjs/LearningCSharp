using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Learning_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //testHello(); // testing the functionality of the Hello class
            Variables();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        static void testHello()
        {
            Hello Hi1 = new Hello(); // running with default name
            Hello Hi2 = new Hello("Stephen"); // overwriting default
            Hello Hi3 = new Hello();

            // testing getName function to replace name
            Hi1.sayHi();
            Hi1.getName();
            Hi1.sayHi();
            Hi1.finishHim();

            Console.WriteLine("\nNext person...");

            // testing sayHi when name is passed into constructor
            Hi2.sayHi();
            Hi2.finishHim();

            Console.WriteLine("\nNext person...");

            // running testing finishHim with default not overwritten
            Hi3.sayHi();
            Hi3.finishHim();

            Console.WriteLine("\nFinally, we're done, done, done!");
        }

        static void Variables()
        {
            /*
            // int variable example
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            */

            // string variable examples
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            /*
             * the following code can also be written like:
             *      string myFirstName = Console.ReadLine();
             * this will help save on space
             */
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("Type your last name:  ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, {0} {1}!", myFirstName, myLastName);
        }
    }
}
