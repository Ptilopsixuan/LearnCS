using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d.Variety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;                      //局部变量  
            int[] array = new int[5];   //数组参数
            Student stu;                    //局部变量  在栈Stack上分配内存，记录堆的内存地址
            stu = new Student();            //实例变量  在堆Heap上分配内存
            /*装箱与拆箱*/
            int y = 10;
            object obj = y;         /*装箱    若要让引用类型指向值类型，要先将值类型从栈Stack上<复制>到堆Heap上，
                                            然后让引用类型指向堆上的值,使其成为一个实例，目的为将改数据的存储空间由栈Stack上转移到堆Heap上*/
            int z = (int)obj;       //拆箱    若要让值类型指向引用类型，要将引用类型指向的堆Heap上的值复制到对应值类型的栈Stack上

        }
    }

    internal class Student
    {
        public static int Count = 0;    //静态字段
        public int Age;                 //实例字段 or 成员变量
        public void Method
            (
            int a,                      //值参数
            ref int b,                  //引用参数
            out int c                   //输出参数
            )
        { c = 0; }
    }


}
