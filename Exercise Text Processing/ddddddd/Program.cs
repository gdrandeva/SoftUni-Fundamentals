using System;
using System.Collections.Generic;

namespace ddddddd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();

            foreach (var username in input)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;
                    for (int i = 0; i < username.Length; i++)
                    {
                        char currentChar = username[i];
                        if (!(currentChar== '-' || currentChar=='_' || char.IsDigit(currentChar) || char.IsLetter(currentChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validUsernames.Add(username);
                    }
                }
                
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));

        }
    }
}
