using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {

            int NpokePower = int.Parse(Console.ReadLine());
            int Mdistance = int.Parse(Console.ReadLine());
            int Yexhaustion = int.Parse(Console.ReadLine());

            int count = 0;
            double Npower = NpokePower * 0.50;

            while (NpokePower >= Mdistance)
            {
                count++;
                if (NpokePower >= 0)
                {
                    NpokePower -= Mdistance;
                }

                if (NpokePower == Npower && Yexhaustion !=0)
                {
                    NpokePower = NpokePower / Yexhaustion;

                }
              
            }

            Console.WriteLine(NpokePower);
            Console.WriteLine(count);

        }
    }
}
