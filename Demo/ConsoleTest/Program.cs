using System;
using System.IO;

namespace ConsoleTest
{
    class ConsoleTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"请输入密码：");
            var result = string.Empty;
            while (true)
            {
                var input=Console.ReadKey(true);
                if (input.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    Console.WriteLine("输入完成");
                    break;
                }
                result += input.KeyChar;
                Console.Write("*");
            }
            Console.WriteLine("输入的密码为：");
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}