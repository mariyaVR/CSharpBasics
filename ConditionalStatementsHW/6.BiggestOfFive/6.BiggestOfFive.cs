using System;

namespace _6.BiggestOfFive
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());
            float bigger1 = new float();
            float bigger2 = new float();
            float biggest = new float();

            if (a > b)
            {
                bigger1 = a;
            }
            else
            {
                bigger1 = b;
            }
            if (c > d)
            {
                bigger2 = c;
            }
            else
            {
                bigger2 = d;
            }
            if (bigger1 > bigger2)
            {
                biggest = bigger1;
            }
            else
            {
                biggest = bigger2;
            }
            if (biggest > e)
            {
                Console.WriteLine(biggest);
            }
            else
            {
                Console.WriteLine(e);
            }
        }
    }
}
