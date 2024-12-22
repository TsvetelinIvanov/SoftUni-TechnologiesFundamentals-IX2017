using System;

namespace _02ChooseADrinkWithPrice
    {
        class Program
        {
            static void Main(string[] args)
            {
                string profession = Console.ReadLine();
                int quantity = int.Parse(Console.ReadLine());
                
                string drink = string.Empty;
                double price = 0.0;
                switch (profession)
                {
                    case "Athlete":
                        drink = "Water";
                        price = 0.70;
                        break;
                    case "Businessman":
                    case "Businesswoman":
                        drink = "Coffee";
                        price = 1.00;
                        break;
                    case "SoftUni Student":
                        drink = "Beer";
                        price = 1.70;
                        break;
                    default:
                        drink = "Tea";
                        price = 1.20;
                        break;
                }
                
                double totalPrice = price * quantity;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
        }
    }
