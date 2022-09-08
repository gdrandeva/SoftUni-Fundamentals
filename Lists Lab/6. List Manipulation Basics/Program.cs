using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList() ;
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];
            }
        }
    }
}
