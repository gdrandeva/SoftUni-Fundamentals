using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine(); 
            int indices = 0;
            int count = 0;

            while (command != "End")
            {
                indices = int.Parse(command);
                if (indices<0 || indices>input.Count-1)
                {
                    command = Console.ReadLine();
                    continue;
                }
                int currentTarget = input[indices];
                input.RemoveAt(indices);
                count++;
                input.Insert(indices, -1);
                for (int i = 0; i <= input.Count-1; i++)
                {
                    if (input[i]!= -1 && input[i]>currentTarget)
                    {
                        input[i] -= currentTarget;
                    }
                    else if (input[i] != -1 && input[i]<=currentTarget)
                    {
                        input[i] += currentTarget;
                    }
                }

               
                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", input)}");
        }
    }
}
