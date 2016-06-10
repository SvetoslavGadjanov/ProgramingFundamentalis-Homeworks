using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintAReceipt
{
    class PrintAReceipt
    {
        static void Main(string[] args)
        {
            string start = @"/----------------------\";
            string middle = @"|----------------------|";
            string end = @"\----------------------/";

            List<decimal> nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            Console.WriteLine(start);
            foreach (decimal dec in nums)
            {
                Console.WriteLine("| {0,20:f2} |", dec);
            }
            Console.WriteLine(middle);
            Console.WriteLine("| Total:{0,14:f2} |", nums.Sum());
            Console.WriteLine(end);
        }
    }
}
