using System;
using System.Globalization;

namespace _01SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < ordersCount; i++)
            {
                decimal price = ProcessOrder();
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

        private static decimal ProcessOrder()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal daysInMoth = DateTime.DaysInMonth(date.Year, date.Month);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());

            decimal price = (daysInMoth * capsulesCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");

            return price;
        }
    }
}
