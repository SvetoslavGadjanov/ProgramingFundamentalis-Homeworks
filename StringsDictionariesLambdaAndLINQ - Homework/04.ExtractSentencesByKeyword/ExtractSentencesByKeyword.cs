using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            char[] sentanceSeparator = new char[] {'.', '!', '?'};
            string wordToSearch = Console.ReadLine();
            List<string> sentances  = Console.ReadLine().Split(sentanceSeparator).ToList();

            for (int i = 0; i < sentances.Count; i++)
            {
                sentances[i] = sentances[i].TrimStart();
            }

            string pattern = @"\W";
            foreach (string str in sentances)
            {
                List<string> words = Regex.Split(str, pattern).ToList();
                if (words.Contains(wordToSearch))
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
