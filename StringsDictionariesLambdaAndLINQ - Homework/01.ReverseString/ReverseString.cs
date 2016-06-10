using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string toPrint = String.Join("", input.ToArray().Reverse());
            Console.WriteLine(toPrint);
        }
    }
}
