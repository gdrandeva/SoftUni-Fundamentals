using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = Console.ReadLine();
            string[] command = new string[] { };
            int value = 0;
            int replacement = 0;

            while (input != "Finish")
            {
                command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        value = int.Parse(command[1]);
                        numbers.Add(value);
                        break;
                    case "Remove":
                        value = int.Parse(command[1]);
                        if (numbers.Contains(value))
                        {
                            for (int i = 0; i < numbers.Count - 1; i++)
                            {
                                if (numbers[i] == value)
                                {
                                    numbers.Remove(value);
                                }
                            }
                        }
                        
                        break;
                    case "Replace":
                        value = int.Parse(command[1]);
                        replacement = int.Parse(command[2]);
                        if (numbers.Contains(value))
                        {
                            if (value!=replacement)
                            {
                                int index = numbers.IndexOf(value);
                                if (index != -1)
                                {
                                    numbers[index] = replacement;
                                }
                            }
                           
                        }
                        break;
                    case "Collapse":
                        value = int.Parse(command[1]);
                        List<int> list = new List<int>();
                        int indexToRemove = 0;
                        foreach (int num in numbers)
                        {
                            if (num<value)
                            {
                               list.Add(num);
                                indexToRemove = list.Count;
                            }
                        }
                        for (int i = 0; i < list.Count; i++)
                        {
                            numbers.Remove(list[i]);
                        }
                       
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
