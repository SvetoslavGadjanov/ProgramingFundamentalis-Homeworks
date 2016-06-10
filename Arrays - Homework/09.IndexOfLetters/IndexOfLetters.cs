using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();



            foreach (char ch in input)
            {
                int num = ch - 97;
                Console.WriteLine("{0} -> {1}", ch, num);
            }

        }
    }
}
