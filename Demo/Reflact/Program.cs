using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflact
{
    class Program
    {
        /// <summary>
        /// 查看类中的构造方法
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string oneString = "newtype";
            System.Type t = oneString.GetType();
            ConstructorInfo[] ci = t.GetConstructors();//获得类的所有构造函数
            foreach (var item in ci)//遍历构造函数
            {
                ParameterInfo[] pi = item.GetParameters();//取出每个构造函数的所有参数
                foreach (var i in pi)//遍历并打印构造函数的参数
                {
                    Console.WriteLine(i.ParameterType.ToString() + "" + i.Name + ",");
                    
                }
            }
            Console.ReadKey();
        }
        static void ReflectionGetMember()
        {
            var asm = Assembly.LoadFile(@"E:\WorkSpace\01.Codes\NorthCKKSoft10\NC.Kernel.WinUI\bin\Debug\NC.Kernel.WinUI.dll");
            var type = asm.GetType();
            Console.WriteLine(type);
        }
    }
}
