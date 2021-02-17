using System;

namespace _19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int takedPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int percentFilteredPictures = int.Parse(Console.ReadLine());
            int uploadingTime = int.Parse(Console.ReadLine());

            int filteredPictures = (int)(Math.Ceiling(takedPictures * (percentFilteredPictures / 100.0)));
            long totalTimeInSeconds = takedPictures * (long)filterTime + filteredPictures * (long)uploadingTime;       

            long totalMinutes = totalTimeInSeconds / 60;
            long seconds = totalTimeInSeconds % 60;
            long totalHours = totalMinutes / 60;
            long minutes = totalMinutes % 60;
            long hours = totalHours % 24;
            long days = totalHours / 24;

            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");

            //or with TimeSpan:
            //Console.WriteLine(TimeSpan.FromSeconds(totalTimeInSeconds).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
        }
    }
}
