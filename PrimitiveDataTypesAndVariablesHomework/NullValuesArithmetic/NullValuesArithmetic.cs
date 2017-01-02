using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? number1 = null;
            double? number2 = null;
            Console.WriteLine("{0};{1}", number1, number2);

            number1 = number1 + null;
            number2 = number2 + null;
            Console.WriteLine("{0};{1}", number1, number2);

            number1 = number1 + 33;
            number2 = number2 + 77;
            Console.WriteLine("{0};{1}", number1, number2);
            Console.WriteLine("{0};{1}", number1.GetValueOrDefault(), number2.GetValueOrDefault());
        }
    }
}
