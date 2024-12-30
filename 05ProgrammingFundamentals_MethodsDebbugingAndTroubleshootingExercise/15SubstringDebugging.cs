using System;

namespace _15SubstringDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            const char SearchedCharacter = 'p';
            
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());
            
            bool hasMatch = false;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (text[i] == SearchedCharacter)
                {
                    hasMatch = true;
                    int endIndex = jump + 1;
                    string matchedString = string.Empty;
                    if (endIndex + i <= text.Length - 1)
                    {
                        matchedString = text.Substring(i, endIndex);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }

                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
