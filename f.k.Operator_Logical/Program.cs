using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.k.Operator_Logical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 28;
            int z1 = x & y; //与
            int z2 = x | y; //或
            int z3 = x ^ y; //异或 两位不一样为1
            string strX = Convert.ToString(x, 2).PadLeft(32, '0');
            string strY = Convert.ToString(y, 2).PadLeft(32, '0');
            string strZ1 = Convert.ToString(z1, 2).PadLeft(32, '0');
            string strZ2 = Convert.ToString(z2, 2).PadLeft(32, '0');
            string strZ3 = Convert.ToString(z3, 2).PadLeft(32, '0');
            Console.WriteLine("x:\t" + strX);
            Console.WriteLine("y:\t" + strY);
            Console.WriteLine("x&y:\t" + strZ1);
            Console.WriteLine("x|y:\t" + strZ2);
            Console.WriteLine("x^y:\t" + strZ3);
        }
    }
}
