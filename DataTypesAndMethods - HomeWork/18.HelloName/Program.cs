using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Greating(name);
        }

        private static void Greating(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
