using System;

class OddandEvenProduct
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] digits = n.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;
        int len = digits.Length;

        for (int i = 1; i <= len; i++)
        {
            if (i % 2 == 0)
            {
                int number = int.Parse(digits[i - 1]);
                evenProduct *= number;
            }
            else
            {
                int number = int.Parse(digits[i - 1]);
                oddProduct *= number;
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes\nproduct = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}",
                oddProduct, evenProduct);
        }

    }
}
