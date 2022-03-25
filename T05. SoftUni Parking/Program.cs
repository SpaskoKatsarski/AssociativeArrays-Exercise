using System;
using System.Collections.Generic;

namespace T05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User --> License plate number
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                string username = commandArgs[1];

                if (action == "register")
                {
                    string licensePlate = commandArgs[2];
                    RegisterUser(parkingLot, username, licensePlate);
                }
                else if (action == "unregister")
                {
                    UnregisterUser(parkingLot, username);
                }
            }

            foreach (KeyValuePair<string, string> registeredUser in parkingLot)
            {
                Console.WriteLine($"{registeredUser.Key} => {registeredUser.Value}");
            }
        }

        public static void RegisterUser(Dictionary<string, string> parkingLot, string username, string licensePlate)
        {
            if (parkingLot.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {parkingLot[username]}");
            }
            else
            {
                parkingLot.Add(username, licensePlate);
                Console.WriteLine($"{username} registered {licensePlate} successfully");
            }
        }

        public static void UnregisterUser(Dictionary<string, string> parkingLot, string username)
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
}
