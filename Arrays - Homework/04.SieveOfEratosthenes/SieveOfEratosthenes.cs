using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(Console.ReadLine());
            bool[] findPrimes = new bool[limit + 1];

            for (int i = 0; i < findPrimes.Length; i++)
            {
                findPrimes[i] = true;
            }
            findPrimes[0] = false;
            findPrimes[1] = false;

            for (int i = 0; i < findPrimes.Length; i++)
            {
                if (findPrimes[i])
                {
                    for (int j = i*i; j < findPrimes.Length; j+=i)
                    {
                        findPrimes[j] = false;
                    }
                }
            }

            for (int i = 0; i < findPrimes.Length; i++)
            {
                if (findPrimes[i])
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

        }
    }
}
