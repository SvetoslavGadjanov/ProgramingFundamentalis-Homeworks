using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int persons = Int32.Parse(Console.ReadLine());
            int capacity = Int32.Parse(Console.ReadLine());

            if (persons % capacity == 0)
            {
                Console.WriteLine("{0}", persons / capacity);
            }
            else
            {
                Console.WriteLine("{0}", (persons / capacity) + 1);
            }
           


        }
    }
}
