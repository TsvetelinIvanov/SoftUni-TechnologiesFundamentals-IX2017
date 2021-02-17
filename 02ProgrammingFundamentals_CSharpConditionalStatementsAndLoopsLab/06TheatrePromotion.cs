using System;

namespace _06TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int pticeChildren = 0;
            int pticeAdults = 0;
            int pticeSeniors = 0;

            switch (day)
            {
                case "weekday":
                    pticeChildren = 12;
                    pticeAdults = 18;
                    pticeSeniors = 12;
                    break;
                case "weekend":
                    pticeChildren = 15;
                    pticeAdults = 20;
                    pticeSeniors = 15;
                    break;
                case "holiday":
                    pticeChildren = 5;
                    pticeAdults = 12;
                    pticeSeniors = 10;
                    break;
            }

            if (0 <= age && age <= 18)
            {
                Console.WriteLine($"{pticeChildren}$");
            }
            else if (age > 18 && age <= 64)
            {
                Console.WriteLine($"{pticeAdults}$");
            }
            else if (age > 64 && age <= 122)
            {
                Console.WriteLine($"{pticeSeniors}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
