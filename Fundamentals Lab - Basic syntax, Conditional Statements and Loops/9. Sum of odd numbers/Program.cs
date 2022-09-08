using System;

namespace _9._Sum_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int oddNumber = 0;
            for (int i = 0; i < n; i++)
            {
                oddNumber = 1 + (i * 2);
                Console.WriteLine(oddNumber);
                sum += oddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
