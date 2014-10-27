using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle : Shape
    {
        public Rectangle(double lenght, double width)
            : base(lenght, width)
        {
        }

        public override double Area
        {
            get
            {
                return Length * Width;
            }
         
        }

        public override double Perimeter
        {
            get
              {
               return (2 * Length) + (2* Width);
              }
        }




    }
}
