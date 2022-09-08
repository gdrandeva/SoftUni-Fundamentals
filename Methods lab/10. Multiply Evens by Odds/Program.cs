using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main()
        {

            int numbers = int.Parse(Console.ReadLine());
            numbers = Math.Abs(numbers);
            int oddSum = GetSumOfOddDigits(numbers);
            int evenSum = GetSumOfEvenDigits(numbers);
            int product = GetMultipleOfEvenAndOdds(oddSum, evenSum);

            Console.WriteLine(product);
        }

        static int GetMultipleOfEvenAndOdds(int oddSum, int evenSum)
        {
            int multiply = oddSum * evenSum;
            return multiply;
        }

        static int GetSumOfEvenDigits(int numbers)
        {
            int sum = 0;
            int digit = numbers;

            while (digit > 0)
            {
                int currentDigit = digit % 10;
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
                digit = digit / 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int numbers)
        {
            int sum = 0;
            int digit = numbers;

            while (digit > 0)
            {
                int currentDigit = digit % 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
                digit = digit / 10;
            }
            return sum;
        }
    }
}
