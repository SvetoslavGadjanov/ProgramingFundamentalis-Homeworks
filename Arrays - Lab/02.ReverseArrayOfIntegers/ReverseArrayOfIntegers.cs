using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = size-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
