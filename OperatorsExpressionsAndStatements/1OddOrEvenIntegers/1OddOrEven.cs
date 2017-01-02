using System;

class OddOrEven
{

    private static void numIsOdd(int number)
    {
        bool isOdd = true;
        if (number % 2 == 0)
        {
            isOdd = false;
        }
        Console.WriteLine("Number {0} is odd: {1}.", number, isOdd);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());
        numIsOdd(num);
    }
}  

