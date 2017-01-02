using System;

class PointInsideCircleRectangle
{
    private static bool IsInsideCircle(double x, double y)
    {
        bool isInsideCircle = false;
        double radius = Math.Pow(1.5, 2);
        double num = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2));
        if (num <= radius)
        {
            isInsideCircle = true;
        }
        return isInsideCircle;
    }

    private static bool IsInsideRectangle(double x, double y)
    {
        bool isInsideRectangle = false;
        if (x >= -1 && x <= 5 && y <= 1 && y >= -1)
        {
            isInsideRectangle = true;
        }
        return isInsideRectangle;
    }

    private static bool Condition(double x, double y)
    {
        bool isInsideCircle = IsInsideCircle(x, y);
        bool isInsideRectangle = IsInsideRectangle(x, y);
        if (isInsideCircle == true && isInsideRectangle == true)
        {
            return false;
        }
        else
        {
            return isInsideCircle && !isInsideRectangle;
        }

    }

    private static void PrintCondition(double x, double y)
    {
        Console.WriteLine("Point x = " + x + "y = " + y + "is inside K & outside of R: " +
            (Condition(x, y)));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("x = ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("y = ");
        double num2 = double.Parse(Console.ReadLine());
        PrintCondition(num1, num2);
    }
}