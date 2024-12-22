using System;

namespace _04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            
            double studioNightPrice = 0.0;
            double doubleNightPrice = 0.0;
            double suiteNightPrice = 0.0;
            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;
            
            switch (month)
            {
                case "May":                    
                case "October":
                    studioNightPrice = 50.0;
                    doubleNightPrice = 65.0;
                    suiteNightPrice = 75.0;
                    if (nightsCount > 7)
                    {
                        studioNightPrice *= 0.95;
                    }
                    
                    break;
                case "June":
                case "September":
                    studioNightPrice = 60.0;
                    doubleNightPrice = 72.0;
                    suiteNightPrice = 82.0;
                    if (nightsCount > 14)
                    {
                        doubleNightPrice *= 0.90;
                    }
                    
                    break;
                case "July":                    
                case "August":                    
                case "December":
                    studioNightPrice = 68.0;
                    doubleNightPrice = 77.0;
                    suiteNightPrice = 89.0;
                    if (nightsCount > 14)
                    {
                        suiteNightPrice *= 0.85;
                    }
                    
                    break;                
            }

            studioPrice = studioNightPrice * nightsCount;
            doublePrice = doubleNightPrice * nightsCount;
            suitePrice = suiteNightPrice * nightsCount;

            if (nightsCount > 7 && (month == "September" || month == "October"))
            {
                studioPrice -= studioNightPrice;
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
