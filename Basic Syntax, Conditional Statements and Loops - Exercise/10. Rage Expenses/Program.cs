using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            int trashedKeyboardCount = 0;


            for (int i = 1; i <=lostGamesCount; i++)
            {
                //gamesCounter++;
                if (i % 2 == 0 && i % 3 == 0)
                {
                    headsetCount++;
                    mouseCount++;
                    keyboardCount++;
                    trashedKeyboardCount++;
                    if (trashedKeyboardCount == 2)
                    {
                        displayCount++;
                    }
                }
                else if (i % 2 == 0)
                {
                    headsetCount++;
                }
                else if (i % 3 == 0)
                {
                    mouseCount++;
                }
                

            }
            rageExpenses = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");


        }
    }
}
