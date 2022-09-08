using System;

namespace _4._Back_in_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int backInMin = minutes + 30;

            if (backInMin>=60)
            {
                backInMin -= 60;
                hours++;
                if (hours==24)
                {
                    hours = 0;
                }
            }

            Console.WriteLine($"{hours}:{backInMin:d2}");

        }
    }
}
