using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfWords; i++)
            {
                string keyWord = Console.ReadLine();
                string keyValue = Console.ReadLine();
                if (!synonyms.ContainsKey(keyWord))
                {
                    synonyms.Add(keyWord, new List<string>());
                    synonyms[keyWord].Add(keyValue);

                }
                else
                {
                    synonyms[keyWord].Add(keyValue);
                }
                
            }
            foreach (var syn in synonyms)
            {
            Console.WriteLine($"{syn.Key} - {string.Join(", ", syn.Value)}");

            }

        }
    }
}
