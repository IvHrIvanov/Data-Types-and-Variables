using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            int coureses = 0;

            while (one > 0)
            {
                one -= two;
                coureses++;

            }
            Console.WriteLine(coureses);
        }
    }
}
