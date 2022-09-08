using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> originalList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Delete")
                {
                    int currentNum = int.Parse(command[1]);


                    for (int i = 0; i <= originalList.Count; i++)
                    {

                        if (originalList.Contains(currentNum))
                        {
                            originalList.Remove(currentNum);
                        }

                    }
                }
                else if (command[0] == "Insert")
                {
                    int currentNum = int.Parse(command[1]);
                    int currentPosition = int.Parse(command[2]);
                    originalList.Insert(currentPosition, currentNum);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", originalList));

        }
    }
}
