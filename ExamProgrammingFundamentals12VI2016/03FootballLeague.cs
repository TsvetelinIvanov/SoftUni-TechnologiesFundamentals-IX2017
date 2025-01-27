using System;
using System.Collections.Generic;
using System.Linq;

namespace _03FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> teamsByPoints = new Dictionary<string, int>();
            Dictionary<string, long> teamsByGoals = new Dictionary<string, long>();
            string key = Console.ReadLine();
            
            string footballInfo = string.Empty;
            while ((footballInfo = Console.ReadLine()) != "final")
            {                
                string[] teamsAndScores = footballInfo.Split(new string[] { key }, StringSplitOptions.None);
                string firstTeam = teamsAndScores[1].ToUpper();
                firstTeam = Reverse(firstTeam);
                
                string secondTeam = teamsAndScores[3].ToUpper();
                secondTeam = Reverse(secondTeam);
                
                string[] scores = teamsAndScores[4].Split(new char[] { ' ', ':' });
                long firstTeamScore = 0;
                long secondTeamScore = 0;
                if (scores.Length == 2)
                {
                    firstTeamScore = long.Parse(scores[0]);
                    secondTeamScore = long.Parse(scores[1]);
                }
                else if (scores.Length == 3)
                {
                    firstTeamScore = long.Parse(scores[1]);
                    secondTeamScore = long.Parse(scores[2]);
                }

                int firstTeamPointsCount = 0;
                int secondTeamPointsCount = 0;
                if (firstTeamScore == secondTeamScore)
                {
                    firstTeamPointsCount = 1;
                    secondTeamPointsCount = 1;
                }
                else if (firstTeamScore > secondTeamScore)
                {
                    firstTeamPointsCount = 3;
                }
                else if (firstTeamScore < secondTeamScore)
                {
                    secondTeamPointsCount = 3;
                }

                if (!teamsByPoints.ContainsKey(firstTeam))
                {
                    teamsByPoints[firstTeam] = 0;
                }

                teamsByPoints[firstTeam] += firstTeamPointsCount;

                if (!teamsByPoints.ContainsKey(secondTeam))
                {
                    teamsByPoints[secondTeam] = 0;
                }

                teamsByPoints[secondTeam] += secondTeamPointsCount;

                if (!teamsByGoals.ContainsKey(firstTeam))
                {
                    teamsByGoals.Add(firstTeam, 0);
                }

                teamsByGoals[firstTeam] += firstTeamScore;

                if (!teamsByGoals.ContainsKey(secondTeam))
                {
                    teamsByGoals.Add(secondTeam, 0);
                }

                teamsByGoals[secondTeam] += secondTeamScore;
            }

            Console.WriteLine("League standings:");
            int place = 0;
            foreach (KeyValuePair<string, int> team in teamsByPoints.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                place++;
                Console.WriteLine("{0}. {1} {2}", place, team.Key, team.Value);
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (KeyValuePair<string, long> team in teamsByGoals.OrderByDescending(t => t.Value).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");                
            }            
        }

        private static string Reverse(string team)
        {
            char[] teamCharacters = team.ToCharArray();
            Array.Reverse(teamCharacters);
            string reversedTeam = string.Empty;
            foreach (char ch in teamCharacters)
            {
                reversedTeam += ch;
            }

            return reversedTeam;
        }
    }
}
