using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] pattern = new char[] {' ', ',', '.', '?', '!'};

            string[] words = input.Split(pattern).ToArray();
            List<string> palindroms = new List<string>();

            foreach (string word in words)
            {
                if (IsPalindome(word) && !palindroms.Contains(word))
                {
                    palindroms.Add(word);
                }
            }
            palindroms.Sort();
            palindroms.RemoveAll(String.IsNullOrEmpty);

            Console.WriteLine(String.Join(", ", palindroms));


        }

        private static bool IsPalindome(string word)
        {
            bool isPalindome = true;
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindome = false;
                    break;
                } 
            }
            return isPalindome;
        }
    }
}
