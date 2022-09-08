using System;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359(?<Separator>[-\s])2\k<Separator>[0-9]{3}\k<Separator>[0-9]{4}\b";


            //Regex regex = new Regex(pattern);
            // Match matched = regex.Match(input);
            MatchCollection matched = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}
