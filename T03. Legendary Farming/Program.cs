using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int requiredForLegendary = 250;

            Dictionary<string, int> materials = new Dictionary<string, int>();

            while (true)
            {
                if (materials.Any(item => item.Value >= requiredForLegendary && (item.Key == "motes" || item.Key == "shards" || item.Key == "fragments")))
                {
                    // We have gathered the materials for a legendary!
                    break;
                }

                //"Shadowmourne";
                //"Valanyr";
                //"Dragonwrath";

                string[] materialsData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int quantityOne = int.Parse(materialsData[0]);
                string itemOne = materialsData[1].ToLower();

                int quantityTwo = int.Parse(materialsData[2]);
                string itemTwo = materialsData[3].ToLower();

                int quantityThree = int.Parse(materialsData[4]);
                string itemThree = materialsData[5].ToLower();

                if (materials.ContainsKey(itemOne))
                {
                    materials[itemOne] += quantityOne;
                }
                else
                {
                    materials.Add(itemOne, quantityOne);
                }

                if (materials.ContainsKey(itemTwo))
                {
                    materials[itemTwo] += quantityTwo;
                }
                else
                {
                    materials.Add(itemTwo, quantityTwo);
                }

                if (materials.ContainsKey(itemThree))
                {
                    materials[itemThree] += quantityThree;
                }
                else
                {
                    materials.Add(itemThree, quantityThree);
                }

            }

            //materials[legendaryMaterial] -= requiredForLegendary;


            string legendaryMaterial = string.Empty;

            foreach (KeyValuePair<string, int> material in materials.Where(m => m.Key == "motes" || m.Key == "shards" || m.Key == "fragments"))
            {
                if (material.Value >= requiredForLegendary)
                {
                    if (material.Key == "shards")
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        legendaryMaterial = "shards";
                        break;
                    }
                    else if (material.Key == "fragments")
                    {
                        Console.WriteLine("Valanyr obtained!");
                        legendaryMaterial = "fragments";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        legendaryMaterial = "motes";
                        break;
                    }
                }
            }

            materials[legendaryMaterial] -= requiredForLegendary;

            foreach (KeyValuePair<string, int> goodMaterial in materials.Where(m => m.Key == "shards" || m.Key == "motes" || m.Key == "fragments"))
            {
                Console.WriteLine($"{goodMaterial.Key} -> {goodMaterial.Value}");
            }

            foreach (KeyValuePair<string, int> badMaterial in materials.Where(m => m.Key != "shards" && m.Key != "motes" && m.Key != "fragments"))
            {
                Console.WriteLine($"{badMaterial.Key} -> {badMaterial.Value}");
            }

            // Then the item of the unwanted items
        }
    }
}
