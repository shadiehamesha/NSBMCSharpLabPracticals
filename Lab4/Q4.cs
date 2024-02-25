using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Shape
    {
        public string ShapeType { get; protected set; }
        public double Area { get; protected set; }

        public Shape()
        {
            ShapeType = "Not defined";
            Area = 0;
        }

        public virtual void CalculateArea(double val1, double val2 = 0)
        {
            Area = 0;
        }

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: " + ShapeType);
            Console.WriteLine("Area: " + Area);
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; private set; }
        public double Width { get; private set; }

        public Rectangle()
        {
            ShapeType = "Rectangle";
            Length = 0;
            Width = 0;
        }

        public void SetDimensions(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override void CalculateArea(double val1, double val2)
        {
            Area = Length * Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle()
        {
            ShapeType = "Circle";
            Radius = 0;
        }

        public void SetRadius(double radius)
        {
            Radius = radius;
        }

        public override void CalculateArea(double val1, double val2 = 0)
        {
            Area = Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetDimensions(5, 3);
            rectangle.DisplayShapeInfo();

            Circle circle = new Circle();
            circle.SetRadius(4);
            circle.DisplayShapeInfo();

            Console.ReadLine();
        }
    }
}
