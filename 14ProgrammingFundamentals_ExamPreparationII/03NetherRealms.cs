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
            string[] demonNames = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string demonName in demonNames)
            {
                int demonHealth = GetDemonHealth(demonName);
                double demonDamage = GetDemonDamage(demonName);
                string demonStats = $" - {demonHealth} health, {demonDamage:f2} damage";
                if (!demons.ContainsKey(demonName))
                {
                    demons[demonName] = demonStats;
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
            int multiplyings = 0;
            int dividings = 0;
            foreach (Match match in matches)
            {                
                if (match.Value == "*")
                {
                    multiplyings++;
                }
                else if (match.Value == "/")
                {
                    dividings++;
                }
                else
                {
                    damage += double.Parse(match.Value);
                }
            }

            damage *= Math.Pow(2, multiplyings);
            damage /= Math.Pow(2, dividings);

            return damage;
        }        
    }
}
