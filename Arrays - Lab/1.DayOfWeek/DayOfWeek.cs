using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


            if (input >= 1 && input<= 7)
            {
                Console.WriteLine(daysOfWeek[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
