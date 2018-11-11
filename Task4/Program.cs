using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            int mask = 1 << number;
            int integer = int.Parse(Console.ReadLine());
            int result = integer & mask;
            bool isThirdBit1 = result > 0;
            Console.WriteLine(isThirdBit1);

        }
    }
}
