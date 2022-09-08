using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> targets = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = Console.ReadLine();
            string[] command = new string[input.Length];
            int index = 0;
            int power = 0;
            int value = 0;
            int radius = 0;

            while (true)
            {
                command = input.Split();

                switch (command[0])
                {
                    case "Shoot":
                        index = int.Parse(command[1]);
                        power = int.Parse(command[2]);
                        targets=Shoot(index, power, targets);
                        //for (int i = 0; i <= targets.Count-1; i++)
                        //{
                        //    if (i==index)
                        //    {
                        //        targets[i] -= power;
                        //        if (targets[i]<=0)
                        //        {
                        //            targets.RemoveAt(i);
                        //        }
                               
                        //    }
                        //}
                        break;
                    case "Add":
                        index = int.Parse(command[1]);
                        value = int.Parse(command[2]);
                        if (index<0 || index>targets.Count-1)
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        else
                        {
                            targets.Insert(index, value);
                        }
                        break;
                    case "Strike":
                        index = int.Parse(command[1]);
                        radius = int.Parse(command[2]);
                       
                        if (index - radius < 0 || index + radius > targets.Count - 1)
                        {
                            Console.WriteLine("Strike missed!");
                            break;
                            
                        }

                        targets.RemoveRange(index - radius, radius * 2 + 1);
                        break;
                }
                if (input=="End")
                {
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
            
        }

        static List<int> Shoot(int index, int power, List<int> targets)
        {
            for (int i = 0; i <= targets.Count - 1; i++)
            {
                if (i == index)
                {
                    targets[i] -= power;
                    if (targets[i] <= 0)
                    {
                        targets.RemoveAt(i);
                    }

                }
            }
            return targets;
        }
    }
}
