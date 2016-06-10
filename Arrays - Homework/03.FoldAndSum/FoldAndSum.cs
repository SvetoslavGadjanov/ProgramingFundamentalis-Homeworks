using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] operantOne = new int[2 * k];
            int[] operantTwo = new int[2 * k];
            int[] sum = new int[2 * k];

            for (int i = 0; i < 2*k; i++)
            {
                operantOne[i] = numbers[i + k];
            }
            for (int i = 0; i < k; i++)
            {
                operantTwo[k + i] = numbers[numbers.Length - 1 - i];
            }
            for (int i = 0; i < k; i++)
            {
                operantTwo[i] = numbers[k - 1 - i];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = operantOne[i] + operantTwo[i];
            }


            Console.WriteLine(String.Join(" ", sum));
          


        }
    }
}
