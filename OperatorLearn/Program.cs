using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.运算操作符优先级
            int x = 10;
            int y = x++;
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);
            Console.WriteLine("===================");
            //2.typeof操作符
            Type t = typeof(int);
            int c = t.GetMethods().Length;
            Console.WriteLine(t.FullName);
            foreach (var method in t.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine(c);
            Console.WriteLine("===================");
            //3.default操作符
            int a = default(int);
            string b = default(string);
            MyEnum e = default(MyEnum);
            Console.WriteLine(a);
            Console.WriteLine(b == null);
            Console.WriteLine(e);
            Console.WriteLine("===================");
            //4.new也是操作符
            Form f1 = new Form();                                                    //调用构造器
            f1.Text = "Hello";
            f1.ShowDialog();
            Form f2 = new Form()
            { Text = "Hello!", FormBorderStyle = FormBorderStyle.FixedToolWindow };    //调用初始化器
            f2.ShowDialog();
            new Form() { Text = "Hello!" }.ShowDialog();                             //一次性调用初始化器
            //语法糖衣，即new操作符可省略
            int s = 10;
            int ss = new int();
            int[] array = new int[10];
            int[] array2 = { 1, 2, 3, 4, 5 };
            //匿名类型
            /*用new操作符为匿名类型创建对象，用隐式类型变量p引用该实例*/
            var p = new { Name = "Tom", Age = 23 };//var 生成隐式类型变量
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.GetType().Name);
            //new可以作为修饰符，如在类的继承中。
            new Student().Say();//此处的new仍为操作符
            new CeStudent().Say();
            Console.WriteLine("===================");
            //5.checked和unchecked操作符
            int m = int.MaxValue;
            Console.WriteLine(m);
            //int n = checked(m++);                         //checked操作符
            //Console.WriteLine(n);
            unchecked                                       //unchecked操作符
            {
                try
                {
                    int n_1 = checked(m + 1);
                    Console.WriteLine(n_1);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("There's overflow!");
                }
            }
            int n_2 = unchecked(m + 1);                     //unchecked操作符
            Console.WriteLine(n_2);
        }
    }


    //3.
    enum MyEnum
    {
        B = 1,
        C = 0,
        A = 2
    }
    //4.new关键字作为修饰符
    internal class Student
    {
        public void Say() { Console.WriteLine("I'm a student."); }
    }
    internal class CeStudent : Student
    {
        new public void Say() { Console.WriteLine("I'm a CE student."); }
    }

}
