using System;

class PriceChangeAlert
{
    static void Main()
    {
        int pricesNumber = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());        

        for (int i = 0; i < pricesNumber - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double difference = GetDifference(lastPrice, currentPrice);
            bool isSignificantDifference = IsSignificantDifference(difference, treshold);
            string message = MakeMessage(currentPrice, lastPrice, difference, isSignificantDifference);

            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static double GetDifference(double firstPrice, double nextPrice)
    {
        double difference = (nextPrice - firstPrice) / firstPrice;
        
        return difference;
    }

    private static bool IsSignificantDifference(double treshold, double difference)
    {
        if (Math.Abs(treshold) >= difference)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static string MakeMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
    {
        string message = string.Empty;
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }

        return message;
    }
}
