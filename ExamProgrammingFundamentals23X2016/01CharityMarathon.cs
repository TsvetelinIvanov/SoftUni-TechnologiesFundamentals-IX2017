using System;

namespace _01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonLengthInDaysCount = int.Parse(Console.ReadLine());
            int volunteerForRunersCount = int.Parse(Console.ReadLine());
            int averageLapsByRuner = int.Parse(Console.ReadLine());
            int trackLengthInMetersCount = int.Parse(Console.ReadLine());
            int trackCapacityPerDay = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            long trackCapacity = (long)marathonLengthInDaysCount * trackCapacityPerDay;
            long runersCount = 0;
            if (trackCapacity <= volunteerForRunersCount)
            {
                runersCount = trackCapacity;
            }
            else
            {
                runersCount = volunteerForRunersCount;
            }

            long totalMeters = runersCount * averageLapsByRuner * trackLengthInMetersCount;
            long totalKilometers = totalMeters / 1000;
            double raisedMoney = moneyPerKilometer * totalKilometers;

            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}
