using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int k = arr.Length / 4;
            var row1Left = arr.Take(k).Reverse();
            var row1Right = arr.Reverse().Take(k);
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();

            var sumArr = row1.Select((x, index) => x + row2[index]);

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
