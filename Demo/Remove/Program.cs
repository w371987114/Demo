using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = @"'a','b','c',";
            Console.WriteLine(str.Substring(0,str.Length-1));
            Console.WriteLine(str.TrimEnd(','));
            Console.WriteLine(str.Remove(str.Length-1));
            Console.WriteLine(str.Remove(str.Length-2,1));
            Console.ReadKey();
        }
    }
}
