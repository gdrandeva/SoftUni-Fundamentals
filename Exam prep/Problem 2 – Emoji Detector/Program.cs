using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2___Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string patternEmojis = @"([\*{2}|:{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string patternNumbers = @"\d";

            MatchCollection emojiMatches = Regex.Matches(text, patternEmojis);
            MatchCollection numberMatches = Regex.Matches(text, patternNumbers);

            long threshold = 1;

            foreach (Match number in numberMatches)
            {
                threshold *= int.Parse(number.Value);
            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");
           

            foreach (Match emojiMatch in emojiMatches)
            {
                string emoji = emojiMatch.Groups["emoji"].Value;
                long emojiThreshold = emoji.ToCharArray().Sum(c => c);
                if (emojiThreshold>=threshold)
                {
                    Console.WriteLine(emojiMatch.Value);
                }

            }
        }
    }
}
