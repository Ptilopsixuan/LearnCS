using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.o.Operator__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int z = 4;
            int res = x += y *= z;
            Console.WriteLine("x:\t" + x);
            Console.WriteLine("y:\t" + y);
            Console.WriteLine("z:\t" + z);
            Console.WriteLine("res:\t" + res);
        }
    }
}
