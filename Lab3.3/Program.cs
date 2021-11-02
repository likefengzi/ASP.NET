using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritInterface i = new InheritInterface();
            i.outMethod();
            Console.Read();
        }
        interface myInterface
        {
            string STR
            {
                get;
                set;
            }
            void outMethod();
        }
        class InheritInterface : myInterface
        {
            string str = "厦门大学软件学院《.NET技术平台》课程——接口实现";
            public string STR { 
                get
                {
                    return str;
                }
                set
                {
                    str = value;
                }
            }

            public void outMethod()
            {
                Console.WriteLine(this.STR);
            }
        }
    }
}
