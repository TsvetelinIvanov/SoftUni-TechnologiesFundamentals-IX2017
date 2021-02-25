using System;

namespace _01SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        { 
            string startTimeString = Console.ReadLine();
            int steps = int.Parse(Console.ReadLine()) % 86400; //to rotate one or more days (86400 is count of seconds per one day)
            int secondsPerStep = int.Parse(Console.ReadLine()) %86400; //to rotate one or more days
            long timeInSeconds = (long)steps * secondsPerStep;
            
            TimeSpan startTime = TimeSpan.Parse(startTimeString);
            TimeSpan finishTime = startTime.Add(TimeSpan.FromSeconds(timeInSeconds));
            Console.WriteLine("Time Arrival: " + finishTime.ToString(@"hh\:mm\:ss"));
        }
    }
}
