using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f.Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Name = "Tom";
            p2.Name = "Jerry";
            //List<Person> nation = Person.GetMarry(p1, p2);
            List<Person> nation = p1 + p2;
            foreach (Person p in nation)
            {
                Console.WriteLine(p.Name);
            }
        }
    }

    class Person 
    {
        public string Name;

        //public static List<Person> GetMarry(Person p1, Person p2) 
        //{
        //    List<Person> people = new List<Person>();
        //    people.Add(p1);
        //    people.Add(p2);
        //    for (int i = 0; i < 10; i++) 
        //    {
        //        Person child = new Person();
        //        child.Name = p1.Name + "&" + p2.Name + i; ; 
        //        people.Add(child);
        //    }
        //    return people;
        //}

        public static List<Person> operator + (Person p1, Person p2)//操作符就是方法/函数的简记法
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 10; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + "&" + p2.Name + i; ;
                people.Add(child);
            }
            return people;
        }
    }
}
