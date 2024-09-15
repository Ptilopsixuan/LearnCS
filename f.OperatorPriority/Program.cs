using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.OperatorPriority
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = 30;
            x += y += z;                    //带有赋值运算符的表达式，从右向左计算
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);
            Console.WriteLine("z:" + z);
        }
    }
}
