using System;

namespace _9._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double costs = 0;
            int countOfStudents = int.Parse(Console.ReadLine());

            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double additionalSabersQuantity = Math.Ceiling(countOfStudents * 0.1);
            double lightSabTotalPrice = (countOfStudents+additionalSabersQuantity)*lightsaberPrice;
            double robesTotalPrice = countOfStudents * robePrice;
            
            double beltTotalPrice = countOfStudents * beltPrice;
            if (countOfStudents>=6)
            {
                int freeBelts = countOfStudents / 6;
                beltTotalPrice -= freeBelts * beltPrice;
            }
            costs = lightSabTotalPrice + robesTotalPrice + beltTotalPrice;
            
            if (money>=costs)
            {
                Console.WriteLine($"The money is enough - it would cost {costs:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(money - costs):f2}lv more.");
            }
        }
    }
}
