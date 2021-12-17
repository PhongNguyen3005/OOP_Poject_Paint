using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication8
{
    class Line : Shape
    {
        public Line(Point a, Point b) : base(a, b) { this.Type = "Line"; }
        
        public Line() { this.Type = "Line"; }

        public override double Area()
        {
            return base.Area();
        }
        public override double Perimeter()
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        public override void input()
        {
            base.input();
        }
        public override void output()
        {
            base.output();
        }
        public override void Display()
        {

            if(A.X == B.X && A.Y == B.Y)
            {
                Console.WriteLine("Input same Point!!!");
                return;
            }
            for (int i = 0; i < (int)Perimeter()*2; i++)
            {
                Console.Write("─");

            }

            Console.WriteLine();
        }
        ~Line() { }
    }
}
