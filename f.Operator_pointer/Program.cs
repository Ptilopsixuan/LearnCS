using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.Operator_pointer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size of int: " + sizeof(int));           //sizeof 仅能获取结构体的内存大小
            Console.WriteLine("size of long: " + sizeof(long));
            //Console.WriteLine("size of string: " + sizeof(String));   //error  当然string内存为8B
            unsafe
            {
                int i = sizeof(MyStruct);
                Console.WriteLine(i);
                Console.WriteLine("===========================================");

                MyStruct myStruct = new MyStruct();
                myStruct.x = 10;
                myStruct.y = 10L;

                MyStruct* p = &myStruct;                                  //& 操作符用于取地址
                p->x = 20;                                              //->操作符用于访问指针指向的成员
                Console.WriteLine(myStruct.x);
                //or
                (*p).x = 30;                                            //*p等效于 -> , 但.(基本操作符)的优先级高于*(一元操作符)，所以要加括号
                Console.WriteLine(myStruct.x);
            }
        }
    }

    struct MyStruct
    {
        public int x;     //4B
        public long y;    //8B
    }
}
