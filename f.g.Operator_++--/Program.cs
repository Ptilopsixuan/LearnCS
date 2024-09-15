using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.g.Operator_____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = x++;        //10
            int z = ++x;        //12
            Console.WriteLine("y:" + y);
            Console.WriteLine("z:" + z);
        }
    }
}
