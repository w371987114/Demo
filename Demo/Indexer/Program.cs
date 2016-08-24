using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//需要引用该命名空间

namespace Indexer
{
    class Program:IEnumerable
    {
        private string[] nameList = new string[size];
        static public int size = 10;
        //public void IndexedNames()
        //{
        //    for (int i = 0; i < size; i++)
        //    {
        //        nameList[i] = "N. A.";
        //    }
        //}
        /// <summary>
        /// 直接实现IEnumerable接口
        /// </summary>
        /// <returns>迭代器类型的</returns>
        public  IEnumerator GetEnumerator()
        {
            for (int i = 0; i < size; i++)
			{
                yield return nameList[i]; 
			}          
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index < 0 && index > size - 1)
                {
                    tmp = "";
                }
                else
                {
                    tmp = nameList[index];
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index < size - 1)
                {
                    nameList[index] = value;
                }
            }

        }
        static void Main(string[] args)
        {
            Program names = new Program();
            names[0] = "0";
            names[1] = "1";
            names[2] = "2";
            names[3] = "3";
            names[4] = "4";
            names[5] = "5";
            Console.WriteLine("这里的for循环");
            for (int i = 0; i < Program.size; i++)
            {
                Console.WriteLine(names[i]);

            }
            Console.WriteLine("这里的foreach循环");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        private double GetAVG(int first,int second)
        {
            return (first + second) / 2.0;
 
        }
    }
}
