using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] output = new string[input.Length];
            int count = 0;
            for (int i = input.Length-1; i >=0; i--)
            {
                output[count] = input[i];
                count++;
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
