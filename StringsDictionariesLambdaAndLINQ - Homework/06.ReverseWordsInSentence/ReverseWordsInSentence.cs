using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.ReverseWordsInSentence
{
    class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] separateWords = new char[] {'.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' '};

            List<string> words = input.Split(separateWords).ToList();
            words.RemoveAll(string.IsNullOrEmpty);

            List<char> separateSymbols = new List<char>();

            foreach (string word in words)
            {
                foreach (char ch in word)
                {
                    separateSymbols.Add(ch);
                }
            }
            char[] seps = separateSymbols.ToArray();
            List<string> separators = input.Split(seps).ToList();
            separators.RemoveAll(string.IsNullOrEmpty);

            words.Reverse();

            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i]);
                Console.Write(separators[i]);
            }
            Console.WriteLine();

        }
    }
}
