using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.n.Operator_Condition_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //normal way
            int x = 10;
            string str = string.Empty;
            if (x > 0) { Console.WriteLine("positive"); }
            else { Console.WriteLine("negative"); }

            //?: :两侧的表达式必须是可以隐式转换的类型
            str = (x > 0) ? "positive" : "negative";        //()可省略
            Console.WriteLine(str);
        }
    }
}
