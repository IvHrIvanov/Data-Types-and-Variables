using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger bestSbowBall = 0;

            int snollballSnowSave = 0;
            int snowballTimeSave = 0;
            int snowBallQualitySave = 0;


            for (int i = 0; i < input; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger sum = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (bestSbowBall <= sum)
                {
                    snollballSnowSave = snowballSnow;
                    snowBallQualitySave = snowballQuality;
                    snowballTimeSave = snowballTime;
                    bestSbowBall = sum;
                }
            }

            Console.WriteLine($"{snollballSnowSave} : {snowballTimeSave} = {bestSbowBall} ({snowBallQualitySave})");


        }
    }
}
