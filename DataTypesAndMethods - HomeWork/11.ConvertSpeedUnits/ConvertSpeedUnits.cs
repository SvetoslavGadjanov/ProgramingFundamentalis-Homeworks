using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distance = Int32.Parse(Console.ReadLine());
            int hours = Int32.Parse(Console.ReadLine());
            int minutes = Int32.Parse(Console.ReadLine());
            int seconds = Int32.Parse(Console.ReadLine());

            int time = seconds + minutes * 60 + hours * 3600;
          
            float ms = (float)distance / (float)time;
            float kmh = ((float)distance / 1000F) / ((float)time / 3600F);
            float mph = ((float)distance / 1609F) / ((float)time / 3600F);


            Console.WriteLine(ms);
            Console.WriteLine(kmh);
            Console.WriteLine(mph);

           
        }
    }
}
