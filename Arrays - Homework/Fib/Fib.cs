using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib
{
    class Fib
    {
        static void Main(string[] args)
        {
            long num = Int64.Parse(Console.ReadLine());
            Console.WriteLine(FibNum(num));
        }

        private static long FibNum(long num)
        {
            if (num <= 2)
            {
                return 1;
            }
            return FibNum(num - 1L) + FibNum(num - 2L);
        }
    }
}
