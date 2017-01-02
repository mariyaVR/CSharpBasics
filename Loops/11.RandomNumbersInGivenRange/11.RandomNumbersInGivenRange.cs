using System;

namespace _11.RandomNumbersInGivenRange
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            max += 1;
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomNum = rng.Next(min, max);
                Console.Write(randomNum + " ");
            }
            Console.WriteLine();
        }
    }
}
