using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e.Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calc           //Overload
    {
        public int Add()
        {
            return 0;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
