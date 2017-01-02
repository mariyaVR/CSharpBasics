using System;

namespace _7.Factorials2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int nFacturial = 1;
            int kFacturial = 1;
            int diffFacturial = 1; //lenght n - k;
            int diff = n - k;
            int len = Math.Max(n, k);

            for (int i = 1; i <= len; i++)
            {
                if (i <= n)
                {
                    nFacturial *= i;
                }
                if (i <= k)
                {
                    kFacturial *= i;
                }
                if (i <= diff)
                {
                    diffFacturial *= i;
                }
            }
            int result = nFacturial / (kFacturial * diffFacturial);
            Console.WriteLine(result);
        }
    }
}
