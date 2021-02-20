using System;

namespace _15SubstringDebbuging
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char search = 'p';
            bool hasMatch = false;

            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (text[i] == search)
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
