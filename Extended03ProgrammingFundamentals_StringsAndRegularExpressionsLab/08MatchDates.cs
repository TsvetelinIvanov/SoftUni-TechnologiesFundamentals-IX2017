using System;
using System.Text.RegularExpressions;

namespace _08MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {                             
            string pattern = @"\b(?<day>\d{2})([-\.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string datesString = Console.ReadLine();
            MatchCollection dates = Regex.Matches(datesString, pattern);
            foreach (Match date in dates)
            {                
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
                //Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
                //Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", date.Groups["day"].Value, date.Groups["month"].Value, date.Groups["year"].Value); 
                //string day = date.Groups["day"].Value;
                //string month = date.Groups["month"].Value;
                //string year = date.Groups["year"].Value;
                //Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
