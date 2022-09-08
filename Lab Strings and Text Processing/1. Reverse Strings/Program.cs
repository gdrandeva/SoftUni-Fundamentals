using System;
using System.Text;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            StringBuilder reversedString = new StringBuilder();

            while (command != "end")
            {
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    char currentChar = command[i];
                    reversedString.Append(currentChar);

                }
                Console.WriteLine($"{command} = {reversedString}");
                reversedString.Clear();
                command = Console.ReadLine();
            }
        }
    }
}
