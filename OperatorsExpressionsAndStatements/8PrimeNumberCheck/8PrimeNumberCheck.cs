using System;

class PrimeNumberChecker
{

    private static bool IsPrime(int number)
    {
        bool isPrime = true;
        int devider = 2;
        if (number == 1)
        {
            isPrime = false;
            return isPrime;
        }
        while (devider < 100)
        {
            if (devider != number)
            {
                if (number % devider != 0)
                {
                    devider++;
                }
                else
                {
                    isPrime = false;
                    break;
                }
            }
            else
            {
                break;
            }
        }
        return isPrime;
    }

    private static void PrintIsPrime(int number)
    {
        Console.WriteLine("Number {0} is prime: {1}", number, IsPrime(number));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        int n = int.Parse(Console.ReadLine());
        if (n >= 100)
        {
            throw new ArgumentOutOfRangeException();
        }
        PrintIsPrime(n);
    }
}
