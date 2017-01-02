using System;

namespace _1.N_
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
