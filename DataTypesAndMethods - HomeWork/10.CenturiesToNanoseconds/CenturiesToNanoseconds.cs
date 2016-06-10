using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            
            int cent = int.Parse(Console.ReadLine());
            int years = cent * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            BigInteger seconds = (long)minutes * 60L;
            BigInteger milisecond = seconds * 1000;
            BigInteger microseconds = milisecond * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                cent,
                years,
                days,
                hours,
                minutes,
                seconds,
                milisecond,
                microseconds,
                nanoseconds);
        }
    }
}
