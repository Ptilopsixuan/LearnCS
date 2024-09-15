using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe//need to change the "Allow unsafe code" setting in Build in StackOverflow Properties in Project
            {
                int* p = stackalloc int[9999999];
            }

            // or
            BadGuy badGuy = new BadGuy();
            badGuy.BadMethod();
        }
    }

    class BadGuy 
    {
        public void BadMethod() 
        {
            int x = 100;
            this.BadMethod();
        }
    }
}
