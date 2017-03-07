using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events_Lambdas
{
    #region Define Delegate
    public delegate string MathDelegate(int arg1, int arg2);
    #endregion

    #region Define Anonymous Delegate
    public delegate int AnonymousDelegate(int i, string s);
    #endregion

    class Program
    {
        #region Functions and Setup for Delegate
        // to use functions as delegates, they need to match the parameters
        // and type of a Delegate defined outside of the class
        // MathDelegate takes in 2 integers and returns a string
        // so, everything below needs to match that signature in order
        // to be used as a MathDelegate function
        static string addFunc(int a, int b) { return (a + b).ToString(); }
        static string subFunc(int a, int b) { return (a - b).ToString(); }
        static string mulFunc(int a, int b) { return (a * b).ToString(); }
        static string divFunc(int a, int b) { return (a / b).ToString(); }

        // print helper function
        // because we're using delegates, we can pass a function as a parameter
        // since the MathDelegate takes in 2 integers and returns a string, we need to define the Func like this:
        //       
        // Func<input, input, output>
        // which looks like this:   Func<int, int, string>
        static void print(int a, int b, MathDelegate f) { Console.WriteLine($"{a} + {b} = {f(a, b)}"); }
        #endregion

        static void Main(string[] args)
        {
            // Uncomment Delegate Testing region to run
            #region Delegate Testing
            /*
            int num1 = 10;
            int num2 = 20;

            // defining the instance of the delegate
            // really only need to do this the first time
            MathDelegate mathFunc = addFunc;
            print(num1, num2, mathFunc);

            mathFunc = subFunc;
            print(num1, num2, mathFunc);

            mathFunc = mulFunc;
            print(num1, num2, mathFunc);

            mathFunc = divFunc;
            print(num1, num2, mathFunc);
            */
            #endregion

            #region Anonymous Delegate Testing
            // I'm guessing can be setup wherever?
            AnonymousDelegate anonFunc = delegate (int i, string s) 
            {
                Console.WriteLine($"Number: {i}\nString: {s}");
                Console.WriteLine("For the hell of it, we're just going to return the number provided by 2");
                Console.WriteLine($"So, {1} * 2 = {i*2}");
                Console.WriteLine("Go ahead, pass this function as a parameter into a Console.WriteLine and see whay pops out on the next line!");
                return i * 2;
            };

            Console.WriteLine(anonFunc(25, "Cincinnati"));
            #endregion

        }
    }
}
