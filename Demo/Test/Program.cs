using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now.Date;
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            Console.ReadKey();
            XtraForm1 xtf1 = new XtraForm1();
            xtf1.Show();
        }
    }
}
