using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            string inputConvert = input.ToString();
            int outNumber = 0;
            int sum = 0;

            for (int i = 0; i < inputConvert.Length; i++)
            {

                outNumber = input % 10;
                input = input / 10;
                sum += outNumber;

            }
            Console.WriteLine(sum);

        }
    }
}
