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
                string team1 = teamsAndScores[1].ToUpper();
                team1 = Reverse(team1);
                string team2 = teamsAndScores[3].ToUpper();
                team2 = Reverse(team2);
                string[] scores = teamsAndScores[4].Split(new char[] { ' ', ':'});
                long score1 = 0;
                long score2 = 0;
                if (scores.Length == 2)
                {
                    score1 = long.Parse(scores[0]);
                    score2 = long.Parse(scores[1]);
                }
                else if (scores.Length == 3)
                {
                    score1 = long.Parse(scores[1]);
                    score2 = long.Parse(scores[2]);
                }

                int points1 = 0;
                int points2 = 0;
                if (score1 == score2)
                {
                    points1 = 1;
                    points2 = 1;
                }
                else if (score1 > score2)
                {
                    points1 = 3;
                }
                else if (score1 < score2)
                {
                    points2 = 3;
                }

                if (!teamsByPoints.ContainsKey(team1))
                {
                    teamsByPoints[team1] = 0;
                }

                teamsByPoints[team1] += points1;

                if (!teamsByPoints.ContainsKey(team2))
                {
                    teamsByPoints[team2] = 0;
                }

                teamsByPoints[team2] += points2;

                if (!teamsByGoals.ContainsKey(team1))
                {
                    teamsByGoals.Add(team1, 0);
                }

                teamsByGoals[team1] += score1;

                if (!teamsByGoals.ContainsKey(team2))
                {
                    teamsByGoals.Add(team2, 0);
                }

                teamsByGoals[team2] += score2;
            }

            Console.WriteLine("League standings:");
            int place = 0;
            foreach (KeyValuePair<string, int> team in teamsByPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                place++;
                Console.WriteLine("{0}. {1} {2}", place, team.Key, team.Value);
            }

            List<string> listOfTeamsByGoals = new List<string>();
            foreach (KeyValuePair<string, long> team in teamsByGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string teamAndGoals = $"- {team.Key} -> {team.Value}";
                listOfTeamsByGoals.Add(teamAndGoals);
            }

            Console.WriteLine("Top 3 scored goals:");
            for (int i = 0; i < Math.Min(listOfTeamsByGoals.Count, 3); i++)
            {
                Console.WriteLine(listOfTeamsByGoals[i]);
            }
        }

        private static string Reverse(string team)
        {
            char[] teamChar = team.ToCharArray();
            Array.Reverse(teamChar);
            string reversedTeam = string.Empty;
            foreach (char ch in teamChar)
            {
                reversedTeam += ch;
            }

            return reversedTeam;
        }
    }
}
