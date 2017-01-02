using System;

class ExtractBit
{
    private static int Extractor(int number, int position)
    {
        int bit = (number >> position) & 1;
        return bit;
    }

    private static void PrintExtractor(int number, int position)
    {
        Console.WriteLine("n = {0} has {1} as {2} bit", number, Extractor(number, position), position);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position of the bite");
        int position = int.Parse(Console.ReadLine());
        PrintExtractor(number, position);
    }
}