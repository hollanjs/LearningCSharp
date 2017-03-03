using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//import Animals & Autmobiles namespace to use Car, Animal, Dog and Cat classes
using Animals;
using Automobiles;

namespace Learning_C_Sharp
{
    class Program
    {

        // ctrl + k  - comments out lines of code
        // cw then tab twice   - writes out Console.WriteLine()

        /*  NOTES ON METHOD TYPES: [access modifier?] [static?] [return type or void] [name] ([parameters?])
            
         *  //ACCESS MODIFIERS//
            public - If you can see the class, then you can see the method

            private - If you are part of the class or struct, then you can see the method, otherwise not.

            protected - Same as Private, plus all descendants can also see the method.

            internal - The type or member can be accessed by any code in the same assembly, but not from another assembly.

            protected Internal - The type or member can be accessed by any code in the same assembly, or by any derived class in another assembly.
           
         *  //STATIC//
            static (class) - Remember the distinction between "Class" and "Object" ? Forget all that. They are the same with "static"... the class is the one-and-only instance of itself.

            static (method) - Whenever you use this method, it will have a frame of reference independent of the actual instance of the class it is part of.

            if using a method within a static method, the method needs to be static as well. you can only use static methods within static methods.
        
         *  //VOID//
            void just means that you have a method that doesn't return anything.
            Otherwise, just state the return type
         */

