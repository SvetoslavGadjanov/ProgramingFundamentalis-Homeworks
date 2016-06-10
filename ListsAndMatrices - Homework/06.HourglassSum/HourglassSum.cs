using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.HourglassSum
{
    class HourglassSum
    {
        static void Main(string[] args)
        {
            int rows = 6;
            int cols = 6;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
                for (int j = 0; j < cols; j++)
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

            int bestSum = int.MinValue;
            int currentSum = int.MinValue;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 1; j < cols - 1; j++)
                {
                    currentSum = matrix[i, j - 1] + matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 2, j - 1] + matrix[i + 2, j] + matrix[i + 2, j + 1];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }

            Console.WriteLine(bestSum);
            
        }
    }
}
