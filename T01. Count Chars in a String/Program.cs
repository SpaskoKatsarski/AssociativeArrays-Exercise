using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char currChar = str[i];

                if (chars.ContainsKey(currChar))
                {
                    chars[currChar]++;
                }
                else
                {
                    chars.Add(currChar, 1);
                }
            }

            foreach (KeyValuePair<char, int> element in chars.Where(c => c.Key != ' '))
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
