using System;

namespace _05._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            
            for (int i = firstInput; i <= secondInput; i++)
            {
                
                Console.Write((char)i + " ");
            }
        }
    }
}