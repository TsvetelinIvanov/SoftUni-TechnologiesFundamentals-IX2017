using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> demons = new SortedDictionary<string, string>();
            string[] demonNames = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string demonName in demonNames)
            {
                int demonHealth = GetDemonHealth(demonName);
                double demonDamage = GetDemonDamage(demonName);
                string demonStatsString = $" - {demonHealth} health, {demonDamage:f2} damage";
                if (!demons.ContainsKey(demonName))
                {
                    demons[demonName] = demonStatsString;
                }
            }

            foreach (KeyValuePair<string, string> demon in demons)
            {
                Console.WriteLine(demon.Key + demon.Value);
            }
        }

        private static int GetDemonHealth(string demonName)
        {
            string pattern = @"[^\d+\-*\/.]+";
            MatchCollection matches = Regex.Matches(demonName, pattern);
            string healthString = string.Empty;
            foreach (Match match in matches)
            {
                healthString += match;
            }

            int health = 0;
            foreach (char ch in healthString)
            {
                health += ch;
            }

            return health;
        }

        private static double GetDemonDamage(string demonName)
        {
            string pattern = @"([+-]?\d+(\.\d+)?)|(\*)|(\/)";
            MatchCollection matches = Regex.Matches(demonName, pattern);
            double damage = 0.0;
            int multiplyingsCount = 0;
            int dividingsCount = 0;
            foreach (Match match in matches)
            {
                if (match.Value == "*")
                {
                    multiplyingsCount++;
                }
                else if (match.Value == "/")
                {
                    dividingsCount++;
                }
                else
                {
                    damage += double.Parse(match.Value);
                }
            }

            damage *= Math.Pow(2, multiplyingsCount);
            damage /= Math.Pow(2, dividingsCount);

            return damage;
        }        
    }
}
