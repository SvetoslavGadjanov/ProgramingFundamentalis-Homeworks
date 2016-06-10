using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
