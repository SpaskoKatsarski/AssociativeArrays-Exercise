using System;
using System.Collections.Generic;

namespace T._03.LegendaryFarming_Second_Retake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string obtainedItem = string.Empty;

            while (string.IsNullOrEmpty(obtainedItem))
            {
                string materialsLine = Console.ReadLine().ToLower();
                string[] materialsArr = materialsLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                ProcessInputLine(keyMaterials, junk, materialsArr, ref obtainedItem);
            }

            Console.WriteLine($"{obtainedItem} obtained!");

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public static void ProcessInputLine(Dictionary<string, int> keyMaterials, Dictionary<string, int> junk, string[] materialsArr, ref string obtainedItem)
        {
            const int requiredMaterials = 250;

            Dictionary<string, string> craftingTable = new Dictionary<string, string>
            {
                { "shards", "Shadowmourne" },
                { "motes", "Dragonwrath" },
                { "fragments", "Valanyr" }
            };

            for (int i = 0; i < materialsArr.Length; i += 2)
            {
                // 0,1 - 2,3

                int currMaterialQty = int.Parse(materialsArr[i]);
                string currMaterial = materialsArr[i + 1];

                if (keyMaterials.ContainsKey(currMaterial))
                {
                    keyMaterials[currMaterial] += currMaterialQty;

                    if (keyMaterials[currMaterial] >= requiredMaterials)
                    {
                        // We gathered the needed amount of materials for a legendary item craft.
                        obtainedItem = craftingTable[currMaterial];
                        keyMaterials[currMaterial] -= requiredMaterials;
                        break;
                    }
                }
                else
                {
                    if (!junk.ContainsKey(currMaterial))
                    {
                        junk[currMaterial] = 0;
                    }

                    junk[currMaterial] += currMaterialQty;
                }
            }
        }
    }
}
