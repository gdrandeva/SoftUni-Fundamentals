using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int buscuitsForDayPerWorker = int.Parse(Console.ReadLine());
            int workersCountInMyFactory = int.Parse(Console.ReadLine());
            int competingFactroryProdPerMonth = int.Parse(Console.ReadLine());
            double dailyProduction = 0;
            double monthlyAmountOfBiscuits = 0;

            for (int day = 1; day <= 30; day++)
            {
                if (day%3==0)
                {
                    dailyProduction = Math.Floor((buscuitsForDayPerWorker * workersCountInMyFactory)*0.75);
                   
                }
                else
                {
                    dailyProduction = buscuitsForDayPerWorker * workersCountInMyFactory;
                }
               
                monthlyAmountOfBiscuits += dailyProduction;
            }

            Console.WriteLine($"You have produced {monthlyAmountOfBiscuits} biscuits for the past month.");

            if (monthlyAmountOfBiscuits>competingFactroryProdPerMonth)
            {
                double difference = (monthlyAmountOfBiscuits - competingFactroryProdPerMonth) / competingFactroryProdPerMonth * 100;
                Console.WriteLine($"You produce {difference:f2} percent more biscuits.");
            }
            else if (monthlyAmountOfBiscuits<competingFactroryProdPerMonth)
            {
                double difference = (competingFactroryProdPerMonth - monthlyAmountOfBiscuits) / competingFactroryProdPerMonth * 100;
                Console.WriteLine($"You produce {difference:f2} percent less biscuits.");
            }
        }
    }
}
