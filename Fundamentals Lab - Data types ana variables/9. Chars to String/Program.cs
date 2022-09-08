using System;

namespace _9._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = ' ';
            string groupOfChars = "";
            for (int i = 1; i <= 3; i++)
            {
                symbol = char.Parse(Console.ReadLine());
                groupOfChars += symbol;
            }
            Console.WriteLine(groupOfChars);
        }
    }
}
