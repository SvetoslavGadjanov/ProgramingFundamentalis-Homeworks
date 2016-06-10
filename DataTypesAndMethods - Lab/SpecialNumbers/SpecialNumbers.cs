using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool special = IsNumberSpecial(i);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }

        private static bool IsNumberSpecial(int num)
        {
            int sum = SumOfDigits(num);
            bool special = (sum == 5) || (sum == 7) || (sum == 11);
            return special;
        }

        private static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }
    }
}
