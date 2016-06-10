using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');

            int limit = Math.Min(first.Length, second.Length);            
            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < limit; i++)
            {
                if (first[i] == second [i])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
                
            }
            for (int i = 0; i < limit; i++)
            {
                if (first[first.Length - i - 1] == second[second.Length - i - 1])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
               
            }

            Console.WriteLine(Math.Max(leftCounter, rightCounter));



        }
    }
}
