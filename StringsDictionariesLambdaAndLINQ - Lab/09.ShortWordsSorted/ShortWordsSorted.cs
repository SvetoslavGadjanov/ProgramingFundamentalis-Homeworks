﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] separators = " .,:;()[]\"'\\/!?".ToCharArray();
            var words = Console.ReadLine().ToLower().Split(separators);

            var result = words
                .Where(w => w != "")
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct();

            Console.WriteLine(String.Join(", ", result));

        }
    }
}
