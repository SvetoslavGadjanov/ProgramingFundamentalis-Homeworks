using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int diverence = Int32.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == diverence)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
