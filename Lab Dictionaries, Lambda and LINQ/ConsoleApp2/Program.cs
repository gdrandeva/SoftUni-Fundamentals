using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> occurencesByNumber = new SortedDictionary<int, int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var number in numbers)
            {

                if (occurencesByNumber.ContainsKey(number))
                {
                    int currentOccurences = occurencesByNumber[number];
                    currentOccurences += 1;

                    occurencesByNumber[number] = currentOccurences;
                }
                else
                {
                    occurencesByNumber.Add(number, 1);
                }
            }

            foreach (var occurenceByNumber in occurencesByNumber)
            {
                Console.WriteLine($"{occurencesByNumber.Keys} -> {occurencesByNumber.Values}");
            }
        }
    }


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

                for (int i = 0; i <= numbers.Count - 1; i++)
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
