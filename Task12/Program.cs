using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("v: ");
            string vString = Console.ReadLine();
            int v = int.Parse(vString);
            Console.Write("p: ");
            string pString = Console.ReadLine();
            int p = int.Parse(pString);
            int i = 1;
            int mask = i << p;
            int result = v & mask;
            if (result != 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
