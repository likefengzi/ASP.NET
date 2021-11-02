using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5._1
{
    class Program
    {
        /// <summary>
        /// 程序集内部可见，internal
        /// internal标识的属性在程序集内部都可访问
        /// </summary>
        class 可访问性
        {
            public 可访问性()//可以被其他成员和实例化对象访问
            {

            }
        }
        public class 全部可见
        {
            protected void 受保护方法()//可以被该类和该类的子类访问
            {

            }
            private void 私有方法()//只可以被该类访问
            {

            }
            public void 公开方法()//可以被其他成员和实例化对象访问
            {
            }
            public string b()
            {
                内部类.str = "全部可见";
                return 内部类.str;
            }
            public class 内部类//外部类可以访问内部类public的对象，内部类访问外部类不受限制
            {
                public static string str;
            }
        }
        class 子类 : 全部可见//继承了全部可见类，包含了内部类，可以通过外部函数访问内部类,也可以直接访问标识符为public，internal的成员
        {
            public 子类()//除了构造函数之外还继承了全部可见包含的所有属性
            {

            }
            public string a()
            {
                全部可见.内部类.str = "子类";
                return 全部可见.内部类.str;
            }
        }

        static void Main(string[] args)
        {
            子类 a = new 子类();
            全部可见 b = new 全部可见();
            Console.WriteLine(b.b());//测试子类对内部类的可访问性
            Console.WriteLine(a.a());
        }
    }
}
