using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CommonStrings
{
    class CommonStrings
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            bool areTheSame = false;

            List<char> firstChars = first.ToCharArray().ToList();
            List<char> secondChars = second.ToCharArray().ToList();

            for (int i = 0; i < firstChars.Count; i++)
            {
                if (secondChars.Contains(firstChars[i]))
                {
                    Console.WriteLine("yes");
                    areTheSame = true;
                    break;
                }
            }
            if (!areTheSame)
            {
                Console.WriteLine("no");
            }


        }
    }
}
