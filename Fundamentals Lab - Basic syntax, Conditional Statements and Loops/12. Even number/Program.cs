using System;

namespace _12._Even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;

            while (true)
            {
                number = int.Parse(input);

                if (number%2==0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                else if (number%2!=0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                input = Console.ReadLine();
            }
        }
    }
}
