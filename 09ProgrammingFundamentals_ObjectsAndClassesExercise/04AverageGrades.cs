using System;
using System.Collections.Generic;
using System.Linq;

namespace _04AverageGrades
{   
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student student = new Student();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                student = ReadStudent();
                students.Add(student);
            }

            List<Student> goodStudents = new List<Student>(students.Where(s => s.AverageGrade >= 5.00));
            foreach (Student goodStudent in goodStudents.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade))
            {
                Console.WriteLine("{0} -> {1:f2}", goodStudent.Name, goodStudent.AverageGrade);
            }
        }

        private static Student ReadStudent()
        {
            string[] studentsInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Student student = new Student();
            student.Name = studentsInfo[0];
            student.Grades = new double[studentsInfo.Length - 1];
            for (int i = 0; i < studentsInfo.Length - 1; i++)
            {
                student.Grades[i] = double.Parse(studentsInfo[i + 1]);
            }

            return student;
        }
    }
}
