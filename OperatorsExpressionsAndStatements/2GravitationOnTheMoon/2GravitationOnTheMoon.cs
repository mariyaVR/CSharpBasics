using System;

class GravitationOnTheMoon
{

    private static void MoonWeight(double weight)
    {
        double weightOnMoon = 0.17 * weight;
        Console.WriteLine("{0} kg on the moon are: {1} kg", weight, weightOnMoon);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your weight(format \"10,0\", not \"10.0\".)");
        double weight = double.Parse(Console.ReadLine()); 
        MoonWeight(weight);
    }
}