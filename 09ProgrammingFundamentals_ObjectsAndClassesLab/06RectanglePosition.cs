using System;
using System.Collections.Generic;
using System.Linq;

namespace _06RectanglePosition
{
    class Rectangle
    {
        public int Left { get; set; }
        
        public int Bottom { get; set; }
        
        public int Width { get; set; }
        
        public int Hight { get; set; }
        
        public int Right 
        {
            get { return Left + Width; }
        }
        
        public int Top
        {
            get { return Bottom + Hight; }
        }

        public bool IsInside(Rectangle otherRectangle)
        {
            bool isInLeft = Left >= otherRectangle.Left;
            bool isInRight = Right <= otherRectangle.Right;
            bool isInBottom = Bottom >= otherRectangle.Bottom;
            bool isInTop = Top <= other.Top;

            bool isInsideHorizontal = isInLeft && isInRight;
            bool isInsideVertical = isInBottom && isInTop;
            bool isInside = isInsideHorizontal && isInsideVertical;

            return isInside;
        }       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = ReadRectangle();
            Rectangle secondRectangle = ReadRectangle();

            if (firstRectangle.IsInside(secondRectangle))
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
                Bottom = size.Skip(1).First(),
                Width = size.Skip(2).First(),
                Hight = size.Skip(3).First()
            };

            return rectangle;
        }        
    }
}
