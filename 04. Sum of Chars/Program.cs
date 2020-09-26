using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());


            int totalSum = 0;

            for (int i = 0; i < input; i++)
            {
                int a = 0;
                string lines = Console.ReadLine();
                totalSum += lines[a];

            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
