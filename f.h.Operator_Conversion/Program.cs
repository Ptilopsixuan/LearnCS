using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.h.Operator_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //隐式 implict
            //1.不丢失精度
            int x = 10;
            long y = x;

            //2.子类向父类转换
            Teacher t = new Teacher();
            Human h = t;
            t.Teach();
            h.Speak();// 只能访问变量类型的方法，而无法访问变量所引用实例的类型的方法

            //3.装箱 见d.Variety


            //显式 explicit
            //1.可能会丢失精度
            uint a = 655356;
            ushort b = (ushort)a;// cast 铸造

            Stone stone = new Stone();
            stone.Age = 5000;
            Monkey wukong = (Monkey)stone;
            Console.WriteLine(wukong.Age);
            Console.WriteLine(b);// b = 0 精度丢失

            //2.拆箱 见d.Variety

            //3.Convert工具类,使用Convert的 静态方法
            Convert.ToUInt32("10");

            //4.调用数值类型的 实例方法 或 相关值类型的 静态方法Parse（）
            x.ToString();
            double.Parse("1e3");//1000.0D
            double.TryParse("1e3", out double result);
        }

        //implict 2.
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

        //explicit 1.cast类型转换操作符亦为某种函数的简化
        class Stone
        {
            public int Age;
            public static explicit operator Monkey(Stone stone) // 形似目标类型Monkey的构造器
                          //若想实现隐式转换，将implicit改为explicit即可
            {
                Monkey m = new Monkey();
                m.Age = stone.Age / 500;
                return m;
            }
        }

        class Monkey
        {
            public int Age;
        }
    }
}
