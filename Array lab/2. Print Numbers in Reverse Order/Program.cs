using System;
using System.Linq;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] reversedNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int digit = int.Parse(Console.ReadLine());//.Split().Select(int.Parse).ToArray();
                reversedNumbers[i] = digit;
            }

            Console.WriteLine(string.Join(" ", reversedNumbers.Reverse()));
        }
    }
}
