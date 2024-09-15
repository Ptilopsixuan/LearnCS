using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace e.Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal class Student
    {
        public int ID;
        public string Name;

        public Student(int id, string name) //instance constructor
        {
            this.ID = id;
            this.Name = name;
        }

        public Student()                    //default constructor   //overload
        {
            this.ID = 0;                    //value type int 4B
            this.Name = "";                 //reference type 4B
        }
        
    }
}
