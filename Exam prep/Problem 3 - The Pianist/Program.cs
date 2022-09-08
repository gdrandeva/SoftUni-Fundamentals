using System;
using System.Collections.Generic;

namespace Problem_3___The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            var music = new Dictionary<string, Dictionary<string, string>>();
            List<string> order = new List<string>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] peaceInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string piece = peaceInfo[0];
                string composer = peaceInfo[1];
                string key = peaceInfo[2];

                if (!music.ContainsKey(piece))
                {
                    music.Add(piece, new Dictionary<string, string>());
                    music[piece].Add(composer, key);
                    order.Add(piece);
                }

                string play = Console.ReadLine();

                while (play != "Stop")
                {
                    string[] commands = play.Split('|');
                    string peace = commands[1];
                    switch (commands[0])
                    {
                        case "Add":
                            {
                                string composer = commands[2];
                                string key = commands[3];

                                if (!music.ContainsKey(peace))
                                {
                                    music.Add(peace, new Dictionary<string, string>());
                                    music[piece].Add(composer, key);
                                    order.Add(peace);
                                }
                                else
                                {
                                    Console.WriteLine($"{piece} is already in the collection!");
                                }
                            }
                            break;
                        case "ChangeKey":
                            {
                                string newKey = commands[2];
                                if (music.ContainsKey(peace))
                                {
                                    var peaceData = music[peace];
                                    var composer = peaceData.Keys;
                                    music[peace] = new Dictionary<string, string>();
                                    music[peace].Add(composer,newKey);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                                }
                            }
                            break;
                        case "Remove":
                            {
                                if (music.ContainsKey(peace))
                                {
                                    music.Remove(peace);
                                    Console.WriteLine($"Successfully removed {piece}!");
                                    order.Remove(peace);
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                                }
                            }
                            break;
                       
                    }

                    play = Console.ReadLine();
                }

                foreach (var peace in order)
                {
                    Console.WriteLine($"{peace} -> Composer: {composer}, Key: {key}");
                }

                
            }
        }
    }
}