        static void Main(string[] args)
        {
            //testHello(); // testing the functionality of the Hello class
            //Variables(); // tinkering around with int and string
            //Decisions(); // tinkering with if statements
            //ForIteration(); // working with for loop
            //WorkingWithArrays(); // array example with forearch
            //typeExamples(); // type examples
            //whileAndDoWhileLoops(); // example of while loops

            /* example of switch reference
            switchRef(0); // testing switch with first case
            switchRef(1); // testing switch with second case
            switchRef(2); // testing switch with default case
            */

            // Tinkering with Animal class
            /*
            Animal newAnimal = new Animal();
            newAnimal.move();
            newAnimal.Age = -4;

            Animal dog = new Animal();
            dog.Age = 14;
            dog.Color = "Brown";
            */

            // Tinkering with inheritance
            // Dog subclass which inherits from animal
            // needed to imporst namespace Animal at top
            // in order to use Animal and Animal child classes
            /*
            Dog Fido = new Dog();
            Fido.Age = 4;
            Fido.Color = "white";
            Fido.name = "Fido";
            Fido.move();
            Fido.makeNoise();
            Console.WriteLine("{0} is {1} years old and has {2} colored fur.", Fido.name, Fido.Age, Fido.Color);
            */

            // Tinkering with Car class from Autmobile namespace
            /*
            Car myCar = new Car();
            myCar.color = "silver";
            myCar.make = "Pontiac";
            myCar.model = "G6";
            myCar.Drive();
            myCar.Stop();

            Car posCar = new Car();
            posCar.Drive();
            posCar.Stop();

            Car fancyCar = new Car("Aston Martin", "DB5", "red");
            fancyCar.Drive();
            fancyCar.Stop();
            */



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
        
        struct Person
        {
            /* struct type
             * use for small objects, probably mostly computational needs, like math
             * or for storing point values like x, y, z
             * 
             * don't put in fuction - should be defined
             * within the class next to the functions
             */
        int age;
            string firstName;
            string lastName;
        }   

        static void Variables()
        {
            /*
             * const int NUM_MONTHS = 12;
             * const = constant value - can't change or update.
             * NUM_MONTHS = uppercase is general convention for constants
             */

            const int NUM_MONTHS = 12;
            // NUM_MONTHS = 14;  // can't reassign!!! can't do this!!!
            Console.WriteLine("I made a const variable NUM_MONTHS which can't be changed. It will always be: {0}", NUM_MONTHS);

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

        static void WorkingWithArrays()
        {
            // Old way of doing it one-by-one
            int[] numbers = new int[5]; // giving array a specific size in memory

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine("Third item in numbers array: {0}", numbers[2]); // calling specific item from array
            Console.WriteLine("Numbers array length: {0}", numbers.Length); // finding how many items are in array

            hashLine();

            // newer way to make array in one line
            string[] names = new string[] { "Eddie", "Alex", "Micheal", "David" };

            /*
             * long way to run through names
             
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }

            */

            //Faster way
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // string converstion to char[] array to work with order, reversing and so on
            string quote = "This string will be written backwards in a moment.";
            char[] charArray = quote.ToCharArray(); // convert string to character array
            Array.Reverse(charArray); // reverse the character array         

            // now, to loop through char array, we can use foreach and Console.Write()
            foreach (char c in charArray)
            {
                Console.Write(c);
            }

            hashLine();
        }

        static void typeExamples()
        {
            // numeric data types
            sbyte aSignedByte = 127;
            byte aByte = 255;
            ushort anUnsignedShort = 65535;
            short aShort = 32767;
            int anInt = 2147483647;
            uint anUnsignedInt = 4294967295;
            ulong anUnsignedLong = 18446744073709551615;
            long aLong = 9223372036854775807;
            float aFloat = 105.5678493F;
            double aDouble = 105.567849312873245;
            decimal aDecimal = 105.8492379759487492387492374982347987293487M;

            // Character data types
            char aChar = 'A'; // must use single quotes
            string aString = "A string of chars"; // must use double quotes

            // Boolean data types
            bool trueResult = true;
            bool falseResult = false;

            // Output values, .NET types, size of data type and max value
            Console.WriteLine("aSignedByte value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", aSignedByte, typeof(sbyte), sizeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
            Console.WriteLine("aByte value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", aByte, typeof(byte), sizeof(byte), byte.MaxValue, byte.MinValue);
            Console.WriteLine("anUnsignedShort value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", anUnsignedShort, typeof(ushort), sizeof(ushort), ushort.MaxValue, ushort.MinValue);
            Console.WriteLine("aShort value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", aShort, typeof(short), sizeof(short), short.MaxValue, short.MinValue);
            Console.WriteLine("anInt value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", anInt, typeof(int), sizeof(int), int.MaxValue, int.MinValue);
            Console.WriteLine("anUnsignedInt value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", anUnsignedInt, typeof(uint), sizeof(uint), uint.MaxValue, uint.MinValue);
            Console.WriteLine("anUnsignedLong value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", anUnsignedLong, typeof(ulong), sizeof(ulong), ulong.MaxValue, ulong.MinValue);
            Console.WriteLine("aLong value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", aLong, typeof(long), sizeof(long), long.MaxValue, long.MinValue);
            Console.WriteLine("aFloat value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", aFloat, typeof(float), sizeof(float), float.MaxValue, float.MinValue);
            Console.WriteLine("aDouble value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", aDouble, typeof(double), sizeof(double), double.MaxValue, double.MinValue);
            Console.WriteLine("aDecimal value is {0}\nWhich has type: {1}\nAnd hase a size of: {2} Byte(s)\nMax Value: {3}\nMin Value: {4}\n\n", aDecimal, typeof(decimal), sizeof(decimal), decimal.MaxValue, decimal.MinValue);
        }

        static void whileAndDoWhileLoops()
        {
            // while loop
            int sentinel = 0; // need something to use to cancel out of loop
            while (sentinel < 10)
            {
                Console.WriteLine("From while loop: {0}", sentinel);
                sentinel++;
            }

            int sentinel2 = 0;
            do //processes do first, then while loop. use if you need to execute something at least once.
            {
                Console.WriteLine("From do...while loop: {0}", sentinel2);
                sentinel2++;
            } while (sentinel2 < 10);


        }

        static void switchRef(int num)
        {
            int val = num;
            switch (val)
            {
                case (0):
                    Console.WriteLine("Value is 0");
                    break;

                case (1):
                    Console.WriteLine("Value is 1");
                    break;

                default:
                    Console.WriteLine("Value is something other than 0 or 1");
                    break;
            }
        }
    }
}
