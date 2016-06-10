using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _17.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            try
            {
                
                long num = long.Parse(number);
                
                Console.WriteLine("{0} can fit in:", num);

                if (IsInInterval(num, -128, 127))
                {
                    Console.WriteLine("* sbyte");
                }
                if (IsInInterval(num, 0, 255))
                {
                    Console.WriteLine("* byte");
                }
                if (IsInInterval(num, -32768, 32767))
                {
                    Console.WriteLine("* short");
                }
                if (IsInInterval(num, 0, 65535))
                {
                    Console.WriteLine("* ushort");
                }
                if (IsInInterval(num, -2147489648, 2147489647))
                {
                    Console.WriteLine("* int");
                }
                if (IsInInterval(num, 0, 4294967295))
                {
                    Console.WriteLine("* uint");
                }
                if (IsInInterval(num, -9223372036854775808, 9223372036854775807))
                {
                    Console.WriteLine("* long");
                }
                

            }
            catch (SystemException)
            {
                Console.WriteLine("{0} can't fit in any type", number);
            }
           




        }

        private static bool IsInInterval(long num, long v1, long v2)
        {
            if (num >= v1 && num <= v2)
            {
                return true;
            }
            else
	        {
                return false;
            }
        }
    }
}
