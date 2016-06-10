using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PalindromeIndex
{
    class PalindromeIndex
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (ChekPalindome(input.ToCharArray().ToList()))
            {
                Console.WriteLine("-1");
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    List<char> test = input.ToCharArray().ToList();
                    test.RemoveAt(i);

                    if (ChekPalindome(test))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }


        private static bool ChekPalindome(List<char> word)
        {
            bool isPalindome = true;
            for (int i = 0; i < word.Count / 2; i++)
            {
                if (word[i] != word[word.Count - 1 - i])
                {
                    isPalindome = false;
                    break;
                }
            }
            return isPalindome;
        }
    }
}
