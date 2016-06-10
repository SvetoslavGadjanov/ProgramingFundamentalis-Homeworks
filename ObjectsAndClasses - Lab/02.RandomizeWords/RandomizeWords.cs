using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();

            for (int first = 0; first < words.Length; first++)
            {
                var second = rnd.Next(0, words.Length);
                var old = words[first];
                words[first] = words[second];
                words[second] = old;

            }

            Console.WriteLine(String.Join("\r\n", words));
        }
    }
}
