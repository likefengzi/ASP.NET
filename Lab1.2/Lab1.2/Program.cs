using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Program
    {
        static void PrintArray(string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
            }
            System.Console.ReadLine();
        }//输出函数
        static void Main(string[] args)
        {
            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            PrintArray(weekDays);
        }
    }
}
