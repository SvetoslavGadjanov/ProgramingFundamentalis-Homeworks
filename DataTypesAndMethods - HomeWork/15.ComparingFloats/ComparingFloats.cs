using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool isEqual = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(isEqual);

        }
    }
}
