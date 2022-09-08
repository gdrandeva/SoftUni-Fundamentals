using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._Imitation_game
{
    class Program
    {
        static void Main(string[] args)
        {

            //               "Move {number of letters}":
            //                Moves the first n letters to the back of the string
            //•	              "Insert {index} {value}":
            //o                Inserts the given value before the given index in the string
            //•	               "ChangeAll {substring} {replacement}":
            //o                Changes all occurrences of the given substring with the replacement text

            StringBuilder encryptedMessage = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();
            while (command!="Decode")
            {
                string[] tokens = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                
                string action = tokens[0];
                switch (action)
                {
                    case "Move":
                        int numberOfLetters = int.Parse(tokens[1]);
                        for (int i = 0; i < numberOfLetters; i++)
                        {
                            char currentChar = encryptedMessage[i];
                            encryptedMessage.Append(encryptedMessage[i]);
                        }
                            encryptedMessage.Remove(0, numberOfLetters);
                        
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string value = tokens[2];
                        encryptedMessage.Insert(index, value);
                        
                        break;
                    case "ChangeAll":
                        string substring = tokens[1];
                        string replacement = tokens[2];
                        while (encryptedMessage.ToString().Contains(substring))
                        {
                            encryptedMessage.Replace(substring, replacement);
                        }
                        break;
                   
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
