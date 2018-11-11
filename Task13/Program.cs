using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            string nString = Console.ReadLine();
            int n = int.Parse(nString);

            Console.Write("p: ");
            string pString = Console.ReadLine();
            int p = int.Parse(pString);

            Console.Write("v: ");
            string vString = Console.ReadLine();
            int v = int.Parse(vString);

            int mask = n << p;
            n = n & (~(1 << p));
            int result = n | mask;
            Console.WriteLine(result);
        }
    }
}
