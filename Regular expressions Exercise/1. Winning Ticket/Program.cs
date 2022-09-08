using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            string ticket = string.Empty;
            for (int i = 0; i < input.Length - 1; i++)
            {
                ticket = input[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string pattern = @"(?<winningsymbols>[@#$^])(\k<winningsymbols>{5,9})";

                string leftSide = string.Join("", ticket.Take(10));
                string rightSide = string.Join("", ticket.Skip(10));

                MatchCollection matchLeft = Regex.Matches(leftSide, pattern);
                MatchCollection matchRight = Regex.Matches(rightSide, pattern);
            }
            
        }
    }
}
