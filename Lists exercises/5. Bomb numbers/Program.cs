using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialListOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> officialListOfNumbers = new List<int>();

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            if (initialListOfNumbers.Contains(bomb))
            {
                for (int i = 0; i < initialListOfNumbers.Count-1; i++)
                {
                    int yourBomb = initialListOfNumbers[i];
                    if (yourBomb==bomb)
                    {
                        int from = Math.Max(0, i-power);
                        int to = Math.Min(initialListOfNumbers.Count-1, i+power);
                        for (int j = from; j <= to; j++)
                        {
                            initialListOfNumbers[j] = 0;
                        }
                    }
                }
            }
            


            
            Console.WriteLine(initialListOfNumbers.Sum());
        }
    }
}
