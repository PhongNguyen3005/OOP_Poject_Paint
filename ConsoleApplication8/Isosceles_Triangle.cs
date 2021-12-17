using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Isosceles_Triangle:Shape
    {
        public Isosceles_Triangle(Point a, Point b): base(a,b)
        {
            this.Type = "Isosceles_Triangle";
        }
        public Isosceles_Triangle()
        {
            this.Type = "Isosceles_Triangle";
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
        public override double Area()
        {
            return Math.Abs(A.X - B.X) * Math.Abs(A.Y - B.Y);
        }
        public override double Perimeter()
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)) * 2 + (Math.Abs(A.X - B.X) * 2);
        }
        public override void output()
        {
            base.output();
        }
        public override void Display()
        {
           
            int height = Math.Abs(A.Y - B.Y);
            for (int i = 0; i <= height; i++)
            {
                for (int j = 1; j <= 2 * height; j++)
                {
                    if (Math.Abs(height - j) <= i - 1)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
         ~Isosceles_Triangle()
        {

        }
    }

}
