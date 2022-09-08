using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";
            List<string> customers = new List<string>();
            double sum = 0;
            double totalSum = 0;
            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                Match matches = Regex.Match(input, pattern);
                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    string product = matches.Groups["product"].Value;
                    int count = int.Parse(matches.Groups["count"].Value);
                    double price = double.Parse(matches.Groups["price"].Value);
                    //if (Regex.IsMatch(input,pattern))
                    //{
                    //    customers.Add(name);
                    //    sum = count * price;
                    //    totalSum += sum;
                    //}
                    if (!customers.Contains(name))
                    {
                        customers.Add(name);
                        sum = count * price;
                        totalSum += sum;
                    }
                    else 
                    {

                    totalSum += count * price;
                    }
                    Console.WriteLine($"{name}: {product} - {sum:f2}");

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
