using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Reveal")
            {
                string[] cmdTokens = commands.Split(":|:");

                switch (cmdTokens[0])
                {
                    case "ChangeAll":
                        {
                            string substring = cmdTokens[1];
                            string replacement = cmdTokens[2];
                            message = message.Replace(substring, replacement);
                        }
                            break;
                       
                    case "Reverse":
                        {
                            string substring = cmdTokens[1];
                            if (message.Contains(substring))
                            {
                                int index = message.IndexOf(substring);
                                message = message.Remove(index,substring.Length);
                                message = message + string.Join("", substring.Reverse());
                                    
                            }
                            else
                            {
                                Console.WriteLine("error");
                                commands = Console.ReadLine();
                                continue;
                            }
                           
                        }
                        break;
                        
                    case "InsertSpace":
                        {
                            int index = int.Parse(cmdTokens[1]);
                            message = message.Insert(index," ");

                        }
                        break;
                    
                }
                Console.WriteLine(message);
                commands = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
