using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            string aString = Console.ReadLine();
            double a = double.Parse(aString);
            Console.Write("b: ");
            string bString = Console.ReadLine();
            double b = double.Parse(bString);
            Console.Write("h: ");
            string hString = Console.ReadLine();
            double h = double.Parse(hString);
            double S = ((a + b) / 2) * h;
            Console.WriteLine("S: "+S);
        }
    }
}
