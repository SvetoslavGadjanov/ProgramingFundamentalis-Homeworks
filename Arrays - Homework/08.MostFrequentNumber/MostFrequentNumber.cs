using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            int element = 0;
            int counter = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int localCounter = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        localCounter++;
                    }
                }
                if (localCounter > counter)
                {
                    counter = localCounter;
                    element = i;
                }
            }

            Console.WriteLine(numbers[element]);
        }
    }
}
