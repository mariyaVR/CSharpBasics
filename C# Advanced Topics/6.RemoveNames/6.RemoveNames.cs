using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RemoveNames
{
    static void Main(string[] args)
    {
        string startingNames = Console.ReadLine();
        List<string> reducedNames = startingNames.Split(' ').ToList();
        string deductedNames = Console.ReadLine();
        string[] secondArray = deductedNames.Split(' ');

        foreach (string name in secondArray)
        {
            while (reducedNames.IndexOf(name) > 0)
            {
                reducedNames.Remove(name);
            }
        }

        foreach (string name in reducedNames)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}