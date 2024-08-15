using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    interface Shape
    {
        public double Circle(double r);
        public double Triangle(double b ,double h );
        public double Square(double w, double h);
    }
    public class CalculateArea : Shape
    {
        public double Circle(double r)
        {
            return (3.14 * r * r);
        }

        public double Square(double w, double h)
        {
            return (w * h);
        }

        public double Triangle(double b, double h)
        {
            return (0.5 * b * h);
        }
    }
}
