using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            bool abool = number % 2 == 0;
            Console.WriteLine(abool);
        }
    }
}
