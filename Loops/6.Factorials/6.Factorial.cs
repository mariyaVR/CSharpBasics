using System;

namespace _6.Factorials
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int nFacturial = 1;
            int kFacturial = 1;
            int len = Math.Max(n, k);
            for (int i = 1; i <= len; i++)
            {
                if (i <= n)
                {
                    nFacturial = nFacturial * i;
                }
                if (i <= k)
                {
                    kFacturial = kFacturial * i;
                }
            }
            int result = nFacturial / kFacturial;
            Console.WriteLine(result);
        }
    }
}
