using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string string1 = "Hello";
            string string2 = "World";
            object concatenatedString = string1 + " " + string2;
            string string3 = (string)concatenatedString;
            Console.WriteLine(string3);
        }
    }
}
