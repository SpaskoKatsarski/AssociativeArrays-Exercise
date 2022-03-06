using System;
using System.Collections.Generic;
using System.Linq;

namespace T._03_LegendaryWeapong_Retake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> keyMaterials = new List<string>
            {
                "shards",
                "fragments",
                "motes"
            };

            Dictionary<string, int> keyItems = new Dictionary<string, int>();

            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (!keyItems.Any(i => i.Value >= 250))
            {
                string[] materialsData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int quantOne = int.Parse(materialsData[0]);
                string materialOne = materialsData[1].ToLower();

                int quantTwo = int.Parse(materialsData[2]);
                string materialTwo = materialsData[3].ToLower();

                int quantThree = int.Parse(materialsData[4]);
                string materialThree = materialsData[5].ToLower();

                if (keyMaterials.Contains(materialOne))
                {
                    if (keyItems.ContainsKey(materialOne))
                    {
                        keyItems[materialOne] += quantOne;
                    }
                    else
                    {
                        keyItems.Add(materialOne, quantOne);
                    }
                }
                else
                {
                    if (junkItems.ContainsKey(materialOne))
                    {
                        junkItems[materialOne] += quantOne;
                    }
                    else
                    {
                        junkItems.Add(materialOne, quantOne);
                    }
                }

                if (keyItems.Any(i => i.Value >= 250))
                {
                    break;
                }

                if (keyMaterials.Contains(materialTwo))
                {
                    if (keyItems.ContainsKey(materialTwo))
                    {
                        keyItems[materialTwo] += quantTwo;
                    }
                    else
                    {
                        keyItems.Add(materialTwo, quantTwo);
                    }
                }
                else
                {
                    if (junkItems.ContainsKey(materialTwo))
                    {
                        junkItems[materialTwo] += quantTwo;
                    }
                    else
                    {
                        junkItems.Add(materialTwo, quantTwo);
                    }
                }

                if (keyItems.Any(i => i.Value >= 250))
                {
                    break;
                }

                if (keyMaterials.Contains(materialThree))
                {
                    if (keyItems.ContainsKey(materialThree))
                    {
                        keyItems[materialThree] += quantThree;
                    }
                    else
                    {
                        keyItems.Add(materialThree, quantThree);
                    }
                }
                else
                {
                    if (junkItems.ContainsKey(materialThree))
                    {
                        junkItems[materialThree] += quantThree;
                    }
                    else
                    {
                        junkItems.Add(materialThree, quantThree);
                    }
                }

                if (keyItems.Any(i => i.Value >= 250))
                {
                    break;
                }

                command = Console.ReadLine();
            }

            // When the loop ends we have enough material for legendary.
            string firstGatheredKeyMaterial = string.Empty;

            foreach (KeyValuePair<string, int> item in keyItems)
            {
                if (item.Value >= 250)
                {
                    firstGatheredKeyMaterial = item.Key;
                    break;
                }
            }

            string legendaryItem = string.Empty;

            if (firstGatheredKeyMaterial == "shards")
            {
                legendaryItem = "Shadowmourne";
            }
            else if (firstGatheredKeyMaterial == "fragments")
            {
                legendaryItem = "Valanyr";
            }
            else
            {
                legendaryItem = "Dragonwrath";
            }

            keyItems[firstGatheredKeyMaterial] -= 250;
            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (KeyValuePair<string, int> keyMat in keyItems)
            {
                Console.WriteLine($"{keyMat.Key}: {keyMat.Value}");
            }

            foreach (KeyValuePair<string, int> junk in junkItems)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
