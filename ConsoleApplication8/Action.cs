using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Action
    {
        private List<Shape> lShape;
        public List<Shape> List_Shape
        {
            get { return lShape; }
            set
            {
                this.lShape = value;
            }
        }
        private Action(List<Shape> lShape)
        {
            this.lShape = new List<Shape>();
        }
        public Action()
        {
            this.lShape = new List<Shape>();
        }
        public void Delete_Shape(int index)
        {
            lShape.RemoveAt(index);
        }
        public Shape Merge(Shape s1, Shape s2)
        {
            if(s1.Type == "Isosceles_Triangle" && s2.Type == "Isosceles_Triangle")
            {
                //hợp thành hình thoi
                double widthS1 = Math.Abs(s1.A.X - s1.B.X);
                double widthS2 = Math.Abs(s2.A.X - s2.B.X);
                double heightS1 = Math.Abs(s2.A.Y - s2.B.Y);
                if (widthS1 == widthS2)
                {
                    Point tempA = new Point(0, 0);
                    Point tempB = new Point((int)widthS1 * 2, (int)heightS1 * 2);
                    Rhombus s = new Rhombus(tempA, tempB);
                    return s;
                }
            }
            if (s1.Type == "Right_Triangle" && s2.Type == "Right_Triangle")
            {
                // hợp thành hình chữ nhật
               double widthS1 = Math.Sqrt(Math.Pow(s1.A.X - s1.B.X, 2) + Math.Pow(s1.A.Y - s1.B.Y, 2));
               double widthS2 = Math.Sqrt(Math.Pow(s2.A.X - s2.B.X, 2) + Math.Pow(s2.A.Y - s2.B.Y, 2));

                if (widthS1 == widthS2)
                {
                    Rectangle s = new Rectangle(s1.A, s1.B);
                    return s;
                }
                
            }
            if (s1.Type == "Square" && s2.Type == "Square")
            {
                // hợp thành hình chữ nhật
                double widthS1 = Math.Abs(s1.A.X - s1.B.X);
                double widthS2 = Math.Abs(s2.A.X - s2.B.X);

                if (widthS1 == widthS2)
                {
                    Point tempA = new Point(0, 0);
                    Point tempB = new Point((int)widthS1 * 2, (int)widthS1);
                    Rectangle s = new Rectangle(s1.A, s1.B);
                    return s;
                }

            }
            return new Shape();
        }
        public void Un_Merge(Shape s1)
        {
            if (s1.Type == "Isosceles_Triangle")
            {
                //tách ra tam giác vuông
                Right_Triangle s = new Right_Triangle(s1.A, s1.B);
                lShape.Add(s);
                lShape.Add(s);
            }
            else if (s1.Type == "Square")
            {
                // tách ra hình chữ nhật
                double widthS1 = Math.Abs(s1.A.X - s1.B.X);
                Point tempA = new Point(0, 0);
                Point tempB = new Point((int)widthS1 / 2, (int)widthS1);
                Rectangle s = new Rectangle(tempA, tempB);
                lShape.Add(s);
                lShape.Add(s);
            }
            else if(s1.Type == "Rectangle")
            {
                //tách ra tam giác vuông
                Right_Triangle s = new Right_Triangle(s1.A, s1.B);
                lShape.Add(s);
                lShape.Add(s);
            }
            else if (s1.Type == "Rhombus")
            {
                //tách ra tam giác cân
                double heightS1 = Math.Abs(s1.A.Y - s1.B.Y);
                double widthS1 = Math.Abs(s1.A.X - s1.B.X);
                Point tempA = new Point(0, 0);
                Point tempB = new Point((int)widthS1 / 2, (int)heightS1 / 2);
                Isosceles_Triangle s = new Isosceles_Triangle(tempA, tempB);
                lShape.Add(s);
                lShape.Add(s);
            }
            else
            {
                Console.WriteLine("This shape cannot unmerge!!!");
            }
        }

        public void Running()
        {
            Console.Title = "Simple PAINT SHAPE !!!";
            int choose;
            do
            {
                Console.WriteLine(" ============ Pls Choose Another One ============");
                Console.WriteLine(" 0.         EXIT");
                Console.WriteLine(" 1.         CREAT SHAPE");
                Console.WriteLine(" 2.         ACTION");
                Console.WriteLine(" ============================================");
                Console.Write("Your choose: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            int c = 0;
                            do
                            {
                                Console.WriteLine(" *** *** *** List Shape *** *** *** ");
                                Console.WriteLine(" 1    ->       Line");
                                Console.WriteLine(" 2    ->       Circle");
                                Console.WriteLine(" 3    ->       Recangle");
                                Console.WriteLine(" 4    ->       Square");
                                Console.WriteLine(" 5    ->       Isosceles_Triangle");
                                Console.WriteLine(" 6    ->       Right_Triangle");
                                Console.WriteLine(" 7    ->       Rhombus");
                                Console.WriteLine(" 8    ->       Exit.");
                                Console.WriteLine(" ------------------------------------ ");
                                Console.Write("Your choose: ");
                                c = Convert.ToInt32(Console.ReadLine());
                                switch (c)
                                {
                                    case 1:
                                        {
                                            Shape s = new Line();
                                            s.input();
                                            lShape.Add(s);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Shape s = new Circle();
                                            s.input();
                                            lShape.Add(s);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Shape s = new Rectangle();
                                            s.input();
                                            lShape.Add(s);
                                            break;
                                        }
                                    case 4:
                                        {
                                            Shape s = new Square();
                                            s.input();
                                            lShape.Add(s);
                                            break;
                                        }
                                    case 5:
                                        {
                                            Shape s = new Isosceles_Triangle();
                                            s.input();
                                            lShape.Add(s);
                                            break;
                                        }
                                    case 6:
                                        {
                                            Shape s = new Right_Triangle();
                                            s.input();
                                            lShape.Add(s);
                                            break;
                                        }
                                    case 7:
                                        {
                                            Shape s = new Rhombus();
                                            s.input();
                                            lShape.Add(s);
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.WriteLine("------------------------------------");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("\t \n !!! INCORRECT !!!, \n");
                                            break;
                                        }
                                }
                            } while (c != 8);
                            break;
                        }
                    case 2:
                        {
                            int l;
                            do
                            {
                                Console.WriteLine(" *** *** *** List Shape *** *** *** ");
                                Console.WriteLine(" 1. Area and Perimeter");
                                Console.WriteLine(" 2. Moving");
                                Console.WriteLine(" 3. Merge Shape");
                                Console.WriteLine(" 4. UnMerge Shape");
                                Console.WriteLine(" 5. Change Color");
                                Console.WriteLine(" 6. Display Shape");
                                Console.WriteLine(" 7. EXIT.");
                                Console.WriteLine(" ------------------------------------- ");
                                Console.Write("Your choose: ");
                                l = Convert.ToInt32(Console.ReadLine());
                                int vt = 0;
                                if (l != 7 && l != 6)
                                {
                                    Console.Write($"Enter number of Shape (1-> {lShape.Count}): ");
                                    vt = Convert.ToInt32(Console.ReadLine()) - 1;
                                    while (vt < 0 || vt > lShape.Count)
                                    {
                                        Console.Write("Pls enter number of list shape: ");
                                        vt = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                }
                                switch (l)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine(" ------------ POINT ------------ ");
                                            lShape[vt].A.output();
                                            lShape[vt].B.output();
                                            Console.WriteLine(" \n------------ Area and Perimeter ------------ ");
                                            lShape[vt].output();
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Shape s = lShape[vt].Moving();
                                            Console.WriteLine("\n > > > > > > Location of Point after moving < < < < < < ");
                                            Console.WriteLine($"\t + Point A: ({s.A.X},{s.A.Y})");
                                            Console.WriteLine($"\t + Point B : ({s.B.X},{s.B.Y})");
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            int vt_1;
                                            Console.Write($"Enter number of shape to merge (1-> {lShape.Count}): ");
                                            vt_1 = Convert.ToInt32(Console.ReadLine()) - 1;
                                            while (vt_1 < 0 || vt_1 > lShape.Count || vt_1 == vt)
                                            {
                                                Console.Write("Enter number of list shape: ");
                                                vt_1 = Convert.ToInt32(Console.ReadLine()) - 1;
                                            }
                                            Shape s = new Shape();
                                            s = Merge(lShape[vt], lShape[vt_1]);
                                            lShape.Add(s);
                                            Delete_Shape(vt);
                                            Delete_Shape(vt_1);
                                            Console.WriteLine();
                                            Console.WriteLine("New Shape");
                                            s.Display();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Un_Merge(lShape[vt]);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 5:
                                        {
                                            lShape[vt].Color();
                                            Console.WriteLine(" > > > > > > > > After Change Color < < < < < < < < ");
                                            lShape[vt].Display();
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 6:
                                        {
                                            for (int i = 0; i < lShape.Count; i++)
                                            {
                                                lShape[i].Display();
                                                Console.WriteLine();
                                            }
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.WriteLine("------------------------------------");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Write(" \t !!! Enter again !!!\n ");
                                            break;
                                        }
                                }
                            } while (l != 7);
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("\n ============== END ==============");
                            break;
                        }
                    default:
                        {
                            Console.Write("ERROR !!!, ");
                            break;
                        }

                }

            } while (choose != 0);
        }
    }
}
