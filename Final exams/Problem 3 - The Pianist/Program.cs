using System;
using System.Collections.Generic;

namespace Problem_3___The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());
            
            //•	"ChangeKey|{piece}|{new key}":
            //o If the piece is in the collection, change its key with the given one and print:
            //"Changed the key of {piece} to {new key}!"
            //o Otherwise, print:
            //"Invalid operation! {piece} does not exist in the collection."
            //Upon receiving the "Stop" command, you need to print all pieces in your collection in the following format:
            //            "{Piece} -> Composer: {composer}, Key: {key}"
            string piece = string.Empty;
            string composer = string.Empty;
            string key = string.Empty;
            string newKey = string.Empty;
            Dictionary<string, Dictionary<string, string>> list= new Dictionary<string, Dictionary<string, string>>();
            for (int i = 0; i < piecesCount; i++)
            {
                string[] infoByPiece = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                piece = infoByPiece[0];
                composer = infoByPiece[1];
                key = infoByPiece[3];
                list.Add(piece, new Dictionary<string, string>());
                list[piece].Add(composer, key);
            }
                string command = Console.ReadLine();
                
                while (command!="Stop")
                {
                    string[] cmd = command.Split("|",StringSplitOptions.RemoveEmptyEntries);
                    string action = cmd[0];
                    switch (action)
                    {
                        case "Add":
                            piece = cmd[1];
                            composer = cmd[2];
                            key = cmd[3];
                        if (!list.ContainsKey(piece))
                        {
                            list.Add(piece, new Dictionary<string, string>());
                            list[piece].Add(composer,key);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!"); 
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                            break;
                        case "Remove":
                        piece = cmd[1];
                        if (!list.ContainsKey(piece))
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        else
                        {
                            list.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                            break;
                        case "ChangeKey":
                        piece = cmd[1];
                        newKey = cmd[2];
                        if (!list.ContainsKey(piece))
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        else
                        {
                            list[piece].Remove(composer, key);
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                            break;
                        case "":
                            break;
                        default:
                    }

                    command = Console.ReadLine();
                }

            

        }
    }
}
