using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {

            int startingYield = int.Parse(Console.ReadLine());
            int extractedSpice=0;
            const int DAILY_CONSUMED_SPICES = 26;
            const int NEXT_DAY_LOWER_PROD = 10;
            const int MIN_PRODUCTION = 100;
            int dayCount = 0;

            while (startingYield>=MIN_PRODUCTION)
            {
                dayCount++;
                extractedSpice = extractedSpice+ (startingYield - DAILY_CONSUMED_SPICES);
                startingYield -= NEXT_DAY_LOWER_PROD;
                
            }
            extractedSpice -= DAILY_CONSUMED_SPICES;
            Console.WriteLine(dayCount);
            Console.WriteLine(extractedSpice);



        }

    }
}
