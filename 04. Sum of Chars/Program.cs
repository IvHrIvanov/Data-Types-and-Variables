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
                string lines = Console.ReadLine();
                totalSum += lines[i];

            }

            Console.WriteLine($"The sum equels: {totalSum}");
        }
    }
}
