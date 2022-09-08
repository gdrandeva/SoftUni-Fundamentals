using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> winningDeck = new List<int>();


            while (firstHand.Count != 0 && secondHand.Count != 0)
            {

                if (firstHand[0] > secondHand[0])
                {
                    winningDeck.Clear();
                    winningDeck.Add(secondHand[0]);
                    winningDeck.Add(firstHand[0]);
                    secondHand.RemoveAt(0);
                    firstHand.RemoveAt(0);
                    firstHand.AddRange(winningDeck);
                }
                else if (firstHand[0] < secondHand[0])
                {
                    winningDeck.Clear();
                    winningDeck.Add(firstHand[0]);
                    winningDeck.Add(secondHand[0]);
                    secondHand.RemoveAt(0);
                    firstHand.RemoveAt(0);
                    secondHand.AddRange(winningDeck);
                }
                else if (firstHand[0] == secondHand[0])
                {
                    secondHand.RemoveAt(0);
                    firstHand.RemoveAt(0);
                }

            }

            if (firstHand.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }




        }
    }
}
