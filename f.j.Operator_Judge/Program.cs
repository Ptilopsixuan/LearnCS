using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.j.Operator_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //is运算符
            Teacher teacher = new Teacher();
            bool b = teacher is Teacher;    //检验的是实例的类型
            Console.WriteLine(b);

            Teacher t = null;
            bool b2 = t is Teacher;
            Console.WriteLine(b2);          //false

            bool b3 = teacher is Human;
            Console.WriteLine(b3);          //true

            bool b4 = teacher is object;
            Console.WriteLine(b4);          //true

            //as运算符
            //用is写
            object obj = new Teacher();     //装箱
            if (obj is Teacher)
            {
                Teacher t2 = (Teacher)obj;  //拆箱
                t2.Teach();
            }
            //用as写
            Teacher t3 = obj as Teacher;    //as运算符，如果转换失败，返回null
            if (t3 != null)
            {
                t3.Teach();
            }
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }

    class Human : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Speak");
        }
    }

    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("Teach");
        }
    }
}
