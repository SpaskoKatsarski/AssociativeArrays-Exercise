using System;
using System.Collections.Generic;

namespace T05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                string username = commandArgs[1];

                if (action == "register")
                {
                    if (parkingLot.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingLot[username]}");
                    }
                    else
                    {
                        string licensePalte = commandArgs[2];
                        parkingLot.Add(username, licensePalte);
                        Console.WriteLine($"{username} registered {licensePalte} successfully");
                    }
                }
                else if (action == "unregister")
                {
                    if (!parkingLot.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        parkingLot.Remove(username);
                    }
                }
            }

            foreach (KeyValuePair<string, string> registeredUser in parkingLot)
            {
                Console.WriteLine($"{registeredUser.Key} => {registeredUser.Value}");
            }
        }
    }
}
