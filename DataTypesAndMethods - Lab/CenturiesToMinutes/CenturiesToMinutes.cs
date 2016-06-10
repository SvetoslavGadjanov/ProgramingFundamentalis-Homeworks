using System;

namespace CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            int cent = int.Parse(Console.ReadLine());
            int years = cent * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine("{0} senturies = {1} years = {2} days = {3} hours = {4} minutes", cent, years, days, hours, minutes);

        }
    }
}
