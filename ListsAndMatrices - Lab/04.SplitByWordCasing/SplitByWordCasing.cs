using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] splitters = new char[]
            {
                ',', ';', ':', ';', ',', '.', '!','(', ')', '"', '\'', '\\', '/', '[', ']', ' '
            };
            List<string> words = Console.ReadLine().Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCaseList = new List<string>();
            List<string> upperCaseList = new List<string>();
            List<string> mixedCaseList = new List<string>();

            foreach (var word in words)
            {
                var type = GetWordType(word);
                if (type == WordType.Uppercase)
                {
                    upperCaseList.Add(word);
                }
                if (type == WordType.Lowercase)
                {
                    lowerCaseList.Add(word);
                }
                if (type == WordType.Mixedcase)
                {
                    mixedCaseList.Add(word);
                }
                
            }
            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCaseList));
        }

        enum WordType { Uppercase, Mixedcase, Lowercase }

        private static WordType GetWordType(string word)
        {
            int lowerLetters = 0;
            int upperLetters = 0;

            foreach (char ch in word)
            {
                if (Char.IsUpper(ch))
                {
                    upperLetters++;
                }
                else if (Char.IsLower(ch))
                {
                    lowerLetters++;
                }
            }
            if (lowerLetters == word.Length)
            {
                return WordType.Lowercase;
            }
            if (upperLetters == word.Length)
            {
                return WordType.Uppercase;
            }
            return WordType.Mixedcase;



        }
    }
}
