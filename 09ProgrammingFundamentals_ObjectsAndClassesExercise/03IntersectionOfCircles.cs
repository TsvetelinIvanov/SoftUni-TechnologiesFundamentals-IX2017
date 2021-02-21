using System;
using System.Linq;

namespace _03IntersectionOfCircles
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class Circle
    {
        public Point Centre { get; set; }
        public double Radius { get; set; }        
    }

    class Program
    {        
        static void Main(string[] args)
        {
            double[] circleInfo1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] circleInfo2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Point centre1 = ReadPoint(circleInfo1);
            Point centre2 = ReadPoint(circleInfo2);
            Circle circle1 = ReadCircle(centre1, circleInfo1);
            Circle circle2 = ReadCircle(centre2, circleInfo2);
            bool isIntersect = CheckIntersect(circle1, circle2);
            if (isIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static Point ReadPoint(double[] pointInfo)
        {           
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }

        static Circle ReadCircle(Point centre, double[] pointInfo)
        {
            Circle circle = new Circle();
            circle.Centre = centre;
            circle.Radius = pointInfo[2];

            return circle;
        }

        public static bool CheckIntersect(Circle circle1, Circle circle2)
        {
            double distance = CalculateDistance(circle1.Centre, circle2.Centre);            
            bool isIntersect = distance <= circle1.Radius + circle2.Radius;

            return isIntersect;
        }

        public static double CalculateDistance(Point centre1, Point centre2)
        {
            double deltaX = centre2.X - centre1.X;
            double deltaY = centre2.Y - centre1.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }
    }
}
