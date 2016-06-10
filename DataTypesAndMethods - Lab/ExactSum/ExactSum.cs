using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSum
{
    class ExactSum
    {
        static void Main(string[] args)
        {
            int rounds = Int32.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < rounds; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
