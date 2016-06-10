using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long num = Int64.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(num));
        }
        public static bool isPrime(long number)
        {
            long boundary = (int)Math.Sqrt(number) + 1;

            if(number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
