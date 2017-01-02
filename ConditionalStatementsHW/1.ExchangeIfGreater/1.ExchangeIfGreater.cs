using System;

namespace _1.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c;
            if (a > b)
            {
                c = b;
                b = a;
                a = c;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
