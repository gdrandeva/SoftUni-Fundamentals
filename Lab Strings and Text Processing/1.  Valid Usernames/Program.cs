using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.__Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            bool isValid = false;
            List<string> validNames = new List<string>();


            foreach (var name in names)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    isValid = true;

                    for (int i = 0; i < name.Length; i++)
                    {
                        char currentChar = name[i];
                        if (!(currentChar == '-' || currentChar == '_' || char.IsLetterOrDigit(currentChar)))
                        {
                            isValid = false;
                            break;
                        }

                    }
                    if (isValid)
                    {
                        validNames.Add(name);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validNames));


        }
    }
}



