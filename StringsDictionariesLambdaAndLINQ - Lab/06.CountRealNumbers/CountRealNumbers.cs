using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(Decimal.Parse);
            var counts = new SortedDictionary<decimal, int>();

            foreach (var num in nums)
            {
                counts[num] = 0;
            }
            foreach (var num in nums)
            {
                counts[num] ++;
            }

            foreach (var key in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}", key, counts[key]);
            }

        }
    }
}
