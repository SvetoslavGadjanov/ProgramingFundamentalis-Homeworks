using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RotateAMatrix
{
    class RotateAMatrix
    {
        static void Main(string[] args)
        {
            int rows = Int32.Parse(Console.ReadLine());
            int cols = Int32.Parse(Console.ReadLine());


            List<List<string>> matrix = new List<List<string>>();

            for (int i = 0; i < rows; i++)
            {
                matrix.Add(Console.ReadLine().Split().ToList());
            }

            //foreach (var row in matrix)
            //{
            //    Console.WriteLine(String.Join(" ", row));
            //}

            for (int i = 0; i < cols; i++)
            {
                for (int j = rows-1; j >= 0; j--)
                {
                    Console.Write("{0} ", matrix[j][i]);
                }
                Console.WriteLine();
            }
        }
    }
}
