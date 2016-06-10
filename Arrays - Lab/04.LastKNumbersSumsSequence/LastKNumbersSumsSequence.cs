using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            long size = Int64.Parse(Console.ReadLine());
            long elementsToSum = Int64.Parse(Console.ReadLine());

            long[] seq = new long[size];
            seq[0] = 1;

            for (long i = 1; i < size; i++)
            {
                if (i < elementsToSum)
                {
                    long sum = 0;
                    for (long j = i-1; j >= 0; j--)
                    {
                        sum = seq[j] + sum;
                    }
                    seq[i] = sum;
                }

                else
                {
                    long sum = 0;
                    for (long j = i - elementsToSum; j <= i - 1; j++)
                    {
                        sum = seq[j] + sum;
                    }
                    seq[i] = sum;
                }
                
            }

            foreach (long num in seq)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine();

        }
    }
}
