using System;

namespace _04DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //PrintHeaderFooter(n);
            //for (int i = 0; i < n - 2; i++)
            //{
            //    PrintMiddleRow(n);
            //}
            
            //PrintHeaderFooter(n);
            DrawSquare(input); //Optimization
        }

        static void DrawSquare(int n) //Optimization
        {
            PrintHeaderFooter(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            
            PrintHeaderFooter(n);
        }

        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            
            Console.Write("-");
            Console.WriteLine();
        }        
    }
}
