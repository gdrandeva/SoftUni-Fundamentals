using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergentBottles = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int dishes = 0;
            int detergentBottlesMl = detergentBottles * 750;
            int potMl = 15;
            int dishMl = 5;
            int counter = 0;
            int detergentMl = 0;
            int dishCounter = 0;
            int potCounter = 0;

            while (input!="End")
            {
                dishes = int.Parse(input);
                counter++;
                if (counter%3==0)
                {
                    detergentMl = dishes * potMl;
                    detergentBottlesMl -= detergentMl;
                    potCounter = dishes;
                    continue;
                }
                detergentMl = dishes * dishMl;
                detergentBottlesMl -= detergentMl;
                dishCounter += dishes;

                if (detergentMl==0)
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{dishCounter} dishes and {potCounter} pots were washed.");
                    Console.WriteLine($"Leftover detergent {detergentBottlesMl} ml.");
                }
                else if(detergentBottlesMl<detergentMl)
                {
                    Console.WriteLine($"Not enough detergent, {detergentMl-detergentBottlesMl} ml. more necessary!");
                }
                

                input = Console.ReadLine();
            }

        }
    }
}
