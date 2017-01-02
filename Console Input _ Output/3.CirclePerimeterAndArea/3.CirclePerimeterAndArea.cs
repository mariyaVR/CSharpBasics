using System;

namespace _3.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Please enter radius:");
            double r = float.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Perimeter = {0:F2}\nArea = {1:F2}", perimeter, area);
        }
    }
}
