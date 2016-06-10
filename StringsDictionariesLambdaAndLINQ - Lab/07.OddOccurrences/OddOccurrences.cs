using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            
            var words = Console.ReadLine().ToLower().Split(' ');

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            var toPrint = new List<string>();
            foreach (var pair in counts)
            {
                
                if (pair.Value % 2 == 1)
                {
                    toPrint.Add(pair.Key);
                }
            }
            Console.WriteLine(String.Join(", ", toPrint));

        }
    }
}
