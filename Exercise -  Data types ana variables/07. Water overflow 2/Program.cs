using System;

namespace _07._Water_overflow_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            const int CAPACITY_OF_TANK = 255;
            int decreasedCapacity =CAPACITY_OF_TANK;
            int sumWater = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());
                if (quantitiesOfWater>decreasedCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                decreasedCapacity -= quantitiesOfWater;
                sumWater += quantitiesOfWater;
            }
            Console.WriteLine(sumWater);
        }
    }
}
