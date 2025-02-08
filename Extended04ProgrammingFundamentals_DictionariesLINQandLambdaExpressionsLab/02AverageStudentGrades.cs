using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < gradesCount; i++)
            {
                string[] studentAndGrade = Console.ReadLine().Split();
                string student = studentAndGrade[0];
                double grade = double.Parse(studentAndGrade[1]);
                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades.Add(student, new List<double>());
                }

                studentsGrades[student].Add(grade);
            }
            
            foreach (KeyValuePair<string, List<double>> studentGrades in studentsGrades)
            {
                Console.Write($"{studentGrades.Key} -> ");
                foreach (double grade in studentGrades.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {studentGrades.Value.Average():f2})");
            }
        }
    }
}
