using System;

namespace _01._Integer_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());
            int fourthInput = int.Parse(Console.ReadLine());

             int sumFirstSecondInput = firstInput + secondInput;
            int devide = sumFirstSecondInput / thirdInput;
            int totalSum = devide * fourthInput;
            Console.WriteLine(totalSum); ;


        }
    }
}
