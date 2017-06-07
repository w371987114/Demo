using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormate
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = @"How are you ? {0},I'd like to {1} you ,{2} you?";
            var result =str;
//                result= string.Format(str, "WS", "see");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
