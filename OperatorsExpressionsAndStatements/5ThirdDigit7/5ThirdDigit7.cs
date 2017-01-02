using System;

class ThirdDigit7
{

    private static bool IsSeven(int number)
    {
        bool isSeven = false;
        int third = new int();
        for (int i = 0; i < 3; i++)
        { 
            third = number % 10;
            number /= 10;
        }
        if (third == 7)
        {
            isSeven = true;
        }
        return isSeven;
    }

    private static void PrintIsSeven(int number)
    {
        Console.WriteLine("The third digit of {0} is 7: {1}", number, IsSeven(number));
    }

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        PrintIsSeven(number);
    }
}