using System;

namespace _01HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlapsCount = int.Parse(Console.ReadLine());
            double distanceFor1000WingFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            
            double distance = (wingFlapsCount / 1000) * distanceFor1000WingFlaps;
            long seconds = (wingFlapsCount / 100) + ((wingFlapsCount / endurance) * 5);
            
            Console.WriteLine("{0:f2} m.", distance);
            Console.WriteLine(seconds + " s.");
        }
    }
}
