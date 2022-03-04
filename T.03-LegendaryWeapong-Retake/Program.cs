using System;
using System.Collections.Generic;
using System.Linq;

namespace T._03_LegendaryWeapong_Retake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int requiredForLegendary = 250;

            List<string> keyItems = new List<string>
            {
                "shards",
                "fragments",
                "motes"
            };

            Dictionary<string, int> materials = new Dictionary<string, int>();

            materials.Add("motes", 0);
            materials.Add("shards", 0);
            materials.Add("fragments", 0);

            string input = Console.ReadLine();

            while (true)
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int quantityOne = int.Parse(data[0]);
                string materialOne = data[1].ToLower();

                int quantityTwo = int.Parse(data[2]);
                string materialTwo = data[3].ToLower();

                int quantityThree = int.Parse(data[4]);
                string materialThree = data[5].ToLower();

                if (materials.ContainsKey(materialOne))
                {
                    materials[materialOne] += quantityOne;
                }
                else
                {
                    materials.Add(materialOne, quantityOne);
                }

                if (materials["shards"] >= 250 || materials["fragments"] >= 250 || materials["motes"] >= 250)
                    break;

                if (materials.ContainsKey(materialTwo))
                {
                    materials[materialTwo] += quantityTwo;
                }
                else
                {
                    materials.Add(materialTwo, quantityTwo);
                }

                if (materials["shards"] >= 250 || materials["fragments"] >= 250 || materials["motes"] >= 250)
                    break;

                if (materials.ContainsKey(materialThree))
                {
                    materials[materialThree] += quantityThree;
                }
                else
                {
                    materials.Add(materialThree, quantityThree);
                }

                if (materials.Any(item => item.Value >= requiredForLegendary && (item.Key == "motes" || item.Key == "shards" || item.Key == "fragments")))
                {
                    // We have gathered the materials for a legendary!
                    break;
                }

                

                input = Console.ReadLine();
            }

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

            foreach (KeyValuePair<string, int> material in materials)
            {
                if (keyItems.Contains(material.Key))
                {
                    // Printing only the key items:
                    Console.WriteLine($"{material.Key}: {material.Value}");
                }
            }

            foreach (KeyValuePair<string, int> junkMaterial in materials.Where(i => i.Key != keyItems[0] && i.Key != keyItems[1] && i.Key != keyItems[2]))
            {
                Console.WriteLine($"{junkMaterial.Key}: {junkMaterial.Value}");
            }

            //string legendaryItem = String.Empty;
            //Dictionary<string, int> materials = new Dictionary<string, int>();
            //materials.Add("motes", 0);
            //materials.Add("shards", 0);
            //materials.Add("fragments", 0);
            //Dictionary<string, int> junk = new Dictionary<string, int>();

            //while (materials["motes"] < 250 && materials["fragments"] < 250 && materials["shards"] < 250)
            //{
            //    string input = Console.ReadLine().ToLower();
            //    string[] inputTokens = input.Split(" ");
            //    for (int i = 0; i < inputTokens.Length; i += 2)
            //    {
            //        int quantity = int.Parse(inputTokens[i]);
            //        string material = inputTokens[i + 1];

            //        switch (material)
            //        {
            //            case "shards":
            //            case "fragments":
            //            case "motes":
            //                materials[material] += quantity;
            //                break;
            //            default:
            //                if (!junk.ContainsKey(material))
            //                    junk.Add(material, 0);
            //                junk[material] += quantity;
            //                break;
            //        }

            //        if (materials["shards"] >= 250 || materials["fragments"] >= 250 || materials["motes"] >= 250)
            //            break;
            //    }
            //}

            //if (materials["shards"] >= 250)
            //{
            //    legendaryItem = "Shadowmourne";
            //    materials["shards"] -= 250;
            //}
            //else if (materials["fragments"] >= 250)
            //{
            //    legendaryItem = "Valanyr";
            //    materials["fragments"] -= 250;
            //}
            //else
            //{
            //    legendaryItem = "Dragonwrath";
            //    materials["motes"] -= 250;
            //}

            //Console.WriteLine($"{legendaryItem} obtained!");

            //foreach (var item in materials.OrderByDescending(entry => entry.Value).ThenBy(entry => entry.Key))
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}

            //foreach (var item in junk.OrderBy(entry => entry.Key))
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}
        }
    }
}
