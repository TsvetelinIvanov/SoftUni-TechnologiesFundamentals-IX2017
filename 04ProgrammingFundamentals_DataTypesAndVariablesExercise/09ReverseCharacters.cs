using System;

namespace _09ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastLetter = char.Parse(Console.ReadLine());
            char middleLetter = char.Parse(Console.ReadLine());
            char firstletter = char.Parse(Console.ReadLine());
            string letters = "" + firstletter + middleLetter + lastLetter;
            Console.WriteLine(letters);
           // Console.WriteLine($"{firstletter}{middleLetter}{lastLetter}");
        }
    }
}
