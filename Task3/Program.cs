using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            string number = Console.ReadLine();
            int a = int.Parse(number);
            int b = a / 100;
            int c= b % 10;
            bool thirdDigit = c == 7;
            Console.WriteLine(thirdDigit);

        }
    }
}
