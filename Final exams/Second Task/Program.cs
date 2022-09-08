using System;
using System.Text.RegularExpressions;

namespace Second_Task
{
    class Program
    {
        static void Main(string[] args)
        {

//            o   "{boss name}, The {title}
//>> Strength: { length of the name}
//>> Armor: { length of the title}
//            "
//o   "Access denied!"

            int numberOfInputs = int.Parse(Console.ReadLine());
            string pattern = @"\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";
            string bossName = string.Empty;
            string title = string.Empty;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(input);

                if (!isValid)
                {
                    Console.WriteLine("Access denied!");
                }
                else
                {
                    bossName = regex.Match(input).Groups["boss"].Value;
                    title = regex.Match(input).Groups["title"].Value;
                    Console.WriteLine($"{bossName}, The {title}");
                    Console.WriteLine($">> Strength: {bossName.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                }
            }

        }
    }
}
