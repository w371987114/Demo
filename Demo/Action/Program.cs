using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace 小偷偷东西问题
{
    //一户人家的主人有一条狗，一天晚上有一个小偷进来，被狗发现了；
    //狗叫了起来，叫醒了主人，吓跑了小偷
    //提示：
    //1.主人和小偷都是被动叫醒的
    //2.要考虑到程序的扩展性：如狗也会叫醒邻居
    //3.采用一定设计模式实现

    //以Action简写委托
    class Program
    {
        static void Main(string[] args)
        {
            Host host1 = new Host();
            host1.Name = "我零0七";
            Thief thief1 = new Thief();
            thief1.Name = "李三";
            Dog dog1 = new Dog();
            dog1.Name = "小白";
            Neighbor neighbor1 = new Neighbor();
            neighbor1.Name = MethodBase.GetCurrentMethod().ReflectedType.Namespace;//ReflectedType获得程序（当前）对象
            //Action BarEvent = thief1.Run;//Action声明委托
            //BarEvent += host1.Wake;//添加委托
            //BarEvent += neighbor1.Wake;//添加委托
            Action BarEvent = () => { Console.WriteLine(thief1.Name + "害怕的跑了跑了"); };
            BarEvent += () => { Console.WriteLine(host1.Name + "醒了，起来看看怎么回事"); };
            BarEvent += () => { Console.WriteLine("不明真相的" + neighbor1.Name); };
            Console.WriteLine("夜深了！");
            host1.Sleeep();
            if (Console.ReadLine() == "贼来了")
            {
                dog1.Bark();
                BarEvent();//执行事件
            }
            Console.ReadKey();
        }
    }
    public abstract class People
    {
        public abstract string Name { get; set; }
    }
    public class Host : People
    {
        public override string Name { get; set; }
        /// <summary>
        /// 人睡着了
        /// </summary>
        public void Sleeep()
        {
            Console.WriteLine(Name + "睡着了，什么都不知道！");
        }
        ///// <summary>
        ///// 人被惊醒了
        ///// </summary>
        //public void Wake()
        //{
        //    Console.WriteLine(Name + "醒了，起来看看怎么回事");
        //}

    }
    public class Neighbor : People
    {
        public override string Name { get; set; }
        //public void Wake()
        //{
        //    Console.WriteLine("不明真相的围观群众" + Name);
        //}
    }
    public class Thief : People
    {
        public override string Name { get; set; }
        public void Steal()
        {
            Console.WriteLine(Name + "来偷东西了！");

        }
        //public void Run()
        //{
        //    Console.WriteLine(Name + "害怕的跑了！");
        //}
    }
    public abstract class Animals
    {
        public abstract string Name { get; set; }
    }
    public class Dog : Animals
    {
        //public delegate void BarkHandler();//声明委托
        //public event BarkHandler BarkEvent;//声明事件       
        public override string Name { get; set; }
        public void Bark()
        {
            Console.WriteLine(Name + "发出：汪汪汪汪！");
            //BarkEvent();//事件发生
        }
    }
}