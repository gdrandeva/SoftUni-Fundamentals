using System;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInGroup = int.Parse(Console.ReadLine());
            //double discount = 0.0;
            double vipTicketPrice = 499.99;
            double normalTicketPrice = 249.99;
            double transportationSum = 0.0;

            switch (category)
            {
                case "VIP":
                    if (peopleInGroup <= 4)
                    {
                        transportationSum = 0.75;
                    }
                    else if (peopleInGroup <=9)
                    {
                        transportationSum = 0.6;
                    }
                    else if (peopleInGroup<=24)
                    {
                        transportationSum = 0.5;
                    }
                    else if (peopleInGroup <= 49)
                    {
                        transportationSum = 0.4;
                    }
                    else if (peopleInGroup >= 50)
                    {
                        transportationSum = 0.25;
                    }
                   
                    break;
                case "Normal":
                    if (peopleInGroup <= 4)
                    {
                        transportationSum = 0.75;
                    }
                    else if (peopleInGroup <= 9)
                    {
                        transportationSum = 0.6;
                    }
                    else if (peopleInGroup <= 24)
                    {
                        transportationSum = 0.5;
                    }
                    else if (peopleInGroup <= 49)
                    {
                        transportationSum = 0.4;
                    }
                    else if (peopleInGroup >= 50)
                    {
                        transportationSum = 0.25;
                    }
                   

                    break;

            }
            transportationSum = transportationSum * budget;
            budget -= transportationSum;

            if (category=="VIP" )
            {
                if (budget/vipTicketPrice >= peopleInGroup)
                {
                    Console.WriteLine($"Yes! You have {budget - peopleInGroup*vipTicketPrice:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budget - peopleInGroup * vipTicketPrice):f2} leva.");
                }
            }
            else if (category=="Normal")
            {
                if (budget / normalTicketPrice >= peopleInGroup)
                {
                    Console.WriteLine($"Yes! You have {budget - peopleInGroup * normalTicketPrice:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budget - peopleInGroup * normalTicketPrice):f2} leva.");
                }
            }



        }

    }
}
