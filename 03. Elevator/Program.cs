using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;

            if (numberOfPeople % capacity == 0)
            {
                courses += numberOfPeople / capacity;
            }
            else if (numberOfPeople % capacity == 2)
            {
                courses += numberOfPeople / capacity;
            }

            courses = (int)Math.Ceiling((double)numberOfPeople / capacity);

            Console.WriteLine(courses);
        }
    }
}