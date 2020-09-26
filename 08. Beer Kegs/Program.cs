using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string bigKeg = string.Empty;
  
            double maxKeg = double.MinValue;

            for (int i = 0; i < input; i++)
            {
                string model = Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());

                int height = int.Parse(Console.ReadLine());

                double sum = Math.PI * Math.Pow(radius, 2) * height;

                if (maxKeg < sum)
                {
                    maxKeg = sum;
                    bigKeg = model;

                }

            }

            Console.WriteLine(bigKeg);

        }
    }
}