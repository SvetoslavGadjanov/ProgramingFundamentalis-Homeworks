using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int[] secindArr = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            int boundary = Math.Max(firstArr.Length, secindArr.Length);
            int[] result = new int[boundary];

            for (int i = 0; i < boundary; i++)
            {
                result[i] = firstArr[i % firstArr.Length] + secindArr[i % secindArr.Length];
            }

            Console.WriteLine(String.Join(" ", result));


        }
    }
}
