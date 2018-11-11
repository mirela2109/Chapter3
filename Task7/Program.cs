using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your weight: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double moon = number * 0.17;
            Console.WriteLine("Your weight on the moon: " + moon);
        }
    }
}