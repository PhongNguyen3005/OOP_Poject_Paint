using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Rectangle:Shape
    {
        public Rectangle(Point a, Point b): base(a,b)
        {
            this.Type = "Rectangle";
        }
        public Rectangle()
        {
            this.Type = "Rectangle";
        }
        public override double Area()
        {
            return Math.Abs(A.X - B.X) * Math.Abs(A.Y - B.Y);
        }
        public override double Perimeter()
        {
            return Math.Abs(A.X - B.X) * 2 + Math.Abs(A.Y - B.Y) * 2;
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


            
            int height = Math.Abs(A.X - B.X);
            int width = Math.Abs(A.Y - B.Y);
            Console.WriteLine(height);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j == 0 )
                    {
                        Console.Write("╔");
                    }
                    else if (i==height-1 && j ==0)
                    {
                        Console.Write("╚");
                    }
                    else if (i == 0 && j == width-1)
                    {
                        Console.Write("╗");
                    }
                    else if(i== height-1 && j==width-1)
                    {
                        Console.Write("╝");
                    }
                    else if(i == 0 && j !=0|| i == height-1 && j!= 0)
                    {
                        Console.Write("═══");
                    }
                    else if(j==0 && i !=0 && i!= height-1 )
                    {
                        Console.Write("║");
                    }
                    else if(j == width - 1 && i != 0 && i != height - 1)
                    {
                        Console.Write("║");
                    }
                        else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
        ~Rectangle() { }
    }

    
}
