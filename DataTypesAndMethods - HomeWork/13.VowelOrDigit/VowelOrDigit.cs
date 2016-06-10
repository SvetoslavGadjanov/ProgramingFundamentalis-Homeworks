using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char ch = Convert.ToChar(Console.ReadLine());

            if (Char.IsDigit(ch))
            {
                Console.WriteLine("digit");
            }
            else if (ch == 'a' || ch == 'e' || ch == 'u' || ch == 'o' || ch == 'i')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
