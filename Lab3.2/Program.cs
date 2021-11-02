using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape A = new Shape(2, 4);
            Triangle B = new Triangle(1, 2);
            Traperia C = new Traperia(2, 3, 4);
            Console.WriteLine("A.area={0}", A.Area());
            Console.WriteLine("B.area={0}", B.Area());
            Console.WriteLine("C.area={0}", C.Area());
            A = B;
            Console.WriteLine("A.area={0}", A.Area());
            A = C;
            Console.WriteLine("A.area={0}", A.Area());
            Console.Read();

        }
    }
    class Shape
    {
        protected double width;
        protected double height;
        public Shape()
        {
            width = 0;
            height = 0;
        }
        public Shape(double x)
        {
            width = x;
            height = x;
        }
        public Shape(double w,double h)
        {
            width = w;
            height = h;
        }
        public virtual double Area()
        {
            return width * height;
        }
    }
    class Triangle : Shape
    {
        public Triangle(double x,double y)
            :base(x,y)
        {

        }
        public override double Area()
        {
            return width*height/2;
        }
    }
    class Traperia : Shape
    {
        double width2;
        public Traperia(double w1,double w2,double h)
            :base(w1,h)
        {
            width2 = w2;
        }
        public override double Area()
        {
            return (width+width2)*height/2;
        }
    }

}
