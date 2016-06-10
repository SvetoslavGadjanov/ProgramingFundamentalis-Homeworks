using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            SortedSet<int> keys = new SortedSet<int>();

            foreach (var num in nums)
            {
                keys.Add(num);
            }

            foreach (var key in keys)
            {
                int counter = 0;
                foreach (var num in nums)
                {
                    if (num == key)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0} -> {1}", key, counter);
            }

        }
    }
}
