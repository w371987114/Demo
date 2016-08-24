using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型约束
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNationality _c = new PrintNationality();
          PrintNationality _a = new PrintNationality();
          //PrintNationality _o = new PrintNationality(); 此句是错误的，因为泛型类型必须是继承自INationality接口的类
          _c.Print();
          _a.Print();
         Console.ReadKey();
        }
    }
    ///
  ///
  ///
  ///
  public class PrintNationality where T : INationality, new()
  {
      T item = new T();
      public void Print()
      {
         Console.WriteLine(string.Format("Nationality:{0}", item.GetNationality()));
      }
  }
    ///
    /// 国籍的接口
    ///
    public interface INationality
    {
        string Nationality
        {
            set;
            get;
        }
        string GetNationality();
    }
    ///
    /// 中国人
    ///
    public class Chinese : INationality
    {
        private string _Nationality;
        public string Nationality
        {
            set
            {
                _Nationality = value;
            }
        }

        public string GetNationality()
        {
            return string.IsNullOrEmpty(_Nationality) ? "Default." : _Nationality;
        }
    }
    ///
    /// 美国人
    ///
    public class American : INationality
    {
        private string _Nationality;
        public string Nationality
        {
            set { _Nationality = value; }
        }

        public string GetNationality()
        {
            return string.IsNullOrEmpty(_Nationality) ? "Default." : _Nationality;
        }
    }
}
