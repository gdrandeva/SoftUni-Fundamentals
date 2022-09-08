using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Dictionary<int, int>> targetedCities = new Dictionary<string, Dictionary<int, int>>();
            string town=string.Empty;
            int population=0;
            int gold=0;
            while (true)
            {
                string firstCommand = Console.ReadLine();
                if (firstCommand == "Sail")
                {
                    break;
                }
                string[] tokens = firstCommand.Split("||", StringSplitOptions.RemoveEmptyEntries);
                //TargetedCities(tokens, targetedCities,town,population,gold);




            }
        }

       
    }
    class Town
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }


        public void TargetedCities(string[] tokens, Dictionary<string, Dictionary<int, int>> targetedCities, string town, int population, int gold)
        {
            
        }
    }
}
