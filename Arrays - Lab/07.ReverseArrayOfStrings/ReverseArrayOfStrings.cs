using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string console = Console.ReadLine();
            string[] inputArr = console.Split(' ');
            string[] printArr = inputArr.Reverse().ToArray();

            foreach (string str in printArr)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();


        }
    }
}
