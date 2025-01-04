using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBasic.Day2
{
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void Info()
        {
            Console.WriteLine($"This is a {Name}");
        }

        public abstract double CalPerimeter();

        public abstract double CalArea();
    }

    class Circle : Shape { 
    
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double CalPerimeter()
        {
            return 2 * Radius * Math.PI;
        }

        public override double CalArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override void Info()
        {
            Console.WriteLine($"This is a circle with radius equal to {Radius}");
        }

        public void CircleSpecialMethod() {
            Console.WriteLine("Method only in Circle");
        }
    }

    interface IShape
    {
        string Name { get; set; }
        void Info();
        double CalPerimeter();
        double CalArea();
    }

    public class Rectangle : IShape
    {
        public string Name { get; set; }

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Name = "Rectangle";
            Width = width;
            Height = height;
        }

        public double CalArea()
        {
            return Width * Height;
        }

        public double CalPerimeter()
        {
            return 2 * (Width + Height);
        }


        public void Info()
        {
            Console.WriteLine($"This is a rectangle with size is [{Width}, {Height}]");
        }
    }
}
