using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
           
            StringBuilder validUsernames = new StringBuilder();

            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    for (int i = 0; i < username.Length; i++)
                    {
                        char currentChar = username[i];
                        if (char.IsLetterOrDigit(currentChar) && currentChar=='_' && currentChar=='-')
                        {
                            validUsernames.Append(username);
                        }
                        
                    }
                    
                }
                
               
            }
            
            Console.WriteLine(validUsernames);
        }
    }
}
