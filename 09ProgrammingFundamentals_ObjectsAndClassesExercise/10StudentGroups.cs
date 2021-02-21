using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Town> towns = ReadTownsAndStudents();
            List<Group> groups = DistributStudentsInToGroups(towns);
            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Count);
            foreach (Group group in groups)
            {
                Console.WriteLine(group.Town.Name + " => " 
                    + string.Join(", ", group.Students.Select(g => g.Email)));
            }
        }        

        private static List<Town> ReadTownsAndStudents()
        {
            List<Town> towns = new List<Town>();
            int counter = -1;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("=>"))
                {
                    string[] townAndSeats = input.Split(new string[] { "=>" }, StringSplitOptions.None);
                    string townName = townAndSeats[0].Trim();
                    int seatsCount = int.Parse(townAndSeats[1].Trim().Split().First());

                    Town town = new Town();
                    town.Name = townName;
                    town.SeatsCount = seatsCount;
                    town.Students = new List<Student>();

                    towns.Add(town);
                    counter++;
                }
                else if (input.Contains("|"))
                {
                    string[] studentInfo = input.Split('|');
                    string studentName = studentInfo[0].Trim();
                    string studentEmail = studentInfo[1].Trim();
                    DateTime date = DateTime.ParseExact(studentInfo[2].Trim(), 
                        "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Student student = new Student();
                    student.Name = studentName;
                    student.Email = studentEmail;
                    student.Date = date;

                    towns[counter].Students.Add(student);
                }                
            }

            return towns;
        }

        private static List<Group> DistributStudentsInToGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();
            foreach (Town town in towns.OrderBy(t => t.Name))
            {
                List<Student> students = town.Students
                    .OrderBy(t => t.Date).ThenBy(t => t.Name).ThenBy(t => t.Email).ToList();
                while (students.Count > 0)
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount).ToList();
                    groups.Add(group);
                }
            }

            return groups;
        }
    }
}
