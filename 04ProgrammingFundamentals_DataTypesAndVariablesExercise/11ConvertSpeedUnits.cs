using System;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            
            float kilometers = meters / 1000;
            float miles = meters / 1609;

            float metersPerSecond = meters / ((3600 * hours) + (60 * minutes) + seconds);
            float kilometersPerHour = kilometers / (hours + (minutes / 60) + (seconds / 3600));
            float milesPerHour = miles / (hours + (minutes / 60) + (seconds / 3600));

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
