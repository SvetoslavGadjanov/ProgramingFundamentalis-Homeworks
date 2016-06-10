using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int offset = Int32.Parse(Console.ReadLine());

            int[] sum = new int[input.Length];
            int[] temp = new int[input.Length];

            for (int i = 0; i < offset; i++)
            {
                int lastNum = input[input.Length - 1];       
                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = lastNum;

                for (int j = 0; j < input.Length; j++)
                {
                    sum[j] += input[j];
                }
            }
            

            
            Console.WriteLine(String.Join(" ", sum));

        }
    }
}
