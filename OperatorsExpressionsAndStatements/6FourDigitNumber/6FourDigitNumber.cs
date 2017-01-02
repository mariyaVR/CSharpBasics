using System;

class FourDigitTransformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 4 digit number");
        int number = int.Parse(Console.ReadLine());
        int sum = new int();
        int digit;
        int[] allDigits = new int[4];
        for (int i = 0; i < 4; i++)
        {
            sum += number % 10;
            digit = number % 10;
            allDigits[i] = digit;
            number /= 10;
        }
        Console.WriteLine("The sum of digits is {0}.", sum);
        Console.WriteLine("Digits backwards: ");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(allDigits[i]);
        }
        Console.WriteLine("\nLast digit in first place:");
        Console.Write(allDigits[0]);
        for (int i = 3; i > 0; i--)
        {
            Console.Write(allDigits[i]);
        }
        Console.WriteLine("\nSecond and third digit are swaped:");
        Console.WriteLine("" + allDigits[3] + allDigits[1] + allDigits[2] + allDigits[0]);
    }
}