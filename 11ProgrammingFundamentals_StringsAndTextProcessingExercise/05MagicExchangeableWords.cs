using System;
using System.Linq;

namespace _05MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstString = strings[0];
            string secondString = strings[1];
            
            bool isMagicExchengeable = CheckIfMagicExchengeable(firstString, secondString);
            Console.WriteLine(isMagicExchengeable.ToString().ToLower());
        }

        static bool CheckIfMagicExchengeable(string firstString, string secondString)
        {
            char[] firstCharArray = firstString.ToCharArray().Distinct().ToArray();
            char[] secondCharArray = secondString.ToCharArray().Distinct().ToArray();
            bool isMagicExchengeable = firstCharArray.Length == secondCharArray.Length;

            return isMagicExchengeable;
        }
    }
}
