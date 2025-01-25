using System;

namespace _01SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double disposableMoney = double.Parse(Console.ReadLine());
            int guestCount = int.Parse(Console.ReadLine());
            double priceForBanana = double.Parse(Console.ReadLine());
            double priceForEgg = double.Parse(Console.ReadLine());
            double priceForKiloBerries = double.Parse(Console.ReadLine());

            int portionSetsCount = guestCount / 6;
            if (guestCount % 6 > 0)
            {
                setsOfPortions++;
            }

            double neededMoney = portionSetsCount * (2 * priceForBanana) + portionSetsCount * (4 * priceForEgg) +
                portionSetsCount * (0.2 * priceForKiloBerries);            
            if (neededMoney <= disposableMoney)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", neededMoney);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededMoney - disposableMoney); 
            }
        }
    }
}
