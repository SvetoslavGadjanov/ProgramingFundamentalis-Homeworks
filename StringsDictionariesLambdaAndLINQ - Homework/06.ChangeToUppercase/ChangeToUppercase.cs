using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ChangeToUppercase
{
    class ChangeToUppercase
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string startTag = "<upcase>";
            string endTag = "</upcase>";

            while (input.Contains(startTag))
            {
                int startIndex = input.IndexOf(startTag);
                int length = input.IndexOf(endTag) - input.IndexOf(startTag) + endTag.Length;

                string strToReplace = input.Substring(startIndex, length);
                string upperCase = strToReplace.Substring(startTag.Length, strToReplace.Length - startTag.Length - endTag.Length).ToUpper();

                input = input.Replace(strToReplace, upperCase);
            }

            Console.WriteLine(input);

            
        }
    }
}
