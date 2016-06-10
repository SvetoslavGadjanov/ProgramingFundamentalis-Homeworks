using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _26.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            BigInteger result = factorialN(input);
            Console.WriteLine(result);

        }
        public static BigInteger factorialN (int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else
            {
                BigInteger temp = 1;

                for (int i = 1; i <= input; i++)
                {
                    temp = temp * i;
                }

                return temp;
            }
            
        }


    }
}
