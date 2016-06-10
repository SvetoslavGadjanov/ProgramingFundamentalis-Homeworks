using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(2*a + 2*b);
            Console.WriteLine(a*b);

            double diagonal = Math.Sqrt(a * a + b * b);
            Console.WriteLine(diagonal);



        }
    }
}
