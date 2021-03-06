﻿using System;

class DecToHex
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        string hexNumber = "";
        if (decNumber == 0)
        {
            Console.Write(0);
        }
        while (decNumber != 0)
        {
            long digit = decNumber % 16;
            if (digit >= 0 && digit <= 9)
            {
                hexNumber += "" + digit;
            }
            else
            {
                switch (digit)
                {
                    case 10: hexNumber += "A"; break;
                    case 11: hexNumber += "B"; break;
                    case 12: hexNumber += "C"; break;
                    case 13: hexNumber += "D"; break;
                    case 14: hexNumber += "E"; break;
                    case 15: hexNumber += "F"; break;
                }
            }
            decNumber /= 16;
        }
        
        int len = hexNumber.Length - 1;
        for (int i = len; i >= 0; i--)
        {
            Console.Write(hexNumber[i]);
        }
        Console.WriteLine();
    }
}