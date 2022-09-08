using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Capacity = 255;

            int nLines = int.Parse(Console.ReadLine());

            int totalQuantity = Capacity;

            for (int i = 0; i < nLines; i++)
            {
                int currentQuantity = int.Parse(Console.ReadLine());

                if (totalQuantity - currentQuantity >= 0)
                {
                    totalQuantity -= currentQuantity;
                      
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            int totalFieldQuantity = Capacity - totalQuantity;

            Console.WriteLine(totalFieldQuantity);

            // solution #2
            //int numberOfRows = int.Parse(Console.ReadLine());
            //const int CAPACITY_OF_TANK = 255;
            //int decreasedCapacity = CAPACITY_OF_TANK;
            //int sumWater = 0;

            //for (int i = 0; i < numberOfRows; i++)
            //{
            //    int quantitiesOfWater = int.Parse(Console.ReadLine());
            //    if (quantitiesOfWater > decreasedCapacity)
            //    {
            //        Console.WriteLine("Insufficient capacity!");
            //        continue;
            //    }
            //    decreasedCapacity -= quantitiesOfWater;
            //    sumWater += quantitiesOfWater;
            //}
            //Console.WriteLine(sumWater);
        }
    }
}
