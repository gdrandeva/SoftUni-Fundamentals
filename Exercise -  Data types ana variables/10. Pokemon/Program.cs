using System;

namespace _10._Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int countPokes = 0;
            int originalN = pokePowerN;
            //int remainedOfN = 0;

            while (pokePowerN >= distanceM)
            {
                countPokes++;
               
                pokePowerN -= distanceM;
                if (pokePowerN == originalN * 0.5 && exhaustionFactorY>0)
                {
                    
                        pokePowerN = pokePowerN / exhaustionFactorY;
                    

                }
            }



            Console.WriteLine(pokePowerN);
            Console.WriteLine(countPokes);



        }
    }
}
