using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
            }
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() { }
        public void input()
        {
            Console.Write("Enter x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y = ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($"+ Point: ({x},{y})");
        }
        ~Point()
        {

        }
    }
}
