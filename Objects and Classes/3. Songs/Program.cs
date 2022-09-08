using System;
using System.Linq;

namespace _3._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "all")
                {
                    break;
                }
                for (int i = 0; i < songsCount; i++)
                {
                    Song infoBySongs = new Song();
                    infoBySongs.TypeList
                    
                }
            }

        }
    }
    class Song
    {

        
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
