using System;
using System.Linq;

namespace dfhdh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int k = 0; k < numbers.Length - 1; k++)
            {
                int topIntegerCurentItteration = numbers[k];
                for (int nextDigit = k+1; nextDigit <= numbers.Length-1; nextDigit++)
                {
                    if (topIntegerCurentItteration > numbers[nextDigit])
                    {
                        Console.Write(topIntegerCurentItteration);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
