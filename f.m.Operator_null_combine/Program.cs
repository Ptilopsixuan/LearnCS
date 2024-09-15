using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.m.Operator_null_combine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = null; can't assign null to int
            Nullable<int> x = null;
            x = 100;
            Console.WriteLine(x);
            Console.WriteLine(x.HasValue);

            int? y = null;
            Console.WriteLine(y);
            int z = y ?? 1;
            Console.WriteLine(z);

        }
    }
}
