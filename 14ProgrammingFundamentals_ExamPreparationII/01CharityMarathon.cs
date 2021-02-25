using System;


namespace _01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonLengthInDays = int.Parse(Console.ReadLine());
            int volunteerForRuners = int.Parse(Console.ReadLine());
            int averageLapsByRuner = int.Parse(Console.ReadLine());
            int trackLengthInMeters = int.Parse(Console.ReadLine());
            int trackCapacityPerDay = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            long trackCapacity = (long)marathonLengthInDays * trackCapacityPerDay;
            long runers = 0;
            if (trackCapacity <= volunteerForRuners)
            {
                runers = trackCapacity;
            }
            else
            {
                runers = volunteerForRuners;
            }

            long totalMeters = runers * averageLapsByRuner * trackLengthInMeters;
            long totalKilometers = totalMeters / 1000;
            double raisedMoney = moneyPerKilometer * totalKilometers;
            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}
