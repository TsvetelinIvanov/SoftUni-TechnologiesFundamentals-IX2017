using System;

namespace _05WormTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int wormLengthInMeters = int.Parse(Console.ReadLine());
            double wormWidthInCentimeters = double.Parse(Console.ReadLine());
            double wormLengthInCentimeters = wormLengthInMeters * 100;
            if (wormWidthInCentimeters == 0 || wormLengthInCentimeters % wormWidthInCentimeters == 0)
            {
                Console.WriteLine("{0:f2}", wormLengthInCentimeters * wormWidthInCentimeters);
            }
            else
            {
                Console.WriteLine("{0:f2}%", wormLengthInCentimeters * 100 / wormWidthInCentimeters);
            }
        } 
    }
}
