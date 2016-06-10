using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class FilledSquare
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());

            PrintHeaderRow(input);
            for (int i = 0; i < input-2; i++)
            {
                PrintMiddleRow(input);
            }
            PrintHeaderRow(input);

        }

        private static void PrintHeaderRow(int num)
        {
            char ch = '-';
            string output = new string(ch, 2 * num); 
            Console.WriteLine(output);
        }

        private static void PrintMiddleRow(int num)
        {
            char ch = '-';
            string mid = "\\/";
            string output = ch + string.Concat(Enumerable.Repeat(mid, num-1)) + ch;
            Console.WriteLine(output);
        }
    }
}
