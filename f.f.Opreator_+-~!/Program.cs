using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.f.Opreator_____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = +a;
            int c = -a;
            Console.WriteLine("a:" + a + "\tb:" + b + "\tc:" + c);
            Console.WriteLine("==================================");
            int m = int.MinValue;
            int m_1 = -m;                                               //取负数为按位取反加1
            Console.WriteLine("m:" + m + "\t-m:" + m_1);
            string mStr = Convert.ToString(m, 2).PadLeft(32, '0');
            string m_1Str = Convert.ToString(m_1, 2);
            Console.WriteLine(mStr);
            Console.WriteLine(m_1Str);
            Console.WriteLine("==================================");
            int x = 2430748;
            int y = ~x;
            string xStr = Convert.ToString(x, 2).PadLeft(32, '0');
            string yStr = Convert.ToString(y, 2).PadLeft(32, '0');
            Console.WriteLine("x:" + x + "\t" + xStr);
            Console.WriteLine("y:" + y + "\t" + yStr);
            Console.WriteLine("==================================");
            bool b1 = true;
            bool b2 = !b1;
            Console.WriteLine(b2);
            Student stu = new Student(null);
        }
    }

    class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.Name = name;
            }
            else 
            {
                throw new Exception("name is null or empty");
            }
        }
    }
}
