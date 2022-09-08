using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfpieces = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, string>> pieceInfo = new Dictionary<string, Dictionary<string, string>>();
            string command = string.Empty;
            string piece = string.Empty;
            string composer = string.Empty;
            string key = string.Empty;
            string newKey = string.Empty;
            List<string> pieceInfoByOrder = new List<string>();
            for (int i = 0; i < numberOfpieces; i++)
            {

                string[] aboutPieces = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                piece = aboutPieces[0];
                composer = aboutPieces[1];
                key = aboutPieces[2];

                pieceInfo.Add(piece, new Dictionary<string, string>());
                pieceInfo[piece].Add(composer, key);
                pieceInfoByOrder.Add(piece);

            }
            command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] commandsArr = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                switch (commandsArr[0])
                {
                    case "Add":
                        {
                            piece = commandsArr[1];
                            composer = commandsArr[2];
                            key = commandsArr[3];
                            if (!pieceInfo.ContainsKey(piece))
                            {
                                pieceInfo.Add(piece, new Dictionary<string, string> { });
                                pieceInfo[piece].TryAdd(composer, key);
                                pieceInfoByOrder.Add(piece);
                                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                            }
                            else
                            {
                                Console.WriteLine($"{piece} is already in the collection!");
                            }
                        }
                        break;
                    case "Remove":
                        {
                            piece = commandsArr[1];

                            if (pieceInfo.ContainsKey(piece))
                            {
                                pieceInfo.Remove(piece);
                                pieceInfoByOrder.Remove(piece);
                                Console.WriteLine($"Successfully removed {piece}!");
                            }
                            else
                            {
                                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            }
                        }
                        break;
                    case "ChangeKey":
                        {
                            piece = commandsArr[1];
                            newKey = commandsArr[2];

                            if (pieceInfo.ContainsKey(piece))
                            {

                                //pieceInfo.Remove(piece);
                                //pieceInfo.Add(piece, new Dictionary<string, string>());
                                pieceInfo[piece].TryAdd(composer, newKey);
                                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                            }
                            else
                            {
                                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            //foreach (var k in pieceInfo.Keys)
            //{
            //    foreach (KeyValuePair<string, string> entry in pieceInfo[k])
            //    {
            //        Console.WriteLine($"{k} -> Composer: {entry.Key}, Key: {entry.Value}");
            //    }
            //}
            foreach (var pieces in pieceInfoByOrder)
            {
                Console.WriteLine($"{piece} -> Composer: {pieceInfo[pieces].Key}, Key: {pieceInfo[piece].Value}");
            }
            foreach (var orderedPiece in pieceInfoByOrder)
                {
                    Console.WriteLine($"{orderedPiece} -> Composer: {pieceInfo[orderedPiece].K}, Key: {pieceInfo[orderedPiece]}");
                }
            
        }
    }
}

