using System;

namespace _01SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double disposeableMoney = double.Parse(Console.ReadLine());
            int guestCount = int.Parse(Console.ReadLine());
            double priceForBanana = double.Parse(Console.ReadLine());
            double priceForEgg = double.Parse(Console.ReadLine());
            double priceForKiloBerries = double.Parse(Console.ReadLine());

            int setsOfPortions = guestCount / 6;
            if (guestCount % 6 > 0)
            {
                setsOfPortions++;
            }

            double neededMoney = setsOfPortions * (2 * priceForBanana) + setsOfPortions * (4 * priceForEgg) +
                setsOfPortions * (0.2 * priceForKiloBerries);            
            if (neededMoney <= disposeableMoney)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", neededMoney);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", 
                    neededMoney - disposeableMoney); 
            }
        }
    }
}
