using System;

namespace _06TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            
            int childrenPrice = 0;
            int adultsPrice = 0;
            int seniorsPrice = 0;
            switch (day)
            {
                case "weekday":
                    childrenPrice = 12;
                    adultsPrice = 18;
                    seniorsPrice = 12;
                    break;
                case "weekend":
                    childrenPrice = 15;
                    adultsPrice = 20;
                    seniorsPrice = 15;
                    break;
                case "holiday":
                    childrenPrice = 5;
                    adultsPrice = 12;
                    seniorsPrice = 10;
                    break;
            }

            if (0 <= age && age <= 18)
            {
                Console.WriteLine($"{childrenPrice}$");
            }
            else if (age > 18 && age <= 64)
            {
                Console.WriteLine($"{adultsPrice}$");
            }
            else if (age > 64 && age <= 122)
            {
                Console.WriteLine($"{seniorsPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
