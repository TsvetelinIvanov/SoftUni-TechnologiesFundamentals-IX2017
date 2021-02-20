using System;

namespace LongerLineIX
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            FindLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void FindLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double lineOneX = Math.Abs(x2 - x1);
            double lineOneY = Math.Abs(y2 - y1);
            double lineTwoX = Math.Abs(x4 - x3);
            double lineTwoY = Math.Abs(y4 - y3);

            double lineOne = Math.Abs(Math.Sqrt(lineOneX * lineOneX + lineOneY * lineOneY));
            double lineTwo = Math.Abs(Math.Sqrt(lineTwoX * lineTwoX + lineTwoY * lineTwoY));

            if (lineOne >= lineTwo)
            {
                PrintClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestPoint(x3, y3, x4, y4);
            }
        }

        static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double hypotenuseOne = Math.Abs(Math.Sqrt(x1 * x1 + y1 * y1));
            double hypotenuseTwo = Math.Abs(Math.Sqrt(x2 * x2 + y2 * y2));
            if (hypotenuseOne <= hypotenuseTwo)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
