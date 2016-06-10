using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());

            Fib(input);
        }

        private static void Fib(int input)
        {
            int firstNum = 1;
            int secondNum = 1;

            if (input == 0 && input == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 0; i < input; i++)
                {
                    int temp = firstNum;
                    firstNum = secondNum;
                    secondNum = temp + secondNum;
                }
                Console.WriteLine(firstNum);
            }
        }
    }
}
