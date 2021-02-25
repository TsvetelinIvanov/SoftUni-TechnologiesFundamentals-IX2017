using System;

namespace _01ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            string reversedStr = new String(charArr);
            Console.WriteLine(reversedStr);
        }
    }
}
