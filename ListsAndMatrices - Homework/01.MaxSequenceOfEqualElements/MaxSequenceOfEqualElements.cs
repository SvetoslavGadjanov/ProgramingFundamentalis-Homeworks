using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();

            int localCounter = 1;
            int counter = 1;
            int element = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    localCounter = localCounter + 1;
                }
                else
                {
                    localCounter = 1;
                }

                if (localCounter > counter)
                {
                    counter = localCounter;
                    element = i;
                }

            }


            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0} ", numbers[element]);
            }
        }
    }
}
