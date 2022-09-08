using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> animals = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, List<string>> hungryAnimals = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            string name = string.Empty;
            string area = string.Empty;
            int neededFood = 0;
            int givenFood = 0;
            int foodQuantity = 0;
            var value = 0;
            string[] separators = new string[] {": ","-"};
            while (command!="EndDay")
            {

                string[] tokens = command.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Add":
                        name = tokens[1];
                        neededFood = int.Parse(tokens[2]);
                        area = tokens[3];
                        Add(name, neededFood, foodQuantity, area, animals,hungryAnimals);
                        break;
                    case "Feed":
                        name = tokens[1];
                        givenFood = int.Parse(tokens[2]);
                        Feed(name, neededFood,givenFood,area,animals,hungryAnimals);
                        break;
                    
                }


                command = Console.ReadLine();
            }
            Console.WriteLine("Animals:");
            foreach (var animal in animals)
            {
                foreach (var food in animal.Value)
                {
                Console.WriteLine($"{animal.Key} -> {food.Value}g");

                }
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var hungryAnimal in hungryAnimals)
            {
                if (hungryAnimal.Value.Count!=0)
                {
                Console.WriteLine($"{hungryAnimal.Key}: {hungryAnimal.Value.Count}");

                }
            }

        }

        static void Add(string name, int neededFood, int foodQuantity, string area, Dictionary<string, Dictionary<string, int>> animals, Dictionary<string, List<string>> hungryAnimals)
        {
           
            if (!animals.ContainsKey(name))
            {
                foodQuantity += neededFood;
                animals.Add(name, new Dictionary<string, int>());
                animals[name].Add(area, foodQuantity);
            }
            else if(animals[name].ContainsKey(area))
            {
                foodQuantity = animals[name][area];
                foodQuantity += neededFood;

                animals[name][area] = foodQuantity;
            }
            if (hungryAnimals.ContainsKey(area) && (!hungryAnimals[area].Contains(name)))
            {
                hungryAnimals[area].Add(name);
            }
            else if(!hungryAnimals.ContainsKey(area))
            {
            hungryAnimals.Add(area, new List<string>());
            hungryAnimals[area].Add(name);
            }
        }

        static void Feed(string name, int foodQuantity, int givenFood, string area, Dictionary<string, Dictionary<string, int>> animals, Dictionary<string, List<string>> hungryAnimals)
        {
            var leftFood = 0;
            if (animals.ContainsKey(name))
            {
                foreach (var key in animals.Keys)
                {
                    foreach (var innerKey in animals[key])
                    {
                        if (name == key)
                        {
                            area = innerKey.Key;
                        }
                    }
                }

                if (animals[name].ContainsKey(area))
                {
                    animals[name][area] -= givenFood;
                    leftFood = animals[name][area];


                }
                if (leftFood <= 0)
                {
                    hungryAnimals[area].Remove(name);
                    animals.Remove(name);
                    Console.WriteLine($"{name} was successfully fed");
                }
            }
            


            
           
        }
    }
}
