using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum ShapeType { Ellipse, Rectangle };



    abstract class Shape
    {

        private double _lenght;

        private double _width;

        abstract public double Perimeter
        {
            get;
        }


        abstract public double Area
        {
            get;
        }


        public double Length
        {

            get
            {
                return _lenght;
            }
            set
            {
                if (value > 0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException("Längden måste vara större än noll.");
                }
            }
        }
        public double Width
        {

            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("Bredden måste vara större än noll.");
                }
            }
        }



        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public string ToString()
        {
            return string.Format("{0, -10}{1, 10:n1}{2, 10:n1}{3, 10:n1}{4, 10:n1}", this.GetType().Name, Length, Width, Math.Round(Perimeter, 1), Math.Round(Area, 1));
        }





    }
}
