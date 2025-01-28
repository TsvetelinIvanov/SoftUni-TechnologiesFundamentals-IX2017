using System;

namespace _01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonLengthInDaysCount = int.Parse(Console.ReadLine());
            int volunteersCount = int.Parse(Console.ReadLine());
            int averageLapsByRunner = int.Parse(Console.ReadLine());
            int trackLengthInMetersCount = int.Parse(Console.ReadLine());
            int trackCapacityPerDay = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            long trackCapacity = (long)marathonLengthInDaysCount * trackCapacityPerDay;
            long runnersCount = 0;
            if (trackCapacity <= volunteersCount)
            {
                runnersCount = trackCapacity;
            }
            else
            {
                runnersCount = volunteersCount;
            }

            long totalMeters = runnersCount * averageLapsByRunner * trackLengthInMetersCount;
            long totalKilometers = totalMeters / 1000;
            double raisedMoney = moneyPerKilometer * totalKilometers;

            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}
