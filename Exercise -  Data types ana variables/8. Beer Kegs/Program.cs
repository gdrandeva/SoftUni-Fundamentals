using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string currentKeg = string.Empty;
            string model = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
               
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    currentKeg = model;
                }
            }
            Console.WriteLine(currentKeg);

        }
    }
}
