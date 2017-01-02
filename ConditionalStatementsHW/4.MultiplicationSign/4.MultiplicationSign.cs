using System;

namespace _4.MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            int signCounter = 0;

            if ((first == 0) || (second == 0) || (third == 0))

            {
                Console.WriteLine("0");
            }
            else
            {
                if (first < 0)
                {
                    signCounter++;
                }
                if (second < 0)
                {
                    signCounter++;
                }
                if (third < 0)
                {
                    signCounter++;
                }
                if (signCounter % 2 == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}
