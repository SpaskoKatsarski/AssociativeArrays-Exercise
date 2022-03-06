using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            dict["Spasko"] = 12;

            dict.Add("Ivan", 1);

            dict.Add(Console.ReadLine(), 12);

            Console.WriteLine(dict["Pe6o"]);

            List<string> names = dict.Keys.ToList();

            //string age = dict["Spasko"].ToString();

            foreach (string name in names)
            {
                Console.WriteLine($"{name} -> {dict[name]}");
            }

            //int numOne = int.MaxValue;
            //Console.WriteLine(numOne += 200); // integer overflow
        }
    }
}
