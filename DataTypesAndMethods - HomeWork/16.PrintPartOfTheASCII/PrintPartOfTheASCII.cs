using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintPartOfTheASCII
{
    class PrintPartOfTheASCII
    {
        static void Main(string[] args)
        {
            int start = Int32.Parse(Console.ReadLine());
            int end = Int32.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();

        }
    }
}
