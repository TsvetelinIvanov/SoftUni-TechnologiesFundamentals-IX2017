using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            Dictionary<string, List<long>> teams = new Dictionary<string, List<long>>();
            
            string command = Console.ReadLine();
            while (command.ToLower() != "final")
            {
                string[] teamsInfo = command.Split(' ');
                string decryptedHomeTeam = teamsInfo[0];
                int startIndex = decryptedHomeTeam.IndexOf(key);
                int endIndex = decryptedHomeTeam.LastIndexOf(key);
                string homeTeam = decryptedHomeTeam.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] homeTeamArray = homeTeam.ToUpper().ToCharArray();
                Array.Reverse(homeTeamArray);
                homeTeam = new string(homeTeamArray);

                string decryptedAwayTeam = teamsInfo[1];
                startIndex = decryptedAwayTeam.IndexOf(key);
                endIndex = decryptedAwayTeam.LastIndexOf(key);
                string awayTeam = decryptedAwayTeam.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] awayTeamArray = awayTeam.ToUpper().ToCharArray();
                Array.Reverse(awayTeamArray);
                awayTeam = new string(awayTeamArray);

                long[] goals = teamsInfo[2].Split(':').Select(long.Parse).ToArray();
                long homeTeamGoalsCount = goals[0];
                long awayTeamGoalsCount = goals[1];

                long homeTeamPointsCount;
                long awayTeamPointsCount;
                if (homeTeamGoalsCount > awayTeamGoalsCount)
                {
                    homeTeamPointsCount = 3;
                    awayTeamPointsCount = 0;
                }
                else if (homeTeamGoalsCount < awayTeamGoalsCount)
                {
                    homeTeamPointsCount = 0;
                    awayTeamPointsCount = 3;
                }
                else
                {
                    homeTeamPointsCount = 1;
                    awayTeamPointsCount = 1;
                }

                if (teams.ContainsKey(homeTeam))
                {
                    teams[homeTeam][0] += homeTeamPointsCount;
                    teams[homeTeam][1] += homeTeamGoalsCount;
                }
                else
                {
                    teams[homeTeam] = new List<long>();
                    teams[homeTeam].Add(homeTeamPointsCount);
                    teams[homeTeam].Add(homeTeamGoalsCount);
                }

                if (teams.ContainsKey(awayTeam))
                {
                    teams[awayTeam][0] += awayTeamPointsCount;
                    teams[awayTeam][1] += awayTeamGoalsCount;
                }
                else
                {
                    teams[awayTeam] = new List<long>();
                    teams[awayTeam].Add(awayTeamPointsCount);
                    teams[awayTeam].Add(awayTeamGoalsCount);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            int counter = 1;
            foreach (KeyValuePair<string, List<long>> team in teams.OrderByDescending(t => t.Value[0]).ThenBy(t => t.Key))
            {
                Console.WriteLine("{0}. {1} {2}", counter, team.Key, team.Value[0]);
                counter++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (KeyValuePair<string, List<long>> team in teams.OrderByDescending(t => t.Value[1]).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value[1]);
            }
        }
    }
}
