using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"(?<FirstName>\b[A-Z][a-z]{1,}) (?<LastName>[A-Z][a-z]{1,}\b)";

            MatchCollection namesByPattern = Regex.Matches(names, pattern);

            foreach (Match matchedName in namesByPattern)
            {
                Console.Write($"{matchedName} ");
            }
        }
    }
}
