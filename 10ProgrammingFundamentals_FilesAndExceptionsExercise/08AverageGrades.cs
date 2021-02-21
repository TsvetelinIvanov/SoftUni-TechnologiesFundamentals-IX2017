using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average => Grades.Average();
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");
            using (file)
            {
                List<Student> students = new List<Student>();
                int n = int.Parse(file.ReadLine());
                string[] inputArguments = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Student student = new Student();
                    inputArguments = file.ReadLine().Split(new char[]
                    { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    student.Name = inputArguments[0];
                    student.Grades = inputArguments.Skip(1).Select(double.Parse).ToList();
                    students.Add(student);
                }

                string text = string.Empty;
                students.Where(s => s.Average >= 5.00).OrderBy(s => s.Name)
                    .ThenByDescending(s => s.Average).ToList()
                    .ForEach(s => text += $"{s.Name} -> {s.Average:f2}\r\n");

                File.WriteAllText("output.txt", text);
            }
        }
    }
}
