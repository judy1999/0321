using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0321
{
    class Car
    {
        string color = "red";
        int cc = 1500;
        string brand = "bmw";
    public void StartEngin()
    {
            Console.WriteLine("發動引擎！");

    }
        public void ShoInfo()
        {
            Console.WriteLine("顏色是：" + color);
            Console.WriteLine("cc數：" + cc);
            Console.WriteLine("品牌" + brand);
        }
    }
    
}
