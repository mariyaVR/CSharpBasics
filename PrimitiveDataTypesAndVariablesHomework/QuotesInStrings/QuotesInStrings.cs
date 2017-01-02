using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string string1 = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(string1);

            string string2 = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(string2);
        }
    }
}
