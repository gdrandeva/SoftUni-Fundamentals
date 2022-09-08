using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int productSum;
            double collectedSum;
            double collectedCash = 0;
            double collectedCard = 0;

            int counter = 0;
            int cashCounter = 0;
            int cardCounter = 0;

            while (input != "End")
            {
                productSum = int.Parse(input);
                counter++;

                if (counter % 2 == 0)
                {
                    if (productSum > 100 || productSum > 10)
                    {
                        cardCounter++;
                        collectedCard += productSum;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }

                }
                else if (counter % 2 != 0)
                {
                    if (productSum < 10 || productSum < 100)
                    {
                        cashCounter++;
                        collectedCash += productSum;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }

                }
                collectedSum = collectedCash + collectedCard;
                if (collectedSum >= sum)
                {
                    Console.WriteLine($"Average CS: {collectedCash / cashCounter:f2}");
                    Console.WriteLine($"Average CC: {collectedCard / cardCounter:f2}");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
