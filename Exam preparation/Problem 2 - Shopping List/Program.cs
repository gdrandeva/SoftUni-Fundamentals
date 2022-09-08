using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            string[] command = new string[input.Length];
            string item = string.Empty;
            string oldItem = string.Empty;
            string newItem = string.Empty;

            while (input != "Go Shopping!")
            {
                command = input.Split();
                if (command[0] == "Urgent")
                {
                    item = command[1];
                    
                    if (groceries.Contains(item))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    item = command[1];
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command[0] == "Correct")
                {
                    oldItem = command[1];
                    newItem = command[2];
                    if (groceries.Contains(oldItem))
                    {
                        //int replaceable = groceries.IndexOf(oldItem);
                        //groceries[replaceable] = newItem;
                        for (int i = 0; i < groceries.Count - 1; i++)
                        {
                            if (groceries[i] == oldItem)
                            {
                                groceries.Insert(i, newItem);
                                groceries.Remove(oldItem);
                            }

                        }
                        input = Console.ReadLine();
                        continue;
                    }

                }
                else if (command[0] == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }
                    input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceries));

        }
    }
}
