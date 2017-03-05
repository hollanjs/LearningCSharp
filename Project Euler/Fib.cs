using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Fib //onacci
    {
        private int limit;
        private List<int> sequence = new List<int>();

        public int Limit
        {
            get { return limit; }

            set
            {
                try
                {
                    limit = value;

                    if (value <= 0)
                    {
                        limit = 1;
                        throw (new ArgumentOutOfRangeException("_limit", "You entered 0 or a negative number.\nMust be set with an integer value of 1 or greater.\nSetting to default of 1"));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }// end set
        } // end limit get/set

        public Fib()
        {
            limit = 1;
        }

        public Fib(int lmt)
        {
            limit = lmt;
        }

        public void createSequenceToLimit()
        {
            int current = 1;
            int next = 1;

            while (next <= limit)
            {
                int temp = current;
                current = next;
                next = current + temp;

                sequence.Add(current);
            }
        }

        public void showSequence()
        {
            foreach (var num in sequence)
            {
                Console.WriteLine(num);
            }
        }

        public void sumEvensInSequence()
        {
            IEnumerable<int> evensQuery =
                from num in sequence
                where num % 2 == 0
                select num;

            Console.WriteLine("Sum of all even numbers: {0}", evensQuery.Sum());
        }
    }
}
