using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";
            string pattern = @"([|#])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}[\/]\d{2}[\/]\d{2})\1(?<calories>\d+)\1";
            //List<string> customers = new List<string>();
            double sum = 0;
            double totalSum = 0;
            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                //Match matches = Regex.Match(input, pattern);
                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(input);
                if (isValid)
                {
                    string name = regex.Match(input).Groups["name"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int count = int.Parse(regex.Match(input).Groups["count"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    //if (!customers.Contains(name))
                    //{
                    //    customers.Add(name);
                        sum = count * price;
                   // }

                    totalSum += count * price;
                    Console.WriteLine($"{name}: {product} - {sum:f2}");

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}