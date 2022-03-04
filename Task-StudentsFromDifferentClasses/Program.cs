using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_StudentsFromDifferentClasses
{
    class Student
    {
        public Student(string name, int numberInClass)
        {
            this.Name = name;
            this.NumberInClass = numberInClass;
        }

        public string Name { get; set; }

        public int NumberInClass { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateNow = DateTime.Now;
            //Console.WriteLine(dateNow);

            Dictionary<string, Student> students = new Dictionary<string, Student>();

            students.Add("8A", new Student("Pesho", 18));
            students.Add("9B", new Student("Anton", 1));
            students.Add("9A", new Student("Ivan", 16));
            students.Add("10A", new Student("Spasko", 9));
            students.Add("5B", new Student("Maria", 24));
            students.Add("10B", new Student("Stamat", 20));

            List<string> studentsFrom9B = students
                .Where(s => s.Key == "9B")
                .Select(s => s.Value.Name)
                .ToList();

            foreach (string student in studentsFrom9B)
            {
                Console.WriteLine(student);
            }

            List<int> studentsWithOddNumbers = students
                .Where(s => s.Value.NumberInClass % 2 != 0)
                .Select(s => s.Value.NumberInClass)
                .ToList();

            foreach (int number in studentsWithOddNumbers)
            {
                Console.WriteLine($"Odd Number: {number}");
            }
        }
    }
}
