using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, int>();

            string resourses = Console.ReadLine();

            while (resourses != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (! items.ContainsKey(resourses))
                {
                    items.Add(resourses, 0);
                }
                items[resourses] += quantity;



                resourses = Console.ReadLine();
            }

            foreach (var curResourses in items)
            {
                Console.WriteLine($"{curResourses.Key} -> {curResourses.Value}");
            }
        }
    }
}
