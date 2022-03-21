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
            Random myObject = new Random();
            int ranNum = myObject.Next(1, 100);
            Console.WriteLine("隨機亂數是: " + ranNum);
            scales scales = new scales();
            scales.weight = 200;
            Console.WriteLine($"你的體重是{scales.weight}");
            Console.ReadKey();
            


        }
        //亂數
        public string GetRandom(string[] arr)
        {
            Random ran = new Random();
            int i = ran.Next(1,100);
            return arr[i];
             
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
        //猜數字(不知道為什麼跑不出來！)
        public int SetRando()
        {
            int n;
            var random = new Random();
            n = random.Next(1, 100);
            return n;

        }
        public void guess(int num)
        {
            int n;
            int count = 0;
            Console.WriteLine("請猜一個數(最多猜到5次！)");
            n = Convert.ToInt32(Console.ReadLine());
            while (num <= 10)
            {
                if (n == num)
                {
                    Console.WriteLine("猜對了！");
                    break;
                }
                else
                {
                    count++;
                    Console.WriteLine("猜錯了！還有{0}次機會！\n", count);

                    if (count >= 5)
                    {
                        Console.WriteLine("猜完5次，機會使用完畢！");
                        break;
                    }
                    
                       
                }
            }
        }
    }
}
