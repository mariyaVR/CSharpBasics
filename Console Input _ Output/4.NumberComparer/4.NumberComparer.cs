using System;

namespace _4.NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number:");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number of {0} and {1} is {2}.",
            firstNumber, secondNumber, Math.Max(firstNumber, secondNumber));
        }
    }
}
