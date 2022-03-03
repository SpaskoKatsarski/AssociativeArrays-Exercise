using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> allStudents = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (allStudents.ContainsKey(studentName))
                {
                    allStudents[studentName].Add(studentGrade);
                }
                else
                {
                    allStudents.Add(studentName, new List<double>{ studentGrade });
                }
            }

            Dictionary<string, double> passingStudents = new Dictionary<string, double>();

            foreach (KeyValuePair<string, List<double>> student in allStudents)
            {
                double currAverageGrade = student.Value.Average();

                if (currAverageGrade >= 4.50)
                {
                    passingStudents.Add(student.Key, currAverageGrade);
                }
            }

            foreach (KeyValuePair<string, double> student in passingStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
