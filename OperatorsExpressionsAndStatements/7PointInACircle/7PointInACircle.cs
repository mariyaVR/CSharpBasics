using System;

class PointInACircle
{

    private static bool IsInsideCircle(double x, double y)
    {
        bool isInsideCircle = false;
        double radius = Math.Pow(2, 2);
        double num = (Math.Pow(x, 2) + Math.Pow(y, 2));
        if (num <= radius)
        {
            isInsideCircle = true;
        }
        return isInsideCircle;
    }

    private static void PrintIsInside(double x, double y)
    {
        Console.WriteLine("(" + x + "," + y + ") is inside: " + IsInsideCircle(x, y));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("x = ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("y = ");
        double num2 = double.Parse(Console.ReadLine());
        PrintIsInside(num1, num2);
    }
}