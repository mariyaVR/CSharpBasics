using System;

namespace _5.Calculation
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double sum = 1d;
            ulong factorial = 1u;
            double rooted = 0d;

            for (uint i = 1; i <= n; i++)
            {
                factorial *= i;
                rooted = Math.Pow(x, i);
                sum += (factorial / rooted);
            }
            Console.WriteLine("{0:F5}", sum);
        }  
    }
}
