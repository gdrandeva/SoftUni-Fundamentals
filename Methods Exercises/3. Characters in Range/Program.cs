using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());


            PrintCharsBetweenFirstAndSecond(first, second);

        }

        static void PrintCharsBetweenFirstAndSecond(char first, char second)
        {
            int startChar = Math.Min(first, second);
            int endChar = Math.Max(first, second);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}