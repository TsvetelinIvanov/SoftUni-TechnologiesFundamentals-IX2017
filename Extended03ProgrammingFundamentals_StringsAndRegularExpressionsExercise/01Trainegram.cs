using System;
using System.Text.RegularExpressions;

namespace _01Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*]\.)*$";
            string train = Console.ReadLine();
            while (train != "Traincode!")
            {
                if (Regex.IsMatch(train, pattern))
                {
                    Console.WriteLine(train);
                }

                train = Console.ReadLine();
            }
        }
    }
}
