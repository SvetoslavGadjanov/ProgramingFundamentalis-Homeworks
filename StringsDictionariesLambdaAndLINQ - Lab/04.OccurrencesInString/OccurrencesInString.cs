using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OccurrencesInString
{
    class OccurrencesInString
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var w = Console.ReadLine().ToLower();

            int startPos = 0;
            int count = 0;
            while (true)
            {
                int pos = text.IndexOf(w, startPos);
                if (pos == -1)
                {
                    break;
                }
                count++;
                startPos = pos + 1;
            }

            Console.WriteLine(count);
        }
    }
}
