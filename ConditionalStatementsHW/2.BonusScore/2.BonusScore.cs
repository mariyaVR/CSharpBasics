using System;

namespace _2.BonusScore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the score:");
            int score = int.Parse(Console.ReadLine());
            if (score <= 0 || score > 9)
            {
                Console.WriteLine("invalid score");
                return;
            }
            else if (score >= 1 && score <= 3)
            {
                score *= 10;
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
            }
            else
            {
                score *= 1000;
            }
            Console.WriteLine("{0}", score);
        }
    }
}
