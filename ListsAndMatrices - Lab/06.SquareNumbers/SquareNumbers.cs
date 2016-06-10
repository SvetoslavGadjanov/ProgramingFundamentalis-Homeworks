using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();

            nums.Sort();
            nums.Reverse();
            List<int> sqrtList = new List<int>();

            foreach (int num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    sqrtList.Add(num);
                }
            }

            Console.WriteLine(String.Join(" ", sqrtList));
        }
    }
}
