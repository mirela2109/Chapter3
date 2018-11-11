using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            string xString = Console.ReadLine();
            int x = int.Parse(xString);
            Console.Write("y: ");
            string yString = Console.ReadLine();
            int y = int.Parse(yString);
            bool inCircle = Math.Sqrt(x * x + y * y) <= 5;
            bool outRectangle = x < -1 || x > 5 || y < 1 || y > 5;
            bool inOut = inCircle && outRectangle;
            Console.WriteLine(inOut);
        }
    }
}
