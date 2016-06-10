using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Capitalization
{
    class Capitalization
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', '.', ',', '?', '!', ';' };
            string[] input = Console.ReadLine().Split(separators).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = MakeCapital(input[i]);
            }

            Console.WriteLine(string.Join(" ", input));
        }

        private static string MakeCapital(string str)
        {
            char first = str[0];
            string result = str.Substring(1);
            result = Char.ToUpper(first) + result;

            return result;
        }
    }
}
