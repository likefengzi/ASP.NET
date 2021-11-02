using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5._2
{
    class Program
    {
        class 面向对象
        {
            public static void Text()//调用Human含参的构造函数
            {
                Human p = new Human("张三");
            }
        }
        class Human//封装类，用户只需了解对应的接口参数，而不需要实现，体现面向对象的封装性
        {
            public string Name { get; set; }

            public Human(string name)
            {
                Name = name;
            }
            public void ParentAbstractMethod() { }
            public void ParentAbstractMethod(string param) { }//重载
            public virtual void ParentMethod() { }//定义虚函数
        }
        class Man : Human//继承Human类，包含human类的所有属性，体现面向对象的继承性
        {
            public Man(string name) : base(name)//base调用基类构造函数
            {

            }

            public override void ParentMethod()//重写父类方法，体现面向对象的多态性
            {
                base.ParentMethod();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
