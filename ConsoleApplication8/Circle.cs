using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Circle:Shape
    {
        public Circle(Point a, Point b) : base(a, b)
        {
            this.Type = "Circle";
        }
        public Circle()
        {
            this.Type = "Circle";
        }
        public override void input()
        {
            base.input();
        }
        public override double Area()
        {
            return (Math.Pow(Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)), 2) * (Math.PI / 4));
        }
        public override double Perimeter()
        {
            return (Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)) * Math.PI);
        }
        public override void output()
        {
            base.output();
        }
        public override void Display()
        {
            double radius =Math.Round( (Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)) / (double)2),0);
            double thickness = 0.4;
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
 
        }
        ~Circle() { }
    }
}
