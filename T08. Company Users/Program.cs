using System;
using System.Collections.Generic;
using System.Linq;

namespace T08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string companyName = data[0];
                string employeeId = data[2];

                if (companies.ContainsKey(companyName))
                {
                    if (companies[companyName].Contains(employeeId))
                    {
                        // Employee with this ID already exists.
                        command = Console.ReadLine();
                        continue;
                    }

                    companies[companyName].Add(employeeId);
                }
                else
                {
                    //if (companies.Any(c => c.Value.Contains(employeeId)))
                    //{
                    //    // We have the same ID with a person in other company
                    //    Console.WriteLine($"ID: {employeeId} already exists!");
                    //    command = Console.ReadLine();
                    //    continue;
                    //}

                    companies.Add(companyName, new List<string>()
                    {
                        employeeId
                    });
                }

                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> company in companies)
            {
                Console.WriteLine(company.Key);

                foreach (string ID in company.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
