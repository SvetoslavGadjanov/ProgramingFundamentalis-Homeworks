using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BuildMatrixOfLetters
{
    class BuildMatrixOfLetters
    {
        static void Main(string[] args)
        {
            int rows = Int32.Parse(Console.ReadLine());
            int cols = Int32.Parse(Console.ReadLine());

            char start = 'A';
            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ",Convert.ToChar(start + counter));
                    counter++;
                }
                Console.WriteLine();
            }

        }
    }
}
