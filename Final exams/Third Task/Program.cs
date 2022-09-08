using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Third_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> animalsList = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> hungryAreas = new Dictionary<string, int>();
            string animal = string.Empty;
            string area = string.Empty;
            int neededFood = 0;
            int food = 0;
            int initialCountOfAnimals = 0;
            int fedCount = 0;
            int hungryCount = 0;
            string command = Console.ReadLine();
            char[] separators = new char[] { ':', '-' };
            while (command != "EndDay")
            {
                string[] tokens = command.Split(separators);
                string action = tokens[0];

                switch (action)
                {
                    case "Add":
                        //animalsList = AddAnimalInfo(tokens, animal, neededFood, area, animalsList, initialCountOfAnimals);
                        animal = tokens[1];
                        neededFood = int.Parse(tokens[2]);
                        area = tokens[3];
                        if (!animalsList.ContainsKey(animal))
                        {
                            initialCountOfAnimals++;
                            animalsList.Add(animal, new Dictionary<string, int>());
                            animalsList[animal].Add(area, neededFood);
                            if (!hungryAreas.ContainsKey(area))
                            {
                                hungryCount++;
                                hungryAreas.Add(area, hungryCount);
                                hungryCount = 0;
                            }
                        }
                        else
                        {
                            if (animalsList[animal].ContainsKey(area))
                            {
                                var value = animalsList[animal][area] += neededFood;
                                animalsList[animal].TryAdd(area, neededFood);
                            }
                        }

                        break;
                    case "Feed":
                        // animalsList = Feed(tokens, animal, food, animalsList, fedCount);
                        animal = tokens[1];
                        food = int.Parse(tokens[2]);
                        


                        if (animalsList.ContainsKey(animal))
                        {
                            foreach (var key in animalsList)
                            {
                                foreach (var innerKey in key.Value)
                                {
                                    if (key.Key == animal)
                                    {

                                        area = innerKey.Key;
                                    }
                                }
                            }


                            fedCount++;
                            if (animalsList[animal].ContainsKey(area))
                            {
                                var value = animalsList[animal][area] -= food;
                                animalsList[animal].TryAdd(area, food);
                                if (value <= 0)
                                {
                                    animalsList[animal].Remove(area, out value);
                                    animalsList.Remove(animal);
                                    if (hungryAreas.ContainsKey(area))
                                    {
                                        hungryCount--;
                                        hungryAreas.Add(area, hungryCount);
                                    }

                                    Console.WriteLine($"{animal} was successfully fed");
                                }
                            }

                        }
                        else if (!animalsList.ContainsKey(animal))
                        {
                            break;
                        }

                        break;

                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Animals:");
            foreach (var animalName in animalsList)
            {
                foreach (var animalArea in animalName.Value)
                {
                    Console.WriteLine($"{animalName.Key} -> {animalArea.Value}g");
                }
            }

            
            Console.WriteLine($"Areas with hungry animals:");
            foreach (var hungry in hungryAreas)
            {
                Console.WriteLine($"{hungry.Key}: {hungry.Value}");
            }
        }

    }
}
