using System;

namespace _04BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100 = int.Parse(Console.ReadLine());
            int sugarContentPer100 = int.Parse(Console.ReadLine());

            double energyContentPerVolume = (double)volume * energyContentPer100 / 100.0;
            double sugarContentPerVolume = (double)volume * sugarContentPer100 / 100.0;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energyContentPerVolume, sugarContentPerVolume);
        }
    }
}
