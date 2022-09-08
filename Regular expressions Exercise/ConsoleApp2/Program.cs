using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            string input = Console.ReadLine();
            List<string> articles = new List<string>();
            double totalPrice = 0;

            while (input!="Purchase")
            {
                Match matches = Regex.Match(input, pattern,RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    double price = double.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);

                    articles.Add(name);
                    totalPrice += price * quantity;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var product in articles)
            {
                Console.WriteLine(product);
            }
            //articles.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice}");



        }
    }
}

