using System;
using System.Linq;

namespace _05MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            string string1 = strings[0];
            string string2 = strings[1];
            bool isMagicExchengeable = CheckIfMagicExchengeable(string1, string2);
            Console.WriteLine(isMagicExchengeable.ToString().ToLower());
        }

        static bool CheckIfMagicExchengeable(string string1, string string2)
        {
            char[] charArr1 = string1.ToCharArray().Distinct().ToArray();
            char[] charArr2 = string2.ToCharArray().Distinct().ToArray();
            bool isMagicExchengeable = charArr1.Length == charArr2.Length;

            return isMagicExchengeable;
        }
    }
}
