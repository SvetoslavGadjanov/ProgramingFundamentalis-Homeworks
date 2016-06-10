using System;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            char strartLetter = 'a';

            for (int i = 0; i <= n-1; i++)
            {
                for (int j = 0; j <= n-1; j++)
                {
                    for (int k = 0; k <= n-1; k++)
                    {
                        char firstChar = (char)(strartLetter + i);
                        char secondChar = (char)(strartLetter + j);
                        char thirdChar = (char)(strartLetter + k);

                        Console.WriteLine("{0}{1}{2}", firstChar, secondChar, thirdChar);
                    }
                }
            }
        }
    }
}
