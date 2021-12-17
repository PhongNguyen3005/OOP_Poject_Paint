using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Rhombus:Shape
    {
        public Rhombus(Point a, Point b) : base(a, b)
        {
            this.Type = "Rhombus";
        }
        public Rhombus()
        {
            this.Type = "Rhombus";
        }
        public override double Area()
        {
            return Math.Abs(A.X - B.X) * Math.Abs(A.Y - B.Y) / (double)2;  
        }
        public override double Perimeter()
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)) * 2;
        }
        public override void input()
        {
            do
            {
                base.input();
                if (A.X == B.X || A.Y == B.Y)
                {
                    Console.WriteLine("Point A and B have same location of x or y!!!");
                }
            } while ((A.X == B.X || A.Y == B.Y));
        }
        public override void output()
        {
           
            base.output();
        }
        public override void Display()
        {
            int length = Math.Abs(A.Y - B.Y) / 2;
            for (int i = 0; i <= length; i++)
            {
                for (int j = 1; j <= length - i; j++)
                    Console.Write("   ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write(" * ");
                Console.WriteLine();
            }

            for (int i = length - 1; i >= 1; i--)
            {
                for (int j = 1; j <= length - i; j++)
                    Console.Write("   ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write(" * ");
                Console.WriteLine();
            }
        }
        ~Rhombus() { }
    }
}
