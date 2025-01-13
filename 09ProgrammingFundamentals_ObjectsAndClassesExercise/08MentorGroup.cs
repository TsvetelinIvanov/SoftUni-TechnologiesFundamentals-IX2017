using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        
        public List<string> Comments { get; set; }
        
        public List<DateTime> Dates { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            string datesInfoString = string.Empty;
            while ((datesInfoString = Console.ReadLine()) != "end of dates")
            {
                string[] datesInfo = datesInfoString.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);                
                string name = datesInfo[0];               
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new Student());
                    students[name].Name = name;
                    students[name].Dates = new List<DateTime>();
                    students[name].Comments = new List<string>();
                }

                if (datesInfo.Length < 2)
                {
                    continue;
                }

                List<DateTime> dates = new List<DateTime>(datesInfo.Skip(1).Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture)));
                students[name].Dates.AddRange(dates);
            }

            string commentInfoString = string.Empty;
            while ((commentInfoString = Console.ReadLine()) != "end of comments")
            {
                string[] commentInfo = commentInfoString.Split('-');
                if (!students.ContainsKey(commentInfo[0]))
                {
                    continue;
                }
                else
                {                
                    string name = commentInfo[0];
                    string comment = commentInfo[1];                    
                    students[name].Comments.Add(comment);                    
                }
            }

            foreach (KeyValuePair<string, Student> student in students.OrderBy(s => s.Key))
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (string comment in student.Value.Comments)
                {
                    Console.WriteLine("- " + comment);
                }

                Console.WriteLine("Dates attended:");
                foreach (DateTime date in student.Value.Dates.OrderBy(d => d))
                {
                    Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                }
            }
        }
    }   
}
