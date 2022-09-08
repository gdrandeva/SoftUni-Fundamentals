using System;
using System.Text;

namespace First_task
{
    class Program
    {
        static void Main(string[] args)
        {


//            o   "End"
//o   "Translate {char} {replacement}"
//o   "Includes {substring}"
//o   "Start {substring}"
//o   "Lowercase"
//o   "FindIndex {char}"
//o   "Remove {startIndex} {count}"

            StringBuilder manipulatedString = new StringBuilder(Console.ReadLine());

            string command = Console.ReadLine();

            while (command!= "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string ch = string.Empty;
                string replacement = string.Empty;
                string substring = string.Empty;
                int startIndex = 0;
                int count = 0;

                switch (action)
                {
                    case "Translate":
                        ch = tokens[1];
                        replacement = tokens[2];
                        while (manipulatedString.ToString().Contains(ch))
                        {
                            manipulatedString.Replace(ch, replacement);
                        }
                        Console.WriteLine(manipulatedString);
                        break;
                    case "Includes":
                        substring = tokens[1];
                        if (manipulatedString.ToString().Contains(substring))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Start":
                        substring = tokens[1];
                        if (manipulatedString.ToString().StartsWith(substring))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Lowercase":
                        string edited = manipulatedString.ToString();
                        edited = edited.ToLower();
                        manipulatedString.Clear();
                        manipulatedString.Append(edited);
                            
                        Console.WriteLine(manipulatedString);
                        break;
                    case "FindIndex":
                        ch = tokens[1];
                        int index = manipulatedString.ToString().LastIndexOf(ch);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        startIndex = int.Parse(tokens[1]);
                        count = int.Parse(tokens[2]);
                        manipulatedString.Remove(startIndex, count);
                        Console.WriteLine(manipulatedString);
                        break;

                }
                command = Console.ReadLine();
            }
        }
    }
}
