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
    }
}
