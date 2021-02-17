using System;

namespace _03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double priceRoom = 0.0;
            double pricePackage = 0.0;
            double discount = 0.0;
            double price = 0.0;
            double pricePerPerson = 0.0;
            string room = string.Empty;
            bool isGroupSize = true;

            if (groupSize > 0 && groupSize <= 50)
            {
                room = "Small Hall";
                priceRoom = 2500.0;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                room = "Terrace";
                priceRoom = 5000.0;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                room = "Great Hall";
                priceRoom = 7500.0;
            }
            else if (groupSize > 120)
            {
                isGroupSize = false;
            }

            switch (package)
            {
                case "Normal":
                    pricePackage = 500;
                    discount = (priceRoom + pricePackage) * 0.05;
                    break;
                case "Gold":
                    pricePackage = 750;
                    discount = (priceRoom + pricePackage) * 0.1;
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discount = (priceRoom + pricePackage) * 0.15;
                    break;
            }

            price = (priceRoom + pricePackage) - discount;
            pricePerPerson = price / groupSize;

            if (isGroupSize == false)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {room}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

        }
    }
}
