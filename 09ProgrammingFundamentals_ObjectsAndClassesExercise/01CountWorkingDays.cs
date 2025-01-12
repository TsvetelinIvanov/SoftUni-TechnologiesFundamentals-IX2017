using System;
using System.Globalization;
using System.Linq;

namespace _01CountWorkingDays
{
    class Program
    {        
        static void Main(string[] args)
        {
            string startDateString = Console.ReadLine();
            string endDateString = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(startDateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            
            DateTime[] holidays = new DateTime[11];
            holidays[0] = new DateTime(01, 01, 1);
            holidays[1] = new DateTime(03, 03, 1);
            holidays[2] = new DateTime(01, 05, 1);
            holidays[3] = new DateTime(06, 05, 1);
            holidays[4] = new DateTime(24, 05, 1);
            holidays[5] = new DateTime(06, 09, 1);
            holidays[6] = new DateTime(22, 09, 1);
            holidays[7] = new DateTime(01, 11, 1);
            holidays[8] = new DateTime(24, 12, 1);
            holidays[9] = new DateTime(25, 12, 1);
            holidays[10] = new DateTime(26, 12, 1);

            int workingDaysCounter = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1)) 
            {
                DayOfWeek currentDay = date.DayOfWeek;
                DateTime currentDate = new DateTime(date.Day, date.Month, 1);
                if (!holidays.Contains(currentDate) && !currentDay.Equals(DayOfWeek.Saturday) && !currentDay.Equals(DayOfWeek.Sunday))
                {
                    workingDaysCounter++;
                }
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}
