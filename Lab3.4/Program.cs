using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass i = new Myclass();
            Console.WriteLine(i.My());
            Console.WriteLine(i.My(100));
            Console.WriteLine(i.My(1100, 5115));
        }
        class Myclass
        {
            public int My()
            {
                return 1;
            }
            public int My(int a)
            {
                return a;
            }
            public int My(int a,int b)
            {
                return a * b;
            }
        }
    }
}
