using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfSequences = int.Parse(Console.ReadLine());
            int currentSequenceCount = 0;
            int bestSequenceCount = 0;
            List<int> bestDna = new List<int>();
            int currentIndex = 0;
            int bestIndex = 0;
            int sumOfBestDna = 0;
            
            string command = Console.ReadLine();


            while (true)
            {

                if (command == "Clone them!")
                {
                    break;
                }


                int[] currentDna = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();//1!0!1!1!0 => 1 0 1 1 0

                for (int i = 0; i < currentDna.Length; i++)
                {
                    bestDna.Add(currentDna[i]);
                    if (currentDna[i] != '1')
                    {
                        currentSequenceCount = 0;
                        continue;
                    }
                    else if (currentDna[i] == '1')
                    {
                        currentSequenceCount++;
                        if (currentSequenceCount>bestSequenceCount)
                        {
                            bestSequenceCount = currentSequenceCount;
                            currentIndex = i;
                            currentIndex -= bestSequenceCount + 1;
                            sumOfBestDna = currentDna.Sum();
                        }
                    }
                   
                }
               
                command = Console.ReadLine();

            }


            //Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            //Console.WriteLine($"{DNA sequence, joined by space}");
        }
    }
}
