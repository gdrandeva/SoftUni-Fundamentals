using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();
            
            foreach (var word in words)
            {
                string lowerCaseWord = word.ToLower();
                if (counts.ContainsKey(lowerCaseWord))
                {
                    counts[lowerCaseWord]++;
                }
                else
                {
                    counts.Add(lowerCaseWord, 1);
                }
            }

            foreach (var item in counts)
            {
                if (item.Value%2!=0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
