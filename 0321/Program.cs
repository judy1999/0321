using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0321
{
    class Program
    {
        static void Main(string[] args)
        {
            scales scales = new scales();
            scales.weight = 200;
            Console.WriteLine($"你的體重是{scales.weight}");
            Console.ReadKey();
        }
        public class scales//定義scales類別
        {
            private int newWeight;//newWeight為private，只能在scales內使用
            public int weight
            {
                get//get存取子可以回傳屬性值
                {
                    return newWeight;//使用return回傳屬性值
                }
                set//set存取子可以設定屬性值，value是外部傳來的數字
                {
                    if (value < 0)//如果小於0就設為0
                    {
                        value = 0;
                    }
                    if (value > 60)//大於60就顯示60
                    {
                        value = 60;
                    }
                    newWeight = value;//把調整後的value值賦值給newWeight
                }
            }
        }
    }
}
