using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();


            //int localCounter = 1;
            //int counter = 1;
            //int startingElement = 0;
            List<int> maxList = new List<int>();
            List<int> localList = new List<int>();
            localList.Add(numbers[0]);


            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    localList.Add(numbers[i + 1]);
                }
                if (localList.Count > maxList.Count)
                {
                    maxList = localList;
                }
                if ((numbers[i] >= numbers[i + 1]))
                {
                    localList = new List<int>();
                    localList.Add(numbers[i + 1]);
                }

            }


            Console.WriteLine(String.Join(" ", maxList));
        }
    }
}
