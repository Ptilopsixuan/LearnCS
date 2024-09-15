using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d.TypeOfTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t1 = typeof(Form);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.IsClass);
            //Form
            //or press F12 with mouse on Form

            //Form is a Class(class)
            //int is a Structure(struct)
            //FormWindowState is an Enum(enum)
        }
    }
}
