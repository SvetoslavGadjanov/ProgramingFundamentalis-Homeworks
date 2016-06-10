using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            List<string> results = new List<string>();

            for (int i = 0; i < intArr.Length; i++)
            {
                for (int j = i+1; j < intArr.Length; j++)
                {
                    
                    int sum = intArr[i] + intArr[j];
                    if (intArr.Contains(sum))
                    {
                        results.Add(intArr[i].ToString() + " + " + intArr[j].ToString() + " == " + sum.ToString());
                    }

                }
            }
            if (results.Any())
            {
                foreach (string str in results)
                {
                    Console.WriteLine(str);
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
 