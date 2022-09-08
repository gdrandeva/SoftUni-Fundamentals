using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> givenList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            List<int> shiftedList = new List<int>();

            while (input != "End")
            {
                string[] commands = input.Split();

                if (commands[0] == "Add")
                {
                    int number = int.Parse(commands[1]);
                    givenList.Add(number);
                }
                else if (commands[0]=="Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index < 0 && index>givenList.Count)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    givenList.Insert(index,number);
                }
                else if (commands[0] == "Remove")
                {
                    int index = int.Parse(commands[1]);
                    if (index < 0 || index > givenList.Count)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    givenList.RemoveAt(index);
                }
                else if (commands[0] == "Shift")
                {
                    if (commands[1] == "left")
                    {
                        shiftedList.Clear();
                        int count = int.Parse(commands[2]);
                        for (int i = 0; i < count; i++)
                        {
                            
                            shiftedList.Add(givenList[i]);
                        }
                        givenList.RemoveRange(0, count);
                        givenList.AddRange(shiftedList);
                    }
                    else
                    {
                        shiftedList.Clear();
                        int count = int.Parse(commands[2]);
                        for (int i = 0; i < count; i++)
                        {
                            shiftedList.Add(givenList[givenList.Count-1-i]);
                        }
                        givenList.RemoveRange(givenList.Count-count, count);
                        shiftedList.Reverse();
                        givenList.InsertRange(0, shiftedList);
                    }
                }

                input = Console.ReadLine();
            }
           
            Console.WriteLine(string.Join(" ", givenList));
        }

       
    }
}
