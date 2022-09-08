using System;

namespace Problem_1___Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int wonBattles = 0;
            

            while (input!= "End of battle")
            {
                int distance = int.Parse(input);
                initialEnergy -= distance;
                if (initialEnergy>=0)
                {
                    wonBattles++;
                    if (wonBattles%3==0)
                    {
                        initialEnergy += wonBattles;
                    }
                }
                else if (initialEnergy < 0)
                {
                    initialEnergy = 0;
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initialEnergy} energy");
                    return;

                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnergy}"); 


        }
    }
}
