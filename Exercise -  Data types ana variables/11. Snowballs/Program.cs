using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBalls = int.Parse(Console.ReadLine());

            int snowBallSnow=0;
            int snowBallTime=0;
            int snowBallQualtity=0;
            int snowBallValue = 0;
            int bestBall = int.MinValue;

            for (int i = 1; i <= countOfBalls; i++)
            {
                snowBallSnow = int.Parse(Console.ReadLine());
                snowBallTime = int.Parse(Console.ReadLine());
                snowBallQualtity = int.Parse(Console.ReadLine());

                bestBall = (snowBallSnow / snowBallTime)*Math.Pow(snowBallQualtity, 2);
                
            }

            Console.WriteLine($"{snowBallSnow} : {snowBallTime} = {snowBallValue} ({snowBallQualtity})");
        }
    }
}
