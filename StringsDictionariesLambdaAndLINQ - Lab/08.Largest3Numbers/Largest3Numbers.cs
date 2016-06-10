using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Console.ReadLine().Split(' ').Select(Int32.Parse).OrderByDescending(x => x).Take(3)));
            
        }
    }
}
