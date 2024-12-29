using System;

namespace _10CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string wishedParameter = Console.ReadLine();
            
            double findedParameter = 0.0;
            switch (wishedParameter)
            {
                case "face":
                    findedParameter = FindeFaceDiagonal(cubeSide);
                    break;
                case "space":
                    findedParameter = FindeSpaceDiagonal(cubeSide);
                    break;
                case "area":
                    findedParameter = FindeSurfaceArea(cubeSide);
                    break;
                case "volume":
                    findedParameter = FindeCubeVolume(cubeSide);
                    break;
            }

            Console.WriteLine($"{findedParameter:f2}");
        }

        static double FindeFaceDiagonal(double side)
        {
            double faceDiagonal = Math.Sqrt(2 * side * side);
            
            return faceDiagonal;
        }

        static double FindeSpaceDiagonal(double side)
        {
            double spaceDiagonal = Math.Sqrt(3 * side * side);
            
            return spaceDiagonal;
        }

        static double FindeSurfaceArea(double side)
        {
            double surfaceArea = 6 * side * side;
            
            return surfaceArea;
        }

        static double FindeCubeVolume(double side)
        {
            double cubeVolume = side * side * side;
            
            return cubeVolume;
        }
    }
}
