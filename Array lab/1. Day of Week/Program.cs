using System;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber>=1 && dayNumber<=7)
            {
                Console.WriteLine(dayOfWeek[dayNumber-1]);
            }
            else 
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
