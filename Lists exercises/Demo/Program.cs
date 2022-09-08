using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command!= "end")
            {
                string[] tokens = command.Split();
                if (tokens.Length==2)
                {
                    int wagon = int.Parse(tokens[1]);
                    wagons.Add(wagon);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);
                    FindWagon(wagons, maxCapacity,passengers);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));





            //List<int> listOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            //int capacityOfWagon = int.Parse(Console.ReadLine());
            //string[] command = Console.ReadLine().Split().ToArray();

            //while (command[0] != "end")
            //{

            //    if (command[0] == "Add")
            //    {
            //        listOfWagons.Add(int.Parse(command[1]));

            //    }
            //    else
            //    {
            //        for (int i = 0; i < listOfWagons.Count - 1; i++)
            //        {
            //            int peopleInCurrentWagon = listOfWagons[i];
            //            int newPeopleCount = int.Parse(command[0]);
            //            if (peopleInCurrentWagon + newPeopleCount <= capacityOfWagon)
            //            {
            //                listOfWagons.RemoveAt(i);
            //                listOfWagons.Insert(i, newPeopleCount + peopleInCurrentWagon);
            //                break;

            //            }
            //        }
            //    }
            //    command = Console.ReadLine().Split();
            //}
            //Console.WriteLine(string.Join(" ", listOfWagons));






        }

        static void FindWagon(List<int> wagons, int maxCapacity, int passengers)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int currentWagon = wagons[i];
                if (currentWagon+passengers <= maxCapacity)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }
    }
}
