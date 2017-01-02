using System;

class ExtractBit3
{

    private static int Extractor(int number)
    {
        int bit = (number >> 3) & 1;
        return bit;
    }

    private static void PrintExtractor(int number)
    {
        Console.WriteLine("n = {0} has {1} as third bit", number, Extractor(number));
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());
        PrintExtractor(number);
    }
}