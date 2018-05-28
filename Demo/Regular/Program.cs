using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular{
    class Program
    {
        static void Main(string[] args)
        {
            //String LogisticsNo1 = "EA123";
            //String LogisticsNo2 = "EA";
            //String LogisticsNo3 = "EA*";
            //String LogisticsNo4 = "EAB";
            //String LogisticsNo5 = "CEA123";
            //String LogisticsNo6 = "1EAC";
            var str = "123,abc,AAA,a12,我,,";
            string LogisticsNo = Console.ReadLine();
            Regex reg = new Regex("([^,]*,){6}");
            bool match = reg.IsMatch(LogisticsNo);
            //var match = eRegex.Match(repStr);
            //var value1 = Convert.ToDouble(match.Groups[1].Captures[0].Value);
            //var value2 = Math.Pow(10, Convert.ToDouble(match.Groups[2].Captures[0].Value));
            //repStr= Regex.Replace(repStr,eRegex.ToString(), value1*value2 + "*");
            Console.WriteLine("匹配结果为：");
            Console.WriteLine(match);
            var result = LogisticsNo.Count(c => c == ',') == 6;
            Console.WriteLine("统计逗号的结果为：");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
