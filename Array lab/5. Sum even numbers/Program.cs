using System;
using System.Linq;

namespace _5._Sum_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //string[] inputAsString = input.Split(' ');
            int[] numbers = new int[numbers.Length];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            foreach (var number in numbers)
            {
                
                if (number%2==0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
