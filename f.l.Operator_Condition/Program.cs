using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.l.Operator_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 4;
            int a = 100;
            int b = 200;
            if (x > y && a < b)
            {
                Console.WriteLine("True");
            }
            if (x < y || a > b) { }
            else
            {
                Console.WriteLine("False");
            }

            //短路
            if (x < y && a++ < b) { }
            else { Console.WriteLine("a:" + a); }

            if (x > y || a++ < b)
            { Console.WriteLine("a:" + a); }
        }
    }
}
