using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class LargestPrimeFactor
    {
        //refactor to use The Sieve of Atkin
        //this is a hot mess...

        public long currentNum { get; set; }
        public List<long> primeFactors = new List<long>();

        public LargestPrimeFactor(long num = 1)
        {
            currentNum = num;
        }

        public void generatePrimeFactors()
        {
            for (long i = 2; i < currentNum/2; i++)
            {
                if ( (checkIfPrime(i)) && (currentNum%i == 0) )
                {
                    primeFactors.Add(i);
                }
            }
        }

        public bool checkIfPrime(long n)
        {
            for (long i = 2; i <= (long)Math.Sqrt((double)n); i++)
            {
                if (n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public long getLargestPrime(long n)
        {
            try
            {
                return primeFactors.Max();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public long generateLargestPrime(long n)
        {
            long temp = 0;
            for (long i = 2; i < n/2; i++)
            {
                if ((checkIfPrime(i)) && (n % i == 0))
                {
                    temp = i;
                }
            }
            return temp;
        }

        public long generateLargestPrime()
        {
            long temp = 0;
            for (long i = 2; i < currentNum / 2; i++)
            {
                if ((checkIfPrime(i)) && (currentNum % i == 0))
                {
                    temp = i;
                }
            }
            return temp;
        }
    }
}
