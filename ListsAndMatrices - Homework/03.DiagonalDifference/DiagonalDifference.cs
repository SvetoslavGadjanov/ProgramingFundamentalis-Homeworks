using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write("{0} ", matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //Sum Main Diagonal
            int sumPrimary = 0;
            for (int i = 0; i < size; i++)
            {
                sumPrimary += matrix[i, i];
            }
            //Sum Secondary Diagonal
            int sumSecondary = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = size-1-i; j >= 0; j--)
                {
                    sumSecondary += matrix[i, j];
                    break;
                }
            }
            Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));
            
        }
    }
}
