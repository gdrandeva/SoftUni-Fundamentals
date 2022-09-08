using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex patternForName = new Regex(@"(?<name>[A-Za-z])");
            string patternForDigits = @"(?<digit>\d+)";

            int sumOfDigits = 0;

            var participants = new Dictionary<string, int>();
            List<string> names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection matchedNames = patternForName.Matches(input);
                MatchCollection matchedDigits = Regex.Matches(input, patternForDigits);
                string currName = string.Join("", matchedNames);
                string currDigits = string.Join("", matchedDigits);
                sumOfDigits = 0;
                for (int i = 0; i < currDigits.Length; i++)
                {
                    sumOfDigits += int.Parse(currDigits[i].ToString());
                }
                if (names.Contains(currName))
                {
                    if (!participants.ContainsKey(currName))
                    {
                        participants.Add(currName, sumOfDigits);
                    }
                    else
                    {
                        participants[currName] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }

            var winners = participants.OrderByDescending(x => x.Value).Take(3);
            var firstRacer = winners.Take(1);

            var secondRacer = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdRacer = winners.OrderBy(x => x.Value).Take(1);

            foreach (var first in firstRacer)
            {
                Console.WriteLine($"1st place: {first.Key}");
            }
            foreach (var second in secondRacer)
            {
                Console.WriteLine($"2nd place: {second.Key}");
            }
            foreach (var third in thirdRacer)
            {
                Console.WriteLine($"3rd place: {third.Key}");
            }
        }
    }
}
