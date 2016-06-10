using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMinMaxFirstLastAverage
{
    class SumMinMaxFirstLastAverage
    {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", arr.Sum());
            Console.WriteLine("Min = {0}", arr.Min());
            Console.WriteLine("Max = {0}", arr.Max());
            Console.WriteLine("First = {0}", arr[0]);
            Console.WriteLine("First = {0}", arr[arr.Length-1]);
            Console.WriteLine("Max = {0}", arr.Average());
        }
    }
}
