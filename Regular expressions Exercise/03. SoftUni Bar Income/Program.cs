using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>%[A-Za-z]+%)(?<product><\w+>)(?<count>\|\d\|)(?<price>[0-9]*[.][0-9]*[$])";
            //string namePattern = @"(?<name>%[A-Za-z]+%)";
            //string productPattern = @"(?<product><\w+>)";
            //string countPattern = @"(?<count>\|\d\|)";
            //string pricePattern = @"(?<price>[0-9]*[.][0-9]*[$])";

            string input = Console.ReadLine();
            //Regex name = new Regex(namePattern);
            //Regex product = new Regex(productPattern);
            //Regex count = new Regex(countPattern);
            //Regex price = new Regex(pricePattern);

            double finalPrice = 0;

            while (input != "end of shift")
            {
                //MatchCollection matchedName = Regex.Matches(input, namePattern);
                //MatchCollection matchedProduct = Regex.Matches(input, productPattern);
                //MatchCollection matchedCount = Regex.Matches(input, countPattern);
                //MatchCollection matchedPrice = Regex.Matches(input, pricePattern);
                MatchCollection matched = Regex.Matches(input, pattern);
                foreach (Match match in matched)
                {
                    var name = match.Groups["name"].Value;
                    var product = match.Groups["product"].Value;
                    var count = int.Parse(match.Groups["count"].Value);
                    var price = double.Parse(match.Groups["price"].Value);
                    finalPrice += count * price;
                }
               
                input = Console.ReadLine();
            }
        }
    }
}
