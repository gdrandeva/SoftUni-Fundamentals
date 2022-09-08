using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read the list with participants
            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            //read  the text which should be filtered
            string input = Console.ReadLine();
            //create patterns for names and ran distance
            Regex namePattern = new Regex(@"(?<name>[A-Za-z]+)");
            Regex distancePattern = new Regex(@"(?<distance>\d+)");
            Dictionary<string, int> persons = new Dictionary<string, int>();
            int sumOfDigits = 0;

            //create a while loop
            while (input != "end of race")
            {
                MatchCollection nameMatches = namePattern.Matches(input);
                MatchCollection distanceMatches = distancePattern.Matches(input);
                string currentName = string.Join("", nameMatches);
                string currentDistance = string.Join("", distanceMatches);

                sumOfDigits = 0;
                for (int i = 0; i < currentDistance.Length; i++)
                {
                    sumOfDigits += int.Parse(currentDistance[i].ToString());
                }
                //check if the person exists in the participants list

                if (participants.Contains(currentName))
                {
                    if (!persons.ContainsKey(currentName))
                    {
                        persons.Add(currentName, sumOfDigits);
                    }
                    else
                    {
                        //updating current distance
                        persons[currentName] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }

            //find the winners
            var winners = persons.OrderByDescending(x => x.Value).Take(3);
            //find the 1st place
            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);



            foreach (var firstName in firstPlace)
            {
                Console.WriteLine($"1st place: {firstName.Key}");
            }
            foreach (var secondName in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondName.Key}");
            }
            foreach (var thirdName in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdName.Key}");
            }




        }
    }
}