using System;

namespace _11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            double area = 0.0;
            switch (figure)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    area = GetTriangleArea(triangleSide, triangleHeight);
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    area = GetRectangleArea(rectangleWidth, rectangleHeight);
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());                    
                    area = GetSquareArea(squareSide);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());                    
                    area = GetCircleArea(radius);
                    break;
            }

            Console.WriteLine($"{area:f2}");
        }

        static double GetTriangleArea(double side, double height)
        {
            return side * height / 2;
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double GetSquareArea(double side)
        {
            return side * side;
        }

        static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
