using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Euler___Multiples_of_3_and_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.

            int maxNum = 1000;
            int res = sumThreesAndFives(maxNum);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        public static int sumThreesAndFives(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
