using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("h: ");
            string hString = Console.ReadLine();
            double h = double.Parse(hString);
            Console.Write("b: ");
            string bString = Console.ReadLine();
            double b = double.Parse(bString);
            double P = (h + b) * 2;
            double S = h * b;
            Console.WriteLine("P: "+ P);
            Console.WriteLine("S: "+S);
        }
    }
}
