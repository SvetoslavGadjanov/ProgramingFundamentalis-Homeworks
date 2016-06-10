using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().Replace(" ", String.Empty);
            string second = Console.ReadLine().Replace(" ", String.Empty);




            if (first == second)
            {
                Console.WriteLine(first);
                Console.WriteLine(first);
            }

            else
            {
                SortedSet<string> set = new SortedSet<string>();
                set.Add(first);
                set.Add(second);

                foreach (string str in set)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
