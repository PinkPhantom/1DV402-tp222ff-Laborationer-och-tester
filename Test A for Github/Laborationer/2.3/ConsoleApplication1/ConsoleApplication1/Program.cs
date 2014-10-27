using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static Shape CreateShape(ShapeType shapeType)
        {


            Console.Write("Ange längden: ");
            double length = ReadDoubleGreaterThanZero("");
            Console.Write("Ange Bredden: ");
            double width = ReadDoubleGreaterThanZero("");




            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    return new Ellipse(length, width);

                case ShapeType.Rectangle:
                    return new Rectangle(length, width);


                default:
                    return null;
            }

        }


        static void Main(string[] args)
        {
            ShapeType shapeType = ShapeType.Ellipse;
            
            do
            {
                
                ViewMenu();
                
                try
                {


                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 0:
                            return;

                        case 1:
                            shapeType = ShapeType.Ellipse;
                            break;

                        case 2:
                            shapeType = ShapeType.Rectangle;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nFEL! Ange ett nummer mellan 0 och 2");
                            Console.ResetColor();
                            continue;
                    }
                    Console.Clear();
                    ViewShapeDetail(CreateShape(shapeType));

                }
                catch (Exception)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Ange ett nummer mellan 0 och 2");
                    Console.ResetColor();


                }
            } while (true);

        }

        static double ReadDoubleGreaterThanZero(string prompt)
        {
            while (true)
            {
                try
                {

                    double variable = double.Parse(Console.ReadLine());

                    if (variable >= 0)
                    {
                        return variable;
                    }

                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fel! Ange ett tal större än 0");
                    Console.ResetColor();

                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fel! Ange ett tal större än 0");
                    Console.ResetColor();
                }
            }
        }


        static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=================================================");
            Console.WriteLine("=                                               =");
            Console.WriteLine("=             Geometriska Figurer               =");
            Console.WriteLine("=                                               =");
            Console.WriteLine("=================================================");
            Console.ResetColor();
            Console.WriteLine("=================================================");
            Console.WriteLine("=                                               =");
            Console.WriteLine("=     0. Avsluta                                =");
            Console.WriteLine("=     1. Ellipse                                =");
            Console.WriteLine("=     2. Rektangel                              =");
            Console.WriteLine("=                                               =");
            Console.WriteLine("=================================================");



        }

        static void ViewShapeDetail(Shape shape)
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=================================================");
            Console.WriteLine("=                                               =");
            Console.WriteLine("=             Detaljer                          =");
            Console.WriteLine("=                                               =");
            Console.WriteLine("=================================================");
            Console.ResetColor();
            Console.WriteLine("=================================================");
            Console.WriteLine(shape.ToString());
            Console.WriteLine("\n");

        }


    }
}