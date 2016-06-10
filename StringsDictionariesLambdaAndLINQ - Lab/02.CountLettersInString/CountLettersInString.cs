using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountLettersInString
{
    class CountLettersInString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            int[] counts = new int[str.Max() + 1];
            for (int i = 0; i < str.Length; i++)
            {
                counts[str[i]]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", Convert.ToChar(i), counts[i]);
                }
            }

        }
    }
}
