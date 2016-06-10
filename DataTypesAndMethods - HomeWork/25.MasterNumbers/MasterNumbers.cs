using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= input; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }

                num = num / 10;
            }
            return false;

        }

        private static bool IsPalindrome(int num)
        {
            string test = Math.Abs(num).ToString();
            int limit = test.Length / 2;
            for (int i = 0; i < limit; i++)
            {
                if (test[i] != test[test.Length-i-1])
                {
                    return false;
                }
            }
            return true;
        }
        private static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
