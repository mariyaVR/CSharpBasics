using System;

class DivideBy7And5
{

    private static bool Devider(int number)
    {
        bool remainder = false;
        if (number % 5 == 0 && number % 7 == 0 && number != 0)
        {
            remainder = true;
        }
        return remainder;
    }

    private static void PrintDevider(int number, bool devider)
    {
        Console.WriteLine("Number {0} can be divided (without remainder) by 7 and 5 in the same time: {1}",
            number, Devider(number));
    }

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        PrintDevider(number, Devider(number));
    }
}