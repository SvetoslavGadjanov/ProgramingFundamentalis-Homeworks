using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            decimal[] intArr = Console.ReadLine().Split(' ').Select(Decimal.Parse).ToArray();
            
            foreach (decimal num in intArr)
            {
                decimal print = Math.Round(num, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", num, print);
            }
        }
    }
}
