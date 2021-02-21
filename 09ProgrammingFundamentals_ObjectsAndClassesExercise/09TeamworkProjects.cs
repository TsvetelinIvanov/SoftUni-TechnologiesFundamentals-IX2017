using System;
using System.Collections.Generic;
using System.Linq;

namespace _09TeamworkProjects
{    
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamCount; i++)
            {
                string[] creatingTeams = Console.ReadLine().Split('-');
                string creator = creatingTeams[0];
                string teamName = creatingTeams[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine("Team {0} was already created!", teamName);

                    continue;
                }

                if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine("{0} cannot create another team!", creator);

                    continue;
                }

                Console.WriteLine("Team {0} has been created by {1}!", teamName, creator);
                Team team = new Team();
                team.Name = teamName;
                team.Creator = creator;
                team.Members = new List<string>();

                teams.Add(team);
            }

            string teamMemberString = string.Empty;
            while ((teamMemberString = Console.ReadLine()) != "end of assignment")
            {
                string[] teamMember = teamMemberString.Split(new string[] { "->" }, StringSplitOptions.None);
                string member = teamMember[0];
                string wishedTeam = teamMember[1];

                if (!teams.Any(t => t.Name == wishedTeam))
                {
                    Console.WriteLine("Team {0} does not exist!", wishedTeam);

                    continue;
                }

                if (teams.Any(t => t.Creator == member) || teams.Any(t => t.Members.Contains(member)))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", member, wishedTeam);

                    continue;
                }

                Team team = teams.Single(t => t.Name == wishedTeam);
                team.Members.Add(member);
               // teams.Single(t => t.Name == wishedTeam).Members.Add(member);                
            }

            List<Team> disbanddedTeams = new List<Team>();
            foreach (Team team in teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine(team.Name);
                    Console.WriteLine("- " + team.Creator);
                    foreach (string member in team.Members.OrderBy(m => m))
                    {
                        Console.WriteLine("-- " + member);
                    }
                }
                else
                {
                    disbanddedTeams.Add(team);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbanddedTeams)
            {
                Console.WriteLine(team.Name);
            }

            //foreach (var team in teams.OrderBy(t => t.Name))
            //{
            //    if (team.Members.Count == 0)
            //    {
            //        Console.WriteLine(team.Name);
            //    }
            //}
        }
    }
}
