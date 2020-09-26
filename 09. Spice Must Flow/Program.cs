using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int spicy = int.Parse(Console.ReadLine());

            int workersConsume = 0;
            int days = 0;
            

            while (spicy >= 100)
            {
                days++;
                workersConsume += spicy;
                workersConsume -= 26;                
                spicy -= 10;              
            }
            if (workersConsume >= 26)
            {
                workersConsume -= 26;

            }

            Console.WriteLine(days);
            Console.WriteLine(workersConsume);
        }
    }
}
