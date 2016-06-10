using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            List<int> positive = new List<int>();

            foreach (var num in nums)
            {
                if (num > 0)
                {
                    positive.Add(num);
                }
            }

            positive.Reverse();

            if (positive.Any())
            {
                Console.WriteLine(String.Join(" ", positive));

            }
            else
            {
                Console.WriteLine("empty");

            }
        }
    }
}
