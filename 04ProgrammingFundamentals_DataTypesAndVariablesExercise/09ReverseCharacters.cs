using System;

namespace _09ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastLetter = char.Parse(Console.ReadLine());
            char middleLetter = char.Parse(Console.ReadLine());
            char firstLetter = char.Parse(Console.ReadLine());
            
            string letters = "" + firstLetter + middleLetter + lastLetter;
            Console.WriteLine(letters);
           // Console.WriteLine($"{firstletter}{middleLetter}{lastLetter}");
        }
    }
}
