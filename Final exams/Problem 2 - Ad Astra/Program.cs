using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2___Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"(?<separators>[?<=#||])(?<itemName>[A-Za-z\s]+)\k<separators>(?<foodDate>[\d]{2}\/[\d]{2}\/[\d]{2})\k<separators>(?<calories>[\d]+)\k<separators>";
            string pattern = @"([|#])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}[\/]\d{2}[\/]\d{2})\1(?<calories>\d+)\1";
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> listOfProducts = new Dictionary<string, Dictionary<string, int>>();
           // const int DAILY_CALORIES = 2000;
            int sumOfCalories = 0;
            int days = 0;

            MatchCollection matches = Regex.Matches(input, pattern);
            string name = string.Empty;
            string foodDate = string.Empty;
            int calories = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                name = matches[i].Groups["itemName"].Value;
                foodDate = matches[i].Groups["foodDate"].Value;
                calories = int.Parse(matches[i].Groups["calories"].Value);

                sumOfCalories += calories;
                listOfProducts.Add(name, new Dictionary<string, int>());
                listOfProducts[name].Add(foodDate, calories);
                

                days = sumOfCalories / 2000;
            }

            //foreach (Match match in matches)
            //{

            //    name = match.Groups["itemName"].Value;
            //    foodDate = match.Groups["foodDate"].Value;
            //    calories = int.Parse(match.Groups["calories"].Value);
                
            //    sumOfCalories += calories;
            //    listOfProducts.Add(name, new Dictionary<string, int>());
            //    listOfProducts[name].Add(foodDate, calories);

            //    days = sumOfCalories / 2000;

            //}

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (var pair in listOfProducts)
            {
                foreach (var innerPair in pair.Value)
                {

                Console.WriteLine($"Item: {pair.Key}, Best before: {innerPair.Key}, Nutrition: {innerPair.Value}");
                }
            }
                

                    

            
            
        }
    }
}
