using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.i.OperatorMulty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = float.PositiveInfinity;
            float b = float.NegativeInfinity;
            int x = 4 / 3;
            Console.WriteLine("int / int : " + x);
            double y = 4.0 / 3.0;
            Console.WriteLine("double / double : " + y);
            double z = (double)4/3;                         //一元操作符执行优先级高于乘法操作符,
                                                            //且该行会发生类型提升，即将3(int类型)提升为double类型
            Console.WriteLine("float / int : " + z);
            double z_1 = (double)(4 / 3);
            Console.WriteLine(z_1);                         //1.0
        }
    }
}