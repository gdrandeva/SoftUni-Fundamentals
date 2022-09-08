using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<day>\b[0-9]{2})(?<separator>\.|\-|\/)(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";


            var matches = Regex.Matches(input, pattern);


            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }
        }
    }
}