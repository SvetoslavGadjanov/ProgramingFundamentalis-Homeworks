using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            long num1 = Int64.Parse(Console.ReadLine());
            long num2 = Int64.Parse(Console.ReadLine());

            findAllPrimes(num1, num2);
            Console.WriteLine();
        }
        public static void findAllPrimes(long num1, long num2)
        {
            List<long> primeList = new List<long>();
            long start = Math.Min(num1, num2);
            long end = Math.Max(num1, num2);

            for (long i = start; i <= end; i++)
            {
                if (isPrime(i))
                {
                    primeList.Add(i);
                }
            }

            Console.Write(primeList[0]);
            for (int i = 1; i < primeList.Count; i++)
            {
                Console.Write(", {0}", primeList[i]);
            }



        }
        public static bool isPrime(long number)
        {
            long boundary = (int)Math.Sqrt(number) + 1;

            if (number == 0) return false;
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
