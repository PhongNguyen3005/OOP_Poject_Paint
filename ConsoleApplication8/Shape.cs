using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication8
{
    class Shape
    {
        private Point a;
        private Point b;
        private string type;
        public Point A
        {
            get { return a; }
            set
            {
                a = value;
            }
        }
        public Point B
        {
            get { return b; }
            set
            {
                b = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }
        public Shape(Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }
        public Shape()
        {
            this.a = new Point();
            this.b = new Point();
        }
        public virtual void input()
        {
            Console.WriteLine("Enter location of A : ");
            a.input();
            a.output();
            Console.WriteLine("Enter location of B : ");
            b.input();
            b.output();
            Console.WriteLine("--------------------------------------");
        }
        public virtual double Area() => 0;
        public virtual double Perimeter() => 0;
        public virtual void Display() { }
        public virtual void output()
        {
            Console.WriteLine("Area = " + Area());
            Console.WriteLine("Perimeter = " + Perimeter());
        }

        public Shape Moving()
        {
            int by_X;
            int by_Y;
            Console.Write("Enter length moving by X: ");
            by_X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter length moving by Y: ");
            by_Y = Convert.ToInt32(Console.ReadLine());

            a.X += by_X;
            b.X += by_X;
            a.Y += by_Y;
            b.Y += by_Y;

            return new Shape(a, b);
        }
        public void Color()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine(" > > > > > > > > List Color !!! < < < < < < < < ");
            for (int i = 0; i < colors.Length; i++)
            {
                if (i < 9)
                    Console.WriteLine($"\t+ Num: {i + 1}      -> {colors[i]}  ");
                else
                {
                    Console.WriteLine($"\t+ Num: {i + 1}     -> {colors[i]}  ");

                }
            }
            int choose;
            Console.Write("Enter Your Choose: ");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    }
                case 7:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    }
                case 8:
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                case 9:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    }
                case 10:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case 11:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case 12:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case 13:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case 14:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    }
                case 15:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }
                case 16:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                default:
                    {
                        Console.Write("Pls enter number of list: ");
                        choose = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
            }
        }
        ~Shape() { }
    }
}
