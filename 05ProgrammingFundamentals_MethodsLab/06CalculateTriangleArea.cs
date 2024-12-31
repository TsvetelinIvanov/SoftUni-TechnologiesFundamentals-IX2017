using System;

namespace _06CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            
            double area = GetTriangleArea(a, h);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
