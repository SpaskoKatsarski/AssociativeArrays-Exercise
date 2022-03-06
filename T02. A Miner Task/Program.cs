using System;
using System.Collections.Generic;

namespace T02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ulong> resources = new Dictionary<string, ulong>();

            string command = Console.ReadLine();

            while (command != "stop")
            {
                string resource = command;
                ulong quantityOfResource = ulong.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantityOfResource;

                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string, ulong> resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
