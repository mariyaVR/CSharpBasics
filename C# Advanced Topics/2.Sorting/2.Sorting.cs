using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DifferenceBetweenDates
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];

        for (int i = 0; i < length; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }
        Array.Sort(numbers);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}