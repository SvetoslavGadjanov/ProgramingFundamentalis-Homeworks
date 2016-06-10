using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                while (nums.Length != 1)
                {
                    int[] condensed = new int[nums.Length - 1];

                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        condensed[i] = nums[i] + nums[i + 1];
                    }
                    nums = new int[condensed.Length];
                    Array.Copy(condensed, nums, condensed.Length);
                }
                Console.WriteLine(nums[0]);
            }
        }
    }
}
