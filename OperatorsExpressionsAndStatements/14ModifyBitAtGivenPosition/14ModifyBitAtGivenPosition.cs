using System;

class ModifyIntegerBit
{

    private static int Modifier(int number, int position, int value)
    {
        int bit;
        if (value == 0)
        {
            bit = number & ~(1 << position);
        }
        else
        {
            bit = number | (1 << position);
        }
        return bit;
    }

    private static void PrintModifier(int number, int position, int value)
    {
        Console.WriteLine("Number {0} with changed bit {1} to value {2} is {3}.",
            number, position, value, Modifier(number, position, value));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position of the bite");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for the bit (0 or 1)");
        int v = int.Parse(Console.ReadLine());
        PrintModifier(n, p, v);
    }
}