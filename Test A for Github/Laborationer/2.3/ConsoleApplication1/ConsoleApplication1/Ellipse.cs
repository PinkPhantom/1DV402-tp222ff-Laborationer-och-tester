using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ellipse : Shape
    {
        public Ellipse(double lenght, double width)
            : base (lenght, width)
        {

        }

        public override double Area
        {
            get
            {
                return Math.PI * (Length / 2) * (Width / 2);
            }
        }

        public override double Perimeter
        {
            get
            {
                return Math.PI * Math.Sqrt(Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2);
            }
        }

    }
}
