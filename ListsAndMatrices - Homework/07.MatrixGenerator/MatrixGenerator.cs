using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixGenerator
{
    class MatrixGenerator
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string type = input[0];
            int rows = Int32.Parse(input[1]);
            int cols = Int32.Parse(input[2]);

            switch (type)
            {
                case "A":
                    PrintA(rows, cols);
                    break;
                case "B":
                    PrintB(rows, cols);
                    break;
                case "C":
                    PrintC(rows, cols);
                    break;
                case "D":
                    PrintD(rows, cols);
                    break;
            }
        }

        private static void PrintD(int r, int c)
        {
            int[,] m = new int[r, c];
            int number = 1;
            int indexR = 0;
            int indexC = 0;

            while (number <= r * c)
            {
                m[indexR, indexC] = number;
                number++; ;

                bool canGoDown = (indexR + 1) < r && m[indexR + 1, indexC] == 0 && !((indexC - 1) >= 0 && m[indexR, indexC - 1] == 0);
                if (canGoDown) { indexR++; continue; }
                bool canGoRight = (indexC + 1) < c && m[indexR, indexC + 1] == 0;
                if (canGoRight) { indexC++; continue; }
                bool canGoUp = (indexR - 1) >= 0 && m[indexR - 1, indexC] == 0;
                if (canGoUp) { indexR--; continue; }
                bool canGoLeft = (indexC - 1) >= 0 && m[indexR, indexC - 1] == 0;
                if (canGoLeft) { indexC--; continue; }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0} ", m[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintC(int rows, int cols)
        {
            
            int value = 1;
            int col = 0;
            int[,] matrix = new int[rows, cols];

            for (int startRow = rows-1; startRow > -rows*cols; startRow--)
            {
                
                for (int row = startRow; row < rows; row++)
                {
                    if (row>=0 && col < cols)
                    {
                        matrix[row, col] = value;
                        value++;
                    }
                    col++;
                }
                col = 0;
                
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintB(int rows, int cols)
        {
            int value = 1;
            int[,] matrix = new int[rows, cols];

            for (int col = 0; col < cols; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row, col] = value;
                        value++;
                    }
                }
                if (col % 2 != 0)
                {
                    for (int row = rows-1; row >= 0; row--)
                    {
                        matrix[row, col] = value;
                        value++;
                    }
                }

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintA(int rows, int cols)
        {
            int value = 1;
            int[,] matrix = new int[rows, cols];

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
