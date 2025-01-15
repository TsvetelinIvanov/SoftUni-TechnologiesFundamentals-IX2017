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
            StreamReader streamReader = new StreamReader("input.txt");
            using (streamReader)
            {
                List<Student> students = new List<Student>();
                int studentsCount = int.Parse(streamReader.ReadLine());
                string[] studentInfo = new string[studentsCount];
                for (int i = 0; i < studentsCount; i++)
                {
                    Student student = new Student();
                    
                    studentInfo = streamReader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    student.Name = studentInfo[0];
                    student.Grades = studentInfo.Skip(1).Select(double.Parse).ToList();
                    
                    students.Add(student);
                }

                string output = string.Empty;
                students.Where(s => s.Average >= 5.00)
                    .OrderBy(s => s.Name).ThenByDescending(s => s.Average)
                    .ToList().ForEach(s => output += $"{s.Name} -> {s.Average:f2}\r\n");

                File.WriteAllText("output.txt", output);
            }
        }
    }
}
