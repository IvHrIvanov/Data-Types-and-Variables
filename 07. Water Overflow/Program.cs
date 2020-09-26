using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sumlitter = 0;
            int check = 0;
            for (int i = 0; i < input; i++)
            {
                
                int addLiter = int.Parse(Console.ReadLine());
                check += addLiter;
                if(check>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    check -= addLiter;
                    continue;
                }
                sumlitter += addLiter;
            }
            Console.WriteLine(sumlitter);
        }
    }
}
