using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] b = new int[4, 3] { { 12, 11, 10 }, { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] c = new int[3, 3];
            int i, j, k;
            for (i = 0; i < c.GetLength(0); i++)
            {
                for (j = 0; j < c.GetLength(1); j++)
                {
                    for (k = 0; k < 4; k++)
                    {
                        c[i, j] += a[i, k] + b[k, j];
                    }
                }
            }
            //矩阵乘法运算
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    System.Console.Write("{0,4:d}", c[i, j]);
                }
                System.Console.WriteLine();
            }
            //输出矩阵
            Console.WriteLine("c组一共有{0}个元素", c.Length);
            Console.Read();
        }
    }
}
