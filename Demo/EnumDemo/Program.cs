using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Number.Four;
            var num2 = Number.OddNumber;
            var num3 = (Number) 21;
            Console.WriteLine((num1 & Number.EvenNumber) != Number.EvenNumber);
            Console.WriteLine(num2.ToString());
            Console.WriteLine(num3.ToString());

            Console.ReadKey();
            #region MyRegion
            //var source = ShopSourceType.Taobao;
            //Console.WriteLine((source & ShopSourceType.OtherSource) != ShopSourceType.OtherSource);
            //var sqlSource = ShopSourceType.OtherSource;
            //Console.WriteLine( sqlSource.); 
            #endregion
        }

        
        
    }

    public static class EnumExtensions
    {
        public static string[] ToStringName(this ShopSourceType sqlSource)
        {
            var num = (int) sqlSource;
            var result = (ShopSourceType) num;
            
            return result.ToString().Split(',');
        }

        
    }
    [Flags]
    public enum Number:byte
    {
        One = 0x01,
        Two = 0x02,
        Three = 0x04,
        Four = 0x08,
        Five = 0x10,
        Sex=0x20,
        /// <summary>
        /// 偶数
        /// </summary>
        EvenNumber = Two | Four,
        /// <summary>
        /// 奇数
        /// </summary>
        OddNumber = One | Three | Five
    }
    /// <summary>
    /// 登录器店铺类型
    /// </summary>
    [Flags]
    public enum ShopSourceType
    {
       
        /// <summary>
        /// 无
        /// </summary>
        None=0x00,

        /// <summary>
        /// 速卖通
        /// </summary>
        AliExpress=0x01,

        /// <summary>
        /// 敦煌网
        /// </summary>
        DHGate=0x02,

        /// <summary>
        /// Wish平台
        /// </summary>
        Wish=0x04,

        /// <summary>
        /// 淘宝网
        /// </summary>
        Taobao=0x8,

        /// <summary>
        /// 亚马逊
        /// </summary>
        Amazon=0x10,

        /// <summary>
        /// Lazada
        /// </summary>
        Lazada=0x20,

        /// <summary>
        /// 园区销售、员工购买属于其他范围
        /// </summary>
        Others=0x40,
        /// <summary>
        /// 
        /// </summary>
        MainSource=23,
        
        OtherSource=104,
    }
}
