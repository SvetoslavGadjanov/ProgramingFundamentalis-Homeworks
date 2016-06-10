using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(' ').Select(Decimal.Parse).ToList();

            nums.Sort();
            Console.WriteLine(String.Join(" <= ", nums));
        }
    }
}
