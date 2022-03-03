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
            
            Dictionary<string, int> wantedMaterials = new Dictionary<string, int>();

            Dictionary<string, int> unwantedMaterials = new Dictionary<string, int>();

            while (true)
            {
                if (wantedMaterials.Any(x => x.Value == requiredForLegendary))
                {
                    // We have gathered the materials for a legendary!
                    break;
                }

                //"Shadowmourne";
                //"Valanyr";
                //"Dragonwrath";

                string[] materialsData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);


                string itemOne = materialsData[0];
                int quantityOne = int.Parse(materialsData[1]);

                string itemTwo = materialsData[2];
                int quantityTwo = int.Parse(materialsData[3]);

                string itemThree = materialsData[4];
                int quantityThree = int.Parse(materialsData[5]);

                // TODO: Check if it is a good material and if so, add it to the count in the dictionary and check if one of them reaches 250. Then do the rest of the task.
            }
        }
    }
}
