using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TowerOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            if (n == 'q')
            {
                return;
            }
            DateTime start = DateTime.Now;
            TowerOfHanoi tower = new TowerOfHanoi();
            tower.Solve(n, 'A', 'B', 'C');
            Console.WriteLine("Total number of moves: {0}", TowerOfHanoi.num);
            DateTime end = DateTime.Now;
            Console.WriteLine("Time taken: " + (end - start).TotalSeconds + " seconds");
            Main(null);
        }
    }

    public class TowerOfHanoi
    {
        public static int num = 0;
        public TowerOfHanoi()
        {
            num = 0;
        }
        public void Solve(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from rod {0} to rod {1}", A, C);
                num++;
                return;
            }
            else
            {
                Solve(n - 1, A, C, B);
                Console.WriteLine("Move disk {0} from rod {1} to rod {2}", n, A, C);
                Solve(n - 1, B, A, C);
                num++;
            }
        }


        //public void Solve(int n, char from, char to, char aux)
        //{
        //    if (n == 1)
        //    {
        //        Console.WriteLine("Move disk 1 from rod " + from + " to rod " + to);
        //        return;
        //    }

        //    Solve(n - 1, from, aux, to);
        //    Console.WriteLine("Move disk " + n + " from rod " + from + " to rod " + to);
        //    Solve(n - 1, aux, to, from);
        //}

    }
}
