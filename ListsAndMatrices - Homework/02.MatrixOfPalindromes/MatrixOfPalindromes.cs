using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            int rows = numbers[0];
            int cols = numbers[1];

            char start = 'a';

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    char mid = Convert.ToChar(start + j);
                    Console.Write("{0}{1}{0} ", start, mid);
                }
                Console.WriteLine();
                start++;
            }
        }
    }
}
