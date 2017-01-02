using System;

namespace _3.MinMaxSumAverage
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many numbers will be entered?");
            int length = int.Parse(Console.ReadLine());

            int sum = new int();
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
                else if (number > max)
                {
                    max = number;
                }
                sum += number;
            }
            float avarage = sum / (float)length;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}",
                min, max, sum, avarage);
        }
    }
}
