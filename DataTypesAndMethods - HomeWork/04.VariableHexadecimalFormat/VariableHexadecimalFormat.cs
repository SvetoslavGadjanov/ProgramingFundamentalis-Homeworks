﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableHexadecimalFormat
{
    class VariableHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int converted = Convert.ToInt32(input, 16);
            Console.WriteLine(converted);
        }
    }
}
