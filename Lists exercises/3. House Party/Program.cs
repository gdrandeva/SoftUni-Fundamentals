using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < commands; i++)
            {
                string answerToInvitation = Console.ReadLine();
                string[] answerAsArray = answerToInvitation.Split();
                if (answerToInvitation.Contains("is going"))
                {
                    if (names.Contains(answerAsArray[0]))
                    {
                        Console.WriteLine($"{answerAsArray[0]} is already in the list!");
                        continue;
                    }
                    names.Add(answerAsArray[0]);
                }
                else if (answerToInvitation.Contains("is not going"))
                {
                    if (!names.Contains(answerAsArray[0]))
                    {
                        Console.WriteLine($"{answerAsArray[0]} is not in the list!");
                        continue;
                    }
                    names.Remove(answerAsArray[0]);
                }

            }
            Console.WriteLine(string.Join("\n", names));

        }
    }
}

