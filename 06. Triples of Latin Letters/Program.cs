using System;
using System.Xml;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int a = 0; a < input; a++)
                {
                    for (int b = 0; b < input; b++)
                    {
                        char firstSymbol = (char)(97 + i);
                        char secondSymbol = (char)(97 + a);
                        char thirdSymbol = (char)(97 + b);

                        Console.WriteLine($"{firstSymbol}{secondSymbol}{thirdSymbol}");

                    }
                }
            }
        }
    }
}