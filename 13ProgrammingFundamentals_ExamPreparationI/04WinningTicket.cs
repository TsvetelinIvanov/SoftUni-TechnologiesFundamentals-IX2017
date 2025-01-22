using System;
using System.Text.RegularExpressions;

namespace _04WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);            
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else if (tickets[i] == "@@@@@@@@@@@@@@@@@@@@")
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - 10@ Jackpot!");
                    continue;
                }
                else if (tickets[i] == "####################")
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - 10# Jackpot!");
                    continue;
                }
                else if (tickets[i] == "$$$$$$$$$$$$$$$$$$$$")
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - 10$ Jackpot!");
                    continue;
                }
                else if (tickets[i] == "^^^^^^^^^^^^^^^^^^^^")
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - 10^ Jackpot!");
                    continue;
                }

                string ticket = tickets[i];
                string left = string.Empty;
                for (int j = 0; j < 10; j++)
                {
                    left += ticket[j];
                }

                string right = string.Empty;
                for (int j = 10; j < 20; j++)
                {
                    right += ticket[j];
                }

                Match macht1Left = Regex.Match(left, "@{6,9}");
                Match macht1Right = Regex.Match(right, "@{6,9}");
                if (macht1Left.Success && macht1Right.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(macht1Left.Length, macht1Right.Length)}@");
                    continue;
                }

                Match macht2Left = Regex.Match(left, "#{6,9}");
                Match macht2Right = Regex.Match(right, "#{6,9}");
                if (macht2Left.Success && macht2Right.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(macht2Left.Length, macht2Right.Length)}#");
                    continue;
                }

                Match macht3Left = Regex.Match(left, "\\${6,9}");
                Match macht3Right = Regex.Match(right, "\\${6,9}");
                if (macht3Left.Success && macht3Right.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(macht3Left.Length, macht3Right.Length)}$");
                    continue;
                }

                Match macht4Left = Regex.Match(left, "\\^{6,9}");
                Match macht4Right = Regex.Match(right, "\\^{6,9}");
                if (macht4Left.Success && macht4Right.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(macht4Left.Length, macht4Right.Length)}^");
                    continue;
                }

                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}
