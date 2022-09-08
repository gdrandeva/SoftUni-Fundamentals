using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
        
            string[] delimiterChars = {" - " , ":" };
            string[] commands = Console.ReadLine().Split(delimiterChars,StringSplitOptions.RemoveEmptyEntries).ToArray();
            string phone = string.Empty;
            string newPhone = string.Empty;
            string oldPhone = string.Empty;
            
            while (true)
            {
                switch (commands[0])
                {
                    case "Add":
                        phone = commands[1];
                        if (!phones.Contains(phone))
                        {
                            phones.Add(phone);
                        }
                        else
                        {
                            break;
                        }
                        
                        break;
                    case "Remove":
                        phone = commands[1];
                        if (phones.Contains(phone))
                        {
                            phones.Remove(phone);
                        }
                        else
                        {
                            break;
                        }
                        break;
                  
                    case "Bonus phone":
                        oldPhone = commands[1];
                        newPhone = commands[2];
                        if (phones.Contains(oldPhone))
                        {
                            int index = phones.IndexOf(oldPhone);
                            phones.Insert(index + 1, newPhone);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Last":
                        phone = commands[1];
                        if (phones.Contains(phone))
                        {
                            phones.Remove(phone);
                            phones.Add(phone);
                        }
                        break;
                    case "End":
                        Console.WriteLine(string.Join(", ", phones));
                        return;

                }
                       commands = Console.ReadLine().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

        }
    }
}
