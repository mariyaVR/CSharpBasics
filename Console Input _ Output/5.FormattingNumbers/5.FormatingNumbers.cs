﻿using System;

namespace _5.FormattingNumbers
{
    class FormatingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter first number:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third number:");
            double thirdNum = double.Parse(Console.ReadLine());
            string binaryFirstNum = Convert.ToString(firstNum, 2);
            Console.WriteLine("{0,-10:X} {1,10} {2,10:0.##} {3,-10:0.###}",
            firstNum, binaryFirstNum.PadLeft(10, '0'), secondNum, thirdNum);
        }
    }
}
