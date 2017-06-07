using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace z_A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<Person> p1 = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                p1.Add(new Person() { ColumnName = "day_" + i, LogisCodeText = "name" + i, PackageNo = 100 + i });
            }
            var a = p1.Select(s => new { a =  s.ColumnName, b = s.LogisCodeText , c = 1000 + s.PackageNo });
            var result = printe(a, a.Select(c=>c.a).Distinct().ToList(),new { a = 0, b = "", c = 0 });
            Console.ReadKey();
        }

        private static DataTable printe<T>(IEnumerable<dynamic> listModel,List<string> columnHeader , T leixing)
        {
            Dictionary<string, int> ergidocRowProperty = new Dictionary<string, int>();//已遍历行属性
            //获取属性列表
            Type type = typeof(T);
            PropertyInfo[] pis = type.GetProperties();
            
            //生成待生成Db栏目名称数据 add by Vincent.Q 13.03.02
            List<string> listPiName = new List<string>();
            List<string> firstColumnValue = new List<string>();
            listPiName.Add(pis[0].Name);
            listPiName.AddRange(columnHeader);
            var obj=new object();
            return (T)obj;
        }

        private void test(object q)
        {
            
        }
    }

     class Person
    {
        public  string ColumnName { get; set; }
         public  string LogisCodeText { get; set; }
         public int PackageNo { get; set; }
    }
}
