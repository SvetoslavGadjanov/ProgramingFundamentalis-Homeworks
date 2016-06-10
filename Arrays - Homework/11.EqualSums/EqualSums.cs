using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            List<int> index = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                //Sum Left
                for (int j = i-1; j >= 0; j--)
                {
                    if (i == 0)
                    {
                        sumLeft = 0;
                        break;
                    }
                    else
                    {
                        sumLeft += numbers[j];
                    }
                }
                //Sum Right
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (i == numbers.Length-1)
                    {
                        sumRight = 0;
                        break;
                    }
                    else
                    {
                        sumRight += numbers[j];
                    }
                }

                if (sumLeft == sumRight)
                {
                    index.Add(i);
                }
            }

            if (!index.Any())
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(String.Join(" ", index));
            }
        }
    }
}
