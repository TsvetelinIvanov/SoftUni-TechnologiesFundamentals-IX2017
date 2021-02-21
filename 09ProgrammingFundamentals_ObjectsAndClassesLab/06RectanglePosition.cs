using System;
using System.Collections.Generic;
using System.Linq;

namespace _06RectanglePosition
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Hight { get; set; }
        public int Right { get { return Left + Width; } }
        public int Bottom { get { return Top + Hight; } }

        public bool IsInside(Rectangle other)
        {
            bool isInLeft = Left >= other.Left;
            bool isInRight = Right <= other.Right;
            bool isInTop = Top >= other.Top;
            bool isInBottom = Bottom <= other.Bottom;

            bool isInsideHorizontal = isInLeft && isInRight;
            bool isInsideVertical = isInTop && isInBottom;
            bool isInside = isInsideHorizontal && isInsideVertical;

            return isInside;
        }       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = ReadRectangle();
            Rectangle rectangle2 = ReadRectangle();

            if (rectangle1.IsInside(rectangle2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static Rectangle ReadRectangle()
        {
            IEnumerable<int> size = Console.ReadLine().Split().Select(int.Parse);
            Rectangle rectangle = new Rectangle()
            {
                Left = size.First(),
                Top = size.Skip(1).First(),
                Width = size.Skip(2).First(),
                Hight = size.Skip(3).First()
            };

            return rectangle;
        }        
    }
}
