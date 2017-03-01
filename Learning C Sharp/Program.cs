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
            testHello();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        static void testHello()
        {
            Hello Hi1 = new Hello();
            Hello Hi2 = new Hello("Stephen");
            Hello Hi3 = new Hello();

            Hi1.sayHi();
            Hi1.getName();
            Hi1.sayHi();
            Hi1.finishHim();

            Console.WriteLine("\nNext person...");

            Hi2.sayHi();
            Hi2.finishHim();

            Console.WriteLine("\nNext person...");

            Hi3.sayHi();
            Hi3.finishHim();

            Console.WriteLine("\nFinally, we're done, done, done!");
        }
    }
}
