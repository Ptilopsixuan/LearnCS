using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g.Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x++);     //打印出表达式的值，然后再加1
            Console.WriteLine(x);       //
            Console.WriteLine(++x);     //
        }
    }
}
