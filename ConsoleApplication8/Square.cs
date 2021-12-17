using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Square:Shape
    {
        public Square(Point a, Point b) : base(a, b)
        {
            this.Type = "Square";
        }
        public Square()
        {
            this.Type = "Square";
        }
        public override void input()
        { 
            base.input();
        }
        public override double Area()
        {
            return Math.Pow(Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)),2 );
        }
        public override double Perimeter()
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)) * 4;
        }
        public override void output()
        {
            base.output();
        }
        public override void Display()
        {
            double width = Math.Round(Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)),0);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || j == 0 || j == width - 1 || i == width - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
