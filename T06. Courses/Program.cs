using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] courseData = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string currentCourse = courseData[0];
                string nameOfStudent = courseData[1];

                if (!courses.ContainsKey(currentCourse))
                {
                    courses.Add(currentCourse, new List<string>{nameOfStudent});
                }

                if (!courses[currentCourse].Contains(nameOfStudent))
                {
                    courses[currentCourse].Add(nameOfStudent);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}"); 
                }
            }

            // values.Count??????
        }
    }
}
