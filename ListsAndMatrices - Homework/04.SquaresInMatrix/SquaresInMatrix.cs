using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            int rows = numbers[0];
            int cols = numbers[1];
            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] temp = Console.ReadLine().Split().ToArray();
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

            int counterEl = 0;
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    string currentEl = matrix[i, j];
                    if (currentEl == matrix[i, j + 1] && currentEl == matrix[i + 1, j] && currentEl == matrix[i + 1, j + 1])
                    {
                        counterEl++;
                    }
                }
            }
            Console.WriteLine(counterEl);
        }
    }
}
