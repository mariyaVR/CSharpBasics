﻿
using System;

class CheckBit
{
    private static int Extractor(int number, int position)
    {
        int bit = (number >> position) & 1;
        return bit;
    }

    private static bool IsOne(int number, int position)
    {
        bool isOne = false;
        if (Extractor(number, position) == 1)
        {
            isOne = true;
        }
        return isOne;
    }

    private static void PrintExtractor(int number, int position)
    {
        Console.WriteLine("n = {0} has one as {1} bit: {2}", number, position, IsOne(number, position));
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