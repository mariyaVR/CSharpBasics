using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractURLs
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
       
        char[] separators = { ' ' };
        var links = input.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Where(pattern => pattern.StartsWith("http://") || pattern.StartsWith("www."));
        foreach (var link in links)
        {
            Console.WriteLine(link);
        }
    }
}