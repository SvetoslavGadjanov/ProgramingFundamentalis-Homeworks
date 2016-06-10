using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractMiddle
{
    class ExtractMiddle
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                Console.WriteLine("{ " + input +  " }");
            }
            else
            {
                string[] strArr = input.Split(' ');
                if (strArr.Length % 2 == 0)
                {
                    Console.Write("{ ");
                    Console.Write("{0}, {1}", strArr[strArr.Length/2 - 1], strArr[strArr.Length / 2]);
                    Console.Write(" }");
                    Console.WriteLine();

                }
                else
                {
                    Console.Write("{ ");
                    Console.Write("{0}, {1}, {2}", strArr[strArr.Length / 2 - 1], strArr[strArr.Length / 2], strArr[strArr.Length / 2 + 1]);
                    Console.Write(" }");
                    Console.WriteLine();


                }
            }
        }
    }
}
