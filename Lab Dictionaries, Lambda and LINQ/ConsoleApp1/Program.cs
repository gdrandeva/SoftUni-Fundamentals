using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> countOfOccurences = new SortedDictionary<int, int>();

            for (int i = 0; i <= numbers.Count-1; i++)
            {
              
                if (!countOfOccurences.ContainsKey(numbers[i]))
                {
                   
                    countOfOccurences.Add(numbers[i], 1);
                }
                else
                {
                    countOfOccurences[numbers[i]]++;
                }
            }

            foreach (var item in countOfOccurences)
            {
                
                Console.WriteLine($"{item.Key} -> {item.Value}"); 
            }
        }
    }
}
