using System;

namespace _05._Constraints
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < input; i++)
            {

                int a = 0;
                string inputChar = Console.ReadLine();
                sum += inputChar[a];

            }

            Console.WriteLine($"The sum equal: {sum}");
        }
    }
}
