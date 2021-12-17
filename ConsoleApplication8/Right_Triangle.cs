using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Right_Triangle:Shape
    {
        public Right_Triangle(Point a, Point b): base(a,b)
        {
            this.Type = "Right_Triangle";
        }
        public Right_Triangle()
        {
            this.Type = "Right_Triangle";
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
            return ((Math.Abs(A.X - B.X) * Math.Abs(A.Y - B.Y))/ (double)2);
        }
        public override double Perimeter()
        {
            return Math.Abs(A.X - B.X) + Math.Abs(A.Y - B.Y) + Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        public override void output()
        {
            base.output();
        }
        public override void Display()
        {
           
            int height = Math.Abs(A.X - B.X);
            int width = Math.Abs(A.Y - B.Y);
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (i == j || i == height || j == 1)
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
        ~Right_Triangle()
        {

        }
    }
   
}
