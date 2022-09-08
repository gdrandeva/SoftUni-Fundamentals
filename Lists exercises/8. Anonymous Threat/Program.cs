using System;
using System.Collections.Generic;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<string> finalResult = new List<string>();
            while (input!= "3:1".Split())
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "merge":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            finalResult.Add(input[i].ToString());
                        }
                        break;
                    case "divide":
                        int index = int.Parse(commands[1]);
                        int partitions = int.Parse(commands[2]);
                        input[index] / 5;                      
                            
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",finalResult));
        }
        
    } 
}


   