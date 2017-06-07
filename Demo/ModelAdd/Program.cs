using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new List<Student>()
            {
                new Student() {Age = 20, Class = "one", IsMan = true, Name = "张三"},
                new Student() {Age = 21, Class = "two", IsMan = true, Name = "李四"}
            };
            var s2 = new List<Student>()
            {
                new Student() {Age = 22, Class = "three", IsMan = true, Name = "王五"},
                new Student() {Age = 23, Class = "four", IsMan = true, Name = "周六"},
                new Student() {Age = 24, Class = "five", IsMan = true, Name = "周日"}
            };
            List<Student> ss=s1.Concat(s2).ToList();
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMan { get; set; }
        public string Class { get; set; }
    }
}
