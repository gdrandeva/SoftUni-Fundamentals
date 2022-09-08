using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            Song song = new Song();

            for (int i = 1; i <= numberOfSongs; i++)
            {

                string[] input = Console.ReadLine().Split('_');
                song.TypeList = input[0];
                song.Name = input[1];
                song.Time = input[2];

            }
            string action = Console.ReadLine();
            switch (song.TypeList)
            {
                case "":
                default:
                    break;
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
