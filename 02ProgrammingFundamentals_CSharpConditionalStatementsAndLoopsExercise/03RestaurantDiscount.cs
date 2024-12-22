using System;

namespace _03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            
            double roomPrice = 0.0;
            double packagePrice = 0.0;
            double discount = 0.0;
            double price = 0.0;
            double pricePerPerson = 0.0;
            string room = string.Empty;
            bool isGroupSize = true;

            if (groupSize > 0 && groupSize <= 50)
            {
                room = "Small Hall";
                roomPrice = 2500.0;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                room = "Terrace";
                roomPrice = 5000.0;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                room = "Great Hall";
                roomPrice = 7500.0;
            }
            else if (groupSize > 120)
            {
                isGroupSize = false;
            }

            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    discount = (roomPrice + packagePrice) * 0.05;
                    break;
                case "Gold":
                    packagePrice = 750;
                    discount = (roomPrice + packagePrice) * 0.1;
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    discount = (roomPrice + packagePrice) * 0.15;
                    break;
            }

            price = (roomPrice + packagePrice) - discount;
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
