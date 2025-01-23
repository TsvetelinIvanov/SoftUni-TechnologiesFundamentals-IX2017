using System;


namespace _01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDurationInDays = int.Parse(Console.ReadLine());
            int volunteersCount = int.Parse(Console.ReadLine());
            int averageLapsByRuner = int.Parse(Console.ReadLine());
            int trackLengthInMeters = int.Parse(Console.ReadLine());
            int trackCapacityPerDay = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            long trackCapacity = (long)marathonDurationInDays * trackCapacityPerDay;
            long runersCount = 0;
            if (trackCapacity <= volunteersCount)
            {
                runersCount = trackCapacity;
            }
            else
            {
                runersCount = volunteersCount;
            }

            long totalDistanceInMeters = runersCount * averageLapsByRuner * trackLengthInMeters;
            long totalDistanceInKilometers = totalDistanceInMeters / 1000;
            double raisedMoney = moneyPerKilometer * totalDistanceInKilometers;
            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}
