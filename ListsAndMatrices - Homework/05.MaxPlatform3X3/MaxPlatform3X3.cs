using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxPlatform3X3
{
    class MaxPlatform3X3
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(Int64.Parse).ToList();
            long rows = numbers[0];
            long cols = numbers[1];
            long[,] matrix = new long[rows, cols];

            for (long i = 0; i < rows; i++)
            {
                long[] temp = Console.ReadLine().Split().Select(Int64.Parse).ToArray();
                for (long j = 0; j < cols; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }
            //Printing:
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write("{0} ", matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            long[] bestStartElement = new long[2];
            long bestSum = long.MinValue;
            long[] currentStartElement = new long[2];
            long currentSum = long.MinValue;

            for (long i = 0; i < rows-2; i++)
            {
                currentStartElement[0] = i;
                for (long j = 0; j < cols-2; j++)
                {
                    currentStartElement[1] = j;
                    currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestStartElement[0] = currentStartElement[0];
                        bestStartElement[1] = currentStartElement[1];
                    }
                }
            }

            Console.WriteLine(bestSum);
            for (long i = bestStartElement[0]; i < bestStartElement[0] + 3; i++)
            {
                for (long j = bestStartElement[1]; j < bestStartElement[1] + 3; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
