using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    class Program
    {
        private int[] data;
        //构造函数
        public Program(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = 0;     //初始化
            }
        }
        //构建索引指示器
        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        static void Main(string[] args)
        {
            const int size = 5;
            Program p = new Program(size);
            p[0] = 0;
            p[1] = 5;
            p[2] = 10;
            p[3] = 15;
            p[4] = 20;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("data[{0}]={1}", i, p[i]);
            }
        }
    }
}
