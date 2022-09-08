using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int totalCalories = 0;
        StringBuilder output = new StringBuilder();

        string regex = @"([|#])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}[\/]\d{2}[\/]\d{2})\1(?<calories>\d+)\1";
        MatchCollection matches = Regex.Matches(input, regex);
        for (int i = 0; i < matches.Count; i++)
        {
            string name = matches[i].Groups["name"].Value;
            string date = matches[i].Groups["date"].Value;
            int calories = int.Parse(matches[i].Groups["calories"].Value);
            totalCalories += calories;

            output.Append($"Item: {name}, Best before: {date}, Nutrition: {calories}\n");
        }
        int days = totalCalories / 2000;
        Console.WriteLine($"You have food to last you for: {days} days!");
        Console.WriteLine(output);
    }
}