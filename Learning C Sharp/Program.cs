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
            //Variables(); // tinkering around with int and string
            //Decisions(); // tinkering with if statements
            ForIteration();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        static void guessWhat(string msg)
        {
            // helper function that, you guessed it, just tacks on
            // "Guess what... " to a message...
            // Pretty sweet, yes?
            Console.WriteLine("Guess what... {0}", msg);
        }

        static void hashLine()
        {
            string hashedLine = string.Join("", Enumerable.Repeat("#", 50));
            Console.WriteLine("\n{0}\n", hashedLine);
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

            // int variable example
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine("y = x + 3");
            Console.WriteLine("Printing the y variable: {0}\n", y);


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

        static void Decisions()
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message;

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
                message = "You're inability to follow directions mean you lose. You win nothing. Sit down, sir/ma'am!";

            guessWhat(message);

            // turnary logic example
            Console.WriteLine("\nAnother Big Bob's Big Giveaway");
            Console.Write("Now there is only 1 prize!\nChoose a door: 1, 2 or 3: ");
            userValue = Console.ReadLine();

            message = (userValue == "2") ? "You won a new Boat!" : "Just kidding, there was a secondary prize - an out of focus picture of my feet... Enjoy!";
            guessWhat(message);
        }

        static void OperatorsExpressionsStatements()
        {
            // variable declaration
            int x, y, a, b;

            // assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // ##  Math operators  ## //
            x = 3 + 4;  // Addition
            x = 4 - 3;  // Subtraction
            x = 4 * 3;  // Mulctiplication
            x = 10 / 5; // Division

            // specify order of operations using parenthesis
            x = (x + y) * (a - b);

            //Equality operator
            if (x == y)
            {
                // do stuff
            }

            // Greater than
            if (x > y)
            {
                // do stuff
            }

            // less than
            if (x < y)
            {
                // do stuff
            }

            // Greater than or equal to
            if (x >= y)
            {
                // do stuff
            }

            // Less than or equal too
            if (x <= y)
            {
                // do stuff
            }

            // AND operator
            if ((x <= y) && (a > b))
            {
                // do stuff
            }

            // OR operator
            if ((x <= y) || (a > b))
            {
                // do stuff
            }

            // Turnary, or in-line conditional
            string youWin = (x == 5) ? "You win!" : "You do not win, in any way, shape or form. Buh-bye.\n";

            // Member access and Method invocation
            Console.WriteLine("Invoking this message to print to the screen!");

        }

        static void ForIteration()
        {
            // working through some examples using the "for" statement

            string msg = "";
            // Print numbers 0-9 with special message if 
            // a specific number is found
            for (int i = 0; i < 10; i++)
            {
                //set message based on conditional
                if (i == 7)
                {
                    msg = " - Found " + i;
                }
                else if (i > 8)
                {
                    msg = " - This number is bigger than 8!";
                }

                // write number and message
                Console.WriteLine("{0}{1}", i, msg);

                // reset message to default
                msg = "";
            }

            // random seperator for fun
            hashLine();
            Console.WriteLine("Pretty cool sperator, am I right?");

        }
    }
}
