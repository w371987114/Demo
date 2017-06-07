using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            var listPerson=new List<Person>();
            var removeP = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                listPerson.Add(new Person() {Age = i,Hobby = $"打{i-1}",IsMale = i%2==0,Name = $"I'm{i}"});
            }
            //for (int i = 0; i < listPerson.Count; i++)
            //{
            //    var p = listPerson[i];
            //    if(p.IsMale)listPerson.RemoveAt(i);
            //}
            //var removeAge=new List<int>() {3,7,1,9,8};
            //var count= listPerson.RemoveAll(c => c.Age%2 == 0);
            removeP = listPerson.Where(c => c.IsMale).Select(c => c.Name).ToList();
            var count= listPerson.RemoveAll(c => removeP.Contains(c.Name));
            Console.WriteLine($@"删除了{count}个元素");
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public  bool IsMale { get; set; }
        public string Hobby { get; set; }
    }
}
