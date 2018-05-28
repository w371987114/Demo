using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleTest
{
    class ConsoleTest
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 100)
            {
                if ((i % 7) == 0)
                {
                    i++;
                    continue;
                }
                sum = sum + i;
                i++;
            }
            Console.WriteLine("{0}", sum);
            Console.ReadKey();

        }
    }
}