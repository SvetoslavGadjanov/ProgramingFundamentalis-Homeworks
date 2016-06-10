using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());

            string hex = Convert.ToString(num, 16);
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
