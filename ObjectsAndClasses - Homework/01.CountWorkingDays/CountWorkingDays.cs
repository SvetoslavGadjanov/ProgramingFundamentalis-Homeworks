using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountWorkingDays
{
    static void Main(string[] args)
    {
        var startDateText = Console.ReadLine();
        var endDateText = Console.ReadLine();

        var startDate = DateTime.ParseExact(startDateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(endDateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                
        DateTime[] holidays = new DateTime[12];

        holidays[0] = new DateTime(endDate.Year, 01, 01);
        holidays[1] = new DateTime(endDate.Year, 03, 03);
        holidays[2] = new DateTime(endDate.Year, 05, 01);
        holidays[3] = new DateTime(endDate.Year, 05, 06);
        holidays[4] = new DateTime(endDate.Year, 05, 24);
        holidays[5] = new DateTime(endDate.Year, 09, 06);
        holidays[6] = new DateTime(endDate.Year, 09, 22);
        holidays[7] = new DateTime(endDate.Year, 11, 01);
        holidays[8] = new DateTime(endDate.Year, 12, 24);
        holidays[9] = new DateTime(endDate.Year, 12, 24);
        holidays[10] = new DateTime(endDate.Year, 12, 25);
        holidays[11] = new DateTime(endDate.Year, 12, 26);

        var workingDayCounter = 0;

        for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            var day = currentDate.DayOfWeek;
            if (!holidays.Contains(currentDate) && !day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday))
            {
                workingDayCounter++;
            }
        }
        Console.WriteLine(workingDayCounter);
    }
}

