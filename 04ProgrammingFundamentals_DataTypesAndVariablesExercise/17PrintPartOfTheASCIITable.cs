using System;

namespace _17PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            for (char i = (char)firstChar; i <= (char)lastChar; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
